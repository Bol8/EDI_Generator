using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class MedioTransporte
    {
        public string IdTipoMedioTransporte_8179 { get; private set; }
        public string TipoMedioTransporte_8178 { get; private set; }

        public MedioTransporte(string idTipoMedioTransporte8179, string tipoMedioTransporte8178)
        {
            IdTipoMedioTransporte_8179 = idTipoMedioTransporte8179;
            TipoMedioTransporte_8178 = tipoMedioTransporte8178;
        }
    }
}
