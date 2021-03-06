﻿namespace DesignPatterns.ChainOfResponsibility.Handlers
{
    public abstract class Handler
    {
        public Handler Successor;

        public void SetSuccessor(Handler handler)
        {
            Successor = handler;
        }

        public abstract int Handle(int requestType);
    }
}