using Empit.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Empite.Core.Interfaces
{
    public interface IUserManagementService
    {
        Task<UserManagementModel> GetUserById(string id);
        Task<IReadOnlyList<UserManagementModel>> GetAllUsers();
        Task Insert(UserManagementModel userManagementModel);
        Task Update(UserManagementModel userManagementModel);
        Task Delete(string id);
      
    }
}
