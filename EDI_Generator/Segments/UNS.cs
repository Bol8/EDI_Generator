using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments
{
    internal class UNS:SegmentoEDI
    {
        private readonly string _idSeccion_0081;


        public UNS(string idSeccion) 
            : base("UNS")
        {
            _idSeccion_0081 = idSeccion;

            Segmento = montaSegmento();
        }


        public override string getSegmento()
        {
            return Segmento;
        }

        protected override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += _0081_IdentificacionSeccion();
            cadena += cerrarSegmento();

            return cadena;
        }


        private string _0081_IdentificacionSeccion()
        {
            return "+" + _idSeccion_0081;
        }


        protected override string cerrarSegmento()
        {
            return _cierreSegmento;
        }
    }
}
