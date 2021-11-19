using System;
using System.Collections.Generic;
using System.Text;

namespace AFIP.Facturacion.Model.Factura
{
    /// <summary>
    /// Información del detalle del comprobante o lote de comprobantes de ingreso
    /// </summary>
    public class DetalleFacturaAFIP
    {
        public Concepto Concepto { get; set; }

        /// <summary>
        /// Código de documento identificatorio del comprador
        /// </summary>
        public TipoDocumento TipoDocumento { get; set; }

        /// <summary>
        /// Nro. De identificación del comprador
        /// </summary>
        public long NroDocumento { get; set; }

        /// <summary>
        /// Nro. De comprobante desde Rango 1-99999999
        /// </summary>
        public long NroComprobanteDesde { get; set; }

        /// <summary>
        /// Nro. De comprobante registrado hasta Rango 1- 99999999
        /// </summary>
        public long NroComprobanteHasta { get; set; }

        /// <summary>
        /// Fecha del comprobante (yyyymmdd). Para concepto igual a 1, la fecha de emisión del comprobante puede ser hasta 5 días anteriores o posteriores respecto de la fecha de generación: La misma no
        /// podrá exceder el mes de presentación.Si se indica Concepto igual a 2 ó 3 puede ser hasta 10 días anteriores o posteriores a la fecha de generación.Si no se envía la fecha del comprobante se asignará la
        /// fecha de proceso. Para comprobantes del tipo MiPyMEs (FCE) del tipo Factura, la fecha de emisión del comprobante debe ser desde 5 días anteriores y hasta 1 día posterior respecto de la fecha de generación. Para
        /// notas de débito y crédito es hasta 5 dias anteriores y tiene que ser posterior o igual a la fecha del comprobante asociado.
        /// </summary>
        public DateTime? FechaComprobante { get; set; }

        //TODO Implementar importe total
        /// <summary>
        /// Importe total del comprobante, Debe ser igual a Importe neto no gravado + Importe exento + Importe neto gravado + todos los campos de IVA al XX% + Importe de tributos
        /// </summary>        
        public double ImporteTotal { get; }

        /// <summary>
        /// Importe neto no gravado. Debe ser menor o igual a Importe total y no puede ser menor a cero. No puede ser mayor al Importe total de la operación ni menor a cero(0). Para comprobantes tipo C debe ser igual
        /// a cero(0). Para comprobantes tipo Bienes Usados – Emisor Monotributista este campo corresponde al importe subtotal.
        /// </summary>
        public double ImporteTotalConc { get; set; }

        /// <summary>
        /// Importe neto gravado. Debe ser menor o igual a Importe total y no puede ser menor a cero.Para comprobantes tipo C este campo corresponde al Importe del SubTotal. Para comprobantes tipo Bienes Usados –
        /// Emisor Monotributista no debe informarse o debe ser igual a cero(0).
        /// </summary>
        public double ImporteNeto { get; set; }

        /// <summary>
        /// Importe exento. Debe ser menor o igual a Importe total y no puede ser menor a cero. Para comprobantes tipo C debe ser igual a cero(0). Para comprobantes tipo Bienes Usados –
        /// Emisor Monotributista no debe informarse o debe ser igual a cero(0).
        /// </summary>
        public double ImporteOpExento { get; set; }

        /// <summary>
        /// Suma de los importes del array de IVA. Para comprobantes tipo C debe ser igual a cero(0). Para comprobantes tipo Bienes Usados – Emisor Monotributista no debe informarse o debe ser igual a cero(0).
        /// </summary>
        public double ImporteIVA { get; set; }

        /// <summary>
        /// Suma de los importes del array de tributos
        /// </summary>
        public double ImporteTributos { get; set; }

        /// <summary>
        /// Fecha de inicio del abono para el servicio a facturar.Dato obligatorio para concepto 2 o 3 (Servicios / Productos y Servicios). Formato yyyymmdd
        /// </summary>
        public DateTime? FechaServicioDesde { get; set; }

        /// <summary>
        /// Fecha de fin del abono para el servicio a facturar.Dato obligatorio para concepto 2 o 3 (Servicios / Productos y Servicios). Formato yyyymmdd.FchServHasta no puede ser menor a FchServDesde
        /// </summary>
        public DateTime? FechaServicioHasta { get; set; }

        /// <summary>
        /// Fecha de vencimiento del pago servicio a facturar.Dato obligatorio para concepto 2 o 3 (Servicios / Productos y Servicios) o Facturas del tipo MiPyMEs
        /// (FCE). Formato yyyymmdd.Debe ser igual o posterior a la fecha del comprobante.
        /// </summary>
        public DateTime? FechaVencimientoPago { get; set; }

        /// <summary>
        /// Código de moneda del comprobante. Consultar método FEParamGetTiposMonedas para valores posibles
        /// </summary>
        public TipoMoneda Moneda { get; set; }

        /// <summary>
        /// Cotización de la moneda informada. Para PES, pesos argentinos la misma debe ser 1
        /// </summary>
        public double CotizacionMoneda { get; set; }

    }
}
