using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Segments;
using EDI_Generator.Segments.AuxClass;

namespace EDI_Generator.EDI.Intrastat
{
    public abstract class CusdecIntrastat:EDI
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
        //private const string _codFuncDeclaracionRectificativa_1225 = "5";
        //private const string _codFuncDeclaracionAnulativa_1225 = "3";

        //CST
        //private const string _codIdentificacionAduaneraIntroduccion_7361 = "A";
        //private const string _codIdentificacionAduaneraExpedicion_7361 = "D";
       // private const string _calificadorListaCodigos_1131 = "176";

        //DTM
        //private const string _calificadorFechaPeriodo_2005 = "320";
        //private const string _calificadorFechaAltaDocumento = "137";

        //GIS


        //RFF
        private const string _calificadorReferencia_1153 = "ACW";

        //NAD
        //private const string _calificadorDeEntidad_3035 = "DT";

        //MOA
        private const string _monedaCodificada = "EUR";

        //TDT
        private const string _calificadorRutaTransporte_8051 = "2";

        #endregion


        protected CusdecIntrastat()
        {
            Segmentos = new List<SegmentoEDI>();
        }


        internal void MontarUnb(string idEmisor,string referenciaControlIntercambio0020,bool indicadorPrueba)
        {
            var unb = new UNB(new IdentificadorDeSintaxis(_identificadorSintaxis_0001, _numeroVersionSintaxis_0002),
                              new EmisorDelIntercambio(idEmisor, _codCalificadorIdentificacionParticipante_0007,null),
                              new ReceptorDelIntercambio(_idReceptor_0010, _codCalificadorIdentificacionParticipante_0007,null),
                              referenciaControlIntercambio0020,
                              null,null,null,null,null,true);

            Segmentos.Add(unb);
            Mensaje += unb.getSegmento();
        }


        protected void MontarUnh(string numeroReferenciaMensaje)
        {
            var unh = new UNH(numeroReferenciaMensaje,
                             new IdentificadorDelMensaje(_idTipoMensaje_0065, _numeroVersionTipoMensaje_0052,
                                                         _numeroPublicacionTipoMensaje_0054, _agenciaControladora_0051, 
                                                         _codigoAsignadoDeAsociacion_0057),
                              null,null);

            Segmentos.Add(unh);
            Mensaje += unh.getSegmento();
        }



        protected void MontarUnz(string referenciaControlIntercambio)
        {
            var unz = new UNZ(referenciaControlIntercambio,_cuentaControlIntercambio_0036);

            Segmentos.Add(unz);
            Mensaje += unz.getSegmento();
        }


        protected void MontarBgm(string numeroDocumento1004,string codigoDeFuncionDelMensaje1225)
        {
            var bgm = new BGM(new DocumentoDelMensaje(_nombreDocumentoCodificado_1001, null, null, null), 
                              numeroDocumento1004,
                              codigoDeFuncionDelMensaje1225,
                              null);

            Segmentos.Add(bgm);
            Mensaje += bgm.getSegmento();
        }

        protected void MontarCstPartidas(string numeroPartida, string codigoIdentificacionAduanera7361, string calificadorListaCodigos1131,
                                         string naturalezaTransaccion,string regimenEstadistico)
        {
            var cst = new CST(numeroPartida,
                              new CodigoIdentificacionAduanera(codigoIdentificacionAduanera7361, calificadorListaCodigos1131, null),
                              null,
                              new CodigoIdentificacionAduanera(naturalezaTransaccion,"112",null),
                              new CodigoIdentificacionAduanera(regimenEstadistico,"177",null),
                              null);

            Segmentos.Add(cst);
            Mensaje += cst.getSegmento();
        }

        protected void MontarCst(string numeroPartida, string codigoIdentificacionAduanera7361, string calificadorListaCodigos1131)
        {
            var cst = new CST(numeroPartida,
                              new CodigoIdentificacionAduanera(codigoIdentificacionAduanera7361,calificadorListaCodigos1131,null));

            Segmentos.Add(cst);
            Mensaje += cst.getSegmento();
        }

        protected void MontarDtm(string calificadorFecha2005,string fechaHora)
        {
            var dtm = new DTM(new FechaHoraPeriodo(calificadorFecha2005, fechaHora, null));

            Segmentos.Add(dtm);
            Mensaje += dtm.getSegmento();

        }

        protected void MontarGis(string indicadorProcesoCodificado7365,string calificadorListaCodigosCodificado1131)
        {
            var dtm = new GIS(new IndicadorDeProceso(indicadorProcesoCodificado7365, calificadorListaCodigosCodificado1131,
                              null, null));

            Segmentos.Add(dtm);
            Mensaje += dtm.getSegmento();
        }


        protected void MontarRff(string numeroReferencia1154)
        {
            var rff = new RFF(new Referencia(_calificadorReferencia_1153, numeroReferencia1154, null, null));

            Segmentos.Add(rff);
            Mensaje += rff.getSegmento();
        }


        protected void MontarNad(string calificadorDeEntidad3035, string identificacionEntidadCodificada3039, string nombreEntidad)
        {
            var nad = new NAD(calificadorDeEntidad3035,new IdentificacionDeLaParte(identificacionEntidadCodificada3039,null,null),
                              null,nombreEntidad,null,null,null,null,null);

            Segmentos.Add(nad);
            Mensaje += nad.getSegmento();
        }

        protected void MontarUns(string identificacionDeSeccion0081)
        {
            var uns = new UNS(identificacionDeSeccion0081);

            Segmentos.Add(uns);
            Mensaje += uns.getSegmento();
        }


        protected void MontarLoc(string calificadorDeLugar3227,string identificacionLugar)
        {
            var loc = new LOC(calificadorDeLugar3227,
                              new IdentificacionLugar(identificacionLugar,null,null,null),
                              null, null, null);
                              
                            

            Segmentos.Add(loc);
            Mensaje += loc.getSegmento();
        }


        protected void MontarMea(string calificadorAplicacionMedida6311,string calificadorUnidadMedida6411,string valorMedida6314)
        {
            var mea = new MEA(calificadorAplicacionMedida6311,null,
                              new ValorAmplitud(calificadorUnidadMedida6411,valorMedida6314,null,null),
                              null );

            Segmentos.Add(mea);
            Mensaje += mea.getSegmento();
        }

        protected void MontarTdt(string modoTransporteCodificado8067)
        {
            var tdt = new TDT(_calificadorRutaTransporte_8051,null,
                              new ModoTransporte(modoTransporteCodificado8067,null),
                              null, null, null, null, null);
                             

            Segmentos.Add(tdt);
            Mensaje += tdt.getSegmento();
        }


        protected void MontarMoa(string calificadorTipoImporte5025,string importeMonetario5004 )
        {
            var moa = new MOA(new ImporteMonetario(calificadorTipoImporte5025, importeMonetario5004, _monedaCodificada, null, null));

            Segmentos.Add(moa);
            Mensaje += moa.getSegmento();
        }


        protected void MontarTod(string plazoEntregaCodificado4053)
        {
            var tod = new TOD(null,null,
                              new PlazoEntrega(plazoEntregaCodificado4053,null,null,null,null));

            Segmentos.Add(tod);
            Mensaje += tod.getSegmento();
        }


        protected void MontarCnt(string calificadorControl6069,string valorControl6066)
        {
            var cnt = new CNT(new ControlDeTotales(calificadorControl6069,valorControl6066,null));

            Segmentos.Add(cnt);
            Mensaje += cnt.getSegmento();
        }


        protected void MontarUnt(string numeroSegmentosMensaje0074,string numeroReferenciaMensaje0062)
        {
            var unt = new UNT(numeroSegmentosMensaje0074,numeroReferenciaMensaje0062);

            Segmentos.Add(unt);
            Mensaje += unt.getSegmento();
        }

    }
}
