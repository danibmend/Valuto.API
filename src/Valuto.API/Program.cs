using Valuto.API.Extensions;
using Valuto.Domain.Middlewares;
using Valuto.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var cnnstr = builder.Configuration.GetConnectionString("DefaultConnection");
var schema = builder.Configuration["DatabaseConfigurationOptions:DefaultSchema"];
builder.Services.AddDbContext<ValutoContext>(opt =>
{
    opt.UseNpgsql(cnnstr, c =>
    {
        c.MigrationsHistoryTable("HISTORICO_MIGRACOES", schema);
        c.MigrationsAssembly("Valuto.Infrastructure");
    });
    opt.LogTo(s => System.Diagnostics.Debug.WriteLine(s)).EnableDetailedErrors();
    opt.EnableSensitiveDataLogging();
});


builder.Services.LoadConfigOptions(builder.Configuration);
builder.Services.LoadServices();
builder.Services.LoadApiServices();
builder.Services.LoadFactories();
builder.Services.LoadRepositories();
builder.Services.LoadValidators();
builder.Services.LoadValidatorsRules(); 

var app = builder.Build();

app.UseCors(opt => opt.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
