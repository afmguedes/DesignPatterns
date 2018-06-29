namespace DesignPatterns.FluentBuilder
{
    public class ConcreteBuilderAb : Builder
    {
        private readonly Product product = new Product();

        public override void IncludePartOne()
        {
            product.Add("Part A");
        }

        public override void IncludePartTwo()
        {
            product.Add("Part B");
        }

        public override Product Build()
        {
            return product;
        }
    }
}