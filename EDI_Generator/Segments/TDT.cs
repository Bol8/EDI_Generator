using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Segments.AuxClass;

namespace EDI_Generator.Segments
{
    internal class TDT : SegmentoEDI
    {
        private readonly string _calificadorRutaTransporte_8051;
        private readonly string _numeroRefTRansporte_8028;

        //C220 MODO DE TRANSPORTE
        private readonly ModoTransporte _modoTransporte_C220;

        //C228 MEDIO DE TRANSPORTE
        private readonly MedioTransporte _medioTransporte_C228;

        //C040 TRANSPORTISTA
        private readonly Transportista _transportista_C040;

        private readonly string _direccionTransportistaCodificada_8101;


        //C401 INFORMACIÓN EXCESO CARGA TRANSPORTE
        private readonly InfoExcesoCargaTransporte _infoExcesoCargaTransporte_C401;

        //C222 IDENTIFICACIÓN DE TRANSPORTE
        private readonly IdentificacionTransporte _identificacionTransporte_C222;



        public TDT(string calificadorRutaTransporte8051, string numeroRefTRansporte8028, ModoTransporte modoTransporteC220,
                   MedioTransporte medioTransporteC228, Transportista transportistaC040, string direccionTransportistaCodificada8101,
                   InfoExcesoCargaTransporte infoExcesoCargaTransporteC401, IdentificacionTransporte identificacionTransporteC222)
            : base("TDT")
        {
            _calificadorRutaTransporte_8051 = calificadorRutaTransporte8051;
            _numeroRefTRansporte_8028 = numeroRefTRansporte8028;
            _modoTransporte_C220 = modoTransporteC220;
            _medioTransporte_C228 = medioTransporteC228;
            _transportista_C040 = transportistaC040;
            _direccionTransportistaCodificada_8101 = direccionTransportistaCodificada8101;
            _infoExcesoCargaTransporte_C401 = infoExcesoCargaTransporteC401;
            _identificacionTransporte_C222 = identificacionTransporteC222;

            Segmento = montaSegmento();
        }


        public override string getSegmento()
        {
            return Segmento;
        }

        protected sealed override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += _8051_CalificadorRutaTransporte();
            cadena += _8028_NumeroRefTransporte();
            cadena += C220_ModoTransporte();
            cadena += C228_MedioTransporte();
            cadena += C040_Transportista();
            cadena += _8101_DireccionTransportistaCodificada();
            cadena += C401_InfoExcesoCargaTransporte();
            cadena += C222_IdentificacionTransporte();
            cadena += cerrarSegmento();

            return cadena;
        }


        private string _8051_CalificadorRutaTransporte()
        {
            return "+" + _calificadorRutaTransporte_8051;
        }


        private string _8028_NumeroRefTransporte()
        {
            return "+" + _numeroRefTRansporte_8028;
        }


        private string C220_ModoTransporte()
        {
            var cadena = "";

            if (_modoTransporte_C220 != null)
            {
                cadena = unirElementos(":", _modoTransporte_C220.ModoTransporteCodificado_8067,
                                            _modoTransporte_C220.ModoDeTransporte_8066);
            }

            return "+" + cadena;
        }

        private string C228_MedioTransporte()
        {
            var cadena = "";

            if (_medioTransporte_C228 != null)
            {
               cadena = unirElementos(":", _medioTransporte_C228.IdTipoMedioTransporte_8179,
                                           _medioTransporte_C228.TipoMedioTransporte_8178);
            }

            return cadena;
        }

        private string C040_Transportista()
        {
            var cadena = "";

            if (_transportista_C040 != null)
            {
                cadena = unirElementos(":", _transportista_C040.TransportistaCodificado_3127,
                                           _transportista_C040.IdListaCodigosCodificado_1131,
                                           _transportista_C040.AgenciaResponsableListaCodigosCodificada_3055,
                                           _transportista_C040.NombreTransportista_3128);
            }

            return "+" + cadena;
        }

        private string _8101_DireccionTransportistaCodificada()
        {
            return "+" + _direccionTransportistaCodificada_8101;
        }


        private string C401_InfoExcesoCargaTransporte()
        {
            var cadena = "";

            if (_infoExcesoCargaTransporte_C401 != null)
            {
                cadena = unirElementos(":", _infoExcesoCargaTransporte_C401.RazonExcesoCargaCodificado_8457,
                                            _infoExcesoCargaTransporte_C401.ResponsabilidadExcesoCargaCodificada_8459,
                                            _infoExcesoCargaTransporte_C401.NumeroAutorizacionCliente_7130);
            }

            return "+" + cadena;
        }

        private string C222_IdentificacionTransporte()
        {
            var cadena = "";

            if (_identificacionTransporte_C222 != null)
            {
                cadena = unirElementos(":", _identificacionTransporte_C222.IdMedioTransporteCodificado_8213,
                                            _identificacionTransporte_C222.IdListaCodigosCodificado_1131,
                                            _identificacionTransporte_C222.AgenciaResponsableListaCodigosCodificada_3055,
                                            _identificacionTransporte_C222.IdMedioTransporte_8212,
                                            _identificacionTransporte_C222.NacionalidadMedioTransporteCodificada_8453);
            }

            return "+" + cadena;
        }



        protected override string cerrarSegmento()
        {
            return _cierreSegmento;
        }
    }
}
