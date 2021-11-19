using AFIP.Facturacion.Exceptions;
using AfipServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFIP.Facturacion.Extensions
{
    internal static class ErrExtensions
    {
        public static void EnsureSucceededResponse(this List<Err> err)
        {
            if (err != null && err.Count > 0)
            {
                throw new AFIPFacturacionException(err);
            }
        }
    }
}
