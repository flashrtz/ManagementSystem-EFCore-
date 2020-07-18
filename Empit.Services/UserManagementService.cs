using Empit.Core.Models;
using Empit.Data;
using Empite.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empit.Services
{
    public class UserManagementService : IUserManagementService
    {
        private readonly ApplicationDbContext context;

        public UserManagementService(ApplicationDbContext context)
        {
            this.context = context;
        }


        public async Task<IReadOnlyList<UserManagementModel>> GetAllUsers()
        {
            return await context.User.ToListAsync();
        }
        public async Task<UserManagementModel> GetUserById(string id)
        {
            return await context.User.FirstOrDefaultAsync(u => u.Id == Convert.ToInt32(id));
        }


        public async Task Insert(UserManagementModel userManagementModel)
        {
            await context.User.AddAsync(userManagementModel);
            await context.SaveChangesAsync();
        }


        public async Task Update(UserManagementModel userManagementModel)
        {
            context.Update(userManagementModel);
            context.SaveChanges();
        }

         public async Task Delete(string id)
        {
            var movie = await context.User.FirstOrDefaultAsync(u => u.Id == Convert.ToInt32(id));
              context.User.Remove(movie);
              await context.SaveChangesAsync();
            
        }
      

    }
}
