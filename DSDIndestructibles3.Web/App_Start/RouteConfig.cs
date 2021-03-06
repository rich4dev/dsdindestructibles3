using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace DSDIndestructibles3.Web
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);

            routes.MapPageRoute("Route1", "RegistrarKitBienvenida", "~/forms/procesos/EntregarKit.aspx");
            routes.MapPageRoute("Route2", "ProgramarInstalacion", "~/forms/procesos/ProgramarInstalacion.aspx");
            routes.MapPageRoute("Route3", "RegistrarInstalacion", "~/forms/procesos/RegistrarInstalacion.aspx");
            routes.MapPageRoute("Route4", "EvaluarRiesgoFraude", "~/forms/procesos/EvaluarRiesgoFraude.aspx");
            routes.MapPageRoute("Route5", "SolicitarInstalacion", "~/forms/procesos/SolicitarInstalacion.aspx");
            routes.MapPageRoute("Route6", "RegistrarSolicitud", "~/forms/procesos/RegistrarSolicitud.aspx");
<<<<<<< HEAD

            routes.MapPageRoute("Route8", "ProgramarInspeccion", "~/forms/procesos/ProgramarInspeccion.aspx");
            routes.MapPageRoute("Route9", "Registrar Inspeccion", "~/forms/procesos/RegistrarInspeccion.aspx");

            routes.MapPageRoute("Route7", "RegistrarSolicitudAfilacion", "~/forms/procesos/RegistrarSolicitudAfilacion.aspx");

=======
>>>>>>> 877065dcfcaaf363d97f9650c0ade13b9a1ad3fd
        }
    }
}
