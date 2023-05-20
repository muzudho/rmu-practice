namespace RMUPractice.Stopwatch3
{
    using System.Collections.Concurrent;

    class TableBuffer<TKey, TValue> where TKey : notnull
    {
        // - フィールド

        readonly ConcurrentDictionary<TKey, TValue> recordDictionary = new ConcurrentDictionary<TKey, TValue>();

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
    }
}
