using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VnApplication.Domain.Entities;

namespace VnApplication.Application.Interfaces.Repositories
{
    public interface IProductRepositoryAsync : IGenericRepositoryAsync<Product>
    {
        Task<bool> IsUniqueBarcodeAsync(string barcode);
    }
}
