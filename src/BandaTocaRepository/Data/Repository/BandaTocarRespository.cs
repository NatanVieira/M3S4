

using BandaTocarDomain.Interfaces;
using BandaTocarDomain.Models;

namespace BandaTocaRepository.Data.Repository {


    public class BandaTocarRepository : IBandaTocarRepository
    {
        private readonly BandaTocarDbContext _context;
        
        public BandaTocarRepository(BandaTocarDbContext context){
            _context = context;
        }
        public void CadastrarBandaTocar(BandaTocarModel bandaTocar)
        {
            _context.BandaTocar.Add(bandaTocar);
        }

        public BandaTocarModel ObterPorDescricao(string descricao)
        {
            return _context.BandaTocar.FirstOrDefault(bt => bt.Descricao == descricao);
        }
    }
}