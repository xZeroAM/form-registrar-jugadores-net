using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using form_registrar_jugadores_net.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace form_registrar_jugadores_net.Controllers
{
    [Route("[controller]")]
    public class FormularioController : Controller
    {
        private readonly ILogger<FormularioController> _logger;

        public FormularioController(ILogger<FormularioController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Formulario(Formulario obj)
        {
            if(obj.verificar()) {
                ViewData["Resultado"] = 
                "<h4>Registro exitoso</h4>" + 
                "<p>Jugador: " + obj.nombre + "</p>"+
                "<p>Club: " + obj.equipo + "</p>"+
                "<p>Temporadas: " + obj.num_temporadas + "</p>" +
                "<p>Meses: " + obj.num_meses + "</p>" +
                "<p>Monto total a pagar: <br> Monto: " + obj.calcularPago() + "<br>Impuesto del 19%:  " + obj.calcularImpuesto() +  "<br>Total: " + obj.calcularMontoTotal() +"</p>";
            }else {
                ViewData["Resultado"] = "Porfavor, rellene todos los campos";
            }
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true), Route("Error")]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}