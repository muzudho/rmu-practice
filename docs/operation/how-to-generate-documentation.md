# 文書生成

インストールするもの

* 📄 [Sandcastle Help File Builder](https://github.com/EWSoftware/SHFB)

* 📄 [Doxygen](https://www.doxygen.nl/)
    * 1. Windows版は インストーラーへのリンクがあるから、Firefox などの Webブラウザーでダウンロードする
    * 2. インストーラーを実行  
        Doxiwizard というアプリケーションがインストールされる
* 📄 [Graphviz](https://graphviz.org/)
    * 1. Windows版は インストーラーへのリンクがあるから、Firefox などの Webブラウザーでダウンロードする
    * 2. インストーラーを実行

## その前に

C# のソースコードのファイルが `Shift-JIS` でエンコーディングされている。  
`UTF-8(BOM付き)` で保存しないと、出力ファイルが文字化けする  

Visual Studio Code でファイルを１つ１つ開いて、エンコーディングを指定し直していく方法がある  
📖 [Shift JISやEUCなどからUTF-8へ変換する方法](https://codeaid.jp/blog/exchange-utf8/)

## 方法

* 📖 [Doxygenを利用して、コードコメントからドキュメントを作ろう！ Githubとの連携も出来るよ！](https://qiita.com/developer-kikikaikai/items/3984606dbdbf2bbbe74e)
* 📖 [NanoAppli.com Doxygen](http://nanoappli.com/blog/?s=doxygen)

* `doxygen.exe` が入っているディレクトリーへのパスをテキスト・ボックスへ入力する

```
# 例
C:\Program Files\doxygen\bin
```

## ソース

* Windowsのパスに対応してない？ `\` より `/` の方がいいか？  
* `.cs` ファイルが入っているディレクトリーを指定する？

```
# 例
# .cs ファイルが入っていないディレクトリーを指定してはいけない
C:/Users/むずでょ/Documents/Unity Projects/RMU-1-00-00-Research-Project/Assets/RPGMaker/Codebase/Runtime/Addon/DataModel
```

## スキャン・リカーシベリー（Scan recursively；再帰的に走査）チェックボックス

* チェックを入れる
    * 時間はかかるが仕方ない
        * 芋づる式にファイルを作りまくるので、ファイル数も膨大になる

## 出力先

```
# 例
C:\Users\むずでょ\Documents\GitHub\doc-my-rmu-1.00.00
```

## Expert/Input

どのフォルダーの下を読むかを指定

```
# 例
C:/Users/むずでょ/Documents/Unity Projects/RMU-1-00-00-Research-Project/Assets/RPGMaker/Codebase/Runtime
```

## Expert/Source Browser

* `Source_Browser` のチェックを外さないと、ソースを含めて出力されてしまう？

## Expert/Dot

Graphvis の bin フォルダーを指定する  

```
# 例
C:\Program Files\Graphviz\bin
```

# Git Hub に上げる例

📖 [namespaces.html](https://htmlpreview.github.io/?https://raw.githubusercontent.com/muzudho/RMU-1-00-00-Documentation-Project/main/html/namespaces.html)

# よくある問題

* 列挙型のメンバーに付けたコメントが出力されない  
  📖 [Doxygen not documenting enum members](https://stackoverflow.com/questions/12033713/doxygen-not-documenting-enum-members)