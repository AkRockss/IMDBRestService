using IMDBRestService.Contexts;
using IMDBRestService.Manager;
using IMDBRestService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IMDBRestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IMDBController : ControllerBase
    {
        private readonly IMDBManager _manager;

        public IMDBController(IMDBContext context)
        {
            _manager = new IMDBManager(context);
         
        }

        //NAME BASIC
 
        // GET api/<ValuesController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{nconst}")]
        public ActionResult<NameBasic> GetByNconst(int nconst)
        {
            NameBasic nameBasics = _manager.GetByNconst(nconst);
            if (nameBasics == null) return NotFound("No such item, nconst " + nconst);
            return Ok(nameBasics);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IEnumerable<NameBasic> Post([FromBody] NameBasic value)
        {
            return _manager.Add(new NameBasic() { nconst = value.nconst, primaryName = value.primaryName, birthYear = value.birthYear, 
             deathYear = value.deathYear, primaryProfession = value.primaryProfession, knownForTitles = value.knownForTitles });

        }

        //TITleAkas
        // GET api/<ValuesController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{titleId}")]
        public ActionResult<TitleAkas> GetBytitleId(int titleId)
        {
            TitleAkas titleAkass = _manager.GetByTitleId(titleId);
            if (titleAkass == null) return NotFound("No such item, titleid " + titleId);
            return Ok(titleAkass);
        }



        //// PUT api/<ValuesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ValuesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
