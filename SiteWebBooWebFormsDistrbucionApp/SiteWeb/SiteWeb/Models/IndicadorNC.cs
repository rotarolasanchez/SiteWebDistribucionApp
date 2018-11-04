using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteWeb
{
    public class IndicadorNC
    {
        public class Elementos
        {
            public string Company { get; set; }
            public string Codigo { get; set; }
            public string FechaDespacho { get; set; }
            public string CodigoChofer { get; set; }
            public string NombreChofer { get; set; }
            public int Entregado { get; set; }
            public int Reprogramado { get; set; }
            public int Anulado { get; set; }
            public int Programado { get; set; }
            public int Total { get; set; }
            public double Indicador { get; set; }

            public Elementos()
            {
                Company = "";
                Codigo = "";
                FechaDespacho = "";
                CodigoChofer = "";
                NombreChofer = "";
                Entregado = 0;
                Reprogramado = 0;
                Anulado = 0;
                Programado = 0;
                Total = 0;
                Indicador = 0.0;
            }

            public Elementos(string company,string codigo,string fechadespacho,string codigochofer,string nombrechofer,
                int entregado, int reprogramado, int anulado, int programado,int total, double indicador )
            {
                Company = company;
                Codigo = codigo;
                FechaDespacho = fechadespacho;
                CodigoChofer = codigochofer;
                NombreChofer = nombrechofer;
                Entregado = entregado;
                Reprogramado = reprogramado;
                Anulado = anulado;
                Programado = programado;
                Total = total;
                Indicador = indicador;
            }
        }

       
    }

}