using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanGabriel_Blazor.Shared.Psico
{
    public class ValorGrado
    {
        [Key]
        public int IdValorGrado { get; set; }
        public int Valor { get; set; }
        public string Descripcion { get; set; }
    }
}
