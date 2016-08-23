using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Segments.AuxClass;

namespace EDI_Generator.Segments
{
    internal class MOA:SegmentoEDI
    {
        //C516 IMPORTE MONETARIO
        private readonly ImporteMonetario _importeMonetario_C516;

        //private readonly string _calificadorImporteMonetario_5026;
        //private readonly string _importeMonetario_5004;
        //private readonly string _monedaCodificada_6345;
        //private readonly string _calificadorMoneda_6343;
        //private readonly string _statusCodificado_4405;


        public MOA(ImporteMonetario importeMonetarioC516) 
            : base("MOA")
        {
            _importeMonetario_C516 = importeMonetarioC516;

            Segmento = montaSegmento();
        }

        public override string getSegmento()
        {
           return Segmento;
        }

        protected sealed override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += C516_ImporteMonetario();
            cadena += cerrarSegmento();


            return cadena;
        }


        private string C516_ImporteMonetario()
        {
            var cadena = "";

            if (_importeMonetario_C516 != null)
            {
                cadena = unirElementos(":", _importeMonetario_C516.CalificadorTipoImporte_5025,
                                            _importeMonetario_C516.ImporteMonetario_5004,
                                            _importeMonetario_C516.MonedaCodificada_6345,
                                            _importeMonetario_C516.CalificadorMoneda_6343,
                                            _importeMonetario_C516.StatusCodificado_4405);
            }

            return "+" + cadena;
        }


        protected override string cerrarSegmento()
        {
            return _cierreSegmento;
        }
    }
}
