namespace RMUPractice.Stopwatch3
{
    class RecordBuffer
    {
        // - その他

        internal RecordBuffer(int count, TimeSpan timeSpan)
        {
            this.Count = count;
            this.TimeSpan = timeSpan;
        }

        // - プロパティ

        /// <summary>
        /// アップデート回数
        /// </summary>
        internal int Count { get; set; }

        /// <summary>
        /// 累計時間
        /// </summary>
        internal TimeSpan TimeSpan { get; set; }

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
