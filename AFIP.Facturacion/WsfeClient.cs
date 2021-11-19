using AFIP.Facturacion.Configuration;
using AfipServiceReference;
using Microsoft.Extensions.Options;
using System.ServiceModel;
using System.Threading.Tasks;

namespace AFIP.Facturacion
{
    public class WsfeClient
    {
        private readonly IOptions<AFIPConfigurationOption> _configuration;
        private readonly LoginCmsClient _loginCmsClient;

        public string WsfeUrlHomologation { get; set; } = "https://wswhomo.afip.gov.ar/wsfev1/service.asmx";
        public string WsfeUrlProd { get; set; } = "https://servicios1.afip.gov.ar/wsfev1/service.asmx";

        public WsfeClient(IOptions<AFIPConfigurationOption> configuration,
           LoginCmsClient loginCmsClient)
        {
            _configuration = configuration;
            _loginCmsClient = loginCmsClient;
            _loginCmsClient = loginCmsClient;
        }

        private async Task<FEAuthRequest> GetAuthRequestAsync()
        {
            var ticket = await _loginCmsClient.GetWsaaTicket();
            return new FEAuthRequest { Cuit = _configuration.Value.Cuit, Sign = ticket.Sign, Token = ticket.Token };
        }

        private ServiceSoapClient GetServiceSoapClient()
        {
            var wsfeService = new ServiceSoapClient(ServiceSoapClient.EndpointConfiguration.ServiceSoap);
            wsfeService.Endpoint.Address = new EndpointAddress(_configuration.Value.IsProdEnvironment ? WsfeUrlProd : WsfeUrlHomologation);
            return wsfeService;
        }

        public async Task<FECompUltimoAutorizadoResponse> FECompUltimoAutorizadoAsync(int ptoVta, int cbteTipo)
        {
            var wsfeService = GetServiceSoapClient();
            var auth = await GetAuthRequestAsync();

            return await wsfeService.FECompUltimoAutorizadoAsync(auth, ptoVta, cbteTipo);
        }

        public async Task<FECAESolicitarResponse> FECAESolicitarAsync(FECAERequest feCaeReq)
        {
            var wsfeService = GetServiceSoapClient();
            var auth = await GetAuthRequestAsync();

            return await wsfeService.FECAESolicitarAsync(auth, feCaeReq);
        }


        public async Task<FEParamGetPtosVentaResponse> FEParamGetPtosVentaAsync()
        {
            var wsfeService = GetServiceSoapClient();
            var auth = await GetAuthRequestAsync();

            return await wsfeService.FEParamGetPtosVentaAsync(auth);
        }

        public async Task<FEParamGetTiposMonedasResponse> FEParamGetTiposMonedasAsync()
        {
            var wsfeService = GetServiceSoapClient();
            var auth = await GetAuthRequestAsync();

            return await wsfeService.FEParamGetTiposMonedasAsync(auth);
        }

        public async Task<FEParamGetTiposDocResponse> FEParamGetTiposDocAsync()
        {
            var wsfeService = GetServiceSoapClient();
            var auth = await GetAuthRequestAsync();

            return await wsfeService.FEParamGetTiposDocAsync(auth);
        }
    }
}
