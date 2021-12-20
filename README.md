# projeto-tecnomotor
Projeto destinado ao processo seletivo da tecnomotor
no início criei as duas classes Dto Véiculo e Montadora, porém resolvi focar primeiramente em uma das classes e depois a outra.
Através da separação de camadas MVC separei cada item no seu devido lugar conforme as boas práticas da programação.
criei as interfaces IVeiculoService e IVéiculoRepository e suas classes de implementação de código.
criei uma Entidade chamada de EntidadeBase para facilitar a geração de Id, onde ele gera o id automaticamente usando o Guid.
criei uma nova Controller para poder listar os veículos chamada de VeiculoCOntroller e onde vamos chamar os métodos CRUD.
através da Controller e utilizando a ferramenta Razor criei uma pagina Véiculo.
Criada a página List para listar todos os véiculos.
Primeiramente para CRUD iniciei criando o método de Listar, onde ele pega as informações da Dto, chamando o serviço que solicita para o repositório que retorna e manda para a controller.
Mas antes criei um banco de dados em memória para poder salvar as informações das solicitações.
Criada a página Cadastrar para a implementação do método.
Cadastrar instanciado com sucesso.
A mesma forma foi com os métodos de Editar, Detalhes e Exclusão, onde crio a página e instancio os métodos para cada, e todos foram implementados com sucesso.
Com o CRUD feito, crio a classe Montadora para trabalhar com ela.
