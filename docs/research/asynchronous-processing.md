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

            //ここで少し待ち、イベント終了契機がキーなどの入力だった場合に、後続のイベント等が発動しないようにする
            await Task.Delay(100);

            //ここで少し待ち、イベント終了直後に別のイベントが発動することを抑制する
            await Task.Delay(100);
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Battle.BattleManager

        戦闘BGMを再生
        public static async void PlayBattleBgm(SoundCommonDataModel bgm)

            await SoundManager.Self().PlayBgm();

        勝利MEを再生
        public static async void PlayVictoryMe()

            await SoundManager.Self().PlayMe();

        敗北MEを再生
        public static async void PlayDefeatMe()

            await SoundManager.Self().PlayMe();

        BGMとBGSの続きを再生
        public static async void ReplayBgmAndBgs()

            await SoundManager.Self().PlayBgm();
            await SoundManager.Self().PlayBgs();
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Battle.Objects.GameActor

        攻撃動作を実行
        public async void PerformAttack()

            //武器アニメーションの指定
            //一歩前に出る分待つ
            //一歩前に出るのは12fで、フラグのON/OFF分の2Fを加えた分待つ
            await Task.Delay(Mathf.RoundToInt(14f / 60f * 1000));
```

```
コア・システム

    サイドビューのアクター表示用のスプライト
    RPGMaker.Codebase.Runtime.Battle.Sprites.SpriteActor

        ステートのスプライトを生成
        public async void CreateStateSprite()

            //画面に生成されていないと、以降の処理で座標計算が行えないため待つ
            await Task.Delay(1000 / 60);
```

```
コア・システム

    アニメーションする表示物のためのクラス
    RPGMaker.Codebase.Runtime.Battle.Sprites.SpriteBase

        アニメーションの再生開始
        public async void StartAnimation(AnimationDataModel animation, bool mirror, float delay, bool isActor)

            //指定されたフレーム数待つ
            await Task.Delay(Mathf.RoundToInt(delay / 60f * 1000));

    [敵キャラ]表示用のスプライトクラス
    RPGMaker.Codebase.Runtime.Battle.Sprites.SpriteEnemy

        アイコン初期化
        public async void CreateStateIconSprite()

            //画面に生成されていないと、以降の処理で座標計算が行えないため待つ
            await Task.Delay(1000 / 60);
```

```
コア・システム

    戦闘シーン用のスプライトセット。[背景][アクター][敵キャラ]を含む / Unite用に作り替えている
    RPGMaker.Codebase.Runtime.Battle.Sprites.SpritesetBattle

        初期化処理
        public async void Initialize()

            await Task.Delay(10);
```

```
コア・システム

    [アイテム]の選択ウィンドウ
    RPGMaker.Codebase.Runtime.Battle.Window.WindowItemList

        コンテンツの再描画の後、若干待ってから実行する処理
        private async void RefreshAft()

            await Task.Delay(100);
```

```
コア・システム

    [スキル]の選択ウィンドウ
    RPGMaker.Codebase.Runtime.Battle.Window.WindowSkillList

        コンテンツの再描画の後、若干待ってから実行する処理
        private async void RefreshAft()

            await Task.Delay(100);
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Common.Component.Hud.Character.MovePlace

        private async void ReflectionBgmBgs(MapDataModel nextMap)

            //サウンドの再生
            await SoundManager.Self().PlayBgm();

            //サウンドの再生
            await SoundManager.Self().PlayBgs();
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

            await Task.Delay(1);

        private async void WaitMillSec(int nowEventIndex)

            await Task.Delay(1);
```

```
コア・システム

    バトルでは本コマンドは利用しない
    RPGMaker.Codebase.Runtime.Common.Component.Hud.Display.MapChangeName

        マップ名の表示削除用
        private async void CloseMapNameDisplay()

            await Task.Delay(1000);
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Common.Component.Hud.Picture

        private async void ExecuteCallback(Action action)

            await Task.Delay(1);
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Common.PartyWindow

        フォーカス設定
        private async void SetFocusAft(int index = 0)

            await Task.Delay(10);
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Common.SoundManager

        public async Task PlayBgm(Action action)

            await PlayBgm();


        public async Task PlayBgm()

#if USE_PARTIAL_LOOP
            int loopStartSamples = -1;
            int loopEndSamples = -1;
            (_bgmClip.clip, loopStartSamples, loopEndSamples) = await GetClip(_bgmSoundCommon?.name, SoundType.BGM);
            _bgmClip.SetLoopInfo(loopStartSamples, loopEndSamples);
#else
            _bgmClip.clip = await GetClip(_bgmSoundCommon?.name, SoundType.BGM);
#endif

            await Task.Delay(1);

    #if USE_PARTIAL_LOOP
        private async Task<(AudioClip, int, int)> GetClip(string clipName, SoundType soundType)
    #else
        private static async Task<AudioClip> GetClip(string clipName, SoundType soundType)
    #endif

#if USE_PARTIAL_LOOP
                (sounddata, loopStartSamples, loopEndSamples) = await LoadAudioClip(type, clipName, clipName.EndsWith(extension) ? "ogg" : "wav");
#else
                sounddata = await LoadAudioClip(type, clipName, clipName.EndsWith(extension) ? "ogg" : "wav");
#endif

#if USE_PARTIAL_LOOP
                (sounddata, loopStartSamples, loopEndSamples) = await LoadAudioClip(type, clipName + extension, "ogg");
#else
                sounddata = await LoadAudioClip(type, clipName + extension, "ogg");
#endif

#if USE_PARTIAL_LOOP
                (sounddata, loopStartSamples, loopEndSamples) = await LoadAudioClip(type, clipName + extension2, "wav");
#else
                sounddata = await LoadAudioClip(type, clipName + extension2, "wav");
#endif

#if USE_PARTIAL_LOOP
                (sounddata, loopStartSamples, loopEndSamples) = await LoadAudioClip(type2, clipName, clipName.EndsWith(extension) ? "ogg" : "wav");
#else
                sounddata = await LoadAudioClip(type2, clipName, clipName.EndsWith(extension) ? "ogg" : "wav");
#endif

#if USE_PARTIAL_LOOP
                (sounddata, loopStartSamples, loopEndSamples) = await LoadAudioClip(type2, clipName + extension, "ogg");
#else
                sounddata = await LoadAudioClip(type2, clipName + extension, "ogg");
#endif

#if USE_PARTIAL_LOOP
                (sounddata, loopStartSamples, loopEndSamples) = await LoadAudioClip(type2, clipName + extension2, "wav");
#else
                sounddata = await LoadAudioClip(type2, clipName + extension2, "wav");
#endif

        BGMの再開。
        public async void ContinueBgm()

#if USE_PARTIAL_LOOP
            int loopStartSamples = -1;
            int loopEndSamples = -1;
            (_bgmClip.clip, loopStartSamples, loopEndSamples) = await GetClip(_bgmSoundCommon.name = _bgmSavedSoundData.clipName, SoundType.BGM);
            _bgmClip.SetLoopInfo(loopStartSamples, loopEndSamples);
#else
            _bgmClip.clip = await GetClip(_bgmSoundCommon.name = _bgmSavedSoundData.clipName, SoundType.BGM);
#endif

        public async Task PlayBgs()

#if USE_PARTIAL_LOOP
            int loopStartSamples = -1;
            int loopEndSamples = -1;
            (_bgsClip.clip, loopStartSamples, loopEndSamples) = await GetClip(_bgsSoundCommon?.name, SoundType.BGS);
            _bgsClip.SetLoopInfo(loopStartSamples, loopEndSamples);
#else
            _bgsClip.clip = await GetClip(_bgsSoundCommon?.name, SoundType.BGS);
#endif

        public async Task PlayMe()

#if USE_PARTIAL_LOOP
            (_meClip.clip, _, _) = await GetClip(_meSoundCommon?.name, SoundType.ME);
#else
            _meClip.clip = await GetClip(_meSoundCommon?.name, SoundType.ME);
#endif

        public async void PlaySe()

#if USE_PARTIAL_LOOP
            AudioClip sounddata;
            (sounddata, _, _) = await GetClip(_seSoundCommon?.name, SoundType.SE);
#else
            AudioClip sounddata = await GetClip(_seSoundCommon?.name, SoundType.SE);
#endif

    #if USE_PARTIAL_LOOP
        private static async Task<(AudioClip, int, int)> LoadAudioClip(string folderName, string filename, string extention)
    #else
        private static async Task<AudioClip> LoadAudioClip(string folderName, string filename, string extention)
    #endif

            if (await AddressableManager.Load.CheckResourceExistence("Assets/RPGMaker/Storage/Sounds/" + folderName + "/" + filename))
```

```
コア・システム

    RPGMaker.Codebase.CoreSystem.Helper.WindowButtonBase

        private async void OnClickWaitFrame()

            await Task.Delay(1);
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Event.AudioVideo.BgmPlayProcessor

        サウンドの再生 > 次のイベントへ
        private async void PlaySound()

            await SoundManager.Self().PlayBgm();
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Event.AudioVideo.BgsPlayProcessor

        サウンドの再生 > 次のイベントへ
        private async void PlaySound()

            await SoundManager.Self().PlayBgs();
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Event.AudioVideo.MePlayProcessor

        サウンドの再生 > 次のイベントへ
        private async void PlaySound()

            await SoundManager.Self().PlayMe();
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Event.Battle.BattleExecCommand

        private async void ProcessEndAction()

            await Task.Delay(1);
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Event.Message.MessageInputSelectProcessor

        private async void FirstFocusSetting(Button button, int index)

                await Task.Delay(100);

                await Task.Delay(1);
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Event.Message.MessageTextOnLineProcessor

        private async void DelayAndSetEvent()

            await Task.Delay(100);
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Event.Party.PartyCharacterChangeProcess

        private async void ProcessExecute()

            await Task.Delay(1);
```

```
コア・システム

    RPGMaker.Codebase.Runtime.GameOver.SceneGameOver

        protected async void PlayMe()

            await SoundManager.Self().PlayMe();
```

```
コア・システム

    時間経過に伴うActionの実行を管理するクラス
    RPGMaker.Codebase.Runtime.Common.TimeHandler

        1msだけ処理を待ち、Actionを実行する / スタックオーバーフロー対策であり、実際に待ちたいわけではない場合にのみ利用する
        public async void WaitMillisec(Action action)

            await Task.Delay(1);
```

```
コア・システム

    マップイベントの実行状態を管理するためのクラス
    RPGMaker.Codebase.Runtime.Map.MapEventExecutionController

        private async void RestartParallelEvent(EventMapDataModel eventMapDataModel, EventDataModel eventDataModel)

            //並列イベントは同時に何個も動作するため、TimeHandlerを利用せずに直接awaitする
            await Task.Delay(1);
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Map.MapManager

        マップ初期化
        public static async void InitManager(GameObject sceneRootGameObject, Camera camera, GameObject menuObject)

            ※ await をつけ忘れているのではないか？
            //BGMが設定されていたら再生
            SoundManager.Self().PlayBgm(() => {
                SoundManager.Self().ChangeBgmState(_runtimeConfigDataModel.bgmVolume);
            });

            ※ await をつけ忘れているのではないか？
            SoundManager.Self().PlayBgs();

        private static async void ChangeMoveSubject(_moveTypeEnum type)

            await Task.Delay(500);

            await Task.Delay(500);

        乗り物に乗る
        public static async void TryToRideFromThePlayerToVehicle()

            await SoundManager.Self().PlayBgm();

        public static async void NextEvent()

            await Task.Delay(500);

        public static async void PartyMemberAllInCoordinate(ReasonForPartyMemberAllIn reason,[CanBeNull] Action  callback = null)

            await Task.Delay(1000/60);

        乗り物降りるメソッド / 降りれる方向が入ってくる
        private static async void GetOffVehicle(CharacterMoveDirectionEnum Direction)

            await SoundManager.Self().PlayBgm();
```

```
コア・システム

    コアシステムサービス / FIXME 本来コンポーネントから直接コアシステムにアクセスするのはよくない Initの引数で受け取るべき
    RPGMaker.Codebase.Runtime.Map.Menu.DebugToolGroupMenu

        async Task FocusGroupAsync(DebugToolButton button)

            await Task.Delay(1);

            await Task.Delay(2);

            await Task.Delay(2);

        async Task DelayCallAsync(int milliSec, System.Action action)

            await Task.Delay(milliSec);

        async Task RefreshValueListAndFocusAsync(DebugToolGroupItem groupItem)

            await Task.Delay(2);
```

```
コア・システム

    タイトル画面またはゲームのメインメニューから開くセーブロード画面
    RPGMaker.Codebase.Runtime.Map.Menu.SaveMenu

    #if UNITY_EDITOR
        public async void ChangeFocused()

        //少し待たないとフォーカスが移らないため、待つ
        await Task.Delay(10);
    #endif
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Map.MenuBase

        イベントに復帰する
        private async void ResumeEvent()

            await Task.Delay(500);

        GameState切り替え処理
        private async void ChangeGameState(GameStateHandler.GameState state)

            //次の入力までの間にDelayを設ける 1/60単位でキー受付するのは早すぎるため
            await Task.Delay(100);
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Title.OptionController

    #if UNITY_EDITOR
        少し待たないとフォーカスが移らないため、待つ > フォーカス再設定処理
        public async void ChangeFocused()

            //少し待たないとフォーカスが移らないため、待つ
            await Task.Delay(10);
    #endif
```

```
コア・システム

    RPGMaker.Codebase.Runtime.Title.TitleController

        private async void PlayBgm(RuntimeConfigDataModel config)

            await SoundManager.Self().PlayBgm();

        セーブ画面を開く。ロード可能なセーブデータが無い場合はブザーを鳴らす。
        private async void Continue()

            await Task.Delay(500);

        private async void Option()

            await Task.Delay(500);

    #if UNITY_EDITOR
        少し待たないとフォーカスが移らないため、待つ > フォーカス再設定処理
        private async void ChangeFocusedTitle()

            //少し待たないとフォーカスが移らないため、待つ
            await Task.Delay(10);
    #endif
```

## 主に Unity エディターで使われているもの

```
エディター

    RPGMaker.Codebase.Editor.Common.AddonUIUtil.AddonBaseModalWindow

        private static async Task DelayedAsync(CancellationToken token)

            await Task.Delay(TimeSpan.FromMilliseconds(_delayedTime), token);
```

```
エディター

    インポートなど、AssetDatabaseの更新を変更するためのAPIクラス
    RPGMaker.Codebase.Editor.Common.ApiManager

        読み込み（残しておく）
        public static async void AssetDatabaseStopToRestart()

            await Task.Delay(1);

        タイムアウトの時間を図る（残しておく）
        private static async void TimeCount()

            await Task.Delay(1);
```

```
エディター

    RPGMaker.Codebase.Editor.Common.RpgMakerEditor

        private static async Task DelayAuth()

            await Task.Delay(1);

            await Task.Delay(1);

            await Task.Delay(1);

            await AuthRpgMaker();

        RpgMakerを認証。
        private static async Task AuthRpgMaker()

            // 認証
            switch (await Auth.AttemptToAuthenticate())

        ツールメニューからエディタを開く処理
        RPG Maker Uniteを開く
        [MenuItem(RpgMakerUniteMenuItemPath)]
        private static async void RpgMakerUniteMenu()

            await DelayAuth();

        RPG Maker Unite Window (開発用)を開く
        [MenuItem(RpgMakerUniteWindowMenuItemPath)]
        private static async void RpgMakerUniteWindow()

            // UnityのAssetStoreへのログインが完了するのを待ってから、認証処理を走らせる
            await DelayAuth();

        private static async void SetWindows()

            await Task.Delay(2000);

            //少しまってからフォーカスをあてなおさないと、タイミングによってタブが切り替わらない
            await Task.Delay(1000);

        Playmodeの状態が変わった時に実行される
        private static async void OnPlayModeStateChanged(PlayModeStateChange state)

            await Task.Delay(100);
```

```
エディター

    RPGMaker.Codebase.Editor.DatabaseEditor.ModalWindow.DlcImporterWindow

        static async Task InitializeAsync()

            await Task.Delay(10);

            await Task.Delay(500);

            await ImportProcessAsync();


        static async Task ImportProcessAsync()

            await WaitForEditorReady();

            var exec = await CheckSameNames();

            var result = await AssetManageImporter.ImportFile(importFileDataList);

        #if true    //for debug
            Debug.Log($"Processing ... {dstFilename}");
            await Task.Delay(1);
        #endif

            await RPGMaker.Codebase.Editor.MapEditor.MapEditor.SaveTile(tileDataModelList);

            await RPGMaker.Codebase.Editor.MapEditor.MapEditor.SaveTile(tileDataModel);

            await RPGMaker.Codebase.Editor.MapEditor.MapEditor.SaveTile(tileDataModelList);

        static async Task WaitForEditorReady()

            await Task.Delay(1);
            await Task.Delay(1);
            await Task.Delay(1);

            await Task.Delay(100);

        static async Task<bool> CheckSameNames()

            await Task.Delay(100);

            await Task.Delay(10);
```

```
エディター

    RPGMaker.Codebase.Editor.DatabaseEditor.ModalWindow.ImageSelectModalWindow

        private async void SelectImage()

            await Task.Delay(1);
```

```
エディター

    RPGMaker.Codebase.Editor.DatabaseEditor.ModalWindow.SdSelectModalWindow

        private async void SelectImage()

            await Task.Delay(1);
```

```
エディター

    RPGMaker.Codebase.Editor.DatabaseEditor.View.Preview.AssetManagePreview

        public async void UpdateAssetId(string id)

            await Task.Delay(50);
```

```
エディター

    RPGMaker.Codebase.Editor.DatabaseEditor.View.Preview.BattleScenePreview

        public async void Render()

            //少し待ってからSceneWindowの再描画を行う
            await Task.Delay(1);
```

```
エディター

    RPGMaker.Codebase.Editor.DatabaseEditor.View.Preview.CustomMovePreview

        async void UpdateAsync(UpdateLoop updateLoop)

            await Task.Delay(1000 / 15);
```

```
エディター

    データベースエディター用シーンウィンドウ.
    RPGMaker.Codebase.Editor.DatabaseEditor.Window.SceneWindow

        一定時間後に再描画を行う / タイトル画面のメニュー部分が、稀に崩れたまま表示されてしまう問題への対応
        public async void ReRender(int time = 500)

            await Task.Delay(time);
```

```
エディター

    RPGMaker.Codebase.Editor.Hierarchy.HierarchyParams

        Hierarchy更新
        public static async Task Refresh(Enum.Region targetRegion = Enum.Region.All, string updateData = null, bool isRefresh = true, bool isForce = false)

            await Task.Delay(2);
```

```
エディター

    Hierarchy全体を制御するクラス
    RPGMaker.Codebase.Editor.Hierarchy.Hierarchy

        Hierarchyのスクロール位置を設定する
        private static async void UpdateHierarchy()
```

```
エディター

    コモンイベントのHierarchy
    RPGMaker.Codebase.Editor.Hierarchy.Region.CommonEvent.CommonEventHierarchy

        コモンイベントのInspector表示
        public async void OpenEventCommonInspector(EventCommonDataModel eventCommonDataModel)
```

```
エディター

    データベースヒエラルキーのマップ部分
    RPGMaker.Codebase.Editor.Hierarchy.Region.Map.View.MapHierarchyView

        最終選択していたマップを返却（待ち時間あり）
        private async void InvokeSelectableElementAction()
```

```
エディター

    データベースヒエラルキーのマップ部分
    RPGMaker.Codebase.Editor.Hierarchy.Region.Map.View.MapSampleHierarchyView

        最終選択していたマップを返却（待ち時間あり）
        private async void InvokeSelectableElementAction()
```

```
エディター

    DatabaseManagementService取得
    RPGMaker.Codebase.Editor.Inspector.AbstractInspectorElement

        初期化を再度行えるようにする
        protected async void CanInitializeOn()

        データの更新を再度行えるようにする
        protected async void CanRefreshOn()

        セーブを再度行えるようにする
        protected async void CanSaveOn()
```

```
エディター
    
    RPGMaker.Codebase.Editor.Inspector.BattleScene.View.BattleSceneInspectorElement

        private static async void InitAllWindow()
```

```
エディター

    RPGMaker.Codebase.Editor.Inspector.Character.View.CharacterInspectorElement

        private async void UpdateData()
```

```
エディター

    RPGMaker.Codebase.Editor.Inspector.Map.View.BackgroundCollisionInspector()

        private async void SaveTile()
```

```
エディター

    マップ>イベント設定画面のinspector枠
    RPGMaker.Codebase.Editor.Inspector.Map.View.EventInspector

        private async void UpdateDataImport()
```

```
エディター

    マップエディター用インスペクターウィンドウ.
    RPGMaker.Codebase.Editor.Inspector.Map.View.MapInspectorView

        public void SetBackgroundCollisionView(TileDataModel tileDataModel)
            async 匿名関数 使用

        public void SetTileEntity(TileDataModel tileDataModel, TileInspector.TYPE inspectorType)
            async 匿名関数 使用
```

```
エディター

    RPGMaker.Codebase.Editor.Inspector.Title.View.TitleInspectorElement

        private async void _InitAsync()
```

```
エディター

    RPGMaker.Codebase.Editor.Inspector.Troop.View.TroopInspectorElement

        イベントエディタを開く
        public static async void LaunchEventEditMode(EventDataModel eventDataModel)

        private async void UpdateData()
```

```
エディター

    [変数の操作]のコマンド設定枠の表示物
    RPGMaker.Codebase.Editor.MapEditor.Component.CommandEditor.GameProgress.GameVariable

        private async void WaitMilliSecond()
```

```
エディター

    タイルリストコンポーネント
    RPGMaker.Codebase.Editor.MapEditor.Component.ListView.TileListView

        初回のタイル画像描画処理 / タイルが画面に置かれて配置場所が確定後に実施する
        private async void InitializeDrawImage()
```

```
エディター

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
```

```
エディター

    実行内容枠のウィンドウ
    RPGMaker.Codebase.Editor.MapEditor.Window.EventEdit.ExecutionContentsWindow

        private async void SaveWait(bool initEvent)

        private async void SaveEnd()
```

```
エディター

    RPGMaker.Codebase.Editor.OutlineEditor.OutlineEditor

        public static async void SelectElementsCommandProcess(OutlineNodeModel outlineNodeModel)
```
