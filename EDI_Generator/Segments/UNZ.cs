using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Interfaces;

namespace EDI_Generator.Segments
{
    internal class UNZ:SegmentoEDI
    {
        private readonly string _numMensajes0036;
        private readonly string _referenciaIntercambio_0020;

        public UNZ(string referenciaIntercambio0020,string numMensajes0036)
        :base("UNZ")
        {
            _referenciaIntercambio_0020 = referenciaIntercambio0020;
            _numMensajes0036 = numMensajes0036;

            Segmento = montaSegmento();
        }


        protected sealed override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += _0036_CuentaControlDelIntercambio();
            cadena += _0020_ReferenciaDeControlDelIntercambio();
            cadena += cerrarSegmento();

            return cadena;
        }

        private string _0036_CuentaControlDelIntercambio()
        {
            return "+" + _numMensajes0036;
        }

        private string _0020_ReferenciaDeControlDelIntercambio()
        {
            return "+" + _referenciaIntercambio_0020;
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
