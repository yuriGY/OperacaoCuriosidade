using Forlogic.OperacaoCuriosidade.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Forlogic.OperacaoCuriosidade.UI.ViewModels.Produtos.Index.Maps
{
    public static class Extensions
    {

        public static IEnumerable<ProdutoIndexVM> ToProdutoIndexVM(this IEnumerable<Cadastro> data)
        {
            return data.Select(p => new ProdutoIndexVM()
            {
                Id = p.Id,
                Nome = p.Nome,
                Preco = p.Login,
                Tipo = p.TipoDeCadastro.Nome,
                Qtde = p.Senha,
                DataCadastro = p.DataCadastro
            });
        }
    }
}
