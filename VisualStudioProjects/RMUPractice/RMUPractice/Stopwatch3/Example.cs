namespace RMUPractice.Stopwatch3
{
    using ModelOfStopwatch3 = RMUPractice.Stopwatch3.Its;

    static class Example
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
            TestCase1();
            TestCase2();
        }

        static void TestCase1()
        {
            // テーブル作成
            var logFilePath = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "TestCase1.log");
            var tableBuffer1 = new TableBuffer(
                logFilePath: logFilePath);

            // ストップウォッチ生成
            var stopwatch3 = new ModelOfStopwatch3(logFilePath, TimeSpan.Zero);

            // 計測開始
            stopwatch3.Start();

            // ★処理A
            Thread.Sleep(234);

            // 計測停止
            stopwatch3.Stop();
            tableBuffer1.Update(stopwatch3, "テストケース１");

            // 結果表示
            Console.WriteLine(stopwatch3.Stringify(label: "■処理A（234ミリ秒スリープ）にかかった時間"));

            //-----------------

            // 経過時間をリセットしてから計測開始
            stopwatch3.Restart();

            // ★処理B
            Thread.Sleep(234);

            // 計測停止
            stopwatch3.Stop();
            tableBuffer1.Update(stopwatch3, "テストケース１");

            // 結果表示
            Console.WriteLine(stopwatch3.Stringify(label: "■処理B（234ミリ秒スリープ）にかかった時間"));

            //-----------------

            // 計測再開（リセットしない）
            stopwatch3.Start();

            // ★処理C
            Thread.Sleep(234);

            // 計測停止
            stopwatch3.Stop();
            tableBuffer1.Update(stopwatch3, "テストケース１");

            // 結果表示
            Console.WriteLine(stopwatch3.Stringify(label: "■処理Bと処理C（234ミリ秒スリープ）にかかった時間"));

            //-----------------

            // 結果表示
            Console.WriteLine($@"
CSV
====
{stopwatch3.StringifyRecordDictionaryAsCSV()}
");

            // ファイル出力
            Console.WriteLine($"Write log to {tableBuffer1.LogFilePath}");
            tableBuffer1.Save(
                text: stopwatch3.StringifyRecordDictionaryAsCSV());
        }

        static void TestCase2()
        {
            // テーブル作成
            var logFilePath = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "TestCase2.log");
            var tableBuffer2 = new TableBuffer(
                logFilePath: logFilePath);

            // ストップウォッチ生成（２つ目）
            var stopwatch3 = new ModelOfStopwatch3(logFilePath, TimeSpan.Zero);

            // いきなりリスタート
            stopwatch3.Restart();

            // ★処理D
            Thread.Sleep(234);

            // 計測停止
            stopwatch3.Stop();
            tableBuffer2.Update(stopwatch3, "テストケース２");

            // 結果表示
            Console.WriteLine(stopwatch3.Stringify(label: "■処理D（234ミリ秒スリープ）にかかった時間"));

            //-----------------

            // 結果表示
            Console.WriteLine($@"
CSV
====
{stopwatch3.StringifyRecordDictionaryAsCSV()}
");

            // ファイル出力
            Console.WriteLine($"Write log to {tableBuffer2.LogFilePath}");
            tableBuffer2.Save(
                text: stopwatch3.StringifyRecordDictionaryAsCSV());
        }
    }
}
