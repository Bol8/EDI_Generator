using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class PlazoEntrega
    {
      
        public string PlazoEntregaCodificado_4053 { get; private set; }
        public string IdListaCodigosCodificado_1131 { get; private set; }
        public string AgenciaResponsableListaCodigos_3055 { get; private set; }
        public string PlazoEntrega1_4052 { get; private set; }
        public string PlazoEntrega2_4052 { get; private set; }

        public PlazoEntrega(string plazoEntregaCodificado4053, string idListaCodigosCodificado1131, 
                            string agenciaResponsableListaCodigos3055, string plazoEntrega14052, 
                            string plazoEntrega24052)
        {
            PlazoEntregaCodificado_4053 = plazoEntregaCodificado4053;
            IdListaCodigosCodificado_1131 = idListaCodigosCodificado1131;
            AgenciaResponsableListaCodigos_3055 = agenciaResponsableListaCodigos3055;
            PlazoEntrega1_4052 = plazoEntrega14052;
            PlazoEntrega2_4052 = plazoEntrega24052;
        }

    }
}
