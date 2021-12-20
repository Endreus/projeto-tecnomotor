using ProjetoTec.Models.Contracts.Repositories;
using ProjetoTec.Models.Contracts.Services;
using ProjetoTec.Models.Dtos;
using System;
using System.Collections.Generic;

namespace ProjetoTec.Models.Services
{
    public class MontadoraService : IMontadoraService
    {
        private readonly IMontadoraRepository _montadoraRepository;

        public MontadoraService(IMontadoraRepository montadoraRepository)
        {
            _montadoraRepository = montadoraRepository;
        }

        public void Atualizar(MontadoraDto montadora)
        {
            try
            {
                _montadoraRepository.Atualizar(montadora); //aqui o MontadoraRepository Atualiza o montadora
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Cadastrar(MontadoraDto montadora)
        {
            try
            {
                _montadoraRepository.Cadastrar(montadora); //aqui o MontadoraRepository cadastra o montadora
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
                _montadoraRepository.Excluir(id); //aqui o MontadoraRepository exclui através do parâmetro id.
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MontadoraDto> Listar()
        {
            try
            {
                return _montadoraRepository.Listar(); // aqui ele faz a lista dos montadoras.
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public MontadoraDto PesquisarPorId(string id)
        {
            try
            {
                return _montadoraRepository.PesquisarPorId(id);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
