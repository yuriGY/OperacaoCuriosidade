using Forlogic.OperacaoCuriosidade.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
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

            Property(c => c.Email)
               .HasColumnName("email")
               .HasColumnType("varchar")
               .HasMaxLength(80)
               .IsRequired()
               .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("UQ_dbo.Cadastro.Email") { IsUnique = true }))
               ;

            Property(c => c.Senha)
                .HasColumnName("senha")
                .HasColumnType("char")
                .HasMaxLength(88)
                .IsRequired();

            Property(c => c.Idade)
                .HasColumnName("idade");

            Property(c => c.Endereco)
                .HasColumnName("Endereco");

            Property(c => c.Outros)
                .HasColumnName("Outros");

            Property(c => c.Interesses)
                .HasColumnName("Interesses");

            Property(c => c.Sentimentos)
                .HasColumnName("Sentimentos");

            Property(c => c.Valores)
                .HasColumnName("Valores");

            Property(c => c.TipoDeCadastroId);

            Property(c => c.DataCadastro);

            HasRequired(prod => prod.TipoDeCadastro)
                .WithMany(tipo => tipo.Cadastros)
                .HasForeignKey(fk => fk.TipoDeCadastroId);

        }
    }   
}
