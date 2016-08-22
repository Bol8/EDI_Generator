using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class CodigoIdentificacionAduanera
    {
        public string codigoIdentificacionAduanera { get; private set; }
        public string calificadorListaCodigos { get; private set; }
        public string agenciaResponsableListaCodigos { get; private set; }



        public CodigoIdentificacionAduanera(string codigoIdentificacionAduanera,string calificadorListaCodigos,
                                             string agenciaResponsableListaCodigos )
        {
            this.codigoIdentificacionAduanera = codigoIdentificacionAduanera;
            this.calificadorListaCodigos = calificadorListaCodigos;
            this.agenciaResponsableListaCodigos = agenciaResponsableListaCodigos;
        }
    }
}
