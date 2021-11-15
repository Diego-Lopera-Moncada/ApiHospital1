using ApiHospital.Controllers.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHospital.Contexts
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }// public ApplicationDbContext

        public DbSet<Paciente> paciente { get; set; }
        public DbSet<Medico> medico { get; set; }
        public DbSet<Cita> cita  { get; set; }

    }
}
