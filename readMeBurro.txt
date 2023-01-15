INICIANDO PROJETO

Para iniciar um projeto .net no visual code é preciso usar o comando no terminal

-> dotnet new webapi -n nome do projeto

Para iniciar um projeto .net na versão que eu desejo no visual code 
é preciso usar o comando no terminal

-> dotnet new webapi -n nome do projeto

Executar projeto 

-> dotnet run

Após ele executar, o mesmo irá mostrar uma porta localhost. Se você clicar
ele não irá encontrar nada. Para isso use /swagger após a url para acesssar
a API

Criar global JSON com a versão

--> dotnet new globaljson --sdk-version versão do .net

Criar migration

--> dotnet ef migration add nomeMigration -o diretorio do migration

Criar um arquivo banco de dados

--> dotnet ef database update
