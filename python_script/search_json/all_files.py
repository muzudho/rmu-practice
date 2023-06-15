import argparse
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
    parser.add_argument("--directory")

    # コマンドライン引数解析
    args = parser.parse_args()

    # 定義したものを参照できる
    print(f"""Arguments
=========

args.directory : {args.directory}
""")

    directory_to_read = args.directory

    print("Please wait")
    result_list = search_member(directory_to_read)

    for json_file in result_list:
        print(f"result: {json_file}")


def search_member(directory):

    #
    # リスト
    # =====
    #
    # 📖 [How To add Elements to a List in Python](https://www.digitalocean.com/community/tutorials/python-add-to-list)
    #
    result_list = []

    #
    # ディレクトリー内のファイル一覧を取得
    # ===============================
    #
    # 📖 [Python – List Files in a Directory](https://www.geeksforgeeks.org/python-list-files-in-a-directory/)
    #

    file_entry_in_dir = os.listdir(directory)
    # print(f"file_entry_in_dir: {file_entry_in_dir}")

    for basename in file_entry_in_dir:
        # フルパスに変更
        file_entry_path = os.path.join(directory,basename)
        # print(f"file_entry_path: {file_entry_path}")

        if basename.endswith(".json"):
            result_list.append(file_entry_path)
        elif os.path.isdir(file_entry_path):
            result_list.extend(
                search_member(file_entry_path)
            )

    return result_list


if __name__ == '__main__':
    main()
