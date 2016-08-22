using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class PlazoEntrega
    {
      
        public string PlazoEntregaCodificado { get; private set; }
        public string IdListaCodigosCodificado { get; private set; }
        public string AgenciaResponsableListaCodigos { get; private set; }
        public string PlazoEntrega1 { get; private set; }
        public string PlazoEntrega2 { get; private set; }

        public PlazoEntrega(string plazoEntregaCodificado, string idListaCodigosCodificado, 
                            string agenciaResponsableListaCodigos, string plazoEntrega1, 
                            string plazoEntrega2)
        {
            PlazoEntregaCodificado = plazoEntregaCodificado;
            IdListaCodigosCodificado = idListaCodigosCodificado;
            AgenciaResponsableListaCodigos = agenciaResponsableListaCodigos;
            PlazoEntrega1 = plazoEntrega1;
            PlazoEntrega2 = plazoEntrega2;
        }

    }
}
