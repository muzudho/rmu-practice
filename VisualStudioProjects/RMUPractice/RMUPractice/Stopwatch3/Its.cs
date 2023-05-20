namespace RMUPractice.Stopwatch3
{
    using System.Collections.Concurrent;
    using System.Text;
    using ModelOfStopwatch2 = RMUPractice.Stopwatch2.Its;

    /// <summary>
    /// ストップウォッチ３
    /// </summary>
    public class Its : ModelOfStopwatch2
    {
        // - フィールド

        readonly ConcurrentDictionary<string, RecordBuffer> recordDictionary = new ConcurrentDictionary<string, RecordBuffer>();

        // - メソッド

        internal void Update(string key)
        {
            recordDictionary.AddOrUpdate(
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

            foreach (var pair in this.recordDictionary)
            {
                buffer.AppendLine($"{pair.Key},{pair.Value.Count},{pair.Value.StringifyTimeSpan()}");
            }

            return buffer.ToString();
        }
    }
}
