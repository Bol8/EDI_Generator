using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.EDI.Intrastat;
using EDI_Generator.POCO;

namespace EDI_Generator.Gestion
{
    public class EdiCusdecIntrastat:EDI.Intrastat.CusdecIntrastat
    {
        private readonly Declaracion _declaracion;

        public EdiCusdecIntrastat(Declaracion declaracion)
        {
            _declaracion = declaracion;
            montarMensaje();
        }


        private void montarMensaje()
        {
            MontarUnb(_declaracion.NifEmisor,_declaracion.ReferenciaControlIntercambio,true);
            MontarUnh(_declaracion.NumeroReferenciaMensaje);

            //Mandamos null porque es una declaración nueva
            MontarBgm(_declaracion.NumeroDocumento,null);
            MontarCst(null,"A","176");
            MontarDtm("320",_declaracion.FechaHoraPeriodo);
            MontarDtm("137",DateTime.Now.ToString("yyMMdd"));
            MontarGis("NIL","42");
            MontarNad("DT",_declaracion.NifEmisor,_declaracion.NombreEntidad);
            MontarMoa("ZZZ",null);
            MontarMoa("39","0");
            MontarUns("D");
            MontarUns("S");
            MontarCnt("2","0");
            MontarCnt("18","0");
            MontarCnt("19","0");
            MontarCnt("20","0");
            MontarCnt("21","0");
            MontarUnt(Segmentos.Count.ToString(),_declaracion.NumeroReferenciaMensaje);
            MontarUnz(_declaracion.ReferenciaControlIntercambio);
        }



    }
}
