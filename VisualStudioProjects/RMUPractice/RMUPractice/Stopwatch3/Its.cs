namespace RMUPractice.Stopwatch3
{
    using ModelOfStopwatch2 = RMUPractice.Stopwatch2.Its;

    /// <summary>
    /// ストップウォッチ３
    /// </summary>
    public class Its : ModelOfStopwatch2
    {
        // - その他

        internal Its(string itemName)
        {
            this.itemName = itemName;
        }

        // - プロパティ

        internal readonly string itemName;

        /// <summary>
        /// アップデート回数
        /// </summary>
        internal int CountOfUpdate { get; set; }

        /// <summary>
        /// 累計時間
        /// </summary>
        internal TimeSpan Total { get; set; } = TimeSpan.Zero;

        // - メソッド

        internal void Update()
        {
            this.CountOfUpdate++;
            this.Total += this.Elapsed;
        }

        /// <summary>
        /// 文字列化
        /// </summary>
        /// <returns></returns>
        public string StringifyTimeSpan()
        {
            TimeSpan ts = this.Total;
            return $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}'{ts.Milliseconds / 10:00}_";
        }
    }
}
