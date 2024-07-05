using BackEnd.Entity;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data;

public class RestoContext(DbContextOptions<RestoContext> options) 
    : DbContext(options)
{
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<OrderInfo> OrderInfos => Set<OrderInfo>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {   
        //kada migration gagawa to ng data
        modelBuilder.Entity<OrderInfo>().HasData(
            new {Id=1, OrderName="Fried Siken"},
            new {Id=2, OrderName="Fried Siomai"},
            new {Id=3, OrderName="Fried Siopao"},
            new {Id=4, OrderName="Fried Siokoy"},
            new {Id=5, OrderName="Fried Okoy"}
        );
    }
}
