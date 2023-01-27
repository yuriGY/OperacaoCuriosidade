using Forlogic.OperacaoCuriosidade.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Forlogic.OperacaoCuriosidade.Data.EF.Maps
{
    public class TipoDeCadastroMap : EntityTypeConfiguration<TipoDeCadastro>
    {
        public TipoDeCadastroMap()
        {

            ToTable(nameof(TipoDeCadastro));

            HasKey(pk => pk.Id);

            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.DataCadastro);
        }
    }
}
