using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments
{
    internal class GIS:SegmentoEDI
    {
        //C529 INDICADOR DE PROCESO
        private readonly string _idProcesoCodificado_7365;
        private readonly string _calificadorListaCodigosCodificado_1131;
        private readonly string _agenciaResponsableListaCodigosCodificadad_3055;
        private readonly string _idTipoProceso_7187;


        public GIS(string idProcesoCodificado,string calificadorListaCodigosCodificado,string agenciaResponsableListaCodigosCod,
                    string idTipoProceso) 
            : base("GIS")
        {
            _idProcesoCodificado_7365 = idProcesoCodificado;
            _calificadorListaCodigosCodificado_1131 = calificadorListaCodigosCodificado;
            _agenciaResponsableListaCodigosCodificadad_3055 = agenciaResponsableListaCodigosCod;
            _idTipoProceso_7187 = idTipoProceso;

            Segmento = montaSegmento();
        }


        protected override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += C529_IndicadorProceso();
            cadena += cerrarSegmento();

            return cadena;
        }


        private string C529_IndicadorProceso()
        {
            var cadena = _idProcesoCodificado_7365;

            if (!string.IsNullOrEmpty(_calificadorListaCodigosCodificado_1131))
                cadena += ":" + _calificadorListaCodigosCodificado_1131;

            if (!string.IsNullOrEmpty(_agenciaResponsableListaCodigosCodificadad_3055))
                cadena += ":" + _agenciaResponsableListaCodigosCodificadad_3055;

            if (!string.IsNullOrEmpty(_idTipoProceso_7187))
                cadena += ":" + _idTipoProceso_7187;

            return "+" + cadena;
        }


        public override string getSegmento()
        {
           return Segmento;
        }


        protected override string cerrarSegmento()
        {
            return _cierreSegmento;
        }

    }
}
