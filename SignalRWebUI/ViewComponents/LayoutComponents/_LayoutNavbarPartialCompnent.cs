using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutNavbarPartialCompnent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
