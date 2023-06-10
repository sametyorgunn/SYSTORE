using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace SYSTORE.ViewComponents.Default
{
    public class MarkaListesiSelect:ViewComponent
    {
        private readonly IMarkaService _markaservice;

        public MarkaListesiSelect(IMarkaService markaservice)
        {
            _markaservice = markaservice;
        }

        public IViewComponentResult Invoke()
        {
            var markalar = _markaservice.GetList();
            return View(markalar);
        }
    }
}
