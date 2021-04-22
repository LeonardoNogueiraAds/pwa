using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace WebApplicationBuffet.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext>options)
        :base (options)
        {
            
        }
    }
}