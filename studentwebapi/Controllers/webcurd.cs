//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using studentwebapi.Controllers;
//using SampleFiles.Model;
//using DataAccessLibrary.Repository;
//using System.Data.SqlClient;
//using Dapper;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace studentwebapi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class webcurd : ControllerBase
//    {

//        studentRepository obj;

//        public webcurd()
//        {

//            obj = new studentRepository();
//        }
//        // GET: api/<webcurd>
//        [HttpGet]
//        public IEnumerable<StudentInformations> Get()
//        {
//            return obj.SelectSP();
//        }

//        // GET api/<webcurd>/5
//        [HttpGet("{entername}")]
//        public List<StudentInformations> Get(string entername)
//        {
//            return obj.SelectInfo(entername);
//        }

//        // POST api/<Controller>
//        [HttpPost]
//        public void Post([FromBody] StudentInformations value)
//        {
//            obj.Insert(value);

//        }

//        // PUT api/<webcurd>/5
//        [HttpPut("{entername}")]
//        public void Put(string entername, [FromBody] StudentInformations value)
//        {
//            value.entername = entername;
//            obj.Update(value);
//        }

//        // DELETE api/<webcurd>/5
//        [HttpDelete("{entername}")]
//        public void Delete(string entername)
//        {
//            obj.Delete(entername);
//        }
//    }

 
//}
