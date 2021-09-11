using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SanGabriel_Blazor.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SanGabriel_Blazor.Shared.Psico;

namespace SanGabriel_Blazor.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<SanGabriel_Blazor.Shared.Psico.ValorGrado> ValorGrado { get; set; }
        public DbSet<SanGabriel_Blazor.Shared.Psico.LSB_50> LSB_50 { get; set; }
    }
}
