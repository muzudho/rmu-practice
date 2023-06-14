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
        json_str = json.dumps(document)
        print(f"dump={json_str}")

        # 解析
        parse_member(document)

def parse_member(node):
    for key, value in node.items():

        if key == "$schema":
            print(f"$schema: {value}")

        elif key == "$id":
            print(f"$id: {value}")

        else:
            print(f"■key: {value}")
            print(f" type(value): {type(value)}")

        if isinstance(value, dict):
            parse_member(value)


if __name__ == '__main__':
    main()
