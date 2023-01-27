using Forlogic.OperacaoCuriosidade.Domain.Entities;

namespace Forlogic.OperacaoCuriosidade.UI.ViewModels.Cadastros.AddEdit.Maps
{
    public static class Extensions
    {

        public static CadastroAddEditVM TocadastroAddEditVM(this Cadastro model)
        {
            return new CadastroAddEditVM()
            {

                Id = model.Id,
                Nome = model.Nome,
                Email = model.Email,
                Senha = model.Senha,
                Idade = model.Idade,
                Endereco = model.Endereco,
                Outros = model.Outros,
                Interesses = model.Interesses,
                Sentimentos = model.Sentimentos,
                Valores = model.Valores,
                TipoDeCadastroId = model.TipoDeCadastroId,
                DataCadastro = model.DataCadastro
            };
        }

        public static Cadastro Tocadastro(this CadastroAddEditVM model)
        {
            return new Cadastro()
            {

                Id = model.Id,
                Nome = model.Nome,
                Email = model.Email,
                Senha = model.Senha,
                Idade = model.Idade,
                Endereco = model.Endereco,
                Outros = model.Outros,
                Interesses = model.Interesses,
                Sentimentos = model.Sentimentos,
                Valores = model.Valores,
                TipoDeCadastroId = model.TipoDeCadastroId,
                DataCadastro = model.DataCadastro
            };
        }
    }
}
