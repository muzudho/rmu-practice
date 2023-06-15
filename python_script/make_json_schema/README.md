# Python script

👇 １ファイルずつ:  

```shell
cd python_script/make_json_schema

python by_file.py --read "C:/Users/むずでょ/Documents/GitHub/rpg-maker-unite-practice/data/json/Assets RPGMaker Storage Addon Resources addonInfos.json" --write "C:/Users/むずでょ/Documents/GitHub/rpg-maker-unite-practice/data/json-schema/Assets RPGMaker Storage Addon Resources addonInfos.md"

python by_file.py --read "C:/Users/むずでょ/Documents/GitHub/rpg-maker-unite-practice/data/json/Assets RPGMaker Storage Animation JSON animation.json" --write "C:/Users/むずでょ/Documents/GitHub/rpg-maker-unite-practice/data/json-schema/Assets RPGMaker Storage Animation JSON animation.md"
```

👇 ディレクトリー毎:  

```shell
cd python_script/make_json_schema

python by_directory.py --read "C:/Users/むずでょ/Documents/GitHub/rpg-maker-unite-practice/data/json/" --write "C:/Users/むずでょ/Documents/GitHub/rpg-maker-unite-practice/data/json-schema/"
```
