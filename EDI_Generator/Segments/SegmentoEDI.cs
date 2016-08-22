using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Interfaces;

namespace EDI_Generator.Segments
{
    public abstract class SegmentoEDI
    {
        protected readonly string _idSEgmento;
        protected const string _cierreSegmento = "'";
        protected string Segmento;


        protected SegmentoEDI(string idSegmento )
        {
            _idSEgmento = idSegmento;
        }


        public abstract string getSegmento();

        protected abstract string montaSegmento();

        protected abstract string cerrarSegmento();

        protected string unirElementos(string separator, params string[] args)
        {
            var cadena = String.Join(separator, args);

            return cadena;
        }
    }
}
