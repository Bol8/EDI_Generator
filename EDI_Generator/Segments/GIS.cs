using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Segments.AuxClass;

namespace EDI_Generator.Segments
{
    internal class GIS:SegmentoEDI
    {
        //C529 INDICADOR DE PROCESO
        private readonly IndicadorDeProceso _indicadorDeProceso_C529;
       
        public GIS(IndicadorDeProceso indicadorDeProcesoC529) 
            : base("GIS")
        {
            _indicadorDeProceso_C529 = indicadorDeProcesoC529;

            Segmento = montaSegmento();
        }


        protected sealed override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += C529_IndicadorProceso();
            cadena += cerrarSegmento();

            return cadena;
        }


        private string C529_IndicadorProceso()
        {
            var cadena = "";

            if (_indicadorDeProceso_C529 != null)
            {
                cadena = unirElementos(":", _indicadorDeProceso_C529.IndicadorProcesoCodificado_7365,
                                            _indicadorDeProceso_C529.CalificadorListaCodigosCodificado_1131,
                                            _indicadorDeProceso_C529.AgenciaResponsableListaCodigosCodificada_3055,
                                            _indicadorDeProceso_C529.IdentificacionTipoProceso_7187);
            }

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
