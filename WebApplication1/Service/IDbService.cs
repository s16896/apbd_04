using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task04.Models;

namespace Task04.Services
{
    public interface IDbService
    {
        Task<int> AddProductToWarehouseAsync(ProductWarehouse productWarehouse);
    }
}