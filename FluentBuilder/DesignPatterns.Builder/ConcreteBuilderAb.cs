namespace DesignPatterns.Builder
{
    public class ConcreteBuilderAb : Builder
    {
        public readonly Product Product = new Product();

        public override void IncludePartOne()
        {
            Product.Add("Part A");
        }

        public override void IncludePartTwo()
        {
            Product.Add("Part B");
        }

        public override Product Build()
        {
            return Product;
        }
    }
}