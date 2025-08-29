using JesusEmNos.API.Extensions;
using JesusEmNos.Domain.Middlewares;
using JesusEmNos.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var cnnstr = builder.Configuration.GetConnectionString("DefaultConnection");
var schema = builder.Configuration["DatabaseConfigurationOptions:DefaultSchema"];
builder.Services.AddDbContext<JesusEmNosContext>(opt =>
{
    opt.UseNpgsql(cnnstr, c =>
    {
        c.MigrationsHistoryTable("HISTORICO_MIGRACOES", schema);
        c.MigrationsAssembly("JesusEmNos.Infrastructure");
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
