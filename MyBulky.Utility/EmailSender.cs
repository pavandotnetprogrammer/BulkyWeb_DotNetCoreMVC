﻿
using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MyBulky.Utility
{
    public class EmailSender: IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //logic to send email

            //var client = new SendGridClient(SendGridSecret);

            //var from = new EmailAddress("hello@dotnetmastery.com", "Bulky Book");
            //var to = new EmailAddress(email);
            //var message = MailHelper.CreateSingleEmail(from, to, subject, "", htmlMessage);

            //return client.SendEmailAsync(message);
            //throw new NotImplementedException();
            return Task.CompletedTask;


        }
    }
}
