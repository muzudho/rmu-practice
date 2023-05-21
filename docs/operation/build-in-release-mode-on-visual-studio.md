# Visual Studio の Release モードでビルドする方法

## やりたいこと

Visual Studio の `Release` モードでビルドしたい  

## 問題点

コンパイル・エラーが出る  

このように `Release` モードでビルドできないなら、 `Release` モードに不具合がないかということを Visual Studio 上で調査できない  

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

* 参考:
    * 📖 [Unity Documentation > 特殊なフォルダー名](https://docs.unity3d.com/ja/2019.4/Manual/SpecialFolders.html)
    * 📄 [Unity Documentation > C# コンパイラー](https://docs.unity3d.com/ja/2020.3/Manual/CSharpCompiler.html)

# 以下の現状は、当然に思える

* `RPGMaker.CodeBase.Editor` プロジェクトのソースコードが、Unity エディター用とそれ以外とに分かれていないこと
* Visual Studio の `Release` モードでビルドするなら、 Unity エディター用の C# スクリプトが含まれないこと

だから、 **Visual Studio** では、 `Release` モードでビルドすると、 Unity エディター用のコードがコンパイルできないことは当然と思えるし  
**Unity** には、 `Editor` フォルダー以外のソースだけを選んでビルドするような仕掛けがあるのだろうと推測する  

## 問題点の解説

👇 Visual Studio 2022 で `Release` モードにし、ビルドすると、  
`RPGMaker.CodeBase.Editor` のような Unity エディター用のソースも含まれているので、  
一緒にビルドされ、エラーが出る  

![Unity エディター用と認識されていない](../img/202305__rmu__21-1622--there-is-no-unity-editor-preprocessor-directive-o2o0.png)  

## 解決方法

Unity エンジン用かどうか見分けるのに、  

Unity では `Editor` フォルダーの下かそれ以外かで分けているが、  
Visual Studio では `なんとかEditor` プロジェクトという名前を付けて、プロジェクトを分けてしまうのがよい  

`Release` ビルドをしたいときは、 `なんとかEditor` プロジェクトをアンロードしてから行う  

ただし、`Unity.GraphToolsFoundation` のような外部ライブラリは Unity エディターで使うのが前提で作られているようなので、  
そのシリーズを丸ごとアンロードしなければならないケースはある  

🏠[トップページへ戻る](../../README.md)  
