using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Segments.AuxClass;

namespace EDI_Generator.Segments
{
    internal class BGM : SegmentoEDI
    {
        //C002 DOCUMENTO/NOMBRE DEL MENSAJE
        private readonly DocumentoDelMensaje _documentoDelMensaje_C002;

        //OTROS
        private readonly string _numeroDocumento_1004;
        private readonly string _codigoFuncionMensaje_1225;
        private readonly string _tipoRespuestaCodificado_4343;


       /// <summary>
        /// Constructor que monta el segmento BGM
       /// </summary>
       /// <param name="documentoDelMensajeC002"></param>
       /// <param name="numeroDocumento1004"></param>
       /// <param name="codigoFuncionMensaje1225"></param>
       /// <param name="tipoRespuestaCodificado4343"></param>
        public BGM(DocumentoDelMensaje documentoDelMensajeC002, string numeroDocumento1004,
                   string codigoFuncionMensaje1225,string tipoRespuestaCodificado4343)
            : base("BGM")
        {
            _documentoDelMensaje_C002 = documentoDelMensajeC002;
            _numeroDocumento_1004 = numeroDocumento1004;
            _codigoFuncionMensaje_1225 = codigoFuncionMensaje1225;
            _tipoRespuestaCodificado_4343 = tipoRespuestaCodificado4343;

            Segmento = montaSegmento();
        }


        protected sealed override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += C002_NombreDocumento();
            cadena += _1004_NumeroDocumento();
            cadena += _1225_CodigoFuncionMensaje();
            cadena += _4343_TipoRespuesta();
            cadena += cerrarSegmento();

            return cadena;
        }


        private string C002_NombreDocumento()
        {
            var cadena = "";

            if (_documentoDelMensaje_C002 != null)
            {
                cadena = unirElementos(":", _documentoDelMensaje_C002.NombreDocumentoCodificado_1001,
                                            _documentoDelMensaje_C002.CalificadorListaCodigos_1131,
                                            _documentoDelMensaje_C002.AgenciaResponsableListaCodigosCodificada_3055,
                                            _documentoDelMensaje_C002.NombreDocumento_1000);
            }
           

            return "+" + cadena;
        }


        private string _1004_NumeroDocumento()
        {
            return "+" + _numeroDocumento_1004;
        }


        private string _1225_CodigoFuncionMensaje()
        {
            return "+" + _codigoFuncionMensaje_1225;
        }

        private string _4343_TipoRespuesta()
        {
            return "+" + _tipoRespuestaCodificado_4343;
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
