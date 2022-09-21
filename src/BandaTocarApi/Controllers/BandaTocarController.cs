
using BandaTocarDomain.DTOs;
using BandaTocarDomain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BandaTocarApi.Controllers {

    [ApiController]
    [Route("[controller]")]

    public class BandaTocarController : ControllerBase {

        private readonly IBandaTocarService _service;

        public BandaTocarController(IBandaTocarService service){
            _service = service;
        }
        [HttpPost]
        public ActionResult<BandaTocarDTO> Post([FromBody] BandaTocarDTO bandaTocar){
            try{
                _service.CadastrarBandaTocar(bandaTocar);
                return Ok(bandaTocar);
            }
            catch{
                return StatusCode(500);
            }
        }
    }
}