using desafio_backend_stefanini.API.Data;
using desafio_backend_stefanini.API.Interfaces;
using desafio_backend_stefanini.API.Repositories;
using desafio_backend_stefanini.API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(c =>
{
    c.AddPolicy("OpenPolicy", options =>
    {
        options.AllowAnyOrigin()
               .WithMethods("POST, GET")
               .AllowAnyHeader();
    });
});

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Desafio para candidatos da Stefanini",
        Contact = new OpenApiContact
        {
            Name = "Bruno Tavares",
            Url = new Uri("https://www.linkedin.com/in/bruno-tavares-83817a152/")
        }
    });

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

builder.Services.AddScoped<IPessoaRepository, PessoaRepository>();
builder.Services.AddScoped<ICidadeRepository, CidadeRepository>();

builder.Services.AddScoped<IPessoaService, PessoaService>();
builder.Services.AddScoped<ICidadeService, CidadeService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors( c => c.AllowAnyOrigin()
                   .WithMethods("POST, GET")
                   .AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();


app.Run();
