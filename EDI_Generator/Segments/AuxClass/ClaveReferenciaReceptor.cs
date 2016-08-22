using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class ClaveReferenciaReceptor
    {
        public string ClaveDelReceptor_0022 { get; private set; }
        public string CalificadorClaveReceptor_0025 { get; private set; }

        public ClaveReferenciaReceptor(string claveDelReceptor0022, string calificadorClaveReceptor0025)
        {
            ClaveDelReceptor_0022 = claveDelReceptor0022;
            CalificadorClaveReceptor_0025 = calificadorClaveReceptor0025;
        }
    }
}
