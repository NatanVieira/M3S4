

using BandaTocarDomain.DTOs;
using BandaTocarDomain.Interfaces;
using BandaTocarDomain.Models;

namespace BandaTocarDomain.Services {

    public class BandaTocarService : IBandaTocarService
    {
        private readonly IBandaTocarRepository _repository;

        public BandaTocarService (IBandaTocarRepository repository){
            _repository = repository;
        }
        public void CadastrarBandaTocar(BandaTocarDTO bandaTocar)
        {
            _repository.CadastrarBandaTocar(new BandaTocarModel(bandaTocar.Descricao, bandaTocar.NomeMusica, bandaTocar.Sequencia));
        }
    }
}