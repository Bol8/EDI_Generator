using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class EmisorDelIntercambio
    {
        public string IdentificacionDelEmisor_0004 { get; private set; }
        public string CodigoCalificadorIdentificacionParticipante_0007 { get; private set; }
        public string DireccionRutaInversa_0008 { get; private set; }

        public EmisorDelIntercambio(string identificacionDelEmisor0004, string codigoCalificadorIdentificacionParticipante0007, 
                                    string direccionRutaInversa0008)
        {
            IdentificacionDelEmisor_0004 = identificacionDelEmisor0004;
            CodigoCalificadorIdentificacionParticipante_0007 = codigoCalificadorIdentificacionParticipante0007;
            DireccionRutaInversa_0008 = direccionRutaInversa0008;
        }

    }
}
