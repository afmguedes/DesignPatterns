using System;

namespace DesignPatterns.Singleton.NotFullLazy
{
    public class PrintRouterNotFullLazy
    {
        private static readonly PrintRouterNotFullLazy instance = new PrintRouterNotFullLazy();
        public static int NumberOfTimesInstanciated { get; }

        static PrintRouterNotFullLazy()
        {
            NumberOfTimesInstanciated++;
        }

        //private PrintRouterNotFullLazy()
        //{

        //}

        public static PrintRouterNotFullLazy Instance
        {
            get { return instance; }
        }
    }
}
