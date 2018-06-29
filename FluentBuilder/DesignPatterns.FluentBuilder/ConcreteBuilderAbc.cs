namespace DesignPatterns.FluentBuilder
{
    public class ConcreteBuilderAbc : Builder
    {
        private readonly Product product = new Product();

        public override Product Build()
        {
            return product;
        }
    }
}