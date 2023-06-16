# Doc edit

## Append br

temp/input.txt ファイルの全ての行の末尾に <br/> を付けたものを temp/output.txt ファイルに書き出す。  
temp ディレクトリーは git でコミットしないように .gitignore ファイルで指定する  

既に末尾に <br> が付いている行には付けない  

```shell
cd python_script/doc_edit

python append_br.py
```

## HTML indent

HTML では半角スペースのインデントが無視されて　テキストが左端揃えになることがある。  
そこで　左端の半角スペースを `&nbsp;` に置き換える  

使い方は `Append br` 参照  

```shell
cd python_script/doc_edit

python html_indent.py
```
