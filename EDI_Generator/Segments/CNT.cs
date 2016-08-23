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
        private readonly ControlDeTotales _controlDeTotales_C270;


        public CNT(ControlDeTotales controlDeTotalesC270) 
            : base("CNT")
        {
            _controlDeTotales_C270 = controlDeTotalesC270;

            Segmento = montaSegmento();
        }

        public override string getSegmento()
        {
            return Segmento;
        }

        protected sealed override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += C270_Control();
            cadena += cerrarSegmento();

            return cadena;
        }

        private string C270_Control()
        {
            var cadena = "";

            if (_controlDeTotales_C270 != null)
            {
                cadena = unirElementos(":", _controlDeTotales_C270.CalificadorDeControl_6069,
                                            _controlDeTotales_C270.ValorDeControl_6066,
                                            _controlDeTotales_C270.CalificadorUnidadDeMedida_6411);
            }

            return "+" + cadena;
        }

        protected override string cerrarSegmento()
        {
            return _cierreSegmento;
        }
    }
}
