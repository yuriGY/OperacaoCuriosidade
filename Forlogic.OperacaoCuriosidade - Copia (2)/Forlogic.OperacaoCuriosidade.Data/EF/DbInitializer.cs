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
            new Cadastro() {Nome =  "Thomas Wagner", Email = "thomW@gmail.com", Senha = "`9kY?G:Xk+5mp!+'".Encrypt(), Idade = 15, Endereco = "", Outros = "", Interesses = "", Sentimentos = "", Valores = "", TipoDeCadastro = cliente},
            new Cadastro() {Nome =  "Felipe Santos", Email = "felipeSantos@hotmail.com", Senha = "_%V{BgZ6Me>,_(f>".Encrypt(), Idade = 25, Endereco = "", Outros = "", Interesses = "", Sentimentos = "", Valores = "", TipoDeCadastro = cliente},
            new Cadastro() {Nome = "Beatriz Carvalho", Email = "bia.carvalho@gmail.com", Senha = "vTH9]+~(=fZk.Cgb".Encrypt(), Idade = 23, Endereco = "", Outros = "", Interesses = "", Sentimentos = "", Valores = "", TipoDeCadastro = cliente},
            new Cadastro() {Nome = "Ana Clara Torres", Email = "anaCtorres@gmail.com", Senha = "J5SNE'p:We%?U$kc".Encrypt(), Idade = 34, Endereco = "", Outros = "", Interesses = "", Sentimentos = "", Valores = "", TipoDeCadastro = cliente},
            new Cadastro() {Nome = "Matheus Fernandes", Email = "matheus.fernandes@yahoo.com", Senha = "2{r^XdB$Tr.;p2sm".Encrypt(), Idade = 47, Endereco = "", Outros = "", Interesses = "", Sentimentos = "", Valores = "", TipoDeCadastro = cliente},
            new Cadastro() {Nome = "Yuri Yoshida", Email = "yuri.g.yoshida@gmail.com", Senha = "123456".Encrypt(), Idade = 24, Endereco = "", Outros = "", Interesses = "", Sentimentos = "", Valores = "", TipoDeCadastro = adm},

        };
            context.Cadastros.AddRange(cadastros);

            context.Usuarios.Add(new Usuario()
            {
                Nome = "Yuri Yoshida",
                Email = "yuri.g.yoshida@gmail.com",
                Senha = "123456".Encrypt()
            });


            context.SaveChanges();
        }
    }
}
