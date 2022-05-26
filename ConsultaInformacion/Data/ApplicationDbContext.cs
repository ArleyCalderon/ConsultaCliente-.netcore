using ConsultaInformacion.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
namespace ConsultaInformacion.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Propietario> propietario { get; set; }
        public DbSet<Vehiculo> vehiculo { get; set; }

    }
}
