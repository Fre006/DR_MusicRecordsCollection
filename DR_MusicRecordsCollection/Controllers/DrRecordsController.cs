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

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [Authorize(Roles = "Admin")]
        [HttpGet("Title/{title}")]
        public ActionResult<IEnumerable<Record>> GetByTitle(string title)
        {
            var result = _recordsRepo.GetByTitle(title);
            if (result == null)
            {
                return NoContent();
            }
            else
            {
                return Ok(result);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [Authorize(Roles = "Admin")]
        [HttpGet("Artist/{artist}")]
        public ActionResult<IEnumerable<Record>> GetByArtist(string artist)
        {
            var result = _recordsRepo.GetByArtist(artist);
            if (result == null)
            {
                return NoContent();
            }
            else
            {
                return Ok(result);
            }
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [Authorize(Roles = "Admin")]
        [HttpGet("PublicationYear/{pubYear}")]
        public ActionResult<IEnumerable<Record>> GetByPublication(int pubYear)
        {
            var result = _recordsRepo.GetByPublicationYear(pubYear);
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
