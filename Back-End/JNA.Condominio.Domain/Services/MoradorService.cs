using JNA.Condominio.Domain.Interfaces;

namespace JNA.Condominio.Domain.Services
{
    public class MoradorService
    {
        private readonly IMoradorRepository _moradorRepository;

        public MoradorService(IMoradorRepository moradorRepository)
        {
            _moradorRepository = moradorRepository;
        }

        //public Morador GetById(int id)
        //{
        //    return _moradorRepository.GetById(id);
        //}

        //public IEnumerable<Morador> GetAll()
        //{
        //    return _moradorRepository.GetAll();
        //}

        //public Morador Add(Morador entity)
        //{
        //    // Implemente validações ou lógica adicional antes de adicionar
        //    return _moradorRepository.Add(entity);
        //}

        //public void Update(Morador entity)
        //{
        //    // Implemente validações ou lógica adicional antes de atualizar
        //    _moradorRepository.Update(entity);
        //}

        //public void Remove(Morador entity)
        //{
        //    // Implemente validações ou lógica adicional antes de remover
        //    _moradorRepository.Remove(entity);
        //}
    }
}
