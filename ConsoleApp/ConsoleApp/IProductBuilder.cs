namespace ConsoleApp
{
    public interface IProductBuilder
    {
        IProductBuilder SetName(string name);
        IProductBuilder SetDescription(string description);
        IProductBuilder SetPrice(decimal price);
        IProductBuilder SetQuantity(int quantity);
        Product Build();
    }
}