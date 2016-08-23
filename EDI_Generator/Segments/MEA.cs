using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Segments.AuxClass;

namespace EDI_Generator.Segments
{
    internal class MEA:SegmentoEDI
    {
        private readonly string _calificadorAplicacionMedida_6311;

        //C502 INFORMACIÓN DE MEDIDAS
        private readonly InformacionMedidas _informacionMedidas_C502;

        //C174 VALOR/AMPLITUD
        private readonly ValorAmplitud _valorAmplitud_C174;

        private readonly string _indicadorSuperficie_7383;


        public MEA(string calificadorAplicacionMedida6311,InformacionMedidas informacionMedidasC502, ValorAmplitud valorAmplitudC174, string indicadorSuperficie7383) 
            : base("MEA")
        {
            _informacionMedidas_C502 = informacionMedidasC502;
            _valorAmplitud_C174 = valorAmplitudC174;
            _indicadorSuperficie_7383 = indicadorSuperficie7383;
            _calificadorAplicacionMedida_6311 = calificadorAplicacionMedida6311;

            Segmento = montaSegmento();
        }



        public override string getSegmento()
        {
            return Segmento;
        }

        protected sealed override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += _6311_CalificadorAplicacionMedida();
            cadena += C502_InformacionMedias();
            cadena += C174_ValorAmplitud();
            cadena += _7383_IndicadorSuperficie();
            cadena += cerrarSegmento();


            return cadena;
        }


        private string _6311_CalificadorAplicacionMedida()
        {
            return "+" + _calificadorAplicacionMedida_6311;
        }


        private string C502_InformacionMedias()
        {
            var cadena = unirElementos(":", _informacionMedidas_C502.DimensionMedidaCodificada_6313,
                                            _informacionMedidas_C502.SignificadoMedidasCodificada_6321,
                                            _informacionMedidas_C502.AtributoMedidasCodificada_6155);


            return "+" + cadena;
        }


        private string C174_ValorAmplitud()
        {
            var cadena = unirElementos(":", _valorAmplitud_C174.CalificadorUnidadMedida_6411,
                                            _valorAmplitud_C174.ValorMedida_6314,
                                            _valorAmplitud_C174.AmplitudMinima_6162,
                                            _valorAmplitud_C174.AmplitudMaxima_6152);

            return "+" + cadena;
        }


        private string _7383_IndicadorSuperficie()
        {
            return "+" + _indicadorSuperficie_7383;
        }

        protected override string cerrarSegmento()
        {
            return _cierreSegmento;
        }
    }
}
