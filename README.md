## Cadastro_Pessoa

Cadastro_Pessoa é um aplicativo desktop feito com C# e Windows Forms que implementa um sistema (CRUD) para cadastrar pessoas.

## Tecnologias utilizadas

C#
Windows Forms (.NET Framework)
PostgreSQL

## Requisitos para uso

Visual Studio 2022

PostgreSQL 12 

## Dependências

Para executar este projeto, você precisa ter as seguintes dependências instaladas:

Npgsql: Biblioteca para acesso ao banco de dados PostgreSQL em C#.

Dapper: Micro ORM que facilita a execução de comandos SQL.

## Configuração do Banco de Dados

Antes de executar o projeto, é necessário configurar o banco de dados PostgreSQL conforme os passos abaixo:

Utilize sua ferramenta de gerenciamento (como o pgAdmin) para criar um novo banco de dados, com o nome cadastropessoa.

Após criar o banco, clique com o botão direito sobre o banco criado e selecione a opção "Restore".

No campo de caminho do arquivo, selecione o arquivo .sql localizado na pasta Database do projeto.

Confirme a operação para que as tabelas e estruturas sejam criadas automaticamente.

## Como instalar e executar o projeto

Clone o repositorio.

Abra o projeto no Visual Studio 2022.

Atualize a string de conexão no arquivo DbConexao.cs, inserindo as informações do seu banco PostgreSQL: nome do banco, nome de usuário, senha, host e porta.

Compile e execute o projeto.
