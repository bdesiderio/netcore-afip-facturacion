using System;
using System.Collections.Generic;
using System.Text;

namespace AFIP.Facturacion.Model.Factura
{
    /// <summary>
    /// Información de la cabecera del comprobante o lote de comprobantes de ingreso
    /// </summary>
    public class CabeceraFacturaAFIP
    {
        /// <summary>
        /// Cantidad de registros del detalle del comprobante o lote de comprobantes de ingreso (cantidad de detalles que se informan)
        /// </summary>
        public int CantidadRegistros { get; set; }

        /// <summary>
        /// Tipo de comprobante que se está informando.Si se informa más de un comprobante, todos deben ser del mismo tipo.
        /// </summary>
        public TipoComprobante TipoComprobante { get; set; }

        /// <summary>
        /// Punto de Venta del comprobante que se está informando.Si se informa más de un comprobante, todos deben corresponder al mismo punto de venta.
        /// </summary>
        public int PuntoVenta { get; set; }
    }
}
