using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class DocumentoDelMensaje
    {
        public string NombreDocumentoCodificado_1001 { get; private set; }
        public string CalificadorListaCodigos_1131 { get; private set; }
        public string AgenciaResponsableListaCodigosCodificada_3055 { get; private set; }
        public string NombreDocumento_1000 { get; private set; }


        public DocumentoDelMensaje(string nombreDocumentoCodificado1001, string calificadorListaCodigos1131, 
                                   string agenciaResponsableListaCodigosCodificada3055, string nombreDocumento1000)
        {
            NombreDocumentoCodificado_1001 = nombreDocumentoCodificado1001;
            CalificadorListaCodigos_1131 = calificadorListaCodigos1131;
            AgenciaResponsableListaCodigosCodificada_3055 = agenciaResponsableListaCodigosCodificada3055;
            NombreDocumento_1000 = nombreDocumento1000;
        }

    }
}
