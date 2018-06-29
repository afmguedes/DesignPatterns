namespace DesignPatterns.FluentBuilder
{
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.IncludePartOne();
            builder.IncludePartTwo();
        }
    }
}