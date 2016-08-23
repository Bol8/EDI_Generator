using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.POCO;
using EDI_Generator.Segments.AuxClass;
using EDI_Generator.EDI.Intrastat;

namespace EDI_Generator.Gestion
{
    public class CusdecIntrastatConOperaciones:CusdecIntrastat
    {
        private readonly Declaracion _declaracion;

        public CusdecIntrastatConOperaciones(Declaracion declaracion)
        {
            _declaracion = declaracion;
            MontarMensaje();
        }


        private void MontarMensaje()
        {
            MontarUnb(_declaracion.NifEmisor, _declaracion.ReferenciaControlIntercambio, true);
            MontarUnh(_declaracion.NumeroReferenciaMensaje);
            MontarBgm(CrearNumeroDocumento(), null);
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
            Cst_EspecificarPartidas();
            Uns_CerrarDetalleMensaje();
            Cnt_EspecificarTotalPartidas();
            Cnt_EspecificarPesoTotalMercancias();
            Cnt_EspecificarTotalUnidadesSuplementarias();
            Cnt_EspecificarValorTotalFactura();
            Cnt_EspecificarValorTotalEstadistico();
            MontarUnt(Segmentos.Count.ToString(), _declaracion.NumeroReferenciaMensaje);
            MontarUnz(_declaracion.ReferenciaControlIntercambio);
        }

        private void Cst_EspecificarPartidas()
        {
            if (_declaracion.Partidas.Any())
            {
                foreach (var partida in _declaracion.Partidas)
                {
                      MontarCstPartidas(partida.IdPartida,partida.Mercancia,"112","1","10");  
                }
            }
        }


        private string CrearNumeroDocumento()
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
            MontarCst(null, flujo, "176");
        }


        private void Dtm_PeriodoFechaHora(string año, string mes)
        {
            var periodo = año + "" + mes;
            MontarDtm("320", periodo);
        }

        private void Dtm_PeriodoFechaHora(string periodo)
        {
            MontarDtm("320", periodo);
        }

        private void Dtm_AltaDocumento(DateTime fechaHoraActual)
        {
            MontarDtm("137", fechaHoraActual.ToString("yyMMdd"));
        }

        private void Gis_DeclaracionSinOperacion()
        {
            MontarGis("NIL", "42");
        }

        private void Gis_TipoOperacion()
        {
            MontarGis("D", "105");
        }

        private void Nad_DatosObligadoEstadistico(string nifEmisor, string nombreEntidad)
        {
            MontarNad("DT", nifEmisor, nombreEntidad);
        }

        private void Nad_DatosReceptor()
        {
            MontarNad("DO", "DA", null);
        }

        private void Moa_EspecificarMoneda()
        {
            MontarMoa("ZZZ", null);
        }

        private void Moa_EspecificarImporteTotal()
        {
            MontarMoa("39", "0");
        }

        private void Uns_CerrarCabeceraMensaje()
        {
            MontarUns("D");
        }

        private void Uns_CerrarDetalleMensaje()
        {
            MontarUns("S");
        }

        private void Cnt_EspecificarTotalPartidas()
        {
            MontarCnt("2", "0");
        }

        private void Cnt_EspecificarPesoTotalMercancias()
        {
            MontarCnt("18", "0");
        }

        private void Cnt_EspecificarTotalUnidadesSuplementarias()
        {
            MontarCnt("19", "0");
        }

        private void Cnt_EspecificarValorTotalFactura()
        {
            MontarCnt("20", "0");
        }

        private void Cnt_EspecificarValorTotalEstadistico()
        {
            MontarCnt("21", "0");
        }

    }
}
