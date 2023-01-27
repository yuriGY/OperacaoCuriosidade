using Forlogic.OperacaoCuriosidade.Data.EF.Repositories;
using Forlogic.OperacaoCuriosidade.Domain.Contracts.Repositories;
using Forlogic.OperacaoCuriosidade.UI.ViewModels.Produtos.AddEdit;
using Forlogic.OperacaoCuriosidade.UI.ViewModels.Produtos.AddEdit.Maps;
using Forlogic.OperacaoCuriosidade.UI.ViewModels.Produtos.Index.Maps;
using System.Web.Mvc;

namespace Forlogic.OperacaoCuriosidade.UI.Controllers
{
    [Authorize]
    public class ProdutosController : Controller
    {
        private readonly ICadastroRepository _produtoRepository = new ProdutoRepositoryEF();
        private readonly ITipoDeCadastroRepository _tipoDeProdutoRepository = new TipoDeProdutoRepositoryEF();

        public ViewResult Index()
        {
            var produtos = _produtoRepository.Get().ToProdutoIndexVM();
            return View(produtos);
        }

        [HttpGet]
        public ViewResult AddEdit(int? id)
        {
            var produto = new ProdutoAddEditVM();

            if (id != null)
            {
                produto = _produtoRepository.Get((int)id).ToprodutoAddEditVM();
            }

            var tipos = _tipoDeProdutoRepository.Get();
            ViewBag.Tipos = tipos;
            return View(produto);
        }

        [HttpPost]
        public ActionResult AddEdit(ProdutoAddEditVM produtoVM)
        {
            var produto = produtoVM.Toproduto();

            if (ModelState.IsValid)
            {
                if (produto.Id == 0)
                {
                    _produtoRepository.Add(produto);
                }
                else
                {
                    _produtoRepository.Edit(produto);
                }

                return RedirectToAction("Index");
            }

            var tipos = _produtoRepository.Get();
            ViewBag.Tipos = tipos;

            return View(produto);
        }

        public ActionResult DelProd(int id)
        {
            var produto = _produtoRepository.Get(id);
            if (produto == null)
            {
                return HttpNotFound();
            }

            _produtoRepository.Delete(produto);

            return null;
        }

        protected override void Dispose(bool disposing)
        {
            _produtoRepository.Dispose();
            _tipoDeProdutoRepository.Dispose();
        }
    }
}
