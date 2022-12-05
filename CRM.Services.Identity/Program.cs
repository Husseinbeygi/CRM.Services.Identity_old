using CRM.Services.Identity.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddIdentityServer()
    .AddDeveloperSigningCredential()
    .AddInMemoryClients(InMemroyConfigurations.Clients)
    .AddInMemoryApiScopes(InMemroyConfigurations.ApiScopes);

var app = builder.Build();

app.UseIdentityServer();


app.Run();
