using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.EDI.Intrastat;
using EDI_Generator.POCO;

namespace EDI_Generator.Gestion
{
    public class CusdescIntrastat:EdiIntrastat
    {
        private readonly Declaracion _declaracion;

        public CusdescIntrastat(Declaracion declaracion)
        {
            _declaracion = declaracion;
            montarMensaje();
        }


        private void montarMensaje()
        {
            montarUnb(_declaracion.NifEmisor,_declaracion.ReferenciaControlIntercambio,true);
            montarUnh(_declaracion.NumeroReferenciaMensaje);

            //Mandamos null porque es una declaración nueva
            montarBgm(_declaracion.NumeroDocumento,null);
            montarCst(null,"A","176");
            montarDtm("320",_declaracion.FechaHoraPeriodo);
            montarDtm("137",DateTime.Now.ToString("yyMMdd"));
            montarGis("NIL","42");
            montarNad("DT",_declaracion.NifEmisor,_declaracion.NombreEntidad);
            montarMoa("ZZZ",null);
            montarMoa("39","0");
            montarUns("D");
            montarUns("S");
            montarCnt("2","0");
            montarCnt("18","0");
            montarCnt("19","0");
            montarCnt("20","0");
            montarCnt("21","0");
            montarUnt(Segmentos.Count.ToString(),_declaracion.NumeroReferenciaMensaje);
            montarUnz(_declaracion.ReferenciaControlIntercambio);
        }



    }
}
