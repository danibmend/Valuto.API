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
                name: "SOLICITACAO_Juridico",
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
                    TIPO_Juridico_ID = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_SOLICITACAO_Juridico", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_Juridico_INDICADOR_SITUACAO_ID",
                        column: x => x.SITUACAO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_Juridico_INDICADOR_TIPO_ENDERECO_ID",
                        column: x => x.TIPO_ENDERECO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_Juridico_INDICADOR_TIPO_Juridico_ID",
                        column: x => x.TIPO_Juridico_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_Juridico_INDICADOR_TIPO_SOLICITACAO_ID",
                        column: x => x.TIPO_SOLICITACAO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_Juridico_MUNICIPIO_MUNICIPIO_ID",
                        column: x => x.MUNICIPIO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "MUNICIPIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SOLICITACAO_Pessoa",
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
                    table.PrimaryKey("PK_SOLICITACAO_Pessoa", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_Pessoa_INDICADOR_IGREJA_ID",
                        column: x => x.IGREJA_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_Pessoa_INDICADOR_SEXO_ID",
                        column: x => x.SEXO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_Pessoa_INDICADOR_SITUACAO_ID",
                        column: x => x.SITUACAO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_Pessoa_INDICADOR_TIPO_ENDERECO_ID",
                        column: x => x.TIPO_ENDERECO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_Pessoa_INDICADOR_TIPO_SOLICITACAO_ID",
                        column: x => x.TIPO_SOLICITACAO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SOLICITACAO_Pessoa_MUNICIPIO_MUNICIPIO_ID",
                        column: x => x.MUNICIPIO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "MUNICIPIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Juridico",
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
                    TIPO_Juridico_ID = table.Column<long>(type: "bigint", nullable: false),
                    DATA_CRIACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_ATUALIZACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATA_REMOCAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    USUARIO_CRIACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_ATUALIZACAO_ID = table.Column<long>(type: "bigint", nullable: false),
                    USUARIO_REMOCAO_ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juridico", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Juridico_ENDERECO_ENDERECO_ID",
                        column: x => x.ENDERECO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "ENDERECO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Juridico_INDICADOR_TIPO_Juridico_ID",
                        column: x => x.TIPO_Juridico_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
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
                    table.PrimaryKey("PK_Pessoa", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pessoa_ENDERECO_ENDERECO_ID",
                        column: x => x.ENDERECO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "ENDERECO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pessoa_INDICADOR_IGREJA_ID",
                        column: x => x.IGREJA_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pessoa_INDICADOR_SEXO_ID",
                        column: x => x.SEXO_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Juridico_CONTATO",
                schema: "JESUS_EM_NOS_DEV",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Juridico_ID = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Juridico_CONTATO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Juridico_CONTATO_INDICADOR_Contato_ClassificacaoId",
                        column: x => x.Contato_ClassificacaoId,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Juridico_CONTATO_INDICADOR_Contato_TipoContatoId",
                        column: x => x.Contato_TipoContatoId,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Juridico_CONTATO_Juridico_Juridico_ID",
                        column: x => x.Juridico_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "Juridico",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa_CONTATO",
                schema: "JESUS_EM_NOS_DEV",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Pessoa_ID = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Pessoa_CONTATO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pessoa_CONTATO_INDICADOR_Contato_ClassificacaoId",
                        column: x => x.Contato_ClassificacaoId,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pessoa_CONTATO_INDICADOR_Contato_TipoContatoId",
                        column: x => x.Contato_TipoContatoId,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "INDICADOR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pessoa_CONTATO_Pessoa_Pessoa_ID",
                        column: x => x.Pessoa_ID,
                        principalSchema: "JESUS_EM_NOS_DEV",
                        principalTable: "Pessoa",
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
                name: "IX_Juridico_CNPJ",
                schema: "JESUS_EM_NOS_DEV",
                table: "Juridico",
                column: "CNPJ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Juridico_ENDERECO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "Juridico",
                column: "ENDERECO_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Juridico_TIPO_Juridico_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "Juridico",
                column: "TIPO_Juridico_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Juridico_CONTATO_Contato_ClassificacaoId",
                schema: "JESUS_EM_NOS_DEV",
                table: "Juridico_CONTATO",
                column: "Contato_ClassificacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Juridico_CONTATO_Contato_TipoContatoId",
                schema: "JESUS_EM_NOS_DEV",
                table: "Juridico_CONTATO",
                column: "Contato_TipoContatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Juridico_CONTATO_Juridico_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "Juridico_CONTATO",
                column: "Juridico_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_Juridico_MUNICIPIO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_Juridico",
                column: "MUNICIPIO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_Juridico_SITUACAO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_Juridico",
                column: "SITUACAO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_Juridico_TIPO_ENDERECO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_Juridico",
                column: "TIPO_ENDERECO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_Juridico_TIPO_Juridico_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_Juridico",
                column: "TIPO_Juridico_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_Juridico_TIPO_SOLICITACAO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_Juridico",
                column: "TIPO_SOLICITACAO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_Pessoa_IGREJA_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_Pessoa",
                column: "IGREJA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_Pessoa_MUNICIPIO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_Pessoa",
                column: "MUNICIPIO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_Pessoa_SEXO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_Pessoa",
                column: "SEXO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_Pessoa_SITUACAO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_Pessoa",
                column: "SITUACAO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_Pessoa_TIPO_ENDERECO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_Pessoa",
                column: "TIPO_ENDERECO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLICITACAO_Pessoa_TIPO_SOLICITACAO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "SOLICITACAO_Pessoa",
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
                name: "IX_Pessoa_CPF",
                schema: "JESUS_EM_NOS_DEV",
                table: "Pessoa",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_ENDERECO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "Pessoa",
                column: "ENDERECO_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_IGREJA_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "Pessoa",
                column: "IGREJA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_SEXO_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "Pessoa",
                column: "SEXO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_CONTATO_Contato_ClassificacaoId",
                schema: "JESUS_EM_NOS_DEV",
                table: "Pessoa_CONTATO",
                column: "Contato_ClassificacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_CONTATO_Contato_TipoContatoId",
                schema: "JESUS_EM_NOS_DEV",
                table: "Pessoa_CONTATO",
                column: "Contato_TipoContatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_CONTATO_Pessoa_ID",
                schema: "JESUS_EM_NOS_DEV",
                table: "Pessoa_CONTATO",
                column: "Pessoa_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Juridico_CONTATO",
                schema: "JESUS_EM_NOS_DEV");

            migrationBuilder.DropTable(
                name: "SOLICITACAO_Juridico",
                schema: "JESUS_EM_NOS_DEV");

            migrationBuilder.DropTable(
                name: "SOLICITACAO_Pessoa",
                schema: "JESUS_EM_NOS_DEV");

            migrationBuilder.DropTable(
                name: "Pessoa_CONTATO",
                schema: "JESUS_EM_NOS_DEV");

            migrationBuilder.DropTable(
                name: "Juridico",
                schema: "JESUS_EM_NOS_DEV");

            migrationBuilder.DropTable(
                name: "Pessoa",
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
