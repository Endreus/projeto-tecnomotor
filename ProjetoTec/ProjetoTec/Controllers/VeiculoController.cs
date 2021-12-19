using Biblioteca.Models.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Biblioteca.Models.Dtos;

namespace Biblioteca.Controllers
{
    public class VeiculoController : Controller //o controlador para mostrar os veiculos na pagina Veiculos
    {
        private readonly IVeiculoService _veiculoservice;

        public VeiculoController(IVeiculoService veiculoservice) 
        {
            _veiculoservice = veiculoservice;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List() 
        {
            try 
            {
                var veiculos = _veiculoservice.Listar();
                return View(veiculos);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
        public IActionResult Create() // para cadastrar é necessário 2 views uma para a página de cadastro e outra para o inserção do cadastro no Bando de dados.
        {
            return View();
        }
        [HttpPost] //referencia dizendo que é algo que ira escrever, salvar
        [ValidateAntiForgeryToken] // sistema de segurança para proteção de CSRF. ataque malicioso.
        public IActionResult Create([Bind("Nome","Autor","Editora")]VeiculoDto veiculo) // tem o mesmo nome Create para tem uma assinatura diferente (possui parâmetros) por isso consigo usar o mesmo nome.
        {                            // Bind irá colocar os itens no BD do LivroDto nos campos Nome, Autor e Editora
            try
            {
                _veiculoservice.Cadastrar(veiculo);
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public IActionResult Edit(string? id) //o ? informa para o programa que é opcional. // aqui nesse código ele buscará as informações do veiculo usando seu id.
        {
            if (string.IsNullOrEmpty(id)) //se nao encontrar ele dará a mensagem de nao encontrado
                return NotFound();

            var veiculo  = _veiculoservice.PesquisarPorID(id); // aqui seria o else
            if(veiculo == null) // caso ele nao ache o livro ele retorna mensagem não encontrado.
                return NotFound();

            return View(veiculo); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Id, Nome")]VeiculoDto veiculo)
        {
            if (string.IsNullOrEmpty(veiculo.Id))
                return NotFound();

            try
            {
                _veiculoservice.Atualizar(veiculo);
                return RedirectToAction("List");
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public IActionResult Details(string? id) //o ? informa para o programa que é opcional.
        {
            if (string.IsNullOrEmpty(id)) //se nao encontrar ele dará a mensagem de nao encontrado
                return NotFound();

            var veiculo = _veiculoservice.PesquisarPorID(id); // aqui seria o else
            if (veiculo == null) // caso ele nao ache o veiculo ele retorna mensagem não encontrado.
                return NotFound();

            return View(veiculo);
        }

        public IActionResult Delete(string? id) //o ? informa para o programa que é opcional.
        {
            if (string.IsNullOrEmpty(id)) //se nao encontrar ele dará a mensagem de nao encontrado
                return NotFound();

            var veiculo = _veiculoservice.PesquisarPorID(id); // aqui seria o else
            if (veiculo == null) // caso ele nao ache o veiculo ele retorna mensagem não encontrado.
                return NotFound();

            return View(veiculo);
        }

        [HttpPost]

        public IActionResult Delete([Bind("Id, Nome, Autor, Editora")]VeiculoDto veiculo)
        {
            _veiculoservice.Excluir(veiculo.Id); //ele pega o id e exclui
            return RedirectToAction("List"); //a exclusão estando tudo certo ele volta para a tela dos veiculos.
        }
    }
}
