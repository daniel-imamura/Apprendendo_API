# Apprendendo_API

API criada para o projeto de TCC utilizando ASP.NET

## Recursos necessários para o uso da API:

* Link para download do .NET: https://dotnet.microsoft.com/en-us/download
* Comando para adicionar package do MySQL: dotnet add package MySql.EntityFrameworkCore

### Para MySQL:

<i> 1. Link para o XAMPP: </i> https://www.apachefriends.org/pt_br/download.html <br>
<i> 2. Criar banco de dados: </i> 
CREATE TABLE `cliente` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `senha` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4


