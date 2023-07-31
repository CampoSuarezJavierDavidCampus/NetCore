using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    idMarca = table.Column<int>(type: "int", maxLength: 12, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idDescipcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.idMarca);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    idPais = table.Column<int>(type: "int", maxLength: 12, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombrePais = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.idPais);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoPersona",
                columns: table => new
                {
                    idTIpoPersona = table.Column<int>(type: "int", maxLength: 12, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    desciptionTIpoPersona = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPersona", x => x.idTIpoPersona);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    idProducto = table.Column<int>(type: "int", maxLength: 12, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Referencia = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Precio = table.Column<double>(type: "double", nullable: true),
                    IdMarca = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    DescipcionProducto = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.idProducto);
                    table.ForeignKey(
                        name: "FK_Producto_Marca_IdMarca",
                        column: x => x.IdMarca,
                        principalTable: "Marca",
                        principalColumn: "idMarca",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    idRegion = table.Column<int>(type: "int", maxLength: 12, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idPais = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    nombreRegion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.idRegion);
                    table.ForeignKey(
                        name: "FK_Region_Pais_idPais",
                        column: x => x.idPais,
                        principalTable: "Pais",
                        principalColumn: "idPais",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Provincia",
                columns: table => new
                {
                    idProvincia = table.Column<int>(type: "int", maxLength: 12, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idRegion = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    nombreProvincia = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincia", x => x.idProvincia);
                    table.ForeignKey(
                        name: "FK_Provincia_Region_idRegion",
                        column: x => x.idRegion,
                        principalTable: "Region",
                        principalColumn: "idRegion",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    idPersona = table.Column<int>(type: "int", maxLength: 12, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    apellidoPersona = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    edadPersona = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    idProv = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    idTipPer = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    nombrePersona = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.idPersona);
                    table.ForeignKey(
                        name: "FK_Persona_Provincia_idProv",
                        column: x => x.idProv,
                        principalTable: "Provincia",
                        principalColumn: "idProvincia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persona_TipoPersona_idTipPer",
                        column: x => x.idTipPer,
                        principalTable: "TipoPersona",
                        principalColumn: "idTIpoPersona",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductoPersona",
                columns: table => new
                {
                    idPersona = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    idProducto = table.Column<int>(type: "int", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoPersona", x => new { x.idPersona, x.idProducto });
                    table.ForeignKey(
                        name: "FK_ProductoPersona_Persona_idPersona",
                        column: x => x.idPersona,
                        principalTable: "Persona",
                        principalColumn: "idPersona",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductoPersona_Producto_idProducto",
                        column: x => x.idProducto,
                        principalTable: "Producto",
                        principalColumn: "idProducto",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_idProv",
                table: "Persona",
                column: "idProv");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_idTipPer",
                table: "Persona",
                column: "idTipPer");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_IdMarca",
                table: "Producto",
                column: "IdMarca");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoPersona_idProducto",
                table: "ProductoPersona",
                column: "idProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Provincia_idRegion",
                table: "Provincia",
                column: "idRegion");

            migrationBuilder.CreateIndex(
                name: "IX_Region_idPais",
                table: "Region",
                column: "idPais");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductoPersona");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Provincia");

            migrationBuilder.DropTable(
                name: "TipoPersona");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
