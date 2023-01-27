using System;
using System.ComponentModel.DataAnnotations;

namespace Forlogic.OperacaoCuriosidade.UI.ViewModels.Cadastros.AddEdit
{
    public class CadastroAddEditVM
    {
        public CadastroAddEditVM()
        {
            DataCadastro = DateTime.Now;
        }

        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nome { get; set; }

        [Required, StringLength(100)]
        public string Email { get; set; }

        [Required, StringLength(100)]
        public string Senha { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public string Outros { get; set; }
        public string Interesses { get; set; }
        public string Sentimentos { get; set; }
        public string Valores { get; set; }

        [Display(Name = "Tipo de Usuário")]
        public int TipoDeCadastroId { get; set; }

        public DateTime DataCadastro { get; set; }

    }
}
