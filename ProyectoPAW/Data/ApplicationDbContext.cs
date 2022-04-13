using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoPAW2.Models;

namespace ProyectoPAW.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProyectoPAW2.Models.Cliente> Cliente { get; set; }
        public DbSet<ProyectoPAW2.Models.Empleado> Empleado { get; set; }
        public DbSet<ProyectoPAW2.Models.Producto> Producto { get; set; }
        public DbSet<ProyectoPAW2.Models.Proveedor> Proveedor { get; set; }
    }
}