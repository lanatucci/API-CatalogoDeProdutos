using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {

            // Inserindo dados iniciais (Populando )na tabela Categorias
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Bebidas', 'bebidas.jpg')");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Lanches', 'lanches.jpg')");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Sobremesas', 'sobremesas.jpg')");

        }

       
        protected override void Down(MigrationBuilder mb)
        {
            // Implementando o método Down para desfazer as alterações feitas no método Up, se necessário.
            mb.Sql("DELETE FROM Categorias");

        }
    }
}
