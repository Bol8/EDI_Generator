using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class IndicadorDeProceso
    {
        public string IndicadorProcesoCodificado_7365 { get; private set; }
        public string CalificadorListaCodigosCodificado_1131 { get; private set; }
        public string AgenciaResponsableListaCodigosCodificada_3055 { get; private set; }
        public string IdentificacionTipoProceso_7187 { get; private set; }

        public IndicadorDeProceso(string indicadorProcesoCodificado7365, string calificadorListaCodigosCodificado1131, 
                                  string agenciaResponsableListaCodigosCodificada3055, string identificacionTipoProceso7187)
        {
            IndicadorProcesoCodificado_7365 = indicadorProcesoCodificado7365;
            CalificadorListaCodigosCodificado_1131 = calificadorListaCodigosCodificado1131;
            AgenciaResponsableListaCodigosCodificada_3055 = agenciaResponsableListaCodigosCodificada3055;
            IdentificacionTipoProceso_7187 = identificacionTipoProceso7187;
        }

    }
}
