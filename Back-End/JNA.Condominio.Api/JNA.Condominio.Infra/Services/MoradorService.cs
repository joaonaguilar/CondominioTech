using JNA.Condominio.Domain.Interfaces;
using JNA.Condominio.Domain.Models;
using JNA.Condominio.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JNA.Condominio.Infra.Services
{
    public class MoradorService : IMoradorService
    {
        private readonly IRepository<Morador> _moradorRepository;

        public MoradorService(IRepository<Morador> moradorRepository)
        {
            _moradorRepository = moradorRepository;
        }

        public Morador CriarMorador(string cpf, string nome)
        {
            Morador novoMorador = new Morador
            {
                Cpf = cpf,
                Nome = nome
            };

            return _moradorRepository.Incluir(novoMorador);
        }

        public Morador ObterMoradorPorId(int moradorId)
        {
            return _moradorRepository.RecuperarPorId(moradorId);
        }

        public void AtualizarMorador(int moradorId, string novoNome)
        {
            Morador moradorExistente = _moradorRepository.RecuperarPorId(moradorId);

            if (moradorExistente != null)
            {
                moradorExistente.Nome = novoNome;
                _moradorRepository.Atualizar(moradorExistente);
            }
        }

        public void ExcluirMorador(int moradorId)
        {
            Morador moradorExistente = _moradorRepository.RecuperarPorId(moradorId);

            if (moradorExistente != null)
            {
                _moradorRepository.Deletar(moradorExistente);
            }
        }
    }
}
