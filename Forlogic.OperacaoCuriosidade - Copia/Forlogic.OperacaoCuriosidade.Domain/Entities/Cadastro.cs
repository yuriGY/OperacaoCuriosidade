namespace Forlogic.OperacaoCuriosidade.Domain.Entities
{
    public class Cadastro : Entity
    {
        public string Nome { get; set; }
        public string Login { get; set; }

        public string Senha { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public string Outros { get; set; }
        public string Interesses { get; set; }
        public string Sentimentos { get; set; }
        public string Valores { get; set; }

        public int TipoDeCadastroId { get; set; }
        public virtual TipoDeCadastro TipoDeCadastro { get; set; }
    }
}
