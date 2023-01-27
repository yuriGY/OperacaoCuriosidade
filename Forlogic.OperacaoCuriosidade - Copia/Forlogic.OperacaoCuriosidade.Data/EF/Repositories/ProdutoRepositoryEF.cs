﻿using Forlogic.OperacaoCuriosidade.Domain.Contracts.Repositories;
using Forlogic.OperacaoCuriosidade.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Forlogic.OperacaoCuriosidade.Data.EF.Repositories
{
    public class ProdutoRepositoryEF : RepositoryEF<Cadastro>, ICadastroRepository
    {
        public IEnumerable<Cadastro> GetByNameContains(string contains)
        {
            return _ctx.Cadastros.Where(p => p.Nome.Contains(contains));
        }
    }
}
