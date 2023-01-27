using Forlogic.OperacaoCuriosidade.Domain.Entities;
using System.Data.Entity;

namespace Forlogic.OperacaoCuriosidade.Data.EF
{
    public class ForlogicOCDataContext : DbContext
    {
        public ForlogicOCDataContext() : base("@CadastroConn")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Cadastro> Cadastros { get; set; }
        public DbSet<TipoDeCadastro> TipoDeCadastros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Maps.CadastroMap());
            modelBuilder.Configurations.Add(new Maps.TipoDeCadastroMap());
        }
    }
}
