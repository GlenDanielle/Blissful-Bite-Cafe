namespace BackEnd.Dtos;

public record class OrderDto(
    int Id,
    string CustomerId,
    DateOnly OrderDate,
    double TotalPrice,
    int OrderId
);
