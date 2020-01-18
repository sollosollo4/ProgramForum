using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramForum_ServerCore.Classes
{
    public class EmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Администрация сайта", "dambas.ss@yandex.ru"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = message };

            using var client = new SmtpClient();
            await client.ConnectAsync("smtp.yandex.ru", 25, false);
            await client.AuthenticateAsync("dambas.ss@yandex.ru", "hft56da");
            await client.SendAsync(emailMessage);

            await client.DisconnectAsync(true);
        }
    }
}
