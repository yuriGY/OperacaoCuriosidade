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
                new Cadastro() {Nome =  "Stephanie Nichols", Email = "stephanienichols@gmail.com", Senha = ")kCfVAB36HG,<GtR".Encrypt(), Idade = 37, Endereco = "Grand Marais, MN 55604, Minnesota", Outros = "Advogada", Interesses = "Filmes", Sentimentos = "Levantar recursos meticulasamente", Valores = "Prosperidade e Cuidado", TipoDeCadastro = cliente},
                new Cadastro() {Nome =  "Jeffrey Kane", Email = "jeffrey_kane@yahoo.com", Senha = "q.E[K@9B^[g'Y7:%".Encrypt(), Idade = 43, Endereco = "1-3 Edinburgh Rd, New South Wales", Outros = "Médico", Interesses = "Comida", Sentimentos = "Sempre melhorar o processo com críticas construtivas", Valores = "Determinação e Assertividade", TipoDeCadastro = cliente},
                new Cadastro() {Nome =  "Darin Miller", Email = "darinmiller01@gmail.com", Senha = "/'>ZL6>zE^NLsM,$Q".Encrypt(), Idade = 34, Endereco = "1843 Teakwood Pl, British Columbia", Outros = "Engenheiro Civil", Interesses = "Telenovelas", Sentimentos = "Conduzir a equipe ao rumo certo", Valores = "Protagonismo e Prosperidade", TipoDeCadastro = cliente},
                new Cadastro() {Nome =  "Andrew Stuart", Email = "andrewstuart@outlook.com", Senha = "f+krsg_LV9F}8q&m".Encrypt(), Idade = 25, Endereco = "Agias Paraskevis 95, Attica", Outros = "Veterinário", Interesses = "Tecnologia", Sentimentos = "Estar sempre a frente dando ideias", Valores = "Assertividade e Protagonismo", TipoDeCadastro = cliente},
                new Cadastro() {Nome =  "Valerie Aguilar", Email = "valerie_aguiler@gmail.com", Senha = "jeLh9un6vRY@{G//$".Encrypt(), Idade = 29, Endereco = "Alte Holstenstrasse 54, Hamburg", Outros = "Guia Turístico", Interesses = "Ciências", Sentimentos = "Produzir num ritmo constante e sempre atento", Valores = "Cuidado e Determinação", TipoDeCadastro = cliente},
                new Cadastro() {Nome =  "Thomas Wagner", Email = "thomW@gmail.com", Senha = "`9kY?G:Xk+5mp!+'".Encrypt(), Idade = 15, Endereco = "Av de Pio XII, 36, Navarra", Outros = "Chef", Interesses = "Jornalismo", Sentimentos = "Ir a frente e garantir resultados", Valores = "Protagonismo e Prosperidade", TipoDeCadastro = cliente},
                new Cadastro() {Nome =  "Felipe Santos", Email = "felipeSantos@hotmail.com", Senha = "_%V{BgZ6Me>,_(f>".Encrypt(), Idade = 25, Endereco = "Primeira Avenida, 231, Serra", Outros = "Empresário", Interesses = "Culturas Diferentes", Sentimentos = "Levantar pessoas para as areas certas", Valores = "Protagonismo e Determinação", TipoDeCadastro = cliente},
                new Cadastro() {Nome = "Beatriz Carvalho", Email = "bia.carvalho@gmail.com", Senha = "vTH9]+~(=fZk.Cgb".Encrypt(), Idade = 23, Endereco = "Zdrojowa 46, Kudowa-Zdroj", Outros = "Designer", Interesses = "Comportamento Humano", Sentimentos = "Fazer todo o possível para um processo seguro", Valores = "Determinação e Cuidado", TipoDeCadastro = cliente},
                new Cadastro() {Nome = "Ana Clara Torres", Email = "anaCtorres@gmail.com", Senha = "J5SNE'p:We%?U$kc".Encrypt(), Idade = 34, Endereco = "Beethovenstraat 86, North Holland", Outros = "Vendedor", Interesses = "True Crime", Sentimentos = "Mostrar suas capacidades e esforço", Valores = "Assertividade e Determinação", TipoDeCadastro = cliente},
                new Cadastro() {Nome = "Matheus Fernandes", Email = "matheus.fernandes@yahoo.com", Senha = "2{r^XdB$Tr.;p2sm".Encrypt(), Idade = 47, Endereco = "73 Rue Brancion, Paris", Outros = "Atleta", Interesses = "Esportes", Sentimentos = "Tomar precauções e vencer", Valores = "Cuidado e Prosperidade", TipoDeCadastro = cliente},
                new Cadastro() {Nome = "Yuri Yoshida", Email = "yuri.g.yoshida@gmail.com", Senha = "123456".Encrypt(), Idade = 24, Endereco = "5 Chome-13-19 Karita, 大阪府", Outros = "Estagiário", Interesses = "Línguas e Tecnologia", Sentimentos = "Fazer o melhor possível com excelência", Valores = "Protagonismo e Cuidado", TipoDeCadastro = adm},

            };
            context.Cadastros.AddRange(cadastros);

            context.SaveChanges();
        }
    }
}
