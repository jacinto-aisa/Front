using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Net;
//using System.Net.Mail;
using System.Threading.Tasks;

namespace Desaprendiendo.Services.Mail
{
    public class EMail : IEMail
    {
        public EMail(IOptions<MailConfiguration> mailConfiguration)
        {
            _mailConfiguration = mailConfiguration.Value;

        }

        public MailConfiguration _mailConfiguration { get; }
        public Task SendEmailAsync(string message)
        {
            Execute(message).Wait();
            return Task.FromResult(0);
        }
        public async Task Execute(string message_recibido)
        {
            MimeMessage message = new MimeMessage();
            try
            {
                // Feel free to add in ProtocolLogger here if you would like to get an smtp logger to output to a file. I removed it for this sample (and brevity).
                // Example: 
                // using (var client = new SmtpClient(new ProtocolLogger("D:\\home\LogFiles\\smtp.log")))
                using (var client = new SmtpClient())
                {
                    // This is where you will input the email it is coming from (hint: your gmail address)
                    message.From.Add(new MailboxAddress("clientes", "clientes.desaprendiendo@gmail.com"));
                    // This is where you add in the recipient email (hint: you can test using your own gmail address as well)
                    message.To.Add(new MailboxAddress("clientesDestino", "clientes.desaprendiendo@gmail.com"));
                    message.Subject = "Consulta_Clientes";
                    message.Body =
                        new TextPart("plain")
                        {
                            Text = message_recibido
                        };
                    // Go to Google Profile to generate an app password rather than using your real password here
                    client.Connect("smtp.gmail.com", 587, SecureSocketOptions.Auto);
                    client.Authenticate("clientes.desaprendiendo@gmail.com", "pgkgbovrcwqpbuoc");
                    await client.SendAsync(message);
                    client.Disconnect(true);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong: " + ex.Message);

            }

        }
    }
}
