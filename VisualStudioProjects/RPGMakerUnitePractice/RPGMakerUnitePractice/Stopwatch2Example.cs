namespace RPGMakerUnitePractice
{
    static class Stopwatch2Example
    {
        /// <summary>
        /// エグザンプル
        /// 
        /// References:
        /// 📖 [C#メモ　処理時間計測](https://qiita.com/Kosen-amai/items/81efaf815b48ab9ffbb6)
        /// 📖 [或るプログラマの一生](http://umezawa.dyndns.info/wordpress/?p=5368)
        /// </summary>
        internal static void DoIt()
        {
            // ストップウォッチ生成
            var stopwatch = new Stopwatch2();

            // 計測開始
            stopwatch.Start();

            // ★処理A
            Thread.Sleep(234);

            // 計測停止
            stopwatch.Stop();

            // 結果表示
            Console.WriteLine(stopwatch.Stringify(label: "■処理A（234ミリ秒スリープ）にかかった時間"));

            //-----------------

            // 経過時間をリセットしてから計測開始
            stopwatch.Restart();

            // ★処理B
            Thread.Sleep(234);

            // 計測停止
            stopwatch.Stop();

            // 結果表示
            Console.WriteLine(stopwatch.Stringify(label: "■処理B（234ミリ秒スリープ）にかかった時間"));

            //-----------------

            // 計測再開（リセットしない）
            stopwatch.Start();

            // ★処理C
            Thread.Sleep(234);

            // 計測停止
            stopwatch.Stop();

            // 結果表示
            Console.WriteLine(stopwatch.Stringify(label: "■処理Bと処理C（234ミリ秒スリープ）にかかった時間"));
        }
    }
}
