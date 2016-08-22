using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments
{
    internal class MOA:SegmentoEDI
    {
        //C516 IMPORTE MONETARIO
        private readonly string _calificadorImporteMonetario_5026;
        private readonly string _importeMonetario_5004;
        private readonly string _monedaCodificada_6345;
        private readonly string _calificadorMoneda_6343;
        private readonly string _statusCodificado_4405;


        public MOA(string calificadorImporteMonetario,string importeMonetario,string monedaCodificada,
                   string calificadorMoneda,string statusCodificado) 
            : base("MOA")
        {
            _calificadorImporteMonetario_5026 = calificadorImporteMonetario;
            _importeMonetario_5004 = importeMonetario;
            _monedaCodificada_6345 = monedaCodificada;
            _calificadorMoneda_6343 = calificadorMoneda;
            _statusCodificado_4405 = statusCodificado;

            Segmento = montaSegmento();
        }

        public override string getSegmento()
        {
           return Segmento;
        }

        protected override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += C516_ImporteMonetario();
            cadena += cerrarSegmento();


            return cadena;
        }


        private string C516_ImporteMonetario()
        {
            var cadena = unirElementos(":", _calificadorImporteMonetario_5026, _importeMonetario_5004,
                _monedaCodificada_6345, _calificadorMoneda_6343, _statusCodificado_4405);

            return "+" + cadena;
        }


        protected override string cerrarSegmento()
        {
            return _cierreSegmento;
        }
    }
}
