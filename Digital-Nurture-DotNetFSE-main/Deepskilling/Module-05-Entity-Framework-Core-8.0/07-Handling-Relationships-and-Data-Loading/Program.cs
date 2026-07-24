using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RelationshipsDemo.Data;
var cfg=new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
var opt=new DbContextOptionsBuilder<AppDbContext>().UseSqlServer(cfg.GetConnectionString("DefaultConnection")).Options;
using var db=new AppDbContext(opt);
Console.WriteLine("Relationships Demo configured successfully.");