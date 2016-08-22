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
        private readonly ModoTransporte _modoTransporte;

        //C228 MEDIO DE TRANSPORTE
        private readonly MedioTransporte _medioTransporte;

        //C040 TRANSPORTISTA
        private readonly Transportista _transportista;

        private readonly string _direccionTransportistaCodificada_8101;


        //C401 INFORMACIÓN EXCESO CARGA TRANSPORTE
        private readonly InfoExcesoCargaTransporte _infoExcesoCargaTransporte;

        //C222 IDENTIFICACIÓN DE TRANSPORTE
        private readonly IdentificacionTransporte _identificacionTransporte;



        public TDT(string calificadorRutaTransporte8051, string numeroRefTRansporte8028, ModoTransporte modoTransporte,
                   MedioTransporte medioTransporte, Transportista transportista, string direccionTransportistaCodificada8101,
                   InfoExcesoCargaTransporte infoExcesoCargaTransporte, IdentificacionTransporte identificacionTransporte)
            : base("TDT")
        {
            _calificadorRutaTransporte_8051 = calificadorRutaTransporte8051;
            _numeroRefTRansporte_8028 = numeroRefTRansporte8028;
            _modoTransporte = modoTransporte;
            _medioTransporte = medioTransporte;
            _transportista = transportista;
            _direccionTransportistaCodificada_8101 = direccionTransportistaCodificada8101;
            _infoExcesoCargaTransporte = infoExcesoCargaTransporte;
            _identificacionTransporte = identificacionTransporte;

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

            if (_modoTransporte != null)
            {
                cadena = unirElementos(":", _modoTransporte.ModoTransporteCodificado,
                                            _modoTransporte.ModoDeTransporte);
            }

            return "+" + cadena;
        }

        private string C228_MedioTransporte()
        {
            var cadena = "";

            if (_medioTransporte != null)
            {
               cadena = unirElementos(":", _medioTransporte.IdTipoMedioTransporte,
                                           _medioTransporte.TipoMedioTransporte);
            }

            return cadena;
        }

        private string C040_Transportista()
        {
            var cadena = "";

            if (_transportista != null)
            {
                cadena = unirElementos(":", _transportista.TrasnportistaCodificado,
                                           _transportista.IdListaCodigosCodificado,
                                           _transportista.AgenciaResponsableListaCodigosCodificada,
                                           _transportista.NombreTransportista);
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

            if (_infoExcesoCargaTransporte != null)
            {
                cadena = unirElementos(":", _infoExcesoCargaTransporte.RazonExcesoCargaCodificado,
                                            _infoExcesoCargaTransporte.ResponsabilidadExcesoCargaCodificada,
                                            _infoExcesoCargaTransporte.NumeroAutorizacionCliente);
            }

            return "+" + cadena;
        }

        private string C222_IdentificacionTransporte()
        {
            var cadena = "";

            if (_identificacionTransporte != null)
            {
                cadena = unirElementos(":", _identificacionTransporte.IdMedioTransporteCodificado,
                                            _identificacionTransporte.IdListaCodigosCodificado,
                                            _identificacionTransporte.AgenciaResponsableListaCodigosCodificada,
                                            _identificacionTransporte.IdMedioTransporte,
                                            _identificacionTransporte.NacionalidadMedioTransporteCodificada);
            }

            return "+" + cadena;
        }



        protected override string cerrarSegmento()
        {
            return _cierreSegmento;
        }
    }
}
