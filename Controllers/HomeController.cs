using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SweetAlertNotifications.Controllers
{
    public class HomeController : NotificationController
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Basic()
        {
            Notify("Message");
            return RedirectToAction("Index");
        }
        public IActionResult TitleWithTextUnder()
        {
            Notify("Title", "Message", IconsType.success);
            return RedirectToAction("Index");
        }
        public IActionResult ModalWithFooter()
        {
            Notify("Title", "Message", "<a href=''>Call me!</a>", IconsType.error);
            return RedirectToAction("Index");
        }
        public IActionResult ConfirmDialogWithConfirmButton()
        {
            Notify("Title", "Message",true,"Delete it","title", "Your file has been deleted.", IconsType.error);
            return RedirectToAction("Index");
        }
    }
}
