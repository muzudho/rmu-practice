namespace RPGMakerUnitePractice
{
    /// <summary>
    /// ストップウォッチ２
    /// </summary>
    public class Stopwatch2
    {
        // ストップウォッチ
        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

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
        /// 
        /// - （2015年頃）時計の精度が 1/64 秒ぐらいしかないという話もあるので、ミリ秒の１桁目は切り捨てる
        /// 
        /// </summary>
        /// <returns></returns>
        public string Stringify(string label)
        {
            TimeSpan ts = stopwatch.Elapsed;
            return $@"
{label}
    {ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}'{ts.Milliseconds / 10:00}_
";
        }
    }
}
