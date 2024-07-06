using System.ComponentModel.DataAnnotations;

namespace BackEnd.Dtos;

public record class UpdateOrderDto(
    [Required] string CustomerId,
    [Required] DateOnly OrderDate,
    [Required] double TotalPrice,
    [Required] string OrderInfoId
);