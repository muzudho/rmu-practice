namespace RMUPractice.Stopwatch4
{
    using TheStopwatch = RMUPractice.Stopwatch4.Its;

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
            // ストップウォッチ生成、かつスタート
            var apple = TheStopwatch.Start("テストケース１　ストップウォッチ１");

            // ★処理A
            Thread.Sleep(234);

            // 旧ストップウォッチ停止、かつ新ストップウォッチ生成、かつスタート
            var banana = tableLog.Restart(apple, "テストケース１　ストップウォッチ２");

            // 結果表示
            Console.WriteLine(apple.Stringify(label: "■処理A（234ミリ秒スリープ）にかかった時間"));

            //-----------------

            // ★処理B
            Thread.Sleep(234);

            // 旧ストップウォッチ停止、かつ新ストップウォッチ生成、かつスタート
            var cherry = tableLog.Restart(banana, "テストケース１　ストップウォッチ３");

            // 結果表示
            Console.WriteLine(banana.Stringify(label: "■処理B（234ミリ秒スリープ）にかかった時間"));

            //-----------------

            // ★処理C
            Thread.Sleep(234);

            // 計測停止（ストップウォッチはリセット済）
            tableLog.Stop(cherry);

            // 結果表示
            Console.WriteLine(cherry.Stringify(label: "■処理Bと処理C（234ミリ秒スリープ）にかかった時間"));

            //-----------------

            // 結果表示
            Console.WriteLine($@"
CSV
====
{tableLog.StringifyRecordDictionaryAsCSV()}
");

            // ファイル出力
            Console.WriteLine($@"Write log to {tableLog.CSVLogFilePath}
         and {tableLog.RemarkLogFilePath}");
            tableLog.Save();
        }

        static void TestCase2()
        {
            // ストップウォッチ生成（２つ目）かつ、スタート
            var apple = TheStopwatch.Start("ストップウォッチ２");

            // ★処理D
            Thread.Sleep(234);

            // 計測停止
            tableLog.Stop(apple);

            // 結果表示
            Console.WriteLine(apple.Stringify(label: "■処理D（234ミリ秒スリープ）にかかった時間"));

            //-----------------

            // 結果表示
            Console.WriteLine($@"
CSV
====
{tableLog.StringifyRecordDictionaryAsCSV()}
");

            // ファイル出力
            Console.WriteLine($@"Write log to {tableLog.CSVLogFilePath}
         and {tableLog.RemarkLogFilePath}");
            tableLog.Save();
        }
    }
}
