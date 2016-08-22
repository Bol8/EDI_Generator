using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    internal class IdentificacionLugar
    {
        public string IdentificacionDeLugar { get; private set; }
        public string CalificadorListaCodigos { get; private set; }
        public string AgenciaResponsableListaCodigosCodificada { get; private set; }
        public string Lugar { get; private set; }


        public IdentificacionLugar(string identificacionDeLugar,string calificadorListaCodigos,
                                   string agenciaResponsbleListaCodigos,string lugar)
        {
            IdentificacionDeLugar = identificacionDeLugar;
            CalificadorListaCodigos = calificadorListaCodigos;
            AgenciaResponsableListaCodigosCodificada = agenciaResponsbleListaCodigos;
            Lugar = lugar;
        }

    }
}
