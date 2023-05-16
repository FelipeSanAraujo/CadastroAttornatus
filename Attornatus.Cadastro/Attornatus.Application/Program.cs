using Attornatus.Core.Interfaces;
using Attornatus.InfraData.Contexts;
using Attornatus.InfraData.Repositories;
using Attornatus.Services.Interfaces;
using Attornatus.Services.Profiles;
using Attornatus.Services.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(options =>
{
    var serializerOptions = options.JsonSerializerOptions;
    serializerOptions.IgnoreNullValues = true;
    serializerOptions.WriteIndented = true;
    serializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DbPessoas");

builder.Services.AddDbContext<SqlServerContext>(opts => 
    opts.UseSqlServer(connectionString));

builder.Services.AddTransient<IPessoaRepository, PessoaRepository>();
builder.Services.AddTransient<IEnderecoRepository, EnderecoRepository>();
builder.Services.AddScoped<IPessoaService, PessoaServices>();
builder.Services.AddScoped<IEnderecoService, EnderecoServices>();

builder.Services.AddAutoMapper(typeof(PessoaProfile), typeof(EnderecoProfile));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
