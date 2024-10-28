# Instruções para Criar Migrations com Entity Framework no RentAPI

## Passo a Passo para Criar Migrations

1. **Abrir o Terminal:**
   - Utilize o terminal integrado da sua IDE ou o Prompt de Comando.

2. **Navegar até o Diretório do Projeto:**
   - Acesse a pasta do projeto de infraestrutura onde o contexto do Entity Framework está localizado.

3. **Instalar a Ferramenta `dotnet-ef`:**
   - Caso ainda não tenha instalado, execute o seguinte comando para instalar a ferramenta globalmente:
     ```bash
     dotnet tool install --global dotnet-ef
     ```

4. **Criar a Migration:**
   - Execute o seguinte comando para criar uma nova migration:
     ```bash
     dotnet ef migrations add NomeDaMigration
     ```
   - Substitua `NomeDaMigration` por um nome descritivo que refira-se às alterações feitas, por exemplo: `AdicionarTabelaImovel`.

5. **Atualizar o Banco de Dados:**
   - Após criar a migration, você deve aplicar as alterações ao banco de dados. Execute o seguinte comando:
     ```bash
     dotnet ef database update
     ```
   - Este comando aplicará todas as migrations pendentes no banco de dados configurado.

6. **Verificar o Banco de Dados:**
   - Utilize uma ferramenta de gerenciamento de banco de dados (como SQL Server Management Studio) para verificar se as tabelas foram criadas ou alteradas conforme esperado.

## Observações
- Certifique-se de que o projeto está configurado corretamente para usar o Entity Framework, incluindo a conexão com o banco de dados no arquivo `appsettings.json`.
- É uma boa prática revisar a migration gerada (localizada na pasta Migrations) para entender as alterações que serão aplicadas ao banco de dados antes de executar o `dotnet ef database update`.

## Exemplo de Criação de Migration
```bash
dotnet ef migrations add CriarTabelaLocador
dotnet ef database update
