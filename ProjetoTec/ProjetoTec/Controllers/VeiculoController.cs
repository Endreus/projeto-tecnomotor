using Biblioteca.Models.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Biblioteca.Models.Dtos;
using ProjetoTec.Models.Dtos;
using ProjetoTec.Models.Contracts.Services;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Biblioteca.Controllers
{
    public class VeiculoController : Controller //o controlador para mostrar os veiculos na pagina Veiculos
    {
        private readonly IVeiculoService _veiculoService;
        private readonly IMontadoraService _montadoraService;

        public VeiculoController(IVeiculoService veiculoService, IMontadoraService montadoraService) 
        {
            _veiculoService = veiculoService;
            _montadoraService = montadoraService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List() 
        {
            try 
            {
                var veiculos = _veiculoService.Listar();
                return View(veiculos);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
        public IActionResult Create() // para cadastrar é necessário 2 views uma para a página de cadastro e outra para o inserção do cadastro no Bando de dados.
        {
            var montadoras = _montadoraService.Listar(); //seleciona a lista já inserida de Montadoras
            var list = montadoras.Select(montadora => new SelectListItem { Value = montadora.Id, Text = montadora.Nome }); //seleciono os campos que serão buscados.
            ViewBag.Montadoras = list;
            return View();
        }
        [HttpPost] //referencia dizendo que é algo que ira escrever, salvar
        [ValidateAntiForgeryToken] // sistema de segurança para proteção de CSRF. ataque malicioso.
        public IActionResult Create(VeiculoViewModel veiculoViewModel) // tem o mesmo nome Create para tem uma assinatura diferente (possui parâmetros) por isso consigo usar o mesmo nome.
        {                       
            try
            {
                var veiculo = new VeiculoDto(); 
                veiculo.Nome = veiculoViewModel.Nome;
                veiculo.Montadora = _montadoraService.PesquisarPorId(veiculoViewModel.Montadora);
                _veiculoService.Cadastrar(veiculo);
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

            var veiculo  = _veiculoService.PesquisarPorID(id); // aqui seria o else
            if(veiculo == null) // caso ele nao ache o veículo ele retorna mensagem não encontrado.
                return NotFound();

            return View(veiculo); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(VeiculoDto veiculo)
        {
            if (string.IsNullOrEmpty(veiculo.Id))
                return NotFound();

            try
            {
                _veiculoService.Atualizar(veiculo);
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

            var veiculo = _veiculoService.PesquisarPorID(id); // aqui seria o else
            if (veiculo == null) // caso ele nao ache o veiculo ele retorna mensagem não encontrado.
                return NotFound();

            return View(veiculo);
        }

        public IActionResult Delete(string? id) //o ? informa para o programa que é opcional.
        {
            if (string.IsNullOrEmpty(id)) //se nao encontrar ele dará a mensagem de nao encontrado
                return NotFound();

            var veiculo = _veiculoService.PesquisarPorID(id); // aqui seria o else
            if (veiculo == null) // caso ele nao ache o veiculo ele retorna mensagem não encontrado.
                return NotFound();

            return View(veiculo);
        }

        [HttpPost]

        public IActionResult Delete([Bind("Id, Nome")]VeiculoDto veiculo)
        {
            _veiculoService.Excluir(veiculo.Id); //ele pega o id e exclui
            return RedirectToAction("List"); //a exclusão estando tudo certo ele volta para a tela dos veiculos.
        }
    }
}
