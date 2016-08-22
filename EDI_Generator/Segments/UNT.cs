using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments
{
    internal class UNT:SegmentoEDI
    {
        private readonly string _numeroSegementosMensaje_0074;
        private readonly string _numeroReferenciaMensaje_0062;



        public UNT(string numeroSegmentosMensaje,string numeroReferenciaMensaje) 
            : base("UNT")
        {
            _numeroSegementosMensaje_0074 = numeroSegmentosMensaje;
            _numeroReferenciaMensaje_0062 = numeroReferenciaMensaje;

            Segmento = montaSegmento();
        }



        public override string getSegmento()
        {
            return Segmento;
        }

        protected sealed override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += _0074_NumeroSegmentosMensaje();
            cadena += _0062_numeroReferenciaMensaje();
            cadena += cerrarSegmento();

            return cadena;
        }

        private string _0074_NumeroSegmentosMensaje()
        {
            return "+" + _numeroSegementosMensaje_0074;
        }

        private string _0062_numeroReferenciaMensaje()
        {
            return "+" + _numeroReferenciaMensaje_0062;
        }

        protected override string cerrarSegmento()
        {
            return _cierreSegmento;
            ;
        }
    }
}
