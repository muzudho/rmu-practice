namespace RMUPractice.Stopwatch4
{
    using TheStopwatch = RMUPractice.Stopwatch3.Its;

    class Its : TheStopwatch
    {
        // - その他

        Its(string itemName)
            : base(itemName)
        {
        }

        // - 静的メソッド

        internal static Its Start(string itemName)
        {
            var stopwatch = new Its(itemName);
            stopwatch.Start();
            return stopwatch;
        }
    }
}
