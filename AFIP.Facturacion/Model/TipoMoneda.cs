using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFIP.Facturacion.Model
{
    public class TipoMoneda
    {
        public string Id { get; set; }
        public string Description { get; set; }

        public static TipoMoneda PesoArgentino => new TipoMoneda("PES", "Pesos Argentinos");
        public static TipoMoneda DolarEstadounidense => new TipoMoneda("DOL", "Dólar Estadounidense");

        public TipoMoneda(string id, string description)
        {
            Id = id;
            Description = description;
        }

        public static IEnumerable<TipoMoneda> GetAll()
        => new TipoMoneda[]
        {
            PesoArgentino,
            DolarEstadounidense
        };

        public static TipoMoneda GetById(string id)
            => GetAll().FirstOrDefault(x => x.Id == id);

        public override bool Equals(object obj) => this.Equals(obj as TipoMoneda);

        public bool Equals(TipoMoneda other)
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

        public static bool operator ==(TipoMoneda ltm, TipoMoneda rtm)
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

        public static bool operator !=(TipoMoneda ltm, TipoMoneda rtm) => !(ltm == rtm);
    }
}
