using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Segments.AuxClass;

namespace EDI_Generator.Segments
{
    internal class DTM:SegmentoEDI
    {
        //C507 FECHA/HORA/PERIODO
        private readonly FechaHoraPeriodo _fechaHoraPeriodo_C507;
       

        public DTM(FechaHoraPeriodo fechaHoraPeriodoC507) 
            : base("DTM")
        {
            _fechaHoraPeriodo_C507 = fechaHoraPeriodoC507;

            Segmento = montaSegmento();
        }


        protected sealed override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += C507_FechaHoraPeriodo();
            cadena += cerrarSegmento();

            return cadena;
        }


        private string C507_FechaHoraPeriodo()
        {
            var cadena = "";

            if (_fechaHoraPeriodo_C507 != null)
            {
                cadena = unirElementos(":", _fechaHoraPeriodo_C507.CalificadorFechaHora_2005,
                                            _fechaHoraPeriodo_C507.FechaHora_2380,
                                            _fechaHoraPeriodo_C507.CalificadorFormatoFechaHora_2379);
            }
          
           
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
