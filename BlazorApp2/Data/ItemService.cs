using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Data
{
    public class ItemService
    {
        private StudentContext dbContext;

        public ItemService(StudentContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Item>> GetAllItemAsync()
        {
            return await dbContext.Item.ToListAsync();
        }


        public async Task<Item> AddItemAsync(Item item)
        {
            dbContext.Item.Add(item);
            await dbContext.SaveChangesAsync();

            return item;
        }
        public async Task<Item> GetItemAsync(int id)
        {
            var item = await dbContext.Item.FirstOrDefaultAsync(c => c.Id == id);
            await dbContext.SaveChangesAsync();

            return item;
        }


        public async Task<bool> UpdateItemAsync(Item item)
        {
            dbContext.Item.Update(item);
            await dbContext.SaveChangesAsync();
            
            return true;
        }


        public async Task<bool> DeleteItemAsync(Item item)
        {

            dbContext.Item.Remove(item);
            await dbContext.SaveChangesAsync();
            return true;
        }
    }
}
