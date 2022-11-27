using ShopApp.Models;

var products = new List<Product>();
var shoppingCart = new ShoppingCart();
Product milk = new Product { ProductName = "Milk", Price = 3.49m };
products.Add(milk);

Console.WriteLine("Welcome to shop");
Console.WriteLine("List of products :");