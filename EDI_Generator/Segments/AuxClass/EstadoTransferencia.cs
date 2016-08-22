using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class EstadoTransferencia
    {
        public string NumeroTransferenciaSecuenciaMensaje_0070 { get; private set; }
        public string IdicacionSecuenciaMensaje_0073 { get; private set; }

        public EstadoTransferencia(string numeroTransferenciaSecuenciaMensaje0070, string idicacionSecuenciaMensaje0073)
        {
            NumeroTransferenciaSecuenciaMensaje_0070 = numeroTransferenciaSecuenciaMensaje0070;
            IdicacionSecuenciaMensaje_0073 = idicacionSecuenciaMensaje0073;
        }
    }
}
