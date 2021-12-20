using Biblioteca.Models.Dtos;
using ProjetoTec.Models.Dtos;
using System;
using System.Collections.Generic;

namespace Biblioteca.Models.Repositories
{
    public static class ContentDataFake
    {
        public static List<VeiculoDto> Veiculos;

        static ContentDataFake() 
        {
            Veiculos = new List<VeiculoDto>(); //foi criado um banco de dados fake para testar como vai ficar, até introduzir o banco de dados real.
            InitializeData();
        }

        private static void InitializeData() //acrescentado alguns veiculos para teste
        {
            var veiculo = new VeiculoDto("Ka", "Ford");
            Veiculos.Add(veiculo);

            veiculo = new VeiculoDto("Corolla", "Toyota");
            Veiculos.Add(veiculo);

            veiculo = new VeiculoDto("Fusca", "Volkswagen");
            Veiculos.Add(veiculo);

            veiculo = new VeiculoDto("Prisma", "Chevrolet");
            Veiculos.Add(veiculo);

            veiculo = new VeiculoDto("Uno", "Fiat");
            Veiculos.Add(veiculo);
        }

    }
}
