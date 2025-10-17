# JornadaMilhas

Sistema para gerenciamento de ofertas de viagens, permitindo cadastro, exibição e busca de ofertas com desconto.

## Funcionalidades

- Cadastro de ofertas de viagem (origem, destino, datas e preço)
- Exibição de todas as ofertas cadastradas
- Busca pela oferta de menor preço (maior desconto) com filtros personalizados
- Carregamento de ofertas de exemplo para testes

## Estrutura Principal

- `GerenciadorDeOfertas`: Classe responsável por gerenciar a lista de ofertas de viagem.
- `OfertaViagem`: Representa uma oferta de viagem, incluindo rota, período, preço e desconto.
- `Rota`: Define a origem e destino da viagem.
- `Periodo`: Define as datas de ida e volta.

## Como Usar

1. Clone o repositório e abra o projeto no Visual Studio 2022.
2. Compile o projeto com .NET 7.
3. Utilize as funcionalidades do `GerenciadorDeOfertas` para cadastrar, exibir e buscar ofertas.

### Exemplo de Cadastro de Oferta

Ao executar o método `CadastrarOferta()`, o sistema solicitará:

- Cidade de origem
- Cidade de destino
- Data de ida (DD/MM/AAAA)
- Data de volta (DD/MM/AAAA)
- Preço

A oferta será adicionada à lista e poderá ser exibida posteriormente.

### Exemplo de Busca de Oferta com Maior Desconto

Utilize o método `RecuperaMaiorDesconto` passando um filtro personalizado para encontrar a melhor oferta disponível.

## Requisitos

- .NET 7
- Visual Studio 2022

## Observações

- O projeto utiliza validações básicas para datas e valores.
- As ofertas podem ser carregadas automaticamente para testes usando o método `CarregarOfertas()`.

---

