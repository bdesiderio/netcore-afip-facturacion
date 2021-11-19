using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFIP.Facturacion.Model
{
    public class Concepto
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public static Concepto Producto => new Concepto(1, "Productos");
        public static Concepto Servicios => new Concepto(2, "Servicios");
        public static Concepto ProductosYServicios => new Concepto(3, "Productos y Servicios");

        public Concepto(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public static IEnumerable<Concepto> GetAll()
        => new Concepto[]
        {
                Producto,
                Servicios,
                ProductosYServicios
        };

        public static Concepto GetById(int id)
            => GetAll().FirstOrDefault(x => x.Id == id);


        public static implicit operator int(Concepto concepto) => concepto.Id;

        public override bool Equals(object obj) => this.Equals(obj as Concepto);

        public bool Equals(Concepto other)
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

        public static bool operator ==(Concepto lc, Concepto rc)
        {
            if (lc is null)
            {
                if (rc is null)
                {
                    // null == null = true.
                    return true;
                }

                // Only the left side is null.
                return false;
            }
            // Equals handles the case of null on right side.
            return lc.Equals(rc);
        }

        public static bool operator !=(Concepto lc, Concepto rc) => !(lc == rc);
    }
}
