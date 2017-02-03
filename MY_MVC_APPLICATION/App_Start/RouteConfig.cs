using System.Web.Mvc;

namespace MY_MVC_APPLICATION
{
	public static class RouteConfig
	{
		static RouteConfig()
		{
		}

		public static void RegisterRoutes(System.Web.Routing.RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults:
					new
					{
						controller = "Home",
						action = "Index",
						id = System.Web.Mvc.UrlParameter.Optional
					},
				namespaces: new[] { "MY_MVC_APPLICATION.Controllers" }
			);
		}
	}
}
