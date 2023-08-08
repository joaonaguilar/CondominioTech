using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JNA.Condominio.Domain.Models
{
    public class Morador
    {
        public Guid Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
    }
}
