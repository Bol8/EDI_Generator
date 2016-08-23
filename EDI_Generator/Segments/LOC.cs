using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Segments.AuxClass;

namespace EDI_Generator.Segments
{
    internal class LOC : SegmentoEDI
    {
        private readonly string _calificadorLugar_3227;

        //C517 IDENTIFICACIÓN DE LUGAR
        private readonly IdentificacionLugar _identificacionLugar_C517;

        //C519 PRIMERA IDENTICACIÓN DE LUGAR
        private readonly IdentificacionLugar _primeraIdentificacionLugar_C519;

        //C553 SEGUNDA IDENTIFICACIÓN DE LUGAR
        private readonly IdentificacionLugar _segundaIdentificacionLugar_C553;

        private readonly string _relacionCodificado_5479;



        public LOC(string calificadorLugar3227, IdentificacionLugar IdentificacionLugarC517,
                   IdentificacionLugar primeraIdentificacionLugarC519, IdentificacionLugar segundaIdentificacionLugarC553,
                   string relacionCodificado5479)
            : base("LOC")
        {
            _calificadorLugar_3227 = calificadorLugar3227;
            _identificacionLugar_C517 = IdentificacionLugarC517;
            _primeraIdentificacionLugar_C519 = primeraIdentificacionLugarC519;
            _segundaIdentificacionLugar_C553 = segundaIdentificacionLugarC553;
            _relacionCodificado_5479 = relacionCodificado5479;

            Segmento = montaSegmento();
        }



        public override string getSegmento()
        {
            return Segmento;
        }


        protected sealed override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += _3227_CalificadorLugar();
            cadena += C517_IdentificacionLugar(_identificacionLugar_C517);
            cadena += C517_IdentificacionLugar(_primeraIdentificacionLugar_C519);
            cadena += C517_IdentificacionLugar(_segundaIdentificacionLugar_C553);
            cadena += _5479_RelacionCodificado();
            cadena += cerrarSegmento();

            return cadena;
        }



        private string _3227_CalificadorLugar()
        {
            return "+" + _calificadorLugar_3227;
        }


        private string C517_IdentificacionLugar(IdentificacionLugar identificacionLugar)
        {
            var cadena = "";

            if (identificacionLugar != null)
            {
                cadena = unirElementos(":", identificacionLugar.IdentificacionDeLugar_3225,
                                            identificacionLugar.CalificadorListaCodigos_1131,
                                            identificacionLugar.AgenciaResponsableListaCodigosCodificada_3055,
                                            identificacionLugar.Lugar_3224);
            }

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
