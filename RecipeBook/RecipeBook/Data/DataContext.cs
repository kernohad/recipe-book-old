using Microsoft.EntityFrameworkCore;

namespace RecipeBook.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            
        }
    }
}
