using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace studentwebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class webcurd : ControllerBase
    {
        webcurd obj;

        // GET: RegistrationController
        public webcurd()
        {

            obj = new webcurd();
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<webcurd> Get()
        {
            return obj.GetAllRegistration();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{Empid}")]
        public string Get(int Empid)
        {
            return "value";
        }

        // POST api/<Controller>
        [HttpPost]
        public void Post([FromBody] webcurd value)
        {
            obj.Insert(value);

        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{Empid}")]
        public void Put(int Empid, [FromBody] webcurd value)
        {
            obj.Insert(value);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{Empid}")]
        public void Delete(int Empid)
        {
            obj.Delete(Empid);
        }
    }
}
