using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Negrea_Georgiana_Lab12.Models;


namespace Negrea_Georgiana_Lab12.Data
{
    interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
