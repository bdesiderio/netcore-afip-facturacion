using AfipServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFIP.Facturacion.Exceptions
{
    public class AFIPFacturacionException : Exception
    {
        public List<ErrorItem> ErrorItems { get; private set; }

        public AFIPFacturacionException(List<Err> err)
            : base(String.Join(Environment.NewLine, err.Select(x => $"Codigo {x.Code}: {x.Msg}")))
        {
            ErrorItems = err.Select(x => new ErrorItem(x.Code, x.Msg)).ToList();
        }
    }

    public class ErrorItem
    {
        public int Code { get; private set; }
        public string Description { get; set; }

        public ErrorItem(int code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}
