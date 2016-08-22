using System.Collections.Generic;

namespace EDI_Generator.EDI
{
    public abstract class EDI
    {
        public string Mensaje { get; protected set; }
        public List<Segments.SegmentoEDI> Segmentos { get; protected set; }

    }
}
