﻿using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Utilidades
{
    public class EmailSender : IEmailSender
    {
        public string SendGridSecret { get; set; }
        public EmailSender(IConfiguration _config) 
        {
            SendGridSecret = _config.GetValue<string>("Sendgrid:Secretkey");
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SendGridClient(SendGridSecret);
            var from = new EmailAddress("luis@pulsecommercegt.org");
            var to = new EmailAddress(email);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent: "", htmlMessage);
            //var msg = new MailHelper.CreateSingleEmail(from, to, subject, "", htmlMessage);               
            
            return client.SendEmailAsync(msg);
        }
    }
}
