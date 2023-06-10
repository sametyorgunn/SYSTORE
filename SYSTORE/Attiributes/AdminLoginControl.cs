using EntityLayer.Enums;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SYSTORE.Attiributes
{
	public class AdminLoginControl:ActionFilterAttribute
	{
		public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
		{
			var rolid = context.HttpContext.Session.GetInt32("rolid");
			if (rolid == (int)RolTurleri.RolType.Admin)
			{
				var result = await next();
			}
			else
			{
				context.HttpContext.Response.Redirect("/SyStore/Giris/index");
			}

		}
	}
}
