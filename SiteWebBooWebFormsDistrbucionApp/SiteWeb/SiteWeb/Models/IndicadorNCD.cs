using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteWeb
{
    public class IndicadorNCD
    {
        public class Elementos
        {
            public string Company { get; set; }
            public string FechaDespacho { get; set; }
            public double Entregado { get; set; }
            public double Reprogramado { get; set; }
            public double Total { get; set; }
            public double Indicador { get; set; }

            public Elementos()
            {
                Company = "";
                FechaDespacho = ""; 
                Entregado = 0.0;
                Reprogramado = 0.0;
                Total = 0.0;
                Indicador = 0.0;
            }

            public Elementos(string company, string fechadespacho,
            double entregado,double reprogramado,double total,double indicador )
            {
                Company = company;
                FechaDespacho = fechadespacho;
                Entregado = entregado;
                Reprogramado = reprogramado;
                Total = total;
                Indicador = indicador;
            }
        }

       
    }

}