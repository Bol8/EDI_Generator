using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Segments.AuxClass
{
    public class InformacionMedidas
    {
        public string DimensionMedidaCodificada_6313 { get; private set; }
        public string SignificadoMedidasCodificada_6321 { get; private set; }
        public string AtributoMedidasCodificada_6155 { get; private set; }


        public InformacionMedidas(string dimensionMedidasCodificada6313,string significadoMedidasCodificada6321,
                                  string atributosMediasCodificada6155)
        {
            DimensionMedidaCodificada_6313 = dimensionMedidasCodificada6313;
            SignificadoMedidasCodificada_6321 = significadoMedidasCodificada6321;
            AtributoMedidasCodificada_6155 = atributosMediasCodificada6155;
        }

    }
}
