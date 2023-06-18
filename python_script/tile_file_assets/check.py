import argparse
import os
from pathlib import Path
# 📖 [Python パスから拡張子なしのファイル名を取得する](https://www.delftstack.com/ja/howto/python/python-get-filename-without-extension-from-path/)

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

    # コマンドライン引数解析
    args = parser.parse_args()

    # 定義したものを参照できる
    print(f"""Arguments
=========

args.read_directory : {args.read_directory}
""")

    directory_to_read = args.read_directory

    #
    # リスト
    # =====
    #
    # 📖 [How To add Elements to a List in Python](https://www.digitalocean.com/community/tutorials/python-add-to-list)
    #
    folder_set = set()
    meta_set = set()
    asset_set = set()
    asset_meta_set = set()
    others_set = set()

    #
    # ディレクトリー内のファイル一覧を取得
    # ===============================
    #
    # 📖 [Python – List Files in a Directory](https://www.geeksforgeeks.org/python-list-files-in-a-directory/)
    #

    file_entry_in_dir = os.listdir(directory_to_read)
    # print(f"file_entry_in_dir: {file_entry_in_dir}")

    for basename in file_entry_in_dir:
        # フルパスに変更
        file_entry_path = os.path.join(directory_to_read,basename).replace("\\","/")
        # print(f"file_entry_path: {file_entry_path}")

        if os.path.isdir(file_entry_path):
            folder_set.add(basename)

        # 先
        elif basename.endswith(".asset.meta"):
            asset_meta_set.add(Path(Path(basename).stem).stem)

        # 後
        elif basename.endswith(".asset"):
            asset_set.add(Path(basename).stem)

        # 最後
        elif basename.endswith(".meta"):
            meta_set.add(Path(basename).stem)

        else:
            others_set.add(basename)

    #
    # 愚直に共通項を消していく
    # ====================
    #
    # 📖 [Python でセットから要素を削除する](https://www.delftstack.com/ja/howto/python/python-remove-element-from-set/)
    #
    deletes_list = []

    for stem in folder_set:
        if stem in meta_set and stem in asset_set and stem in asset_meta_set:
            deletes_list.append(stem)

    for stem in deletes_list:
        folder_set.remove(stem)
        meta_set.remove(stem)
        asset_set.remove(stem)
        asset_meta_set.remove(stem)

    deletes_list.clear()

    for stem in meta_set:
        if stem in folder_set and stem in asset_set and stem in asset_meta_set:
            deletes_list.append(stem)

    for stem in deletes_list:
        folder_set.remove(stem)
        meta_set.remove(stem)
        asset_set.remove(stem)
        asset_meta_set.remove(stem)

    deletes_list.clear()

    for stem in asset_set:
        if stem in folder_set and stem in meta_set and stem in asset_meta_set:
            deletes_list.append(stem)

    for stem in deletes_list:
        folder_set.remove(stem)
        meta_set.remove(stem)
        asset_set.remove(stem)
        asset_meta_set.remove(stem)

    deletes_list.clear()

    for stem in asset_meta_set:
        if stem in folder_set and stem in meta_set and stem in asset_set:
            deletes_list.append(stem)

    for stem in deletes_list:
        folder_set.remove(stem)
        meta_set.remove(stem)
        asset_set.remove(stem)
        asset_meta_set.remove(stem)

    deletes_list.clear()

    #
    # 残った物を表示
    # ====================
    #

    print("""
Remain folder
=============
""")
    for stem in folder_set:
        print(f"folder: {stem}")

    print("""
Meta file
=========
""")
    for stem in meta_set:
        print(f"meta: {stem}")

    print("""
Asset file
==========
""")
    for stem in asset_set:
        print(f"asset: {stem}")

    print("""
Asset meta file
===============
""")
    for stem in asset_meta_set:
        print(f"asset meta: {stem}")

    print("""
Others file
===========
""")
    for stem in others_set:
        print(f"others: {stem}")


if __name__ == '__main__':
    main()
