namespace AsynchronousTimer
{
    using System;

    class AsynchronousTimerTester
    {
        static void Main()
        {
            AsynchronousTimer asyncTimer = new AsynchronousTimer(DoSomething, 15, 1000);
            asyncTimer.StartAsync();
        }

        public static void DoSomething()
        {
            Console.WriteLine("Whaaat");
        }
    }
}
