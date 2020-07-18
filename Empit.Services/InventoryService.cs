using Empit.Core.Models;
using Empit.Data;
using Empite.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Empit.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly ApplicationDbContext context;

        public InventoryService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IReadOnlyList<InventoryModel>> GetAllInventory()
        {
            return await context.Inventory.ToListAsync();
        }
        public async Task<InventoryModel> GetInventoryById(string id)
        {
            return await context.Inventory.FirstOrDefaultAsync(u => u.Id == Convert.ToInt32(id));
        }


        public async Task Insert(InventoryModel inventoryModel)
        {
            await context.Inventory.AddAsync(inventoryModel);
            await context.SaveChangesAsync(); 
        }

         public async Task Update(InventoryModel inventoryModdel)
        {
            context.Update(inventoryModdel);
            await context.SaveChangesAsync();
        }

          public async Task Delete(string id)
        {
            var item = await context.Inventory.FirstOrDefaultAsync(u => u.Id == Convert.ToInt32(id));
              context.Inventory.Remove(item);
              await context.SaveChangesAsync();
            
        }
      

    }
}
