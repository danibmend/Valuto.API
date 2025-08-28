using JesusEmNos.API.Extensions;
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


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.LoadConfigOptions(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
