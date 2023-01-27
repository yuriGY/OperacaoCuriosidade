using Forlogic.OperacaoCuriosidade.Data.EF.Repositories;
using Forlogic.OperacaoCuriosidade.Domain.Contracts.Repositories;
using Forlogic.OperacaoCuriosidade.Domain.Helpers;
using Forlogic.OperacaoCuriosidade.UI.Models;
using System.Web.Mvc;
using System.Web.Security;

namespace Forlogic.OperacaoCuriosidade.UI.Controllers
{
    public class ContaController : Controller
    {
        private readonly ICadastroRepository _cadastroRepository = new CadastroRepositoryEF();

        [HttpGet]
        public ActionResult Login(string returnURL)
        {
            var model = new LoginVM() { ReturnURL = returnURL };
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginVM model)
        {
            var cadastro = _cadastroRepository.Get(model.Email);
            if (cadastro == null)
            {
                ModelState.AddModelError("Email", "O e-mail não foi localizado");
            }
            else
            {
                if (cadastro.Senha != model.Senha.Encrypt())
                {
                    ModelState.AddModelError("Senha", "Senha inválida");
                }
            }

            if (ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(model.Email, model.PermanecerLogado);

                if (!string.IsNullOrEmpty(model.ReturnURL) && Url.IsLocalUrl(model.ReturnURL))
                {
                    return Redirect(model.ReturnURL);
                }
                return RedirectToAction("Index", "Cadastros");
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
        protected override void Dispose(bool disposing)
        {
            _cadastroRepository.Dispose();
        }
    }
}
