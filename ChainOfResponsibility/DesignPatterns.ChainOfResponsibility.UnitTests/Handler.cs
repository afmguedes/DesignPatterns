namespace DesignPatterns.ChainOfResponsibility.UnitTests
{
    public abstract class Handler
    {
        public Handler Successor;

        public void SetSuccessor(Handler handler)
        {
            Successor = handler;
        }
    }
}