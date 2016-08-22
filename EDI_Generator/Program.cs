using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Segments;
using EDI_Generator.Segments.AuxClass;
using EDI_Generator.EDI.Intrastat;
using EDI_Generator.Gestion;
using EDI_Generator.POCO;
using EDI_Generator.Manage;

namespace EDI_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var declaration = new Declaracion()
            {
                NifEmisor = "A98989898",
                ReferenciaControlIntercambio = "00294",
                NumeroReferenciaMensaje = "REF789012",
                NumeroDocumento = "A989898980205A10000022",
                FechaHoraPeriodo = "2005",
                NombreEntidad = "@¿¿''''INTRO+++DUCT,,,,ORES MERC@ANC:::ÍAS?? S.A"
            };

            CleanerSpecialSigns.Cleaner(declaration.NombreEntidad);


            var EdiIntrastat = new CusdescIntrastat(declaration);

            foreach (var segmento in EdiIntrastat.Segmentos.ToList())
            {
                Console.WriteLine(segmento.getSegmento());
            }



            //var INTRASTAT_CUSDEC = new INTRASTAT_CUSDESC();



            //var _UNB = new UNB("UNOA", "1", "ZZ", "AEATADUE", "A98989898","00294",true);
            //var _UNH = new UNH("REF789012", "CUSDEC", "1", "921", "UN", "INT003",null,null,null);
            //var _BGM = new BGM("896",null,null,null,"REF989898987","5",null);
            //var _CST = new CST(null,new CodigoIdentificacionAduanera("A","176",null));
            //var _DTM = new DTM("320", DateTime.Now.ToString("yyMM"),null);
            //var _DTM2 = new DTM("137", DateTime.Now.ToString("yyMMdd"), null);
            //var _GIS = new GIS("NIL","42",null,null);
            //var _GIS2 = new GIS(null, "105", null, null);
            //var _RFF = new RFF("ACW", "A98989898",null,null);
            //var _NAD = new NAD_Intrastat("DT","A98989898","INTRODUCTORES DE MERCANCÍAS S.A");
            //var _MOA1 = new MOA("ZZZ",null,"EUR",null,null);
            //var _MOA2 = new MOA("39","21434,42","EUR",null,null);
            //var _UNS1 = new UNS("D");
            //var _CST2 = new CST("1",new CodigoIdentificacionAduanera("0101000010","122",null),
            //                        null,
            //                        new CodigoIdentificacionAduanera("11", "112", null),
            //                        new CodigoIdentificacionAduanera("1", "117", null),
            //                        null);

            //var _LOC = new LOC("35",new IdentificacionLugar("FR",null,null,null),null );
            //var _MEA = new MEA("WT",new InformacionMedidas(null,null,null),new ValorAmplitud("KGM","1295",null,null),null);
            //var _TDT = new TDT("2",null,new ModoTransporte("2",null),null,null,null,null,null);
            //var _TOD = new TOD(null,null,new PlazoEntrega("FOB",null,null,null,null));
            //var _CNT = new CNT(new ControlDeTotales("2","1",null));
            //var _CNT2 = new CNT(new ControlDeTotales("2", "1", null));
            //var _CNT3 = new CNT(new ControlDeTotales("18", "1586", null));
            //var _CNT4 = new CNT(new ControlDeTotales("19", "1658", null));
            //var _CNT5 = new CNT(new ControlDeTotales("20", "39658,29", null));
            //var _UNS2 = new UNS("S");
            //var _UNT = new UNT("10", "REF789012");
            //var _UNZ = new UNZ("00294", "1");

 

            //var segmentoUNB = _UNB.getSegmento();
            //var segmentoUNH = _UNH.getSegmento();
            //var segmentoBGM = _BGM.getSegmento();
            //var segmentoCST = _CST.getSegmento();
            //var segmentoDTM = _DTM.getSegmento();
            //var segmentoDTM2 = _DTM2.getSegmento();
            //var segmentoGIS = _GIS.getSegmento();
            //var segmentoGIS2 = _GIS2.getSegmento();
            //var segementoRFF = _RFF.getSegmento();
            //var segmentoNAD = _NAD.getSegmento();
            //var segmentoMOA1 = _MOA1.getSegmento();
            //var segmentoMOA2 = _MOA2.getSegmento();
            //var segmentoUNS = _UNS1.getSegmento();
            //var segmentoCST2 = _CST2.getSegmento();
            //var segmentoLOC = _LOC.getSegmento();
            //var segmentoMEA = _MEA.getSegmento();
            //var segmentoTDT = _TDT.getSegmento();
            //var segmentoTOD = _TOD.getSegmento();
            //var segmentoCNT = _CNT.getSegmento();
            //var segmentoCNT2 = _CNT2.getSegmento();
            //var segmentoCNT3 = _CNT3.getSegmento();
            //var segmentoCNT4 = _CNT4.getSegmento();
            //var segmentoCNT5 = _CNT5.getSegmento();
            //var segmentoUNS2 = _UNS2.getSegmento();
            //var segmentoUNT = _UNT.getSegmento();
            //var segmentoUNZ = _UNZ.getSegmento();



            //var cadena = segmentoUNB +"\n";
            //cadena += segmentoUNH + "\n";
            //cadena += segmentoBGM + "\n";
            //cadena += segmentoCST + "\n";
            //cadena += segmentoDTM + "\n";
            //cadena += segmentoDTM2 + "\n";
            //cadena += segmentoGIS + "\n";
            //cadena += segmentoGIS2 + "\n";
            //cadena += segementoRFF + "\n";
            //cadena += segmentoNAD + "\n";
            //cadena += segmentoMOA1 + "\n";
            //cadena += segmentoMOA2 + "\n";
            //cadena += segmentoUNS + "\n";
            //cadena += segmentoCST2 + "\n";
            //cadena += segmentoLOC + "\n";
            //cadena += segmentoMEA + "\n";
            //cadena += segmentoTDT + "\n";
            //cadena += segmentoTOD + "\n";
            //cadena += segmentoCNT + "\n";
            //cadena += segmentoCNT2 + "\n";
            //cadena += segmentoCNT3 + "\n";
            //cadena += segmentoCNT4 + "\n";
            //cadena += segmentoCNT5 + "\n";
            //cadena += segmentoUNS2 + "\n";
            //cadena += segmentoUNT + "\n";
            //cadena += segmentoUNZ;



            //var cadena2 = segmentoUNB;
            //cadena2 += segmentoUNH;
            //cadena2 += segmentoBGM;
            //cadena2 += segmentoCST;
            //cadena2 += segmentoDTM;
            //cadena2 += segmentoDTM2;
            //cadena2 += segmentoGIS;
            //cadena2 += segmentoGIS2;
            //cadena2 += segementoRFF;
            //cadena2 += segmentoNAD;
            //cadena2 += segmentoUNT;
            //cadena2 += segmentoUNZ;


            Console.ReadLine();
        }
    }
}
