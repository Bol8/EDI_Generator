using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class CodigoIdentificacionAduanera
    {
        public string codigoIdentificacionAduanera_7361 { get; private set; }
        public string calificadorListaCodigos_1131 { get; private set; }
        public string agenciaResponsableListaCodigosCodificada_3055 { get; private set; }



        public CodigoIdentificacionAduanera(string codigoIdentificacionAduanera7361,string calificadorListaCodigos1131,
                                             string agenciaResponsableListaCodigosCodificada3055 )
        {
            this.codigoIdentificacionAduanera_7361 = codigoIdentificacionAduanera7361;
            this.calificadorListaCodigos_1131 = calificadorListaCodigos1131;
            this.agenciaResponsableListaCodigosCodificada_3055 = agenciaResponsableListaCodigosCodificada3055;
        }
    }
}
