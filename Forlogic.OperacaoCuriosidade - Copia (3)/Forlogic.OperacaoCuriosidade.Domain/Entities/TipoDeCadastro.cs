using System.Collections.Generic;

namespace Forlogic.OperacaoCuriosidade.Domain.Entities
{
    public class TipoDeCadastro : Entity
    {
        public string Nome { get; set; }

        public virtual ICollection<Cadastro> Cadastros { get; set; }
    }
}
