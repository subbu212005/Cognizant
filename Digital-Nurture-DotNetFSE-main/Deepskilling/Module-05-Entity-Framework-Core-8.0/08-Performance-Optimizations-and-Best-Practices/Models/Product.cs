using System.ComponentModel.DataAnnotations;

namespace PerformanceDemo.Models;
public class Product{
 public int Id{get;set;}
 public string Name{get;set;}=string.Empty;
 public decimal Price{get;set;}
 [ConcurrencyCheck]
 public int Version{get;set;}
}