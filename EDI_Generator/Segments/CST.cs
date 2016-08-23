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
        private readonly CodigoIdentificacionAduanera _codigoIdentificacionAduanera_C246;

        private readonly CodigoIdentificacionAduanera _codigoIdentificacionAduanera2;
        private readonly CodigoIdentificacionAduanera _codigoIdentificacionAduanera3;
        private readonly CodigoIdentificacionAduanera _codigoIdentificacionAduanera4;
        private readonly CodigoIdentificacionAduanera _codigoIdentificacionAduanera5;


        /// <summary>
        /// Constructor que monta el segmento CST.
        /// </summary>
        /// <param name="numeroDePartida1496"></param>
        /// <param name="codigoIdentificacionAduaneraC246"></param>
        public CST(string numeroDePartida1496 ,CodigoIdentificacionAduanera codigoIdentificacionAduaneraC246)
            : base("CST")
        {
            _numeroDePartida_1496 = numeroDePartida1496;
            _codigoIdentificacionAduanera_C246 = codigoIdentificacionAduaneraC246;

            Segmento = montaSegmento();
        }


        /// <summary>
        /// Constructor que monta el segmento CST con un máximo de 5 Codificaciones aduaneras
        /// </summary>
        public CST(string numeroDePartida1496,CodigoIdentificacionAduanera codigoIdentificacionAduaneraC246, CodigoIdentificacionAduanera codigoIdentificacionAduanera2,
                   CodigoIdentificacionAduanera codigoIdentificacionAduanera3, CodigoIdentificacionAduanera codigoIdentificacionAduanera4,
                   CodigoIdentificacionAduanera codigoIdentificacionAduanera5) 
            : base("CST")
        {
            _numeroDePartida_1496 = numeroDePartida1496;
            _codigoIdentificacionAduanera_C246 = codigoIdentificacionAduaneraC246;
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
            cadena += C246_CodificacionAduanera(_codigoIdentificacionAduanera_C246);
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
                cadena = unirElementos(":", codigoIdentificacion.codigoIdentificacionAduanera_7361,
                                            codigoIdentificacion.calificadorListaCodigos_1131,
                                            codigoIdentificacion.agenciaResponsableListaCodigosCodificada_3055);
            }

            return "+" + cadena;
        }



        private string _1496_NumeroArticuloMercancia()
        {
            return "+" + _numeroDePartida_1496;
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
