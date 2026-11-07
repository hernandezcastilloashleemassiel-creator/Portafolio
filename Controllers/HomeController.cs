using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MiPortafolio.Models;
using Portafolio.Models;

namespace MiPortafolio.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var modelo = new PortafolioViewModel
        {
            Nombre = "Masiel Castillo",
            Presentacion = "Estoy estudiando frontend y backend con ASP.NET Core. Acá subo lo que aprendo y lo que voy construyendo.",
            SobreMi = "Estoy en proceso de aprender programación. Me gusta ver cómo una idea pasa de un dibujo a una página que funciona. Este sitio es mi cuaderno público: muestro mis avances, mis errores y lo que voy mejorando.",
            Foto = "/imagenes/perfil.jpg",            
            Email = "hernandezcastilloashleemassiel@gmail.com",

            // Nivel de 0 a 100
            Frontend = new()
            {
                new("HTML y CSS", 70),
                new("JavaScript", 40),
                new("Bootstrap", 55)
            },
            Backend = new()
            {
                new("C#", 50),
                new("ASP.NET Core MVC", 35),
                new("SQL Server", 30)
            },

            // Titulo, Descripcion
            Proyectos = new()
            {
                new("Página de ", "Maqueta responsive con HTML, CSS y Bootstrap.", "Frontend · Bootstrap", "/imagenes/amazon.PNG", null),
                new("Lista de tareas", "CRUD en ASP.NET Core MVC con SQL Server.", "Backend · MVC · EF Core", "/imagenes/reddit.PNG", "https://github.com/tuusuario/tareas"),
                new("Calculadora en JavaScript", "Mi primer proyecto con eventos y DOM.", "Frontend · JavaScript", "/imagenes/steam.PNG", null)
            }
        };
        return View(modelo);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
