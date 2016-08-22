using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Segments;

namespace EDI_Generator.EDI.Intrastat
{
    public class INTRASTAT_CUSDESC
    {
        #region CONSTANTES
        
        //UNB
        private const string _identificadorSintaxis_0001 = "UNOA";
        private const string _numeroVersionSintaxis_0002 = "1";
        private const string _codCalificadorIdentificacionParticipante_0007 = "ZZ";
        private const string _idReceptor_0010 = "AEATADUE";

        //UNZ
        private const string _cuentaControlIntercambio_0036 = "1";

        //UNH
        private const string _idTipoMensaje_0065 = "CUSDEC";
        private const string _numeroVersionTipoMensaje_0052 = "1";
        private const string _numeroPublicacionTipoMensaje_0054 = "921";
        private const string _agenciaControladora_0051 = "UN";
        private const string _codigoAsignadoDeAsociacion_0057 = "INT003";

        //BGM
        private const string _nombreDocumentoCodificado_1001 = "896";
        private const string _codFuncDeclaracionRectificativa_1225 = "5";
        private const string _codFuncDeclaracionAnulativa_1225 = "3";

        //CST
        private const string _codIdentificacionAduaneraIntroduccion_7361 = "A";
        private const string _codIdentificacionAduaneraExpedicion_7361 = "D";
        private const string _calificadorListaCodigos_1131 = "176";

        //DTM
        private const string _calificadorFechaPeriodo_2005 = "320";
        private const string _calificadorFechaAltaDocumento = "137";

        //GIS


        #endregion


        #region SEGMENTOS

        UNB _UNB;
        UNH _UNH;
        BGM _BGM;
        CST _CST_Cabecera;
        DTM _DTM_Periodo;
        DTM _DTM_AltaDocumento;
        GIS _GIS_DeclaracionSinOperacion;
        GIS _GIS_TipoDeclaracion;
        RFF _RFF;
        NAD _NAD_ObligadoEstadistico;
        NAD _NAD_DatosTercerDeclarante;
        NAD _NAD_ReceptorDeclaracion;
        MOA _MOA_MonedaDeclaracion;
        MOA _MOA_ImporteTotal;
        MOA _MOA_ValorFactura;
        private MOA _MOA_ValorEstadistico;

        UNS _UNS;
        UNT _UNT;
        List<CST> listaPartidasCST;
        LOC _LOC_EstadoMiembroProcedencia;
        LOC _LOC_PaisOrigenMercancia;
        LOC _LOC_ProvinciaEspañolaProcedencia;
        LOC _LOC_Puerto;
        MEA _MEA_MasaBruta;
        MEA _MEA_UnidadesSuplementarias;
        TDT _TDT;
        TOD _TOD;
        CNT _CNT_TotalPartidas;
        CNT _CNT_TotalPesoNeto;
        CNT _CNT_UnidadesSuplementarias;
        CNT _CNT_ValorFactura;
        CNT _CNT_ValorEstadisticoTotal;



        #endregion


        public string MensajeEDI { get; private set; }

        public INTRASTAT_CUSDESC()
        {
            cargarSegmentos();
            montarMensajeEDI();

        }

        private void montarMensajeEDI()
        {
            if (_UNB != null) MensajeEDI = _UNB.getSegmento();
            if (_UNH != null) MensajeEDI += _UNH.getSegmento();
        }



        private void cargarSegmentos()
        {
            cargarUNB();
            cargarUNH();
        }


        private void cargarUNB()
        {
            var idEmisor = "A98989898";
            var refIntercambo = "00294";
            var fehcaEmision = DateTime.Now.ToString("yy-MM-dd");

            //_UNB = new UNB(_identificadorSintaxis_0001,_numeroVersionSintaxis_0002,
            //                _codCalificadorIdentificacionParticipante_0007,
            //                _idReceptor_0010,idEmisor,refIntercambo,true);
        }


        private void cargarUNH()
        {
            //_UNH = new UNH("00294",_idTipoMensaje_0065,_numeroVersionTipoMensaje_0052,
            //               _numeroPublicacionTipoMensaje_0054,_agenciaControladora_0051,
            //               _codigoAsignadoDeAsociacion_0057);
        }


        private void cargarBGM()
        {
           
        }


    }
}
