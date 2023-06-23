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
    parser.add_argument("--read_directory")
    parser.add_argument("--write_file")

    # コマンドライン引数解析
    args = parser.parse_args()

    # 定義したものを参照できる
    print(f"""Arguments
=========

args.read_directory : {args.read_directory}
args.write_file : {args.write_file}
""")

    directory_to_read = args.read_directory
    file_to_write = args.write_file

    print("Please wait")
    result_list = search_member(directory_to_read)

    # ファイル書出し
    text = ""

    for target_file in result_list:
        text += f"{target_file}\n"
        # print(f"result: {target_file}")

    with open(file_to_write, 'w', encoding='utf-8-sig') as f:
        print(f"Write text file to {file_to_write}")
        f.write(text)



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
        file_entry_path = os.path.join(directory,basename).replace("\\","/")
        # print(f"file_entry_path: {file_entry_path}")

        if basename.endswith(".png"):
            result_list.append(file_entry_path)
        elif os.path.isdir(file_entry_path):
            result_list.extend(
                search_member(file_entry_path)
            )

    return result_list


if __name__ == '__main__':
    main()
