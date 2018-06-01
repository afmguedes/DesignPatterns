using System;

namespace DesignPatterns.Singleton.ThreadSafetyDoubleLock
{
    public class PrintRouterThreadSafetyDoubleLock
    {
        private static PrintRouterThreadSafetyDoubleLock instance;
        private static object padlock = new object();
        public static int NumberOfTimesInstanciated { get; private set; }

        private PrintRouterThreadSafetyDoubleLock()
        {
            NumberOfTimesInstanciated++;
        }

        public static PrintRouterThreadSafetyDoubleLock Instance
        {
            get
            {
                if (instance == null)
                    lock (padlock)
                        if (instance == null)
                            instance = new PrintRouterThreadSafetyDoubleLock();

                return instance;
            }
        }
    }
}
