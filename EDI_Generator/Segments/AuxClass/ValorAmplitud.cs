using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class ValorAmplitud
    {
        public string CalificadorUnidadMedida { get; private set; }
        public string ValorMedida { get; private set; }
        public string AmplitudMinima { get; private set; }
        public string AmplitudMaxima { get; private set; }


        public ValorAmplitud(string calificadorUnidadMedida, string valorMedida, string amplitudMinima, string amplitudMaxima)
        {
            CalificadorUnidadMedida = calificadorUnidadMedida;
            ValorMedida = valorMedida;
            AmplitudMinima = amplitudMinima;
            AmplitudMaxima = amplitudMaxima;
        }
    }
}
