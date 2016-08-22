using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments
{
    internal class DTM:SegmentoEDI
    {
        //C507 FECHA/HORA/PERIODO
        private readonly string _calificadorFecha_2005;
        private readonly string _fecha_2380;
        private readonly string _calificadorFormatoFecha_2379;


        public DTM(string calificadorFecha,string fecha,string calificadorFormatoFecha) 
            : base("DTM")
        {
            _calificadorFecha_2005 = calificadorFecha;
            _fecha_2380 = fecha;
            _calificadorFormatoFecha_2379 = calificadorFormatoFecha;

            Segmento = montaSegmento();
        }


        protected override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += C507_FechaHoraPeriodo();
            cadena += cerrarSegmento();

            return cadena;
        }


        private string C507_FechaHoraPeriodo()
        {
            var cadena = _calificadorFecha_2005;

            if (!string.IsNullOrEmpty(_fecha_2380)) cadena += ":" + _fecha_2380;
            if (!string.IsNullOrEmpty(_calificadorFormatoFecha_2379)) cadena += ":" + _calificadorFormatoFecha_2379;
           
            return "+" + cadena;
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
