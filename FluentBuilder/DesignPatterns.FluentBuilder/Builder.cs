﻿namespace DesignPatterns.FluentBuilder
{
    public abstract class Builder
    {
        public abstract void IncludePartOne();
        public abstract void IncludePartTwo();
        public abstract Product Build();
    }
}