using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class IdentificadorDeSintaxis
    {
        public string IdentificadorDeSintaxis_0001 { get; private set; }
        public string NumeroVersionDeSintaxis_0002 { get; private set; }

        public IdentificadorDeSintaxis(string identificadorDeSintaxis0001, string numeroVersionDeSintaxis0002)
        {
            IdentificadorDeSintaxis_0001 = identificadorDeSintaxis0001;
            NumeroVersionDeSintaxis_0002 = numeroVersionDeSintaxis0002;
        }
    }
}
