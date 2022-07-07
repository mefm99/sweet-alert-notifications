using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SweetAlertNotifications.Controllers
{
    public enum BoxesType
    {
        Basic,
        TitleWithTextUnder,
        ModalWithFooter,
        ConfirmDialogWithConfirmButton
    }
    public enum IconsType
    {
        warning,
        error,
        success,
        info,
        question
    }
    public class NotificationController : Controller
    {
        /// <summary>
        /// A basic message.
        /// </summary>
        /// <param name="message"></param>
        public void Notify(string message)
        {
            var msg = new
            {
                message = message,
                type = BoxesType.Basic.ToString()
            };
            TempData["Message"] = JsonConvert.SerializeObject(msg);
        }
        /// <summary>
        /// A title with a text under

        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="icon"></param>
        public void Notify(string title,string message, IconsType icon = IconsType.question)
        {
            var msg = new
            {
                title = title,
                message = message,
                icon = icon.ToString(),
                type = BoxesType.TitleWithTextUnder.ToString()
            };
            TempData["Message"] = JsonConvert.SerializeObject(msg);
        }
        /// <summary>
        /// A modal with a title, an error icon, a text, and a footer
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="footer"></param>
        /// <param name="icon"></param>
        public void Notify(string title, string message, string footer, IconsType icon = IconsType.question)
        {
            var msg = new
            {
                title = title,
                message = message,
                icon = icon.ToString(),
                footer = footer,
                type = BoxesType.ModalWithFooter.ToString()
            };
            TempData["Message"] = JsonConvert.SerializeObject(msg);
        }
        /// <summary>
        /// A confirm dialog, with a function attached to the "Confirm"-button
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="showCancelButton"></param>
        /// <param name="confirmButtonText"></param>
        /// <param name="titleConfirm"></param>
        /// <param name="messageConfirm"></param>
        /// <param name="icon"></param>
        public void Notify(string title, string message, bool showCancelButton, string confirmButtonText,string titleConfirm,string messageConfirm, IconsType icon = IconsType.question)
        {
            var msg = new
            {
                title = title,
                message = message,
                icon = icon.ToString(),
                showCancelButton = showCancelButton,
                confirmButtonText = confirmButtonText,
                titleConfirm = titleConfirm,
                messageConfirm = messageConfirm,
                type = BoxesType.ConfirmDialogWithConfirmButton.ToString()
            };
            TempData["Message"] = JsonConvert.SerializeObject(msg);
        }
    }
}
