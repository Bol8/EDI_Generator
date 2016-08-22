using System.Collections.Generic;

namespace EDI_Generator.EDI
{
    public abstract class EDI
    {
        protected string Mensaje { get; set; }
        public List<Segments.SegmentoEDI> Segmentos { get; protected set; }

    }
}
