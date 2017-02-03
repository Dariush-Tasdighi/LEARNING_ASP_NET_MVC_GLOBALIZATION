using System.Linq;
using System.Data.Entity;

namespace MY_MVC_APPLICATION.Controllers
{
	public partial class HomeController : Infrastructure.BaseController
	{
		public HomeController()
			: base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Index()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public void ChangeCulture(string name)
		{
			Session["Culture"] = name;

			//return (RedirectToAction(MVC.Home.Index()));

			string strUrlReferrer =
				Request.UrlReferrer.AbsoluteUri;

			Response.Redirect(strUrlReferrer, endResponse: false);
		}
	}
}
