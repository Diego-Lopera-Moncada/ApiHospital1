using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHospital.Controllers.Entities
{
    public class Cita
    {

        [Key]
        public int IdPaciente { get; set; }
        public int NroDocumento { get; set; }
        public string NomPaciente { get; set; }
        public string DirPaciente { get; set; }
        public int TelPaciente { get; set; }
        public int CelPaciente { get; set; }
        public byte Activo { get; set; }

    }
}
