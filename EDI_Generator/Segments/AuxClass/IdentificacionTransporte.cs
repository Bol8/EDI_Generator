using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class IdentificacionTransporte
    {
        public string IdMedioTransporteCodificado { get; private set; }
        public string IdListaCodigosCodificado { get; private set; }
        public string AgenciaResponsableListaCodigosCodificada { get; private set; }
        public string IdMedioTransporte { get; private set; }
        public string NacionalidadMedioTransporteCodificada { get; private set; }


        public IdentificacionTransporte(string idMedioTransporteCodificado, string idListaCodigosCodificado, 
                                        string agenciaResponsableListaCodigosCodificada,string idMedioTransporte, 
                                        string nacionalidadMedioTransporteCodificada)
        {
            IdMedioTransporteCodificado = idMedioTransporteCodificado;
            IdListaCodigosCodificado = idListaCodigosCodificado;
            AgenciaResponsableListaCodigosCodificada = agenciaResponsableListaCodigosCodificada;
            IdMedioTransporte = idMedioTransporte;
            NacionalidadMedioTransporteCodificada = nacionalidadMedioTransporteCodificada;
           
        }
    }
}
