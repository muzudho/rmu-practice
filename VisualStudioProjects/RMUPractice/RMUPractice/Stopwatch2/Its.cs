namespace RMUPractice.Stopwatch2
{
    /// <summary>
    /// ストップウォッチ２
    /// </summary>
    class Its
    {
        // - フィールド

        // ストップウォッチ
        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

        // - プロパティ

        internal TimeSpan Elapsed => stopwatch.Elapsed;

        // - メソッド

        /// <summary>
        /// 計測開始
        /// </summary>
        public void Start()
        {
            stopwatch.Start();
        }

        /// <summary>
        /// 経過時間をリセットしてから計測開始
        /// </summary>
        public void Restart()
        {
            stopwatch.Restart();
        }

        /// <summary>
        /// 計測停止
        /// </summary>
        public void Stop()
        {
            stopwatch.Stop();
        }

        /// <summary>
        /// 文字列化
        /// </summary>
        /// <returns></returns>
        internal string Stringify(string label)
        {
            TimeSpan ts = stopwatch.Elapsed;

            return $@"
{label}
    {this.StringifyTimeSpan()}
            ";
        }

        /// <summary>
        /// 文字列化
        /// </summary>
        /// <returns></returns>
        internal string StringifyTimeSpan()
        {
            TimeSpan ts = stopwatch.Elapsed;

            return Stringify(ts);
        }

        internal static string Stringify(TimeSpan span)
        {
            //// - （2015年頃）CPUの時間計測の精度が 1/64 秒ぐらいしかないという話もあるので、ミリ秒の１桁目は切り捨てる
            //            return $@"
            //{label}
            //    {ts.hours:00}:{ts.minutes:00}:{ts.seconds:00}'{ts.milliseconds / 10:00}_
            //";

            return $"{span.Hours:00}:{span.Minutes:00}:{span.Seconds:00}'{span.Milliseconds:000}";
        }
    }
}
