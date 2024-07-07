using System.ComponentModel.DataAnnotations;

namespace BackEnd.Dtos;

public record class UpdateOrderDto(
    [Required] string CustomerId,
    [Required] DateOnly DateOrder,
    [Required] double TotalPrice,
    [Required] int OrderInfoId
);