namespace BackEnd.Api.Dto;
//record is good cause its like constant you cant mutate or change it
//thats why record is good in using on models like Dto or Data transfer Object
public record class createOrderDto(
    string CustomerName,
    string OrderName,
    DateOnly OrderDate
);

