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
        protected string _calificadorEntidad_3035;

        //C082 IDENTIFICACIÓN DE LA PARTE O ENTIDAD
        private IdentificacionDeLaParte _identificacionDeLaParte;
        protected string _idEntidadCodificada_3039;
        protected string _idListaCodigosCodificado_1131;
        protected string _agenciaResponsableListaCodigosCodificada_3055;

        //C058 NOMBRE Y DIRECCIÓN
        protected string _direccion_3124;
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


        //public NAD(string calificadorEntidad, string idEntidadCodificada, string idListaCodigosCodificado,
        //           string agenciaResponsableListaCodigosCod, string direccion, string nombreEntidad, string calle,
        //           string nombreCiudad, string subEntidadPais, string codigoPostal, string paisCodificado)
        //    : base("NAD")
        //{
        //    _calificadorEntidad_3035 = calificadorEntidad;
        //    _idEntidadCodificada_3039 = idEntidadCodificada;
        //    _idListaCodigosCodificado_1131 = idListaCodigosCodificado;
        //    _agenciaResponsableListaCodigosCodificada_3055 = agenciaResponsableListaCodigosCod;
        //    _direccion_3124 = direccion;
        //    _nombreEntidad_3036 = nombreEntidad;
        //    _calle_3042 = calle;
        //    _nombreCiudad_3164 = nombreCiudad;
        //    _subEntidadPais_3229 = subEntidadPais;
        //    _codigoPostal_3251 = codigoPostal;
        //    _paisCodificado_3207 = paisCodificado;

        //    Segmento = montaSegmento();
        //}

        public NAD(string calificadorEntidad,IdentificacionDeLaParte identificacionDeLaParte, 
                   string direccion, string nombreEntidad, string calle,
                  string nombreCiudad, string subEntidadPais, string codigoPostal, string paisCodificado)
            : base("NAD")
        {
            _calificadorEntidad_3035 = calificadorEntidad;
            _identificacionDeLaParte = identificacionDeLaParte;
            _direccion_3124 = direccion;
            _nombreEntidad_3036 = nombreEntidad;
            _calle_3042 = calle;
            _nombreCiudad_3164 = nombreCiudad;
            _subEntidadPais_3229 = subEntidadPais;
            _codigoPostal_3251 = codigoPostal;
            _paisCodificado_3207 = paisCodificado;

            Segmento = montaSegmento();
        }



        public override string getSegmento()
        {
            return Segmento;
        }

        protected override string montaSegmento()
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
            return "+" + _calificadorEntidad_3035;
        }

        private string C082_IdentificacionDeLaParte()
        {
            var cadena = "";

            if (_identificacionDeLaParte != null)
            {
                cadena = unirElementos(":", _identificacionDeLaParte.IdentificacionEntidadCodificada_3039,
                                            _identificacionDeLaParte.IdentificadorListaCodigosCodificado_1131,
                                            _identificacionDeLaParte.AgenciaResponsableListaCodigosCodificada_3055);
            }

            return "+" + cadena;
        }


        private string _C058_NombreDireccion()
        {
            return "+" + _direccion_3124;
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
