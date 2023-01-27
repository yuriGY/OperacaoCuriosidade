using Forlogic.OperacaoCuriosidade.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Forlogic.OperacaoCuriosidade.Domain.Contracts.Repositories
{
    public interface ICadastroRepository : IRepository<Cadastro>
    {

        IEnumerable<Cadastro> GetByNameContains(String contains);
        Cadastro Get(string email);
    }
}
