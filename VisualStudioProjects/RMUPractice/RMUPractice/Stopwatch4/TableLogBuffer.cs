namespace RMUPractice.Stopwatch4
{
    using TheStopwatch = RMUPractice.Stopwatch4.Its;
    using TheTableLogBuffer = RMUPractice.Stopwatch3.TableLogBuffer;

    class TableLogBuffer : TheTableLogBuffer
    {
        // - その他

        internal TableLogBuffer(string csvLogFilePath, string remarkLogFilePath)
            : base(csvLogFilePath, remarkLogFilePath)
        {
        }

        // - メソッド

        internal TheStopwatch Restart(TheStopwatch oldStopwatch, string itemName)
        {
            oldStopwatch.Stop();
            this.Update(oldStopwatch);
            this.Total += oldStopwatch.Elapsed;
            this.Save();

            return TheStopwatch.Start(itemName);
        }

        internal void Stop(TheStopwatch stopwatch)
        {
            stopwatch.Stop();
            this.Update(stopwatch);
            this.Total += stopwatch.Elapsed;
            this.Save();
        }
    }
}
