using BackEnd.Api;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<gameDto> orderDesc = [
    new(
        1,
        "Jojo",
        "Nuggets",
        new DateOnly(27, 06, 24)
    )
];

//route
app.MapGet("/", () => "Der Vogel kämpft sich aus dem Ei");

//get customer orders
app.MapGet("orders", () => orderDesc);

app.Run();
