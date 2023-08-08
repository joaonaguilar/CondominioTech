using JNA.Condominio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JNA.Condominio.Domain.Interfaces
{
    public interface IMoradorService
    {
        Morador CriarMorador(string cpf, string nome);
        Morador ObterMoradorPorId(int moradorId);
        void AtualizarMorador(int moradorId, string novoNome);
        void ExcluirMorador(int moradorId);
    }
}
