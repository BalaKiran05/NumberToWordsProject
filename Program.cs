var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapPost("/convert", (ConvertRequest req) =>
{
    var service = new NumberToWordsService();
    var result = service.ConvertAmount(req.Amount);
    return Results.Ok(result);
});

app.Run();

record ConvertRequest(string Amount);
