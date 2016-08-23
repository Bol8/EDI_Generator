using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class Transportista
    {

        public string TransportistaCodificado_3127 { get; private set; }
        public string IdListaCodigosCodificado_1131 { get; private set; }
        public string AgenciaResponsableListaCodigosCodificada_3055 { get; private set; }
        public string NombreTransportista_3128 { get; private set; }

        public Transportista(string transportistaCodificado3127, string idListaCodigosCodificado1131, string agenciaResponsableListaCodigosCodificada3055, 
                             string nombreTransportista3128)
        {
            TransportistaCodificado_3127 = transportistaCodificado3127;
            IdListaCodigosCodificado_1131 = idListaCodigosCodificado1131;
            AgenciaResponsableListaCodigosCodificada_3055 = agenciaResponsableListaCodigosCodificada3055;
            NombreTransportista_3128 = nombreTransportista3128;
        }

    }
}
