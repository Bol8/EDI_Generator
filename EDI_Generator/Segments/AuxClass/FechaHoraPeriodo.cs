using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class FechaHoraPeriodo
    {
        public string CalificadorFechaHora_2005 { get; private set; }
        public string FechaHora_2380 { get; private set; }
        public string CalificadorFormatoFechaHora_2379 { get; private set; }

        public FechaHoraPeriodo(string calificadorFechaHora2005, string fechaHora2380, string calificadorFormatoFechaHora2379)
        {
            CalificadorFechaHora_2005 = calificadorFechaHora2005;
            FechaHora_2380 = fechaHora2380;
            CalificadorFormatoFechaHora_2379 = calificadorFormatoFechaHora2379;
        }
    }
}
