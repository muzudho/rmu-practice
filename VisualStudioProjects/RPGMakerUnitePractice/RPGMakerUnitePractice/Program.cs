// See https://aka.ms/new-console-template for more information

// 📖 [C#メモ　処理時間計測](https://qiita.com/Kosen-amai/items/81efaf815b48ab9ffbb6)
// 📖 [或るプログラマの一生](http://umezawa.dyndns.info/wordpress/?p=5368)

// ストップウォッチ
var stopwatch = new System.Diagnostics.Stopwatch();

// 計測開始
stopwatch.Start();

// ★処理A
Thread.Sleep(234);

// 計測停止
stopwatch.Stop();

//
// 結果表示
//
// - （2015年頃）時計の精度が 1/64 秒ぐらいしかないという話もあるので、ミリ秒の１桁目は切り捨てる
//
TimeSpan ts = stopwatch.Elapsed;
Console.WriteLine($@"
■処理Aにかかった時間
　{ts}
　{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}'{ts.Milliseconds/10:00}X
　{stopwatch.ElapsedMilliseconds}ミリ秒
");

//-----------------
// 経過時間をリセットしてから計測開始
stopwatch.Restart();

// ★処理B
Thread.Sleep(234);

// 計測停止
stopwatch.Stop();

// 結果表示
ts = stopwatch.Elapsed;
Console.WriteLine($@"
■処理Aにかかった時間
　{ts}
　{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}'{ts.Milliseconds / 10:00}X
　{stopwatch.ElapsedMilliseconds}ミリ秒
");

//-----------------
// 計測再開（リセットしない）
stopwatch.Start();

// ★処理C
Thread.Sleep(234);

// 計測停止
stopwatch.Stop();

// 結果表示
ts = stopwatch.Elapsed;
Console.WriteLine($@"
■処理BとCにかかった時間
　{ts}
　{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}'{ts.Milliseconds / 10:00}X
　{stopwatch.ElapsedMilliseconds}ミリ秒
");
