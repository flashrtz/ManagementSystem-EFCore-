using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Empit.Core.Models;
using Empite.Core.Interfaces;

namespace Empit.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {

    private readonly IInventoryService inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            this.inventoryService = inventoryService;
        }

          [HttpGet]
        [Route("GetUserById")]
        public async Task<InventoryModel> GetUserById(string id)
        { 
            return await inventoryService.GetInventoryById(id);
        }

        [HttpGet]
        [Route("GetAllInventory")]
        public async Task<IReadOnlyList<InventoryModel>> GetAllUsers()
        {
            return await inventoryService.GetAllInventory();
        }

        [HttpPost]
        [Route("Insert")]
        public async Task Insert(InventoryModel inventoryModel)
        {
             await inventoryService.Insert(inventoryModel);
        }

        [HttpPost]
        [Route("Update")]
        public async Task Update(InventoryModel inventoryModdel)
        {
             await inventoryService.Update(inventoryModdel);
        }
        
        [HttpPost]
        [Route("Delete")]
        public async Task Delete(string id)
        {
             await inventoryService.Delete(id);
        }

       


    }
}
