using Empit.Core.Models;
using Empite.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Empit.Services
{
    public interface IMailService
    {
    
     Task<string>  SendEmailAsync(MailModel mailModel);



    }
}
