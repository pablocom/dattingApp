using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        // necesitamos crear una instancia de DB context options para funcionar
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }
        // esto es para decirle a la base de datos el modelo que vamos a guardar
        // el nombre que le pongamos va a ser el nombre con el que se cree la tabla sql
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}