using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.EDI.Intrastat;
using EDI_Generator.POCO;

namespace EDI_Generator.Gestion
{
    public class CusdecIntrastatSinOperaciones : EdiIntrastat
    {
        private readonly Declaracion _declaracion;

        public CusdecIntrastatSinOperaciones(Declaracion declaracion)
        {
            _declaracion = declaracion;
            montarMensaje();
        }


        private void montarMensaje()
        {
            montarUnb(_declaracion.NifEmisor, _declaracion.ReferenciaControlIntercambio, true);
            montarUnh(_declaracion.NumeroReferenciaMensaje);
            montarBgm(crearNumeroDocumento(), null);
            Cst_EspecificarFlujo(_declaracion.Flujo);
            Dtm_PeriodoFechaHora(_declaracion.FechaHoraPeriodo);
            Dtm_AltaDocumento(DateTime.Now);
            Gis_DeclaracionSinOperacion();
            Gis_TipoOperacion();
            Nad_DatosObligadoEstadistico(_declaracion.NifEmisor, _declaracion.NombreEntidad);
            Nad_DatosReceptor();
            Moa_EspecificarMoneda();
            Moa_EspecificarImporteTotal();
            Uns_CerrarCabeceraMensaje();
            Uns_CerrarDetalleMensaje();
            Cnt_EspecificarTotalPartidas();
            Cnt_EspecificarPesoTotalMercancias();
            Cnt_EspecificarTotalUnidadesSuplementarias();
            Cnt_EspecificarValorTotalFactura();
            Cnt_EspecificarValorTotalEstadistico();
            montarUnt(Segmentos.Count.ToString(), _declaracion.NumeroReferenciaMensaje);
            montarUnz(_declaracion.ReferenciaControlIntercambio);
        }


        /// <summary>
        /// Método para generar el Número de documento.
        /// Nif + FechaPeriodo + Flujo + Número declaración.
        /// </summary>
        /// <returns></returns>
        private string crearNumeroDocumento()
        {
            var sb = new StringBuilder();

            sb.Append(_declaracion.NifEmisor);
            sb.Append(_declaracion.FechaHoraPeriodo);
            sb.Append(_declaracion.Flujo);
            sb.Append(_declaracion.NumeroDeclaracion);

            return sb.ToString();
        }


        private void Cst_EspecificarFlujo(string flujo)
        {
            montarCst(null, flujo, "176");
        }


        private void Dtm_PeriodoFechaHora(string año, string mes)
        {
            var periodo = año + "" + mes;
            montarDtm("320", periodo);
        }

        private void Dtm_PeriodoFechaHora(string periodo)
        {
            montarDtm("320", periodo);
        }

        private void Dtm_AltaDocumento(DateTime fechaHoraActual)
        {
            montarDtm("137", fechaHoraActual.ToString("yyMMdd"));
        }

        private void Gis_DeclaracionSinOperacion()
        {
            montarGis("NIL", "42");
        }

        private void Gis_TipoOperacion()
        {
            montarGis("D", "105");
        }

        private void Nad_DatosObligadoEstadistico(string nifEmisor, string nombreEntidad)
        {
            montarNad("DT", nifEmisor, nombreEntidad);
        }

        private void Nad_DatosReceptor()
        {
            montarNad("DO", "DA", null);
        }

        private void Moa_EspecificarMoneda()
        {
            montarMoa("ZZZ", null);
        }

        private void Moa_EspecificarImporteTotal()
        {
            montarMoa("39", "0");
        }

        private void Uns_CerrarCabeceraMensaje()
        {
            montarUns("D");
        }

        private void Uns_CerrarDetalleMensaje()
        {
            montarUns("S");
        }

        private void Cnt_EspecificarTotalPartidas()
        {
            montarCnt("2", "0");
        }

        private void Cnt_EspecificarPesoTotalMercancias()
        {
            montarCnt("18", "0");
        }

        private void Cnt_EspecificarTotalUnidadesSuplementarias()
        {
            montarCnt("19", "0");
        }

        private void Cnt_EspecificarValorTotalFactura()
        {
            montarCnt("20", "0");
        }

        private void Cnt_EspecificarValorTotalEstadistico()
        {
            montarCnt("21", "0");
        }

    }
}
