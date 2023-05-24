# プロジェクトの依存関係

## プロジェクト一覧

![プロジェクト一覧](../img/202305/202305__rmu__24-2028--project-list-o1o0.png)  

👆 プロジェクトはこれだけある  

* Effekseer
* Effekseer.HDRP
* Effekseer.PostProcessing
* Effekseer.URP
* EffekseerEditor
* RPGMaker.CodeBase.CoreSystem
* RPGMaker.CodeBase.Editor
* RPGMaker.Unite
* Unity.GraphTools.Foundation.Editor.Tests
* Unity.GraphTools.Foundation.Overdrive
* Unity.GraphTools.Foundation.Overdrive.CommandStateObserver
* Unity.GraphTools.Foundation.Overdrive.Editor
* Unity.GraphTools.Foundation.Overdrive.Model
* Unity.GraphTools.Foundation.Tests
* Unity.GraphToolsFoundation.Searcher.Editor
* Unity.GraphToolsFoundation.Searcher.EditorSamples
* Unity.GraphToolsFoundation.Searcher.EditorTests
* Unity.GraphToolsFoundation.Searcher.ScriptsSamples
* Unity.InternalAPIEngineBridge.015

## 依存関係

![プロジェクトの依存関係](../img/202305/202305__rmu__24-2026--project-dependencies-o1o0.png)  

👆 プロジェクトの依存関係を見ていこう

* Effekseer
    * 主なし
* Effekseer.HDRP
    * Effekseer
* Effekseer.PostProcessing
    * Effekseer
* Effekseer.URP
    * Effekseer
* EffekseerEditor
    * Effekseer
* RPGMaker.CodeBase.CoreSystem
    * Effekseer
    * Unity.GraphTools.Foundation.Overdrive
* RPGMaker.CodeBase.Editor
    * Effekseer
    * EffekseerEditor
    * RPGMaker.CodeBase.CoreSystem
    * Unity.GraphTools.Foundation.Overdrive
    * Unity.GraphTools.Foundation.Overdrive.CommandStateObserver
    * Unity.GraphTools.Foundation.Overdrive.Editor
    * Unity.GraphTools.Foundation.Overdrive.Model
* RPGMaker.Unite
    * 主なし
* Unity.GraphTools.Foundation.Editor.Tests
    * Unity.GraphTools.Foundation.Overdrive
    * Unity.GraphTools.Foundation.Overdrive.CommandStateObserver
    * Unity.GraphTools.Foundation.Overdrive.Editor
    * Unity.GraphTools.Foundation.Overdrive.Model
    * Unity.GraphToolsFoundation.Searcher.Editor
    * Unity.InternalAPIEngineBridge.015
* Unity.GraphTools.Foundation.Overdrive
    * Unity.InternalAPIEngineBridge.015
* Unity.GraphTools.Foundation.Overdrive.CommandStateObserver
    * 主なし
* Unity.GraphTools.Foundation.Overdrive.Editor
    * Unity.GraphTools.Foundation.Overdrive
    * Unity.GraphTools.Foundation.Overdrive.CommandStateObserver
    * Unity.GraphTools.Foundation.Overdrive.Model
    * Unity.GraphToolsFoundation.Searcher.Editor
    * Unity.InternalAPIEngineBridge.015
* Unity.GraphTools.Foundation.Overdrive.Model
    * Unity.GraphTools.Foundation.Overdrive.CommandStateObserver
    * Unity.GraphTools.Foundation.Overdrive.Editor
    * Unity.GraphToolsFoundation.Searcher.Editor
    * Unity.InternalAPIEngineBridge.015
* Unity.GraphTools.Foundation.Tests
    * Unity.GraphTools.Foundation.Overdrive
    * Unity.GraphTools.Foundation.Overdrive.CommandStateObserver
    * Unity.InternalAPIEngineBridge.015
* Unity.GraphToolsFoundation.Searcher.Editor
    * 主なし
* Unity.GraphToolsFoundation.Searcher.EditorSamples
    * Unity.GraphToolsFoundation.Searcher.Editor
    * Unity.GraphToolsFoundation.Searcher.ScriptsSamples
* Unity.GraphToolsFoundation.Searcher.EditorTests
    * Unity.GraphToolsFoundation.Searcher.Editor
    * Unity.GraphToolsFoundation.Searcher.EditorSamples
* Unity.GraphToolsFoundation.Searcher.ScriptsSamples
    * 主なし
* Unity.InternalAPIEngineBridge.015
    * 主なし

👆 これを図にすれば、ネットワーク図になっているはずだ。見てみよう  


```
                                                                                                                                                                                                        ┌────────────────┐
                                                                                                                                                                                                        │ RPGMaker.Unite │★要る
                                                                                                                                                                                                        └────────────────┘                    
                                                                                                                                                                                                        ┌───────────────┐
                   ┌────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┤ Effekseer.URP │
                   │                                                                                                                                                                                    └───────────────┘
                   ↓                                                                                                                                                                                    ┌──────────────────────────┐
                   ├────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┤ Effekseer.PostProcessing │
                   │                                                                                                                                                                                    └──────────────────────────┘
                   ↓                                                                                                                                                                                    ┌────────────────┐
                   ├────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┤ Effekseer.HDRP │
                   │                                                                                                                                                                                    └────────────────┘
                   ↓                                                                                                                        ┌─────────────────┐
                   ├────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┤ EffekseerEditor ├←────────────────────────────────────┐
                   │                                                                                                                        └─────────────────┘                                     │
                   ↓                                                                                                                                                                                │
                   ├───────────────────────────────────────────────────────────────────────────────────────────────────────────────┐                                                                │   ┌──────────────────────────┐
┌───────────┐      │                                                                                                               │                                                                ├───┤ RPGMaker.CodeBase.Editor │★要る
│ Effekseer ├←─────┘                                                                                                               │                                                                │   └──────────────────────────┘
└───────────┘                                                                                                                      │                                                                │
                                                                                                                                   │        ┌──────────────────────────────┐                        │
                                                                                                                                   ├────────┤ RPGMaker.CodeBase.CoreSystem ├←───────────────────────┤
                                                                                                                                   │        └──────────────────────────────┘                        │
                                                                                                                                   │                                                                │
┌───────────────────────────────────┐                                  ┌───────────────────────────────────────┐                   │                                                                │
│ Unity.InternalAPIEngineBridge.015 ├←─────────────────────────────────┤ Unity.GraphTools.Foundation.Overdrive ├←──────────────────┘                                                                │
│                                   │                                  │                                       │                                                                                    │
│                                   ├←──────────────────────────┐      │                                       ├←──────────────────┐                                                                │
└───────────────────────────────────┘                           │      │                                       │                   │                                                                │
                                                                │      │                                       ├←──────────┐       │                                                                │
                                                                │      └───────────────────────────────────────┘           │       │                                                                │
                                                                │                                                          │       │                                                                │   ┌───────────────────────────────────┐
                                                                │                                                          │       ├────────────────────────────────────────────────────────────────│───┤ Unity.GraphTools.Foundation.Tests │
                                                                │                                                          │       │                                                                │   └───────────────────────────────────┘
┌────────────────────────────────────────────────────────────┐  │                                                          │       │                                                                │
│ Unity.GraphTools.Foundation.Overdrive.CommandStateObserver ├←────────────────────────────────────────────────────────────────────┘                                                                │
│                                                            │　│                                                          │                                                                        │
│                                                            ├←─┤                                                          │                                                                        │   ┌──────────────────────────────────────────┐
└────────────────────────────────────────────────────────────┘  │                                                          ├←───────────────────────────────────────────────────────────────────────│───┤ Unity.GraphTools.Foundation.Editor.Tests │
                                                                │                                                          │                                                                        │   └──────────────────────────────────────────┘
                                                                │                                                          │                                                                        │
                                                                │                                                          │                ┌──────────────────────────────────────────────┐        │
                                                                │                                                          ├←───────────────┤ Unity.GraphTools.Foundation.Overdrive.Editor ├←───┐   │
                                                                │                                                          │                └──────────────────────────────────────────────┘    │   │
                                                                │                                                          │                                                                    │   │
                                                                │       ┌─────────────────────────────────────────────┐    │                                                                    │   │
                                                                ├───────┤ Unity.GraphTools.Foundation.Overdrive.Model ├←───┘                                                                    │   │
                                                                │       │                                             │                                                                         │   │
                                                                │    ┌──┤                                             ├←────────────────────────────────────────────────────────────────────────────┘
                                                                │    │  └─────────────────────────────────────────────┘                                                                         ↑
                                                                │    │                                                                                                                          │
┌────────────────────────────────────────────┐                  │    │                                                                                                                          │
│                                            ├←─────────────────┘    └──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘
│                                            │
│ Unity.GraphToolsFoundation.Searcher.Editor ├←──────────────┐
└────────────────────────────────────────────┘               │
                                                             │                                                                              ┌───────────────────────────────────────────────────┐       ┌─────────────────────────────────────────────────┐
                                                             ├──────────────────────────────────────────────────────────────────────────────┤ Unity.GraphToolsFoundation.Searcher.EditorSamples ├←──────┤ Unity.GraphToolsFoundation.Searcher.EditorTests │
                                                             │                                                                              └───────────────────────────────────────────────────┘       └─────────────────────────────────────────────────┘
┌────────────────────────────────────────────────────┐       │
│ Unity.GraphToolsFoundation.Searcher.ScriptsSamples ├←──────┘
└────────────────────────────────────────────────────┘
```
