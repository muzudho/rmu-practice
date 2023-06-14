import argparse
import json
import os

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
    parser.add_argument("--read")
    parser.add_argument("--write")

    # コマンドライン引数解析
    args = parser.parse_args()

    # 定義したものを参照できる
    print(f"""Arguments
=========

args.read : {args.read}
args.write: {args.write}
""")

    #
    # JSON読込
    # ========
    #
    # 📖 [【Python入門】JSON形式データの扱い方](https://qiita.com/Morio/items/7538a939cc441367070d)
    # 📖 [Pythonでファイルの読み込み、書き込み（作成・追記）](https://note.nkmk.me/python-file-io-open-with/)
    #

    file_to_read = args.read
    with open(file_to_read) as f:
        print(f"Read text file to {file_to_read}")
        # text = f.read()
        # print(text)
        # 文書構造へ変換
        document = json.load(f)

        # ダンプ
        # json_str = json.dumps(document, indent=4)
        # print(f"dump={json_str}")

        #
        # 結果文言
        # =======
        #
        # 📖 [Pythonでパス文字列からファイル名・フォルダ名・拡張子を取得、結合](https://note.nkmk.me/python-os-basename-dirname-split-splitext/)
        #
        basename_without_ext = os.path.splitext(os.path.basename(file_to_read))[0]
        result_text = f"# JSON schema: {basename_without_ext}\n\n"

        # 解析
        parent_key = "#ROOT#"
        buffer = {}
        indent = ""
        for key, value in document.items():
            """パースの容易性から、 OrderedMap を想定したアルゴリズムにする
            """
            result_text += parse_key_value_pair_for_root(key, value, indent, buffer, parent_key)

    # print(f"result_text: {result_text}")

    #
    # デスクトップへファイルを保存
    # ========================
    #
    # 📖 [How to get Desktop location?](https://stackoverflow.com/questions/34275782/how-to-get-desktop-location)
    #

    # desktop = os.path.join(os.path.join(os.environ['USERPROFILE']), 'Desktop') 
    # file_to_save = f'{desktop}/json-parsed.md'
    file_to_save = args.write

    with open(file_to_save, 'w', encoding='utf-8') as f:
        print(f"Write text file to {file_to_save}")
        f.write(result_text)


def parse_key_value_pair_for_root(key, value, indent, buffer, parent_key):
    if key == "$schema":
        return f"{indent}* $schema: {value}\n"

    elif key == "$id":
        return f"{indent}* $id: {value}\n"

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

        # ダンプ
        dump_text = json.dumps(value, indent=4)
        result_text += stringify_quote_in_list(dump_text, indent)

    else:
        result_text += f"{indent}■key: {key}, type(value): {type(value)}\n"

        if isinstance(value, dict):
            child_indent = f"{indent}    "
            child_buffer = {"default":None}
            for child_key, child_value in value.items():
                result_text = parse_key_value_pair(child_key, child_value, child_indent, child_buffer, key)

    return result_text

def stringify_quote_in_list(text, indent):
    """例えば、以下のように整形したい
    📖 [chbrown/gfm-multiline-quotes.md](https://gist.github.com/chbrown/03f4d637bd1f489e3d962de15db18aba#file-nested-quotes-md)

    * examples:
        >```
        >[
        >    "255,255,255",
        >    "255,119,102",
        >    "255,136,51"
        >]
        >```
    """

    # 結果文言
    result_text = ""


    temp_lines = text.splitlines()

    result_text += f"{indent}* examples:\n"
    result_text += f"{indent}    >```\n"

    for line in temp_lines:
        result_text += f"{indent}    >{line}\n"

    result_text += f"{indent}    >```\n"

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
                result_text += f"{indent}* 😁 `{parent_key}` array - default: {buffer['default']}\n"
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

            # ダンプ
            dump_text = json.dumps(value, indent=4)
            result_text += stringify_quote_in_list(dump_text, indent)

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
