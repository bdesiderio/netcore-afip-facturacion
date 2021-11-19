using AfipServiceReference;
using AFIP.Facturacion.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFIP.Facturacion.Model.Factura
{
    /// <summary>
    /// Información del comprobante o lote de comprobantes de ingreso.Contiene los datos de FeCabReq y FeDetReq
    /// </summary>
    public class FacturaAFIP
    {
        public CabeceraFacturaAFIP Cabecera { get; set; }
        public List<DetalleFacturaAFIP> Detalle { get; set; }

        internal FECAERequest ToFECAERequest()
        => new FECAERequest
        {
            FeCabReq = new FECAECabRequest
            {
                CantReg = Detalle.Count,
                CbteTipo = Cabecera.TipoComprobante.Id,
                PtoVta = Cabecera.PuntoVenta,
            },
            FeDetReq = Detalle.Select(x => new FECAEDetRequest
            {
                Concepto = x.Concepto,
                DocTipo = x.TipoDocumento.Id,
                DocNro = x.NroDocumento,
                CbteDesde = x.NroComprobanteDesde,
                CbteHasta = x.NroComprobanteHasta,
                CbteFch = x.FechaComprobante?.ToAFIPDateString(),
                ImpTotal = x.ImporteTotal,
                ImpTotConc = x.ImporteTotalConc,
                ImpNeto = x.ImporteNeto,
                ImpOpEx = x.ImporteOpExento,
                ImpIVA = x.ImporteIVA,
                ImpTrib = x.ImporteTributos,
                FchServDesde = x.FechaServicioDesde?.ToAFIPDateString(),
                FchServHasta = x.FechaServicioHasta?.ToAFIPDateString(),
                FchVtoPago = x.FechaVencimientoPago?.ToAFIPDateString(),
                MonId = x.Moneda.Id,
                MonCotiz = x.CotizacionMoneda
            }).ToList(),
        };
    }
}
