using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.SistemaRH.Infra.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<SQLServerContext>
    {
        public SQLServerContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SQLServerContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-QGH12DH;Database=SistemaRH;User Id=sa;Password=admin;TrustServerCertificate=True;Encrypt=False;");

            return new SQLServerContext(optionsBuilder.Options);
        }
    }
}
