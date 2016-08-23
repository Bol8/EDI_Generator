using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    internal class IdentificacionLugar
    {
        public string IdentificacionDeLugar_3225 { get; private set; }
        public string CalificadorListaCodigos_1131 { get; private set; }
        public string AgenciaResponsableListaCodigosCodificada_3055 { get; private set; }
        public string Lugar_3224 { get; private set; }


        public IdentificacionLugar(string identificacionDeLugar3225,string calificadorListaCodigos1131,
                                   string agenciaResponsbleListaCodigos,string lugar3224)
        {
            IdentificacionDeLugar_3225 = identificacionDeLugar3225;
            CalificadorListaCodigos_1131 = calificadorListaCodigos1131;
            AgenciaResponsableListaCodigosCodificada_3055 = agenciaResponsbleListaCodigos;
            Lugar_3224 = lugar3224;
        }

    }
}
