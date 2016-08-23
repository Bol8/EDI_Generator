using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Segments.AuxClass;

namespace EDI_Generator.Segments
{
    internal class UNH : SegmentoEDI
    {
        private readonly string _numRefMensaje0062;
        private readonly string _referenciaAccesoComun_0068;

        //S009 IDENTIFICADOR DEL MENSAJE
        private readonly IdentificadorDelMensaje _identificadorDelMensaje_S009;

      
        //S010 ESTADO DE LA TRANSFERENCIA
        private readonly EstadoTransferencia _estadoTransferencia_S010;

        private readonly string _numTransfSecuenciaMensaje_0070;
        private readonly string _indicacionSecuenciaMensaje_0073;


        /// <summary>
        /// Constructor que monta segmento UNH 
        /// </summary>
        /// <param name="numRefMensaje0062"></param>
        /// <param name="identificadorDelMensajeS009"></param>
        /// <param name="referenciaAccesoComun0068"></param>
        /// <param name="estadoTransferenciaS010"></param>
        public UNH(string numRefMensaje0062,IdentificadorDelMensaje identificadorDelMensajeS009,
                   string referenciaAccesoComun0068,EstadoTransferencia estadoTransferenciaS010)
            : base("UNH")
        {
            _numRefMensaje0062 = numRefMensaje0062;
            _identificadorDelMensaje_S009 = identificadorDelMensajeS009;
            _referenciaAccesoComun_0068 = referenciaAccesoComun0068;
            _estadoTransferencia_S010 = estadoTransferenciaS010;

            Segmento = montaSegmento();
        }

        protected sealed override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += _0062_NumeroReferenciaMensaje();
            cadena += S009_IdentificadorMensaje();
            cadena += _0068_ReferenciaAccesoComun();
            cadena += S010_EstadoTransferencia();
            cadena += cerrarSegmento();

            return cadena;
        }

        private string _0062_NumeroReferenciaMensaje()
        {
            return "+" + _numRefMensaje0062;
        }

        private string S009_IdentificadorMensaje()
        {
            var cadena = "";

            if (_identificadorDelMensaje_S009 != null)
            {
                cadena = unirElementos(":", _identificadorDelMensaje_S009.IdentificadorTipoMensaje_0065,
                                            _identificadorDelMensaje_S009.NumeroVersionTipoMensaje_0052,
                                            _identificadorDelMensaje_S009.NumeroPublicacionTipoMensaje_0054,
                                            _identificadorDelMensaje_S009.AgenciaControladora_0051,
                                            _identificadorDelMensaje_S009.CodigoAsignadoDeAsociacion_0057);
            }

            return "+" + cadena;
        }

        private string _0068_ReferenciaAccesoComun()
        {
            return "+" + _referenciaAccesoComun_0068;
        }

        private string S010_EstadoTransferencia()
        {
            var cadena = "";

            if (_estadoTransferencia_S010 != null)
            {
                cadena = unirElementos(":", _estadoTransferencia_S010.NumeroTransferenciaSecuenciaMensaje_0070,
                                            _estadoTransferencia_S010.IdicacionSecuenciaMensaje_0073);
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
