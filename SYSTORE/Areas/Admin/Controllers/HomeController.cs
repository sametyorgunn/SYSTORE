using BusinessLayer.Abstract;
using EntityLayer.Dtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace SYSTORE.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class HomeController : Controller
	{

		public IActionResult Index()
		{
			return View();
		}
	

	

		

	}
}
