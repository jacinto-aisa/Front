using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desaprendiendo.Services.Mail
{
    public interface IEMail
    {
        Task SendEmailAsync(string message);
    }
}
