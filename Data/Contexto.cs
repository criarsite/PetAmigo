using LovePet.Models;
using Microsoft.EntityFrameworkCore;

namespace LovePet.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        { }

        public DbSet<Animal> Animais { get; set; }
    }
}