using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class InformacionMedidas
    {
        public string DimensionMedidaCodificada { get; private set; }
        public string SignificadoMedidasCodificada { get; private set; }
        public string AtributoMedidasCodificada { get; private set; }


        public InformacionMedidas(string dimensionMedidasCodificada,string significadoMedidasCodificada,
                                  string atributosMediasCodificada)
        {
            DimensionMedidaCodificada = dimensionMedidasCodificada;
            SignificadoMedidasCodificada = significadoMedidasCodificada;
            AtributoMedidasCodificada = atributosMediasCodificada;
        }

    }
}
