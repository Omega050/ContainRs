# ContainRs 🚢

![.NET](https://img.shields.io/badge/.NET-8.0-blue?style=for-the-badge&logo=.net)
![C#](https://img.shields.io/badge/C%23-12.0-purple?style=for-the-badge&logo=c-sharp&logoColor=white)
![Microsoft SQL Server](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)

API RESTful para gerenciamento de contêineres, desenvolvida em ASP.NET Core com foco na aplicação dos princípios de **Arquitetura Limpa (Clean Architecture)**.

Este projeto serve como a fundação arquitetural, estabelecendo uma clara separação de interesses e um baixo acoplamento entre as camadas, preparando o terreno para futuras evoluções.

> Este é o primeiro de dois projetos. Sua evolução, que aprofunda os conceitos de Design Orientado a Domínio, pode ser encontrada no repositório [**ContainRs-DDD**](https://github.com/Omega050/ContainRs-DDD).

---

## 🏛️ Arquitetura Aplicada

A solução foi estruturada seguindo os preceitos da **Arquitetura Limpa** de Robert C. Martin. O objetivo principal é o isolamento do domínio do negócio de detalhes de infraestrutura e frameworks.

- **Domain:** Contém as entidades e a lógica de negócio mais pura, sem dependências externas.
- **Application:** Orquestra os casos de uso do sistema, conectando a camada de apresentação com a de domínio.
- **Infrastructure:** Implementa os detalhes técnicos, como o acesso ao banco de dados com Entity Framework Core e a persistência em SQL Server.
- **Presentation (API):** A camada mais externa, responsável por expor as funcionalidades via endpoints RESTful.

A **Regra da Dependência** é estritamente seguida: todas as dependências apontam para dentro, em direção ao `Domain`.

## 💻 Tecnologias Utilizadas

- **C# 12** e **.NET 8**
- **ASP.NET Core:** Para a construção da API RESTful.
- **Entity Framework Core:** ORM para comunicação com o banco de dados.
- **SQL Server:** Banco de dados relacional.
## Preparando o ambiente

### Criando o banco de dados
Abra o terminal, navegue para a pasta onde baixou o projeto e execute o comando abaixo:
```
dotnet ef database update --project .\ContainRs.WebApp\ContainRs.WebApp.csproj --startup-project .\ContainRs.WebApp\ContainRs.WebApp.csproj
```

O comando deverá criar o banco de dados e as tabelas necessárias para o funcionamento do projeto.
