using Biblioteca.Models.Dtos;
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
            var veiculo = new VeiculoDto("Ford Ka");
            Veiculos.Add(veiculo);

            veiculo = new VeiculoDto("Corolla");
            Veiculos.Add(veiculo);

            veiculo = new VeiculoDto("Fusca");
            Veiculos.Add(veiculo);

            veiculo = new VeiculoDto("Prisma");
            Veiculos.Add(veiculo);

            veiculo = new VeiculoDto("Uno");
            Veiculos.Add(veiculo);
        }
    }
}
