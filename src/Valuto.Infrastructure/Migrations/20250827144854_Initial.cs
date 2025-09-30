using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Valuto.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "JESUS_EM_NOS_DEV");

            migrationBuilder.CreateTable(
                name: "ESTADO",
                schema: "JESUS_EM_NOS_DEV",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SIGLA = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    NOME = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    DATA_CRIACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_ATUALIZACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_REMOCAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    USUARIO_CRIACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_ATUALIZACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_REMOCAO_ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESTADO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TIPO_INDICADOR",
                schema: "JESUS_EM_NOS_DEV",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NOME = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    SIGLA = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    DESCRICAO = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    DATA_CRIACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_ATUALIZACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_REMOCAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    USUARIO_CRIACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_ATUALIZACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_REMOCAO_ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPO_INDICADOR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MUNICIPIO",
                schema: "JESUS_EM_NOS_DEV",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    COD_IBGE7 = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false),
                    NOME = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ESTADO_ID = table.Column<long>(type: "bigint", nullable: false),
                    DATA_CRIACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_ATUALIZACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_REMOCAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    USUARIO_CRIACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_ATUALIZACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_REMOCAO_ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MUNICIPIO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MUNICIPIO_ESTADO_ESTADO_ID",
                        column: x => x.ESTADO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "ESTADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INDICADOR",
                schema: "JESUS_EM_NOS_DEV",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NOME = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    SIGLA = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    DESCRICAO = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    TIPO_INDICADOR_ID = table.Column<long>(type: "bigint", nullable: false),
                    DATA_CRIACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_ATUALIZACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_REMOCAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    USUARIO_CRIACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_ATUALIZACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_REMOCAO_ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INDICADOR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_INDICADOR_TipoIndicador_TIPO_INDICADOR_ID",
                        column: x => x.TIPO_INDICADOR_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "TIPO_INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ENDERECO",
                schema: "JESUS_EM_NOS_DEV",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LOGRADOURO = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    NUMERO = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    COMPLEMENTO = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    BAIRRO = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CEP = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false),
                    TIPO_ENDERECO_ID = table.Column<long>(type: "bigint", nullable: false),
                    MUNICIPIO_ID = table.Column<long>(type: "bigint", nullable: false),
                    DATA_CRIACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_ATUALIZACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_REMOCAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    USUARIO_CRIACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_ATUALIZACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_REMOCAO_ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENDERECO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ENDERECO_Indicador_TIPO_ENDERECO_ID",
                        column: x => x.TIPO_ENDERECO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ENDERECO_Municipio_MUNICIPIO_ID",
                        column: x => x.MUNICIPIO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "MUNICIPIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SOLICITACAO_PARCEIRO",
                schema: "JESUS_EM_NOS_DEV",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NOME = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CNPJ = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    NOME_RESPONSAVEL = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CPF_RESPONSAVEL = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    EMAIL = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    TELEFONE = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    EMAIL_RESPONSAVEL = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    TELEFONE_RESPONSAVEL = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    URL_FOTO = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    LOGRADOURO = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    NUMERO = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    COMPLEMENTO = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    CEP = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false),
                    BAIRRO = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    TIPO_ENDERECO_ID = table.Column<long>(type: "bigint", nullable: false),
                    MUNICIPIO_ID = table.Column<long>(type: "bigint", nullable: false),
                    DATA_RESOLUCAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    TIPO_PARCEIRO_ID = table.Column<long>(type: "bigint", nullable: false),
                    TIPO_SOLICITACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    SITUACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    DATA_CRIACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_ATUALIZACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_REMOCAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    USUARIO_CRIACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_ATUALIZACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_REMOCAO_ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOLICITACAO_PARCEIRO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_PARCEIRO_INDICADOR_SITUACAO_ID",
                        column: x => x.SITUACAO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_PARCEIRO_INDICADOR_TIPO_ENDERECO_ID",
                        column: x => x.TIPO_ENDERECO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_PARCEIRO_INDICADOR_TIPO_PARCEIRO_ID",
                        column: x => x.TIPO_PARCEIRO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_PARCEIRO_INDICADOR_TIPO_SOLICITACAO_ID",
                        column: x => x.TIPO_SOLICITACAO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_PARCEIRO_MUNICIPIO_MUNICIPIO_ID",
                        column: x => x.MUNICIPIO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "MUNICIPIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SOLICITACAO_VOLUNTARIO",
                schema: "JESUS_EM_NOS_DEV",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NOME = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CPF = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    EMAIL = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    TELEFONE = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    URL_FOTO = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    DATA_NASCIMENTO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SEXO_ID = table.Column<long>(type: "bigint", nullable: false),
                    IGREJA_ID = table.Column<long>(type: "bigint", nullable: false),
                    LOGRADOURO = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    NUMERO = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    COMPLEMENTO = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    BAIRRO = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CEP = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false),
                    TIPO_ENDERECO_ID = table.Column<long>(type: "bigint", nullable: false),
                    MUNICIPIO_ID = table.Column<long>(type: "bigint", nullable: false),
                    DATA_RESOLUCAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    TIPO_SOLICITACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    SITUACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    DATA_CRIACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_ATUALIZACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_REMOCAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    USUARIO_CRIACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_ATUALIZACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_REMOCAO_ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOLICITACAO_VOLUNTARIO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_VOLUNTARIO_INDICADOR_IGREJA_ID",
                        column: x => x.IGREJA_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_VOLUNTARIO_INDICADOR_SEXO_ID",
                        column: x => x.SEXO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_VOLUNTARIO_INDICADOR_SITUACAO_ID",
                        column: x => x.SITUACAO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_VOLUNTARIO_INDICADOR_TIPO_ENDERECO_ID",
                        column: x => x.TIPO_ENDERECO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_VOLUNTARIO_INDICADOR_TIPO_SOLICITACAO_ID",
                        column: x => x.TIPO_SOLICITACAO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_VOLUNTARIO_MUNICIPIO_MUNICIPIO_ID",
                        column: x => x.MUNICIPIO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "MUNICIPIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PARCEIRO",
                schema: "JESUS_EM_NOS_DEV",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NOME = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CNPJ = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    NOME_RESPONSAVEL = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CPF_RESPONSAVEL = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    URL_FOTO = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    ENDERECO_ID = table.Column<long>(type: "bigint", nullable: false),
                    TIPO_PARCEIRO_ID = table.Column<long>(type: "bigint", nullable: false),
                    DATA_CRIACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_ATUALIZACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_REMOCAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    USUARIO_CRIACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_ATUALIZACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_REMOCAO_ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PARCEIRO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PARCEIRO_ENDERECO_ENDERECO_ID",
                        column: x => x.ENDERECO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "ENDERECO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PARCEIRO_INDICADOR_TIPO_PARCEIRO_ID",
                        column: x => x.TIPO_PARCEIRO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VOLUNTARIO",
                schema: "JESUS_EM_NOS_DEV",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NOME = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CPF = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    DATA_NASCIMENTO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SEXO_ID = table.Column<long>(type: "bigint", nullable: false),
                    URL_FOTO = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    ENDERECO_ID = table.Column<long>(type: "bigint", nullable: false),
                    IGREJA_ID = table.Column<long>(type: "bigint", nullable: false),
                    DATA_CRIACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_ATUALIZACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_REMOCAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    USUARIO_CRIACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_ATUALIZACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_REMOCAO_ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VOLUNTARIO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VOLUNTARIO_ENDERECO_ENDERECO_ID",
                        column: x => x.ENDERECO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "ENDERECO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VOLUNTARIO_INDICADOR_IGREJA_ID",
                        column: x => x.IGREJA_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VOLUNTARIO_INDICADOR_SEXO_ID",
                        column: x => x.SEXO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PARCEIRO_CONTATO",
                schema: "JESUS_EM_NOS_DEV",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PARCEIRO_ID = table.Column<long>(type: "bigint", nullable: false),
                    Contato_Valor = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Contato_TipoContatoId = table.Column<long>(type: "bigint", nullable: false),
                    Contato_ClassificacaoId = table.Column<long>(type: "bigint", nullable: false),
                    DATA_CRIACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_ATUALIZACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_REMOCAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    USUARIO_CRIACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_ATUALIZACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_REMOCAO_ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PARCEIRO_CONTATO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PARCEIRO_CONTATO_INDICADOR_Contato_ClassificacaoId",
                        column: x => x.Contato_ClassificacaoId,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PARCEIRO_CONTATO_INDICADOR_Contato_TipoContatoId",
                        column: x => x.Contato_TipoContatoId,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PARCEIRO_CONTATO_PARCEIRO_PARCEIRO_ID",
                        column: x => x.PARCEIRO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "PARCEIRO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VOLUNTARIO_CONTATO",
                schema: "JESUS_EM_NOS_DEV",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VOLUNTARIO_ID = table.Column<long>(type: "bigint", nullable: false),
                    Contato_Valor = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Contato_TipoContatoId = table.Column<long>(type: "bigint", nullable: false),
                    Contato_ClassificacaoId = table.Column<long>(type: "bigint", nullable: false),
                    DATA_CRIACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_ATUALIZACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_REMOCAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    USUARIO_CRIACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_ATUALIZACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_REMOCAO_ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VOLUNTARIO_CONTATO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VOLUNTARIO_CONTATO_INDICADOR_Contato_ClassificacaoId",
                        column: x => x.Contato_ClassificacaoId,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VOLUNTARIO_CONTATO_INDICADOR_Contato_TipoContatoId",
                        column: x => x.Contato_TipoContatoId,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VOLUNTARIO_CONTATO_VOLUNTARIO_VOLUNTARIO_ID",
                        column: x => x.VOLUNTARIO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "VOLUNTARIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ENDERECO_MUNICIPIO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "ENDERECO",
                column: "MUNICIPIO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ENDERECO_TIPO_ENDERECO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "ENDERECO",
                column: "TIPO_ENDERECO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ESTADO_NOME",
                schema: "JESUS_EM_NOS_DEV",
                table: "ESTADO",
                column: "NOME",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ESTADO_SIGLA",
                schema: "JESUS_EM_NOS_DEV",
                table: "ESTADO",
                column: "SIGLA",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_INDICADOR_NOME",
                schema: "JESUS_EM_NOS_DEV",
                table: "INDICADOR",
                column: "NOME",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_INDICADOR_SIGLA",
                schema: "JESUS_EM_NOS_DEV",
                table: "INDICADOR",
                column: "SIGLA",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_INDICADOR_TIPO_INDICADOR_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "INDICADOR",
                column: "TIPO_INDICADOR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_MUNICIPIO_COD_IBGE7",
                schema: "JESUS_EM_NOS_DEV",
                table: "MUNICIPIO",
                column: "COD_IBGE7",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MUNICIPIO_ESTADO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "MUNICIPIO",
                column: "ESTADO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PARCEIRO_CNPJ",
                schema: "JESUS_EM_NOS_DEV",
                table: "PARCEIRO",
                column: "CNPJ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PARCEIRO_ENDERECO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "PARCEIRO",
                column: "ENDERECO_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PARCEIRO_TIPO_PARCEIRO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "PARCEIRO",
                column: "TIPO_PARCEIRO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PARCEIRO_CONTATO_Contato_ClassificacaoId",
                schema: "JESUS_EM_NOS_DEV",
                table: "PARCEIRO_CONTATO",
                column: "Contato_ClassificacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_PARCEIRO_CONTATO_Contato_TipoContatoId",
                schema: "JESUS_EM_NOS_DEV",
                table: "PARCEIRO_CONTATO",
                column: "Contato_TipoContatoId");

            migrationBuilder.CreateIndex(
                name: "IX_PARCEIRO_CONTATO_PARCEIRO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "PARCEIRO_CONTATO",
                column: "PARCEIRO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_PARCEIRO_MUNICIPIO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_PARCEIRO",
                column: "MUNICIPIO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_PARCEIRO_SITUACAO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_PARCEIRO",
                column: "SITUACAO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_PARCEIRO_TIPO_ENDERECO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_PARCEIRO",
                column: "TIPO_ENDERECO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_PARCEIRO_TIPO_PARCEIRO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_PARCEIRO",
                column: "TIPO_PARCEIRO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_PARCEIRO_TIPO_SOLICITACAO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_PARCEIRO",
                column: "TIPO_SOLICITACAO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_VOLUNTARIO_IGREJA_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_VOLUNTARIO",
                column: "IGREJA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_VOLUNTARIO_MUNICIPIO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_VOLUNTARIO",
                column: "MUNICIPIO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_VOLUNTARIO_SEXO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_VOLUNTARIO",
                column: "SEXO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_VOLUNTARIO_SITUACAO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_VOLUNTARIO",
                column: "SITUACAO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_VOLUNTARIO_TIPO_ENDERECO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_VOLUNTARIO",
                column: "TIPO_ENDERECO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_VOLUNTARIO_TIPO_SOLICITACAO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_VOLUNTARIO",
                column: "TIPO_SOLICITACAO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TIPO_INDICADOR_NOME",
                schema: "JESUS_EM_NOS_DEV",
                table: "TIPO_INDICADOR",
                column: "NOME",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TIPO_INDICADOR_SIGLA",
                schema: "JESUS_EM_NOS_DEV",
                table: "TIPO_INDICADOR",
                column: "SIGLA",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VOLUNTARIO_CPF",
                schema: "JESUS_EM_NOS_DEV",
                table: "VOLUNTARIO",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VOLUNTARIO_ENDERECO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "VOLUNTARIO",
                column: "ENDERECO_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VOLUNTARIO_IGREJA_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "VOLUNTARIO",
                column: "IGREJA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_VOLUNTARIO_SEXO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "VOLUNTARIO",
                column: "SEXO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_VOLUNTARIO_CONTATO_Contato_ClassificacaoId",
                schema: "JESUS_EM_NOS_DEV",
                table: "VOLUNTARIO_CONTATO",
                column: "Contato_ClassificacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_VOLUNTARIO_CONTATO_Contato_TipoContatoId",
                schema: "JESUS_EM_NOS_DEV",
                table: "VOLUNTARIO_CONTATO",
                column: "Contato_TipoContatoId");

            migrationBuilder.CreateIndex(
                name: "IX_VOLUNTARIO_CONTATO_VOLUNTARIO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "VOLUNTARIO_CONTATO",
                column: "VOLUNTARIO_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PARCEIRO_CONTATO",
                schema: "JESUS_EM_NOS_DEV");

            migrationBuilder.DropTable(
                name: "SOLICITACAO_PARCEIRO",
                schema: "JESUS_EM_NOS_DEV");

            migrationBuilder.DropTable(
                name: "SOLICITACAO_VOLUNTARIO",
                schema: "JESUS_EM_NOS_DEV");

            migrationBuilder.DropTable(
                name: "VOLUNTARIO_CONTATO",
                schema: "JESUS_EM_NOS_DEV");

            migrationBuilder.DropTable(
                name: "PARCEIRO",
                schema: "JESUS_EM_NOS_DEV");

            migrationBuilder.DropTable(
                name: "VOLUNTARIO",
                schema: "JESUS_EM_NOS_DEV");

            migrationBuilder.DropTable(
                name: "ENDERECO",
                schema: "JESUS_EM_NOS_DEV");

            migrationBuilder.DropTable(
                name: "INDICADOR",
                schema: "JESUS_EM_NOS_DEV");

            migrationBuilder.DropTable(
                name: "MUNICIPIO",
                schema: "JESUS_EM_NOS_DEV");

            migrationBuilder.DropTable(
                name: "TIPO_INDICADOR",
                schema: "JESUS_EM_NOS_DEV");

            migrationBuilder.DropTable(
                name: "ESTADO",
                schema: "JESUS_EM_NOS_DEV");
        }
    }
}
