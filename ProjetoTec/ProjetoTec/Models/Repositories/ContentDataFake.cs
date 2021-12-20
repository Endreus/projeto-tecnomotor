using Biblioteca.Models.Dtos;
using ProjetoTec.Models.Dtos;
using System;
using System.Collections.Generic;

namespace Biblioteca.Models.Repositories
{
    public static class ContentDataFake
    {
        public static List<VeiculoDto> Veiculos;
        public static List<MontadoraDto> Montadoras;

        static ContentDataFake() 
        {
            Veiculos = new List<VeiculoDto>();//foi criado um banco de dados fake para testar como vai ficar, até introduzir o banco de dados real.
            Montadoras = new List<MontadoraDto>();
            InitializeData();

        }

        private static void InitializeData() //acrescentado alguns veiculos para teste
        {
            var montadora = new MontadoraDto("Ford");
            Montadoras.Add(montadora);



            var veiculo = new VeiculoDto("Ka", montadora);
            Veiculos.Add(veiculo);

            montadora = new MontadoraDto("Toyota");
            Montadoras.Add(montadora);

            veiculo = new VeiculoDto("Corolla", montadora);
            Veiculos.Add(veiculo);

            montadora = new MontadoraDto("Volkswagen");
            Montadoras.Add(montadora);

            veiculo = new VeiculoDto("Fusca", montadora);
            Veiculos.Add(veiculo);

            montadora = new MontadoraDto("Chevrolet");
            Montadoras.Add(montadora);

            veiculo = new VeiculoDto("Prisma", montadora);
            Veiculos.Add(veiculo);

            montadora = new MontadoraDto("Fiat");
            Montadoras.Add(montadora);

            veiculo = new VeiculoDto("Uno", montadora);
            Veiculos.Add(veiculo);
        }

    }
}
