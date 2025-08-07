using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Biblioteca.UI.Data;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion;
using Biblioteca.Repositorios;
using Biblioteca.Aplicacion.UseCases;
using Biblioteca.Aplicacion.InterfacesRepositorios;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

//agregamos estos servicios al contenedor DI
builder.Services.AddTransient<AgregarDocenteUseCase>();
builder.Services.AddTransient<ListarDocentesUseCase>();
builder.Services.AddTransient<EliminarDocenteUseCase>();
builder.Services.AddTransient<ModificarDocenteUseCase>();
builder.Services.AddTransient<ObtenerDocenteUseCase>();
builder.Services.AddTransient<IdsDisponiblesUseCase>();
builder.Services.AddScoped<iRepositorioDocente, RepositorioDocente>();

builder.Services.AddTransient<AgregarEstudianteUseCase>();
builder.Services.AddTransient<ListarEstudiantesUseCase>();
builder.Services.AddTransient<EliminarEstudianteUseCase>();
builder.Services.AddTransient<ModificarEstudianteUseCase>();
builder.Services.AddTransient<ObtenerEstudianteUseCase>();
builder.Services.AddScoped<iRepositorioEstudiante, RepositorioEstudiante>();

builder.Services.AddTransient<AgregarLibroUseCase>();
builder.Services.AddTransient<ListarLibrosUseCase>();
builder.Services.AddTransient<EliminarLibroUseCase>();
builder.Services.AddTransient<ModificarLibroUseCase>();
builder.Services.AddTransient<ObtenerLibroUseCase>();
builder.Services.AddTransient<IdDisponibleLibroUseCase>();
builder.Services.AddScoped<IRepositorioLibro, RepositorioLibro>();

builder.Services.AddTransient<RealizarPrestamoUseCase>();
builder.Services.AddTransient<ListarPrestamoUseCase>();
builder.Services.AddTransient<DevolverPrestamoUseCase>();
builder.Services.AddTransient<ModificarDocenteUseCase>();
builder.Services.AddTransient<ObtenerPrestamoUseCase>();
builder.Services.AddScoped<IRepositorioPrestamo, RepositorioPrestamo>();

builder.Services.AddDbContext<RepositoriosContext>(options =>
{
    options.UseSqlite("data source= RepositoriosInfo.sqlite");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

//app.Run();

using(var context =new RepositoriosContext())
{
  context.Database.EnsureCreated();
var connection = context.Database.GetDbConnection();
connection.Open();
using (var command = connection.CreateCommand())
{
command.CommandText = "PRAGMA journal_mode=DELETE;";
command.ExecuteNonQuery();
}
}
app.Run();

