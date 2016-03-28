using Rangamo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rangamo.DAL
{
    interface IRangamoRepository:IDisposable
    {
        IEnumerable<InventoryItems> GetInventories();
        InventoryItems GetInventoryById(int inventoryId);
        void InsertInventory(InventoryItems inventory);
        void DeleteInventory(int inventoryId);
        void UpdateInventory(InventoryItems inventory);
        void ItemSave();
        IEnumerable<Product> GetProducts();
        Product GetProductById(int productId);
        void InsertProduct(Product product);
        void DeleteProduct(int productId);
        void UpdateProduct(Product product);
        void ProductSave();
    }
}
