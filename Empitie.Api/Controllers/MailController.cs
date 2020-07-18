using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Empit.Core.Models;
using Empite.Core.Interfaces;
using Empit.Services;

namespace Empit.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {

    private readonly IMailService mailService;

        public MailController(IMailService mailService)
        {
            this.mailService = mailService;
        }

          
        [HttpPost]   
        [Route("SendMail")]
        public async Task<string> SendEmailAsync([FromBody] MailModel mailmodel)
        {
            return await mailService.SendEmailAsync(mailmodel);
           // return await
        }

     
       


    }
}
