namespace DesignPatterns.Singleton.FullyLazy
{
    public class PrinterRouterFullyLazy
    {
        public static int NumberOfTimesInstanciated { get; private set; }

        private PrinterRouterFullyLazy()
        {
            NumberOfTimesInstanciated++;
        }

        public static PrinterRouterFullyLazy Instance
        {
            get { return Nested.instance; }
        }

        private class Nested
        {
            internal static readonly PrinterRouterFullyLazy instance = new PrinterRouterFullyLazy();

            static Nested()
            {
                
            }
        }
    }
}