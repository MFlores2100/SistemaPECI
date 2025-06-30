using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SistemaPECI.Data.Context;

namespace SistemaPECI.Data.Context
{
    public class DBContextFactory : IDesignTimeDbContextFactory<DBContext>
    {
        public DBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DBContext>();
            optionsBuilder.UseSqlite("Data Source=Data/BaseDatosPECI.db");
            return new DBContext(optionsBuilder.Options);
        }
    }
}
