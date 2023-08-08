﻿using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddress = new MailboxAddress("HotelierAdmin", "myilmaz8787.mctyl@gmail.com");
            mimeMessage.From.Add(mailboxAddress);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587,false);
            client.Authenticate("myilmaz8787.mctyl@gmail.com", "ufcmcoomehtldibs");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }
    }
}
