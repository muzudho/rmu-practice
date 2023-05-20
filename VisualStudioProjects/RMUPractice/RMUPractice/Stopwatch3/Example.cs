namespace RMUPractice.Stopwatch3
{
    using ModelOfStopwatch3 = RMUPractice.Stopwatch3.Its;

    static class Example
    {
        // テーブル型ログ
        static readonly TableLogBuffer tableLog = new TableLogBuffer(
            csvLogFilePath: Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "RMUPractice-Stopwatch-Table.csv"),
            remarkLogFilePath: Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "RMUPractice-Stopwatch-Info.log"));

        /// <summary>
        /// エグザンプル
        /// 
        /// References:
        /// 📖 [C#メモ　処理時間計測](https://qiita.com/Kosen-amai/items/81efaf815b48ab9ffbb6)
        /// 📖 [或るプログラマの一生](http://umezawa.dyndns.info/wordpress/?p=5368)
        /// </summary>
        internal static void DoIt()
        {
            TestCase1();
            TestCase2();
        }

        static void TestCase1()
        {
            // ストップウォッチ生成
            var stopwatch3 = new ModelOfStopwatch3("ストップウォッチ１");

            // 計測開始
            stopwatch3.Start();

            // ★処理A
            Thread.Sleep(234);

            // 計測停止
            stopwatch3.Stop();
            tableLog.Update(stopwatch3);
            tableLog.Total += stopwatch3.Elapsed;

            // 結果表示
            Console.WriteLine(stopwatch3.Stringify(label: "■処理A（234ミリ秒スリープ）にかかった時間"));

            //-----------------

            // 経過時間をリセットしてから計測開始
            stopwatch3.Restart();

            // ★処理B
            Thread.Sleep(234);

            // 計測停止
            stopwatch3.Stop();
            tableLog.Update(stopwatch3);

            // 結果表示
            Console.WriteLine(stopwatch3.Stringify(label: "■処理B（234ミリ秒スリープ）にかかった時間"));

            //-----------------

            // 計測再開（リセットしない）
            stopwatch3.Start();

            // ★処理C
            Thread.Sleep(234);

            // 計測停止
            stopwatch3.Stop();
            tableLog.Update(stopwatch3);
            tableLog.Total += stopwatch3.Elapsed;

            // 結果表示
            Console.WriteLine(stopwatch3.Stringify(label: "■処理Bと処理C（234ミリ秒スリープ）にかかった時間"));

            //-----------------

            // 結果表示
            Console.WriteLine($@"
CSV
====
{tableLog.StringifyRecordDictionaryAsCSV()}
");

            // ファイル出力
            Console.WriteLine($"Write log to {tableLog.CSVLogFilePath}");
            tableLog.Save();
        }

        static void TestCase2()
        {
            // ストップウォッチ生成（２つ目）
            var stopwatch3 = new ModelOfStopwatch3("ストップウォッチ２");

            // いきなりリスタート
            stopwatch3.Restart();

            // ★処理D
            Thread.Sleep(234);

            // 計測停止
            stopwatch3.Stop();
            tableLog.Update(stopwatch3);
            tableLog.Total += stopwatch3.Elapsed;

            // 結果表示
            Console.WriteLine(stopwatch3.Stringify(label: "■処理D（234ミリ秒スリープ）にかかった時間"));

            //-----------------

            // 結果表示
            Console.WriteLine($@"
CSV
====
{tableLog.StringifyRecordDictionaryAsCSV()}
");

            // ファイル出力
            Console.WriteLine($"Write log to {tableLog.CSVLogFilePath}");
            tableLog.Save();
        }
    }
}
