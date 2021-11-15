using ApiHospital.Contexts;
using ApiHospital.Controllers.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiHospital.Controllers
{
    [Route("api/[controller]")]
    public class PacienteController : Controller
    {
        public ApplicationDbContext Context { get; }

        public PacienteController(ApplicationDbContext Context)
        {
            this.Context = Context;
        }


        // GET: api/<PacienteController>
        [HttpGet]
        public IEnumerable<Paciente> Get()
        {
            return Context.paciente.ToList();
        }

        // GET api/<PacienteController>/5
        [HttpGet("{id}")]
        public Paciente Get(int id)
        {
            var paciente = Context.paciente.FirstOrDefault(p=>p.IdPaciente==id);
            return paciente;
        }

        // POST api/<PacienteController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PacienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PacienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
