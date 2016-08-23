using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class ValorAmplitud
    {
        public string CalificadorUnidadMedida_6411 { get; private set; }
        public string ValorMedida_6314 { get; private set; }
        public string AmplitudMinima_6162 { get; private set; }
        public string AmplitudMaxima_6152 { get; private set; }


        public ValorAmplitud(string calificadorUnidadMedida6411, string valorMedida6314, string amplitudMinima6162, string amplitudMaxima6152)
        {
            CalificadorUnidadMedida_6411 = calificadorUnidadMedida6411;
            ValorMedida_6314 = valorMedida6314;
            AmplitudMinima_6162 = amplitudMinima6162;
            AmplitudMaxima_6152 = amplitudMaxima6152;
        }
    }
}
