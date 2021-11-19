using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFIP.Facturacion.Model
{
    public class TipoDocumento
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public static TipoDocumento CUIT => new TipoDocumento(80, "CUIT");
        public static TipoDocumento CUIL => new TipoDocumento(86, "CUIL");
        public static TipoDocumento CDI => new TipoDocumento(87, "CDI");
        public static TipoDocumento LE => new TipoDocumento(89, "LE");
        public static TipoDocumento LC => new TipoDocumento(90, "LC");
        public static TipoDocumento CIExtranjera => new TipoDocumento(91, "CI Extranjera");
        public static TipoDocumento EnTramite => new TipoDocumento(92, "en trámite");
        public static TipoDocumento ActaNacimiento => new TipoDocumento(93, "Acta Nacimiento");
        public static TipoDocumento CIBsAsRNP => new TipoDocumento(95, "CI Bs. As. RNP");
        public static TipoDocumento DNI => new TipoDocumento(96, "DNI");
        public static TipoDocumento Pasaporte => new TipoDocumento(94, "Pasaporte");
        public static TipoDocumento CIPoliciaFederal => new TipoDocumento(0, "CI Policía Federal");
        public static TipoDocumento CIBuenosAires => new TipoDocumento(1, "CI Buenos Aires");
        public static TipoDocumento CICatamarca => new TipoDocumento(2, "CI Catamarca");
        public static TipoDocumento CICordoba => new TipoDocumento(3, "CI Córdoba");
        public static TipoDocumento CICorrientes => new TipoDocumento(4, "CI Corrientes");
        public static TipoDocumento CIEntreRios => new TipoDocumento(5, "CI Entre Ríos");
        public static TipoDocumento CIJujuy => new TipoDocumento(6, "CI Jujuy");
        public static TipoDocumento CIMendoza => new TipoDocumento(7, "CI Mendoza");
        public static TipoDocumento CILaRioja => new TipoDocumento(8, "CI La Rioja");
        public static TipoDocumento CISalta => new TipoDocumento(9, "CI Salta");
        public static TipoDocumento CISanJuan => new TipoDocumento(10, "CI San Juan");
        public static TipoDocumento CISanLuis => new TipoDocumento(11, "CI San Luis");
        public static TipoDocumento CISantaFe => new TipoDocumento(12, "CI Santa Fe");
        public static TipoDocumento CISantiagoDelEstero => new TipoDocumento(13, "CI Santiago del Estero");
        public static TipoDocumento CITucuman => new TipoDocumento(14, "CI Tucumán");
        public static TipoDocumento CIChaco => new TipoDocumento(16, "CI Chaco");
        public static TipoDocumento CIChubut => new TipoDocumento(17, "CI Chubut");
        public static TipoDocumento CIFormosa => new TipoDocumento(18, "CI Formosa");
        public static TipoDocumento CIMisiones => new TipoDocumento(19, "CI Misiones");
        public static TipoDocumento CINeuquen => new TipoDocumento(20, "CI Neuquén");
        public static TipoDocumento CILaPampa => new TipoDocumento(21, "CI La Pampa");
        public static TipoDocumento CIRioNegro => new TipoDocumento(22, "CI Río Negro");
        public static TipoDocumento CISantaCruz => new TipoDocumento(23, "CI Santa Cruz");
        public static TipoDocumento CITierraDelFuego => new TipoDocumento(24, "CI Tierra del Fuego");
        public static TipoDocumento DocOtro => new TipoDocumento(99, "Doc. (Otro)");

        public TipoDocumento(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public static IEnumerable<TipoDocumento> GetAll()
       => new TipoDocumento[]
       {
            CUIT,
            CUIL,
            CDI,
            LE,
            LC,
            CIExtranjera,
            EnTramite,
            ActaNacimiento,
            CIBsAsRNP,
            DNI,
            Pasaporte,
            CIPoliciaFederal,
            CIBuenosAires,
            CICatamarca,
            CICordoba,
            CICorrientes,
            CIEntreRios,
            CIJujuy,
            CIMendoza,
            CILaRioja,
            CISalta,
            CISanJuan,
            CISanLuis,
            CISantaFe,
            CISantiagoDelEstero,
            CITucuman,
            CIChaco,
            CIChubut,
            CIFormosa,
            CIMisiones,
            CINeuquen,
            CILaPampa,
            CIRioNegro,
            CISantaCruz,
            CITierraDelFuego,
            DocOtro
       };

        public static TipoDocumento GetById(int id)
          => GetAll().FirstOrDefault(x => x.Id == id);

        public override bool Equals(object obj) => this.Equals(obj as TipoDocumento);

        public bool Equals(TipoDocumento other)
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

        public static bool operator ==(TipoDocumento ltd, TipoDocumento rtd)
        {
            if (ltd is null)
            {
                if (rtd is null)
                {
                    // null == null = true.
                    return true;
                }

                // Only the left side is null.
                return false;
            }
            // Equals handles the case of null on right side.
            return ltd.Equals(rtd);
        }

        public static bool operator !=(TipoDocumento ltd, TipoDocumento rtd) => !(ltd == rtd);
    }
}
