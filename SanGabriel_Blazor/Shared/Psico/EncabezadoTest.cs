using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanGabriel_Blazor.Shared.Psico
{
   public class EncabezadoTest
    {
        [MaxLength(8)]
        public string Dni { get; set; }
        public string NomApe { get; set; }
        public int  Edad { get; set; }
        public DateTime Fecha { get; set; }
    }
}
