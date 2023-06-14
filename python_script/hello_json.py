import argparse
import json

def main():

    #
    # コマンドライン引数取得
    # ===================
    #
    # 📖 [pythonでコマンドライン引数を使うサンプル](https://qiita.com/stkdev/items/e262dada7b68ea91aa0c)
    #

    # まずオブジェクト生成
    parser = argparse.ArgumentParser()

    # 引数定義
    parser.add_argument("--file")

    # コマンドライン引数解析
    args = parser.parse_args()

    # 定義したものを参照できる
    print(f"arg file={args.file}")

    #
    # JSON読込
    # ========
    #
    # 📖 [【Python入門】JSON形式データの扱い方](https://qiita.com/Morio/items/7538a939cc441367070d)
    # 📖 [Pythonでファイルの読み込み、書き込み（作成・追記）](https://note.nkmk.me/python-file-io-open-with/)
    #

    with open(args.file) as f:
        # text = f.read()
        # print(text)
        # 文書構造へ変換
        document = json.load(f)

        # ダンプ
        # json_str = json.dumps(document, indent=4)
        # print(f"dump={json_str}")

        # 結果文言
        result_text = ""

        # 解析
        parent_key = "#ROOT#"
        buffer = {}
        indent = ""
        for key, value in document.items():
            """パースの容易性から、 OrderedMap を想定したアルゴリズムにする
            """
            result_text += parse_key_value_pair_for_root(key, value, indent, buffer, parent_key)

    print(f"result_text: {result_text}")

def parse_key_value_pair_for_root(key, value, indent, buffer, parent_key):
    if key == "$schema":
        return f"{indent}$schema: {value}\n"

    elif key == "$id":
        return f"{indent}$id: {value}\n"

    else:
        return parse_key_value_pair(key, value, indent, buffer, parent_key)


def parse_key_value_pair(key, value, indent, buffer, parent_key):
    # 結果文言
    result_text = ""

    if key == "type":
        buffer["type"] = value

    elif key == "default":
        buffer["default"] = value

    elif key == "title":
        buffer["title"] = value

    elif key == "items":
        if buffer["type"] == "array":
            # 配列のメンバー
            result_text += f"{indent}* 😁 `{parent_key}` array\n"
            result_text += f"{indent}    * default - ```{buffer['default']}```\n"

            if isinstance(value, dict):
                child_indent = f"{indent}    "
                child_buffer = {"default":None}
                result_text += parse_array_items_member(value, child_indent, child_buffer, key)

            else:
                result_text += f"{indent}■key: [{key}], value: {value}\n"
                result_text += f"{indent} type(value): {type(value)}\n"

        else:
            result_text += f"{indent}■key: [{key}], value: {value}\n"
            result_text += f"{indent} type(value): {type(value)}\n"

    elif key == "examples":
        result_text += f"{indent}* examples: ```{value}```\n"

        if isinstance(value, dict):
            child_indent = f"{indent}    "
            child_buffer = {}
            for child_key, child_value in value.items():
                result_text = parse_key_value_pair(child_key, child_value, indent, child_buffer, key)

    else:
        result_text += f"{indent}■key: {key}, type(value): {type(value)}\n"

        if isinstance(value, dict):
            child_indent = f"{indent}    "
            child_buffer = {"default":None}
            for child_key, child_value in value.items():
                result_text = parse_key_value_pair(child_key, child_value, child_indent, child_buffer, key)

    return result_text



def parse_array_items_member(node, indent, buffer, parent_key):
    # 結果文言
    result_text = ""

    for key, value in node.items():

        if key == "type":
            buffer["type"] = value

        elif key == "title":
            buffer["title"] = value

        elif key == "items":
            if buffer["type"] == "array":
                # 配列のメンバー
                result_text += f"{indent}* 😁 `{parent_key}` array - default: {buffer['default']}"
                result_text += f"{indent}    * default - ```{buffer['default']}```"

                if isinstance(value, dict):
                    child_indent = f"{indent}    "
                    child_buffer = {"default":None}
                    result_text += parse_array_items_member(value, child_indent, child_buffer, key)

                else:
                    result_text += f"{indent}■key: [{key}], value: {value}\n"
                    result_text += f"{indent} type(value): {type(value)}\n"

            else:
                result_text += f"{indent}■key: [{key}], value: {value}\n"
                result_text += f"{indent} type(value): {type(value)}\n"

        elif key == "required":
            result_text += f"{indent}* required - {value}\n"

        elif key == "properties":
            if isinstance(value, dict):
                # child_indent = f"{indent}    "
                child_indent = indent
                child_buffer = {}
                for child_key, child_value in value.items():
                    result_text += parse_key_value_pair_for_property(child_key, child_value, child_indent, child_buffer, key)
            else:
                result_text += f"{indent}■[array-items] properties: {value}\n"

        elif key == "examples":
            result_text += f"{indent}* examples: ```{value}```\n"

        else:
            result_text += f"{indent}■key: {key}\n"

    return result_text


def parse_key_value_pair_for_property(key, value, indent, buffer, parent_key):
    """任意のキー"""

    # 結果文言
    result_text = ""

    if isinstance(value, dict):
        # プロパティ名
        result_text += f"{indent}* 😁 `{key}` property\n"

        child_indent = f"{indent}    "
        child_buffer = {"default":None}
        result_text += parse_array_items_member(value, child_indent, child_buffer, key)

    else:
        result_text += f"{indent}■property key: {key}, value: {value} type(value): {type(value)}\n"

    return result_text


if __name__ == '__main__':
    main()
