

namespace BandaTocarApi.DTOs{

    public class BandaTocarDTO {

        public string Descricao { get; set; }
        public string NomeMusica { get; set; }
        public int Sequencia { get; set; }

        public BandaTocarDTO(){}

        public BandaTocarDTO(string descricao, string nomeMusica, int sequencia){
            Descricao = descricao;
            NomeMusica = nomeMusica;
            Sequencia = sequencia;
        }
    }
}