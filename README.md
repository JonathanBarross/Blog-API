# Blog API 🚀

Projeto desenvolvido a fins de estudo para colocar os conhecimentos adquiridos na plataforma balta.io em prática usando **ASP.NET Core** e **Entity Framework Core** para gerenciar um sistema de blog. Inclui autenticação segura, gerenciamento de usuários, upload de imagens e CRUD de categorias, seguindo boas práticas de desenvolvimento.

---

## 🌟 **Destaques do Projeto**

- **Segurança:** Autenticação JWT e criptografia de senhas.
- **Boas Práticas:** Uso de migrations, tratamento de exceções e padrão MVC.
- **Escalabilidade:** Pronto para evoluir com testes, logs e monitoramento.

---

## 📂 **Estrutura do Projeto**

- **Controllers:** Endpoints da API (Account, Category, etc.).
- **Models:** Entidades do banco de dados (User, Category, Post, etc.).
- **Data:** Configuração do contexto do banco de dados e migrations.
- **Services:** Lógica de negócio (TokenService, etc.).
- **ViewModels:** Modelos para validação e transferência de dados.

---

## ⚙️ **Funcionalidades**

- **Autenticação JWT:** Segurança robusta com tokens JWT para acesso aos recursos.
- **Cadastro e Login de Usuários:** Registro e autenticação de usuários com geração automática de senhas seguras.
- **Upload de Imagem de Perfil:** Permite aos usuários adicionar ou alterar a imagem do perfil.
- **CRUD de Categorias:** Criação, leitura, atualização e exclusão de categorias.
- **Tratamento de Exceções:** Respostas claras e personalizadas para erros.
- **Migrations com Code First:** Gerenciamento eficiente do banco de dados.

---

## 🛠️ **Tecnologias Utilizadas**

- **ASP.NET Core**
- **Entity Framework Core**
- **SQL Server**
- **JWT (JSON Web Tokens)**
- **Docker** (opcional para containerização)
- **Postman** (para teste dos endpoints)

---

## 📦 **Pacotes Utilizados**

- **Microsoft.AspNetCore.Authentication**  
  Para funcionalidades básicas de autenticação.

- **Microsoft.AspNetCore.Authentication.JwtBearer**
  Para autenticação JWT.

- **Microsoft.EntityFrameworkCore.Design**  
  Para gerenciar migrations e design-time do Entity Framework Core.

- **Microsoft.EntityFrameworkCore.SqlServer**  
  Para integração com SQL Server.

- **SecureIdentity**  
  Para geração segura de senhas e hash.

---

## 🚀 **Como Executar o Projeto**

### **Pré-requisitos**
- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [Docker](https://www.docker.com/) (opcional)
- [Postman](https://www.postman.com/downloads/) (para testar os endpoints)

### **Passos para Execução**

1. Clone o repositório:
   ```bash
   git clone https://github.com/JonathanBarross/Blog-API.git
   cd Blog-API
   ```
2. Restaure os pacotes:
   ```bash
   dotnet restore
   ```
3. A string de conexão está definida no arquivo `Data/BlogDataContext.cs`.  
   - Localize o método `OnConfiguring` e altere a string de conexão conforme necessário:
     ```csharp
     options.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=TrueCalefactor83;TrustServerCertificate=True");
     ```
   - Substitua os valores de `Server`, `Database`, `User ID` e `Password` conforme sua configuração local do SQL Server.
   - Execute as migrations para criar o banco de dados:
      ```bash
      dotnet ef database update
      ```
4. Execute o projeto e depois teste os endpoints usando o Postman:
    ```bash  
    dotnet run
    ```

---

## 🛠️ **Endpoints Principais**

### **Autenticação**
- **Cadastro de Usuário:**  
  `POST /v1/accounts`  
  Body:
  ```json
  {
    "name": "Seu Nome",
    "email": "seuemail@example.com"
  }
  ```

- **Login:**  
  `POST /v1/accounts/login`  
  Body: 
  ```json
  {
    "email": "seuemail@example.com",
    "password": "sua-senha"
  }
  ```

### **Upload de Imagem de Perfil**
- **Upload de Imagem:**  
  `POST /v1/account/upload-image`  
  Body:
  ```json
  {
    "base64Image": "base64-da-imagem"
  }
  ```

### **Categorias**
- **Listar Categorias:**  
  `GET /v1/categories`

- **Criar Categoria:**  
  `POST /v1/categories`  
  Body:
  ```json
  {
    "name": "Nome da Categoria",
    "slug": "slug-da-categoria"
  }
  ```

- **Atualizar Categoria:**  
  `PUT /v1/categories/{id}`  
  Body:
  ```json
  {
    "name": "Novo Nome",
    "slug": "novo-slug"
  }
  ```

- **Deletar Categoria:**  
  `DELETE /v1/categories/{id}`

---



