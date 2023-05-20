namespace RMUPractice.Stopwatch3
{
    using System.Collections.Concurrent;
    using System.Text;

    class TableBuffer<TKey, TValue> where TKey : notnull
    {
        // - その他

        internal TableBuffer(string filePathToSave)
        {
            this.FilePathToSave = filePathToSave;
        }

        // - フィールド

        readonly ConcurrentDictionary<TKey, TValue> recordDictionary = new ConcurrentDictionary<TKey, TValue>();

        // - プロパティ

        internal string FilePathToSave { get; private set; }

        // - メソッド

        internal void AddOrUpdate(TKey key, TValue addValue, Func<TKey, TValue, TValue> updateValueFactory)
        {
            this.recordDictionary.AddOrUpdate(key, addValue, updateValueFactory);
        }

        internal delegate void SetPair(TKey key, TValue value);

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
                fs = new FileStream(this.FilePathToSave, FileMode.OpenOrCreate, FileAccess.Write);
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
