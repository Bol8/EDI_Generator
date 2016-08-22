using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    class ModoTransporte
    {
       
        public string ModoTransporteCodificado { get; private set; }
        public string ModoDeTransporte { get; private set; }

        public ModoTransporte(string modoTransporteCodificado, string modoDeTransporte)
        {
            ModoTransporteCodificado = modoTransporteCodificado;
            ModoDeTransporte = modoDeTransporte;
        }

    }
}
