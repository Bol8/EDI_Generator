using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments
{
    internal class RFF:SegmentoEDI
    {
        //C506 REFERENCIA
        private readonly string _calificadorReferencia_1153;
        private readonly string _numeroReferencia_1154;
        private readonly string _numeroLinea_1156;
        private readonly string _numeroVersionReferencia_4000;


        public RFF(string calificadorReferencia,string numeroReferencia,string numeroLinea,string numeroVersionReferencia) 
            : base("RFF")
        {
            _calificadorReferencia_1153 = calificadorReferencia;
            _numeroReferencia_1154 = numeroReferencia;
            _numeroLinea_1156 = numeroLinea;
            _numeroVersionReferencia_4000 = numeroVersionReferencia;

            Segmento = montaSegmento();
        }


        protected override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += C506_Referencia();
            cadena += cerrarSegmento();

            return cadena;
        }


        private string C506_Referencia()
        {
            var cadena = unirElementos(":", _calificadorReferencia_1153, _numeroReferencia_1154, _numeroLinea_1156,
                _numeroVersionReferencia_4000);

            return "+" + cadena;
        }


        //private string unirSegmento(string separator,params string[] args)
        //{
        //    var cadena = String.Join(separator, args);

        //    return cadena;
        //}



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
