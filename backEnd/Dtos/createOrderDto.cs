using System.ComponentModel.DataAnnotations;

namespace BackEnd.Dtos;
//record is good cause its like constant you cant mutate or change it
//thats why record is good in using on models like Dto or Data transfer Object
public record class CreateOrderDto(
    [Required] string CustomerId,
    [Required] DateOnly DateOrder,
    [Required] double TotalPrice,
    [Required] int OrderInfoId
);

