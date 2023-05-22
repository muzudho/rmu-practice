namespace RMUPractice.Stopwatch3
{
    using System.Collections.Concurrent;
    using System.Text;
    using TheStopwatch2 = RMUPractice.Stopwatch2.Its;
    using TheStopwatch3 = RMUPractice.Stopwatch3.Its;

    class TableLogBuffer
    {
        // - その他

        internal TableLogBuffer(string csvLogFilePath, string remarkLogFilePath)
        {
            this.CSVLogFilePath = csvLogFilePath;
            this.RemarkLogFilePath = remarkLogFilePath;
        }

        // - フィールド

        readonly ConcurrentDictionary<string, TheStopwatch3> recordDictionary = new ConcurrentDictionary<string, TheStopwatch3>();

        // - プロパティ

        /// <summary>
        /// トータル処理時間
        /// </summary>
        internal TimeSpan Total { get; set; }

        // - メソッド

        internal void Update(TheStopwatch3 stopwatch)
        {
            // 有れば取得、無ければ追加
            var targetStopwatch = this.recordDictionary.GetOrAdd(stopwatch.itemName, stopwatch);

            // 既存のストップ・ウォッチに経過時間を足す
            targetStopwatch.Update(stopwatch.Elapsed);
        }

        /// <summary>
        /// 📖 [マルチスレッドで1つのテキストファイルへ書き込みする (C#プログラミング)](https://www.ipentec.com/document/csharp-write-text-file-in-multi-thread-operation)
        /// 📖 [finally を使用してクリーンアップ コードを実行する方法](https://learn.microsoft.com/ja-jp/dotnet/csharp/fundamentals/exceptions/how-to-execute-cleanup-code-using-finally)
        /// </summary>
        public void Save()
        {
            SaveCSV();
            SaveRemark();
        }

        void SaveCSV()
        {
            string text = this.StringifyRecordDictionaryAsCSV();

            FileStream? fs = null;
            StreamWriter? sw = null;
            TextWriter? tw = null;

            try
            {
                fs = new FileStream(this.CSVLogFilePath, FileMode.OpenOrCreate, FileAccess.Write);
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

        void SaveRemark()
        {
            string text = $@"Total
=====
{TheStopwatch2.Stringify(this.Total)}
";

            FileStream? fs = null;
            StreamWriter? sw = null;
            TextWriter? tw = null;

            try
            {
                fs = new FileStream(this.RemarkLogFilePath, FileMode.OpenOrCreate, FileAccess.Write);
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

        // - プライベート・プロパティ

        /// <summary>
        /// 出力ログ・ファイルのパス
        /// 
        /// - CSV形式
        /// </summary>
        string CSVLogFilePath { get; set; }

        /// <summary>
        /// 出力ログ・ファイルのパス
        /// 
        /// - 備考を出力
        /// </summary>
        string RemarkLogFilePath { get; set; }
    }
}
