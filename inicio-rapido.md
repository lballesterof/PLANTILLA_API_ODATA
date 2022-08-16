---
description: Guía rapida de instalación manual de Services Layers
---

# Inicio rápido

{% hint style="info" %}
**Bueno a saber:** Antes de iniciar con la instalación del services layers de unosoft ERP, validar de no poseer reincios pendientes por actualización, validar ademas de contar con la ultima actualizacion del SO más estable, para evitar posibles errores de dependencias sobre el marco de trabajo .Net Framework
{% endhint %}

## Instalar IIS Server

Si deseas instalar tus servicios en un servidor Windows puedes instalarlo en IIS (Internet Information Services) el cual es el Web Server que viene incluido en Windows.

En esta sección explicaré:

* Instalar IIS en Windows Server y 10.

**Caso Windows 10** seguir tutorial siguiente: [https://aspnetcoremaster.com/aspnetcore/como-instalar-iis-para-aspnetcore.html](https://aspnetcoremaster.com/aspnetcore/como-instalar-iis-para-aspnetcore.html).

**Caso Windows Server**: Para habilitar IIS y los componentes de IIS necesarios en Windows Server, haga lo siguiente:

1. Abra Server Manager y haga clic en Administrar > Añadir roles y entidades. Haga clic en Siguiente.
2. Seleccione Instalación basada en roles o entidades y haga clic en Siguiente.
3. Seleccione el servidor apropiado. De forma predeterminada se selecciona el servidor local. Haga clic en Siguiente.
4. Habilite Servidor Web (IIS) y haga clic en Siguiente.
5. No se necesitan entidades adicionales para instalar Web Adaptor; por lo tanto, haga clic en Siguiente.
6. En el cuadro de diálogo Rol de servidor Web (IIS), haga clic en Siguiente.
7. En el cuadro de diálogo Seleccionar servicios de rol, verifique que los componentes del servidor web que aparecen en la sección siguiente están habilitados. Haga clic en Siguiente.
8. Verifique que la configuración es correcta y haga clic en Instalar.
9. Una vez completada la instalación, haga clic en Cerrar para salir del asistente.

### Componentes de IIS necesarios Windows Server

Los componentes de IIS que se detallan a continuación cumplen con los requisitos mínimos para ejecutar Web Adaptor. Si están habilitados otros componentes de IIS, no es necesario quitarlos.

* Servidor Web
  * Características HTTP comunes
    * Documento predeterminado
    * Contenido estático
  * Seguridad
    * Filtro de solicitudes
    * Autenticación básica
    * Autenticación de Windows
  * Desarrollo de aplicaciones
    * .NET Extensibility 4.5
    * Extensibilidad de .NET
    * ASP.NET 4.7
    * ASP.NET
    * Extensiones ISAPI
    * Filtros ISAPI
    * Protocolo WebSocket
* Herramientas de administración
  * Consola de administración de IIS
  * Scripts y herramientas de administración de IIS
  * Servicio de administración



## Instalar Services Layers Unosoft

Ejecutar el archivo de instalación&#x20;

{% tabs %}
{% tab title="Dependencias" %}
```
# Install via MSI
Ejecutar archivo SLUSInstall.exe
```
{% endtab %}
{% endtabs %}

{% hint style="info" %}
**Nota:** Durante la instalación los archivos de dependencia son borrados una vez culminado la instalación óptmizando así los espacios del disco duro.
{% endhint %}

## Consume tu primer request

Para realizar su primera solicitud, envíe una solicitud autenticada al terminal de SL. Esto creará una sesión, lo cual permitirá realizar las operaciones y verlas reflejadas en el ERP.

{% swagger baseUrl="https://api.myapi.com/api/Users/" method="post" path="login" summary="Inicia sesión." %}
{% swagger-description %}
Logueate al SL Unosoft
{% endswagger-description %}

{% swagger-parameter in="body" name="usuariomozo" required="true" type="string" %}
Código de usuario ERP
{% endswagger-parameter %}

{% swagger-parameter in="body" name="passmozo" required="true" type="string" %}
Es el 

`password`

 asignado para mobile en el ERP
{% endswagger-parameter %}

{% swagger-response status="200" description="Login successfully" %}
```javascript
{
  "usuario": "USER1",
  "nombreusuario": "SOPORTE",
  "codigO_EMPRESA": "001",
  "iD_CLIENTE": 30504,
  "poR_IGV": "18",
  "cdgmoneda": "0001",
  "validez": "0001",
  "cdgpago": "0001",
  "sucursal": "0008",
  "nombremozo": null,
  "usuarioautoriza": "USER1",
  "usuariocreacion": "USER1",
  "descuento": "0.00",
  "seriepedido": "0000",
  "estadopedido": "0001",
  "tipocambio": "0.00",
  "jwtToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IlVTRVIxIiwibmJmIjoxNjYwNjI5OTE2LCJleHAiOjE2NjA2MzA4MTYsImlhdCI6MTY2MDYyOTkxNn0.L8x_M8naE5Aar8Aa1o2yxA8Zua1SK1Q_oazusw0BMB8",
  "facturA_ADELANTADA": "0",
  "iD_COTIZACION": "0",
  "puntO_VENTA": "0",
  "redondeo": "0",
  "motivo": null,
  "correlativo": null,
  "refreshToken": "540YjJra/tT6GEVvHwpQZMvkGVbrrN/XtVHgQMiaG/P/YYDWAHIp3XBQUuS3CLaU56Q0Nn/oJF3gTszSBgXFAw==",
  "cdG_VENDEDOR": "0003",
  "ruc": "200000000000",
  "nombre": "DEMO SAC"
}
```
{% endswagger-response %}

{% swagger-response status="400: Bad Request" description="Permission denied" %}
```json
{
  "message": "Usuario o Contraseña Incorrecta"
}
```
{% endswagger-response %}
{% endswagger %}
