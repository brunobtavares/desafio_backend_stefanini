using desafio_backend_stefanini.Application.Clients;
using desafio_backend_stefanini.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IPessoaClient>(provider => new PessoaClient(builder.Configuration.GetValue<string>("ApiUrl")));
builder.Services.AddScoped<ICidadeClient>(provider => new CidadeClient(builder.Configuration.GetValue<string>("ApiUrl")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
