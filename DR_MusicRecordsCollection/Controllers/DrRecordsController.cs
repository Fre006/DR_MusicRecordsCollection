using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DR_MusicRecordsCollection.Models;
using DR_MusicRecordsCollection.Repos;
using DR_MusicRecordsCollection.Repos.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace DR_MusicRecordsCollection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class DrRecordsController : ControllerBase
    {
        private RecordsRepo _recordsRepo;

        public DrRecordsController(RecordsRepo repo)
        {
            _recordsRepo = repo;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [Authorize(Roles ="Admin")]
        [HttpGet]
        public ActionResult<IEnumerable<Record>> GetAll()
        {
            var result =_recordsRepo.GetAll();
            if (result == null)
            {
                return NoContent();
            }
            else
            {
                return Ok(result);
            }
        }
        

    }
}
