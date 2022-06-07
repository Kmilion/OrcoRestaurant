using Microsoft.EntityFrameworkCore.Migrations;

namespace Orco.Services.ProductAPI.Migrations
{
    public partial class SeedNewProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImageUrl", "Name", "Price", "ProductCategory" },
                values: new object[,]
                {
                    { 1, "TV 50 pulgadas.", "https://orcorestaurantimages.blob.core.windows.net/orco/tele_1.jpg", "Smart TV 4K 50\" Admiral AD50Q20", 64999, 1 },
                    { 2, "Un smartphone que te da lo que querés para que puedas hacer más de lo que disfrutás, ese es el Galaxy S20 FE.", "https://orcorestaurantimages.blob.core.windows.net/orco/celu_1.jpg", "Celular Samsung Galaxy S20 FE 5G 128GB Navy", 114999, 2 },
                    { 3, "El lavarropas Samsung WW65M0NHWUA es de carga frontal que combina diseño y tecnología brindando una gran experiencia de uso.", "https://orcorestaurantimages.blob.core.windows.net/orco/lavarropas_1.jpg", "Lavarropas Carga Frontal Samsung 6.5 Kg 1000 RPM WW65M0NHWU", 89999, 5 },
                    { 4, "Lavarropas Drean Gold 10.8 Eco.", "https://orcorestaurantimages.blob.core.windows.net/orco/lavarropas_2.jpg", "Lavarropas Drean Gold 10.8 Eco", 103499, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImageUrl", "Name", "Price", "ProductCategory" },
                values: new object[,]
                {
                    { 1, "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.", "https://orcorestaurantimages.blob.core.windows.net/orco/gancia.jpg", "Gancia", 15.0, 1 },
                    { 2, "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.", "https://orcorestaurantimages.blob.core.windows.net/orco/pasteldepapa.jfif", "Pastel de papa", 13.99, 3 },
                    { 3, "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.", "https://orcorestaurantimages.blob.core.windows.net/orco/budindepan.jpg", "Budín de pan", 10.99, 4 },
                    { 4, "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.", "https://orcorestaurantimages.blob.core.windows.net/orco/empanadas.jpg", "Empanada de carne", 15.0, 2 }
                });
        }
    }
}
