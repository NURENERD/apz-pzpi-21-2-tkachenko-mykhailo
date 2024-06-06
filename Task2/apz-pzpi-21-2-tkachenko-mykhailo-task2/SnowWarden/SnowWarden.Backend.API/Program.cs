using SnowWarden.Backend.API.Extensions.DependencyInjection;
using SnowWarden.Backend.API.Extensions.WebApp;

using SnowWarden.Backend.Application.Extensions.DI;
using SnowWarden.Backend.Infrastructure.Extensions.DI;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureApplicationOptions(builder.Configuration);
builder.Services.ConfigureApplicationSwagger();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddMapping();
builder.Services.AddApplicationIdentities();
builder.Services.AddApplicationAuthentication(builder.Configuration);
builder.Services.AddEventProcessor();
builder.Services.AddApplicationLayer();
builder.Services.AddInfrastructureLayer(builder.Configuration);
builder.Services.AddReserveCoping();

WebApplication app = builder.Build();

// Застосувати міграції, які ще не були застосовані до актуальної схеми
app.UseDatabaseMigrations();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();;
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

await app.SeedMembers();

app.Run();