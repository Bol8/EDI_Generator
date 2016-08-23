using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Segments.AuxClass;

namespace EDI_Generator.Segments
{
    internal class RFF:SegmentoEDI
    {
        //C506 REFERENCIA
        private readonly Referencia _referencia_C506;

       
        public RFF(Referencia referenciaC506) 
            : base("RFF")
        {
            _referencia_C506 = referenciaC506;

            Segmento = montaSegmento();
        }


        protected sealed override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += C506_Referencia();
            cadena += cerrarSegmento();

            return cadena;
        }


        private string C506_Referencia()
        {
            var cadena = "";

            if (_referencia_C506 != null)
            {
                cadena = unirElementos(":", _referencia_C506.CalificadorReferencia_1153,
                                            _referencia_C506.NumeroReferencia_1154,
                                            _referencia_C506.NumeroLinea_1156,
                                            _referencia_C506.NumeroVersionDeLaReferencia_4000);
            }

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
