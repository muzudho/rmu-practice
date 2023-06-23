import os

def do_it(directory, extension):
    """
    Parameters
    ==========

    extension : str
        Example: ".wlt"
    """

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

        if basename.endswith(extension):
            result_list.append(file_entry_path)

        elif os.path.isdir(file_entry_path):
            result_list.extend(
                do_it(file_entry_path, extension)
            )

    return result_list
