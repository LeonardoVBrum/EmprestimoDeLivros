using EmprestimoLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.Data
{
    public class ApplicationDbContext : DbContext

    {
        //CONSTRUTOR QUE PEGA AS OPTIONS DO DBCONTEXT
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }

        // CRIAR TABELA NO BANCO
        public DbSet<EmprestimosModel> Emprestimos { get; set; }
    }
}
