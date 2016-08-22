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
        private readonly InformacionMedidas _informacionMedidas;

        //C174 VALOR/AMPLITUD
        private readonly ValorAmplitud _valorAmplitud;


        private readonly string _indicadorSuperficie;

        public MEA(string calificadorAplicacionMedida6311,InformacionMedidas informacionMedidas, ValorAmplitud valorAmplitud, string indicadorSuperficie) 
            : base("MEA")
        {
            _informacionMedidas = informacionMedidas;
            _valorAmplitud = valorAmplitud;
            _indicadorSuperficie = indicadorSuperficie;
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
            var cadena = unirElementos(":", _informacionMedidas.DimensionMedidaCodificada,
                                            _informacionMedidas.SignificadoMedidasCodificada,
                                            _informacionMedidas.AtributoMedidasCodificada);


            return "+" + cadena;
        }


        private string C174_ValorAmplitud()
        {
            var cadena = unirElementos(":", _valorAmplitud.CalificadorUnidadMedida,
                                            _valorAmplitud.ValorMedida,
                                            _valorAmplitud.AmplitudMinima,
                                            _valorAmplitud.AmplitudMaxima);

            return "+" + cadena;
        }


        private string _7383_IndicadorSuperficie()
        {
            return "+" + _indicadorSuperficie;
        }

        protected override string cerrarSegmento()
        {
            return _cierreSegmento;
        }
    }
}
