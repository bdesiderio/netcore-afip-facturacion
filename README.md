# netcore-afip-facturacion
Hola necesito comunicarme contigo, podrias hablarme a mi mail tomas.marro10@gmail.com
Facturacion AFIP para NETCore 5 implementado para ser utilizado con inyección de dependencias. El proyecto disponibiliza usos básicos de la facturación y se encuentra en desarrollo.

Este proyecto nace como un fork de:
https://github.com/tecnocode-sa/afipwsfeclient

## Configurar Dependency Injection
Se crea extensión de IServiceCollection con el nombre AddAFIPConfiguration para configurar inyección de dependencias

```
var serviceCollection = new ServiceCollection();

serviceCollection.AddAFIPConfiguration(x =>
{
    x.CertificatePassword = CERTIFICATE_PASSWORD;
    x.Cuit = CUIT;
    x.IsProdEnvironment = false;
    x.Verbose = true;
    x.x509CertificateFilePath = CERTIFICATE_PATH;
});

serviceProvider = serviceCollection.BuildServiceProvider();
```

## Injectar Servicio IAFIPFacturacionService
Luego de configurar la inyección de dependencias se puede inyectar el servicio IAFIPFacturacionService

```
public class Facturacion
{
    private readonly IAFIPFacturacionService _afipFacturacionService;

    public Facturacion(IAFIPFacturacionService afipFacturacionService)
    {
        _afipFacturacionService = afipFacturacionService;
    }

    public async Task Facturar()
    {
        await _afipFacturacionService.FacturarAsync(new FacturaAFIP()
        {

        });
    }
}
```
