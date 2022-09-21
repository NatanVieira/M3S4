

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
        {    if(_repository.ObterPorDescricao(bandaTocar.Descricao) == null)
                _repository.CadastrarBandaTocar(new BandaTocarModel(bandaTocar.Descricao, bandaTocar.NomeMusica, bandaTocar.Sequencia));
            else
                throw new Exception("Banda Tocar Já cadastrada.");
        }
    }
}