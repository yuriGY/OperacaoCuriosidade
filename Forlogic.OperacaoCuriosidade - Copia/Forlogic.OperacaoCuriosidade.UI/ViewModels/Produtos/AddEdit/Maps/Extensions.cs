using Forlogic.OperacaoCuriosidade.Domain.Entities;

namespace Forlogic.OperacaoCuriosidade.UI.ViewModels.Produtos.AddEdit.Maps
{
    public static class Extensions
    {

        public static ProdutoAddEditVM ToprodutoAddEditVM(this Cadastro model)
        {
            return new ProdutoAddEditVM()
            {

                Id = model.Id,
                Nome = model.Nome,
                Preco = model.Login,
                TipoDeProdutoId = model.TipoDeCadastroId,
                Qtde = model.Senha,
                DataCadastro = model.DataCadastro
            };
        }

        public static Cadastro Toproduto(this ProdutoAddEditVM model)
        {
            return new Cadastro()
            {

                Id = model.Id,
                Nome = model.Nome,
                Login = model.Preco,
                TipoDeCadastroId = model.TipoDeProdutoId,
                Senha = model.Qtde,
                DataCadastro = model.DataCadastro
            };
        }
    }
}
