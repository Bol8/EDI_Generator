using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Segments.AuxClass;

namespace EDI_Generator.Segments
{
    internal class LOC:SegmentoEDI
    {
        private readonly string _calificadorLugar_3227;

        //C517 IDENTIFICACIÓN DE LUGAR
        private readonly IdentificacionLugar _identificacionLugar;

        //C519 PRIMERA IDENTICACIÓN DE LUGAR
        private IdentificacionLugar _primeraIdentificacionLugar;

        //C553 SEGUNDA IDENTIFICACIÓN DE LUGAR
        private IdentificacionLugar _segundaIdentificacionLugar;

        private readonly string _relacionCodificado_5479;



        public LOC(string calificadorLugar, IdentificacionLugar codigoIdentificacionAduanera, string relacionCodificado) 
            : base("LOC")
        {
            _calificadorLugar_3227 = calificadorLugar;
            _identificacionLugar = codigoIdentificacionAduanera;
            _relacionCodificado_5479 = relacionCodificado;

            Segmento = montaSegmento();
        }



        public override string getSegmento()
        {
            return Segmento;
        }

       
        protected override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += _3227_CalificadorLugar();
            cadena += C517_IdentificacionLugar();
            cadena += _5479_RelacionCodificado();
            cadena += cerrarSegmento();

            return cadena;
        }



        private string _3227_CalificadorLugar()
        {
            return "+" + _calificadorLugar_3227;
        }


        private string C517_IdentificacionLugar()
        {
            var cadena = unirElementos(":", _identificacionLugar.IdentificacionDeLugar,
                                            _identificacionLugar.CalificadorListaCodigos,
                                            _identificacionLugar.AgenciaResponsableListaCodigosCodificada,
                                            _identificacionLugar.Lugar);

            return "+" + cadena;
        }


        private string _5479_RelacionCodificado()
        {
            return "+" + _relacionCodificado_5479;
        }

        protected override string cerrarSegmento()
        {
            return _cierreSegmento;
        }
    }
}
