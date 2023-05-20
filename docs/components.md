# コンポーネンツ（Components；構成要素）

```plaintext
 ■ＲＰＧツクール（主エディター）
RPGMaker.Codebase.Editor.Common.RpgMakerEditor

	３大モード

		■ "rpgmaker"
		RPGMakerDefaultConfigSingleton.RpgMakerUniteModeId

		■ "rpgmaker_window"
		RPGMakerDefaultConfigSingleton.RpgMakerUniteWindowModeId

		■ "initialize"
		RPGMakerDefaultConfigSingleton.InitializeModeId

	７大サブ・ウィンドウ
	RPGMaker.Codebase.Editor

		■ [1.0] 共通メニューウィンドウ
		RPGMaker.Codebase.Editor.Common.Window.MenuWindow

		■ [2.0] ヒエラルキー
		RPGMaker.Codebase.Editor.Hierarchy

		■ [3.0] インスペクター
		RPGMaker.Codebase.Editor.Inspector

		■ [4.0] データベース
		RPGMaker.Codebase.Editor.DatabaseEditor

		■ [5.0] マップ
		RPGMaker.Codebase.Editor.MapEditor

		■ [6.0] アウトライン
		RPGMaker.Codebase.Editor.OutlineEditor

		■ [7.0] インスペクターで開いていたウィンドウ

			■ [7.1.0] タイトル・インスペクター・エレメント（Display.Title）
			RPGMaker.Codebase.Editor.Inspector.Title.View.TitleInspectorElement

            ■ [7.2.0] UIコモン・インスペクター・エレメント（Display.UiCommon）
            RPGMaker.Codebase.Editor.Inspector.UIPattern.View.UiCommonInspectorElement

            ■ [7.3.0] UIゲーム・メニュー・インスペクター・エレメント（Display.GameMenu）
            RPGMaker.Codebase.Editor.Inspector.GameMenu.View.UIGameMenuInspectorElement

            ■ [7.4.0] オプション・インスペクター・エレメント（Display.Option）
            RPGMaker.Codebase.Editor.Inspector.Option.View.OptionInspectorElement

            ■ [7.5.0] UIバトル・メニュー・インスペクター・エレメント（Display.BattleMenu）
            RPGMaker.Codebase.Editor.Inspector.BattleMenu.View.UIBattleMenuInspectorElement

            ■ [7.6.0] ワード・インスペクター・エレメント（Display.Word）
            RPGMaker.Codebase.Editor.Inspector.Word.View.WordInspectorElement

            ■ [7.7.0] UIトーク・インスペクター・エレメント（Display.UiTalk）
            RPGMaker.Codebase.Editor.Inspector.Talk.View.UiTalkInspectorElement

            ■ [7.8.0] クラス・コモン・インスペクター・エレメント（Display.Job）
            RPGMaker.Codebase.Editor.Inspector.ClassCommon.View.ClassCommonInspectorElement

            ■ [7.9.0] サウンド・インスペクター・エレメント（Display.Sound）
            RPGMaker.Codebase.Editor.Inspector.Sound.View.SoundInspectorElement

            ■ [7.10.0] キャラクター・インスペクター・エレメント（Display.Character）
            RPGMaker.Codebase.Editor.Inspector.Character.View.CharacterInspectorElement

            ■ [7.11.0] キャラクター・ビークルズ・インスペクター・エレメント（Display.CharacterVehicles）
            RPGMaker.Codebase.Editor.Inspector.CharacterVehicle.View.CharacterVehiclesInspectorElement

            ■ [7.12.0] キャラクター・ビークルズ・インスペクター・エレメント（Display.CharacterClass）
            RPGMaker.Codebase.Editor.Inspector.CharacterClass.View.CharacterClassInspectorElement

            ■ [7.13.0] スキル・コモン・インスペクター・エレメント（Display.SkillCommon）
            RPGMaker.Codebase.Editor.Inspector.SkillCommon.View.SkillCommonInspectorElement

            ■ [7.14.0] スキル・カスタム・インスペクター・エレメント（Display.SkillCustom）
            RPGMaker.Codebase.Editor.Inspector.SkillCustom.View.SkillCustomInspectorElement

            ■ [7.15.0] スキル・カスタム・インスペクター・エレメント（Display.Enemy）
            RPGMaker.Codebase.Editor.Inspector.Enemy.View.EnemyInspectorElement

            ■ [7.16.0] バトル・シーン・インスペクター・エレメント（Display.BattleScene）
            RPGMaker.Codebase.Editor.Inspector.BattleScene.View.BattleSceneInspectorElement

            ■ [7.17.0] トループ・インスペクター・エレメント（Display.Troop）
            RPGMaker.Codebase.Editor.Inspector.Troop.View.TroopInspectorElement

            ■ [7.18.0] バトル編集ウィンドウ （Display.Encounter）
            RPGMaker.Codebase.Editor.MapEditor.Window.MapEdit.BattleEditWindow

            ■ [7.19.0] ステート・エディット・インスペクター・エレメント（Display.StateEdit）
            RPGMaker.Codebase.Editor.Inspector.State.View.StateEditInspectorElement

            ■ [7.20.0] [装備アイテムの編集]-[武器]の各武器のinspector枠（Display.Weapon）
            RPGMaker.Codebase.Editor.Inspector.Weapon.View.WeaponInspectorElement

            ■ [7.21.0] アーマー・インスペクター・エレメント（Display.Armor）
            RPGMaker.Codebase.Editor.Inspector.Armor.View.ArmorInspectorElement

            ■ [7.22.0] アイテム・エディット・インスペクター・エレメント（Display.Item）
            RPGMaker.Codebase.Editor.Inspector.Item.View.ItemEditInspectorElement

            ■ [7.23.0] アトリビュート・タイプ・エディット・インスペクター・エレメント（Display.AttributeTypeEdit）
            RPGMaker.Codebase.Editor.Inspector.Type.View.AttributeTypeEditInspectorElement

            ■ [7.24.0] スキル・タイプ・エディット・インスペクター・エレメント（Display.SkillTypeEdit）
            RPGMaker.Codebase.Editor.Inspector.Type.View.SkillTypeEditInspectorElement

            ■ [7.25.0] ウェポン・タイプ・インスペクター・エレメント（Display.WeaponTypeEdit）
            RPGMaker.Codebase.Editor.Inspector.Type.View.WeaponTypeEditInspectorElement

            ■ [7.26.0] アーマー・タイプ・エディット・インスペクター・エレメント（Display.ArmorTypeEdit）
            RPGMaker.Codebase.Editor.Inspector.Type.View.ArmorTypeEditInspectorElement

            ■ [7.27.0] エクイップメント・タイプ・エディット・インスペクター・エレメント（Display.EquipmentTypeEdit）
            RPGMaker.Codebase.Editor.Inspector.Type.View.EquipmentTypeEditInspectorElement

            ■ [7.28.0] アニメーション・インスペクター・エレメント（Display.Animation）
            RPGMaker.Codebase.Editor.Inspector.Animation.View.AnimationInspectorElement

            ■ [7.29.0] コモン・イベント・インスペクター・エレメント（Display.CommonEvent）
            RPGMaker.Codebase.Editor.Inspector.CommonEvent.View.CommonEventInspectorElement

            ■ [7.30.0] アセット・マネージ・インスペクター・エレメント（Display.AssetManage）
            RPGMaker.Codebase.Editor.Inspector.AssetManage.View.AssetManageInspectorElement

            ■ [7.31.0] スイッチ・エディット・インスペクター・エレメント（Display.SwitchEdit）
            RPGMaker.Codebase.Editor.Inspector.Switch.View.SwitchEditInspectorElement

            ■ [7.32.0] バリアブル・エディット・インスペクター・エレメント（Display.VariableEdit）
            RPGMaker.Codebase.Editor.Inspector.Variable.View.VariableEditInspectorElement

            ■ [7.33.0] 環境設定のInspector（Display.EnvironmentEdit）
            RPGMaker.Codebase.Editor.Inspector.Environment.View.EnvironmentInspectorElement

            ■ [7.34.0] マップ編集ウィンドウ（Display.MapEdit）
            RPGMaker.Codebase.Editor.MapEditor.Window.MapEdit.MapEditWindow

            ■ [7.35.0] バトル・エディット・ウィンドウ（Display.MapDistant）
            RPGMaker.Codebase.Editor.MapEditor.Window.MapEdit.BattleEditWindow

            ■ [7.36.0] マップエディター用インスペクターウィンドウ（Display.MapBackground）
            RPGMaker.Codebase.Editor.Inspector.Map.View.MapInspectorView

            ■ [7.37.0] マップエディター用インスペクターウィンドウ（Display.MapBackgroundCol）
            RPGMaker.Codebase.Editor.Inspector.Map.View.MapInspectorView

            ■ [7.38.0] マップエディター用インスペクターウィンドウ（Display.MapTile）
            RPGMaker.Codebase.Editor.Inspector.Map.View.MapInspectorView

            ■ [7.39.0] 複合的（Display.MapEvent） - ※タイルマップを読込んでるのも、ここ
            RPGMaker.Codebase.Editor.MapEditor.MapEditor            

            ■ [7.40.0] 複合的（Display.Outline）
            RPGMaker.Codebase.Editor.Inspector.Outline.View.InspectorViewForChapter
            RPGMaker.Codebase.Editor.Inspector.Outline.View.InspectorViewForSection

            ■ [7.41.0] （Display.Search）
            RPGMaker.Codebase.Editor.Inspector.SearchEvent.View.SearchEventInspector

```

🏠 [トップページへ戻る](../README.md)  
