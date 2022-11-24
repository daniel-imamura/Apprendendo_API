# Apprendendo_API

API criada para o projeto de TCC utilizando ASP.NET

## Recursos necessários para o uso da API:

* Link para download do .NET: https://dotnet.microsoft.com/en-us/download


### MySQL:

<i> 1. Comando para adicionar package do MySQL: dotnet add package MySql.EntityFrameworkCore </i>
<i> 2. Link para o XAMPP: </i> https://www.apachefriends.org/pt_br/download.html <br>
<i> 3. Criar banco de dados </i> <br>
<i> 4. Criar tabela com o código: </i> <br> 
<p> CREATE TABLE `cliente` (           <br>
  &emsp;`id` int(11) NOT NULL AUTO_INCREMENT,<br>
  &emsp;`username` varchar(50) NOT NULL,     <br>   
  &emsp;`senha` int(11) NOT NULL,            <br>
  &emsp;PRIMARY KEY (`id`)                   <br>
) </p> 
<p> CREATE TABLE `guia` (                       <br>
  &emsp;`id` int(11) NOT NULL AUTO_INCREMENT,   <br>
  &emsp;`nomeApp` varchar(50) NOT NULL,         <br>
  &emsp;`link` text DEFAULT NULL,               <br>
  &emsp;PRIMARY KEY (`id`)                      <br>
) </p>
<i> 5. Vá no arquivo Apprendendo_API/Program.cs e altere a linha 12, colocando o nome de seu banco de dados e usuário no database e user </i>

## Para rodar a aplicação:

* Iniciar o Apache e o MySQL no XAMPP 
* Rodar comando <b>dotnet run</b>
* Link para baixar Postman: https://www.postman.com/downloads/
* Agora você pode testar os métodos de requisição e ver os resultados no Postman!
