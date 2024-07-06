using BackEnd.Data;
using BackEnd.Dtos;
using BackEnd.Entity;
using BackEnd.Mapping;

namespace BackEnd.Endpoint;

public static class OrderEndpoints
{
    const string EndpointOrderName = "GetOrder";

    private static readonly List<OrderSummaryDto> Orders = [
        //readonly BASICALLY
        new(
            1,
            "Jojo",
            new DateOnly(2024, 6, 27),//you must use presentable format like year month day,
            100,
            "Fried Siken"
        ),
        new(
            2,
            "Gojo",
            new DateOnly(2004, 9, 7),//you must use presentable format like year month day,
            200,
            "French Fries"
        ),
        new(
            3,
            "Jogo",
            new DateOnly(2000, 1, 12),//you must use presentable format like year month day,
            300,
            "Chicken Nuggets"
        )
    ];

    public static RouteGroupBuilder MapOrderEndpoints(this WebApplication app)
    {

        var OrderEP = app.MapGroup("Orders")//order End Point
                         .WithParameterValidation();

        //get customer orders
        OrderEP.MapGet("/", () => Orders);

        //.Find is basically Find
        //GET!
        OrderEP.MapGet("/{id}", (int id, RestoContext dbContext) =>
        {
            Order? order = dbContext.Orders.Find(id);

            return order is null ? Results.NotFound() : Results.Ok(order);
        })
        .WithName(EndpointOrderName);

        //POST
        OrderEP.MapPost("/", (CreateOrderDto newOrder, RestoContext DbContext) =>
        {
            Order order = newOrder.ToEntity();
            order.OrderInfo = DbContext.OrderInfos.Find(newOrder.OrderInfoId);

            DbContext.Add(order);
            DbContext.SaveChanges();


            return Results.CreatedAtRoute(EndpointOrderName, new { id = order.Id }, order.ToOrderDetailsDto());
            //we use Results.CreatedAtRoute to provide location header so that the FE knows the loc
        });

        //PUT
        OrderEP.MapPut("/{id}", (int id, UpdateOrderDto updatedOrder) =>
        {
            var index = Orders.FindIndex(order => order.Id == id);
            //FindIndex is basically find in the index

            if (index == -1)
            {
                return Results.NotFound();
            }

            Orders[index] = new OrderSummaryDto(
                id,
                updatedOrder.CustomerId,
                updatedOrder.OrderDate,
                updatedOrder.TotalPrice,
                updatedOrder.OrderInfoId
            );

            return Results.NoContent();
        });

        //DELETE
        OrderEP.MapDelete("/{id}", (int id) =>
        {

            Orders.RemoveAll(order => order.Id == id);

            return Results.NoContent();
        });

        return OrderEP;

    }

}
