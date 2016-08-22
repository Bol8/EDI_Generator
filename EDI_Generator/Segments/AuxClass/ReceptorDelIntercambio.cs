using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class ReceptorDelIntercambio
    {
       
        public string IdentificacionDelReceptor_0010 { get; private set; }
        public string CodigoCalificadorIdentificacionParticipante_0007 { get; private set; }
        public string DireccionRuta_0014 { get; private set; }

        public ReceptorDelIntercambio(string identificacionDelReceptor0010, string codigoCalificadorIdentificacionParticipante0007, 
                                      string direccionRuta0014)
        {
            IdentificacionDelReceptor_0010 = identificacionDelReceptor0010;
            CodigoCalificadorIdentificacionParticipante_0007 = codigoCalificadorIdentificacionParticipante0007;
            DireccionRuta_0014 = direccionRuta0014;
        }

    }
}
