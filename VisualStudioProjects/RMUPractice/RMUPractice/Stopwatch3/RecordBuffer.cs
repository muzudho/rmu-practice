namespace RMUPractice.Stopwatch3
{
    class RecordBuffer
    {
        // - プロパティ

        /// <summary>
        /// アップデート回数
        /// </summary>
        internal int Count { get; set; }

        /// <summary>
        /// 累計時間
        /// </summary>
        internal TimeSpan TimeSpan { get; set; } = TimeSpan.Zero;
    }
}
