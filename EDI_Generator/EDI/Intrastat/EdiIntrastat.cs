using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Segments;
using EDI_Generator.Segments.AuxClass;

namespace EDI_Generator.EDI.Intrastat
{
    public abstract class EdiIntrastat:EDI
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
       // private const string _calificadorListaCodigos_1131 = "176";

        //DTM
        private const string _calificadorFechaPeriodo_2005 = "320";
        private const string _calificadorFechaAltaDocumento = "137";

        //GIS


        //RFF
        private const string _calificadorReferencia_1153 = "ACW";

        //NAD
        private const string _calificadorDeEntidad_3035 = "DT";

        //MOA
        private const string _monedaCodificada = "EUR";

        //TDT
        private const string _calificadorRutaTransporte_8051 = "2";

        #endregion


        protected EdiIntrastat()
        {
            Segmentos = new List<SegmentoEDI>();
        }


        internal void montarUnb(string idEmisor,string ReferenciaControlIntercambio_0020,bool indicadorPrueba)
        {
            var Unb = new UNB(new IdentificadorDeSintaxis(_identificadorSintaxis_0001, _numeroVersionSintaxis_0002),
                              new EmisorDelIntercambio(idEmisor, _codCalificadorIdentificacionParticipante_0007,null),
                              new ReceptorDelIntercambio(_idReceptor_0010, _codCalificadorIdentificacionParticipante_0007,null),
                              ReferenciaControlIntercambio_0020,
                              null,null,null,null,null,true);

            Segmentos.Add(Unb);
            Mensaje += Unb.getSegmento();
        }


        protected void montarUnh(string numeroReferenciaMensaje)
        {
            var Unh = new UNH(numeroReferenciaMensaje,
                             new IdentificadorDelMensaje(_idTipoMensaje_0065, _numeroVersionTipoMensaje_0052,
                                                         _numeroPublicacionTipoMensaje_0054, _agenciaControladora_0051, 
                                                         _codigoAsignadoDeAsociacion_0057),
                              null,null);

            Segmentos.Add(Unh);
            Mensaje += Unh.getSegmento();
        }



        protected void montarUnz(string ReferenciaControlIntercambio)
        {
            var Unz = new UNZ(ReferenciaControlIntercambio,_cuentaControlIntercambio_0036);

            Segmentos.Add(Unz);
            Mensaje += Unz.getSegmento();
        }


        protected void montarBgm(string numeroDocumento_1004,string codigoDeFuncionDelMensaje_1225)
        {
            var Bgm = new BGM(new DocumentoDelMensaje(_nombreDocumentoCodificado_1001, null, null, null), 
                              numeroDocumento_1004,
                              codigoDeFuncionDelMensaje_1225,
                              null);

            Segmentos.Add(Bgm);
            Mensaje += Bgm.getSegmento();
        }


        protected void montarCst(string numeroPartida, string codigoIdentificacionAduanera_7361, string calificadorListaCodigos_1131)
        {
            var Cst = new CST(numeroPartida,new CodigoIdentificacionAduanera(codigoIdentificacionAduanera_7361,calificadorListaCodigos_1131,null));

            Segmentos.Add(Cst);
            Mensaje += Cst.getSegmento();
        }

        protected void montarDtm(string calificadorFecha_2005,string FechaHora)
        {
            var Dtm = new DTM(new FechaHoraPeriodo(calificadorFecha_2005, FechaHora, null));

            Segmentos.Add(Dtm);
            Mensaje += Dtm.getSegmento();

        }

        protected void montarGis(string indicadorProcesoCodificado_7365,string calificadorListaCodigosCodificado_1131)
        {
            var Dtm = new GIS(new IndicadorDeProceso(indicadorProcesoCodificado_7365, calificadorListaCodigosCodificado_1131,
                              null, null));

            Segmentos.Add(Dtm);
            Mensaje += Dtm.getSegmento();
        }


        protected void montarRff(string numeroReferencia_1154)
        {
            var Rff = new RFF(new Referencia(_calificadorReferencia_1153, numeroReferencia_1154, null, null));

            Segmentos.Add(Rff);
            Mensaje += Rff.getSegmento();
        }


        protected void montarNad(string calificadorDeEntidad_3035, string identificacionEntidadCodificada_3039, string nombreEntidad)
        {
            var Nad = new NAD(calificadorDeEntidad_3035,new IdentificacionDeLaParte(identificacionEntidadCodificada_3039,null,null),
                              null,nombreEntidad,null,null,null,null,null);

            Segmentos.Add(Nad);
            Mensaje += Nad.getSegmento();
        }

        protected void montarUns(string identificacionDeSeccion_0081)
        {
            var Uns = new UNS(identificacionDeSeccion_0081);

            Segmentos.Add(Uns);
            Mensaje += Uns.getSegmento();
        }


        protected void montarLoc(string calificadorDeLugar_3227,string identificacionLugar)
        {
            var Loc = new LOC(calificadorDeLugar_3227,
                              new IdentificacionLugar(identificacionLugar,null,null,null),
                              null, null, null);
                              
                            

            Segmentos.Add(Loc);
            Mensaje += Loc.getSegmento();
        }


        protected void montarMea(string calificadorAplicacionMedida_6311,string calificadorUnidadMedida_6411,string valorMedida_6314)
        {
            var Mea = new MEA(calificadorAplicacionMedida_6311,null,
                              new ValorAmplitud(calificadorUnidadMedida_6411,valorMedida_6314,null,null),
                              null );

            Segmentos.Add(Mea);
            Mensaje += Mea.getSegmento();
        }

        protected void montarTdt(string modoTransporteCodificado_8067)
        {
            var Tdt = new TDT(_calificadorRutaTransporte_8051,null,
                              new ModoTransporte(modoTransporteCodificado_8067,null),
                              null, null, null, null, null);
                             

            Segmentos.Add(Tdt);
            Mensaje += Tdt.getSegmento();
        }


        protected void montarMoa(string calificadorTipoImporte_5025,string importeMonetario_5004 )
        {
            var Moa = new MOA(new ImporteMonetario(calificadorTipoImporte_5025, importeMonetario_5004, _monedaCodificada, null, null));

            Segmentos.Add(Moa);
            Mensaje += Moa.getSegmento();
        }


        protected void montarTod(string plazoEntregaCodificado_4053)
        {
            var Tod = new TOD(null,null,
                              new PlazoEntrega(plazoEntregaCodificado_4053,null,null,null,null));

            Segmentos.Add(Tod);
            Mensaje += Tod.getSegmento();
        }


        protected void montarCnt(string calificadorControl_6069,string valorControl_6066)
        {
            var Cnt = new CNT(new ControlDeTotales(calificadorControl_6069,valorControl_6066,null));

            Segmentos.Add(Cnt);
            Mensaje += Cnt.getSegmento();
        }


        protected void montarUnt(string numeroSegmentosMensaje_0074,string numeroReferenciaMensaje_0062)
        {
            var Unt = new UNT(numeroSegmentosMensaje_0074,numeroReferenciaMensaje_0062);

            Segmentos.Add(Unt);
            Mensaje += Unt.getSegmento();
        }

    }
}
