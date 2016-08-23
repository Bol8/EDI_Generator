using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Interfaces;
using EDI_Generator.Segments.AuxClass;

namespace EDI_Generator.Segments
{
    internal class UNB : SegmentoEDI
    {
        //S001 IDENTIFICADOR DE SINTAXIS
        private readonly IdentificadorDeSintaxis _identificadorDeSintaxis_S001;

        //S002 EMISOR DEL INTERCAMBIO
        private readonly EmisorDelIntercambio _emisorDelIntercambio_S002;

        //S003 RECEPTOR DEL INTERCAMBIO
        private readonly ReceptorDelIntercambio _receptorDelIntercambio_S003;

        //S004 FECHA Y HORA DE PREPARACIÓN
        private string _fechaHora_0019;

        public string _referenciaIntercambio_0020;

        //S005 CLAVE DE REFERENCIA DEL RECEPTOR
        private readonly ClaveReferenciaReceptor _claveReferenciaReceptor_S005;

        //OTROS
        private readonly string _referenciaAplicacion_0026;
        private readonly string _codigoPrioridadProcesado_0029;
        private readonly string _solicitudDeAcuseDeRecibo_0031;
        private readonly string _idAcuerdoComunicaciones_0032;

        public bool _indicadorPrueba;


        /// <summary>
        /// Constructor que monta el segmento UNB
        /// </summary>
        /// <param name="receptorDelIntercambioS003"></param>
        /// <param name="referenciaIntercambio0020"></param>
        /// <param name="identificadorDeSintaxisS001"></param>
        /// <param name="emisorDelIntercambioS002"></param>
        /// <param name="claveReferenciaReceptorS005"></param>
        /// <param name="referenciaAplicacion0026"></param>
        /// <param name="codigoPrioridadProcesado0029"></param>
        /// <param name="solicitudDeAcuseDeRecibo0031"></param>
        /// <param name="identificacionAcuerdoComunicaciones0032"></param>
        /// <param name="indicadorPrueba"></param>
        public UNB(IdentificadorDeSintaxis identificadorDeSintaxisS001, EmisorDelIntercambio emisorDelIntercambioS002,
                   ReceptorDelIntercambio receptorDelIntercambioS003, string referenciaIntercambio0020,
                   ClaveReferenciaReceptor claveReferenciaReceptorS005,string referenciaAplicacion0026,string codigoPrioridadProcesado0029,
                   string solicitudDeAcuseDeRecibo0031,string identificacionAcuerdoComunicaciones0032,
                   bool indicadorPrueba)
            : base("UNB")
        {
            _identificadorDeSintaxis_S001 = identificadorDeSintaxisS001;
            _emisorDelIntercambio_S002 = emisorDelIntercambioS002;
            _receptorDelIntercambio_S003 = receptorDelIntercambioS003;
            _referenciaIntercambio_0020 = referenciaIntercambio0020;
            _claveReferenciaReceptor_S005 = claveReferenciaReceptorS005;
            _referenciaAplicacion_0026 = referenciaAplicacion0026;
            _codigoPrioridadProcesado_0029 = codigoPrioridadProcesado0029;
            _solicitudDeAcuseDeRecibo_0031 = solicitudDeAcuseDeRecibo0031;
            _idAcuerdoComunicaciones_0032 = identificacionAcuerdoComunicaciones0032;
            _indicadorPrueba = indicadorPrueba;

            Segmento = montaSegmento();
        }


        public override string getSegmento()
        {
            return Segmento;
        }

        protected sealed override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += S001_IdentificadorDeSintaxis();
            cadena += S002_EmisorDelIntercambio();
            cadena += S003_ReceptorDeiIntercambio();
            cadena += S004_FechaHoraPreparacion();
            cadena += _0020_ReferenciaDeControlDeIntercambio();
            cadena += S005_ClaveReferenciaDelReceptor();
            cadena += _0026_ReferenciaDelaAplicacion();
            cadena += _0029_CodigoPrioridadProcesado();
            cadena += _0031_SolicitudDeAcuseDeRecibo();
            cadena += _0032_IdentificacionAcuerdoComunicaciones();
            cadena += _0035_IndicadorPrueba();
            cadena += cerrarSegmento();

            return cadena;
        }


        private string S001_IdentificadorDeSintaxis()
        {
            var cadena = "";

            if (_identificadorDeSintaxis_S001 != null)
            {
                cadena = unirElementos(":", _identificadorDeSintaxis_S001.IdentificadorDeSintaxis_0001,
                                            _identificadorDeSintaxis_S001.NumeroVersionDeSintaxis_0002);
            }

            return "+" + cadena;
        }


        private string S002_EmisorDelIntercambio()
        {
            var cadena = "";

            if (_emisorDelIntercambio_S002 != null)
            {
                cadena = unirElementos(":", _emisorDelIntercambio_S002.IdentificacionDelEmisor_0004,
                                            _emisorDelIntercambio_S002.CodigoCalificadorIdentificacionParticipante_0007,
                                            _emisorDelIntercambio_S002.DireccionRutaInversa_0008);
            }

            return "+" + cadena;
        }


        private string S003_ReceptorDeiIntercambio()
        {
            var cadena = "";

            if (_receptorDelIntercambio_S003 != null)
            {
                cadena = unirElementos(":", _receptorDelIntercambio_S003.IdentificacionDelReceptor_0010,
                                            _receptorDelIntercambio_S003.CodigoCalificadorIdentificacionParticipante_0007,
                                            _receptorDelIntercambio_S003.DireccionRuta_0014);
            }

            return "+" + cadena;
        }

        private string S004_FechaHoraPreparacion()
        {
            _fechaHora_0019 = DateTime.Now.ToString("yyMMdd:HHmm");
            return "+" + _fechaHora_0019;
        }

        private string _0020_ReferenciaDeControlDeIntercambio()
        {
            return "+" + _referenciaIntercambio_0020;
        }

        private string S005_ClaveReferenciaDelReceptor()
        {
            var cadena = "";

            if (_claveReferenciaReceptor_S005 != null)
            {
                cadena = unirElementos(":", _claveReferenciaReceptor_S005.ClaveDelReceptor_0022,
                                            _claveReferenciaReceptor_S005.CalificadorClaveReceptor_0025);
            }

            return "+" + cadena;
        }

        private string _0026_ReferenciaDelaAplicacion()
        {
            return "+" + _referenciaAplicacion_0026;
        }

        private string _0029_CodigoPrioridadProcesado()
        {
            return "+" + _codigoPrioridadProcesado_0029;
        }

        private string _0031_SolicitudDeAcuseDeRecibo()
        {
            return "+" + _solicitudDeAcuseDeRecibo_0031;
        }

        private string _0032_IdentificacionAcuerdoComunicaciones()
        {
            return "+" + _idAcuerdoComunicaciones_0032;
        }


        private string _0035_IndicadorPrueba()
        {
            var cadena = "";
            if (_indicadorPrueba) cadena = "1";

            return "+" + cadena;
        }


        protected override string cerrarSegmento()
        {
            return _cierreSegmento;
        }
    }
}
