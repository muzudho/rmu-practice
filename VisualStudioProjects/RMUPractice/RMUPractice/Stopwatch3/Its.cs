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

        internal Its(TableBuffer tableBuffer, TimeSpan timeSpan)
        {
            this.tableBuffer = tableBuffer;
            this.TimeSpan = timeSpan;
        }

        // - プロパティ

        readonly TableBuffer tableBuffer;

        /// <summary>
        /// アップデート回数
        /// </summary>
        internal int CountOfUpdate { get; set; }

        /// <summary>
        /// 累計時間
        /// </summary>
        internal TimeSpan TimeSpan { get; set; } = TimeSpan.Zero;

        // - メソッド

        /// <summary>
        /// 文字列化
        /// </summary>
        /// <returns></returns>
        public string StringifyTimeSpan()
        {
            TimeSpan ts = this.TimeSpan;
            return $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}'{ts.Milliseconds / 10:00}_";
        }
    }
}
