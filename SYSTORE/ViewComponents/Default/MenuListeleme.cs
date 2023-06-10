using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace SYSTORE.ViewComponents.Default
{
    public class MenuListeleme:ViewComponent
    {
        private readonly IMenuService _menuservice;

        public MenuListeleme(IMenuService menuservice)
        {
            _menuservice = menuservice;
        }

        public IViewComponentResult Invoke()
        {
            var menuler = _menuservice.GetList();
            return View(menuler);
        }
    }
}
