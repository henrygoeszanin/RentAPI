# RentAPI: Documentação do Projeto

## Visão Geral
O **RentAPI** é uma API monolítica que permite o gerenciamento de imóveis para locação, organizando e controlando o status de cada imóvel. A aplicação oferece funcionalidades para **locatários** (proprietários ou administradores) e **clientes** (potenciais inquilinos), facilitando o processo de consulta, cadastro e locação de imóveis, com uma estrutura clara de autenticação e autorização.

## Estrutura de Camadas (Clean Architecture)

- **Api**: Responsável pela interface RESTful. É a camada que expõe os endpoints HTTP para a interação do cliente, recebendo e processando as requisições e delegando as tarefas às camadas apropriadas.

- **Application**: Centraliza a lógica de negócio e as regras da aplicação. Contém os *handlers* do **MediatR**, que processam requisições e orquestram as operações entre as entidades. Esta camada depende exclusivamente da **Domain**.

- **Authentication**: Controla toda a lógica de autenticação e autorização do sistema. Gerencia a criação e verificação de tokens, validação de credenciais e outras necessidades relacionadas à segurança dos dados dos usuários.

- **Domain**: Representa o coração da aplicação, definindo as entidades, como Imóvel, Locatário e Cliente, e as regras de domínio (regras de negócio essenciais) que não dependem das camadas superiores. Também contém contratos (interfaces) para abstrações das interações com infraestrutura, seguindo o princípio de inversão de dependência.

- **Infrastructure**: Implementa os detalhes de infraestrutura, incluindo acesso a dados com o **Entity Framework**, repositórios e integração com serviços externos. Esta camada depende do **Domain** para as definições de contratos e fornece implementações concretas.

---

## Funcionalidades

### Para Clientes

1. **Explorar Imóveis**:
   - Visualizar um catálogo completo de imóveis com dados detalhados.
   - Filtrar e visualizar dados de imóveis próximos a uma localização específica.
   - Ver informações de valores e detalhes do imóvel.

2. **Criar Conta**:
   - É necessário criar uma conta para contatar um locatário e visualizar informações de contato.

### Para Locatários

1. **Cadastro e Gerenciamento de Imóveis**:
   - Cadastro de novos imóveis com status (alugável, pendente, em reforma).
   - Visualização e edição de dados cadastrais e valor estimado de cada imóvel.
   - Controle de listagem, com contagem de imóveis alugados, disponíveis e pendentes.

2. **Painel de Controle de Imóveis**:
   - Resumo de quantos imóveis estão alugados, disponíveis e pendentes ou em reforma.

### Para Inquilinos

1. **Acesso a Informações de Locação**:
   - Visualização da data de pagamento do aluguel.
   - Acesso a um canal de chat para contato direto com o locatário.

---

## Requisitos Técnicos

- **Arquitetura**: Clean Architecture.
- **Padrão**: API RESTful monolítica.
- **Autenticação e Autorização**: Controle de acesso para clientes e locatários.
- **Banco de Dados**: Integrado com Entity Framework para persistência dos dados.
