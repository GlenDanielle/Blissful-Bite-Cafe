using System.Text.RegularExpressions;
using BackEnd.Api.Dto;

namespace BackEnd.Endpoint;

public static class OrderEndpoints
{
    const string EndpointOrderName = "GetOrder";

    private static readonly List<orderDto> orders = [
        //readonly is basically const
        new(
            1,
            "Jojo",
            "Nuggets",
            new DateOnly(2024, 06, 27)//you must use presentable format like year month day
        ),
        new(
            2,
            "Gojo",
            "Soju",
            new DateOnly(2005, 01, 12)
        ),
        new(
            3,
            "Jogo",
            "Fries",
            new DateOnly(2001, 12, 01)
        )
    ];

    public static RouteGroupBuilder MapOrderEndpoints(this WebApplication app){
                
        var orderEP = app.MapGroup("orders");
        //order End Point

        //get customer orders
        orderEP.MapGet("/", () => orders);

        //.Find is basically Find
        //GET!
        orderEP.MapGet("/{id}", (int id) =>{
            var order = orders.Find(orders => orders.Id == id);

            return order is null ? Results.NotFound() : Results.Ok(order);
        })
        .WithName(EndpointOrderName);

        //POST
        orderEP.MapPost("/", (createOrderDto newOrder) => {
            orderDto order = new(
                orders.Count +1,
                newOrder.CustomerName,
                newOrder.OrderName,
                newOrder.OrderDate
            );
            orders.Add(order);
            
            return Results.CreatedAtRoute(EndpointOrderName, new {id = order.Id}, order);
            //we use Results.CreatedAtRoute to provide location header so that the FE knows the loc
        });

        //PUT
        orderEP.MapPut("/{id}", (int id, updateOrderDto updatedOrder)=>{
            var index = orders.FindIndex(order => order.Id == id);
            //FindIndex is basically find in the index

            if(index == -1){
                return Results.NotFound();
            }

            orders[index] = new orderDto(
                id,
                updatedOrder.CustomerName,
                updatedOrder.OrderName,
                updatedOrder.OrderDate
            );

            return Results.NoContent();
        });

        //DELETE
        orderEP.MapDelete("/{id}", (int id) => {

            orders.RemoveAll(order => order.Id == id);

            return Results.NoContent();
        });

        return orderEP;

    }

}
