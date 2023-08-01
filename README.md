# Builder Design Pattern

The Builder design pattern is a creational pattern that separates 
the construction of a complex object from its representation. 
 
It allows you to create an object step by step, using a builder 
class that abstracts away the creation details and provides a 
simple API for building the object. 
 
The builder class typically exposes methods for setting the various 
properties of the object, and a method for building the final object.
This allows for greater flexibility in object creation, as well as 
improved readability and maintainability of code that creates complex 
objects. Additionally, the builder pattern can help to improve the 
testability of code by allowing for easier creation of mock objects.

## Explanation of the demo project
In this example, we have a `Product` class that has several properties, 
including Name, Description, Price, and Quantity.

```csharp
public class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
```

We then define an interface `IProductBuilder` that defines methods for 
setting each of these properties, as well as a `Build()` method that 
returns a `Product` instance.

```csharp
public interface IProductBuilder
{
    IProductBuilder SetName(string name);
    IProductBuilder SetDescription(string description);
    IProductBuilder SetPrice(decimal price);
    IProductBuilder SetQuantity(int quantity);
    Product Build();
}
```

Next, we define a concrete implementation of the `IProductBuilder` 
interface, called `ProductBuilder`. This class maintains an internal 
`Product` instance, and each setter method returns the builder instance 
itself, allowing method chaining.

```csharp
public class ProductBuilder : IProductBuilder
{
    private readonly Product _product = new Product();

    public IProductBuilder SetName(string name)
    {
        _product.Name = name;
        return this;
    }

	...
}
```

Finally, we demonstrate the usage of the Builder design pattern by 
creating a new `ProductBuilder` instance, setting the various properties 
using method chaining, and calling the `Build()` method to obtain a fully 
constructed Product instance.

```csharp
var productBuilder = new ProductBuilder();
var product = productBuilder
    .SetName("Product A")
    .SetDescription("This is Product A")
    .SetPrice(9.99m)
    .SetQuantity(10)
    .Build();
```

The Builder design pattern is useful when you have complex object 
creation logic that you want to encapsulate in a separate class, 
or when you want to provide a fluent interface for building objects 
with many properties.