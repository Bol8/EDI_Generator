using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class ControlDeTotales
    {
       
        public string CalificadorDeControl { get; private set; }
        public string ValorDeControl { get; private set; }
        public string CalificadorUnidadDeMedida { get; private set; }

        public ControlDeTotales(string calificadorDeControl, string valorDeControl, string calificadorUnidadDeMedida)
        {
            CalificadorDeControl = calificadorDeControl;
            ValorDeControl = valorDeControl;
            CalificadorUnidadDeMedida = calificadorUnidadDeMedida;
        }

    }
}
