using Forlogic.OperacaoCuriosidade.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Forlogic.OperacaoCuriosidade.UI.ViewModels.Cadastros.Index.Maps
{
    public static class Extensions
    {
        public static IEnumerable<CadastroIndexVM> ToCadastroIndexVM(this IEnumerable<Cadastro> data)
        {
            return data.Select(p => new CadastroIndexVM()
            {
                Id = p.Id,
                Nome = p.Nome,
                Email = p.Email,
                Senha = p.Senha,
                Idade = p.Idade,
                Endereco = p.Endereco,
                Outros = p.Outros,
                Interesses = p.Interesses,
                Sentimentos = p.Sentimentos,
                Valores = p.Valores,
                Tipo = p.TipoDeCadastro.Nome,
                DataCadastro = p.DataCadastro
            });
        }
    }
}
