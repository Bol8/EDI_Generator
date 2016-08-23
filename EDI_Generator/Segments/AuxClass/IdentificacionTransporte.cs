using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class IdentificacionTransporte
    {
        public string IdMedioTransporteCodificado_8213 { get; private set; }
        public string IdListaCodigosCodificado_1131 { get; private set; }
        public string AgenciaResponsableListaCodigosCodificada_3055 { get; private set; }
        public string IdMedioTransporte_8212 { get; private set; }
        public string NacionalidadMedioTransporteCodificada_8453 { get; private set; }


        public IdentificacionTransporte(string idMedioTransporteCodificado8213, string idListaCodigosCodificado1131, 
                                        string agenciaResponsableListaCodigosCodificada3055,string idMedioTransporte8212, 
                                        string nacionalidadMedioTransporteCodificada8453)
        {
            IdMedioTransporteCodificado_8213 = idMedioTransporteCodificado8213;
            IdListaCodigosCodificado_1131 = idListaCodigosCodificado1131;
            AgenciaResponsableListaCodigosCodificada_3055 = agenciaResponsableListaCodigosCodificada3055;
            IdMedioTransporte_8212 = idMedioTransporte8212;
            NacionalidadMedioTransporteCodificada_8453 = nacionalidadMedioTransporteCodificada8453;
           
        }
    }
}
