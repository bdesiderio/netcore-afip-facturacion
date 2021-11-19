using System;
using System.Collections.Generic;
using System.Text;

namespace AFIP.Facturacion.Configuration
{
    public class AFIPConfigurationOption
    {
        public long Cuit { get; set; }
        public bool IsProdEnvironment { get; set; } = false;
        public string x509CertificateFilePath { get; set; }
        public string CertificatePassword { get; set; }
        public bool Verbose { get; set; }
    }
}
