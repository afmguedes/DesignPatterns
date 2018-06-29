namespace DesignPatterns.FluentBuilder
{
    public class ConcreteBuilderCd : Builder
    {
        public readonly Product Product = new Product();

        public override void IncludePartOne()
        {
            Product.Add("Part C");
        }

        public override void IncludePartTwo()
        {
            Product.Add("Part D");
        }

        public override Product Build()
        {
            return Product;
        }
    }
}