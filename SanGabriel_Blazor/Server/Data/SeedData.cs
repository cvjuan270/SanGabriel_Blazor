using SanGabriel_Blazor.Shared.Psico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanGabriel_Blazor.Server.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext db) 
        {
            #region Valores
            var valores =new ValorGrado[]
            {
               new ValorGrado(){ Valor=0,Descripcion="NADA/NUNCA"},
               new ValorGrado(){ Valor=1,Descripcion="POCO"},
               new ValorGrado(){ Valor=2,Descripcion="MODERADAMENTE"},
               new ValorGrado(){ Valor=3,Descripcion="BASTANTE"},
               new ValorGrado(){ Valor=4,Descripcion="MUCHO"}
            };

            db.ValorGrado.AddRange(valores);
            #endregion

            db.SaveChanges();
        }
    }
}
