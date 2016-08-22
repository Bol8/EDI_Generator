using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class MedioTransporte
    {
        public string IdTipoMedioTransporte { get; private set; }
        public string TipoMedioTransporte { get; private set; }

        public MedioTransporte(string idTipoMedioTransporte, string tipoMedioTransporte)
        {
            IdTipoMedioTransporte = idTipoMedioTransporte;
            TipoMedioTransporte = tipoMedioTransporte;
        }
    }
}
