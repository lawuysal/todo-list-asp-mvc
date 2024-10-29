using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace todo_list_asp_mvc.Controllers
{
    public class AdminController : Controller
    {
        IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public IActionResult Index()
        {
            var result = _adminService.GetAll();
            if (result.Success)
            {
                ViewBag.AdminList = result.Data;
            }
            return View();
        }
    }
}
