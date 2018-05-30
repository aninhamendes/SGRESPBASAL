using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SGRB.Infrastructure.Migrations
{
    public partial class Initial : Migration
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
                    Cidade = table.Column<string>(type: "varchar(100)", nullable: false),
                    DescricaoAmbiente = table.Column<string>(type: "varchar(10000)", nullable: false),
                    TamanhoPropriedade = table.Column<double>(type: "varchar(100)", nullable: false),
                    TipoArea = table.Column<string>(type: "varchar(100)", nullable: false),
                    TipoClima = table.Column<string>(type: "varchar(100)", nullable: false),
                    TipoSolo = table.Column<string>(type: "varchar(100)", nullable: false)
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
                    Armazenamento = table.Column<string>(type: "varchar(10000)", nullable: false),
                    DataColeta = table.Column<DateTime>(type: "varchar(100)", nullable: false),
                    PesoAmostra = table.Column<double>(type: "varchar(40)", nullable: false),
                    Profundidade = table.Column<int>(type: "varchar(50)", nullable: false),
                    Sazonalidade = table.Column<bool>(type: "varchar(100)", nullable: false),
                    TempodeRepouso = table.Column<int>(type: "varchar(30)", nullable: false),
                    TipodeEcossistema = table.Column<string>(type: "varchar(200)", nullable: false),
                    TipodeTratamento = table.Column<string>(type: "varchar(10000)", nullable: false)
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
                name: "Pesquisador",
                columns: table => new
                {
                    PesquisadorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InstituicaoDeEnsino = table.Column<string>(type: "varchar(100)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pesquisador", x => x.PesquisadorId);
                });

            migrationBuilder.CreateTable(
                name: "ProcessamentodeAmostra",
                columns: table => new
                {
                    ProcessamentoAmostraId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescricaoProcedimento = table.Column<string>(type: "varchar(8000)", nullable: false),
                    Peneira = table.Column<int>(type: "varchar(10)", nullable: false),
                    PeriodoIncubacao = table.Column<DateTime>(type: "varchar(50)", nullable: false),
                    Refrigeracao = table.Column<double>(type: "varchar(30)", nullable: false),
                    Solucoes = table.Column<string>(type: "varchar(3000)", nullable: false),
                    TipodeArmazenamento = table.Column<string>(type: "varchar(5000)", nullable: false)
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
                name: "Pesquisador");

            migrationBuilder.DropTable(
                name: "ProcessamentodeAmostra");
        }
    }
}
