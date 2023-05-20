namespace RMUPractice.Stopwatch3
{
    using System.Text;
    using ModelOfStopwatch2 = RMUPractice.Stopwatch2.Its;

    /// <summary>
    /// ストップウォッチ３
    /// </summary>
    public class Its : ModelOfStopwatch2
    {
        // - フィールド

        readonly TableBuffer<string, RecordBuffer> tableBuffer = new TableBuffer<string, RecordBuffer>();

        // - メソッド

        internal void Update(string key)
        {
            tableBuffer.AddOrUpdate(
                key: key,
                addValue: new RecordBuffer(
                    count: 1,
                    timeSpan: this.Elapsed),
                updateValueFactory: (key, recordBuffer) =>
                {
                    recordBuffer.Count++;
                    recordBuffer.TimeSpan += this.Elapsed;
                    return recordBuffer;
                });
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

            this.tableBuffer.ForEach((key, value) =>
            {
                buffer.AppendLine($"{key},{value.Count},{value.StringifyTimeSpan()}");
            });

            return buffer.ToString();
        }

        /// <summary>
        /// 📖 [マルチスレッドで1つのテキストファイルへ書き込みする (C#プログラミング)](https://www.ipentec.com/document/csharp-write-text-file-in-multi-thread-operation)
        /// 📖 [finally を使用してクリーンアップ コードを実行する方法](https://learn.microsoft.com/ja-jp/dotnet/csharp/fundamentals/exceptions/how-to-execute-cleanup-code-using-finally)
        /// </summary>
        public void Save(string filePath, string text)
        {
            FileStream? fs = null;
            StreamWriter? sw = null;
            TextWriter? tw = null;

            try
            {
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
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
    }
}
