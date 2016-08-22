using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class Transportista
    {

        public string TrasnportistaCodificado { get; private set; }
        public string IdListaCodigosCodificado { get; private set; }
        public string AgenciaResponsableListaCodigosCodificada { get; private set; }
        public string NombreTransportista { get; private set; }

        public Transportista(string trasnportistaCodificado, string idListaCodigosCodificado, string agenciaResponsableListaCodigosCodificada, 
                             string nombreTransportista)
        {
            TrasnportistaCodificado = trasnportistaCodificado;
            IdListaCodigosCodificado = idListaCodigosCodificado;
            AgenciaResponsableListaCodigosCodificada = agenciaResponsableListaCodigosCodificada;
            NombreTransportista = nombreTransportista;
        }

    }
}
