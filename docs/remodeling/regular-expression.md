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

## ２

```
            <summary>
        /// 
        /// </summary>
        /// <param name="eventID"></param>
        /// <param name="command"></param>
        protected override void Process(string eventID, EventDataModel.EventCommand command)
```

を

```
            <summary>
        /// 😁 処理
        /// </summary>
        /// <param name="eventID">イベントＩｄ</param>
        /// <param name="command">命令</param>
        protected override void Process(string eventID, EventDataModel.EventCommand command)
```

に置き換えるなら

```
<summary>(.*)\r\n(\s*)///(.*)\r\n(\s*)///(.*)</summary>\r\n(\s*)///(.*)<param name="eventID"></param>\r\n(\s*)///(.*)<param name="command"></param>\r\n(\s*)protected override void Process\(string eventID, EventDataModel.EventCommand command\)
```

```
<summary>$1\r\n$2/// 😁 処理$3\r\n$4///$5</summary>\r\n$6///$7<param name="eventID">イベントＩｄ</param>\r\n$8///$9<param name="command">命令</param>\r\n$10protected override void Process(string eventID, EventDataModel.EventCommand command)
```

とする
