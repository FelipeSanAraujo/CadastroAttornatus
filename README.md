# API para cadastro de pessoas e endereços
O principal objetivo desta api é cadastrar pessoas e seus respectivos endereços fazendo assim o relacionamento de um para um no banco de dados.
O Sql Server foi a escolha juntamente com o Entityframework, as entidades foram mapeadas para o banco utilizando o Fluent Api, e o mapeamento de DTOs
para entidades foi feito utilizando o AutoMapper.

### Padrões utilizados:

* Arquitetura limpa;
> Todas as camadas do projeto são bem definidas e o core devidamente desacoplado das demais.
* Injeção de dependência
> O acesso às implementações tanto de repositório quanto de serviços é feito por meio de interfaces.
* Code First
> Primeiro foi desenvolvido as entidades depois com o recurso das migrations foram geradas as tabelas do banco.

## Stack do projeto
* ASP.NET Core
* Entityframework Core
* Sql Server

#### Faça um clone e execute o projeto
``` git clone https://github.com/FelipeSanAraujo/CadastroAttornatus.git ```

Voçe deve criar um banco de dados e alterar a connectionString no appsettings.json, após isso é só dar um:

``` dotnet ef migrations add NomeDaMigration ```

depois:
``` dotnet ef database update ```
