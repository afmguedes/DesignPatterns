using System;

namespace DesignPatterns.Singleton.NotThreadSafe
{
    public class PrintRouterNotThreadSafe
    {
        private static PrintRouterNotThreadSafe instance;
        public static int NumberOfTimesInstanciated { get; private set; }

        private PrintRouterNotThreadSafe()
        {
            NumberOfTimesInstanciated++;
        }

        public static PrintRouterNotThreadSafe Instance
        {
            get
            {
                if (instance == null)
                    instance = new PrintRouterNotThreadSafe();

                return instance;
            }
        }
    }
}
