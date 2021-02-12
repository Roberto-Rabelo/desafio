using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using desafio.Data;
using desafio.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace desafio.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value"; 
        }

        // POST api/<ValuesController>
        [HttpPost]
        [Consumes("application/json")]
        public async Task<ActionResult<covid19>> Post([FromServices] ApplicationDbContext context, [FromBody] covid19 model)
        {
            var listacovid = new List<covid19>();
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR", false);
            if (ModelState.IsValid)
            {
                listacovid.Add(model.id);
                listacovid.Add(model.country);
                listacovid.Add(model.countryCode);
                listacovid.Add(model.totalcomfirmed); 
                listacovid.Add(model.TotalDeaths);
                listacovid.Add(model.totalrecovered);
                listacovid.Add(model.newConfirmed);
                listacovid.Add(model.Date)


            }
            listacovid.Take(10).OrderBy();

            return ViewResult("listaRank",listacovid);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
