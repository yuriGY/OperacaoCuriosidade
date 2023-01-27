using Forlogic.OperacaoCuriosidade.Domain.Entities;

namespace Forlogic.OperacaoCuriosidade.Domain.Contracts.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Usuario Get(string email);
    }
}
