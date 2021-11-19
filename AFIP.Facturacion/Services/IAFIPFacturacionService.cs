using AFIP.Facturacion.Model;
using AFIP.Facturacion.Model.Factura;
using AfipServiceReference;
using System.Threading.Tasks;

namespace AFIP.Facturacion.Services
{
    public interface IAFIPFacturacionService
    {
        Task<FacturacionResponse> FacturarAsync(FacturaAFIP factura);
        Task<FERecuperaLastCbteResponse> GetUltimoComprobanteAutorizadoAsync(int ptoVenta, TipoComprobante tipoComprobante);
    }
}
