namespace DesignPatterns.Builder
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