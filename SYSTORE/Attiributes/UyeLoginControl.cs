using EntityLayer.Enums;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SYSTORE.Attiributes
{
	public class UyeLoginControl:ActionFilterAttribute
	{
		public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
		{
			var rolid = context.HttpContext.Session.GetInt32("rolid");
			if (rolid == (int)RolTurleri.RolType.Uye)
			{
				var result = await next();
			}
			else
			{
				context.HttpContext.Response.Redirect("/Giris/index");
			}

		}
	}
}
