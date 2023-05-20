namespace RMUPractice.Stopwatch3
{
    using System.Collections.Concurrent;
    using System.Text;
    using ModelOfStopwatch3 = RMUPractice.Stopwatch3.Its;

    class TableBuffer
    {
        // - その他

        internal TableBuffer(string logFilePath)
        {
            this.LogFilePath = logFilePath;
        }

        // - フィールド

        readonly ConcurrentDictionary<string, ModelOfStopwatch3> recordDictionary = new ConcurrentDictionary<string, ModelOfStopwatch3>();

        // - プロパティ

        /// <summary>
        /// 出力ログ・ファイルのパス
        /// </summary>
        internal string LogFilePath { get; private set; }

        // - メソッド

        internal void AddOrUpdate(string itemName, ModelOfStopwatch3 addValue, Func<string, ModelOfStopwatch3, ModelOfStopwatch3> updateValueFactory)
        {
            this.recordDictionary.AddOrUpdate(itemName, addValue, updateValueFactory);
        }

        internal void Update(ModelOfStopwatch3 stopwatch3, string itemName)
        {
            this.AddOrUpdate(
                itemName: itemName,
                addValue: new Its(
                    tableBuffer: this,
                    timeSpan: stopwatch3.Elapsed),
                updateValueFactory: (key, recordBuffer) =>
                {
                    stopwatch3.CountOfUpdate++;
                    stopwatch3.TimeSpan += stopwatch3.Elapsed;
                    return recordBuffer;
                });
        }

        internal delegate void SetPair(string itemName, ModelOfStopwatch3 value);

        internal void ForEach(SetPair setPair)
        {
            foreach (var pair in this.recordDictionary)
            {
                setPair(pair.Key, pair.Value);
            }
        }

        /// <summary>
        /// 📖 [マルチスレッドで1つのテキストファイルへ書き込みする (C#プログラミング)](https://www.ipentec.com/document/csharp-write-text-file-in-multi-thread-operation)
        /// 📖 [finally を使用してクリーンアップ コードを実行する方法](https://learn.microsoft.com/ja-jp/dotnet/csharp/fundamentals/exceptions/how-to-execute-cleanup-code-using-finally)
        /// </summary>
        public void Save(string text)
        {
            FileStream? fs = null;
            StreamWriter? sw = null;
            TextWriter? tw = null;

            try
            {
                fs = new FileStream(this.LogFilePath, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs, Encoding.UTF8);
                tw = TextWriter.Synchronized(sw);

                tw.WriteLine(text);
            }
            finally
            {
                if (tw != null)
                {
                    tw.Close();
                }

                if (sw != null)
                {
                    sw.Close();
                }

                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        /// <summary>
        /// 文字列化
        /// 
        /// - CSV形式
        /// 
        /// </summary>
        /// <returns></returns>
        public string StringifyRecordDictionaryAsCSV()
        {
            StringBuilder buffer = new StringBuilder();

            foreach (var pair in this.recordDictionary)
            {
                buffer.AppendLine($"{pair.Key},{pair.Value.CountOfUpdate},{pair.Value.StringifyTimeSpan()}");
            }

            return buffer.ToString();
        }
    }
}
