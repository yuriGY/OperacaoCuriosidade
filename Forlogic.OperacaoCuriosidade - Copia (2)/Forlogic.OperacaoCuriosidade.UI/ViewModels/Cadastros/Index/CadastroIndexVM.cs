using System;

namespace Forlogic.OperacaoCuriosidade.UI.ViewModels.Cadastros.Index
{
    public class CadastroIndexVM
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public string Outros { get; set; }
        public string Interesses { get; set; }
        public string Sentimentos { get; set; }
        public string Valores { get; set; }
        public string Tipo { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;

    }
}
