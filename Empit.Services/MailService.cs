using Empit.Core.Models;
using Empit.Data;

using Empite.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Linq;
using Microsoft.Extensions.Caching.Memory;
using System.IO;

namespace Empit.Services
{
    public class MailService : IMailService
    {
        private readonly ApplicationDbContext context;
        

        public MailService(ApplicationDbContext context)
        {
            this.context = context;
        }



        public async Task<string> SendEmailAsync(MailModel mailModel)
        {
            foreach (string element in mailModel.Recipients)
            {
                var apiKey = "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";
                var client = new SendGridClient(apiKey);
                var from = new EmailAddress("imandissanayake12@gmail.com");
                var to = new EmailAddress(element);
                var subject = "Summary Report";
                var plainTextContent = mailModel.Content;
                var htmlContent = mailModel.Content;
                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
               

                byte[] byteData = Encoding.ASCII.GetBytes(File.ReadAllText("D:\\check.txt"));
                msg.Attachments = new List<SendGrid.Helpers.Mail.Attachment>
            {
                new SendGrid.Helpers.Mail.Attachment
                {
                    Content = Convert.ToBase64String(byteData),
                    Filename = "Report.txt",
                    Type = "txt/plain",
                    Disposition = "attachment"
                }
            };
                var response = await client.SendEmailAsync(msg);
            }
            return mailModel.Subject;

       }

     //   public async Task<MailModel> SendEmailAsync(List<string> recipients, string subject,  string sender)
        // {
        //     var apiKey = "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";
        //     var client = new SendGridClient(apiKey);
        //     var from = MailHelper.StringToEmailAddress(sender);
        //     var tos = recipients.Select(x => MailHelper.StringToEmailAddress(x)).ToList();
        //     var msg = new SendGridMessage();
        //     msg.SetFrom(from);
        //     msg.SetGlobalSubject(subject);
        //     //use htmlcontent only if you are sending only HTML
        //     // if (!string.IsNullOrEmpty(bodyHtml))
        //     // {
        //     //     msg.AddContent(MimeType.Html, bodyHtml);
        //     // }

        //     //The AddTos method below accepts List<EmailAddress> to add multiple recipients with Personalization

        //     msg.AddTos(tos);

        //    await client.SendEmailAsync(msg);
           
        // }

    }
}
