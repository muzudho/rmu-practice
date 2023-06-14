import argparse
import os
from by_file import do_it as do_it_by_file

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

    directory_to_read = args.read
    directory_to_save = args.write

    #
    # 実行
    # ===
    #
    do_it(directory_to_read, directory_to_save)


def do_it(directory_to_read, directory_to_save):

    #
    # ディレクトリー内のファイル一覧を取得
    # ===============================
    #
    # 📖 [Python – List Files in a Directory](https://www.geeksforgeeks.org/python-list-files-in-a-directory/)
    #

    file_entry_in_dir = os.listdir(directory_to_read)

#     print(f"""Paths
# =====
# """)

    for file_entry in file_entry_in_dir:
        if file_entry.endswith(".json"):

            # 拡張子抜きのファイル名を取得
            basename_without_extension = os.path.splitext(os.path.basename(file_entry))[0]

            file_to_read = os.path.join(directory_to_read, f"{basename_without_extension}.json")
            file_to_save = os.path.join(directory_to_save, f"{basename_without_extension}.md")

            print(f"""
file_to_read: {file_to_read}
file_to_save: {file_to_save}
""")
            do_it_by_file(
                file_to_read,
                file_to_save)

if __name__ == '__main__':
    main()
