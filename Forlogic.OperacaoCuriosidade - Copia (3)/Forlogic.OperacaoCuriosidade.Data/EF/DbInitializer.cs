using Forlogic.OperacaoCuriosidade.Domain.Entities;
using Forlogic.OperacaoCuriosidade.Domain.Helpers;
using System.Collections.Generic;
using System.Data.Entity;

namespace Forlogic.OperacaoCuriosidade.Data.EF
{
    internal class DbInitializer : CreateDatabaseIfNotExists<ForlogicOCDataContext>
    {
        protected override void Seed(ForlogicOCDataContext context)
        {
            var adm = new TipoDeCadastro() { Nome = "Administrador" };
            var cliente = new TipoDeCadastro() { Nome = "Cliente" };

            var cadastros = new List<Cadastro>()
            {
                new Cadastro() {Nome =  "Stephanie Nichols", Email = "stephanienichols@gmail.com", Senha = ")kCfVAB36HG,<GtR".Encrypt(), Idade = 37, Endereco = "", Outros = "", Interesses = "", Sentimentos = "", Valores = "", TipoDeCadastro = cliente},
                new Cadastro() {Nome =  "Jeffrey Kane", Email = "jeffrey_kane@yahoo.com", Senha = "q.E[K@9B^[g'Y7:%".Encrypt(), Idade = 43, Endereco = "", Outros = "", Interesses = "", Sentimentos = "", Valores = "", TipoDeCadastro = cliente},
                new Cadastro() {Nome =  "Darin Miller", Email = "darinmiller01@gmail.com", Senha = "/'>ZL6>zE^NLsM,$Q".Encrypt(), Idade = 34, Endereco = "", Outros = "", Interesses = "", Sentimentos = "", Valores = "", TipoDeCadastro = cliente},
                new Cadastro() {Nome =  "Andrew Stuart", Email = "andrewstuart@outlook.com", Senha = "f+krsg_LV9F}8q&m".Encrypt(), Idade = 25, Endereco = "", Outros = "", Interesses = "", Sentimentos = "", Valores = "", TipoDeCadastro = cliente},
                new Cadastro() {Nome =  "Valerie Aguilar", Email = "valerie_aguiler@gmail.com", Senha = "jeLh9un6vRY@{G//$".Encrypt(), Idade = 29, Endereco = "", Outros = "", Interesses = "", Sentimentos = "", Valores = "", TipoDeCadastro = cliente},
                new Cadastro() {Nome =  "Thomas Wagner", Email = "thomW@gmail.com", Senha = "`9kY?G:Xk+5mp!+'".Encrypt(), Idade = 15, Endereco = "", Outros = "", Interesses = "", Sentimentos = "", Valores = "", TipoDeCadastro = cliente},
                new Cadastro() {Nome =  "Felipe Santos", Email = "felipeSantos@hotmail.com", Senha = "_%V{BgZ6Me>,_(f>".Encrypt(), Idade = 25, Endereco = "", Outros = "", Interesses = "", Sentimentos = "", Valores = "", TipoDeCadastro = cliente},
                new Cadastro() {Nome = "Beatriz Carvalho", Email = "bia.carvalho@gmail.com", Senha = "vTH9]+~(=fZk.Cgb".Encrypt(), Idade = 23, Endereco = "", Outros = "", Interesses = "", Sentimentos = "", Valores = "", TipoDeCadastro = cliente},
                new Cadastro() {Nome = "Ana Clara Torres", Email = "anaCtorres@gmail.com", Senha = "J5SNE'p:We%?U$kc".Encrypt(), Idade = 34, Endereco = "", Outros = "", Interesses = "", Sentimentos = "", Valores = "", TipoDeCadastro = cliente},
                new Cadastro() {Nome = "Matheus Fernandes", Email = "matheus.fernandes@yahoo.com", Senha = "2{r^XdB$Tr.;p2sm".Encrypt(), Idade = 47, Endereco = "", Outros = "", Interesses = "", Sentimentos = "", Valores = "", TipoDeCadastro = cliente},
                new Cadastro() {Nome = "Yuri Yoshida", Email = "yuri.g.yoshida@gmail.com", Senha = "123456".Encrypt(), Idade = 24, Endereco = "", Outros = "", Interesses = "", Sentimentos = "", Valores = "", TipoDeCadastro = adm},

            };
            context.Cadastros.AddRange(cadastros);

            context.SaveChanges();
        }
    }
}
