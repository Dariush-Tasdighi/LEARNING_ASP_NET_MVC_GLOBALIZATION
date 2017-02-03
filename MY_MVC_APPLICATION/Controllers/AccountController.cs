using System.Linq;
using System.Data.Entity;

namespace MY_MVC_APPLICATION.Controllers
{
	public partial class AccountController : Infrastructure.BaseController
	{
		public AccountController()
			: base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Login()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.ViewResult Login(Models.User user)
		{
			return View();
		}
	}
}
