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

        # 解析
        parent_key = "#ROOT#"
        buffer = {}
        indent = ""
        for key, value in document.items():
            """パースの容易性から、 OrderedMap を想定したアルゴリズムにする
            """
            parse_key_value_pair_for_root(key, value, indent, buffer, parent_key)


def parse_key_value_pair_for_root(key, value, indent, buffer, parent_key):
    if key == "$schema":
        print(f"{indent}$schema: {value}")

    elif key == "$id":
        print(f"{indent}$id: {value}")

    else:
        parse_key_value_pair(key, value, indent, buffer, parent_key)


def parse_key_value_pair(key, value, indent, buffer, parent_key):
    # print(f"{indent}解析 key: {key}, value: {value}")

    if key == "type":
        buffer["type"] = value

    elif key == "default":
        buffer["default"] = value

    elif key == "title":
        buffer["title"] = value

    elif key == "items":
        if buffer["type"] == "array":
            # 配列のメンバー
            print(f"{indent}* `{parent_key}` array - default: {buffer['default']}")
            # print(f"{indent}array items title: {buffer['title']}, default: {buffer['default']}, type(value): {type(value)}")

            if isinstance(value, dict):
                # print(f"{indent}解析開始 辞書 key: {key}, value: {value}, type(value): {type(value)}")
                child_indent = f"{indent}    "
                child_buffer = {"default":None}
                parse_array_items_member(value, child_indent, child_buffer, key)
                # 解析を抜けたときに出力
                # print(f"{indent}[{child_buffer['title']} :{child_buffer['type']}]")
                # print(f"{indent}解析終了")
            else:
                print(f"{indent}■key: [{key}], value: {value}")
                print(f"{indent} type(value): {type(value)}")

        else:
            print(f"{indent}■key: [{key}], value: {value}")
            print(f"{indent} type(value): {type(value)}")

    elif key == "examples":
        print(f"{indent}examples:")
        print(f"{indent} type(value): {type(value)}")

        if isinstance(value, dict):
            child_indent = f"{indent}    "
            child_buffer = {}
            for child_key, child_value in value.items():
                parse_key_value_pair(child_key, child_value, indent, child_buffer, key)

    else:
        print(f"{indent}■key: {key}, type(value): {type(value)}")

        if isinstance(value, dict):
            child_indent = f"{indent}    "
            child_buffer = {"default":None}
            for child_key, child_value in value.items():
                parse_key_value_pair(child_key, child_value, child_indent, child_buffer, key)




def parse_array_items_member(node, indent, buffer, parent_key):
    for key, value in node.items():
        # print(f"{indent}■[array-items]key: [{key}], type(value): {type(value)}")

        if key == "type":
            buffer["type"] = value
            # print(f"{indent}[array-items] type: {value}")

        elif key == "title":
            buffer["title"] = value
            # print(f"{indent}[array-items] title: {value}")

        elif key == "items":
            if buffer["type"] == "array":
                # 配列のメンバー
                print(f"{indent}* `{parent_key}` array - default: {buffer['default']}")
                # print(f"{indent}array items title: {buffer['title']}, default: {buffer['default']}, type(value): {type(value)}")

                if isinstance(value, dict):
                    # print(f"{indent}解析開始 辞書 key: {key}, value: {value}, type(value): {type(value)}")
                    # child_indent = f"{indent}    "
                    child_indent = indent
                    child_buffer = {"default":None}
                    parse_array_items_member(value, child_indent, child_buffer, key)
                    # 解析を抜けたときに出力
                    # print(f"{indent}[{child_buffer['title']} :{child_buffer['type']}]")
                    # print(f"{indent}解析終了")
                else:
                    print(f"{indent}■key: [{key}], value: {value}")
                    print(f"{indent} type(value): {type(value)}")

            else:
                print(f"{indent}■key: [{key}], value: {value}")
                print(f"{indent} type(value): {type(value)}")

        elif key == "required":
            print(f"{indent}[array-items] required: {value}")

        elif key == "properties":
            if isinstance(value, dict):
                child_indent = f"{indent}    "
                child_buffer = {}
                for child_key, child_value in value.items():
                    parse_key_value_pair_for_property(child_key, child_value, child_indent, child_buffer, key)
            else:
                print(f"{indent}■[array-items] properties: {value}")

        elif key == "examples":
            # print(f"{indent}[array-items] examples: {value}")
            print(f"{indent}examples: {value}")
        else:
            print(f"{indent}■key: {key}")


def parse_key_value_pair_for_property(key, value, indent, buffer, parent_key):
    """任意のキー"""


    if isinstance(value, dict):
        # プロパティ名
        print(f"{indent}[{key} property]")
        # print(f"{indent}property key: {key}, value: {value} type(value): {type(value)}")

        child_indent = f"{indent}    "
        child_buffer = {"default":None}
        parse_array_items_member(value, child_indent, child_buffer, key)
        # 解析を抜けたときに出力
        # print(f"{indent}[{child_buffer['title']} :{child_buffer['type']}]")

    else:
        print(f"{indent}■property key: {key}, value: {value} type(value): {type(value)}")



if __name__ == '__main__':
    main()
