# RPG Maker Unite のインストール

Unity の新しいプロジェクトを開けておく  

Unity Asset Store で RPG Maker Unite を購入したあと、  

![Unity Account](./img/202305__rpgmu__11-2248--install-o2o0.png)  

👆 Unity アカウントへログインし、右上の丸いアイコンをクリック  

![My Assets](./img/202305__rpgmu__11-2256--my-assets-o2o0.png)

👆 メニューから `My Assets` をクリック  

![Open in Unity](./img/202305__rpgmu__11-2259--open-in-unity-o2o0.png)  

👆 `Open in Unity` ボタンをクリック  

![Package Manager](./img/202305__rpgmu__11-2303--package-manager-o2o0.png)  

👆 `Package Manager` が出てくるので、 `RPG Maker Unite` を選択して `Download` ボタンをクリック。  

ダウンロードが終わったら、 `Download` ボタンの横の `Import` ボタンをクリック  

![Import Unity Package](./img/202305__rpgmu__11-2312--import-unity-package-o2o0.png)  

👆 `Import Unity Package` が出てきたら、 `import` をクリック  

![Warning](./img/202305__rpgmu__11-2314--warning-o1o0.png)  

```plaintext
This project is using the new input system package but
the native platform backends for the new input system
are not enabled in the player settings. This means that
no input from native devices will come through.

Do you want to enable the backends? Doing so will
*RESTART* the editor.
```

```plaintext
このプロジェクトでは、新しい入力システムパッケージを使用していますが
新しい入力システム用のネイティブプラットフォームのバックエンドは
がプレーヤーの設定で有効になっていません。このため
ネイティブデバイスからの入力はありません。

バックエンドを有効にしますか？そうすることで
*エディターを再起動します。
```

👆 この警告が出たら Yes をクリック。 Unity Editor の再起動が進む  

このあと、  

![Progress Bar](./img/202305__rpgmu__11-2331--progress-bar-o1o0.png)  

👆 プログレスバーが出てきて 30分ぐらい待たされる（CPU:Ryzen Threadripper 2920X， GPU:GeForce RTX 4090X，Memory:16GB）  

![Restart](./img/202305__rpgmu__11-2357--restart-o1o0.png)  

👆 Unity Editor が突然消えてビックリするが、（30分も経つと再起動していたことを忘れる）Unity Editor が再起動される  

![Warning 2](./img/202305__rpgmu__12-0000--warning2-o1o0.png)  

```plaintext
RPG Maker Unite needs to overwrite your project
settings in order to work correctly. Are you sure you
wish to proceed?
```

```plaintext
RPG Maker Uniteを正しく動作させるためには、プロジェクトの設定を上書きする必要があります。
本当にこのままでよいのでしょうか？
```

👆 `Overwrite` を選ぶ  

![Restart 2](./img/202305__rpgmu__12-0006--restart2-o1o0.png)  

👆 Unity Editor がまた、再起動する  

![Hold on](./img/202305__rpgmu__12-0007--loading-o1o0.png)  

👆 白いウィンドウが出てきて、またプログレスバーが出てきて待たされる。  
RPG Maker Unite が起動する前には、この「白いウィンドウが出てきて、プログレスバーが出てきて待たされる」を  
必ず通るようだ？  

![RPG Maker Unite Editor](./img/202305__rpgmu__12-0011--rpg-maker-unite-editor-o1o0.png)  

👆 RPG Maker Unite のエディターが出てくるが、まだプログレスバーは出ていて、待たされる。  
（まだ待ってほしい）  

後ろに アウトライン の画面が出ているが、これはロードの途中にたまたま見えているだけで、  
RPG Maker Unite のエディターの想定したファースト・ビューではないのかもしれない  

![Launched](./img/202305__rpgmu__12-0013--launched-o1o0.png)  

👆　このサンプル・ゲームのタイトル画面が出てきたら、ロード完了  
