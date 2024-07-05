namespace BackEnd.Dtos;

public record class OrderDetailsDto(
    int Id,
    string CustomerId,
    DateOnly DateOrder,
    double TotalPrice,
    int OrderInfoId
);
