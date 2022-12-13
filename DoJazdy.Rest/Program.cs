using DoJazdy.Infrastructure.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddPostgres(builder.Configuration);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();