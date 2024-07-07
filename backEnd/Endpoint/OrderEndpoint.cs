using BackEnd.Data;
using BackEnd.Dtos;
using BackEnd.Entity;
using BackEnd.Mapping;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Endpoint;

public static class OrderEndpoints
{
    const string EndpointOrderName = "GetOrder";

    public static RouteGroupBuilder MapOrderEndpoints(this WebApplication app)
    {

        var OrderEP = app.MapGroup("Orders")//order End Point
                         .WithParameterValidation();

        //get customer orders
        OrderEP.MapGet("/", (RestoContext dbContext) => {
            return dbContext.Orders
                            .Include(order => order.OrderInfo)//para bawat order mainclude yung bawat info nung order meaning name
                            .Select(order => order.ToOrderSummaryDto())
                            .AsNoTracking() //to optimize dont track basically gamitin lang to if giving data
                            .ToListAsync(); //basically one liner async await
        });

        //.Find is basically Find
        //GET!
        OrderEP.MapGet("/{id}", async (int id, RestoContext dbContext) =>
        {
            Order? order = await dbContext.Orders.FindAsync(id);

            return order is null ? Results.NotFound() 
            : Results.Ok(order.ToOrderDetailsDto());
        })
        .WithName(EndpointOrderName);

        //POST
        OrderEP.MapPost("/", async(CreateOrderDto newOrder, RestoContext DbContext) =>
        {
            Order order = newOrder.ToEntity();
            order.OrderInfo = await DbContext.OrderInfos.FindAsync(newOrder.OrderInfoId);

            DbContext.Add(order);
            await DbContext.SaveChangesAsync();


            return Results.CreatedAtRoute(EndpointOrderName, new { id = order.Id }, order.ToOrderDetailsDto());
            //we use Results.CreatedAtRoute to provide location header so that the FE knows the loc
        });

        //PUT
        OrderEP.MapPut("/{id}", async(int id, UpdateOrderDto updatedOrder, RestoContext dbContext) =>
        {
            var existingOrder = await dbContext.Orders.FindAsync(id);
            //FindIndex is basically find in the index

            if (existingOrder is null)
            {
                return Results.NotFound();
            }
            //entry can find something in the db
            dbContext.Entry(existingOrder)
                     .CurrentValues.SetValues(updatedOrder.ToUpdateOrderEntity(id)); 
                     await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });

        //DELETE
        OrderEP.MapDelete("/{id}", async(int id, RestoContext dbContext) =>
        {

            await dbContext.Orders.Where(order => order.Id == id)
                                  .ExecuteDeleteAsync();

            return Results.NoContent();
        });

        return OrderEP;

    }

}
