using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Segments.AuxClass;

namespace EDI_Generator.Segments
{
    //TODO Comprobar cuando se usa el número de la mercancía.
    internal class CST : SegmentoEDI
    {
        //1496 NÚMERO ARTICULO DE LA MERCANCÍA
        private readonly string _numeroDePartida_1496;

        //C246 CÓDIGOS DE IDENTIFICACIÓN ADUANERA
        private readonly CodigoIdentificacionAduanera _codigoIdentificacionAduanera;

        private readonly CodigoIdentificacionAduanera _codigoIdentificacionAduanera2;
        private readonly CodigoIdentificacionAduanera _codigoIdentificacionAduanera3;
        private readonly CodigoIdentificacionAduanera _codigoIdentificacionAduanera4;
        private readonly CodigoIdentificacionAduanera _codigoIdentificacionAduanera5;


        /// <summary>
        /// Constructor que monta un Codificación aduanera.
        /// </summary>
        /// <param name="numeroDePartida1496"></param>
        /// <param name="codigoIdentificacionAduanera"></param>
        public CST(string numeroDePartida1496 ,CodigoIdentificacionAduanera codigoIdentificacionAduanera)
            : base("CST")
        {
            _numeroDePartida_1496 = numeroDePartida1496;
            _codigoIdentificacionAduanera = codigoIdentificacionAduanera;

            Segmento = montaSegmento();
        }


        /// <summary>
        /// Constructor que monta hasta un máximo de 5 Codificaciones aduaneras
        /// </summary>
        /// <param name="listCodigoIdentificacionAduaneras"></param>
        public CST(string numeroDePartida1496,CodigoIdentificacionAduanera codigoIdentificacionAduanera, CodigoIdentificacionAduanera codigoIdentificacionAduanera2,
                   CodigoIdentificacionAduanera codigoIdentificacionAduanera3, CodigoIdentificacionAduanera codigoIdentificacionAduanera4,
                   CodigoIdentificacionAduanera codigoIdentificacionAduanera5) 
            : base("CST")
        {
            _numeroDePartida_1496 = numeroDePartida1496;
            _codigoIdentificacionAduanera = codigoIdentificacionAduanera;
            _codigoIdentificacionAduanera2 = codigoIdentificacionAduanera2;
            _codigoIdentificacionAduanera3 = codigoIdentificacionAduanera3;
            _codigoIdentificacionAduanera4 = codigoIdentificacionAduanera4;
            _codigoIdentificacionAduanera5 = codigoIdentificacionAduanera5;

            Segmento = montaSegmento();
        }


        protected sealed override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += _1496_NumeroArticuloMercancia();
            cadena += C246_CodificacionAduanera(_codigoIdentificacionAduanera);
            cadena += C246_CodificacionAduanera(_codigoIdentificacionAduanera2);
            cadena += C246_CodificacionAduanera(_codigoIdentificacionAduanera3);
            cadena += C246_CodificacionAduanera(_codigoIdentificacionAduanera4);
            cadena += C246_CodificacionAduanera(_codigoIdentificacionAduanera5);
            cadena += cerrarSegmento();

            return cadena;
        }


        private string C246_CodificacionAduanera(CodigoIdentificacionAduanera codigoIdentificacion)
        {
            var cadena = "";

            if (codigoIdentificacion != null)
            {
                if (!string.IsNullOrEmpty(codigoIdentificacion.codigoIdentificacionAduanera))
                    cadena = codigoIdentificacion.codigoIdentificacionAduanera;

                if (!string.IsNullOrEmpty(codigoIdentificacion.calificadorListaCodigos))
                    cadena += ":" + codigoIdentificacion.calificadorListaCodigos;

                if (!string.IsNullOrEmpty(codigoIdentificacion.agenciaResponsableListaCodigos))
                    cadena += ":" + codigoIdentificacion.agenciaResponsableListaCodigos;
            }

            return "+" + cadena;
        }



        private string _1496_NumeroArticuloMercancia()
        {
            var cadena = "";
            if (!string.IsNullOrEmpty(_numeroDePartida_1496)) cadena = _numeroDePartida_1496;

            return "+" + cadena;
        }
       


        public override string getSegmento()
        {
            return Segmento;
        }

        protected override string cerrarSegmento()
        {
            return _cierreSegmento;
        }
    }
}
