# JSON 調査

ソースコードに書かれている JSON ファイルを適当に検索してみる

```
JSON_ASSETS	                = "Assets/RPGMaker/Storage/AssetManage/JSON/Assets/"	            \r\n    😁 JSONアセット・フォルダーへのパス\r\n
    * Assets RPGMaker Storage AssetManage JSON assetsData.json      - 解析失敗
    * Assets RPGMaker Storage AssetManage JSON orderManager.json
JSON_PATH_ANIMATION	        = "Assets/RPGMaker/Storage/Animation/JSON/animation.json"	        \r\n    😁 アニメーションのJSONファイルへのパス\r\n\r\n（※翻訳者追記）ファイル・パスをハードコーディングしたら拡張性無いのでは？（※翻訳者追記）１つの辞書にキー・バリュー・ペア形式で全部入れたらどうか？ 外部ファイルやデータベースにしないの？ ユニティの作法知らんけど（※翻訳者追記）オブジェクト指向になってない。アニメーション・クラスのように **オブジェクト** 毎にクラスを作って、そのクラスがファイルパスを持つべきでは？
    * Assets RPGMaker Storage Animation JSON animation.json         - 解析失敗
JSON_PATH_ARMOR	            = "Assets/RPGMaker/Storage/Initializations/JSON/armor.json"	        \r\n    😁 防具のJSONファイルへのパス\r\n
    * Assets RPGMaker Storage Initializations JSON armor.json       - 解析失敗
    * Assets RPGMaker Storage Initializations JSON autoGuide.json
    * Assets RPGMaker Storage Initializations JSON skill.json
    * Assets RPGMaker Storage Initializations JSON skillCustom.json     - 解析失敗
    * Assets RPGMaker Storage Initializations JSON state.json
    * Assets RPGMaker Storage Initializations JSON stateTest.json
    * Assets RPGMaker Storage Initializations JSON system.json
    * Assets RPGMaker Storage Initializations JSON title.json
    * Assets RPGMaker Storage Initializations JSON weapon.json          - 解析失敗
    * Assets RPGMaker Storage Initializations JSON weaponTest.json
JSON_PATH_ASSETMANAGE	    = "Assets/RPGMaker/Storage/AssetManage/JSON"	                    \r\n    😁 資産管理JSONフォルダーへのパス\r\n
    * 既出
JSON_PATH_ASSETMANAGE_DATA	= "Assets/RPGMaker/Storage/AssetManage/JSON/assetsData.json"	    \r\n    😁 アセット・データのJSONファイルへのパス\r\n
    * 既出
JSON_PATH_AUTOGUID	        = "Assets/RPGMaker/Storage/Initializations/JSON/autoGuide.json"	    \r\n    😁 自動ガイドのJSONファイルへのパス\r\n
    * 既出
JSON_PATH_CHARACTERACTOR	= "Assets/RPGMaker/Storage/Character/JSON/characterActor.json"	    \r\n    😁 キャラクター・アクターのJSONファイルへのパス\r\n
    * Assets RPGMaker Storage Character JSON characterActor.json
    * Assets RPGMaker Storage Character JSON class.json                 - 解析失敗
    * Assets RPGMaker Storage Character JSON enemy.json                 - 解析失敗
    * Assets RPGMaker Storage Character JSON troop.json                 - 解析失敗
    * Assets RPGMaker Storage Character JSON vehicles.json
JSON_PATH_CLASS	            = "Assets/RPGMaker/Storage/Character/JSON/class.json"	            \r\n    😁 クラスのJSONファイルへのパス\r\n
    * 既出
JSON_PATH_ENCOUNTER	        = "Assets/RPGMaker/Storage/Encounter/JSON/encounter.json"	        \r\n    😁 遭遇のJSONファイルへのパス\r\n
    * Assets RPGMaker Storage Encounter JSON encounter.json             - 解析失敗
JSON_PATH_ENEMY	            = "Assets/RPGMaker/Storage/Character/JSON/enemy.json"	            \r\n    😁 敵のJSONファイルへのパス\r\n
    * 既出
JSON_PATH_FLAGS	            = "Assets/RPGMaker/Storage/Flags/JSON/flags.json"	                \r\n    😁 フラグのJSONファイルへのパス\r\n
    * Assets RPGMaker Storage Flags JSON flags.json
JSON_PATH_ITEM	            = "Assets/RPGMaker/Storage/Item/JSON/item.json"	                    \r\n    😁 アイテムのJSONファイルへのパス\r\n
    * Assets RPGMaker Storage Item JSON item.json                       - 解析失敗
JSON_PATH_SKILL	            = "Assets/RPGMaker/Storage/Initializations/JSON/skill.json"	        \r\n    😁 スキルのJSONファイルへのパス\r\n
    * 既出
JSON_PATH_SKILLCUSTOM	    = "Assets/RPGMaker/Storage/Initializations/JSON/skillCustom.json"	\r\n    😁 スキル・カスタムのJSONファイルへのパス\r\n
    * 既出
JSON_PATH_STATE	            = "Assets/RPGMaker/Storage/Initializations/JSON/state.json"	        \r\n    😁 状態のJSONファイルへのパス\r\n
    * 既出
JSON_PATH_SYSTEM	        = "Assets/RPGMaker/Storage/Initializations/JSON/system.json"	    \r\n    😁 システムのJSONファイルへのパス\r\n
    * 既出
JSON_PATH_TITLE	            = "Assets/RPGMaker/Storage/Initializations/JSON/title.json"	        \r\n    😁 タイトルのJSONファイルへのパス\r\n
    * 既出
JSON_PATH_TROOP	            = "Assets/RPGMaker/Storage/Character/JSON/troop.json"	            \r\n    😁 部隊のJSONファイルへのパス\r\n
    * 既出
JSON_PATH_UI	            = "Assets/RPGMaker/Storage/Ui/JSON/ui.json"	                        \r\n    😁 ユーザー・インターフェースのJSONファイルへのパス\r\n
JSON_PATH_VEHICLES	        = "Assets/RPGMaker/Storage/Character/JSON/vehicles.json"	        \r\n    😁 乗り物のJSONファイルへのパス\r\n
    * 既出
JSON_PATH_WEAPON	        = "Assets/RPGMaker/Storage/Initializations/JSON/weapon.json"	    \r\n    😁 武器のJSONファイルへのパス\r\n
    * 既出
JSON_PATH_WORDS	            = "Assets/RPGMaker/Storage/Word/JSON/words.json"	                \r\n    😁 単語のJSONファイルへのパス\r\n
JSON_PATH_MAPBASE	        = "Assets/RPGMaker/Storage/Map/JSON/mapbase.json"	                \r\n    😁 マップ・ベースのJSONファイルへのパス\r\n
JSON_PATH_EVENT	            = "Assets/RPGMaker/Storage/Event/JSON/Event"	                    \r\n    😁 JSONフォルダーのイベント・ディレクトリーへのパス\r\n
JSON_PATH_EVENTMAP	        = "Assets/RPGMaker/Storage/Event/JSON/eventMap.json"	            \r\n    😁 イベント・マップのJSONファイルへのパス\r\n
JSON_PATH_EVENTCOMMON	    = "Assets/RPGMaker/Storage/Event/JSON/eventCommon.json"	            \r\n    😁 イベント共通のJSONファイルへのパス\r\n
JSON_PATH_EVENTBATTLE	    = "Assets/RPGMaker/Storage/Event/JSON/eventBattle.json"	            \r\n    😁 イベント戦闘のJSONファイルへのパス\r\n
JSON_PATH_MAP	            = "Assets/RPGMaker/Storage/Map/JSON/Map"	                        \r\n    😁 JSONフォルダーのマップ・ディレクトリーへのパス\r\n
JSON_PATH_BGM_LOOP	        = "Assets/RPGMaker/Storage/Sounds/bgmLoopInfo.json"	                \r\n    😁 背景音楽ループ情報のJSONファイルへのパス\r\n
JSON_PATH_BGS_LOOP	        = "Assets/RPGMaker/Storage/Sounds/bgsLoopInfo.json"	                \r\n    😁 環境音ループ情報のJSONファイルへのパス\r\n
JSON_PATH	                = "Assets/RPGMaker/Storage/AssetManage/JSON"	                    \r\n    😁 資産管理JSONフォルダーへのパス\r\n
    * 既出
JSON_NAME	                = "/orderManager.json"	                                            \r\n    😁 JSONファイル名\r\n
JSON_PATH	                = "Assets/RPGMaker/Storage/Flags/JSON/flags.json"	                \r\n    😁 フラグJSONファイルへのパス\r\n
    * 既出
JsonPath	                = "Assets/RPGMaker/Storage/Initializations/JSON/system.json"	    \r\n    😁 システムJSONファイルへのパス\r\n
    * 既出
JsonPath	                = "Assets/RPGMaker/Storage/Initializations/JSON/title.json"	        \r\n    😁 タイトルJSONファイルへのパス\r\n
    * 既出
JsonPath	                = "Assets/RPGMaker/Storage/Ui/JSON/ui.json"	                        \r\n    😁 ユーザー・インターフェースJSONファイルへのパス\r\n
JSON_PATH	                = "Assets/RPGMaker/Storage/Word/JSON/words.json"	                \r\n    😁 単語JSONファイルへのパス\r\n
JsonPath	                = "Assets/RPGMaker/Storage/Event/JSON/eventBattle.json"	            \r\n    😁 イベント戦闘JSONファイルへのパス\r\n
JsonPath	                = "Assets/RPGMaker/Storage/Event/JSON/eventCommon.json"	            \r\n    😁 ファイルパス　＞　イベント共通JSON\r\n
JsonFile	                = "Assets/RPGMaker/Storage/Event/JSON/eventMap.json"	            \r\n    😁 イベント・マップJSONファイルへのパス\r\n
JsonPath	                = "Assets/RPGMaker/Storage/Event/JSON/Event/"	                    \r\n    😁 イベントJSONフォルダーへのパス\r\n
OldJsonPath	                = "Assets/RPGMaker/Storage/Event/JSON/event.json"	                \r\n    😁 古いイベントJSONファイルへのパス\r\n
JsonFile	                = "Assets/RPGMaker/Storage/Map/JSON/Map/"	                        \r\n    😁 マップJSONフォルダーへのパス\r\n
JsonBaseFile	            = "Assets/RPGMaker/Storage/Map/JSON/mapbase.json"	                \r\n    😁 マップ・ベースJSONファイルへのパス\r\n
OldJsonFile	                = "Assets/RPGMaker/Storage/Map/JSON/map.json"	                    \r\n    😁 古いマップJSONファイルへのパス\r\n
JsonFileTranslation	        = "Assets/RPGMaker/Storage/Map/JSON/mapname.json"	                \r\n    😁 マップの翻訳JSONファイルへのパス\r\n
JsonFileSample	            = "Assets/RPGMaker/Storage/Map/JSON/MapSample/"	                    \r\n    😁 マップ・サンプルJSONフォルダーへのパス\r\n
OldJsonFileSample	        = "Assets/RPGMaker/Storage/Map/JSON/mapSample.json"	                \r\n    😁 古いマップ・サンプルJSONファイルへのパス\r\n
JsonFile	                = "Assets/RPGMaker/Storage/Map/JSON/tileGroup.json"	                \r\n    😁 タイル・グループJSONファイルへのパス\r\n
JsonDirOfMap	            = "Assets/RPGMaker/Storage/Map/JSON/Map"	                        \r\n    😁 マップJSONマップ・ディレクトリーへのパス\r\n
JsonFileOfStart	            = "Assets/RPGMaker/Storage/Outline/start.json"	                    \r\n    😁 開始JSONファイルへのパス\r\n
JsonFileOfChapter	        = "Assets/RPGMaker/Storage/Outline/chapter.json"	                \r\n    😁 章JSONファイルへのパス\r\n
JsonFileOfSection	        = "Assets/RPGMaker/Storage/Outline/section.json"	                \r\n    😁 区画JSONファイルへのパス\r\n
JsonFileOfConnection	    = "Assets/RPGMaker/Storage/Outline/connection.json"	                \r\n    😁 接続JSONファイルへのパス\r\n
JsonFileOfMap	            = "Assets/RPGMaker/Storage/Map/JSON/Map"	                        \r\n    😁 マップJSONマップ・ディレクトリーへのパス\r\n
JsonFileOfEventMap	        = "Assets/RPGMaker/Storage/Event/JSON/eventMap.json"	            \r\n    😁 イベント・マップJSONファイルへのパス\r\n
JsonFileOfFlags	            = "Assets/RPGMaker/Storage/Flags/JSON/flags.json"	                \r\n    😁 フラグJSONファイルへのパス\r\n
args	                    = new List<AddonParamInfoJson>()	                                \r\n    😁 （※翻訳者追記） 辞書を含む構造体を要素として持つリスト。アドオン関連\r\n
params_	                    = new List<AddonParamInfoJson>()	                                \r\n    😁 （※翻訳者追記）文書構造。アドオンの情報関連\r\n
commandInfos	            = new List<AddonCommandInfoJson>()	                                \r\n    😁 （※翻訳者追記）文書構造。アドオンのコマンド関連\r\n
noteParamInfos	            = new List<AddonParamInfoJson>()	                                \r\n    😁 （※翻訳者追記）文書構造。アドオンのノート関連\r\n
paramInfos	                = new List<AddonParamInfoJson>()	                                \r\n    😁 （※翻訳者追記）文書構造。アドオンの情報関連\r\n
structInfos	                = new List<AddonStructInfoJson>()	                                \r\n    😁 （※翻訳者追記）文書構造。アドオンの構造体関連\r\n
JsonFile	                = "Assets/RPGMaker/Storage/Addon/Resources/addonSettings.json"	    \r\n    😁 JSONファイル\r\n
AddonInfosJsonFile	        = "Assets/RPGMaker/Storage/Addon/Resources/addonInfos.json"	        \r\n    😁 アドオン情報JSONファイル\r\n
_bgmLoopInfoFilename	    = "Assets/RPGMaker/Storage/Sounds/bgmLoopInfo.json"	                \r\n    😁 背景音楽ループ情報ファイル名\r\n
_bgsLoopInfoFilename	    = "Assets/RPGMaker/Storage/Sounds/bgsLoopInfo.json"	                \r\n    😁 環境音ループ情報ファイル名\r\n
```
