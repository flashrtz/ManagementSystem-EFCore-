using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Empit.Core.Models;
using Empite.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Empit.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserManagementController : ControllerBase
    {
        private readonly IUserManagementService userManagementService;

        public UserManagementController(IUserManagementService userManagementService)
        {
            this.userManagementService = userManagementService;
        }

        [HttpGet]
        [Route("GetUserById")]
        public async Task<UserManagementModel> GetUserById(string id)
        { 
            return await userManagementService.GetUserById(id);
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public async Task<IReadOnlyList<UserManagementModel>> GetAllUsers()
        {
            return await userManagementService.GetAllUsers();
        }

        [HttpPost]
        [Route("Insert")]
        public async Task Insert(UserManagementModel userManagementModel)
        {
             await userManagementService.Insert(userManagementModel);
        }

        [HttpPost]
        [Route("Update")]
        public async Task Update(UserManagementModel userManagementModel)
        {
             await userManagementService.Update(userManagementModel);
        }
        [HttpPost]
        [Route("Delete")]
        public async Task Delete(string id)
        {
             await userManagementService.Delete(id);
        }

       

    }
}
