namespace RMUPractice.Stopwatch3
{
    using System.Collections.Concurrent;
    using ModelOfStopwatch2 = RMUPractice.Stopwatch2.Its;

    /// <summary>
    /// ストップウォッチ３
    /// </summary>
    public class Its : ModelOfStopwatch2
    {
        // - フィールド

        ConcurrentDictionary<string, RecordBuffer> recordDictionary = new ConcurrentDictionary<string, RecordBuffer>();

        // - メソッド

        internal void Update(string key)
        {
            recordDictionary.AddOrUpdate(
                key: key,
                addValue: new RecordBuffer(),
                updateValueFactory: (key, recordBuffer) =>
                {
                    recordBuffer.Count++;
                    recordBuffer.TimeSpan += this.Elapsed;
                    return recordBuffer;
                });
        }
    }
}
