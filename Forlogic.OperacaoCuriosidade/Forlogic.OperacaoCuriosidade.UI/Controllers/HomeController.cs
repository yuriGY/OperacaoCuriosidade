using Forlogic.OperacaoCuriosidade.Data.EF.Repositories;
using Forlogic.OperacaoCuriosidade.Domain.Contracts.Repositories;
using Forlogic.OperacaoCuriosidade.UI.ViewModels.Cadastros.Index.Maps;
using System.Web.Mvc;

namespace Forlogic.OperacaoCuriosidade.UI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ICadastroRepository _cadastroRepository = new CadastroRepositoryEF();

        public ViewResult Index()
        {
            var cadastros = _cadastroRepository.Get().ToCadastroIndexVM();
            return View(cadastros);
        }

        [HttpPost]
        public ActionResult Index(string BuscaCad)
        {
            ViewData["GetDetalhesCadastro"] = BuscaCad;

            var result = _cadastroRepository.GetByNameContains(BuscaCad).ToCadastroIndexVM();

            return View(result);
        }

        public ActionResult Detalhes(int? id)
        {
            var cadastro = _cadastroRepository.Get((int)id);
            if (cadastro == null)
            {
                return HttpNotFound();
            }

            return View("Detalhes", cadastro);
        }

        public ViewResult Relatorios()
        {
            return View();
        }
    }
}
