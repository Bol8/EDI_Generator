using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class ImporteMonetario
    {
        
        public string CalificadorTipoImporte_5025 { get; private set; }
        public string ImporteMonetario_5004 { get; private set; }
        public string MonedaCodificada_6345 { get; private set; }
        public string CalificadorMoneda_6343 { get; private set; }
        public string StatusCodificado_4405 { get; private set; }

        public ImporteMonetario(string calificadorTipoImporte5025, string importeMonetario5004, 
                                string monedaCodificada6345, string calificadorMoneda6343,
                                string statusCodificado4405)
        {
            CalificadorTipoImporte_5025 = calificadorTipoImporte5025;
            ImporteMonetario_5004 = importeMonetario5004;
            MonedaCodificada_6345 = monedaCodificada6345;
            CalificadorMoneda_6343 = calificadorMoneda6343;
            StatusCodificado_4405 = statusCodificado4405;
        }

    }
}
