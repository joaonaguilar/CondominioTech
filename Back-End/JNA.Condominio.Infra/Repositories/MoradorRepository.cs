using JNA.Condominio.Domain.Interfaces;
using JNA.Condominio.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JNA.Condominio.Infra.Repositories
{
    public class MoradorRepository : RepositoryBase<Morador>, IMoradorRepository
    {
        public MoradorRepository(DbContext dbContext) : base(dbContext) { }

    }
}
