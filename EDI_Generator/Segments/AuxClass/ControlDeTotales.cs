using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class ControlDeTotales
    {
        public string CalificadorDeControl_6069 { get; private set; }
        public string ValorDeControl_6066 { get; private set; }
        public string CalificadorUnidadDeMedida_6411 { get; private set; }

        public ControlDeTotales(string calificadorDeControl6069, string valorDeControl6066, 
                                string calificadorUnidadDeMedida6411)
        {
            CalificadorDeControl_6069 = calificadorDeControl6069;
            ValorDeControl_6066 = valorDeControl6066;
            CalificadorUnidadDeMedida_6411 = calificadorUnidadDeMedida6411;
        }

    }
}
