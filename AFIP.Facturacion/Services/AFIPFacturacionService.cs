using AFIP.Facturacion.Extensions;
using AFIP.Facturacion.Model;
using AFIP.Facturacion.Model.Factura;
using AfipServiceReference;
using System.Threading.Tasks;

namespace AFIP.Facturacion.Services
{
    public class AFIPFacturacionService : IAFIPFacturacionService
    {
        private readonly WsfeClient _wsfeClient;

        public AFIPFacturacionService(WsfeClient wsfeClient)
        {
            _wsfeClient = wsfeClient;
        }

        public async Task<FacturacionResponse> FacturarAsync(FacturaAFIP factura)
        {
            var comprobante = await _wsfeClient.FECAESolicitarAsync(factura.ToFECAERequest());

            comprobante.Body.FECAESolicitarResult.Errors.EnsureSucceededResponse();

            return new FacturacionResponse
            {
                FECAECabResponse = comprobante.Body.FECAESolicitarResult.FeCabResp,
                FECAEDetResponse = comprobante.Body.FECAESolicitarResult.FeDetResp,
            };
        }

        public async Task<FERecuperaLastCbteResponse> GetUltimoComprobanteAutorizadoAsync(int ptoVenta, TipoComprobante tipoComprobante)
        {
            var result = await _wsfeClient.FECompUltimoAutorizadoAsync(ptoVenta, tipoComprobante.Id);
            result.Body.FECompUltimoAutorizadoResult.Errors.EnsureSucceededResponse();

            return result.Body.FECompUltimoAutorizadoResult;
        }
    }


}
