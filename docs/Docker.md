# Instruções para Rodar o Banco de Dados com Docker

## Pré-requisitos

1. **Instalar o Docker Desktop:**
   - Baixe e instale o [Docker Desktop](https://www.docker.com/products/docker-desktop) para seu sistema operacional.
   - Certifique-se de que o Docker está rodando antes de continuar.

2. **Rodar o Container:**
   - Abra o terminal na pasta onde está o arquivo `docker-compose.yml` e execute o seguinte comando:
     ```bash
     docker-compose up -d
     ```
   - Esse comando iniciará o container do banco de dados em segundo plano.

## Aplicando as Migrations

1. **Conectar ao Banco de Dados:**
   - Após o container estar em execução, você pode aplicar suas migrations. Abra um novo terminal e navegue até o diretório do projeto onde está o contexto do Entity Framework.

2. **Executar as Migrations:**
   - Utilize o seguinte comando para aplicar as migrations ao banco de dados:
     ```bash
     dotnet ef database update
     ```

## Verificando a Conexão

- Você pode utilizar uma ferramenta de gerenciamento de banco de dados, como SQL Server Management Studio, para se conectar ao banco de dados usando as seguintes configurações:
  - **Servidor:** `localhost,1433`
  - **Usuário:** `sa`
  - **Senha:** A senha que você definiu no arquivo `docker-compose.yml`.

## Parar o Container

- Para parar o container do banco de dados, use o comando:
  ```bash
  docker-compose down
