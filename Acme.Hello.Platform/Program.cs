using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) app.MapOpenApi();

app.UseHttpsRedirection();

// Implemented RESTful API with a GET and POST endpoint to greet a developer.
// The GET endpoint accepts optional query parameters for the developer's
// first and last name, while the POST endpoint accepts a JSON payload
// containing the developer's information. Both endpoints use assemblers
// to convert between domain entities and response/request models,
// ensuring a clean separation of concerns and adherence to RESTful principles.
app.MapGet("/greetings", (string? firstName, string? lastName) =>
{
 var developer = !string.IsNullOrWhiteSpace(firstName) &&
                 !string.IsNullOrWhiteSpace(lastName)
                 ? new Developer(firstName, lastName)
                 : null;
 var response = GreetDeveloperAssembler.ToResponseFromEntity(developer);
 return Results.Ok(response);
}).WithName("GetGreeting");

app.MapPost("/greetings", (GreetDeveloperRequest request) =>
{
    var developer = DeveloperAssembler.ToEntityFromRequest(request);
    var response = GreetDeveloperAssembler.ToResponseFromEntity(developer);
    return Results.Created("/greetings", response);
}).WithName("PostGreeting");
app.Run();

