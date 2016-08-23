using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class InfoExcesoCargaTransporte
    {
        public string RazonExcesoCargaCodificado_8457 { get; private set; }
        public string ResponsabilidadExcesoCargaCodificada_8459 { get; private set; }
        public string NumeroAutorizacionCliente_7130 { get; private set; }


        public InfoExcesoCargaTransporte(string razonExcesoCargaCodificado8457, string responsabilidadExcesoCargaCodificada8459, 
                                         string numeroAutorizacionCliente7130)
        {
            RazonExcesoCargaCodificado_8457 = razonExcesoCargaCodificado8457;
            ResponsabilidadExcesoCargaCodificada_8459 = responsabilidadExcesoCargaCodificada8459;
            NumeroAutorizacionCliente_7130 = numeroAutorizacionCliente7130;
        }


    }
}
