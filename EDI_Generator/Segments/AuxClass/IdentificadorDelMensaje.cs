using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class IdentificadorDelMensaje
    {
        public string IdentificadorTipoMensaje_0065 { get; private set; }
        public string NumeroVersionTipoMensaje_0052 { get; private set; }
        public string NumeroPublicacionTipoMensaje_0054 { get; private set; }
        public string AgenciaControladora_0051 { get; private set; }
        public string CodigoAsignadoDeAsociacion_0057 { get; private set; }

        public IdentificadorDelMensaje(string identificadorTipoMensaje0065, string numeroVersionTipoMensaje0052,
                                       string numeroPublicacionTipoMensaje0054, string agenciaControladora0051, 
                                       string codigoAsignadoDeAsociacion0057)
        {
            IdentificadorTipoMensaje_0065 = identificadorTipoMensaje0065;
            NumeroVersionTipoMensaje_0052 = numeroVersionTipoMensaje0052;
            NumeroPublicacionTipoMensaje_0054 = numeroPublicacionTipoMensaje0054;
            AgenciaControladora_0051 = agenciaControladora0051;
            CodigoAsignadoDeAsociacion_0057 = codigoAsignadoDeAsociacion0057;
        }

    }
}
