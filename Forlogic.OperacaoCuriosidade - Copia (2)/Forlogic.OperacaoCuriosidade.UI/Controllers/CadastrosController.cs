using Forlogic.OperacaoCuriosidade.Data.EF.Repositories;
using Forlogic.OperacaoCuriosidade.Domain.Contracts.Repositories;
using Forlogic.OperacaoCuriosidade.UI.ViewModels.Cadastros.AddEdit;
using Forlogic.OperacaoCuriosidade.UI.ViewModels.Cadastros.AddEdit.Maps;
using Forlogic.OperacaoCuriosidade.UI.ViewModels.Cadastros.Index.Maps;
using System.Web.Mvc;

namespace Forlogic.OperacaoCuriosidade.UI.Controllers
{
    [Authorize]
    public class CadastrosController : Controller
    {
        private readonly ICadastroRepository _cadastroRepository = new CadastroRepositoryEF();
        private readonly ITipoDeCadastroRepository _tipoDeCadastroRepository = new TipoDeCadastroRepositoryEF();

        public ViewResult Index()
        {
            var cadastros = _cadastroRepository.Get().ToCadastroIndexVM();
            return View(cadastros);
        }

        [HttpGet]
        /*public ActionResult Index(string BuscaCad)
        {
            ViewData["GetDetalhesCadastro"] = BuscaCad;
            //var cadquery = from x in _db.Cadastros select x;
            return View();
        }*/
        public ViewResult AddEdit(int? id)
        {
            var cadastro = new CadastroAddEditVM();

            if (id != null)
            {
                cadastro = _cadastroRepository.Get((int)id).TocadastroAddEditVM();
            }

            var tipos = _tipoDeCadastroRepository.Get();
            ViewBag.Tipos = tipos;
            return View(cadastro);
        }

        [HttpPost]
        public ActionResult AddEdit(CadastroAddEditVM cadastroVM)
        {
            var cadastro = cadastroVM.Tocadastro();

            if (ModelState.IsValid)
            {
                if (cadastro.Id == 0)
                {
                    _cadastroRepository.Add(cadastro);
                }
                else
                {
                    _cadastroRepository.Edit(cadastro);
                }

                return RedirectToAction("Index");
            }

            var tipos = _cadastroRepository.Get();
            ViewBag.Tipos = tipos;

            return View(cadastro);
        }

        public ActionResult Detalhes(int id)
        {
            var cadastro = _cadastroRepository.Get(id);
            if (cadastro == null)
            {
                return HttpNotFound();
            }

            
            return View();
        }

        public ActionResult DelCad(int id)
        {
            var cadastro = _cadastroRepository.Get(id);
            if (cadastro == null)
            {
                return HttpNotFound();
            }

            _cadastroRepository.Delete(cadastro);

            return null;
        }

        protected override void Dispose(bool disposing)
        {
            _cadastroRepository.Dispose();
            _tipoDeCadastroRepository.Dispose();
        }
    }
}
