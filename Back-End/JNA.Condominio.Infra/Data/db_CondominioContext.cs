using JNA.Condominio.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JNA.Condominio.Infra.Data
{
    public class db_CondominioContext : DbContext
    {
        public DbSet<Morador> Morador { get; set; }

        public db_CondominioContext(DbContextOptions<db_CondominioContext> options)
            : base(options)
        {}
    }
}
