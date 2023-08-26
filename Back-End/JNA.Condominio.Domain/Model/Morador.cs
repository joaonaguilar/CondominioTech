using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JNA.Condominio.Domain.Model
{
    public class Morador
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
    }

    public enum Sexo
    {
        Masculino,
        Feminino,
        Outro
    }

    public enum EstadoCivil
    {
        Solteiro,
        Casado,
        Divorciado,
        Viuvo
    }
}
