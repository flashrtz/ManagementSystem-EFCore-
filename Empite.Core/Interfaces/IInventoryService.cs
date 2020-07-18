using Empit.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Empite.Core.Interfaces
{
    public interface IInventoryService
    {

        Task<InventoryModel> GetInventoryById(string id);
        Task<IReadOnlyList<InventoryModel>> GetAllInventory();
        Task Insert(InventoryModel inventoryModel);
        Task Update(InventoryModel inventoryModel);
        Task Delete(string id);
    }
}
