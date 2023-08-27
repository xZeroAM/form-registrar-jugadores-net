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
        public int? edad {get; set;}
        public string? genero {get; set;}
        public string? equipo {get; set;}
        public string? categoria {get; set;}
        public int num_meses {get; set;}
        public string? num_temporadas {get; set;}

        public Boolean verificar() {
            if(nombre == null || edad == null || genero == null) {
                return false;
            } else {
                return true;
            }
        }

        public double calcularPago() {
            double resultado;

            resultado = num_meses/6 * 300;

            return resultado;
        }

        public double calcularImpuesto() {
            double impuesto;

            impuesto = calcularPago()*0.19;

            return impuesto;
        }

        public double calcularMontoTotal() {
            return calcularPago() + calcularImpuesto();
        }

    }
}