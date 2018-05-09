using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculateService.Models;
using Microsoft.AspNetCore.Cors;

namespace CalculateService.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [EnableCors("AllowAnyOrigin")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            Calculation toReturn;

            if (id.Length > 0)
            {
                toReturn = new Calculation(getList(id));

                toReturn.Calculate();
            }
            else
            {
                toReturn = new Calculation();
            }
            return Ok(toReturn);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private List<int> getList(string toGet)
        {
            int mos = 0;
            var intList = toGet.Split(',')
                    .Select(m => { int.TryParse(m, out mos); return mos; })
                    .Where(m => m != 0)
                    .ToList();

            return intList;
        }
    }
}
