using Forlogic.OperacaoCuriosidade.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Forlogic.OperacaoCuriosidade.Data.EF.Maps
{
    public class CadastroMap : EntityTypeConfiguration<Cadastro>
    {
        public CadastroMap()
        {
            ToTable(nameof(Cadastro));

            HasKey(pk => pk.Id);

            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.Login)
                .HasColumnType("money");

            Property(c => c.Senha)
                .HasColumnName("Quantidade");

            Property(c => c.TipoDeCadastroId);

            Property(c => c.DataCadastro);

            HasRequired(prod => prod.TipoDeCadastro)
                .WithMany(tipo => tipo.Cadastros)
                .HasForeignKey(fk => fk.TipoDeCadastroId);

        }
    }   
}
