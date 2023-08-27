using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace form_registrar_jugadores_net.Models
{
    public class Formulario
    {
        public string? nombre {get; set;}
        public int edad {get; set;}
        public string? genero {get; set;}
        public string? equipo {get; set;}
        public string? categoria {get; set;}
        public string? num_meses {get; set;}
        public string? num_temporadas {get; set;}
    }
}