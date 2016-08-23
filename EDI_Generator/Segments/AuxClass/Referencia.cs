using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
   public class Referencia
    {
       public string CalificadorReferencia_1153 { get; private set; }
       public string NumeroReferencia_1154 { get; private set; }
       public string NumeroLinea_1156 { get; private set; }
       public string NumeroVersionDeLaReferencia_4000 { get; private set; }

       public Referencia(string calificadorReferencia1153, string numeroReferencia1154, 
                        string numeroLinea1156, string numeroVersionDeLaReferencia4000)
       {
           CalificadorReferencia_1153 = calificadorReferencia1153;
           NumeroReferencia_1154 = numeroReferencia1154;
           NumeroLinea_1156 = numeroLinea1156;
           NumeroVersionDeLaReferencia_4000 = numeroVersionDeLaReferencia4000;
       }
    }
}
