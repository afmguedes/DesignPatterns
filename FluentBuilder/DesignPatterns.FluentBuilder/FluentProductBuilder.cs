namespace DesignPatterns.FluentBuilder
{
    public class FluentProductBuilder
    {
        private readonly Product product = new Product();

        public FluentProductBuilder WithPartOne(string partOne)
        {
            product.PartOne = partOne;
            return this;
        }

        public FluentProductBuilder WithPartTwo(string partTwo)
        {
            product.PartTwo = partTwo;
            return this;
        }

        public Product Build()
        {
            return product;
        }
    }
}