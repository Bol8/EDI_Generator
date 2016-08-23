using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.POCO
{
    public class Declaracion
    {
        public string NifEmisor { get; set; }
        public string ReferenciaControlIntercambio { get; set; }
        public string NumeroReferenciaMensaje { get; set; }
        public string NumeroDocumento { get; set; }
        public string FechaHoraPeriodo { get; set; }
        public string NombreEntidad { get; set; }
        public string ImporteMonetario { get; set; }
        public string Flujo { get; set; }
        public string NumeroDeclaracion { get; set; }
        public List<Partida> Partidas { get; set; }


      //  public string ValorControl { get; set; }
       // public string NumeroDeRe { get; set; }

    }
}
