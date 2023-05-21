# 非同期処理

## 主にリリース・ビルドで使われているもの

```
コア・システム

    RPGMaker.Codebase.CoreSystem.Helper.AddressableManager

        public static async Task<bool> CheckResourceExistence(string path)

            // path_replace の存在有無を返却
            AsyncOperationHandle<IList<IResourceLocation>> checkHandle = Addressables.LoadResourceLocationsAsync(path_replace);
            await checkHandle.Task;
```

```
コア・システム

    RPGMaker.Codebase.CoreSystem.Service.DatabaseManagement.AssetManageImporter

        public static async Task<List<bool>> ImportFile(
            List<ImportFileData> importFileData) 

            ※ await 未使用
```

```
コア・システム

    RPGMaker.Codebase.CoreSystem.Service.MapManagement.MapManagementService

        public async Task<bool> SaveTile(TileDataModel tileDataModel)

            return await _tileRepository.StoreTileEntity(tileDataModel);


        public async Task<List<bool>> SaveTile(List<TileDataModel> tileDataModel)

            return await _tileRepository.StoreTileEntity(tileDataModel);
```

```
コア・システム

    RPGMaker.Codebase.CoreSystem.Service.MapManagement.Repository.TileRepository

        タイルを保存する
        public async Task<bool> StoreTileEntity(TileDataModel tileDataModel)

            // 大型パーツタイルの親パーツなら専用のメソッドを呼ぶ。
            await GenerateLargePartsTileAssets(tileDataModel, assetPath);

            // 1ms待つ（読み込み用）
            await Task.Delay(1);

            // 1ms待つ（読み込み用）
            await Task.Delay(1);

        タイルを保存する
        public async Task<List<bool>> StoreTileEntity(List<TileDataModel> tileDataModel)

            // 1ms待つ（読み込み用）
            await Task.Delay(1);

            // 1ms待つ（読み込み用）
            await Task.Delay(1);

        大型パーツタイルを構成するアセットファイル群を生成・保存する
        private static async Task GenerateLargePartsTileAssets(TileDataModel tileDataModel, string assetPath)

            // 1ms待つ（読み込み用）
            await Task.Delay(1);
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Battle.BattleEventCommandChainLauncher

        イベント実行終了
        private async void EndDelayCommandChain()
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Battle.BattleManager

        戦闘BGMを再生
        public static async void PlayBattleBgm(SoundCommonDataModel bgm)

        勝利MEを再生
        public static async void PlayVictoryMe()

        敗北MEを再生
        public static async void PlayDefeatMe()

        BGMとBGSの続きを再生
        public static async void ReplayBgmAndBgs()
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Battle.Objects.GameActor

        攻撃動作を実行
        public async void PerformAttack()
```

```
コア・システム

    サイドビューのアクター表示用のスプライト
    RPGMaker.Codebase.Runtime.Battle.Sprites.SpriteActor

        ステートのスプライトを生成
        public async void CreateStateSprite()
```

```
コア・システム

    アニメーションする表示物のためのクラス
    RPGMaker.Codebase.Runtime.Battle.Sprites.SpriteBase

        アニメーションの再生開始
        public async void StartAnimation(AnimationDataModel animation, bool mirror, float delay, bool isActor)

        [敵キャラ]表示用のスプライトクラス
        RPGMaker.Codebase.Runtime.Battle.Sprites.SpriteEnemy

        アイコン初期化
        public async void CreateStateIconSprite()
```

```
コア・システム

    戦闘シーン用のスプライトセット。[背景][アクター][敵キャラ]を含む / Unite用に作り替えている
    RPGMaker.Codebase.Runtime.Battle.Sprites.SpritesetBattle

        初期化処理
        public async void Initialize()
```

```
コア・システム

    [アイテム]の選択ウィンドウ
    RPGMaker.Codebase.Runtime.Battle.Window.WindowItemList

        コンテンツの再描画の後、若干待ってから実行する処理
        private async void RefreshAft()
```

```
コア・システム

    [スキル]の選択ウィンドウ
    RPGMaker.Codebase.Runtime.Battle.Window.WindowSkillList

        コンテンツの再描画の後、若干待ってから実行する処理
        private async void RefreshAft()
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Common.Component.Hud.Character.MovePlace

        private async void ReflectionBgmBgs(MapDataModel nextMap)
```

```
コア・システム

    バトルでは本コマンドは利用しない
    キャラクターの座標が必要 / キャラクターの画像を変える必要がある
    RPGMaker.Codebase.Runtime.Common.Component.Hud.Character.MoveSetMovePoint

        イベントコマンドから設定
        public async void SetMovePointProcess(
            Action endAction,
            Action closeAction,
            Action nextAction,
            EventDataModel.EventCommand command,
            string thisEventId,
            bool isActor = false)

        private async void WaitMillSec(int nowEventIndex)
```

```
コア・システム

    バトルでは本コマンドは利用しない
    RPGMaker.Codebase.Runtime.Common.Component.Hud.Display.MapChangeName

        マップ名の表示削除用
        private async void CloseMapNameDisplay()
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Common.Component.Hud.Picture

        private async void ExecuteCallback(Action action)
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Common.PartyWindow

        フォーカス設定
        private async void SetFocusAft(int index = 0)
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Common.SoundManager

        public async Task PlayBgm(Action action)

        public async Task PlayBgm()

    #if USE_PARTIAL_LOOP
        private async Task<(AudioClip, int, int)> GetClip(string clipName, SoundType soundType)
    #else
        private static async Task<AudioClip> GetClip(string clipName, SoundType soundType)
    #endif

        BGMの再開。
        public async void ContinueBgm()

        public async Task PlayBgs()

        public async Task PlayMe()

        public async void PlaySe()

    #if USE_PARTIAL_LOOP
        private static async Task<(AudioClip, int, int)> LoadAudioClip(string folderName, string filename, string extention)
    #else
        private static async Task<AudioClip> LoadAudioClip(string folderName, string filename, string extention)
    #endif
```

```
コア・システム

    RPGMaker.Codebase.CoreSystem.Helper.WindowButtonBase

        private async void OnClickWaitFrame()
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Event.AudioVideo.BgmPlayProcessor

        サウンドの再生 > 次のイベントへ
        private async void PlaySound()
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Event.AudioVideo.BgsPlayProcessor

        サウンドの再生 > 次のイベントへ
        private async void PlaySound()
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Event.AudioVideo.MePlayProcessor

        サウンドの再生 > 次のイベントへ
        private async void PlaySound()
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Event.Battle.BattleExecCommand

        private async void ProcessEndAction()
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Event.Message.MessageInputSelectProcessor

        private async void FirstFocusSetting(Button button, int index)
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Event.Message.MessageTextOnLineProcessor

        private async void DelayAndSetEvent()
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Event.Party.PartyCharacterChangeProcess

        private async void ProcessExecute()
```

```
コア・システム

    RPGMaker.Codebase.Runtime.GameOver.SceneGameOver

        protected async void PlayMe()
```

```
コア・システム

    時間経過に伴うActionの実行を管理するクラス
    RPGMaker.Codebase.Runtime.Common.TimeHandler

        1msだけ処理を待ち、Actionを実行する / スタックオーバーフロー対策であり、実際に待ちたいわけではない場合にのみ利用する
        public async void WaitMillisec(Action action)
```

```
コア・システム

    マップイベントの実行状態を管理するためのクラス
    RPGMaker.Codebase.Runtime.Map.MapEventExecutionController

        private async void RestartParallelEvent(EventMapDataModel eventMapDataModel, EventDataModel eventDataModel)
            //並列イベントは同時に何個も動作するため、TimeHandlerを利用せずに直接awaitする
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Map.MapManager

        マップ初期化
        public static async void InitManager(GameObject sceneRootGameObject, Camera camera, GameObject menuObject)

        private static async void ChangeMoveSubject(_moveTypeEnum type)

        乗り物に乗る
        public static async void TryToRideFromThePlayerToVehicle()

        public static async void NextEvent()

        public static async void PartyMemberAllInCoordinate(ReasonForPartyMemberAllIn reason,[CanBeNull] Action  callback = null)

        乗り物降りるメソッド / 降りれる方向が入ってくる
        private static async void GetOffVehicle(CharacterMoveDirectionEnum Direction)
```

```
コア・システム

    コアシステムサービス / FIXME 本来コンポーネントから直接コアシステムにアクセスするのはよくない Initの引数で受け取るべき
    RPGMaker.Codebase.Runtime.Map.Menu.DebugToolGroupMenu

        async Task FocusGroupAsync(DebugToolButton button)

        async Task DelayCallAsync(int milliSec, System.Action action)

        async Task RefreshValueListAndFocusAsync(DebugToolGroupItem groupItem)
```

```
コア・システム

    タイトル画面またはゲームのメインメニューから開くセーブロード画面
    RPGMaker.Codebase.Runtime.Map.Menu.SaveMenu

    #if UNITY_EDITOR
        public async void ChangeFocused()
    #endif
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Map.MenuBase

        イベントに復帰する
        private async void ResumeEvent()

        GameState切り替え処理
        private async void ChangeGameState(GameStateHandler.GameState state)
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Title.OptionController

    #if UNITY_EDITOR
        少し待たないとフォーカスが移らないため、待つ > フォーカス再設定処理
        public async void ChangeFocused()
    #endif
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Title.TitleController

        private async void PlayBgm(RuntimeConfigDataModel config)

        セーブ画面を開く。ロード可能なセーブデータが無い場合はブザーを鳴らす。
        private async void Continue()

        private async void Option()

    #if UNITY_EDITOR
        少し待たないとフォーカスが移らないため、待つ > フォーカス再設定処理
        private async void ChangeFocusedTitle()
    #endif
```

## 主に Unity エディターで使われているもの

```plaintext
エディター

    RPGMaker.Codebase.Editor.Common.AddonUIUtil.AddonBaseModalWindow

        private static async Task DelayedAsync(CancellationToken token)

    インポートなど、AssetDatabaseの更新を変更するためのAPIクラス
    RPGMaker.Codebase.Editor.Common.ApiManager

        読み込み（残しておく）
        public static async void AssetDatabaseStopToRestart()

        タイムアウトの時間を図る（残しておく）
        private static async void TimeCount()

    RPGMaker.Codebase.Editor.Common.RpgMakerEditor

        private static async Task DelayAuth()

        RpgMakerを認証。
        private static async Task AuthRpgMaker()

        ツールメニューからエディタを開く処理
        RPG Maker Uniteを開く
        [MenuItem(RpgMakerUniteMenuItemPath)]
        private static async void RpgMakerUniteMenu()

        RPG Maker Unite Window (開発用)を開く
        [MenuItem(RpgMakerUniteWindowMenuItemPath)]
        private static async void RpgMakerUniteWindow()

        private static async void SetWindows()

        Playmodeの状態が変わった時に実行される
        private static async void OnPlayModeStateChanged(PlayModeStateChange state)

    RPGMaker.Codebase.Editor.DatabaseEditor.ModalWindow.DlcImporterWindow

        static async Task InitializeAsync()

        static async Task ImportProcessAsync()

        static async Task WaitForEditorReady()

        static async Task<bool> CheckSameNames()

    RPGMaker.Codebase.Editor.DatabaseEditor.ModalWindow.ImageSelectModalWindow

        private async void SelectImage()

    RPGMaker.Codebase.Editor.DatabaseEditor.ModalWindow.SdSelectModalWindow

        private async void SelectImage()

    RPGMaker.Codebase.Editor.DatabaseEditor.View.Preview.AssetManagePreview

        public async void UpdateAssetId(string id)

    RPGMaker.Codebase.Editor.DatabaseEditor.View.Preview.BattleScenePreview

        public async void Render()

    RPGMaker.Codebase.Editor.DatabaseEditor.View.Preview.CustomMovePreview

        async void UpdateAsync(UpdateLoop updateLoop)

    データベースエディター用シーンウィンドウ.
    RPGMaker.Codebase.Editor.DatabaseEditor.Window.SceneWindow

        一定時間後に再描画を行う / タイトル画面のメニュー部分が、稀に崩れたまま表示されてしまう問題への対応
        public async void ReRender(int time = 500)

    RPGMaker.Codebase.Editor.Hierarchy.HierarchyParams

        Hierarchy更新
        public static async Task Refresh(Enum.Region targetRegion = Enum.Region.All, string updateData = null, bool isRefresh = true, bool isForce = false)

    Hierarchy全体を制御するクラス
    RPGMaker.Codebase.Editor.Hierarchy.Hierarchy

        Hierarchyのスクロール位置を設定する
        private static async void UpdateHierarchy()

    コモンイベントのHierarchy
    RPGMaker.Codebase.Editor.Hierarchy.Region.CommonEvent.CommonEventHierarchy

        コモンイベントのInspector表示
        public async void OpenEventCommonInspector(EventCommonDataModel eventCommonDataModel)

    データベースヒエラルキーのマップ部分
    RPGMaker.Codebase.Editor.Hierarchy.Region.Map.View.MapHierarchyView

        最終選択していたマップを返却（待ち時間あり）
        private async void InvokeSelectableElementAction()

    データベースヒエラルキーのマップ部分
    RPGMaker.Codebase.Editor.Hierarchy.Region.Map.View.MapSampleHierarchyView

        最終選択していたマップを返却（待ち時間あり）
        private async void InvokeSelectableElementAction()

    DatabaseManagementService取得
    RPGMaker.Codebase.Editor.Inspector.AbstractInspectorElement

        初期化を再度行えるようにする
        protected async void CanInitializeOn()

        データの更新を再度行えるようにする
        protected async void CanRefreshOn()

        セーブを再度行えるようにする
        protected async void CanSaveOn()
    
    RPGMaker.Codebase.Editor.Inspector.BattleScene.View.BattleSceneInspectorElement

        private static async void InitAllWindow()

    RPGMaker.Codebase.Editor.Inspector.Character.View.CharacterInspectorElement

        private async void UpdateData()

    RPGMaker.Codebase.Editor.Inspector.Map.View.BackgroundCollisionInspector()

        private async void SaveTile()

    マップ>イベント設定画面のinspector枠
    RPGMaker.Codebase.Editor.Inspector.Map.View.EventInspector

        private async void UpdateDataImport()

    マップエディター用インスペクターウィンドウ.
    RPGMaker.Codebase.Editor.Inspector.Map.View.MapInspectorView

        public void SetBackgroundCollisionView(TileDataModel tileDataModel)
            async 匿名関数 使用

        public void SetTileEntity(TileDataModel tileDataModel, TileInspector.TYPE inspectorType)
            async 匿名関数 使用

    RPGMaker.Codebase.Editor.Inspector.Title.View.TitleInspectorElement

        private async void _InitAsync()

    RPGMaker.Codebase.Editor.Inspector.Troop.View.TroopInspectorElement

        イベントエディタを開く
        public static async void LaunchEventEditMode(EventDataModel eventDataModel)

        private async void UpdateData()

    [変数の操作]のコマンド設定枠の表示物
    RPGMaker.Codebase.Editor.MapEditor.Component.CommandEditor.GameProgress.GameVariable

        private async void WaitMilliSecond()

    タイルリストコンポーネント
    RPGMaker.Codebase.Editor.MapEditor.Component.ListView.TileListView

        初回のタイル画像描画処理 / タイルが画面に置かれて配置場所が確定後に実施する
        private async void InitializeDrawImage()

    RPGMaker.Codebase.Editor.MapEditor.MapEditor

        イベント編集モードに切り替え
        public static async void LaunchEventEditMode(
            MapDataModel mapDataModel,
            EventMapDataModel eventMapDataModelEntity,
            int pageNum = 0
        )

        座標指定
        public static async void LaunchCommonEventEditMode(
            MapDataModel mapDataModel,
            int pageNum = 0,
            Action<Vector3Int> callBack = null,
            string id = "",
            bool eventMove = false,
            bool notCoordinateMode = false
        )

        public static async void LaunchCommonEventEditModeEnd(
            MapDataModel mapDataModel,
            int pageNum = 0
        )
        
        タイルを保存する.
        public static async Task<bool> SaveTile(TileDataModel tileDataModel)
        
        タイルを保存する.
        public static async Task<List<bool>> SaveTile(List<TileDataModel> tileDataModel)

    実行内容枠のウィンドウ
    RPGMaker.Codebase.Editor.MapEditor.Window.EventEdit.ExecutionContentsWindow

        private async void SaveWait(bool initEvent)

        private async void SaveEnd()

    RPGMaker.Codebase.Editor.OutlineEditor.OutlineEditor

        public static async void SelectElementsCommandProcess(OutlineNodeModel outlineNodeModel)
```
