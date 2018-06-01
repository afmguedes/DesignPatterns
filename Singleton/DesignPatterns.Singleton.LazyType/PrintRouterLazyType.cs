using System;

namespace DesignPatterns.Singleton.LazyType
{
    public class PrintRouterLazyType
    {
        public static Lazy<PrintRouterLazyType> lazy = new Lazy<PrintRouterLazyType>(() => new PrintRouterLazyType());
        public static int NumberOfTimesInstanciated { get; private set; }

        public static PrintRouterLazyType Instance
        {
            get { return lazy.Value; }
        }

        private PrintRouterLazyType()
        {
            NumberOfTimesInstanciated++;
        }
    }
}
