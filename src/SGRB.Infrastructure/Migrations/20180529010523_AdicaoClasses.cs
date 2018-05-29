using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SGRB.Infrastructure.Migrations
{
    public partial class AdicaoClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalculoBasal",
                columns: table => new
                {
                    CalculoBasalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculoBasal", x => x.CalculoBasalId);
                });

            migrationBuilder.CreateTable(
                name: "CaracterizacaodaArea",
                columns: table => new
                {
                    CaracterizacaoAreaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cidade = table.Column<string>(nullable: true),
                    DescricaoAmbiente = table.Column<string>(nullable: true),
                    TamanhoPropriedade = table.Column<double>(nullable: false),
                    TipoArea = table.Column<string>(nullable: true),
                    TipoClima = table.Column<string>(nullable: true),
                    TipoSolo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaracterizacaodaArea", x => x.CaracterizacaoAreaId);
                });

            migrationBuilder.CreateTable(
                name: "ColetadeAmostra",
                columns: table => new
                {
                    ColetaAmostraId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Armazenamento = table.Column<string>(nullable: true),
                    DataColeta = table.Column<DateTime>(nullable: false),
                    PesoAmostra = table.Column<double>(nullable: false),
                    Profundidade = table.Column<int>(nullable: false),
                    Sazonalidade = table.Column<bool>(nullable: false),
                    TempodeRepouso = table.Column<int>(nullable: false),
                    TipodeEcossistema = table.Column<string>(nullable: true),
                    TipodeTratamento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColetadeAmostra", x => x.ColetaAmostraId);
                });

            migrationBuilder.CreateTable(
                name: "MateriaiseEquipamentos",
                columns: table => new
                {
                    MateriaisEquipamentosId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MateriaisUtilizados = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriaiseEquipamentos", x => x.MateriaisEquipamentosId);
                });

            migrationBuilder.CreateTable(
                name: "ProcessamentodeAmostra",
                columns: table => new
                {
                    ProcessamentoAmostraId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescricaoProcedimento = table.Column<string>(nullable: true),
                    Peneira = table.Column<int>(nullable: false),
                    PeriodoIncubacao = table.Column<DateTime>(nullable: false),
                    Refrigeracao = table.Column<double>(nullable: false),
                    Solucoes = table.Column<string>(nullable: true),
                    TipodeArmazenamento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessamentodeAmostra", x => x.ProcessamentoAmostraId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalculoBasal");

            migrationBuilder.DropTable(
                name: "CaracterizacaodaArea");

            migrationBuilder.DropTable(
                name: "ColetadeAmostra");

            migrationBuilder.DropTable(
                name: "MateriaiseEquipamentos");

            migrationBuilder.DropTable(
                name: "ProcessamentodeAmostra");
        }
    }
}
