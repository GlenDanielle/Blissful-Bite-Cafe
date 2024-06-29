namespace BackEnd.Api.Dto;

public record class updateOrderDto(
    string CustomerName,
    string OrderName,
    DateOnly OrderDate
);