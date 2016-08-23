using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI_Generator.Segments.AuxClass;

namespace EDI_Generator.Segments
{
    internal class TOD:SegmentoEDI
    {
        private readonly string _codigoFuncionPlazoEntrega_4055;
        private readonly string _metodoPagoCargosTrasnporte_4215;

        //C100 PLAZOS ENTREGA
        private readonly PlazoEntrega _plazoEntrega_C100;


        public TOD(string codigoFuncionPlazoEntrega4055, string metodoPagoCargosTrasnporte4215,
                   PlazoEntrega plazoEntregaC100) 
            : base("TOD")
        {
            _codigoFuncionPlazoEntrega_4055 = codigoFuncionPlazoEntrega4055;
            _metodoPagoCargosTrasnporte_4215 = metodoPagoCargosTrasnporte4215;
            _plazoEntrega_C100 = plazoEntregaC100;

            Segmento = montaSegmento();
        }

        public override string getSegmento()
        {
           return Segmento;
        }

        protected sealed override string montaSegmento()
        {
            var cadena = _idSEgmento;
            cadena += _4055_CodigoFuncionPlazoEntrega();
            cadena += _4215_MetodoPagoCargosTransporte();
            cadena += C100_PlazoEntrega();
            cadena += cerrarSegmento();

            return cadena;
        }

        private string _4055_CodigoFuncionPlazoEntrega()
        {
            return "+" + _codigoFuncionPlazoEntrega_4055;
        }

        private string _4215_MetodoPagoCargosTransporte()
        {
            return "+" + _metodoPagoCargosTrasnporte_4215;
        }

        private string C100_PlazoEntrega()
        {
            var cadena = "";

            if (_plazoEntrega_C100 != null)
            {
                cadena = unirElementos(":", _plazoEntrega_C100.PlazoEntregaCodificado_4053,
                                            _plazoEntrega_C100.IdListaCodigosCodificado_1131,
                                            _plazoEntrega_C100.AgenciaResponsableListaCodigos_3055,
                                            _plazoEntrega_C100.PlazoEntrega1_4052,
                                            _plazoEntrega_C100.PlazoEntrega2_4052);
            }

            return "+" + cadena;
        }

        protected override string cerrarSegmento()
        {
            return _cierreSegmento;
        }
    }
}
