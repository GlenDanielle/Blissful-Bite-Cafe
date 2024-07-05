using BackEnd.Dtos;
using BackEnd.Entity;

namespace BackEnd.Mapping;

public static class OrderMapping
{
    public static Order ToEntity(this CreateOrderDto newOrder){
        return new Order(){
            CustomerId = newOrder.CustomerId,
            DateOrder = newOrder.DateOrder,
            TotalPrice = newOrder.TotalPrice,
            OrderInfoId = newOrder.OrderInfoId,
            //you cannot access dbcontext here
           // OrderInfo = DbContext.OrderInfos.Find(newOrder.OrderInfoId)
        };
    }

    public static OrderSummaryDto ToOrderSummaryDto(this Order order){
         return new OrderSummaryDto(
            order.Id,
            order.CustomerId,
            order.DateOrder,
            order.TotalPrice,
            order.OrderInfo!.OrderName
        );
    }
    public static OrderDetailsDto ToOrderDetailsDto(this Order order){
         return new OrderDetailsDto(
            order.Id,
            order.CustomerId,
            order.DateOrder,
            order.TotalPrice,
            order.OrderInfoId
        );
    }
}
