using Microsoft.EntityFrameworkCore;
using _18_Crud_Bd.Models;

namespace _18_Crud_Bd.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){

        }

        //No meu DbSet carregará todos os jogos salvos no banco de dados 
        public DbSet<Jogo> Jogos {get; set;}

        
        
    }
}