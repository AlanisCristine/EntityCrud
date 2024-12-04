using API.DataConfig;
using Infraestrutura;
using Infraestrutura.Data;
using Infraestrutura.DTOs;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddDbContext<ApplicationDbContext>(variavel =>
    variavel.UseLazyLoadingProxies().UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IPessoaRepository,PessoaRepository>(); 
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>(); 
builder.Services.AddScoped<ICidadeRepository, CidadeRepository>(); 
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
