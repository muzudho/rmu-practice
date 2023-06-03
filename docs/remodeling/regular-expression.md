# 正規表現

Visual Studio 2022 使用  

## １

```
            <summary>
        /// 
        /// </summary>
        private void ProcessEndAction()
```

を

```
        /// <summary>
        /// 😁 終了処理
        /// </summary>
        private void ProcessEndAction()
```

に置き換えるなら

```
<summary>(.*)\r\n(.*)///(\s*)\r\n(.*)</summary>\r\n(.*)private void ProcessEndAction\(\)
```

```
<summary>$1\r\n$2/// 😁 終了処理$3\r\n$4</summary>\r\n$5private void ProcessEndAction()
```

とする
