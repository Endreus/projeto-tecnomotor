using Biblioteca.Models.Contracts.Repositories;
using Biblioteca.Models.Contracts.Services;
using Biblioteca.Models.Dtos;
using System;
using System.Collections.Generic;

namespace Biblioteca.Models.Services
{
    public class VeiculoService : IVeiculoService // ele vai acessar a camadada repositório e disponibilizar para quem solicitou
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoService(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public void Atualizar(VeiculoDto veiculo)
        {
            try
            {
                _veiculoRepository.Atualizar(veiculo); //aqui o VeiculoRepository Atualiza o veiculo
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Cadastrar(VeiculoDto veiculo)
        {
            try
            {
                _veiculoRepository.Cadastrar(veiculo); //aqui o VeiculoRepository cadastra o veiculo
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(string id)
        {
            try
            {
                _veiculoRepository.Excluir(id); //aqui o VeiculoRepository exclui através do parâmetro id.
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<VeiculoDto> Listar() 
        {
            try 
            {
                return _veiculoRepository.Listar(); // aqui ele faz a lista dos veiculos
            }

            catch (Exception ex) 
            {
                throw ex;
            }
            
        }

        public VeiculoDto PesquisarPorID(string id)
        {
            try
            {
                return _veiculoRepository.PesquisarPorId(id);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
