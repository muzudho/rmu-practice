# UNITY_EDITOR プリプロセッサ・ディレクティブの追加（改悪を行う）

## 前提知識

Unity の C# スクリプトは、以下のように大きく２つに分かれる

* `Unity エディター用` - ヒエラルキー・ビューや、インスペクター・ビューを表示してゲームを編集しているときだ
* `それ以外` - ゲーム用。Unity エディターで Play ボタンを押し、ゲームをプレイしているときだ

👇 Unity エディター用では、以下のようにソースコードを `#if UNITY_EDITOR` と `#endif` で囲む

```cs
namespace Apple.Banana.Cherry
{
#if UNITY_EDITOR
    // Unity エディター用のコードをここに書く
#else
    // それ以外のコードをここに書く
#end
    // どちらでも使うコードは、その外へ書く
}
```

👇 なお、 Unity エディターでしか使わない C# スクリプトであれば、 `Editor` という名前のフォルダーの下に置けば  
わざわざ `#if UNITY_EDITOR` と `#endif` で囲む必要はない  

```plaintext
    📁 Assets
👉  └──📁 Editor
        └──📄 Apple.cs      # Unity エディター用の C# スクリプトとみなされる
```

参考: 📖 [Unity Documentation > 特殊なフォルダー名](https://docs.unity3d.com/ja/2019.4/Manual/SpecialFolders.html)  

例えば、 `RPGMaker.CodeBase.Editor` プロジェクトのソースコードが、Unity エディター用とそれ以外とに分かれていないのは当然だ  

## 問題点

👇 前提知識を踏まえ、それにも関わらず、  
Visual Studio 2022 で Release モードにすると、  
`RPGMaker.CodeBase.Editor` は Unity エディター用とはみなされず、エラーが出る  

![Unity エディター用と認識されていない](../img/202305__rmu__21-1622--there-is-no-unity-editor-preprocessor-directive-o2o0.png)  

これは、 Unity が利用している C# コンパイラーと、  
Visual Studio 2022 が利用している C# コンパイラーが別物か、設定が異なるからと推測する  

📄 [Unity Documentation > C# コンパイラー](https://docs.unity3d.com/ja/2020.3/Manual/CSharpCompiler.html)  

## やること

ソースコードを `#if UNITY_EDITOR` と `#endif` で囲みたい

🏠[トップページへ戻る](../../README.md)  
