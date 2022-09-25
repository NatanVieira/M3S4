
using BandaTocarDomain.Models;
namespace BandaTocarDomain.Interfaces {

    internal interface IBandaTocarRepository {

        public void CadastrarBandaTocar(BandaTocarModel bandaTocar);
        public BandaTocarModel ObterPorDescricao(string descricao);
    }
}