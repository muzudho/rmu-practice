import re

def main():
    file_to_read = "./temp/input.txt"
    file_to_write = "./temp/output.txt"

    re_end_br = re.compile("<br/>")
    lines = []

    #
    # ファイル読込
    # ===========
    #
    # 📖 [［Python入門］ファイル操作の基本](https://atmarkit.itmedia.co.jp/ait/articles/1909/17/news030_2.html)
    # 📖 [【Python】ファイル読み込み【1行、全行、リスト】](https://max999blog.com/python-file-read-readline-readlines/)
    #
    with open(file_to_read, 'r', encoding="utf-8-sig") as f:
        print(f"Read text file to {file_to_read}")
        # 改行コードは省く
        lines = f.read().split('\n')

    #
    # 行末に<br/>を付ける
    # =================
    #
    # - 行末に既に<br/>が付いている間は付けない
    #
    text = ""
    for line in lines:
        if not re_end_br.search(line):
            text += f"{line}<br/>\n"

    #
    # ファイルを保存
    # ============
    #
    with open(file_to_write, 'w', encoding='utf-8-sig') as f:
        print(f"Write text file to {file_to_write}")
        f.write(text)


if __name__ == '__main__':
    main()
