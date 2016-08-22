using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Segments.AuxClass;

namespace EDI_Generator.Segments
{
    internal class CNT:SegmentoEDI
    {
        //C270 CONTROL
        private readonly ControlDeTotales _controlDeTotales;


        public CNT(ControlDeTotales controlDeTotales) 
            : base("CNT")
        {
            _controlDeTotales = controlDeTotales;

            Segmento = montaSegmento();
        }

        public override string getSegmento()
        {
            return Segmento;
        }

        protected override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += C270_Control();
            cadena += cerrarSegmento();

            return cadena;
        }

        private string C270_Control()
        {
            var cadena = "";

            if (_controlDeTotales != null)
            {
                cadena = unirElementos(":", _controlDeTotales.CalificadorDeControl,
                                            _controlDeTotales.ValorDeControl,
                                            _controlDeTotales.CalificadorUnidadDeMedida);
            }

            return "+" + cadena;
        }

        protected override string cerrarSegmento()
        {
            return _cierreSegmento;
        }
    }
}
