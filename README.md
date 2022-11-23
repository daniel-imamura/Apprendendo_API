# Apprendendo_API

API criada para o projeto de TCC utilizando ASP.NET

## Recursos necessários para o uso da API:

* Link para download do .NET: https://dotnet.microsoft.com/en-us/download
* Comando para adicionar package do MySQL: dotnet add package MySql.EntityFrameworkCore

### Para MySQL:

<i> 1. Link para o XAMPP: </i> https://www.apachefriends.org/pt_br/download.html <br>
<i> 2. Criar banco de dados </i> <br>
<i> 3. Criar tabela com o código: </i> <br> 
<p> CREATE TABLE `cliente` (           <br>
  &emsp;`id` int(11) NOT NULL AUTO_INCREMENT,<br>
  &emsp;`username` varchar(50) NOT NULL,     <br>   
  &emsp;`senha` int(11) NOT NULL,            <br>
  &emsp;PRIMARY KEY (`id`)                   <br>
) </p> 
<i> 4. Vá no arquivo Apprendendo_API/Program.cs e altere a linha 12, colocando o nome de seu banco de dados e usuário no database e user
