using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class IdentificacionDeLaParte
    {
       
        public string IdentificacionEntidadCodificada_3039 { get; private set; }
        public string IdentificadorListaCodigosCodificado_1131 { get; private set; }
        public string AgenciaResponsableListaCodigosCodificada_3055 { get; private set; }


        public IdentificacionDeLaParte(string identificacionEntidadCodificada3039, string identificadorListaCodigosCodificado1131,
                                       string agenciaResponsableListaCodigosCodificada3055)
        {
            IdentificacionEntidadCodificada_3039 = identificacionEntidadCodificada3039;
            IdentificadorListaCodigosCodificado_1131 = identificadorListaCodigosCodificado1131;
            AgenciaResponsableListaCodigosCodificada_3055 = agenciaResponsableListaCodigosCodificada3055;
        }

    }
}
