namespace BackEnd.Dtos;

public record class OrderSummaryDto(
    int Id,
    string CustomerId,
    DateOnly DateOrder,
    double TotalPrice,
    string OrderInfo
);
