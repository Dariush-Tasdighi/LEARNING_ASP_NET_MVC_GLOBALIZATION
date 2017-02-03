namespace Infrastructure
{
	public abstract class BaseController : System.Web.Mvc.Controller
	{
		public BaseController()
			: base()
		{
		}

		protected override void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext)
		{
			// **************************************************
			//System.Globalization.CultureInfo oCultureInfo =
			//	new System.Globalization.CultureInfo("en-US");

			//System.Threading.Thread.CurrentThread.CurrentCulture = oCultureInfo;
			//System.Threading.Thread.CurrentThread.CurrentUICulture = oCultureInfo;
			// **************************************************

			// **************************************************
			//System.Globalization.CultureInfo oCultureInfo =
			//	new System.Globalization.CultureInfo("fa-IR");

			//System.Threading.Thread.CurrentThread.CurrentCulture = oCultureInfo;
			//System.Threading.Thread.CurrentThread.CurrentUICulture = oCultureInfo;
			// **************************************************

			// **************************************************
			if (Session["Culture"] == null)
			{
				// دستورات ذیل یعنی اول بسم الله سایت به چه زبانی دیده شود
				Session["Culture"] = "en-US";
				//Session["Culture"] = "fa-IR";
			}

			// دستورات ذیل نباید در داخل شرط قرار بگیرند
			System.Globalization.CultureInfo oCultureInfo =
				new System.Globalization.CultureInfo(Session["Culture"].ToString());

			System.Threading.Thread.CurrentThread.CurrentCulture = oCultureInfo;
			System.Threading.Thread.CurrentThread.CurrentUICulture = oCultureInfo;
			// **************************************************
		}
	}
}
