namespace RMUPractice.Stopwatch3
{
    using TheStopwatch = RMUPractice.Stopwatch2.Its;

    /// <summary>
    /// ストップウォッチ３
    /// </summary>
    class Its : TheStopwatch
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

        internal void Update(TimeSpan addSpan)
        {
            this.CountOfUpdate++;
            this.Total += addSpan;
        }
    }
}
