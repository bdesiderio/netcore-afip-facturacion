using System;

namespace AFIP.Facturacion
{
    public class WsaaTicket
    {
        public string Sign { get; set; } // Firma de seguridad recibida en la respuesta
        public string Token { get; set; } // Token de seguridad recibido en la respuesta
        public DateTime ExpirationTime { get; set; } //Expiracion del ticket
    }
}
