namespace RMUPractice.Stopwatch3
{
    using System.Text;
    using ModelOfStopwatch2 = RMUPractice.Stopwatch2.Its;

    /// <summary>
    /// ストップウォッチ３
    /// </summary>
    public class Its : ModelOfStopwatch2
    {
        // - その他

        internal Its(string filePathToSave)
        {
            this.tableBuffer = new TableBuffer<string, RecordBuffer>(filePathToSave);
        }

        // - フィールド

        readonly TableBuffer<string, RecordBuffer> tableBuffer;

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
    }
}
