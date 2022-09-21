
using BandaTocarApi.DTOs;
using BandaTocarApi.Models;
using BandaTocarApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BandaTocarApi.Controllers {

    [ApiController]
    [Route("[controller]")]

    public class BandaTocarController : ControllerBase {

        private readonly BandaTocarDbContext _context;

        public BandaTocarController(BandaTocarDbContext context){
            _context = context;
        }
        [HttpPost]
        public ActionResult<BandaTocarDTO> Post([FromBody] BandaTocarDTO bandaTocar){
            try{
                BandaTocarModel banda = new BandaTocarModel(bandaTocar.Descricao, bandaTocar.NomeMusica, bandaTocar.Sequencia);
                _context.BandaTocar.Add(banda);
                _context.SaveChanges();
                return Ok(bandaTocar);
            }
            catch{
                return StatusCode(500);
            }
        }
    }
}