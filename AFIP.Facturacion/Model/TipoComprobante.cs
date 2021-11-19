using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFIP.Facturacion.Model
{
    public class TipoComprobante
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public static TipoComprobante Factura_A => new TipoComprobante(1, "Factura A");
        public static TipoComprobante NotaDebito_A => new TipoComprobante(2, "Nota de Débito A");
        public static TipoComprobante NotaCredito_A => new TipoComprobante(3, "Nota de Crédito A");
        public static TipoComprobante Factura_B => new TipoComprobante(6, "Factura B");
        public static TipoComprobante NotaDebito_B => new TipoComprobante(7, "Nota de Débito B");
        public static TipoComprobante NotaCredito_B => new TipoComprobante(8, "Nota de Crédito B");
        public static TipoComprobante Recibo_A => new TipoComprobante(4, "Recibos A");
        public static TipoComprobante NotaVentaContado_A => new TipoComprobante(5, "Notas de Venta al contado A");
        public static TipoComprobante Recibo_B => new TipoComprobante(9, "Recibos B");
        public static TipoComprobante NotaVentaContado_B => new TipoComprobante(10, "Notas de Venta al contado B");
        public static TipoComprobante Liquidacion_A => new TipoComprobante(63, "Liquidacion A");
        public static TipoComprobante Liquidacion_B => new TipoComprobante(64, "Liquidacion B");
        public static TipoComprobante CbteAnexoI_A => new TipoComprobante(34, "Cbtes. A del Anexo I, Apartado A,inc.f),R.G.Nro. 1415");
        public static TipoComprobante CbteAnexoI_B => new TipoComprobante(35, "Cbtes. B del Anexo I,Apartado A,inc. f),R.G. Nro. 1415");
        public static TipoComprobante OtrosComprobante1415_A => new TipoComprobante(39, "Otros comprobantes A que cumplan con R.G.Nro. 1415");
        public static TipoComprobante OtrosComprobante1415_B => new TipoComprobante(40, "Otros comprobantes B que cumplan con R.G.Nro. 1415");
        public static TipoComprobante CtaVtaLiqProd_A => new TipoComprobante(60, "Cta de Vta y Liquido prod. A");
        public static TipoComprobante CtaVtaLiqProd_B => new TipoComprobante(61, "Cta de Vta y Liquido prod. B");
        public static TipoComprobante Factura_C => new TipoComprobante(11, "Factura C");
        public static TipoComprobante NotaDebito_C => new TipoComprobante(12, "Nota de Débito C");
        public static TipoComprobante NotaCredito_C => new TipoComprobante(13, "Nota de Crédito C");
        public static TipoComprobante Recibo_C => new TipoComprobante(15, "Recibo C");
        public static TipoComprobante ComprobanteCompraBienesUsadosConsFinal => new TipoComprobante(49, "Comprobante de Compra de Bienes Usados a Consumidor Final");
        public static TipoComprobante Factura_M => new TipoComprobante(51, "Factura M");
        public static TipoComprobante NotaDebito_M => new TipoComprobante(52, "Nota de Débito M");
        public static TipoComprobante NotaCredito_M => new TipoComprobante(53, "Nota de Crédito M");
        public static TipoComprobante Recibo_M => new TipoComprobante(54, "Recibo M");
        public static TipoComprobante FacturaCreditoElectronicaMiPyMEs_A => new TipoComprobante(201, "Factura de Crédito electrónica MiPyMEs (FCE) A");
        public static TipoComprobante NotaDebitoElectronicaMiPyMEs_A => new TipoComprobante(202, "Nota de Débito electrónica MiPyMEs (FCE) A");
        public static TipoComprobante NotaCreditoElectronicaMiPyMEs_A => new TipoComprobante(203, "Nota de Crédito electrónica MiPyMEs (FCE) A");
        public static TipoComprobante FacturaCreditoElectronicaMiPyMEs_B => new TipoComprobante(206, "Factura de Crédito electrónica MiPyMEs (FCE) B");
        public static TipoComprobante NotaDebitoElectronicaMiPyMEs_B => new TipoComprobante(207, "Nota de Débito electrónica MiPyMEs (FCE) B");
        public static TipoComprobante NotaCreditoElectronicaMiPyMEs_B => new TipoComprobante(208, "Nota de Crédito electrónica MiPyMEs (FCE) B");
        public static TipoComprobante FacturaCreditoElectronicaMiPyMEs_C => new TipoComprobante(211, "Factura de Crédito electrónica MiPyMEs (FCE) C");
        public static TipoComprobante NotaDebitoElectronicaMiPyMEs_C => new TipoComprobante(212, "Nota de Débito electrónica MiPyMEs (FCE) C");
        public static TipoComprobante NotaCreditoElectronicaMiPyMEs_C => new TipoComprobante(213, "Nota de Crédito electrónica MiPyMEs (FCE) C");

        public TipoComprobante(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public static IEnumerable<TipoComprobante> GetAll()
        => new TipoComprobante[]
        {
            Factura_A,
            NotaDebito_A,
            NotaCredito_A,
            Factura_B,
            NotaDebito_B,
            NotaCredito_B,
            Recibo_A,
            NotaVentaContado_A,
            Recibo_B,
            NotaVentaContado_B,
            Liquidacion_A,
            Liquidacion_B,
            CbteAnexoI_A,
            CbteAnexoI_B,
            OtrosComprobante1415_A,
            OtrosComprobante1415_B,
            CtaVtaLiqProd_A,
            CtaVtaLiqProd_B,
            Factura_C,
            NotaDebito_C,
            NotaCredito_C,
            Recibo_C,
            ComprobanteCompraBienesUsadosConsFinal,
            Factura_M,
            NotaDebito_M,
            NotaCredito_M,
            Recibo_M,
            FacturaCreditoElectronicaMiPyMEs_A,
            NotaDebitoElectronicaMiPyMEs_A,
            NotaCreditoElectronicaMiPyMEs_A,
            FacturaCreditoElectronicaMiPyMEs_B,
            NotaDebitoElectronicaMiPyMEs_B,
            NotaCreditoElectronicaMiPyMEs_B,
            FacturaCreditoElectronicaMiPyMEs_C,
            NotaDebitoElectronicaMiPyMEs_C,
            NotaCreditoElectronicaMiPyMEs_C,
        };

        public static TipoComprobante GetById(int id)
            => GetAll().FirstOrDefault(x => x.Id == id);

        public static implicit operator int(TipoComprobante tipoMoneda) => tipoMoneda.Id;

        public override bool Equals(object obj) => this.Equals(obj as TipoComprobante);

        public bool Equals(TipoComprobante other)
        {
            if (other is null)
            {
                return false;
            }

            // Optimization for a common success case.
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }

            // Check properties that this class declares.
            if (Id == other.Id)
            {
                // Let base class check its own fields
                // and do the run-time type comparison.
                return base.Equals(other);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode() => (Id, Description).GetHashCode();

        public static bool operator ==(TipoComprobante ltm, TipoComprobante rtm)
        {
            if (ltm is null)
            {
                if (rtm is null)
                {
                    // null == null = true.
                    return true;
                }

                // Only the left side is null.
                return false;
            }
            // Equals handles the case of null on right side.
            return ltm.Equals(rtm);
        }

        public static bool operator !=(TipoComprobante ltm, TipoComprobante rtm) => !(ltm == rtm);
    }
}
