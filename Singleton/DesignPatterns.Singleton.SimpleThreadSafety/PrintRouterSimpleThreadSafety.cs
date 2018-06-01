using System;

namespace DesignPatterns.Singleton.SimpleThreadSafety
{
    public class PrintRouterSimpleThreadSafety
    {
        private static PrintRouterSimpleThreadSafety instance;
        private static readonly object padlock = new object();
        public static int NumberOfTimesInstanciated { get; private set; }

        private PrintRouterSimpleThreadSafety()
        {
            NumberOfTimesInstanciated++;
        }

        public static PrintRouterSimpleThreadSafety Instance
        {
            get
            {
                lock (padlock)
                    if (instance == null)
                        instance = new PrintRouterSimpleThreadSafety();

                return instance;
            }
        }
    }
}
