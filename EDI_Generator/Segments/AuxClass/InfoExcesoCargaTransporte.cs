using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class InfoExcesoCargaTransporte
    {
        public string RazonExcesoCargaCodificado { get; private set; }
        public string ResponsabilidadExcesoCargaCodificada { get; private set; }
        public string NumeroAutorizacionCliente { get; private set; }


        public InfoExcesoCargaTransporte(string razonExcesoCargaCodificado, string responsabilidadExcesoCargaCodificada, 
                                         string numeroAutorizacionCliente)
        {
            RazonExcesoCargaCodificado = razonExcesoCargaCodificado;
            ResponsabilidadExcesoCargaCodificada = responsabilidadExcesoCargaCodificada;
            NumeroAutorizacionCliente = numeroAutorizacionCliente;
        }


    }
}
