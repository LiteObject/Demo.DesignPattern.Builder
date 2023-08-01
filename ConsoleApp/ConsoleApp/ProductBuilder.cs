namespace ConsoleApp
{
    public class ProductBuilder : IProductBuilder
    {
        private readonly Product _product = new();

        public IProductBuilder SetName(string name)
        {
            _product.Name = name;
            return this;
        }

        public IProductBuilder SetDescription(string description)
        {
            _product.Description = description;
            return this;
        }

        public IProductBuilder SetPrice(decimal price)
        {
            _product.Price = price;
            return this;
        }

        public IProductBuilder SetQuantity(int quantity)
        {
            _product.Quantity = quantity;
            return this;
        }

        public Product Build()
        {
            return _product;
        }
    }
}