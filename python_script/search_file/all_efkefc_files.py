import argparse
import os
from search_member import do_it as search_member

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
    result_list = search_member(directory_to_read, ".efkefc")

    # ファイル書出し
    text = ""

    for target_file in result_list:
        text += f"{target_file}\n"
        # print(f"result: {target_file}")

    with open(file_to_write, 'w', encoding='utf-8-sig') as f:
        print(f"Write text file to {file_to_write}")
        f.write(text)


if __name__ == '__main__':
    main()
