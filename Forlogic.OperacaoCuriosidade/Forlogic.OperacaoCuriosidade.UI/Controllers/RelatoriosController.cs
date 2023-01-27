using Forlogic.OperacaoCuriosidade.Data.EF.Repositories;
using Forlogic.OperacaoCuriosidade.Domain.Contracts.Repositories;
using Forlogic.OperacaoCuriosidade.UI.ViewModels.Cadastros.Index.Maps;
using System.Web.Mvc;

namespace Forlogic.OperacaoCuriosidade.UI.Controllers
{

    public class RelatoriosController : Controller
    {
        private readonly ICadastroRepository _cadastroRepository = new CadastroRepositoryEF();

        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Emails()
        {
            var cadastros = _cadastroRepository.Get().ToCadastroIndexVM();
            return View(cadastros);
            
        }
    }
}
