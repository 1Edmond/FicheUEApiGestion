using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FicheUEApiGestion.Migrations
{
    /// <inheritdoc />
    public partial class FicheGenerate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Departement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Orientation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cycle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlocEtude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Situation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UEPrequises = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UECorequises = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LangueEnseignementId = table.Column<int>(type: "int", nullable: false),
                    LangueEvaluationId = table.Column<int>(type: "int", nullable: false),
                    RepsonableId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Capacites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompetenceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capacites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Competences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsOnline = table.Column<bool>(type: "bit", nullable: false),
                    Acquis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSupportObligatoire = table.Column<bool>(type: "bit", nullable: false),
                    LangueEnseignement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LangueEvaluation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitulaireId = table.Column<int>(type: "int", nullable: false),
                    CodeUE = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cursus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Implantation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelSecretariat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enseignants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enseignants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Langues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Langues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Libres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valeur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoursId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModeEvaluations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeEvaluationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeEvaluations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeEvaluations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Session = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pourcentage = table.Column<float>(type: "real", nullable: false),
                    NotFinale = table.Column<float>(type: "real", nullable: false),
                    CoursId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeEvaluations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UEs",
                columns: table => new
                {
                    CodeUE = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Departement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Orientation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Implantation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Situation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlocEtudes = table.Column<int>(type: "int", nullable: false),
                    NomUE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UEPrerequises = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UECorequises = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VolumeHoraire = table.Column<int>(type: "int", nullable: false),
                    NbrCredits = table.Column<int>(type: "int", nullable: false),
                    ResponsableId = table.Column<int>(type: "int", nullable: false),
                    Competences = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoteUE = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UEs", x => x.CodeUE);
                });

            migrationBuilder.InsertData(
                table: "Langues",
                columns: new[] { "Id", "Libelle" },
                values: new object[,]
                {
                    { 1, "Français" },
                    { 2, "Anglais" },
                    { 3, "Espagnol" },
                    { 4, "Néerlandais" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminFields");

            migrationBuilder.DropTable(
                name: "Capacites");

            migrationBuilder.DropTable(
                name: "Competences");

            migrationBuilder.DropTable(
                name: "Cours");

            migrationBuilder.DropTable(
                name: "Cursus");

            migrationBuilder.DropTable(
                name: "Enseignants");

            migrationBuilder.DropTable(
                name: "Langues");

            migrationBuilder.DropTable(
                name: "Libres");

            migrationBuilder.DropTable(
                name: "ModeEvaluations");

            migrationBuilder.DropTable(
                name: "TypeEvaluations");

            migrationBuilder.DropTable(
                name: "UEs");
        }
    }
}
