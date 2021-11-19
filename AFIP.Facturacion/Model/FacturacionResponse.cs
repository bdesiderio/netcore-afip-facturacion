using AfipServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFIP.Facturacion.Model
{
    public class FacturacionResponse
    {
        public FECAECabResponse FECAECabResponse { get; set; }
        public List<FECAEDetResponse> FECAEDetResponse { get; set; }
    }
}
