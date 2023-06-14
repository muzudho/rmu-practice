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
        json_str = json.dumps(document, indent=4)
        print(f"dump={json_str}")

        # 解析
        parse_member(document, "")


def parse_member(node, indent):
    """パースの容易性から、 OrderedMap を想定したアルゴリズムにする
    """

    print(f"{indent}解析 type(node): {type(node)}")
    print(f"{indent}解析 len(node): {len(node)}")

    num = 1

    for key, value in node.items():
        print(f"{indent}({num})解析 key: {key}, value: {value}")

        if key == "$schema":
            print(f"{indent}$schema: {value}")

        elif key == "$id":
            print(f"{indent}$id: {value}")

        elif key == "type":
            buffer_type = value

        elif key == "default":
            buffer_default = value

        elif key == "title":
            buffer_title = value

        elif key == "items":
            if buffer_type == "array":
                # 配列のメンバー
                print(f"{indent}array items title: {buffer_title}, default: {buffer_default}, type(value): {type(value)}")

                if isinstance(value, dict):
                    print(f"{indent}解析開始 辞書 key: {key}, value: {value}, type(value): {type(value)}")
                    parse_member(value, f"{indent}    ")
                    print(f"{indent}解析終了")
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
                parse_member(value, f"{indent}    ")

        else:
            print(f"{indent}■key: [{key}]")
            print(f"{indent} type(value): {type(value)}")

            if isinstance(value, dict):
                parse_member(value, f"{indent}    ")

        num = num + 1

def parse_items(node, indent):
    for key, value in node.items():
        print(f"{indent}■[items]key: [{key}]")
        print(f"{indent} [items]type(value): {type(value)}")


if __name__ == '__main__':
    main()
