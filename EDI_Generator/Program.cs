﻿using System;
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
                NombreEntidad = "@¿¿''''INTRO+++DUCT,,,,ORES MERC@ANC:::ÍAS?? S.A",
                Flujo = "A",
                NumeroDeclaracion = "10000022",
                Partidas = new List<Partida>()
                {
                    new Partida() {IdPartida = "1",Mercancia = "00001111",TotalPeso = "60.00",TotalPrecio = "120.00" },
                    new Partida() {IdPartida = "1",Mercancia = "00001111",TotalPeso = "60.00",TotalPrecio = "120.00" },
                    new Partida() {IdPartida = "1",Mercancia = "00001111",TotalPeso = "60.00",TotalPrecio = "120.00" },
                    new Partida() {IdPartida = "1",Mercancia = "00001111",TotalPeso = "60.00",TotalPrecio = "120.00" },
                    new Partida() {IdPartida = "1",Mercancia = "00001111",TotalPeso = "60.00",TotalPrecio = "120.00" }
                }

            };

            CleanerSpecialSigns.Cleaner(declaration.NombreEntidad);


            var EdiIntrastat = new EdiCusdecIntrastat(declaration);
            var CusdecIntrastatSinOperaciones = new CusdecIntrastatConOperaciones(declaration);

            foreach (var segmento in CusdecIntrastatSinOperaciones.Segmentos.ToList())
            {
                Console.WriteLine(segmento.getSegmento());
            }


            Console.ReadLine();
        }
    }
}
