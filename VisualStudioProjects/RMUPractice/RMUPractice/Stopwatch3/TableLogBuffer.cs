namespace RMUPractice.Stopwatch3
{
    using System.Collections.Concurrent;
    using System.Text;
    using ModelOfStopwatch2 = RMUPractice.Stopwatch2.Its;
    using ModelOfStopwatch3 = RMUPractice.Stopwatch3.Its;

    class TableLogBuffer
    {
        // - その他

        internal TableLogBuffer(string csvLogFilePath, string remarkLogFilePath)
        {
            this.CSVLogFilePath = csvLogFilePath;
            this.RemarkLogFilePath = remarkLogFilePath;
        }

        // - フィールド

        readonly ConcurrentDictionary<string, ModelOfStopwatch3> recordDictionary = new ConcurrentDictionary<string, ModelOfStopwatch3>();

        // - プロパティ

        /// <summary>
        /// 出力ログ・ファイルのパス
        /// 
        /// - CSV形式
        /// </summary>
        internal string CSVLogFilePath { get; private set; }

        /// <summary>
        /// 出力ログ・ファイルのパス
        /// 
        /// - 備考を出力
        /// </summary>
        internal string RemarkLogFilePath { get; private set; }

        /// <summary>
        /// トータル処理時間
        /// </summary>
        internal TimeSpan Total { get; set; }

        // - メソッド

        internal void Update(ModelOfStopwatch3 stopwatch3)
        {
            // 有れば取得、無ければ追加
            stopwatch3 = this.recordDictionary.GetOrAdd(stopwatch3.itemName, stopwatch3);

            // 更新
            stopwatch3.Update();
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
{ModelOfStopwatch2.Stringify(this.Total)}
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
    }
}
