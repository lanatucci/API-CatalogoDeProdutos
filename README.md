
<h1 align="center" style="font-weight: bold;">API Catálogo de Produtos 💻</h1>


<p align="center">
    <b>Projeto de uma API RESTful em ASP.NET Core (.NET 9) programada em C# para gerenciamento de um catálogo de produtos e categorias. Utiliza MySQL Workbench com Entity Framework Core para facilitar a integração com o banco de dados.</b>
</p>

<h2 id="technologies">💻 Tecnologias</h2>

- C#
- .NET 9.0  
- Visual Studio IDE
- MySQL Workbench
- Entity Framework Core


<h2 id="routes">📍 API Endpoints</h2>

Rotas do Controller Categoria
​
| Rota               | Descrição                                          
|----------------------|-----------------------------------------------------
| <kbd>GET /Categorias/Produtos | Retorna todas as categorias junto com os produtos relacionados. [Detalhes do Response](#get-auth-detail)
| <kbd>GET /Categorias | Retorna todas as categorias.
| <kbd>POST /Categorias | Cria uma nova categoria.
| <kbd>GET /Categorias/{id} | Retona uma categoria. 
| <kbd>PUT /Categorias/{id} | Adiciona uma categoria.
| <kbd>DELETE /Categorias/{id} | Deleta uma categoria.

Rotas do Controller Produto
​
| Rota               | Descrição                                        
|----------------------|-----------------------------------------------------
| <kbd>GET /Produtos | Retorna todos os produtos. [Detalhes do Response](#getProd-auth-detail)
| <kbd>POST /Produtos | Cria um novo produto.
| <kbd>GET /Produtos/{id} | Retona um produto. 
| <kbd>PUT /Produtos/{id} | Adiciona um produto.
| <kbd>DELETE /Produtos/{id} | Deleta um produto.

<h3 id="get-auth-detail">GET /Categorias/Produtos </h3>

**RESPONSE**
```json
{
    "categoriaId": 1,
    "nome": "Bebidas",
    "imagemUrl": "bebidas.jpg",
    "produtos": [
      {
        "produtoId": 1,
        "nome": "Coca-Cola Diet",
        "descricao": "Refrigerante de Cola 350 ml",
        "preco": 5.45,
        "imagemUrl": "cocacola.jpg",
        "estoque": 50,
        "dataCadastro": "2025-10-23T09:06:50",
        "categoriaId": 1
      }
    ]
  },
  {
    "categoriaId": 2,
    "nome": "Lanches",
    "imagemUrl": "lanches.jpg",
    "produtos": [
      {
        "produtoId": 2,
        "nome": "Lasanha de Atum",
        "descricao": "Lanche de Atum com maionese",
        "preco": 8.5,
        "imagemUrl": "atum.jpg",
        "estoque": 10,
        "dataCadastro": "2025-10-23T09:06:50",
        "categoriaId": 2
      }
    ]
  },
  {
    "categoriaId": 3,
    "nome": "Sobremesas",
    "imagemUrl": "sobremesas.jpg",
    "produtos": [
      {
        "produtoId": 3,
        "nome": "Pudim 100 g",
        "descricao": "Pudim de leite condensado 100g",
        "preco": 6.75,
        "imagemUrl": "pudim.jpg",
        "estoque": 20,
        "dataCadastro": "2025-10-23T09:06:50",
        "categoriaId": 3
      }
    ]
  }
```

<h3 id="getProd-auth-detail">GET /produtos</h3>

**RESPONSE**
```json
{
    "produtoId": 1,
    "nome": "Coca-Cola Diet",
    "descricao": "Refrigerante de Cola 350 ml",
    "preco": 5.45,
    "imagemUrl": "cocacola.jpg",
    "estoque": 50,
    "dataCadastro": "2025-10-23T09:06:50",
    "categoriaId": 1
  },
  {
    "produtoId": 2,
    "nome": "Lasanha de Atum",
    "descricao": "Lanche de Atum com maionese",
    "preco": 8.5,
    "imagemUrl": "atum.jpg",
    "estoque": 10,
    "dataCadastro": "2025-10-23T09:06:50",
    "categoriaId": 2
  },
  {
    "produtoId": 3,
    "nome": "Pudim 100 g",
    "descricao": "Pudim de leite condensado 100g",
    "preco": 6.75,
    "imagemUrl": "pudim.jpg",
    "estoque": 20,
    "dataCadastro": "2025-10-23T09:06:50",
    "categoriaId": 3
  }
```


