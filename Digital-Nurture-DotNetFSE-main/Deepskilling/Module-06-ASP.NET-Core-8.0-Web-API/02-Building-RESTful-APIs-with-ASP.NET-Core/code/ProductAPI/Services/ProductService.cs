using System.Collections.Generic;
public class ProductService{
private readonly List<Product> products=new(){new Product{Id=1,Name="Laptop",Price=50000}};
public IEnumerable<Product> GetAll()=>products;
}