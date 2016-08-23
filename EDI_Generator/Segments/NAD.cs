using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Segments.AuxClass;

namespace EDI_Generator.Segments
{
    internal class NAD : SegmentoEDI
    {
        protected string _calificadorEntidad3035;

        //C082 IDENTIFICACIÓN DE LA PARTE O ENTIDAD
        private readonly IdentificacionDeLaParte _identificacionDeLaParte_C082;

        //C058 NOMBRE Y DIRECCIÓN
        protected string _direccion3124;
        protected List<string> _listaDirecciones;


        //C080 NOMBRE DE LA PARTE O ENTIDAD
        protected string _nombreEntidad_3036;
        protected List<string> _listaNombreEntidades;

        //C059 CALLE
        protected string _calle_3042;
        protected List<string> _listaCalles;


        protected string _nombreCiudad_3164;
        protected string _subEntidadPais_3229;
        protected string _codigoPostal_3251;
        protected string _paisCodificado_3207;



        public NAD(string calificadorEntidad3035,IdentificacionDeLaParte identificacionDeLaParteC082, 
                   string direccion3124, string nombreEntidad3036, string calle3042,
                   string nombreCiudad3164, string subEntidadPais3229, string codigoPostal3251,
                   string paisCodificado3207)
            : base("NAD")
        {
            _calificadorEntidad3035 = calificadorEntidad3035;
            _identificacionDeLaParte_C082 = identificacionDeLaParteC082;
            _direccion3124 = direccion3124;
            _nombreEntidad_3036 = nombreEntidad3036;
            _calle_3042 = calle3042;
            _nombreCiudad_3164 = nombreCiudad3164;
            _subEntidadPais_3229 = subEntidadPais3229;
            _codigoPostal_3251 = codigoPostal3251;
            _paisCodificado_3207 = paisCodificado3207;

            Segmento = montaSegmento();
        }



        public override string getSegmento()
        {
            return Segmento;
        }

        protected sealed override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += _3035_CalificadorDeLaParte();
            cadena += C082_IdentificacionDeLaParte();
            cadena += _C058_NombreDireccion();
            cadena += _C080_NombreEntidad();
            cadena += _C059_Calle();
            cadena += _3164_NombreCiudad();
            cadena += _3229_SubEntidadCodificada();
            cadena += _3251_CodigoPostal();
            cadena += _3207_PaisCodificado();
            cadena += cerrarSegmento();

            return cadena;
        }

        private string _3035_CalificadorDeLaParte()
        {
            return "+" + _calificadorEntidad3035;
        }

        private string C082_IdentificacionDeLaParte()
        {
            var cadena = "";

            if (_identificacionDeLaParte_C082 != null)
            {
                cadena = unirElementos(":", _identificacionDeLaParte_C082.IdentificacionEntidadCodificada_3039,
                                            _identificacionDeLaParte_C082.IdentificadorListaCodigosCodificado_1131,
                                            _identificacionDeLaParte_C082.AgenciaResponsableListaCodigosCodificada_3055);
            }

            return "+" + cadena;
        }


        private string _C058_NombreDireccion()
        {
            return "+" + _direccion3124;
        }

        private string _C080_NombreEntidad()
        {
            return "+" + _nombreEntidad_3036;
        }

        private string _C059_Calle()
        {
            return "+" + _calle_3042;
        }

        private string _3164_NombreCiudad()
        {
            return "+" + _nombreCiudad_3164;
        }

        private string _3229_SubEntidadCodificada()
        {
            return "+" + _subEntidadPais_3229;
        }

        private string _3251_CodigoPostal()
        {
            return "+" + _codigoPostal_3251;
        }

        private string _3207_PaisCodificado()
        {
            return "+" + _paisCodificado_3207;
        }


        protected override string cerrarSegmento()
        {
            return _cierreSegmento;
        }


    }
}
