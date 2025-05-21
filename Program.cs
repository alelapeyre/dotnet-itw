using Betclic.Dotnet.Interview.Repositories;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ISummariesRepository, SummariesRepository>();

var app = builder.Build();

app.MapGet(
    "/summaries",
    async ([FromServices] ISummariesRepository repository) => await repository.GetAsync()
);

app.Run();
