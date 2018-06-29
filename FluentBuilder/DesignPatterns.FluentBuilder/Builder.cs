namespace DesignPatterns.FluentBuilder
{
    public abstract class Builder
    {
        public abstract Product Build();
        public abstract void IncludePartOne();
        public abstract void IncludePartTwo();
    }
}