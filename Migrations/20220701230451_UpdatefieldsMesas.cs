using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PLANTILLA_API_ODATA.Migrations
{
    public partial class UpdatefieldsMesas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ACA_CRONOGRAMA_PAGO_ALUMNO",
                columns: table => new
                {
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    MES = table.Column<decimal>(type: "numeric(2,0)", nullable: false),
                    NUM_MODALIDAD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    FECHA_VENCIMIENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    DESCUENTO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMPORTE_PAGAR = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACA_CRONOGRAMA_PAGO_ALUMNO", x => new { x.ANO, x.MES, x.NUM_MODALIDAD, x.ID_PERSONA, x.ID_PRODUCTO, x.SECUENCIA });
                });

            migrationBuilder.CreateTable(
                name: "ACA_MATRICULA",
                columns: table => new
                {
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    NUM_MODALIDAD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    DNI_ALUMNO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NOMBRE_ALUMNO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DIRECCION_ALUMNO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    GRADO_ACADEMICO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    NIVEL_ACADEMICO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    SECCION_ACADEMICO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    AULA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NOMBRE_APODERADO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    DIRECCION_APODERADO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ACA_MATRICULA_CURSO",
                columns: table => new
                {
                    NUM_MODALIDAD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    NUM_CURSO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ACA_PENSION_ALUMNO",
                columns: table => new
                {
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    MES = table.Column<decimal>(type: "numeric(2,0)", nullable: false),
                    NUM_MODALIDAD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    FECHA_VENCIMIENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    INICIAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PRIMARIA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    SECUNDARIA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACA_PENSION_ALUMNO_1", x => new { x.ANO, x.MES, x.NUM_MODALIDAD, x.ID_PRODUCTO });
                });

            migrationBuilder.CreateTable(
                name: "AFI_ACTIVO_FIJO",
                columns: table => new
                {
                    ID_PROVEEDOR = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NUMERO_DOCUMENTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    MONEDA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    FECHA_DOCUMENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    DEPRECIACION = table.Column<decimal>(type: "numeric(6,4)", nullable: true),
                    CENTRO_COSTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    NRO_SERIE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SERIE_GENERADA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(7,2)", nullable: false),
                    CDG_MARCA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    CDG_MODELO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    METODO_DEPRECIACION = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    SITUACION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    DEPRECIABLE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    AJUSTE_INFLACION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(7,0)", nullable: false),
                    MESES_DEPRE = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AFI_DEPRECIACION",
                columns: table => new
                {
                    ANO = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    MES = table.Column<decimal>(type: "numeric(2,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    NRO_SERIE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    SERIE_GENERADA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMP_OTRO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    MONEDA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    CENTRO_COSTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BI_DETALLE_TABLA",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NUMERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    REFERENCIA1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA3 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA4 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA5 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA6 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA7 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA8 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA9 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA10 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA11 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA12 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA13 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA14 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA15 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA16 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA17 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA18 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA19 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA20 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA21 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA22 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA23 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA24 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA25 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA26 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA27 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA28 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA29 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA30 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "date", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BI_QUERY",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CATEGORIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NOMBRE = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    VISTA = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ORIGEN_BD = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BI_TABLA",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    IdCategoria = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    NombreCorto = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Estado = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    IdParent = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    NombreImagen = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MOFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFCACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "CLI_CITA",
                columns: table => new
                {
                    ID_CITA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ESPECIALIDAD = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_CITA = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_PROGRAMADA = table.Column<DateTime>(type: "datetime", nullable: false),
                    HORARIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TURNO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DETALLE = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLI_CITA", x => x.ID_CITA);
                });

            migrationBuilder.CreateTable(
                name: "CLI_HISTORIA_PACIENTE",
                columns: table => new
                {
                    ID_HISTORIA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    FECHA_ATENCION = table.Column<DateTime>(type: "datetime", nullable: true),
                    MEDICO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ESPECIALDAD = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    EXPLORACION_HECHA = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    DIAGNOSTICO_HECHA = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    TRATAMIENTO_HECHA = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    OBSERVACION_HECHA = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLI_HISTORIA_PACIENTE", x => x.ID_HISTORIA);
                });

            migrationBuilder.CreateTable(
                name: "COM_COMISION_FACT",
                columns: table => new
                {
                    ANO = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    MES = table.Column<decimal>(type: "numeric(2,0)", nullable: false),
                    VENDEDOR = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CUOTA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    VALOR_NETO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    COMISION = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    COBRANZA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    COMISION_PAGAR = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    MONEDA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    POR_CUMPLIMIENTO = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuario_modificacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONF_ALERTA",
                columns: table => new
                {
                    ALERTA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    NOMBRE_ALERTA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONF_ALERTA", x => x.ALERTA);
                });

            migrationBuilder.CreateTable(
                name: "CONF_ALUS",
                columns: table => new
                {
                    ALERTA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    TITULO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    MENSAJE = table.Column<string>(type: "nchar(200)", fixedLength: true, maxLength: 200, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    AVISAR_ANTES = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    AVISAR_HASTA = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    USUARIOS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    FRECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONF_ALUS", x => x.ALERTA);
                });

            migrationBuilder.CreateTable(
                name: "CONF_CONDICION",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONF_DETALLE_CONDICION",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CODIGO2 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    REFERENCIA1 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    REFERENCIA2 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    REFERENCIA3 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    REFERENCIA4 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    REFERENCIA5 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONF_DETALLE_CONDICION", x => new { x.CODIGO, x.CODIGO2, x.MONEDA, x.REFERENCIA1 });
                });

            migrationBuilder.CreateTable(
                name: "CONF_DISENO_DOCUMENTO",
                columns: table => new
                {
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NOMBRE_COLUMNA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false),
                    LONGITUD = table.Column<int>(type: "int", nullable: false),
                    ORDEN = table.Column<int>(type: "int", nullable: false),
                    SALTO_LINEA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ALINEACION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    FUENTE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ESTILO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TAMANO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NRO_DECIMAL = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONF_DOCUMENTO",
                columns: table => new
                {
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    NOMBRE_EMPRESA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    RUC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DIRECCION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    COMENTARIO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    REFERENCIA1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA3 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA4 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA5 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA6 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA7 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA8 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA9 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA10 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONF_ECE",
                columns: table => new
                {
                    NOMBRE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    DESCRIPCION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    REFERENCIA1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONF_ECE", x => x.NOMBRE);
                });

            migrationBuilder.CreateTable(
                name: "CONF_GEN_COD",
                columns: table => new
                {
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PREFIJO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONF_PARAMETRO",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    REF1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONF_QUERY",
                columns: table => new
                {
                    MODULO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CONSULTA = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    DESCRIPCION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONF_SERVIDOR_BD",
                columns: table => new
                {
                    RUC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    SERVIDOR = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    BASE_DATO = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    TIPO_SEGURIDAD = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    USUARIO = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    CONTRASENA = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    RUTA_BASE_DATO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    NOM_SERVIDOR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONF_SWT_MD",
                columns: table => new
                {
                    MD = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    SWT_MD = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: false),
                    CNT_MD = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: false),
                    US_CR = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: false),
                    FC_CR = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONF_SWT_MD", x => x.MD);
                });

            migrationBuilder.CreateTable(
                name: "CONF_USAL",
                columns: table => new
                {
                    ALERTA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    TITULO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    MENSAJE = table.Column<string>(type: "nchar(200)", fixedLength: true, maxLength: 200, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIOS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    FRECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONF_USAL", x => x.ALERTA);
                });

            migrationBuilder.CreateTable(
                name: "CONF_USUARIO_ALERTA",
                columns: table => new
                {
                    ALERTA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    USUARIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    LIBERAR = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    APROBAR = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    RECHAZAR = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONF_VIGENCIA",
                columns: table => new
                {
                    CDG_PARAM = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    VALOR = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    REFERENCIA1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    REFERENCIA2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    REFERENCIA3 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_VIGENCIA = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTA_ANALITICA",
                columns: table => new
                {
                    codigo = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    codigo_analitico = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    descripcion = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    estado = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    usuario_modificacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTA_DETALLE_MODELO",
                columns: table => new
                {
                    cdg_tope = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    num_cor = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cdg_cope = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    debe = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    haber = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    cdg_ccto = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    pro_fin = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    cdg_tmov = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    cdg_tana = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    cdg_mon = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    tipo = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('C')"),
                    pro_ini = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TIPO_PRODUCTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CATEGORIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTA_DETALLE_VOUCHE",
                columns: table => new
                {
                    ano_vouc = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    mes_vouc = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    cdg_tas = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    num_vouc = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    num_sec = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cdg_tdoc = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cdg_tana = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cdg_anal = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    cdg_cct = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cdg_cta = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    num_docu = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    fec_docu = table.Column<DateTime>(type: "datetime", nullable: true),
                    vct_docu = table.Column<DateTime>(type: "datetime", nullable: true),
                    cdg_mon = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    deb_nac = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    hab_nac = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    tip_cmb = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    gls_vouc = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    swt_vouc = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "((0))"),
                    swt_ama = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "((0))"),
                    deb_ext = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    hab_ext = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    num_reg = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    CDG_TOPE = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    REFERENCIA1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    REFERENCIA2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    REFERENCIA3 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CDG_TAS2 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTA_DLINEA_ESFI",
                columns: table => new
                {
                    swt_ef = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    cdg_rub = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    cdg_lin = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    cdg_cta = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    des_cta = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTA_LINEA_ESFI",
                columns: table => new
                {
                    swt_ef = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    cdg_rub = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    cdg_lin = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    des_lin = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    ord_lin = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    swt_lin = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    swt_fn = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    tipo = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    usuario_modificacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTA_MODELO",
                columns: table => new
                {
                    cdg_tope = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    cdg_tas = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTA_PLAN_CUENTA",
                columns: table => new
                {
                    conta_codigo = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    conta_descripcion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    conta_movimiento = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    conta_monetaria = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    conta_centro_costo = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    conta_oficial = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    conta_patrimonial = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    conta_deudora = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    conta_acrededora = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    conta_tipo_analitica = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    conta_cta_debe = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    conta_cta_haber = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    usuario_modificacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    conta_estado = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    conta_cambio = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    conta_ganancia = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    conta_perdida = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    conta_nivel_cuenta = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    conta_tipo_cuenta = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    conta_tipo_analisis = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    conta_cta_cte = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    conta_prc_gst = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    conta_cta_flujo = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    conta_cta_cierre = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    conta_moneda = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    conta_codigo_parent = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    conta_codigo_eq = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    conta_monetaria_especial = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTA_PROCESO_GESTION",
                columns: table => new
                {
                    conta_codigo = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    conta_cc = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    conta_debe = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    conta_haber = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTA_PROD_CTA",
                columns: table => new
                {
                    tipo_producto = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CATEGORIA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    cuenta_existencia = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cuenta_recibir = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cuenta_venta = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cuenta_costo_venta = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cuenta_compra = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cuenta_ingr_producto = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cuenta_proc_producto = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cuenta_vta_diferida = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cuenta_dev_vta = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cuenta_var_exi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cuenta_dev_compra = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cuenta_sal_of = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cuenta_dev_of = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cuenta_sal_con = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cuenta_dev_con = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cuenta_puente = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    usuario_creacion = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTA_RUBRO_ESFI",
                columns: table => new
                {
                    swt_ef = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    cdg_rub = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    des_rub = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    swt_rub = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    swt_ap = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    swt_fn = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    ftr_rub = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ord_rub = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    usuario_modificacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTA_SALDOS",
                columns: table => new
                {
                    ano_sld = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    mes_sld = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    cdg_cta = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    cdg_mon = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    deb_sld = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    deb_ofi = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    deb_pat = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    hab_sld = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    hab_ofi = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    hab_pat = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    venta = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    compra = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTA_SALDOSA",
                columns: table => new
                {
                    ano_sld = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    mes_sld = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    cdg_cta = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    cdg_mon = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    cdg_tana = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    cdg_anal = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    cdg_cct = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    deb_sld = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    deb_ofi = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    deb_pat = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    hab_sld = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    hab_ofi = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    hab_pat = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    venta = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    compra = table.Column<decimal>(type: "numeric(14,4)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTA_SALDOSAG",
                columns: table => new
                {
                    ano_sld = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    mes_sld = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    cdg_cta = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    cdg_mon = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    cdg_tana = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    cdg_anal = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    cdg_cct = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    deb_sld = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    deb_ofi = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    deb_pat = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    hab_sld = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    hab_ofi = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    hab_pat = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    venta = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    compra = table.Column<decimal>(type: "numeric(14,4)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTA_SALDOSCG",
                columns: table => new
                {
                    ano_sld = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    mes_sld = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    cdg_cta = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    cdg_mon = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    deb_sld = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    deb_ofi = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    deb_pat = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    hab_sld = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    hab_ofi = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    hab_pat = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    venta = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    compra = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTA_SALDOSD",
                columns: table => new
                {
                    ano_sld = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    mes_sld = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    cdg_cta = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    cdg_cct = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    cdg_mon = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    cdg_tana = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    cdg_anal = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    cdg_tdoc = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    num_docu = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    deb_nac = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    hab_nac = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    deb_ext = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    hab_ext = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    tip_cmb = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    swt_est = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTA_SALDOSDG",
                columns: table => new
                {
                    ano_sld = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    mes_sld = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    cdg_cta = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    cdg_cct = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    cdg_mon = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    cdg_tana = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    cdg_anal = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    cdg_tdoc = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    num_docu = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    deb_nac = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    hab_nac = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    deb_ext = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    hab_ext = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    tip_cmb = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    swt_est = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTA_SALDOSG",
                columns: table => new
                {
                    ano_sld = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    mes_sld = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    cdg_cta = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    cdg_mon = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    deb_sld = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    deb_ofi = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    deb_pat = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    hab_sld = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    hab_ofi = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    hab_pat = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    venta = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    compra = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTA_TIPO_CAMBIO",
                columns: table => new
                {
                    MONEDA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    VALOR_VENTA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    VALOR_COMPRA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    VALOR_COMERCIAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTA_TIPO_CAMBIO", x => new { x.MONEDA, x.FECHA_REGISTRO });
                });

            migrationBuilder.CreateTable(
                name: "CONTA_TIPO_OPERACION",
                columns: table => new
                {
                    cdg_tope = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cdg_cope = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cdg_tdoc = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    tab_cope = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    cam_cope = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    des_cope = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    swt_cope = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    cnd_cope = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    fec_cope = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    prd_cope = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    tmv_cope = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    cambio = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    mon_cope = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    grupo = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CONTA_VOUCHE",
                columns: table => new
                {
                    ano_vouc = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    mes_vouc = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    cdg_tas = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    num_vouc = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    swt_ofi = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    swt_pat = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    fec_vouc = table.Column<DateTime>(type: "datetime", nullable: true),
                    des_vouc = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    deb_tnac = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    hab_tnac = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    swt_vouc = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    deb_text = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    hab_text = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    swt_pre = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    cdg_tope = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    usuario_creacion = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuario_modificacion = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CRM_ANEXO_SEGUIMIENTO",
                columns: table => new
                {
                    ID_SEGUIMIENTO = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    NOMBRE_ARCHIVO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ARCHIVO = table.Column<byte[]>(type: "image", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    EXTENSION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CRM_APLAZAR_AVISO",
                columns: table => new
                {
                    ID_APLAZAR = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_AVISO = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    ASUNTO = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    FECHA_AVISO = table.Column<DateTime>(type: "datetime", nullable: false),
                    HORA_AVISO = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    TIEMPO = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    UNIDAD_TIEMPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CRM_APLAZAR_AVISO", x => x.ID_APLAZAR);
                });

            migrationBuilder.CreateTable(
                name: "CRM_AVISO",
                columns: table => new
                {
                    ID_AVISO = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_SEGUIMIENTO = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    TIPO_EVENTO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    DE_USUARIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    PARA_USUARIO_GRUPO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ASUNTO = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    FECHA_AVISO = table.Column<DateTime>(type: "datetime", nullable: false),
                    HORA_AVISO = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CRM_AVISO", x => x.ID_AVISO);
                });

            migrationBuilder.CreateTable(
                name: "CRM_CAMPANA",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CRM_CAMPANA_CLIENTE",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ID_LISTA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CRM_LISTA_MARKETING",
                columns: table => new
                {
                    ID_LISTA = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    DESCRIPCION = table.Column<string>(type: "varchar(3000)", unicode: false, maxLength: 3000, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CRM_LISTA_MARKETING", x => x.ID_LISTA);
                });

            migrationBuilder.CreateTable(
                name: "CRM_LISTA_MKT_INTEGRANTE",
                columns: table => new
                {
                    ID_LISTA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PROSPECTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_CLIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CRM_SEGUIMIENTO",
                columns: table => new
                {
                    ID_SEGUIMIENTO = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO_CAMPANA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_CLIENTE_CAMPANA = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    SITUACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_PARA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    PRIORIDAD = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    ID_CLIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: true),
                    HORA_INICIO = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: true),
                    HORA_FIN = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    LUGAR = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    TIPO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    PROCEDENCIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TIPO_SOLUCION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DESCRIPCION = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    SOLUCION = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REF1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TIPO_EVENTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    USUARIO_FINALIZACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_FINALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    HORA_FINALIZACION = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    USUARIO_REF1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_REF1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    HORA_REF1 = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    NOTA = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    ETAPA_VENTA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    MONEDA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    IMPORTE_ESTIMADO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    MES_CIERRE = table.Column<decimal>(type: "numeric(2,0)", nullable: true),
                    ANO_CIERRE = table.Column<decimal>(type: "numeric(4,0)", nullable: true),
                    ID_MAIN_PARENT = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    ID_PARENT = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    MOTIVO_PERDIDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    COMPETENCIA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    NOTA_PERDIDA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ASUNTO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SITIO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    TECNICO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SUCURSAL = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    NUM_COR = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CRM_SEGUIMIENTO", x => x.ID_SEGUIMIENTO);
                });

            migrationBuilder.CreateTable(
                name: "FE_DETALLE_RESUMEN_BAJA",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    TIPO_DOCU = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    NUME_DOCU = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NUM_ITEM = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    TDOC = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    SERIE = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    CORRELATIVO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    NUMDOC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    MOTIVO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FE_DETALLE_RESUMEN_BAJA", x => new { x.CODIGO_EMPRESA, x.TIPO_DOCU, x.NUME_DOCU, x.NUM_ITEM });
                });

            migrationBuilder.CreateTable(
                name: "FE_ERROR",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MENSAJE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "FE_RESUMEN_BAJA",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    TIPO_DOCU = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    NUME_DOCU = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    EST_REG = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_ENVIO = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_ENVIO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_DOCUMENTO = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FE_RESUMEN_BAJA", x => new { x.CODIGO_EMPRESA, x.TIPO_DOCU, x.NUME_DOCU });
                });

            migrationBuilder.CreateTable(
                name: "Hoja1",
                columns: table => new
                {
                    COD_ALM = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "LOG_APLICACION",
                columns: table => new
                {
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUMERO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NOTA = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "LOG_CAMBIO_CAMPOS",
                columns: table => new
                {
                    TABLA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    RUC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUMERO_DOCUMENTO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_ITEM = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CAMPO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    REFERENCIA1 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "loteserie",
                columns: table => new
                {
                    COD_ALM = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: true),
                    TP_TRANSAC = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: true),
                    COD_ART = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: true),
                    NRO_SER_LOTE = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: true),
                    CANTIDAD = table.Column<double>(type: "float", nullable: true),
                    LOTE = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_ALMACENZONA",
                columns: table => new
                {
                    CODIGO_SUCURSAL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CODIGO_ZONA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NOMBRE_ZONA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_ANEXO_COTIZACIONC",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    NOMBRE_ARCHIVO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ARCHIVO = table.Column<byte[]>(type: "image", nullable: false),
                    EXTENSION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_ANEXO_COTIZACIONC", x => new { x.CODIGO, x.SECUENCIA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_ANEXO_DOCUMENTO_COMPRA",
                columns: table => new
                {
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    RUTA = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: false),
                    NOMBRE_ARCHIVO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    EXTENSION = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_ANEXO_DOCUMENTO_COMPRA", x => new { x.ID_DOCUMENTO, x.SECUENCIA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_ANTICIPO",
                columns: table => new
                {
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUMERO_DOCU = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    TIPO_DOCUMENTO2 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUMERO_DOCU2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    RUC_CLI = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    VALOR_ORIGINAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    VALOR_APLICADO = table.Column<decimal>(type: "numeric(14,4)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_ANTICIPOP",
                columns: table => new
                {
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUMERO_DOCU = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    TIPO_DOCUMENTO2 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUMERO_DOCU2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    RUC_PRV = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    VALOR_ORIGINAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    VALOR_APLICADO = table.Column<decimal>(type: "numeric(14,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OPE_ANTI__EDCAB248A7097F2D", x => new { x.TIPO_DOCUMENTO, x.NUMERO_DOCU, x.TIPO_DOCUMENTO2, x.NUMERO_DOCU2, x.RUC_PRV });
                });

            migrationBuilder.CreateTable(
                name: "OPE_APERTURA_CAJA",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    CODIGO_CAJA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_APERTURA = table.Column<DateTime>(type: "datetime", nullable: false),
                    CODIGO_CAJERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CODIGO_TURNO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NUMERO_MAQUINA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    HORA_APERTURA = table.Column<string>(type: "char(6)", unicode: false, fixedLength: true, maxLength: 6, nullable: false),
                    NUMERO_SERIE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    IMPORTE_APERTURA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    NUMERO_SERIE_FACT = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CODIGO_IMPRESORA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RUTA_IMPRESORA = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    CDG_LISTA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    VENDEDORES = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    IMPORTE_APERTURAD = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    FECHA_CIERRE = table.Column<DateTime>(type: "datetime", nullable: true),
                    IMPORTE_CIERRE = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPORTE_CIERRED = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPORTE_CIERRE_TARJ = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPORTE_CIERRE_TARJD = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPORTE_CIERRE_OTRO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPORTE_CIERRE_OTROD = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ESTADO2 = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_APERTURA_CAJA", x => new { x.CODIGO_EMPRESA, x.CODIGO_SUCURSAL, x.CODIGO_CAJA, x.FECHA_APERTURA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_ARCHIVO_PRESUPUESTO",
                columns: table => new
                {
                    ID_PRESUPUESTO = table.Column<int>(type: "int", nullable: false),
                    IMAGEN_REF = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_ARQUEO_CAJA",
                columns: table => new
                {
                    ID_ARQUEO = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    CODIGO_CAJERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    TURNO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MAQUINA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    BILLETE200 = table.Column<int>(type: "int", nullable: false),
                    BILLETE100 = table.Column<int>(type: "int", nullable: false),
                    BILLETE50 = table.Column<int>(type: "int", nullable: false),
                    BILLETE20 = table.Column<int>(type: "int", nullable: false),
                    BILLETE10 = table.Column<int>(type: "int", nullable: false),
                    MONEDA5 = table.Column<int>(type: "int", nullable: false),
                    MONEDA1 = table.Column<int>(type: "int", nullable: false),
                    MONEDA05 = table.Column<int>(type: "int", nullable: false),
                    MONEDA005 = table.Column<int>(type: "int", nullable: false),
                    MONEDA001 = table.Column<int>(type: "int", nullable: false),
                    SALDO_INICIAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TOTAL_BILLETE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TOTAL_MONEDA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TOTAL_INGRESO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TOTAL_RETIRO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TOTAL_SISTEMA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(1500)", unicode: false, maxLength: 1500, nullable: false),
                    FECHA_ARQUEO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_CIERRE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    EFECTIVO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    VISA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    MASTERCARD = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    RIPLEY = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    SAGA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    OTROS = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CONTADO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CREDITO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    MONEDA010 = table.Column<int>(type: "int", nullable: true),
                    COBRADO_POR_CREDITO = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_ARQUEO_CAJA", x => x.ID_ARQUEO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_AZFILACOLUMNA",
                columns: table => new
                {
                    CODIGO_SUCURSAL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CODIGO_ZONA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FILA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COLUMNA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CANT_ITEMS = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    AREA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_AZFILACOLUMNA", x => new { x.CODIGO_SUCURSAL, x.CODIGO_ZONA, x.FILA, x.COLUMNA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_AZFILACOLUMNAPROD",
                columns: table => new
                {
                    CODIGO_SUCURSAL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CODIGO_ZONA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FILA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COLUMNA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(6,0)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_AZFILACOLUMNAPROD", x => new { x.CODIGO_SUCURSAL, x.CODIGO_ZONA, x.FILA, x.COLUMNA, x.ID_PRODUCTO });
                });

            migrationBuilder.CreateTable(
                name: "OPE_BLOQUEO_DESBLO",
                columns: table => new
                {
                    HABITACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    MOTIVO = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_CAJA",
                columns: table => new
                {
                    CDG_AREA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_CAJA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_CTA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CDG_BCO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_FPAG = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_CHEQ = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CDG_MON = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FEC_CAJA = table.Column<DateTime>(type: "datetime", nullable: false),
                    SLD_CAJA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMP_CAJA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TOT_CAJA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    MAX_CAJA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    SWT_CAJA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    CDG_TMOV = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_COR = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FEC_CIERRE = table.Column<DateTime>(type: "datetime", nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CDG_OP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_OS = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CODIGO_SUCURSAL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_REQUI = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_CAJA", x => new { x.CDG_AREA, x.NUM_CAJA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_CAJA2",
                columns: table => new
                {
                    CDG_AREA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_CAJA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_CTA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CDG_BCO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_FPAG = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_CHEQ = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CDG_MON = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FEC_CAJA = table.Column<DateTime>(type: "datetime", nullable: false),
                    SLD_CAJA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMP_CAJA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TOT_CAJA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    MAX_CAJA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    SWT_CAJA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    CDG_TMOV = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_COR = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FEC_CIERRE = table.Column<DateTime>(type: "datetime", nullable: true),
                    NUM_CORCAJA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_OP = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CODIGO_SUCURSAL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_REQUI = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_CAJAB",
                columns: table => new
                {
                    ID_MOVIMIENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_TC = table.Column<DateTime>(type: "datetime", nullable: false),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    GIRA_DETALLE = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(1500)", unicode: false, maxLength: 1500, nullable: true),
                    REF_CHOP = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_CAJAB", x => x.ID_MOVIMIENTO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_CARPETA_IMPORTACION",
                columns: table => new
                {
                    ci_codigo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ci_nombre = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    estado = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('A')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_CHECKINOUT",
                columns: table => new
                {
                    ID_CHECKINOUT = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ESTADO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_ENTRADA = table.Column<DateTime>(type: "datetime", nullable: false),
                    HORA = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    FECHA_SALIDA_PREVISTA = table.Column<DateTime>(type: "datetime", nullable: false),
                    CANT_NOCHES = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    NO_PRESENTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    REGIMEN = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COMIDA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ADULTO = table.Column<decimal>(type: "numeric(3,0)", nullable: false),
                    NINO = table.Column<decimal>(type: "numeric(3,0)", nullable: false),
                    BEBE = table.Column<decimal>(type: "numeric(3,0)", nullable: false),
                    ID_CLIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_EMPRESA = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_AGENCIA = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_TOUR_OPERADOR = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_CLIENTE_FACTURAR = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    TIPO_TARIFA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    TIPO_HABITACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    HABITACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    SWT_TIPO_HABITACION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    ID_RESERVA = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    SWT_CHECKINOUT = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ID_CHECKINOUT_PARENT = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    HORA_SALIDA = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    TURNO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_CHECKINOUT", x => x.ID_CHECKINOUT);
                });

            migrationBuilder.CreateTable(
                name: "OPE_CIERRE_DIARIO_CAJA",
                columns: table => new
                {
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    FECHA_CAJA = table.Column<DateTime>(type: "datetime", nullable: false),
                    CDG_CAJA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValueSql: "('0001')"),
                    SALDO_ANTERIOR = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    INGRESO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    EGRESO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    SALDO_FINAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('A')"),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    CODIGO_TURNO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CODIGO_MONEDA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    CODIGO_CAJERO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_CIERRE_DIARIO_CAJA", x => new { x.CODIGO_SUCURSAL, x.FECHA_CAJA, x.CDG_CAJA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_CIERRE_MES",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    CODIGO_MODULO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ANO = table.Column<int>(type: "int", nullable: false),
                    MES = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CIERRE = table.Column<DateTime>(type: "datetime", nullable: false),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    ESTADO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    iMes = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_CIERRE_MES", x => new { x.CODIGO_EMPRESA, x.CODIGO_SUCURSAL, x.CODIGO_MODULO, x.ANO, x.MES, x.FECHA_CIERRE, x.TIPO });
                });

            migrationBuilder.CreateTable(
                name: "OPE_CLIENTE_PRODUCTO",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    FLAG_P1 = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    FLAG_P2 = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    FLAG_P3 = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    FLAG_P4 = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "(0)"),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_CLIENTE_PRODUCTO", x => new { x.CODIGO, x.ID_PERSONA, x.ID_PRODUCTO });
                });

            migrationBuilder.CreateTable(
                name: "OPE_CLISTA_PRECIO",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NOMBRE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    FACTOR = table.Column<decimal>(type: "numeric(10,5)", nullable: false),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    METODO_REDONDEO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CODIGO_BASE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    GRUPO_USUARIO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    TIPO_CLIENTE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    TIPO = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    SWT_WEB = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_CLISTA_PRECIO", x => x.CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_COFPR_PRODUCTO",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    CDG_LISTA_PRECIO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_COMISION_CONTRATO",
                columns: table => new
                {
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CDG_CARGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    PORCENTAJE1 = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    PORCENTAJE2 = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    TOTAL_CONTRATO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMPORTE_COMISION = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    FECHA_CALCULO = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_COMISION_CONTRATO", x => new { x.ID_PEDIDO, x.CDG_CARGO });
                });

            migrationBuilder.CreateTable(
                name: "OPE_COMISION_VENTA_PERSONA",
                columns: table => new
                {
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CDG_CARGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_COMISION_VENTA_PERSONA", x => new { x.ID_PEDIDO, x.ID_PERSONA, x.CDG_CARGO });
                });

            migrationBuilder.CreateTable(
                name: "OPE_COMP_ELEC",
                columns: table => new
                {
                    CODI_EMPR = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    TIPO_DOCU = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    NUME_DOCU = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    TIPO_DOCU_CLIE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    RUC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CLIENTE = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    VVENTA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IGV = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_COMPROMISO",
                columns: table => new
                {
                    num_comp = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ano = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    mes = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    cdg_tmov = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    cdg_pla = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    cdg_bco = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    num_cta = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_COR = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    cdg_mon = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    importe = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    tea = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    swt_est = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    tip_cmb = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    fec_docu = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    usuario_modificacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    obs = table.Column<string>(type: "varchar(3000)", unicode: false, maxLength: 3000, nullable: true),
                    beneficiario = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    fecha_plazo = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecha_vencimiento = table.Column<DateTime>(type: "datetime", nullable: true),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_CONSUMO",
                columns: table => new
                {
                    ID_CONSUMO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_CONSUMO", x => x.ID_CONSUMO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_CONTRATO",
                columns: table => new
                {
                    ID_CONTRATO = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PERSONA_ARRENDADOR = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PERSONA_COPROPIETARIO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PERSONA_GARANTE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PERSONA_RESPONSABLE_PAGO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PERSONA_OTRO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    PRECIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    FECHA_INICIO_G = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_FIN_G = table.Column<DateTime>(type: "datetime", nullable: true),
                    PRECIO_G = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CANTIDAD_G = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPORTE_G = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    FECHA_INICIO_RP = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_FIN_RP = table.Column<DateTime>(type: "datetime", nullable: true),
                    PRECIO_RP = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CANTIDAD_RP = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPORTE_RP = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    FECHA_INICIO_OT = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_FIN_OT = table.Column<DateTime>(type: "datetime", nullable: true),
                    PRECIO_OT = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CANTIDAD_OT = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPORTE_OT = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    FACTURA = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    OPERADOR = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_CONTRATO_CUOTA_PARQUEO",
                columns: table => new
                {
                    ID_CONTRATO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    ANO = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    MES = table.Column<decimal>(type: "numeric(2,0)", nullable: false),
                    CUOTA = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_CONTRATO_PARQUEO",
                columns: table => new
                {
                    ID_CONTRATO = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    NRO_CUOTA = table.Column<decimal>(type: "numeric(4,0)", nullable: true),
                    ANO_INICIO = table.Column<decimal>(type: "numeric(4,0)", nullable: true),
                    MES_INICIO = table.Column<decimal>(type: "numeric(2,0)", nullable: true),
                    TIPO_TARIFA = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    TIPO_VECHICULO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    HORA_INICIO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    HORA_FIN = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    IMPORTE_PRORRATEO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    NUM_ESPACIO = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    REFERENCIA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_CONTRATO_PLACA_PARQUEO",
                columns: table => new
                {
                    ID_CONTRATO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    NUMERO_PLACA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_CONTROL_GARANTIA",
                columns: table => new
                {
                    NOMBRE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    SERIE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    SERIE_REEM = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    RECORDATORIO = table.Column<int>(type: "int", nullable: false),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_GUIA = table.Column<int>(type: "int", nullable: true),
                    ID_PEDIDO = table.Column<int>(type: "int", nullable: true),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('I')"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: true),
                    NOTA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_CONTROL_MAQUINA",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    NUMERO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    HORA_INICIO = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    HORA_FIN = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    MONTO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_CONTROL_MAQUINA", x => new { x.CODIGO_EMPRESA, x.CODIGO_SUCURSAL, x.NUMERO, x.FECHA, x.HORA_INICIO, x.HORA_FIN });
                });

            migrationBuilder.CreateTable(
                name: "OPE_CONVENIO_LAB",
                columns: table => new
                {
                    ID_CONVENIO = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    NUM_GARANTIA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_VENCIMIENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    ESTADO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_CONVENIO_LAB", x => x.ID_CONVENIO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_CONVENIO_PRUEBA",
                columns: table => new
                {
                    ID_CONVENIO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    NUM_SEC = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    COSTO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ESTADO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_ATENCION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_MEDICO = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_CONVENIO_PRUEBA", x => new { x.ID_CONVENIO, x.ID_PRODUCTO, x.NUM_SEC });
                });

            migrationBuilder.CreateTable(
                name: "OPE_CORRELATIVO",
                columns: table => new
                {
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUMERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_CORRELATIVO", x => new { x.TIPO_DOCUMENTO, x.NUMERO });
                });

            migrationBuilder.CreateTable(
                name: "OPE_COSTEO_IMPORTACION",
                columns: table => new
                {
                    ci_file_importacion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ci_numero_ingreso = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ci_cantidad = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ci_precio_compra = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ci_precio_estandar = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ci_precio_real = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ci_ano = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    ci_mes = table.Column<decimal>(type: "numeric(2,0)", nullable: false),
                    ci_fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    usuario_modificacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    ci_estado = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('0')"),
                    cdg_costeo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ci_porcentaje_fob = table.Column<decimal>(type: "numeric(10,4)", nullable: true),
                    ci_incremento_real = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ci_costo_total = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ci_ratio_importacion = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    ci_incremento_real_d = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ci_precio_real_d = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ci_costo_total_d = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_COSTO_PROM",
                columns: table => new
                {
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    MES = table.Column<int>(type: "int", nullable: false),
                    ANO = table.Column<int>(type: "int", nullable: false),
                    COSTO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    SALDO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    COSTOF = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    COSTOL = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_COSTO_REAL_OF",
                columns: table => new
                {
                    anomes = table.Column<string>(type: "char(6)", unicode: false, fixedLength: true, maxLength: 6, nullable: false),
                    id_of = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    id_producto = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    id_insumo = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    costo_sol = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    costo_dol = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    cantidad_producidad = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    id_guia = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    cantidad_insumo = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    saldo_guia = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    id_guia_ing = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_COTIZACION_VENTA",
                columns: table => new
                {
                    ID_COTIZACION = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NUMERO_COTIZACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CODIGO_VENDEDOR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CODIGO_VENDEDOR_ASIGNADO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CODIGO_CPAGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CODIGO_MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FECHA_COTIZACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    NUMERO_OCLIENTE = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    IMPORTE_STOT = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMPORTE_DESCUENTO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    VALOR_VENTA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMPORTE_IGV = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMPORTE_TOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PORCENTAJE_DESCUENTO = table.Column<decimal>(type: "numeric(7,4)", nullable: false),
                    PORCENTAJE_IGV = table.Column<decimal>(type: "numeric(7,4)", nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    ESTADO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    ID_CLIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_CLIENTE_FACTURA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    IMPORTE_ISC = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CONTACTO = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    EMAIL_CONTACTO = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    TIPO_FECHA_ENTREGA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    DIAS_ENTREGA = table.Column<int>(type: "int", nullable: false),
                    FECHA_ENTREGA = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_AUTORIZA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_AUTORIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    LUGAR_ENTREGA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    COMISION = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    REDONDEO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('0')"),
                    VALIDEZ = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MOTIVO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    CORRELATIVO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CENTRO_COSTO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ID_COTIZACION_PARENT = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    TELEFONOS = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: true),
                    SUCURSAL = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TIPO_ENTREGA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true, defaultValueSql: "((1))", comment: "1:DIAS:2:SEMANAS"),
                    DIAS_ENTREGA2 = table.Column<int>(type: "int", nullable: true),
                    OBSERVACION2 = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    COSTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ID_OPORTUNIDAD = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    MOTIVO_PERDIDA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COMPETENCIA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    NOTA_PERDIDA = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SEPARAR_STOCK = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    TIPO_DSCTO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ID_PROYECTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    SWT_VISADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_COTIZACION_VENTA", x => x.ID_COTIZACION);
                });

            migrationBuilder.CreateTable(
                name: "OPE_COTIZACIONC",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_ENTREGA = table.Column<DateTime>(type: "datetime", nullable: true),
                    LUGAR_ENTREGA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CONDICION_PAGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ID_PERSONA = table.Column<int>(type: "int", nullable: true),
                    SUB_TOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    DSCTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    PORCENTAJE_DSCTO = table.Column<decimal>(type: "numeric(7,3)", nullable: true),
                    IGV = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    TOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ESTADO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValueSql: "(1)"),
                    OBSERVACION = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    SWT_COTI = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    RESPONSABLE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    VALOR_COMPRA = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_COTIZACIONC", x => x.CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_CREQUERIMIENTO",
                columns: table => new
                {
                    CODIGO_REQUERIMIENTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    TIPO_REQUERIMIENTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    ESTADO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    ENTREGADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('N')"),
                    PRIORIDAD = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    FECHA_SOLICITUD = table.Column<DateTime>(type: "date", nullable: false),
                    HORA_SOLICITUD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    SOLICITADO_POR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_PROVEEDOR = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    MANAGER = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SUPERVISOR = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SITE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NOMBRE_SITE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DEPARTAMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    PROVINCIA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    DISTRITO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    DIRECCION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    FECHA_REQUERIDA = table.Column<DateTime>(type: "date", nullable: true),
                    HORA_REQUERIDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    TRANSPORTE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    AGENCIA_TRANSPORTE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NUMERO_DOCUMENTO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NOMBRE_CONTACTO1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DNI_CONTACTO1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TELEFONO_CONTACTO1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NOMBRE_CONTACTO2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DNI_CONTACTO2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TELEFONO_CONTACTO2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TIPO_TRANSPORTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SWT_REQ = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('A')"),
                    ALMACEN = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(3000)", unicode: false, maxLength: 3000, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_ATENDIDO = table.Column<DateTime>(type: "date", nullable: true),
                    HORA_ATENDIDO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FECHA_PROGRAMADA = table.Column<DateTime>(type: "date", nullable: true),
                    HORA_PROGRAMADA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FECHA_TRANSITO = table.Column<DateTime>(type: "date", nullable: true),
                    HORA_TRANSITO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FECHA_AGENCIA = table.Column<DateTime>(type: "date", nullable: true),
                    HORA_AGENCIA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NODO_DESPACHO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CDG_CECO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FECHA_PROGRAMA_ALMACEN = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_PROGRAMA_ALMACEN = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_REQ = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_CREQUERIMIENTO_NUMEROS",
                columns: table => new
                {
                    CODIGO_REQUERIMIENTO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NUMERO_REFERENCIA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NUM_ALU = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_CUENTA_CORRIENTE_CLIENTE",
                columns: table => new
                {
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUMERO_SERIE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    RUC_CLIENTE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FECHA_DOCUMENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_VENCIMIENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    IMPORTE_DOCUMENTO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PAGO_DOCUMENTO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    ID_DOCUMENTO = table.Column<int>(type: "int", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    PUNTO_VENTA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "((0))"),
                    REFLETRA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_CUENTA_CORRIENTE_CLIENTE", x => new { x.TIPO_DOCUMENTO, x.NUMERO_SERIE, x.RUC_CLIENTE, x.CODIGO_EMPRESA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_CUENTA_CORRIENTE_PROVEEDOR",
                columns: table => new
                {
                    ID_DOCUMENTO = table.Column<int>(type: "int", nullable: false),
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    RUC_PROV = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUMERO_SERIE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FECHA_DOCUMENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_VENCIMIENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    IMPORTE_DOCUMENTO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PAGO_DOCUMENTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_CUOTA_CONDPAGO",
                columns: table => new
                {
                    NUM_COPA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUM_CUOTA = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    DIAS = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    POR_CUOTA = table.Column<decimal>(type: "numeric(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_CUOTA_CONDPAGO", x => new { x.NUM_COPA, x.NUM_CUOTA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_CUOTA_DOCUMENTOVENTA",
                columns: table => new
                {
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    NUM_CUOTA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    FECHA_VCTO = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_CUOTA_DOCUMENTOVENTA", x => new { x.ID_DOCUMENTO, x.NUM_CUOTA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_CUOTA_PEDIDO",
                columns: table => new
                {
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CUOTA = table.Column<decimal>(type: "numeric(3,0)", nullable: false),
                    LETRA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FECHA_VENCIMIENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    DIAS = table.Column<int>(type: "int", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    INTERES = table.Column<decimal>(type: "numeric(4,2)", nullable: false),
                    IMPORTE_INTERES = table.Column<decimal>(type: "numeric(8,2)", nullable: false),
                    IMPORTE_TOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    INTERES_SIGV = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    VALOR_INAFECTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IGV = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IGV50 = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CAPITAL_FINAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CAPITAL_AMORTIZADO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    VALOR_AFECTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    AMORTIZACION = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_CUOTA_VENDEDOR",
                columns: table => new
                {
                    VENDEDOR = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    MES = table.Column<decimal>(type: "numeric(2,0)", nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_CUOTA_VENDEDOR", x => new { x.VENDEDOR, x.ANO, x.MES });
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_ACTIVO_FIJO",
                columns: table => new
                {
                    daf_id = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    daf_serie = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    daf_marca = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    daf_modelo = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    daf_cantidad = table.Column<int>(type: "int", nullable: true),
                    daf_numero_factura = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    id_moneda = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    proveedor_codigo = table.Column<int>(type: "int", nullable: true),
                    daf_fecha_adquisicion = table.Column<DateTime>(type: "datetime", nullable: true),
                    daf_fecha_capitalizacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    daf_valor_adquisicion = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    daf_clase = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    daf_nivel_absolescencia = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    daf_uso = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    daf_estado_fisico = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuario_modificacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_ACTIVO_FIJO", x => x.daf_id);
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_CHECKINOUT",
                columns: table => new
                {
                    ID_CHECKINOUT = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_HABITACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ID_CONCEPTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    UNIDAD = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    DIAS = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    PRECIO = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    DSCTO = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    SWT_FACT = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SECUENCIA = table.Column<decimal>(type: "numeric(6,0)", nullable: true),
                    SUPLEMENTO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SWT_AUTO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_COMPROMISO",
                columns: table => new
                {
                    num_comp = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    num_itm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    imp = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    cdg_pla = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fec_venc = table.Column<DateTime>(type: "datetime", nullable: true),
                    cdg_tdoc = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    num_docu = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    cdg_tana = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cdg_anal = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    cdg_tmov = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cdg_bco = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    num_cta = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cdg_gara = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    num_cor = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cor_cren = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    swt_est = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    cdg_fpag = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cdg_tmov_parent = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    tip_cmb = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    num_comp_parent = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_CONSUMO",
                columns: table => new
                {
                    ID_CONSUMO = table.Column<int>(type: "int", nullable: false),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    VENDIDO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    BAJA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_COTIZACION",
                columns: table => new
                {
                    ID_COTIZACION = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PRECIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    DESCUENTO = table.Column<decimal>(type: "numeric(7,4)", nullable: true),
                    IGV = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    OBSERVACION = table.Column<string>(type: "ntext", nullable: true),
                    PRECIO_ORIGINAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false, comment: "1:PRODUCTO;2:PRD PROMOCION;P:PRESUPUESTO"),
                    IMPORTE_DSCTO = table.Column<decimal>(type: "numeric(10,4)", nullable: true),
                    AFECTO_IGV = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    COMISION = table.Column<decimal>(type: "numeric(7,2)", nullable: true),
                    ID_PRESUPUESTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    CDG_SERV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    IMAGEN_REF = table.Column<byte[]>(type: "image", nullable: true),
                    OBSERVACION2 = table.Column<string>(type: "ntext", nullable: true),
                    UNIDAD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    POR_PERCEPCION = table.Column<decimal>(type: "numeric(7,2)", nullable: true),
                    PERCEPCION = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    VALOR_VEN = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    UNID_VEN = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    FECHA_VEN = table.Column<DateTime>(type: "datetime", nullable: true),
                    CDG_KIT = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SWT_PIGV = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    POR_DETRACCION = table.Column<decimal>(type: "numeric(7,2)", nullable: true),
                    DETRACCION = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    FACTOR_CONVERSION = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    MARGEN = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPORTE_MARGEN = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    COSTO_ADIC = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CANT_KIT = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    SWT_IMP = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    TIPO_ITEM = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_COTIZACION", x => new { x.ID_COTIZACION, x.ID_PRODUCTO, x.SECUENCIA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_CPRESUPUESTO",
                columns: table => new
                {
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_ITEM = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    HORAS = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PRECIO_UNITARIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    TIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_DOCUMENTO_COMPRA2",
                columns: table => new
                {
                    ID_DOCUMENTO = table.Column<int>(type: "int", nullable: false),
                    RUC_PRV = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_DOCU = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CDG_TDOC = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_OC = table.Column<int>(type: "int", nullable: true),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: true),
                    DESCRIPCION_PROD = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CAN_DFAC = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    PRE_DFAC = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    DCT_DFAC = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMP_DFAC = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    CUENTA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    COSTO = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    IMPORTE = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    AFINA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_TANA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_ANAL = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    TIP_PROV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NUM_POLI = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    BAS_POR = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    EST_POLI = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    NUM_SEC = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    ORD_PROD = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ORD_SERV = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    VAL_VALOR = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CDG_PROD = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CDG_CC = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_GASTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_UNIDAD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ID_GUIA = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    PRECIO_IGV = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    CODIGO_ALMACEN = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    SCDG_CC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    PRECIO_AJUSTE = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPORTE_AJUSTE = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    PRECIO_OTRO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPORTE_OTRO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ITEM_PF = table.Column<decimal>(type: "numeric(6,0)", nullable: true),
                    PRE_SIGV = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    PRE_INV = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    FACTOR_CONVERSION = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_ENTRE",
                columns: table => new
                {
                    CDG_TIAN = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CDG_ANAL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_CAJA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_COR = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    CDG_MCJA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FEC_DCJA = table.Column<DateTime>(type: "datetime", nullable: false),
                    DOC_DCJA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CNC_DCJA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IMP_DCJA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    NUM_ORIG = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_VOUC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_PROVEEDOR = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    RUC_PRV = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_TDOC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_DOCU = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    MON_DOCU = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FEC_DOCU = table.Column<DateTime>(type: "datetime", nullable: true),
                    IMP_PAG = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TIP_CMB = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    SWT_ACT = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    CDG_CCT = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_TANA2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_ANAL2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    REFERENCIA1 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_LIQUIDA = table.Column<DateTime>(type: "datetime", nullable: true),
                    MON_CAJA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_REQUI = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SCDG_CC = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_BCO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_CTA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_CORB = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_ENTRE", x => new { x.CDG_TIAN, x.CDG_ANAL, x.NUM_CAJA, x.NUM_COR });
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_FRE",
                columns: table => new
                {
                    NUMERO_FRE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SERIE_GENERADA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false),
                    SERIE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CDG_ESTADO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_EQUIPO = table.Column<int>(type: "int", nullable: false),
                    CDG_MARCA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_MODELO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    FECHA_GENERADA = table.Column<DateTime>(type: "datetime", nullable: false),
                    SWT_CXG = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SWT_TB = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    KILOMETRAJE = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CDG_COLOR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_FRE_1", x => new { x.NUMERO_FRE, x.SERIE_GENERADA, x.SECUENCIA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_GUIA2",
                columns: table => new
                {
                    ID_DOCUMENTO = table.Column<int>(type: "int", nullable: false),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    LOTE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CODIGO_UNIDAD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FECHA_ENVASADO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_VENCIMIENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    MESES = table.Column<int>(type: "int", nullable: false),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false),
                    SECUENCIA_DOC = table.Column<int>(type: "int", nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    SERIE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    SERIE_GEN = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_GUIA3",
                columns: table => new
                {
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PROVEEDOR = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    CODIGO_SUCURSAL = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CDG_UNIDAD = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    FACTOR = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    CDG_UNIDAD_EQUI = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    CDG_CAJA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    CDG_COLUMNA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    CDG_CASILLERO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    CDG_MARCA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    CDG_MODELO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_GUIA4",
                columns: table => new
                {
                    ID_DOCUMENTO = table.Column<int>(type: "int", nullable: false),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    LOTE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CODIGO_UNIDAD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FECHA_ENVASADO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_VENCIMIENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    MESES = table.Column<int>(type: "int", nullable: false),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false),
                    SECUENCIA_DOC = table.Column<int>(type: "int", nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    SERIE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SERIE_GEN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_GUIAUBICACION",
                columns: table => new
                {
                    ID_DOCUMENTO = table.Column<int>(type: "int", nullable: false),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    LOTE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CODIGO_UNIDAD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FECHA_ENVASADO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_VENCIMIENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    MESES = table.Column<int>(type: "int", nullable: false),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false),
                    SECUENCIA_DOC = table.Column<int>(type: "int", nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    SERIE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SERIE_GEN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CODIGO_ZONA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FILA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    COLUMNA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_HABITACION",
                columns: table => new
                {
                    ID_SECUENCIA = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_HABITACION = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_EMPLEADO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: true),
                    HORA = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TIPO_DETALLE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_INVENTARIO_FISICO",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    inventariado = table.Column<bool>(type: "bit", nullable: true),
                    contado = table.Column<bool>(type: "bit", nullable: true),
                    CANTIDAD_CONTADA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    FALTANTE = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    SOBRANTE = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CONCILIADO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    UTILMO_OC = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    COSTO_PROMEDIO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    COSTO_PROMEDIOD = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    SECUENCIA = table.Column<decimal>(type: "numeric(6,0)", nullable: true),
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_INVENTARIO_FISICO", x => new { x.CODIGO, x.ID_PRODUCTO });
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_LETRA_CLIENTE",
                columns: table => new
                {
                    NUMERO_LETRA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    RUC_CLI = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    BANCO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NUMERO_CUENTA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUMERO_DOCUMENTO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    PLAZO = table.Column<int>(type: "int", nullable: false),
                    VENCIMIENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    FECHA_GIRO = table.Column<DateTime>(type: "datetime", nullable: true),
                    LUGAR_GIRO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA_GIRO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NOMBRE_AVAL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DIRECCION_AVAL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    RUC_AVAL = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TELEFONO_AVAL = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUMERO_BANCO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUMERO_LORI = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    SECCION = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    COR_LREN = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUMERO_LREN = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_ORIG = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_VOUC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IMPORTE_RET = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    REFERENCIA1 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    INTERES = table.Column<decimal>(type: "numeric(6,3)", nullable: true),
                    IMP_INTERES = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_LETRA_PROVEEDOR",
                columns: table => new
                {
                    NUMERO_LETRA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    RUC_PROV = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    BANCO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NUMERO_CUENTA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUMERO_DOCUMENTO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    PLAZO = table.Column<int>(type: "int", nullable: false),
                    VENCIMIENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    FECHA_GIRO = table.Column<DateTime>(type: "datetime", nullable: true),
                    LUGAR_GIRO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA_GIRO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NOMBRE_AVAL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DIRECCION_AVAL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    RUC_AVAL = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TELEFONO_AVAL = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUMERO_BANCO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUMERO_LORI = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    SECCION = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    COR_LREN = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUMERO_LREN = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_ORIG = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_VOUC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IMPORTE_RET = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_LIQUIDACIONM",
                columns: table => new
                {
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    VALOR_UNITARIO = table.Column<decimal>(type: "numeric(12,4)", nullable: false),
                    PRECIO_UNITARIO = table.Column<decimal>(type: "numeric(12,4)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(12,4)", nullable: false),
                    UNIDAD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SUBTOTAL = table.Column<decimal>(type: "numeric(12,4)", nullable: false),
                    VALOR_UNITRARIO_TOTAL = table.Column<decimal>(type: "numeric(12,4)", nullable: false),
                    SWT_FACT = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_LIQUIDACIONM", x => new { x.ID_DOCUMENTO, x.ID_PRODUCTO, x.SECUENCIA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_ORDEN_COMPRA",
                columns: table => new
                {
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    ID_OC = table.Column<int>(type: "int", nullable: false),
                    PRECIO = table.Column<decimal>(type: "numeric(16,6)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    AFECTO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(16,6)", nullable: false),
                    CANTIDAD_INGRESADA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CANTIDAD_FACTURADA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CODIGO_UNIDAD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRIPCION_EXTENDIDA = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    DSCTO = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    PRECIO_ORI = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    FECHA_ENTREGA = table.Column<DateTime>(type: "datetime", nullable: true),
                    SEC_REQ = table.Column<int>(type: "int", nullable: true),
                    REQ = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    AI = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    CDG_CC = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    POR_DETRACCION = table.Column<decimal>(type: "numeric(7,2)", nullable: true),
                    DETRACCION = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    FACTOR_CONVERSION = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    SCDG_CC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_REQ = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_ORDEN_FABRICACION",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    planificado = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    entregado = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    requerido = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    cant_base = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    costo_promedio = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    costo_promedio_d = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    costo = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    costo_d = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    des_item = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ref1 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    secuencia = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuario_modificacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_ORDEN_SERVICIO",
                columns: table => new
                {
                    CODIGO_SERVICIO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CDG_SERV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    COSTO = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: false),
                    TIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    VALOR_ORI = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    IMPORTE = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    REFERENCIA1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CANT_REQ = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    CANT_UTIL = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    FLAG = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('G')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_ORDEN_TRABAJO",
                columns: table => new
                {
                    CODIGO_SERVICIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CODIGO_ORDEN_TRABAJO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CDG_SERV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    COSTO = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: false),
                    TIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    VALOR_ORI = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    IMPORTE = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    REFERENCIA1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CANT_REQ = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    CANT_UTIL = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    FLAG = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('G')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_PAGO_CLIENTE",
                columns: table => new
                {
                    NUMERO_COBRO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUMERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    RUC_CLI = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_DOCUMENTO = table.Column<int>(type: "int", nullable: false),
                    FORMA_PAGO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMPORTE_COBRO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    BANCO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CHEQUE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_COBRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    MONEDA_ORI = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    INTERES = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_PAGO_CLIENTE", x => new { x.NUMERO_COBRO, x.TIPO_DOCUMENTO, x.NUMERO, x.RUC_CLI });
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_PAGO_PROVEEDOR",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_DOCUMENTO = table.Column<int>(type: "int", nullable: false),
                    FORMA_PAGO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    FECHA_PAGO = table.Column<DateTime>(type: "datetime", nullable: false),
                    IMPORTE_PAGO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    NUMERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    BANCO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NUMERO_CHEQUE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CUENTA_BANCARIA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_COR = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_COR2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    RUC_PROV = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    MONEDA_ORI = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CORRELATIVO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_ORIG = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_VOUC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    REFERENCIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TURNO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CAJA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    NUM_REQUI = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_COR_MOD = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    MODULO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    LUGAR_PAGO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    NUM = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_PARTIDA_PRESUPUESTO",
                columns: table => new
                {
                    ID_PRESUPUESTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_ITEM = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    TIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    HORAS = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PRECIO_UNITARIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    SEC_PROD = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    PRECIO_UNITARIO_ORI = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_PARTIDA_PRESUPUESTO", x => new { x.ID_PRESUPUESTO, x.ID_PRODUCTO, x.ID_ITEM, x.TIPO });
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_PEDIDO",
                columns: table => new
                {
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PRECIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    DESCUENTO = table.Column<decimal>(type: "numeric(7,4)", nullable: true),
                    IGV = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CANT_DESPACHADA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CANT_FACTURADA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(3000)", unicode: false, maxLength: 3000, nullable: true),
                    PRECIO_ORIGINAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    IMPORTE_DSCTO = table.Column<decimal>(type: "numeric(10,4)", nullable: true),
                    AFECTO_IGV = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    COMISION = table.Column<decimal>(type: "numeric(7,2)", nullable: true),
                    ID_PRESUPUESTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    CDG_SERV = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FLAG_C = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true, defaultValueSql: "((0))"),
                    FLAG_P = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FLAG_COLOR = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "((0))"),
                    COMANDA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    MOZO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    UNIDAD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    POR_PERCEPCION = table.Column<decimal>(type: "numeric(7,2)", nullable: true),
                    PERCEPCION = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    VALOR_VEN = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    UNID_VEN = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    FECHA_VEN = table.Column<DateTime>(type: "datetime", nullable: true),
                    FACTOR_CONVERSION = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CDG_KIT = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SWT_PIGV = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    SWT_PROM = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    CANT_KIT = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    SWT_DCOM = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SWT_SABOR = table.Column<string>(type: "varchar(7)", unicode: false, maxLength: 7, nullable: true),
                    SWT_FREE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    NOM_IMP = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SEC_PROD = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    POR_DETRACCION = table.Column<decimal>(type: "numeric(7,2)", nullable: true),
                    DETRACCION = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    USUARIO_ANULA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_ANULA = table.Column<DateTime>(type: "datetime", nullable: true),
                    MARGEN = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPORTE_MARGEN = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    COSTO_ADIC = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_PEDIDO", x => new { x.ID_PEDIDO, x.ID_PRODUCTO, x.SECUENCIA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_PLAN_FABRICACION",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    a_producir = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    producido = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    secuencia = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_PLANTILLA_RECETA",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    COSTO_UNITARIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    LISTA_PRECIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    PRECIO_LISTA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    TOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPRIME = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    UNIDAD = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_PRESUPUESTO2",
                columns: table => new
                {
                    ID_PRESUPUESTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CDG_SERV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    COSTO = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    MARGEN = table.Column<decimal>(type: "numeric(10,5)", nullable: false),
                    DSCTO = table.Column<decimal>(type: "numeric(10,5)", nullable: false),
                    VALOR_UNIT = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: false),
                    OBSERVACION2 = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: false),
                    TIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    VALOR_ORI = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    IMPORTE2 = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    UNIDAD = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ID_PROVEEDOR = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_PROGRAMACION_PAGO",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    NUM = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_DOCUMENTO = table.Column<int>(type: "int", nullable: false),
                    FORMA_PAGO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(14,8)", nullable: false),
                    FECHA_PAGO = table.Column<DateTime>(type: "datetime", nullable: false),
                    IMPORTE_PAGO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    NUMERO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    BANCO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NUMERO_CHEQUE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CUENTA_BANCARIA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    RUC_PROV = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    MONEDA_ORI = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_RECETA",
                columns: table => new
                {
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    ID_PRODUCTO2 = table.Column<int>(type: "int", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    VALOR_SOL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    VALOR_DOL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    INTERMEDIO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_REQITEMS",
                columns: table => new
                {
                    ID_REQUERIMIENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    ESTADO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    UNIDAD = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FACTOR_CONVERSION = table.Column<decimal>(type: "numeric(10,4)", nullable: true),
                    CDG_RESPONSABLE = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    CDG_USO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    CDG_PRIORIDAD = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    CDG_CUSO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_REQITEMS", x => new { x.ID_REQUERIMIENTO, x.ID_PRODUCTO, x.SECUENCIA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_REQUISICION",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    CDG_GASTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    PRECIO = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AFECTO_IGV = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "((1))"),
                    AI = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('A')"),
                    CENTRO_COSTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    UNIDAD = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FACTOR_CONVERSION = table.Column<decimal>(type: "numeric(10,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_REQUISICION", x => new { x.CODIGO, x.ID_PRODUCTO, x.SECUENCIA, x.CDG_GASTO });
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_RESERVA",
                columns: table => new
                {
                    ID_RESERVA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_CONCEPTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    UNIDAD = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    DIAS = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    PRECIO = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    DSCTO = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(6,0)", nullable: true),
                    SUPLEMENTO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SWT_AUTO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_SOLICITUD_DOCUMENTO",
                columns: table => new
                {
                    ID_SOLICITUD = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    PRECIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    UNIDAD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SUBTOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    AFECTO_IGV = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    SWT_PIGV = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    TIPO_AFEC_IGV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_SOLICITUD_DOCUMENTO", x => new { x.ID_SOLICITUD, x.ID_PRODUCTO, x.SECUENCIA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_SOLICITUD_REQUERIMIENTO",
                columns: table => new
                {
                    ID_REQUERIMIENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    UNIDAD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_SOLICITUD_REQUERIMIENTO", x => new { x.ID_REQUERIMIENTO, x.ID_PRODUCTO, x.SECUENCIA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_SOLICITUD_VJEVTO",
                columns: table => new
                {
                    ID_SOLICITUD = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    TIPO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    TIPO_AT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CDG_VJE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CDG_VTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CDG_PERSONAL = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    COSTO_UNITARIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CANT_PERSONA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CDG_CECO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NOM_VJE = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    NOM_VTO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_SOLICITUD_VJEVTO", x => new { x.ID_SOLICITUD, x.TIPO, x.SECUENCIA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_DIST_GAST_IMPORTACION",
                columns: table => new
                {
                    ci_codigo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    tipo_documento = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    numero_documento = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ruc_prov = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    base_prorrateo = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    valor = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    ci_codigo2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    tipo_documento_o = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    numero_documento_o = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ruc_prov_o = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CDG_COSTEO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    secuencia = table.Column<int>(type: "int", nullable: true),
                    secuencia_docu = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DOCNT_DOC",
                columns: table => new
                {
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_DOCUMENTO_NT = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    NUM_COBRO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DOCUMENTO_COMPRA",
                columns: table => new
                {
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    NUMERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_DOCUMENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_VENCIMIENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_PROVEEDOR = table.Column<int>(type: "int", nullable: true),
                    ID_MONEDA = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    ID_FORMA_PAGO = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    DEPARTAMENTO_PARTIDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    PROVINCIA_PARTIDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    UBIGEO_PARTIDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DEPARTAMENTO_LLEGADA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    PROVINCIA_LLEGADA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    UBIGEO_LLEGADA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TIPO_MOVIMIENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    GLOSA = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ES_TRASLADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    CODIGO_SUCURSAL_ORIGEN = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    CODIGO_SUCURSAL_DESTINO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    FLAG1 = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "((0))"),
                    CODIGO_EMPRESA_DESTINO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    ID_DOCUMENTO_PARENT = table.Column<int>(type: "int", nullable: true),
                    TIPO_GUIA = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    CODIGO_GENERADO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ID_OC = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    RUC_TRANSPORTISTA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    LICENCIA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PLACA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CHOFER = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    LUGAR_ENTREGA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    LUGAR_PARTIDA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PUNTO_VENTA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "((0))"),
                    NUM_ORIG = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_VOUC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_OS = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_OP = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SWT_ING = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    VEHICULO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CDG_OT = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_REF = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_FRE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_REF = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_ENTREGA_CLIENTE = table.Column<DateTime>(type: "datetime", nullable: true),
                    CERTIFICADO_INSCRIPCION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_BULTOS = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    NUM_ALU = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_DELIVERY = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    SWT_AUTORIZACION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    USUARIO_AUTORIZACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_AUTORIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    SWT_CUO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    TRANSPORTISTA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CDG_CC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    SCDG_CC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ID_DOCUMENTO_PARENT2 = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    SWT_WEB = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SWT_WS = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    NODO_DESPACHO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CDG_CECO_D = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_SCECO_D = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    SWT_FE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    FLAG_ERROR = table.Column<bool>(type: "bit", nullable: true),
                    FLAG_ENVIO = table.Column<bool>(type: "bit", nullable: true),
                    SWT_BJ = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    FECHA_ENVIO = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_ENVIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    M_ERROR = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    M_EXITO = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    VALOR_RESUMEN = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    NUM_REQ = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_REQ_EM = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ERR_ST = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DOCUMENTO_COMPRA", x => x.ID_DOCUMENTO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_DOCUMENTO_COMPRA2",
                columns: table => new
                {
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    RUC_PRV = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CDG_TDOC = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUM_DOCU = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CDG_AFEC = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CDG_CPAG = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CDG_MON = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FEC_DOCU = table.Column<DateTime>(type: "datetime", nullable: false),
                    FEC_VCTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FEC_CANC = table.Column<DateTime>(type: "datetime", nullable: true),
                    VAL_FSUB = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    VAL_FDES = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    VAL_FLET = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    VAL_FIGV = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    VAL_FTOT = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    VAL_FPAG = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    OBS_FPRV = table.Column<string>(type: "varchar(3000)", unicode: false, maxLength: 3000, nullable: true),
                    SWT_EST = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    SWT_OCOM = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    NUM_ORIG = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_VOUC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FEC_CMP = table.Column<DateTime>(type: "datetime", nullable: true),
                    POR_TIGV = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    VAL_FINT = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    NUM = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_POLI = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    SWT_POLI = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    BAS_PORR = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    EST_POLI = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    IMP_ISC = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CDG_TREF = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NUM_REF = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FEC_REF = table.Column<DateTime>(type: "datetime", nullable: true),
                    IMP2 = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMP3 = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    SUB2 = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    POR_TPER = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    VAL_FPER = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    FEC_PGOD = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    AFECTA_TOTAL = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    FECHA_DETRA = table.Column<DateTime>(type: "datetime", nullable: true),
                    NUMERO_DETRA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TASA_DETRA = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    ANTICIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    TIPO_REF_IMP = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    CODIGO_SUCURSAL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REF1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REFE_CORR = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_OC = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    POR_TIR = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    NUM_REQ = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FLETE = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    TIPO_DSCTO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ID_CONVENIO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_PRODLAB = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    NUMSEC = table.Column<decimal>(type: "numeric(5,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DOCUMENTO_COMPRA2", x => x.ID_DOCUMENTO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_DOCUMENTO_GUIA",
                columns: table => new
                {
                    ID_GUIA = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DOCUMENTO_GUIA2",
                columns: table => new
                {
                    ID_PEDIDO = table.Column<int>(type: "int", nullable: false),
                    ID_GUIA = table.Column<int>(type: "int", nullable: false),
                    REFERENCIA1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DOCUMENTO_VENTA",
                columns: table => new
                {
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    HORA = table.Column<string>(type: "char(8)", unicode: false, fixedLength: true, maxLength: 8, nullable: false),
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    CONDICION_PAGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TIPO_VENTA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUMERO_SERIE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    POR_IGV = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    IGV = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    SUB_TOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    VALOR_VENTA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    EFECTIVO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ABONO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    VUELTO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    NUMERO_MAQUINA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MOZO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    TURNO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CODIGO_CAJERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    VISA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    MASTERCARD = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    RIPLEY = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    SAGA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    OTROS = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    NUMERO_COMANDA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    RUC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NOMBRE_PERSONA = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    DIRECCION_PERSONA = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    COMISION_VISA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    COMISION_MASTERCARD = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    COMISION_RIPLEY = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    COMISION_SAGA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    COMISION_OTROS = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    DESCUENTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_DOCUMENTO2 = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    TIPO_DOCUMENTO2 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    TIPO_MOVIMIENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FECHA_REFERENCIA = table.Column<DateTime>(type: "datetime", nullable: true),
                    FEC_VCTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    FEC_CANC = table.Column<DateTime>(type: "datetime", nullable: true),
                    DOC_REF = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_ORIG = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NUM_VOUC = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    TOT_COB = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    VAL_FPAG = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    REDONDEO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('0')"),
                    ANTICIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ID_GUIA = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    VAL_ANTICIPO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    VAL_PERCEPCION = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    REF_ZONAS = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ID_CHECKINOUT = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_COTIZACION = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    FECHA_ANULACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    DEPARTAMENTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    PROVINCIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DISTRITO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CANT_DECIMAL = table.Column<decimal>(type: "numeric(4,0)", nullable: true),
                    FECHA_APERTURA = table.Column<DateTime>(type: "datetime", nullable: true),
                    PROPINA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CAJA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    SWT_CUO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    VALOR_RESUMEN = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TEXTO_IMPORTE = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    VALOR_FIRMA = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    M_ERROR = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    M_EXITO = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    M_CONTINGENCIA = table.Column<decimal>(type: "numeric(2,0)", nullable: true),
                    USUARIO_CONTINGENCIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_CONTINGENCIA = table.Column<DateTime>(type: "datetime", nullable: true),
                    REFE_CORR = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    IMP_OPERACION_GRAVADA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMP_OPERACION_INAFECTA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMP_OPERACION_EXONERADA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMP_OPERACION_EXPORTACION = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    REFLETRA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    SWT_CC = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    USUARIO_CAJA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SWT_CANJE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ICBPER = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    FLAG_ERROR = table.Column<bool>(type: "bit", nullable: true),
                    FLAG_ENVIO = table.Column<bool>(type: "bit", nullable: true),
                    FECHA_ENVIO = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_ENVIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SWT_FE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SWT_BJ = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SWT_GN = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    STR_MOT = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DNI = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NOMBRE_APELLIDO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TEL_CELULAR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CDG_CECO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_SCECO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    PTOS_VTA = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    DSCTO_PTOS_VTA = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    PTOS_VTA_APLICA = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    TIPO_OPERACION = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    IMP_RED = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    NUM_PLACA = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    IMP_CREDITO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    FECHA_INGRESO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_SALIDA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TEXTO_CONTRATO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TEXTO_CONTRATO2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MINUTOS = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    HORAS = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    MINUTOSE = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    HORASE = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    MINUTOSST = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    HORASST = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    TARIFA = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    CANT_HS = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    TARIFA_PLANA = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    ID_CONTRATO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    NOM_DELIVERY = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    POR_RETENCION = table.Column<decimal>(type: "numeric(4,2)", nullable: true),
                    IMP_RETENCION = table.Column<decimal>(type: "numeric(11,4)", nullable: true),
                    POR_RETENCION_OTRO = table.Column<decimal>(type: "numeric(4,2)", nullable: true),
                    IMP_RETENCION_OTRO = table.Column<decimal>(type: "numeric(11,4)", nullable: true),
                    ID_MEDICO = table.Column<decimal>(type: "numeric(7,0)", nullable: true),
                    CDG_ESPE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DOCUMENTO_VENTA", x => x.ID_DOCUMENTO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_DOCUMENTO_VENTA_CONTRATO",
                columns: table => new
                {
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_CONTRATO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ANO = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    MES = table.Column<decimal>(type: "numeric(2,0)", nullable: false),
                    CUOTA = table.Column<decimal>(type: "numeric(10,2)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DOCUMENTO_VENTA_PEDIDO",
                columns: table => new
                {
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_GUIA = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    SECUENCIA = table.Column<int>(type: "int", nullable: true),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DSCTO_CANTIDAD_PRODUCTO",
                columns: table => new
                {
                    CDG_LISTA_PRECIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    UNIDAD = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    FACTOR_CONVERSION = table.Column<decimal>(type: "numeric(10,4)", nullable: false, defaultValueSql: "((1))"),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    DSCTO = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    PRECIO = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    PRECIO_DSCTO = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    AUTO_P = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DSCTO_CANTIDAD_PRODUCTO", x => new { x.CDG_LISTA_PRECIO, x.ID_PRODUCTO, x.CANTIDAD, x.TIPO, x.UNIDAD, x.FACTOR_CONVERSION });
                });

            migrationBuilder.CreateTable(
                name: "OPE_EMPRESA",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    RUC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    NOMBRE_COMERCIAL = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DIRECCION = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TELEFONO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FAX = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    DNI_REPRESENTANTE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REPRESENTANTE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    IMAGEN_HEADER = table.Column<byte[]>(type: "image", nullable: true),
                    IMAGEN_FOOTER = table.Column<byte[]>(type: "image", nullable: true),
                    REFERENCIA1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IMAGEN_BACKGROUND = table.Column<byte[]>(type: "image", nullable: true),
                    EMPRESA_PRINCIPAL = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    DEPARTAMENTO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PROVINCIA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DISTRITO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NOTA = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    IMAGEN_PLAN = table.Column<byte[]>(type: "image", nullable: true),
                    C_ID = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    C_ST = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_EMPRESA", x => x.CODIGO_EMPRESA);
                });

            migrationBuilder.CreateTable(
                name: "OPE_ENTRE",
                columns: table => new
                {
                    CDG_TIAN = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_CAJA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CDG_ANAL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_CTA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CDG_BCO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_FPAG = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_CHEQ = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CDG_MON = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FEC_CAJA = table.Column<DateTime>(type: "datetime", nullable: false),
                    SLD_CAJA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMP_CAJA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TOT_CAJA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    MAX_CAJA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    SWT_CAJA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    CDG_TMOV = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_COR = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FEC_CIERRE = table.Column<DateTime>(type: "datetime", nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CDG_OP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_OS = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NUM_REQUI = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_SD = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_ENTRE", x => new { x.CDG_TIAN, x.NUM_CAJA, x.CDG_ANAL });
                });

            migrationBuilder.CreateTable(
                name: "OPE_ENTRE2",
                columns: table => new
                {
                    CDG_TIAN = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_CAJA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CDG_ANAL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_CTA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CDG_BCO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_FPAG = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_CHEQ = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CDG_MON = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FEC_CAJA = table.Column<DateTime>(type: "datetime", nullable: false),
                    SLD_CAJA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMP_CAJA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TOT_CAJA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    MAX_CAJA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    SWT_CAJA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    CDG_TMOV = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_COR = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FEC_CIERRE = table.Column<DateTime>(type: "datetime", nullable: true),
                    NUM_ITEM = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_REQUI = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_EQUIPO_PRESUPUESTO",
                columns: table => new
                {
                    ID_PRESUPUESTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    FRE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    SERIE_GENERADA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    SERIE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_ESTABLECIMIENTO",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CDG_ESTA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    RUC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    DIRECCION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    TELEFONO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_ESTABLECIMIENTO", x => new { x.CODIGO_EMPRESA, x.CDG_ESTA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_ESTADO_EQUIPO_FRE",
                columns: table => new
                {
                    NUMERO_FRE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SERIE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    SERIE_GENERADA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CDG_ESTADO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_ESTADO_HABITACION",
                columns: table => new
                {
                    ID_RESERVA = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_CHECKIN = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_HABITACION = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ABREVIATURA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    ESTADO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    SWT_SUCIO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_FC_DIARIO",
                columns: table => new
                {
                    tipo_flujo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    movimiento_flujo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    tipo_documento = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    numero_documento = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    fecha_documento = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecha_vencimiento = table.Column<DateTime>(type: "datetime", nullable: true),
                    ruc = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    tipo_persona = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    movimiento_banco = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    fecha_caja = table.Column<DateTime>(type: "datetime", nullable: true),
                    tipo_operacion = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    banco = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    estado_documento = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    fecha_inicio = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecha_fin = table.Column<DateTime>(type: "datetime", nullable: true),
                    importe_soles = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    importe_dolar = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    tipo_cambio = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    estado_flujo_caja = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuario_modificacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_FORM",
                columns: table => new
                {
                    ID_FORM = table.Column<int>(type: "int", nullable: false),
                    NOMBRE_ARCHIVO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    TITULO_FORM = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    DESCRIPCION_FORM = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    OPERACIONES = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    MODULO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_FORMATO_LAB",
                columns: table => new
                {
                    FORMATO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIADOC = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    SECUENCIAPRO = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    CDG_REALIZADO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    COLOR = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ASPECTO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DENSIDAD = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    OLOR = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    REACCION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CEL_EPITELIALES = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PIOCITO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    LEUCOCITO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    HEMATIES = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CILINDRO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CRISTALES = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    OTROS = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    GLUCOSA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    UROBILINOGENO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    SANGRE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PROTEINA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CUERPO_CETONICO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    NITRITO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    BILIRRUBINA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ESTERASA_LEUCOCITANIA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    HEMOGLOBINA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ACIDO_ASCORBICO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    LINFOCITO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    BASOFILO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    MONOCITO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    RANGO1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    RANGO2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    VALOR_REFERENCIAL1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    VALOR_REFERENCIAL2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    VALOR_REFERENCIAL3 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    VALOR_REFERENCIAL4 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    METODO1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    METODO2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    METODO3 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    METODO4 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    UND1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    UND2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    UND3 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    UND4 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    RESULTADO_VERIFICADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_FORMATO_LAB", x => new { x.FORMATO, x.ID_DOCUMENTO, x.ID_PRODUCTO, x.SECUENCIADOC, x.SECUENCIAPRO });
                });

            migrationBuilder.CreateTable(
                name: "OPE_FORMATO_LABVALOR",
                columns: table => new
                {
                    FORMATO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TIPO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    COLOR = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ASPECTO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DENSIDAD = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    OLOR = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    REACCION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CEL_EPITELIALES = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PIOCITO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    LEUCOCITO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    HEMATIES = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CILINDRO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CRISTALES = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    OTROS = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    GLUCOSA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    UROBILINOGENO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    SANGRE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PROTEINA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CUERPO_CETONICO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    NITRITO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    BILIRRUBINA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ESTERASA_LEUCOCITANIA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    HEMOGLOBINA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ACIDO_ASCORBICO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    LINFOCITO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    BASOFILO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    MONOCITO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    RANGO1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    RANGO2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    VALOR_REFERENCIAL1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    VALOR_REFERENCIAL2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    VALOR_REFERENCIAL3 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    VALOR_REFERENCIAL4 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    METODO1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    METODO2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    METODO3 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    METODO4 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    UND1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    UND2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    UND3 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    UND4 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    T1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    T2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    T3 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    T4 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    T5 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    T6 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_FORMATO_LABVALOR", x => new { x.FORMATO, x.TIPO });
                });

            migrationBuilder.CreateTable(
                name: "OPE_FRE",
                columns: table => new
                {
                    NUMERO_FRE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_COMPROMETIDA = table.Column<DateTime>(type: "datetime", nullable: true),
                    CONTACTO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DNI_CONTACTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TELEFONO_CONTACTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EMAIL_CONTACTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DEPARTAMENTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PROVINCIA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DISTRITO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REFERENCIA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NOTAS = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    CDG_ESTADO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_FRE", x => x.NUMERO_FRE);
                });

            migrationBuilder.CreateTable(
                name: "OPE_GASTO_ADICIONAL",
                columns: table => new
                {
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUMERO_DOCUMENTO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    RUC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CDG_GASTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CDG_MEDI = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(3,0)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_GG_PRESUPUESTO",
                columns: table => new
                {
                    ID_PRESUPUESTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    CDG_TABLA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CDG_UNIDAD = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    PARTICIPACION = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    TIEMPO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    SUELDO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    PARCIAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    SUELDOME = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    PARCIALME = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_GG_PRESUPUESTO", x => new { x.ID_PRESUPUESTO, x.SECUENCIA, x.CDG_TABLA, x.CODIGO });
                });

            migrationBuilder.CreateTable(
                name: "OPE_HABITACION",
                columns: table => new
                {
                    ID_HABITACION = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ABREVIATURA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    TIPO_HABITACION = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    GRUPO_HABITACION = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    NO_HABITACION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    PAX_MAX = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_HABITACION", x => x.ID_HABITACION);
                });

            migrationBuilder.CreateTable(
                name: "OPE_IMP_PRESUPUESTO",
                columns: table => new
                {
                    ID_PRESUPUESTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    CDG_UNIDAD = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    PRECIO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    SUBTOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    PROBABILIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    TOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    PRECIOME = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    SUBTOTALME = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    TOTALME = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_IMP_PRESUPUESTO", x => new { x.ID_PRESUPUESTO, x.CODIGO, x.SECUENCIA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_IMP_PROD_WEB",
                columns: table => new
                {
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    RUTA = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: false),
                    NOMBRE_IMAGEN = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    NOMBRE_CARPETA = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_IMP_PROD_WEB", x => new { x.ID_PRODUCTO, x.SECUENCIA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_INGRESO_IMPORTACION",
                columns: table => new
                {
                    file_importacion = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ingreso = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    cdg_costeo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_INVENTARIO_FISICO",
                columns: table => new
                {
                    codigo = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    Almacen = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    Fecha_inventario = table.Column<DateTime>(type: "datetime", nullable: true),
                    Contado_por = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Anotado_por = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Jefe_equipo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    observacion = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    estado = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_INVENTARIO_FISICO", x => new { x.codigo, x.Almacen });
                });

            migrationBuilder.CreateTable(
                name: "OPE_KARDEX",
                columns: table => new
                {
                    CODIGO_SUCURSAL = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ano = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    mes = table.Column<decimal>(type: "numeric(2,0)", nullable: false),
                    saldo = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    usuario_modificacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_LAB_FRE",
                columns: table => new
                {
                    NUMERO_FRE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SERIE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_ESTADO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    CDG_RESPONSABLE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    OBSERVACION2 = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_LETRA_CLIENTE",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    ID_DOCUMENTO = table.Column<int>(type: "int", nullable: false),
                    NUMERO_CANJE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUMERO_DOCUMENTO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    FECHA_CANJE = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_ANULACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ESTADO_CANJE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    NUM_ORIG = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_VOUC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IMPORTE_SOLES = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMPORTE_DOLAR = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    MONEDA_CANJE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    RUC_DOC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    NUM_ORIG_A = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_VOUC_A = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    SWT_CUO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SWT_CANJE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_LETRA_PROVEEDOR",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    ID_DOCUMENTO = table.Column<int>(type: "int", nullable: false),
                    NUMERO_CANJE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUMERO_DOCUMENTO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    FECHA_CANJE = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_ANULACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ESTADO_CANJE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    NUM_ORIG = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_VOUC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IMPORTE_SOLES = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMPORTE_DOLAR = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    MONEDA_CANJE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    RUC_DOC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    NUM_ORIG_A = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_VOUC_A = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_LIBBCO",
                columns: table => new
                {
                    CDG_BCO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUM_CTA = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    NUM_COR = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ANO = table.Column<short>(type: "smallint", nullable: false),
                    MES = table.Column<short>(type: "smallint", nullable: false),
                    CDG_MON = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FEC_DOCU = table.Column<DateTime>(type: "datetime", nullable: false),
                    NUM_DOCU = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CON_DOCU = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    IMP_DEBE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMP_HABER = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMP_SALDO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CDG_TMOV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NUM_ORIG = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NUM_VOUC = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_CTA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    SWT_EST = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    SWT_ATN = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    TIP_CMB = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    DES_PRV = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    NUM_COR_MODULO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    MODULO = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true, defaultValueSql: "('MB')"),
                    FECHA_REF1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_BCO2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_CTA2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    SWT_PRO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    AVANCE = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    TURNO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_REQUI = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_REF = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_SD = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    DOCS = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_LIBBCO", x => new { x.CDG_BCO, x.NUM_CTA, x.NUM_COR });
                });

            migrationBuilder.CreateTable(
                name: "OPE_LIMPIEZA_HABITACION",
                columns: table => new
                {
                    HABITACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    MOTIVO = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    HORA = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    ID_EMPLEADO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ENTRADA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    TOALLAS = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SABANAS = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SALIDA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_LIQUIDACIONM",
                columns: table => new
                {
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ID_CLIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    SWT_PLOMO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    SWT_ZINC = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    SWT_COBRE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    DATO_PROCESO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    TMH_PROCESADO = table.Column<decimal>(type: "numeric(12,4)", nullable: true),
                    TOTAL_INGRESADO = table.Column<decimal>(type: "numeric(12,4)", nullable: true),
                    MONEDA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    SUBTOTAL = table.Column<decimal>(type: "numeric(12,4)", nullable: false),
                    VALOR_VENTA = table.Column<decimal>(type: "numeric(12,4)", nullable: false),
                    IGV = table.Column<decimal>(type: "numeric(12,4)", nullable: false),
                    TOTAL = table.Column<decimal>(type: "numeric(12,4)", nullable: false),
                    IMP_ADEL1 = table.Column<decimal>(type: "numeric(12,4)", nullable: true),
                    IMP_ADEL2 = table.Column<decimal>(type: "numeric(12,4)", nullable: true),
                    IMP_ADEL3 = table.Column<decimal>(type: "numeric(12,4)", nullable: true),
                    OBSERVACIONES = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_APROBACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_APROBACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_AUTORIZA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_AUTORIZA = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_LIQUIDACIONM", x => x.ID_DOCUMENTO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_LISTA_PRECIO",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_TIPO_CLIENTE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MONEDA = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    UNIDAD = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    FACTOR_CONVERSION = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    PRECIO_MINIMO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    COSTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    PRECIO_VENTA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    MARGEN = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CODIGO_BASE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    AUTO_P = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CODIGO_BARRA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_LISTA_PRECIO$", x => new { x.CODIGO, x.CODIGO_EMPRESA, x.CODIGO_SUCURSAL, x.ID_PRODUCTO, x.ID_TIPO_CLIENTE, x.MONEDA, x.UNIDAD, x.FACTOR_CONVERSION });
                });

            migrationBuilder.CreateTable(
                name: "OPE_LOTE",
                columns: table => new
                {
                    NUMERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    VALOR = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_LOTE", x => x.NUMERO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_MAQUINA",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    NUMERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_MAQUINA", x => new { x.CODIGO_EMPRESA, x.CODIGO_SUCURSAL, x.NUMERO });
                });

            migrationBuilder.CreateTable(
                name: "OPE_MESA",
                columns: table => new
                {
                    PISO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    ID_MESA = table.Column<int>(type: "int", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ESTADO_TRANS = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SECUENCIA = table.Column<decimal>(type: "numeric(6,0)", nullable: true),
                    ID_PEDIDO = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    NombreMozo = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_MESA", x => new { x.PISO, x.ID_MESA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_MOVBCO_REQ",
                columns: table => new
                {
                    ID_MOVIMIENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CDG_BCO_EMP = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    CTA_CTE_EMP = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECH_MOV_BCO = table.Column<DateTime>(type: "datetime", nullable: true),
                    NUM_REF = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IMP_BCO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    DOCS = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    DOCS2 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CMITF = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    TC = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    GIRADO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    DETRACCION = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_MOVBCO_REQ", x => x.ID_MOVIMIENTO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_MOVIMIENTO_DINERO",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL_ORIGEN = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    CODIGO_SUCURSAL_DESTINO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    ES_TRASLADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "((0))"),
                    TIPO_MOV = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    ID_MOVIMIENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_RECEPCION = table.Column<DateTime>(type: "datetime", nullable: true),
                    CDG_CONCEPTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CONCEPTO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NUMERO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    MONEDA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CONDICION_PAGO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    TURNO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    COBRADOR = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CAJERO = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    FECHA_APERTURA = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_MP_DOCVEN",
                columns: table => new
                {
                    ORDEN = table.Column<decimal>(type: "numeric(3,0)", nullable: false),
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CDG_MON = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CDG_FP = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CDG_MP = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    IMP = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PROPINA = table.Column<decimal>(type: "numeric(8,2)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_MP_PEDVEN",
                columns: table => new
                {
                    ORDEN = table.Column<decimal>(type: "numeric(3,0)", nullable: false),
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CDG_MON = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CDG_FP = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CDG_MP = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    IMP = table.Column<decimal>(type: "numeric(14,4)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_NI_GASTO_IMPORTACION",
                columns: table => new
                {
                    niga_file_importacion = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    niga_ingreso = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    niga_porcentaje = table.Column<decimal>(type: "numeric(5,2)", nullable: false),
                    niga_prorrateo = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    niga_tipo_documento = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    niga_num_docu = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    niga_ruc = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    niga_importe_dolar = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    niga_tc = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    secuencia = table.Column<int>(type: "int", nullable: true),
                    cuenta = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    glosa = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    secuencia_docu = table.Column<int>(type: "int", nullable: true),
                    cdg_gasto = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    cdg_costeo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_NOTA_COBRANZA",
                columns: table => new
                {
                    ID_SEGUIMIENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    NOTA = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    FECHA_PROXIMO_SEG = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    REFERENCIA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_NOTA_COBRANZA", x => x.ID_SEGUIMIENTO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_NOTA_PROYECTO",
                columns: table => new
                {
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    ID_PROYECTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    NOTA = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_NOTAS_REQ",
                columns: table => new
                {
                    ID_NOTA = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO_REQUERIMIENTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA = table.Column<DateTime>(type: "date", nullable: false),
                    COMENTARIO = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('U')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_NOTAS_REQ", x => x.ID_NOTA);
                });

            migrationBuilder.CreateTable(
                name: "OPE_NUMERO_DOCUMENTO",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SERIE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUMERO_INICIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUMERO_FIN = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_NUMERO_DOCUMENTO", x => new { x.CODIGO_EMPRESA, x.CODIGO_SUCURSAL, x.TIPO_DOCUMENTO, x.SERIE });
                });

            migrationBuilder.CreateTable(
                name: "OPE_OCDC_PRORRATEO",
                columns: table => new
                {
                    ID_OC = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    CDG_GASTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    CDG_CC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PORCENTAJE = table.Column<decimal>(type: "numeric(5,3)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_ODOCUMENTO_COMPRA",
                columns: table => new
                {
                    NUM_COR = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    TDOC = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUM_DOCU = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    RUC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    TDOC_COMP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUM_DOCU_COMP = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    RUC_COMP = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMPORTE_TRANSACCION = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    AUTO_G = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "((0))"),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_ODOCUMENTO_COMPRA", x => new { x.NUM_COR, x.TDOC, x.NUM_DOCU, x.RUC, x.TDOC_COMP, x.NUM_DOCU_COMP, x.RUC_COMP });
                });

            migrationBuilder.CreateTable(
                name: "OPE_OFPR_PRODUCTO",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_TIPO_CLIENTE = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    DESCUENTO1 = table.Column<decimal>(type: "numeric(8,4)", nullable: false),
                    DESCUENTO2 = table.Column<decimal>(type: "numeric(8,4)", nullable: false),
                    CANTIDAD2 = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CANTIDAD3 = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CANTIDAD4 = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    DESCUENTO3 = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    DESCUENTO4 = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_ORDEN_COMPRA",
                columns: table => new
                {
                    ID_OC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    FORMA_PAGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FECHA_ENTREGA = table.Column<DateTime>(type: "datetime", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PORCENTAJE_DSCTO = table.Column<decimal>(type: "numeric(5,2)", nullable: false),
                    DESCUENTO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IGV = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    MONTO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ESTADO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    LUGAR_ENTREGA = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    CDG_COTI = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    FECHA_AUTORIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_AUTORIZA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ATENCION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    REFERENCIA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    INCOTERMS = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    SHIP_ORDER = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SHIPPING_MARKS = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SHIP_TO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    BILL_NET_PRICE_TO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    RESPONSABLE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_VENCIMIENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    PORCENTAJE_IGV = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    VALOR_COMPRA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    TIPO_DOCU = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    MEDIO_TRANSPORTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    PAGO_ADELANTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    FECHA_ESTIMADA_EMBARQUE = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_ESTIMADA_LLEGADA = table.Column<DateTime>(type: "datetime", nullable: true),
                    ORDEN_PEDIDO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    MOTI_ORCO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    SWT_IGV = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "((1))"),
                    ALMACEN = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(12,6)", nullable: true),
                    REF_NUM = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ENTREGA_MATERIAL = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ENTREGA_FACTURA = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    NUM = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FLETE = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    VALOR_AFECTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    VALOR_INAFECTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    REQUI = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_ORDEN_FABRICACION",
                columns: table => new
                {
                    codigo = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    CDG_PLAN = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    estado = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    id_pedido = table.Column<int>(type: "int", nullable: true),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    a_producir = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CDG_CC = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    id_parent = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    producido = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    secuencia = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ref1 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ref2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ref3 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    costo_unitario = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    fecha_cierre = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    usuario_modificacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecha_vencimiento = table.Column<DateTime>(type: "datetime", nullable: true),
                    TIPO_OF = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ALMACEN = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_ORDEN_FABRICACION_SERIELOTE",
                columns: table => new
                {
                    CODIGO_OF = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    NUM_EMBALAJE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    SERIE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    LOTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    UNIDAD = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('P')"),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_ORDEN_SERVICIO",
                columns: table => new
                {
                    CODIGO_SERVICIO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CODIGO_PROD = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    GLOSA = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    REFERENCIA1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REFERENCIA2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REFERENCIA3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REFERENCIA4 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SECUENCIA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PEDIDO = table.Column<int>(type: "int", nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    COSTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CENTRO_COSTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_ORDEN_SERVICIO", x => x.CODIGO_SERVICIO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_ORDEN_TRABAJO",
                columns: table => new
                {
                    CODIGO_SERVICIO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CODIGO_ORDEN_TRABAJO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    CDG_RESPONSABLE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    REFERENCIA1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    REFERENCIA2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    REFERENCIA3 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_OT_PEDIDO",
                columns: table => new
                {
                    CDG_OP = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CDG_OS = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CDG_OT = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_PAGO_CLIENTE",
                columns: table => new
                {
                    NUMERO_COBRO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    COBRADOR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUM_ORIG = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_VOUC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    BANCO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NUM_CTA = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    NUM_COR = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    REF_BANC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    CAJA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    SWT_CUO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    IMPORTE_PAGA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPORTE_VUELTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_PAGO_CLIENTE", x => x.NUMERO_COBRO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_PAGO_TRABAJADOR",
                columns: table => new
                {
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    RUC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CDG_TDOC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NUM_DOCU = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    IMP_PAGO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CDG_MON = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TIP_CMB = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    NUM_COR = table.Column<string>(type: "char(15)", unicode: false, fixedLength: true, maxLength: 15, nullable: true),
                    NUM_CTA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CDG_BCO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NUM_CHEQ = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NUM_ORIG = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NUM_VOUC = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FEC_PAGO = table.Column<DateTime>(type: "datetime", nullable: false),
                    HORA = table.Column<string>(type: "char(8)", unicode: false, fixedLength: true, maxLength: 8, nullable: false),
                    FECHA = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    CDG_FPAG = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CDG_VEND = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_MON_ORI = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    IMP_PAGO_SOLES = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMP_PAGO_DOLAR = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_PARAMETRO",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    VALOR = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    REFERENCIA1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA3 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA4 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA5 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_PARQUEO_VEHICULO",
                columns: table => new
                {
                    ID_MOVIMIENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NUM_COCHERA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUM_PLACA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_INGRESO = table.Column<DateTime>(type: "datetime", nullable: false),
                    HORA_INGRESO = table.Column<string>(type: "char(12)", unicode: false, fixedLength: true, maxLength: 12, nullable: false),
                    FECHA_SALIDA = table.Column<DateTime>(type: "datetime", nullable: true),
                    HORA_SALIDA = table.Column<string>(type: "char(12)", unicode: false, fixedLength: true, maxLength: 12, nullable: true),
                    TIPO_VEHICULO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    DESCRIPCION_VEHICULO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TARIFA_IATP = table.Column<decimal>(type: "numeric(8,2)", nullable: true),
                    IMPORTE_IATP = table.Column<decimal>(type: "numeric(8,3)", nullable: true),
                    HORA_IATP = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    MIN_IATP = table.Column<decimal>(type: "numeric(5,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_PEDIDO",
                columns: table => new
                {
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NUMERO_PEDIDO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CODIGO_VENDEDOR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CODIGO_CPAGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CODIGO_MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FECHA_PEDIDO = table.Column<DateTime>(type: "datetime", nullable: false),
                    NUMERO_OCLIENTE = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    IMPORTE_STOT = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    VALOR_VENTA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPORTE_IGV = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMPORTE_DESCUENTO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMPORTE_TOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PORCENTAJE_DESCUENTO = table.Column<decimal>(type: "numeric(7,4)", nullable: false),
                    PORCENTAJE_IGV = table.Column<decimal>(type: "numeric(7,4)", nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    ESTADO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    ID_CLIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    IMPORTE_ISC = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    ID_CLIENTE_FACTURA = table.Column<int>(type: "int", nullable: true),
                    CODIGO_VENDEDOR_ASIGNADO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_PROGRAMADA = table.Column<DateTime>(type: "datetime", nullable: true),
                    FACTURA_ADELANTADA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    CONTACTO = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    EMAIL_CONTACTO = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    USUARIO_AUTORIZA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_AUTORIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    LUGAR_ENTREGA = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ID_COTIZACION = table.Column<int>(type: "int", nullable: true),
                    ESTADO_FACTURA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    COMISION = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    PUNTO_VENTA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "((0))"),
                    REDONDEO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('0')"),
                    VALIDEZ = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MOTIVO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    CORRELATIVO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CENTRO_COSTO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    SUCURSAL = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    COSTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ID_OPORTUNIDAD = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    VAL_PERCEPCION = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    FECHA_PROGRAMADA_ENTREGA = table.Column<DateTime>(type: "datetime", nullable: true),
                    OBSERVACION2 = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    PAX = table.Column<decimal>(type: "numeric(3,0)", nullable: true, defaultValueSql: "((0))"),
                    MESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PISO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    SWT_ESTA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    DELIVERY = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    CDG_MENSAJERO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    FECHA_FINALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    INICIAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_VENC = table.Column<DateTime>(type: "datetime", nullable: true),
                    SINICIAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    TIPO_DSCTO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ICBPER = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    SWT_PD = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    NUMPAIN = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_PROYECTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    PORCENTAJE_INICIAL = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    TIPO_CONTRATO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    PUNTOS = table.Column<decimal>(type: "numeric(7,0)", nullable: true),
                    PRECIO_PUNTO = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    CALENDARIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    MONTO_INICIAL_HOY = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    PORCENTAJE_INICIAL_HOY = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    FORMA_DE_PAGO_1_INICIAL_HOY = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FP_GA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MONTO_GA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    VENC_GA = table.Column<DateTime>(type: "datetime", nullable: true),
                    BANCO_GA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REF_GA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    FECHA_PROCESABLE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ESTATUS = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    MONTO_A_FINANCIAR = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    PORCENTAJE_MONTO_FINANCIAR = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    NUM_CUOTA_FINANCIAR = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    PORCENTAJE_INTERES_MENSUAL = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    MONTO_CUOTA_MENSUAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    VENC_PRIMERA_CUOTA = table.Column<DateTime>(type: "datetime", nullable: true),
                    SWT_WEB = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    PRIMER_ANO_USO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    CANTIDAD_ANO_CONTRATO = table.Column<decimal>(type: "numeric(3,0)", nullable: true),
                    CDG_SCECO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    IdOrder = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    OrderGuid = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CustomerId = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    OrdeStatus = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PaymentStatusId = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PaymentMethodSystemName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    OrderTotal = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    PaidDateUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    CustomerIp = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PaymentMethodAdditionalFeeInclTax = table.Column<decimal>(type: "numeric(8,2)", nullable: true),
                    PaymentMethodAdditionalFeeExclTax = table.Column<decimal>(type: "numeric(8,2)", nullable: true),
                    ESTADOC = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_PEDIDO", x => x.ID_PEDIDO)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "OPE_PEDIDO_GIRO_ICOMPLEMENTARIA",
                columns: table => new
                {
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    GIRO_ICOMPLEMENTARIA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MONTO_GIRO_ICOMPLEMENTARIA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    VENC_GIRO_ICOMPLEMENTARIA = table.Column<DateTime>(type: "datetime", nullable: true),
                    NO_APLICA1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NO_APLICA2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NO_APLICA3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_PEDIDO_MESA",
                columns: table => new
                {
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_MESA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    PISO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_PEDIDOO = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_PEDIDO_PAGO_IHOY",
                columns: table => new
                {
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    MONTO_PAGO_INICIAL_HOY = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    BANCO_TARJETA_PAGO_INICIAL_HOY = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REFERENCIA_PAGO_INICIAL_HOY = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FECHA_PAGO_INICIAL_HOY = table.Column<DateTime>(type: "datetime", nullable: true),
                    FORMA_PAGO_INICIAL_HOY = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDIDO_PAGO_IHOY", x => new { x.ID_PEDIDO, x.SECUENCIA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_PEDIDO_PUNTAJE",
                columns: table => new
                {
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    MES = table.Column<decimal>(type: "numeric(2,0)", nullable: false),
                    PUNTAJE = table.Column<decimal>(type: "numeric(7,0)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_PEDIDO_PUNTAJE", x => new { x.ID_PEDIDO, x.ANO, x.MES });
                });

            migrationBuilder.CreateTable(
                name: "OPE_PERMISO_PERSONA",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    DESAYUNO = table.Column<short>(type: "smallint", nullable: false),
                    ALMUERZO = table.Column<short>(type: "smallint", nullable: false),
                    CENA = table.Column<short>(type: "smallint", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    LONCHE = table.Column<short>(type: "smallint", nullable: true),
                    BREAK1 = table.Column<short>(type: "smallint", nullable: true),
                    REFERENCIA1 = table.Column<short>(type: "smallint", nullable: true),
                    REFERENCIA2 = table.Column<short>(type: "smallint", nullable: true),
                    REFERENCIA3 = table.Column<short>(type: "smallint", nullable: true),
                    REFERENCIA4 = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_PERSONA",
                columns: table => new
                {
                    ID_PERSONA = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    RUC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    APELLIDO_PATERNO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    APELLIDO_MATERNO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NOMBRE = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    NOMBRE_COMERCIAL = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    TELEFONO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FAX = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DIRECCION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    EMAIL_FE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PAGINA_WEB = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TIPO_PERSONA = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    TIPO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    NOMBRE_CONTACTO1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DIRRECION_CONTACTO1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    EMAIL_CONTACTO1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CARGO_CONTACTO1 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    NOMBRE_CONTACTO2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DIRRECION_CONTACTO2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    EMAIL_CONTACTO2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CARGO_CONTACTO2 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    NOMBRE_CONTACTO3 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DIRRECION_CONTACTO3 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    EMAIL_CONTACTO3 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CARGO_CONTACTO3 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    CODIGO_SUCURSAL = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FECHA_NACIMIENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    ESTADO_CIVIL = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    SEXO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CODIGO_SUCURSAL2 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    FECHA_INGRESO = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECH_CESE = table.Column<DateTime>(type: "datetime", nullable: true),
                    CENTRO_COSTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    AREA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    LINEA_CREDITO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    LINEA_CREDITO_D = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMAGEN = table.Column<byte[]>(type: "image", nullable: true),
                    RUC2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    RAZON_SOCIAL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CUENTA1 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    BANCO1 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    TIPO_TRABAJADOR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ILIMITADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    TIPO_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    VENDEDOR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CONDICION_PAGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    LOTE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ENTREGA_DOCUMENTO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    RUTA_IMAGEN = table.Column<string>(type: "varchar(3000)", unicode: false, maxLength: 3000, nullable: true),
                    REPRESENTANTE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    NUMERO_CONTACTO1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUMERO_CONTACTO2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUMERO_CONTACTO3 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    LISTA_PRECIO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    AGENTE_RETENCION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    PAIS = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DEPARTAMENTO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PROVINCIA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DISTRITO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TELEFONO_CONTACTO1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CELULAR_CONTACTO1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    RPC_CONTACTO1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NEXTEL_CONTACTO1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TELEFONO_CONTACTO2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CELULAR_CONTACTO2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    RPC_CONTACTO2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NEXTEL_CONTACTO2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TELEFONO_CONTACTO3 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CELULAR_CONTACTO3 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    RPC_CONTACTO3 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NEXTEL_CONTACTO3 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CANAL_VENTA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SUBCANAL_VENTA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    REGION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SECTOR_ECONOMICO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SUBSECTOR_ECONOMICO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    BUEN_CONTRIBUYENTE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    AFECTO_SPOT = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    PROVEEDOR_AGUALUZ = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    AGENTE_PERCEPCION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    POR_PERCEPCION = table.Column<decimal>(type: "numeric(7,4)", nullable: true),
                    ZONA_VENTA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    RUTA_VENTA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ORIGEN_CLIE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ESTADO_HNH = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TASA_INTERES = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    NIVEL_RIESGO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    FORMA_ATENCION = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    DESCUENTO = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    EDITA_PRECIO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    REFERENCIA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CATEGORIA_TRAB = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    RUC_REF = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_REFERENCIA = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    TELEFONO2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TIPO_PACIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ESPECIALIDAD = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    OCUPACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SEGURO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_PROSPECTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_PERSONA", x => x.ID_PERSONA);
                });

            migrationBuilder.CreateTable(
                name: "OPE_PLAN_FABRICACION",
                columns: table => new
                {
                    codigo = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    nombre = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    fecha_inicio = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecha_fin = table.Column<DateTime>(type: "datetime", nullable: false),
                    estado = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    usuario_modificacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_PLAN_FACT_GASTO",
                columns: table => new
                {
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    ID_PROYECTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    CDG_CC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ENERO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    FEBRERO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    MARZO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ABRIL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    MAYO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    JUNIO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    JULIO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    AGOSTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    SETIEMBRE = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    OCTUBRE = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    NOVIEMBRE = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    DICIEMBRE = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_PLAN_FACT_GASTO", x => new { x.TIPO, x.ID_PROYECTO, x.ANO });
                });

            migrationBuilder.CreateTable(
                name: "OPE_PLAN_FACTURACION_OC",
                columns: table => new
                {
                    ID_OC = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ITEM = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    VALOR = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    FECHA_ESTIMADA = table.Column<DateTime>(type: "datetime", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_APROBACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_APROBACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_PLANTILLA_RECETA",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    TIPO_LISTA = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    LISTA_PRECIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    PRECIO_UNITARIO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPRIME = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: true),
                    CANTIDAD = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    ALMACEN = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    UNIDAD = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_PRESUPUESTO",
                columns: table => new
                {
                    ID_PRESUPUESTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ID_CLIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_REQUERIMIENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CATEGORIA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SERVICIO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CDG_ING = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_PARENT = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('B')"),
                    COSTO = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    VALOR_VENTA = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: false),
                    OBSERVACION2 = table.Column<string>(type: "varchar(3000)", unicode: false, maxLength: 3000, nullable: false),
                    SWT_MAIN = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    CANTIDAD = table.Column<int>(type: "int", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(CONVERT([char](10),getdate(),(103)))"),
                    GASTO_ADMINISTRATIVO = table.Column<decimal>(type: "numeric(6,3)", nullable: true),
                    GASTO_GENERAL = table.Column<decimal>(type: "numeric(6,3)", nullable: true),
                    MARGEN = table.Column<decimal>(type: "numeric(6,3)", nullable: true),
                    IMPORTE_ADMINISTRATIVO = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    IMPORTE_GENERAL = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    IMPORTE_MARGEN = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    SUCURSAL = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    SUB_TIPO_SERVICIO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FECHA_INICIO = table.Column<DateTime>(type: "date", nullable: true),
                    FECHA_TERMINO = table.Column<DateTime>(type: "date", nullable: true),
                    CANTIDAD_SERVICIO = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    FRECUENCIA_SERVICIO = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    TIEMPO_ONSIDE = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    CANT_MESES_FACT = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    RENOVACION = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true, defaultValueSql: "('NO')"),
                    ID_FACTURAR = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    SWT_PRES = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('P')"),
                    ID_OPORTUNIDAD = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_PROYECTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    EJEC_PROY = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    RESP_PROY = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ESTA_PROY = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    SWT_FACT = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    IMPORTE_APROX_FACTURAR = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPORTE_AMPLIACION = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    TOTAL_APROX_FACTURAR = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    GANANCIA_PROYECTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    PORCENTAJE_PROYECTO = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    MOTIVO_AMPLIACION1 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    USUARIO_APROBACION_A1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_APROBACION_A1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    ESTADO_AMPLIACION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    IMP_GG_DIRECTOMN = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMP_GG_INDIRECTOMN = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMP_GG_DIRECTOME = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMP_GG_INDIRECTOME = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMP_MN = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMP_ME = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    TOTAL_COSTO_OPERATIVO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    UTILIDAD_OPERATIVA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    UTILIDAD_ANTES_IMPUESTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    POR_RENTA_REPARTOUTILIDAD = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    RENTA_REPARTOUTILIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    UTILIDAD_NETA = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_PRESUPUESTO", x => x.ID_PRESUPUESTO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_PRESUPUESTO2",
                columns: table => new
                {
                    ID_PRESUPUESTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ID_CLIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_REQUERIMIENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CATEGORIA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SERVICIO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CDG_ING = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_PARENT = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('B')"),
                    COSTO = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    VALOR_VENTA = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: false),
                    OBSERVACION2 = table.Column<string>(type: "varchar(3000)", unicode: false, maxLength: 3000, nullable: false),
                    SWT_MAIN = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    CANTIDAD = table.Column<int>(type: "int", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(CONVERT([char](10),getdate(),(103)))"),
                    GASTO_ADMINISTRATIVO = table.Column<decimal>(type: "numeric(6,3)", nullable: true),
                    GASTO_GENERAL = table.Column<decimal>(type: "numeric(6,3)", nullable: true),
                    MARGEN = table.Column<decimal>(type: "numeric(6,3)", nullable: true),
                    IMPORTE_ADMINISTRATIVO = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    IMPORTE_GENERAL = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    IMPORTE_MARGEN = table.Column<decimal>(type: "numeric(15,5)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_PRODUCTO",
                columns: table => new
                {
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CODIGO_ANTERIOR = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CODIGO_BARRA = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    NOMBRE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    DESCRIPCION_EXTENDIDA = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    ID_UNIDAD_COMPRA = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    CANT_UNIDAD_COMPRA = table.Column<decimal>(type: "numeric(8,4)", nullable: true),
                    ID_UNIDAD_EMPAQUE_COMPRA = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    CANT_UNIDAD_EMPAQUE_COMPRA = table.Column<decimal>(type: "numeric(8,4)", nullable: true),
                    ID_UNIDAD_VENTA = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    CANT_UNIDAD_VENTA = table.Column<decimal>(type: "numeric(8,4)", nullable: true),
                    ID_UNIDAD_EMPAQUE_VENTA = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    CANT_UNIDAD_EMPAQUE_VENTA = table.Column<decimal>(type: "numeric(8,4)", nullable: true),
                    ID_UNIDAD_INVENTARIO = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    ID_TIPO_PRODUCTO = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    ID_CATEGORIA = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    PRECIO_VENTA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    COMPRA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    VENTA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    INVENTARIO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('0')"),
                    INVENTARIABLE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    STOCK_MINIMO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    STOCK_MAXIMO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    PAGO_TRABAJADOR = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ID_UNIDAD_PAGO_TRABAJADOR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    PAGO_EMPRESA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ID_UNIDAD_PAGO_EMPRESA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    AFECTO_IGV = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    VENTA_MASIVA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    DESAYUNO = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    ALMUERZO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    CENA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    MARCA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    MODELO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PRECIO_COMPRA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    PRECIO_COMPRAD = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    RUTA_FICHA = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    PRESENTACION = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    IGV_COSTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    COSTO_CON_IGV = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    COMISION_CONTADO = table.Column<decimal>(type: "numeric(7,2)", nullable: true),
                    COMISION_CREDITO = table.Column<decimal>(type: "numeric(7,2)", nullable: true),
                    PROMOCION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    EDITA_PRECIO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    EDITA_DESCRIPCION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    MANEJA_SERIE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    MESES_GARANTIA = table.Column<int>(type: "int", nullable: true),
                    MANEJA_LOTE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    MAXIMO = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    MINIMO = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    GRUPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    SUBGRUPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    RUTA_IMAGEN = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    UBICACION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DESTINO_COMANDA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ADICIONAL = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    LONCHE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    BREAK1 = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    REFERENCIA1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    REFERENCIA2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    REFERENCIA3 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    REFERENCIA4 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    PROCEDENCIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CADA_BULTO = table.Column<decimal>(type: "numeric(10,4)", nullable: true),
                    PESO = table.Column<decimal>(type: "numeric(10,4)", nullable: true),
                    XCM = table.Column<decimal>(type: "numeric(10,4)", nullable: true),
                    YCM = table.Column<decimal>(type: "numeric(10,4)", nullable: true),
                    ZCM = table.Column<decimal>(type: "numeric(10,4)", nullable: true),
                    MAXPISO = table.Column<decimal>(type: "numeric(10,4)", nullable: true),
                    GRUPO_PLANIFICACION = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    TECNICA_REPOSICION = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    METODO_ABASTECIMIENTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    INTERVALO_PEDIDO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PEDIDO_MULTIPLE = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    CANT_MIN_COMPRA = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    TIEMPO_ENTREGA = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    TAMANO_LOTE = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    FACTOR_MES = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    MULTIPLICADOR = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    PERIODO_PASADO = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    VENCE_EN = table.Column<decimal>(type: "numeric(3,0)", nullable: true),
                    UNIDAD_VENCE_EN = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    TIEMPO_RETRASO = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    INDICADOR = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    MODELO_GESTION_INVENTARIO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    PROVEEDOR_PREFERIDO = table.Column<int>(type: "int", nullable: true),
                    STOCK_SEGURIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    AFECTO_PERCEPCION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    DETRACCION = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    PERCEPCION_VENTA = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    APLICA_IMPORTE = table.Column<decimal>(type: "numeric(10,4)", nullable: true),
                    REFERENCIA5 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    REFERENCIA6 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    REFERENCIA7 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ID_EQUI_PROD = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    PESO_EMPA_VENTA = table.Column<decimal>(type: "decimal(18,2)", unicode: false, maxLength: 10, nullable: true),
                    XCM_EMPA_VENTA = table.Column<decimal>(type: "decimal(18,2)", unicode: false, maxLength: 10, nullable: true),
                    YCM_EMPA_VENTA = table.Column<decimal>(type: "decimal(18,2)", unicode: false, maxLength: 10, nullable: true),
                    ZCM_EMPA_VENTA = table.Column<decimal>(type: "decimal(18,2)", unicode: false, maxLength: 10, nullable: true),
                    CUENTA_VENTA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CUENTA_COMPRA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ORDEN = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    APLICA_IMPORTE_DETRACCION = table.Column<decimal>(type: "numeric(10,4)", nullable: true),
                    NUM_LAB = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NUM_PRE = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NUM_GEN = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NUM_AFA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    BIEN_SERVICIO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NUM_AFA2 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NUM_AFA3 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NUM_COMP = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NUM_CONC = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NUM_VIAD = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    SWT_REME = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    NUM_REFMED = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    GRUP_UMED = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ID_UNIDAD_REC = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    CANT_UNIDAD_REC = table.Column<decimal>(type: "numeric(8,4)", nullable: true),
                    CDG_CAJA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_COLUMNA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_CASILLERO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    SWT_IMP1 = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SWT_IMP2 = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SWT_WEB = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    VENCIMIENTO = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    CODIGO_SUNAT = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdCategoria = table.Column<decimal>(type: "numeric(7,0)", nullable: true),
                    IdSubCategoria = table.Column<decimal>(type: "numeric(7,0)", nullable: true),
                    Precio1 = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    Precio2 = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    Precio3 = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    Precio4 = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    NUM_LAB2 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    SWT_RESTA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    CONDICION_CLINICA = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CONDICION_PACIENTE = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CONDICION_MUESTRA = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CONDICION_CONTENEDOR = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    VMI_H = table.Column<decimal>(type: "numeric(7,3)", nullable: true),
                    VMA_H = table.Column<decimal>(type: "numeric(7,3)", nullable: true),
                    VMI_M = table.Column<decimal>(type: "numeric(7,3)", nullable: true),
                    VMA_M = table.Column<decimal>(type: "numeric(7,3)", nullable: true),
                    UNIDAD_VALOR = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_PRODUCTO", x => x.ID_PRODUCTO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_PRODUCTO_IMAGEN",
                columns: table => new
                {
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    IMAGEN1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOMBRE_IMAGEN1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_PRODUCTO_IMAGEN", x => x.ID_PRODUCTO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_PRODUCTO_SUCURSAL",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    PAGO_TRABAJADOR = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ID_UNIDAD_PAGO_TRABAJADOR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    PAGO_EMPRESA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ID_UNIDAD_PAGO_EMPRESA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_PRODUCTO_SUCURSAL", x => new { x.CODIGO_EMPRESA, x.CODIGO_SUCURSAL, x.ID_PRODUCTO });
                });

            migrationBuilder.CreateTable(
                name: "OPE_PROGRAMACION_MN",
                columns: table => new
                {
                    ID_MN = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_PROGRAMACION_MENU", x => new { x.ID_MN, x.FECHA, x.ID_PRODUCTO, x.TIPO });
                });

            migrationBuilder.CreateTable(
                name: "OPE_PROGRAMACION_PAGO",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUM = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FECHA_PAGO = table.Column<DateTime>(type: "datetime", nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    IMPORTE_MN = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPORTE_ME = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CDG_BANCO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NUM_CTA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_PROGRAMACION_PAGO", x => new { x.CODIGO_EMPRESA, x.CODIGO_SUCURSAL, x.NUM });
                });

            migrationBuilder.CreateTable(
                name: "OPE_PROMOCION_PRODUCTO",
                columns: table => new
                {
                    ID_PROMOCION = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    PRECIO_VENTA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CODIGO_KIT = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_PROMOCION_PRODUCTO", x => x.ID_PROMOCION);
                });

            migrationBuilder.CreateTable(
                name: "OPE_PROSPECTO",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    ID_PROSPECTO = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    RUC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    APELLIDO_PATERNO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    APELLIDO_MATERNO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NOMBRE = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    TELEFONO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FAX = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DIRECCION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    EMAIL_FE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PAGINA_WEB = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    RAZON_SOCIAL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    VENDEDOR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CONDICION_PAGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    PAIS = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DEPARTAMENTO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PROVINCIA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DISTRITO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CANAL_VENTA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SUBCANAL_VENTA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    REGION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SECTOR_ECONOMICO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SUBSECTOR_ECONOMICO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ZONA_VENTA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    RUTA_VENTA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TIPO_PERSONA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    INICIO_EMPRESA = table.Column<DateTime>(type: "datetime", nullable: true),
                    GIRO_EMPRESA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_PROVEEDOR_PRODUCTO",
                columns: table => new
                {
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    UNIDAD = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    CDG_MON = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    PRECIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    NUMERO_PARTE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FACTOR = table.Column<decimal>(type: "numeric(7,4)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_PROVEEDOR_PRODUCTO", x => new { x.ID_PERSONA, x.ID_PRODUCTO, x.UNIDAD });
                });

            migrationBuilder.CreateTable(
                name: "OPE_PUNTOS_VENTA",
                columns: table => new
                {
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    PUNTOS = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    DESCONTADOS = table.Column<decimal>(type: "numeric(10,2)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_RECETA",
                columns: table => new
                {
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    ID_RECETA = table.Column<int>(type: "int", nullable: false),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CDG_UNIDAD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false),
                    TIPO_LISTA = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    LISTA_PRECIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    PRECIO_UNITARIO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    TOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ALMACEN = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    CANT = table.Column<decimal>(type: "numeric(10,2)", nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_RECETA", x => new { x.ID_PRODUCTO, x.ID_RECETA, x.TIPO });
                });

            migrationBuilder.CreateTable(
                name: "OPE_REFERENCIA_ADELANTO",
                columns: table => new
                {
                    NUMERO_COBRO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PRECIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_REFERENCIA_BANCARIA",
                columns: table => new
                {
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    BANCO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CUENTA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CCI = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_REFERENCIA_PERSONA",
                columns: table => new
                {
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, comment: "1:SUCURSAL;2:LABORAL;3:FAMILIAR"),
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    DIRECCION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    FAX = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TELEFONO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false),
                    CDG_DST = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    APELLIDOS = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    FECHA_NACIMIENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    NUMERO_DOCUMENTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_PARE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CONTACTO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CELULAR = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    RCP = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NEXTEL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    REFERENCIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_SUCURSAL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_REPROGRAMACION_OC",
                columns: table => new
                {
                    SECUENCIA = table.Column<decimal>(type: "numeric(15,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_OC = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SEC_OC = table.Column<int>(type: "int", nullable: false),
                    FECHA_ENTREGA = table.Column<DateTime>(type: "datetime", nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    TIPO_FECHA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ESTADO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CANAL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_REPROGRAMACION_OC", x => x.SECUENCIA);
                });

            migrationBuilder.CreateTable(
                name: "OPE_REQITEMS",
                columns: table => new
                {
                    ID_REQUERIMIENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_PEDIDO = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_REQUERIDO = table.Column<DateTime>(type: "datetime", nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SOLICITANTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SWT_REQ = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    CDG_CC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_APROBACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_APROBACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_REQITEMS", x => x.ID_REQUERIMIENTO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_REQUERIMIENTO",
                columns: table => new
                {
                    CODIGO_REQUERIMIENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    ESTADO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    ID_PERSONA = table.Column<int>(type: "int", nullable: true),
                    PRIORIDAD = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    MOTIVO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    FECHA_ATENCION = table.Column<DateTime>(type: "datetime", nullable: true),
                    HORA_ATENCION = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    CDG_INGENIERO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    DESCRIPCION = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    CDG_VEND_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_VEND_ASIGNADO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TIPO_REQU = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CENTRO_COSTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: true),
                    CANTIDAD_PEDIDA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    PRECIO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ID_OC = table.Column<int>(type: "int", nullable: true),
                    CANTIDAD_INGRESADA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    SECUENCIA = table.Column<int>(type: "int", nullable: true),
                    CDG_PLAN = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_ORD = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_PRODUCTO_OF = table.Column<int>(type: "int", nullable: true),
                    CDG_SERV = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    CDG_OP = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SECUENCIA_OC = table.Column<int>(type: "int", nullable: true),
                    CDG_SCC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_REQUISICION",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_PEDIDO = table.Column<DateTime>(type: "datetime", nullable: true),
                    NUM_REQUI = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SOLICITANTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    MOD_PAGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    SUBTOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    POR_IGV = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    IGV = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    VALOR_COMPRA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    TOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_APROBACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_APROBACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    SWT_REQ = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    CTA_CTE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    VEHICULO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    CODIGO_SUCURSAL = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    OBSERVACION2 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CDG_BCO_EMP = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    CTA_CTE_EMP = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECH_MOV_BCO = table.Column<DateTime>(type: "datetime", nullable: true),
                    NUM_REF = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DOCS = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IMP_BCO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    TASA = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    PERCEPCION = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ID_OC = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_REQUISICION_1", x => x.CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_REQUISICION_ANEXO",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NOMBRE_ARCHIVO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ARCHIVO = table.Column<byte[]>(type: "image", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    EXTENSION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_RESERVA",
                columns: table => new
                {
                    ID_RESERVA = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ESTADO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_ENTRADA = table.Column<DateTime>(type: "datetime", nullable: false),
                    HORA = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    FECHA_SALIDA_PREVISTA = table.Column<DateTime>(type: "datetime", nullable: false),
                    CANT_NOCHES = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    NO_PRESENTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    REGIMEN = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COMIDA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ADULTO = table.Column<decimal>(type: "numeric(3,0)", nullable: false),
                    NINO = table.Column<decimal>(type: "numeric(3,0)", nullable: false),
                    BEBE = table.Column<decimal>(type: "numeric(3,0)", nullable: false),
                    ID_CLIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_EMPRESA = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_AGENCIA = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_TOUR_OPERADOR = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_CLIENTE_FACTURAR = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    TIPO_TARIFA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    TIPO_HABITACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    HABITACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    SWT_TIPO_HABITACION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    HORA_SALIDA = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: true),
                    TURNO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_RESERVA", x => x.ID_RESERVA);
                });

            migrationBuilder.CreateTable(
                name: "OPE_RESULTADO_FINAL_LAB",
                columns: table => new
                {
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIARESUL = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    SECUENCIADOC = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    CDG_AGRUPACION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    TIPO_DATO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    VALOR_DEFECTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NOM_CAMPO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    VALOR_OPCION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    UNIDAD_VALOR = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    VALOR_RANGO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    VALOR_REFRENCIA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    METODO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CDG_REALIZADO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFCACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_RESULTADO_FINAL_LAB", x => new { x.ID_DOCUMENTO, x.ID_PRODUCTO, x.SECUENCIARESUL });
                });

            migrationBuilder.CreateTable(
                name: "OPE_RESULTADO_PRODUCTO",
                columns: table => new
                {
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    CDG_AGRUPACION = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    TIPO_DATO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    VALOR_DEFECTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NOM_CAMPO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FORMULA = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    OPCIONES = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    VMI_H = table.Column<decimal>(type: "numeric(7,3)", nullable: true),
                    VMA_H = table.Column<decimal>(type: "numeric(7,3)", nullable: true),
                    VMI_M = table.Column<decimal>(type: "numeric(7,3)", nullable: true),
                    VMA_M = table.Column<decimal>(type: "numeric(7,3)", nullable: true),
                    UNIDAD_VALOR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    VALOR_REFRENCIA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    METODO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_RLK",
                columns: table => new
                {
                    RGID = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    USR = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MB = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CDG = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_SEGUIMIENTO_COTI",
                columns: table => new
                {
                    ID_SECUENCIA = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_COTIZACION = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ANO_CIERRE = table.Column<decimal>(type: "numeric(4,0)", nullable: true),
                    MES_CIERRE = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    ANO_ENTREGA = table.Column<decimal>(type: "numeric(4,0)", nullable: true),
                    MES_ENTREGA = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    FECHA_SEGUIMIENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_PROX_SEG = table.Column<DateTime>(type: "datetime", nullable: false),
                    PROB_CIERRE = table.Column<decimal>(type: "numeric(7,2)", nullable: false),
                    PORC_AVANCE = table.Column<decimal>(type: "numeric(7,2)", nullable: false),
                    COMENTARIO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_SEGUIMIENTO_COTI", x => x.ID_SECUENCIA);
                });

            migrationBuilder.CreateTable(
                name: "OPE_SEGUIMIENTO_IMPORTACION",
                columns: table => new
                {
                    SECUENCIA = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_OC = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CDG_HITO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    FECHA_HITO = table.Column<DateTime>(type: "datetime", nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_SEGUIMIENTO_IMPORTACION", x => x.SECUENCIA);
                });

            migrationBuilder.CreateTable(
                name: "OPE_SEGUIMIENTO_PEDI",
                columns: table => new
                {
                    ID_PROGRAMACION = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_PEDIDO = table.Column<int>(type: "int", nullable: false),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false),
                    FECHA_REPROGRAMADA = table.Column<DateTime>(type: "datetime", nullable: false),
                    MOTIVO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    COMENTARIO = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_SOLICITUD_ANTICIPO_PROVEEDOR",
                columns: table => new
                {
                    ID_SOLICITUD = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ID_OC = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    FECHA_SOLICITUD = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_REQUERIDA = table.Column<DateTime>(type: "datetime", nullable: false),
                    TIPO_ANAL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CODIGO_ANAL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    MOTIVO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CDG_CECO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_APROBACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_APROBACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_SOLICITUD_ANTICIPO_PROVEEDOR", x => x.ID_SOLICITUD);
                });

            migrationBuilder.CreateTable(
                name: "OPE_SOLICITUD_DINERO",
                columns: table => new
                {
                    ID_SOLICITUD = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_SOLICITUD = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_REQUERIDA = table.Column<DateTime>(type: "datetime", nullable: false),
                    TIPO_ANAL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CODIGO_ANAL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    MOTIVO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CDG_CECO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_APROBACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_APROBACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    SOLICITANTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    MOTIVO_RECHAZO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    USUARIO_RECHAZO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_RECHAZO = table.Column<DateTime>(type: "datetime", nullable: true),
                    CODIGO_OC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_COMP = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_ITEM = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    NUM_DOCU = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TDOC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_SOLICITUD_DINERO", x => x.ID_SOLICITUD);
                });

            migrationBuilder.CreateTable(
                name: "OPE_SOLICITUD_DOCUMENTO",
                columns: table => new
                {
                    ID_SOLICITUD = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    MOTIVO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SUBTOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    DESCUENTO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ANTICIPO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    VALOR_VENTA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    POR_IGV = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    IGV = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ID_GUIA = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_APROBACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_APROBACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_SOLICITUD_DOCUMENTO", x => x.ID_SOLICITUD);
                });

            migrationBuilder.CreateTable(
                name: "OPE_SOLICITUD_REQUERIMIENTO",
                columns: table => new
                {
                    ID_REQUERIMIENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TIPO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: true),
                    SOLICITANTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    ID_PROYECTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_APROBACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_APROBACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_SOLICITUD_REQUERIMIENTO", x => x.ID_REQUERIMIENTO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_SOLICITUD_VJEVTO",
                columns: table => new
                {
                    ID_SOLICITUD = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_SOLICITUD = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_REQUERIDA = table.Column<DateTime>(type: "datetime", nullable: false),
                    TIPO_ANAL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CODIGO_ANAL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    TOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    MOTIVO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ID_CLIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    TOTAL_VIAJE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TOTAL_VIATICO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    COMENTARIO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ID_PROYECTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_APROBACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_APROBACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    MOTIVO_RECHAZO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    USUARIO_RECHAZO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_RECHAZO = table.Column<DateTime>(type: "datetime", nullable: true),
                    TOTAL_ADICIONAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_SOLICITUD_VJECTO", x => x.ID_SOLICITUD);
                });

            migrationBuilder.CreateTable(
                name: "OPE_STOCK_LOTE",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    LOTE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CANTIDAD_INGRESADA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CANTIDAD_SALIDA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    STOCK_ACTUAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CODIGO_UNIDAD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SERIE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_STOCK_PRODUCTO",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: true),
                    CANTIDAD_INICIAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CANTIDAD_INGRESADA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CANTIDAD_SALIDA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CANTIDAD_ACTUAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_TABLA",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "(1)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_TABLA", x => x.CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "OPE_TARIFA",
                columns: table => new
                {
                    ID_TARIFA = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    AL = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    AD = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    MP = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    PC = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    TI = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    CARGO_PERSONA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    CARGO_DIA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    NOCHES = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    ADULTO_MIN = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    ADULTO_MAX = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    NINO_MAX = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    PAX_MIN = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    PAX_MAX = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    NOCHE_MAX = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    NOCHE_MIN = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    DIAS_DSCTO = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    DSCTO = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    LUNES = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    MARTES = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    MIERCOLES = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    JUEVES = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    VIERNES = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    SABADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    DOMINGO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    CONCEPTO_CARGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_TARIFA", x => x.ID_TARIFA);
                });

            migrationBuilder.CreateTable(
                name: "OPE_TARIFA_HABITACION",
                columns: table => new
                {
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    REGIMEN = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    TIPO_HABITACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    PRECIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CONCEPTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CARGO_PERSONA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_TARIFA_PRECIO",
                columns: table => new
                {
                    ID_TARIFA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    TEMPORADA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    ALOJAMIENTO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    DESAYUNO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    MEDIA_PENSION = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PENSION_COMPLETA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TODO_INCLUIDO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_TARIFA_TEMPORADA",
                columns: table => new
                {
                    ID_TARIFA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    TEMPORADA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_TARIFA_TIPO_HABITACION",
                columns: table => new
                {
                    ID_TARIFA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    TIPO_HABITACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_TARJETA_EQUIPO",
                columns: table => new
                {
                    ID_SERIE = table.Column<decimal>(type: "numeric(15,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SERIE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    SERIE_GEN = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SERIE_REEM = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_MARCA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_MODELO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DEPARTAMENTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PROVINCIA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DISTRITO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UBICACION = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CDG_ESTADO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    ID_PEDIDO = table.Column<int>(type: "int", nullable: true),
                    ID_GUIA = table.Column<int>(type: "int", nullable: true),
                    NUM_FRE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: true),
                    RECORDATORIO = table.Column<int>(type: "int", nullable: true),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: true),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_TARJETA_EQUIPO", x => x.ID_SERIE);
                });

            migrationBuilder.CreateTable(
                name: "OPE_TDOC_APERTURA",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    CODIGO_CAJA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_APERTURA = table.Column<DateTime>(type: "datetime", nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    SERIES = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_TDOC_APERTURA", x => new { x.CODIGO_EMPRESA, x.CODIGO_SUCURSAL, x.CODIGO_CAJA, x.FECHA_APERTURA, x.TIPO_DOCUMENTO });
                });

            migrationBuilder.CreateTable(
                name: "OPE_TDOC_PUNTO_VENTA",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_USUARIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    SERIES = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_TDOC_PUNTO_VENTA", x => new { x.CODIGO_EMPRESA, x.CODIGO_USUARIO, x.TIPO_DOCUMENTO });
                });

            migrationBuilder.CreateTable(
                name: "OPE_TEMP_COMANDA",
                columns: table => new
                {
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PRECIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ZONA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MESA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MOZO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CAJA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TURNO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ESTADO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_TEMP_COMANDA", x => new { x.ID_PEDIDO, x.ID_PRODUCTO, x.SECUENCIA });
                });

            migrationBuilder.CreateTable(
                name: "OPE_TEMPORADA",
                columns: table => new
                {
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    TIPO_TEMPORADA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_TICKET",
                columns: table => new
                {
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    NUM_TICKET = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_ATENCION = table.Column<DateTime>(type: "datetime", nullable: true),
                    CODIGO_TURNO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_TICKET", x => new { x.ID_DOCUMENTO, x.ID_PRODUCTO, x.NUM_TICKET });
                });

            migrationBuilder.CreateTable(
                name: "OPE_TIPO_CAMBIO",
                columns: table => new
                {
                    MONEDA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    VALOR_VENTA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    VALOR_COMPRA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    VALOR_COMERCIAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_TMOV_TDOC",
                columns: table => new
                {
                    CDG_TDOC = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_TMOV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_FLUJO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_MFLUJO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_TRANSFERENCIA",
                columns: table => new
                {
                    NUM_TRAN = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FEC_TRAN = table.Column<DateTime>(type: "datetime", nullable: false),
                    RUC_PRV = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CDG_BCO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUM_CTA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CDG_CTA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CDG_MON = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUM_COR = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_CHEQ = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    IMP_TRAN = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    BCO_TRAN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CTA_TRAN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MON_TRAN = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    OBS_TRAN = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    PAG_TRAN = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    SWT_TRAN = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    CDG_TDOC = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_TMOV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    REF_NUMERO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    REF_CDG_TDOC = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    NUM_REQUI = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SWT_REQ = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    REFERENCIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_USUARIO",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    SUPERUSUARIO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    ADMINISTRADOR = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    CONTRASENA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    EMAIL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    CAJERO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    REFERENCIA1 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA2 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA3 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA4 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA5 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    IMAGEN1 = table.Column<byte[]>(type: "image", nullable: true),
                    REFERENCIA6 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA7 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA8 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA9 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA10 = table.Column<string>(type: "varchar(3000)", unicode: false, maxLength: 3000, nullable: true),
                    REFERENCIA11 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA12 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA13 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA14 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA15 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA16 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA17 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA18 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA19 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA20 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA21 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA22 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA23 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA24 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA25 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA26 = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    REFERENCIA27 = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    REFERENCIA28 = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    REFERENCIA29 = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    REFERENCIA30 = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    REFERENCIA31 = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    REFERENCIA32 = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    REFERENCIA33 = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    REFERENCIA34 = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    REFERENCIA35 = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    REFERENCIA36 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    REFERENCIA37 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    REFERENCIA38 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    REFERENCIA39 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    REFERENCIA40 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_USUARIO", x => new { x.CODIGO_EMPRESA, x.CODIGO });
                });

            migrationBuilder.CreateTable(
                name: "OPE_USUARIO_FORM",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    ID_FORM = table.Column<int>(type: "int", nullable: false),
                    OPERACIONES = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CODIGO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_VALORIZACION",
                columns: table => new
                {
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    ano = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    mes = table.Column<decimal>(type: "numeric(2,0)", nullable: false),
                    costo_sol = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    cantidad = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    costo = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    costo_dol = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PLAN_PRESUPUESTO",
                columns: table => new
                {
                    ID_PRESUPUESTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ID_CLIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_REQUERIMIENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CATEGORIA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SERVICIO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CDG_ING = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_PARENT = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('B')"),
                    COSTO = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    VALOR_VENTA = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: false),
                    OBSERVACION2 = table.Column<string>(type: "varchar(3000)", unicode: false, maxLength: 3000, nullable: false),
                    SWT_MAIN = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    CANTIDAD = table.Column<int>(type: "int", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(CONVERT([char](10),getdate(),(103)))"),
                    GASTO_ADMINISTRATIVO = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    GASTO_GENERAL = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    MARGEN = table.Column<decimal>(type: "numeric(6,3)", nullable: true),
                    IMPORTE_ADMINISTRATIVO = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    IMPORTE_GENERAL = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    IMPORTE_MARGEN = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    SUCURSAL = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    SUB_TIPO_SERVICIO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FECHA_INICIO = table.Column<DateTime>(type: "date", nullable: true),
                    FECHA_TERMINO = table.Column<DateTime>(type: "date", nullable: true),
                    CANTIDAD_SERVICIO = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    FRECUENCIA_SERVICIO = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    TIEMPO_ONSIDE = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    CANT_MESES_FACT = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    RENOVACION = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true, defaultValueSql: "('NO')"),
                    ID_FACTURAR = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    SWT_PRES = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('P')"),
                    ID_OPORTUNIDAD = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLAN_PRESUPUESTO", x => x.ID_PRESUPUESTO);
                });

            migrationBuilder.CreateTable(
                name: "REQ_ALMACEN",
                columns: table => new
                {
                    req_id = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    cooc_id = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_GUIA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    cantidad = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    secuencia_req = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    secuencia_oc = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    secuencia_guia = table.Column<decimal>(type: "numeric(6,0)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "REQ_OC",
                columns: table => new
                {
                    req_id = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    cooc_id = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    cantidad = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    secuencia_req = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    secuencia_oc = table.Column<decimal>(type: "numeric(6,0)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RQ_DETALLE_CC_PRESUPUESTO",
                columns: table => new
                {
                    NUM_PRE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUMERO_CONCEPTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    MES = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    CDG_CC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    PRESUPUESTADO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RQ_DETALLE_PRESUPUESTO",
                columns: table => new
                {
                    NUM_PRE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUMERO_CONCEPTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    MES = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    PRESUPUESTADO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RQ_PRESUPUESTO",
                columns: table => new
                {
                    NUM_PRE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_PRE_P = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NOMBRE = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    NOTA = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RRHH_ANEXO_PERSONAL",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CDG_TDOC = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    FECHA_EMISION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_VENCIMIENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    NOMBRE_ARCHIVO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ARCHIVO = table.Column<byte[]>(type: "image", nullable: true),
                    SECUENCIA = table.Column<decimal>(type: "numeric(7,0)", nullable: true),
                    EXTENSION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RRHH_ASIGNACION_RECURSO",
                columns: table => new
                {
                    ID_ASIGNACION = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    MARCA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MODELO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SERIE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REFERENCIA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    COMENTARIO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    FECHA_ENTREGA = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_DEVOLUCION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RRHH_ASIGNACION_RECURSO", x => x.ID_ASIGNACION);
                });

            migrationBuilder.CreateTable(
                name: "RRHH_CAPACITACION",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    TIPO_EVENTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    TIPO_CURSO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    TIPO_ORGANIZACION = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ORGANIZACION = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NOMBRE_CURSO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    FECHA_IREALIZACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_FREALIZACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    CANTIDAD_HORA = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    LUGAR = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NOTA = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RRHH_CONCEPTO_PERSONA",
                columns: table => new
                {
                    CDG_PARA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    MES = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    SEMANA = table.Column<int>(type: "int", nullable: false),
                    CDG_PROY = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    TIPO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    TOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RRHH_CONCEPTO_PERSONA", x => new { x.CDG_PARA, x.ID_PERSONA, x.ANO, x.MES, x.SEMANA, x.CDG_PROY });
                });

            migrationBuilder.CreateTable(
                name: "RRHH_CONSOLIDADO_ASISTENCIA",
                columns: table => new
                {
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    MES = table.Column<int>(type: "int", nullable: false),
                    SEMANA = table.Column<int>(type: "int", nullable: false),
                    CDG_PROY = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    DIAS_TRAB = table.Column<int>(type: "int", nullable: false),
                    FALTAS = table.Column<int>(type: "int", nullable: true),
                    HORA_TRAB = table.Column<decimal>(type: "numeric(8,2)", nullable: false),
                    MINU_TARD = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    HE_25 = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    HE_35 = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    HE_60 = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    HE_100 = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: true),
                    FERIADO = table.Column<decimal>(type: "numeric(6,2)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RRHH_CONSOLIDADO_ASISTENCIA_TAREO",
                columns: table => new
                {
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    MES = table.Column<int>(type: "int", nullable: false),
                    SEMANA = table.Column<int>(type: "int", nullable: false),
                    CDG_CC = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_SCC = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_TURNO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    DIAS_TRAB = table.Column<int>(type: "int", nullable: false),
                    FALTAS = table.Column<int>(type: "int", nullable: true),
                    HORA_TRAB = table.Column<decimal>(type: "numeric(8,2)", nullable: false),
                    MINU_TARD = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    HE_25 = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    HE_35 = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    HE_60 = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    HE_100 = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: true),
                    FERIADO = table.Column<decimal>(type: "numeric(6,2)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RRHH_CONTRATO",
                columns: table => new
                {
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    TIPO_CONTRATO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    INICIO_PRUEBA = table.Column<DateTime>(type: "datetime", nullable: true),
                    FIN_PRUEBA = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_INSCRIPCION = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    RENOVACION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    CONTRATO = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RRHH_CONTROL_VACACION",
                columns: table => new
                {
                    ID_CONTROL = table.Column<decimal>(type: "numeric(15,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    TIPO_VACA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    FECHA_SALIDA = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_RETORNO = table.Column<DateTime>(type: "datetime", nullable: false),
                    DIAS_EFECTIVO = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    DIAS_VACA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    COMENTARIO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ANO_PAGO = table.Column<int>(type: "int", nullable: true),
                    MES_PAGO = table.Column<int>(type: "int", nullable: true),
                    SEMANA = table.Column<int>(type: "int", nullable: true),
                    CDG_PROY = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RRHH_CTA_5TA_CAT",
                columns: table => new
                {
                    CDG_PARA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    MES = table.Column<int>(type: "int", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    SWT_TIPO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RRHH_CTA_CTE_TRABAJADOR",
                columns: table => new
                {
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    CDG_PARA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    NUMERO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PAGADO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RRHH_DERECHO_HABIENTE",
                columns: table => new
                {
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_DH = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    APELLIDO_PATERNO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    APELLIDO_MATERNO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NRO_DOCUMENTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_NACIMIENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    SEXO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    ESTADO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    VINCULO_FAMILIAR = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    INCAPACIDAD = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    RESOLUCION_DIRECTORAL = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    DOMICILIO_DH = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SITUACION_DH = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ALTA_DH = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    FECHA_ALTA = table.Column<DateTime>(type: "datetime", nullable: true),
                    MOTIVO_BAJA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    BAJA_DH = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    FECHA_BAJA = table.Column<DateTime>(type: "datetime", nullable: true),
                    TD_ACREDITA_PATERNIDAD = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NRO_ACREDITA_PATERNIDAD = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    VIA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ZONA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NOMBRE_VIA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NOMBRE_ZONA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NRO_VIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    INTERIOR = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    REFERENCIA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DEPARTAMENTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PROVINCIA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    UBIGEO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RRHH_DERECHO_HABIENTE", x => new { x.ID_PERSONA, x.ID_DH });
                });

            migrationBuilder.CreateTable(
                name: "RRHH_DETALLE_HORARIO",
                columns: table => new
                {
                    CDG_HORARIO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DIA = table.Column<short>(type: "smallint", nullable: false),
                    LIMITE_INICIO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    DIA_LIMITE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    LIMITE_FIN = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    INGRESO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    SALIDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    SALIDA_REFRIGERIO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ENTRADA_REFRIGERIO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RRHH_DETALLE_HORARIO", x => new { x.CDG_HORARIO, x.DIA });
                });

            migrationBuilder.CreateTable(
                name: "RRHH_DETALLE_INCIDENCIA_MEMO",
                columns: table => new
                {
                    TIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    TIPO2 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    SECUENCIA2 = table.Column<decimal>(type: "numeric(6,0)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RRHH_DETALLE_PLANILLA",
                columns: table => new
                {
                    CDG_PARAM = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CDG_PLANILLA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    MES = table.Column<int>(type: "int", nullable: false),
                    SEMANA = table.Column<int>(type: "int", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    IDA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    NRNR = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    AFECTO_ESSALUD = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    AFECTO_ESSALUD_SCTR = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    AFECTO_SENATI = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    AFECTO_SISTEMA_PENSION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    AFECTO_SISTEMA_PRIVADO_PENSION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    AFECTO_QUINTA_CATEGORIA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    AFECTO_GRATIFICACION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    AFECTO_CTS = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    AFECTO_VACACION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    AFECTO_UTIL = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    AFECTO_LIQUIDACION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    TIPO_ASISTENCIA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ASISTENCIA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SWT_PLA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    NOMBRE_PARAM = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    REFE_PARAM = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    UNIDAD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    AFECTO_ONP_SCTR = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    AFECTO_CONAFOVICER = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ANO_REF1 = table.Column<decimal>(type: "numeric(4,0)", nullable: true),
                    MES_REF1 = table.Column<decimal>(type: "numeric(2,0)", nullable: true),
                    SEMANA_REF1 = table.Column<decimal>(type: "numeric(2,0)", nullable: true),
                    CDG_PROY = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RRHH_DETALLE_PRESTAMO",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ITEM = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    MES = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    COMENTARIO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RRHH_DISTRIBUCION_CENTROCOSTO",
                columns: table => new
                {
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CENTRO_COSTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CODIGO_ESTABLECIMIENTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    PORCENTAJE = table.Column<decimal>(type: "numeric(10,4)", nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RRHH_HORARIO",
                columns: table => new
                {
                    CDG_HORARIO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RRHH_HORARIO", x => x.CDG_HORARIO);
                });

            migrationBuilder.CreateTable(
                name: "RRHH_INCIDENCIA_MEMO",
                columns: table => new
                {
                    SECUENCIA = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    TIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    DESCRIPCION = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RRHH_INCIDENCIA_MEMO", x => new { x.SECUENCIA, x.ID_PERSONA, x.TIPO });
                });

            migrationBuilder.CreateTable(
                name: "RRHH_MARCACION_ASISTENCIA",
                columns: table => new
                {
                    ID_MARCACION = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    INGRESO = table.Column<DateTime>(type: "datetime", nullable: false),
                    HORA_INGRESO = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    SALIDA = table.Column<DateTime>(type: "datetime", nullable: false),
                    HORA_SALIDA = table.Column<string>(type: "char(5)", unicode: false, fixedLength: true, maxLength: 5, nullable: false),
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    MES = table.Column<int>(type: "int", nullable: false),
                    SEMANA = table.Column<int>(type: "int", nullable: false),
                    CDG_PROY = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FALTAS = table.Column<int>(type: "int", nullable: true),
                    HORA_TRAB = table.Column<decimal>(type: "numeric(8,2)", nullable: false),
                    MINU_TARD = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    HE_25 = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    HE_35 = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    HE_60 = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    HE_100 = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RRHH_MARCACION_ASISTENCIA_1", x => x.ID_MARCACION);
                });

            migrationBuilder.CreateTable(
                name: "RRHH_PERMISO_SANCION",
                columns: table => new
                {
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    TIPO_PERMISO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    MES = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    SEMANA = table.Column<int>(type: "int", nullable: false),
                    CDG_PROY = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    HORAS = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    REFERENCIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    COMENTARIO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RRHH_PERMISO_SANCION_1", x => new { x.ID_PERSONA, x.TIPO_PERMISO, x.ANO, x.MES, x.SEMANA, x.CDG_PROY });
                });

            migrationBuilder.CreateTable(
                name: "RRHH_PLANILLA",
                columns: table => new
                {
                    ID_PERSONA = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    MES = table.Column<int>(type: "int", nullable: false),
                    SEMANA = table.Column<int>(type: "int", nullable: false),
                    NUMERO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_INGRESO = table.Column<DateTime>(type: "datetime", nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    DIRECCION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    AREA = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    CARGO = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    CENTRO_COSTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    OBRA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_PLANILLA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CDG_MON = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMP_REMUNERATIVO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMP_NOREMUNERATIVO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMP_INGRESO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMP_DESCUENTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMP_APORTACION = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMP_NETO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    FECHA_PROCESO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_PAGO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_CESE = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_INICIO_VACA = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_FIN_VACA = table.Column<DateTime>(type: "datetime", nullable: true),
                    REGIMEN_PENSIONARIO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CUSPP = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ESTABLE_CONTRATADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SWT_PAGO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ANO_REF1 = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    CDG_PROY = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_VOUC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_ORIG = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_INICIO_S = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_FIN_S = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RRHH_PRESTAMO",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CDG_PARA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    FECHA_OPERACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    INTERES = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    COMENTARIO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RRHH_RECORD_VACACIONAL",
                columns: table => new
                {
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    ANO = table.Column<int>(type: "int", nullable: false),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RRHH_RECORD_VACACIONAL", x => new { x.ID_PERSONA, x.ANO });
                });

            migrationBuilder.CreateTable(
                name: "RRHH_REFERENCIA_CUENTA",
                columns: table => new
                {
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    BANCO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    NUM_CTA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    TIPO_CTA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(2,0)", nullable: false),
                    ACTIVO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RRHH_REFERENCIA_TRABAJADOR",
                columns: table => new
                {
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    TIPO_CATEGORIA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    AFILIACION_ESSALUD_VIDA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    CONDICION_DOMICILIO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    INTERMITENTE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    CATEGORIA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    CARGO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    AREA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    DEPARTAMENTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    REMUNERACION_BASICA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    MONEDA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    CONTROLA_ASISTENCIA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    NO_DSCTA_TARDANZA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    HORARIO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    TIPO_TRABAJADOR = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    CATEGORIA_OCUPACIONAL = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    NIVEL_EDUCATIVO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    OCUPACION = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    REGIMEN_PENSIONARIO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    FECHA_INSCRIPCION = table.Column<DateTime>(type: "datetime", nullable: true),
                    CUSPP = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DISCAPACIDAD = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    TIPO_COMISION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ATENCION_SALUD = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SISTEMA_PENSION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    UNIVERSIDAD = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    TIPO_CONTRATO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ESTABLE_CONTRATADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    REGIMEN_ALTERNATIVO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    JORNADA_TRABAJO_MAXIMO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    TRABAJO_HORARIO_NOCTURNO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SINDICALIZADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    TIPO_PAGO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    AFILIADO_EPS_SERVICIO_PROPIO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    EPS = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    SITUACION_TRABAJADOR = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PERIOCIDAD_INGRESO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    SITUACION_ESPECIAL = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PESO = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    ESTATURA = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    TIPO_SANGRE = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COMPLEXION = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ENFERMEDAD_DISCAPACIDAD = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    APTITUD_HABILIDAD = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    NOTAS = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    CATEGORIA_TRABAJADOR = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    SIN_APORTE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    JUBILACION_ANTICIPADA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RRHH_REFERENCIA_TRABAJADOR", x => x.ID_PERSONA);
                });

            migrationBuilder.CreateTable(
                name: "RRHH_SEMANA",
                columns: table => new
                {
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    MES = table.Column<decimal>(type: "numeric(2,0)", nullable: false),
                    SEMANA = table.Column<decimal>(type: "numeric(2,0)", nullable: false),
                    CDG_PROY = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_PAGO = table.Column<DateTime>(type: "datetime", nullable: false),
                    NUMERO_HORA = table.Column<decimal>(type: "numeric(5,2)", nullable: false),
                    NUMERO_FERIADO = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    DIAS_FERIADO = table.Column<decimal>(type: "numeric(6,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RRHH_SEMANA_1", x => new { x.ANO, x.MES, x.SEMANA, x.CDG_PROY });
                });

            migrationBuilder.CreateTable(
                name: "RRHH_UTIL",
                columns: table => new
                {
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ANO = table.Column<long>(type: "bigint", nullable: false),
                    MES = table.Column<decimal>(type: "numeric(2,0)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RRHH_VIGENCIA_REINTEGRO",
                columns: table => new
                {
                    CDG_PARA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    TIPO_OBRERO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    MES = table.Column<int>(type: "int", nullable: false),
                    VALOR = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    UNIDAD = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    ANOI = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    MESI = table.Column<int>(type: "int", nullable: false),
                    ANOF = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    MESF = table.Column<int>(type: "int", nullable: false),
                    CDG_PARA_APLICA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RRHH_VIGENCIA_REINTEGRO", x => new { x.CDG_PARA, x.TIPO_OBRERO, x.ANO, x.MES });
                });

            migrationBuilder.CreateTable(
                name: "SERV_ACTIVIDAD_PROYECTO",
                columns: table => new
                {
                    ID_PROYECTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    ID_ACTIVIDAD = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    NOMBRE_ACTIVIDAD = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    VV_UNIT = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    VALOR_VENTA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    HORA_ESTIMADA = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    MONEDA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    TC = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERV_ACTIVIDAD_PROYECTO", x => new { x.ID_PROYECTO, x.SECUENCIA, x.ID_ACTIVIDAD });
                });

            migrationBuilder.CreateTable(
                name: "SERV_ACTIVIDAD_TECNICO",
                columns: table => new
                {
                    ID_PROYECTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    ID_TECNICO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERV_ACTIVIDAD_TECNICO", x => new { x.ID_PROYECTO, x.SECUENCIA, x.ID_TECNICO });
                });

            migrationBuilder.CreateTable(
                name: "SERV_CONTRATO",
                columns: table => new
                {
                    ID_CONTRATO = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ID_CLIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_REQUERIMIENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_PRESUPUESTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    CATEGORIA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SERVICIO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CDG_ING = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_PARENT = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    COSTO = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    VALOR_VENTA = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    TIPO_CAMBIO = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: false),
                    OBSERVACION2 = table.Column<string>(type: "varchar(3000)", unicode: false, maxLength: 3000, nullable: false),
                    SWT_MAIN = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    CANTIDAD = table.Column<int>(type: "int", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    GASTO_ADMINISTRATIVO = table.Column<decimal>(type: "numeric(6,3)", nullable: true),
                    GASTO_GENERAL = table.Column<decimal>(type: "numeric(6,3)", nullable: true),
                    MARGEN = table.Column<decimal>(type: "numeric(6,3)", nullable: true),
                    IMPORTE_ADMINISTRATIVO = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    IMPORTE_GENERAL = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    IMPORTE_MARGEN = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    SUCURSAL = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    SUB_TIPO_SERVICIO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FECHA_INICIO = table.Column<DateTime>(type: "date", nullable: true),
                    FECHA_TERMINO = table.Column<DateTime>(type: "date", nullable: true),
                    CANTIDAD_SERVICIO = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    FRECUENCIA_SERVICIO = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    TIEMPO_ONSIDE = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    CANT_MESES_FACT = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    RENOVACION = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    ID_FACTURAR = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERV_CONTRATO", x => x.ID_CONTRATO);
                });

            migrationBuilder.CreateTable(
                name: "SERV_CONTROL_CALIDAD_PROYECTO",
                columns: table => new
                {
                    ID_PROYECTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DESCRIPCION = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: true),
                    SWT_CHECK = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SECUENCIA = table.Column<decimal>(type: "numeric(6,0)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SERV_DETALLE_CONTRATO",
                columns: table => new
                {
                    ID_CONTRATO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CDG_SERV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    COSTO = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    MARGEN = table.Column<decimal>(type: "numeric(10,5)", nullable: false),
                    DSCTO = table.Column<decimal>(type: "numeric(10,5)", nullable: false),
                    VALOR_UNIT = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: false),
                    OBSERVACION2 = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: false),
                    TIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    VALOR_ORI = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    IMPORTE2 = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    UNIDAD = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ID_PROVEEDOR = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SERV_DETALLE_PLANTILLA_CC",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERV_DETALLE_PLANTILLA_CC", x => new { x.CODIGO, x.SECUENCIA });
                });

            migrationBuilder.CreateTable(
                name: "SERV_DETALLE_SERVICIO_TECNICO",
                columns: table => new
                {
                    NUMERO_FRE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    SERIE_GENERADA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FALLA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    MOTIVO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    ID_TIPO_PRUEBA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ID_REVISION_INTERNA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    ID_DIAGNOSTICO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    ID_DESCRIPCION = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    ID_RECOMENDACION = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    TIPO = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SERV_EQUIPO_MATERIAL_PROYECTO",
                columns: table => new
                {
                    ID_PROYECTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_REQUERIMIENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    UNIDAD = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CANTIDAD = table.Column<decimal>(type: "numeric(7,2)", nullable: false),
                    PRECIO_VENTA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SERV_ITEMS_PROYECTO",
                columns: table => new
                {
                    ID_PROYECTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERV_ITEMS_PROYECTO", x => new { x.ID_PROYECTO, x.ID_PRODUCTO, x.SECUENCIA });
                });

            migrationBuilder.CreateTable(
                name: "SERV_PLAN_FACTURACION_CONTRATO",
                columns: table => new
                {
                    CDG_SERVICIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    DESCRIPCION_FACTURA = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false),
                    FECHA_FACTURACION = table.Column<DateTime>(type: "date", nullable: false),
                    CDG_RESPONSABLE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    TIPO_CUOTA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('F')"),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SERV_PLAN_FACTURACION_PROYECTO",
                columns: table => new
                {
                    ID_PROYECTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    DESCRIPCION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    POR_FACT = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    VALOR_VENTA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SERV_PLANTILLA_CC",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERV_PLANTILLA_CC", x => x.CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "SERV_PROYECTO",
                columns: table => new
                {
                    ID_PROYECTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_CLIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true),
                    DIRECCION_SERVICIO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    FECHA_INICIO_ESTIMADA = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_FIN_ESTIMADA = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_INICIO_REAL = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_FIN_REAL = table.Column<DateTime>(type: "datetime", nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    RESPONSABLE1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    RESPONSABLE2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    MONEDA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    COSTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    MARGEN = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    VALOR_VENTA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    REFERENCIA1 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    REFERENCIA2 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ID_PRESUPUESTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    DEPARTAMENTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    PROVINCIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DISTRITO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    LATITUD = table.Column<decimal>(type: "numeric(20,14)", nullable: true),
                    LONGITUD = table.Column<decimal>(type: "numeric(20,14)", nullable: true),
                    PRIORIDAD = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TIPO_OT = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_AMPLIACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_FIN_REAL_AMPLIACION1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    MOTIVO_AMPLIACION1 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    FECHA_FIN_REAL_AMPLIACION2 = table.Column<DateTime>(type: "datetime", nullable: true),
                    MOTIVO_AMPLIACION2 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_APROBACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_APROBACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_APROBACION_A1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_APROBACION_A1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_APROBACION_A2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_APROBACION_A2 = table.Column<DateTime>(type: "datetime", nullable: true),
                    ESTADO_AMPLIACION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ESTADO_PROYECTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    NUMCOR = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERV_PROYECTO", x => x.ID_PROYECTO);
                });

            migrationBuilder.CreateTable(
                name: "SERV_SERVICIO_TECNICO",
                columns: table => new
                {
                    NUMERO_FRE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SERIE_GENERADA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    TIPO = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    SERIE_EQUIPO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    INICIO = table.Column<DateTime>(type: "datetime", nullable: true),
                    TERMINO = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_TECNICO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    TIPO_SERVICIO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    CONDICION_EQUIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    DIAGNOSTICO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ACCION_SEGUIR = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ID_RESULTADO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    usuario_modificacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERV_SERVICIO_TECNICO_1", x => new { x.NUMERO_FRE, x.ID_PERSONA, x.SERIE_GENERADA, x.TIPO });
                });

            migrationBuilder.CreateTable(
                name: "SERV_SERVICIO_TECNICO_IMAGEN",
                columns: table => new
                {
                    NUMERO_FRE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    SERIE_GENERADA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NOMBRE_IMAGEN = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    TITULO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IMG_IMAGEN = table.Column<byte[]>(type: "image", nullable: true),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERV_SERVICIO_TECNICO_IMAGEN", x => new { x.NUMERO_FRE, x.SERIE_GENERADA, x.NOMBRE_IMAGEN });
                });

            migrationBuilder.CreateTable(
                name: "SERV_TAREA_PROYECTO",
                columns: table => new
                {
                    ID_PROYECTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(6,0)", nullable: false),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    DESCRIPCION_TAREA = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    COMENTARIO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    ESTADO_APROBACION = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_APROBACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_APROBACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SERV_TAREO",
                columns: table => new
                {
                    ANO = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    MES = table.Column<decimal>(type: "numeric(2,0)", nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_PERSONA = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CDG_CC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    SCDG_CC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CDG_TURNO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    TIPO_DIA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SERV_TRANSPORTE_PROYECTO",
                columns: table => new
                {
                    ID_PROYECTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(3,0)", nullable: false),
                    CHOFER = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    LICENCIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    VEHICULO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    PLACA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CERTIFICADO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    KILOMETRAJE = table.Column<decimal>(type: "numeric(6,2)", nullable: false),
                    DEPARTAMENTO_DE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    PROVINCIA_DE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DISTRITO_DE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DEPARTAMENTO_HASTA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    PROVINCIA_HASTA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DISTRITO_HASTA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERV_TRANSPORTE_PROYECTO", x => new { x.ID_PROYECTO, x.SECUENCIA });
                });

            migrationBuilder.CreateTable(
                name: "SI_FILTRO_INDICADOR",
                columns: table => new
                {
                    CDG_INDICADOR = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CODIGO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NUMERO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    VALOR = table.Column<decimal>(type: "decimal(14,4)", nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "smalldatetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SI_INDICADOR",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    CATEGORIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    TIPO_INDICADOR = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    DEFINICION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    OBJETIVO = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: false),
                    PROCEDIMIENTO_CALCULO = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    FORMULA = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    VISTA = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    ORIGEN_DB = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    META = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    PRECAUCION_DE = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    PRECAUCION_HASTA = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    CRITICO = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    UNIDAD = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FRECUENCIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    RESPONSABLE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ABREVIATURA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SPT_APP",
                columns: table => new
                {
                    APP_VERSION = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    APP_VERSION2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "t_ple_compras",
                columns: table => new
                {
                    PMONEDA = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    X_01 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    X_02 = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    X_03 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    X_04 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    X_05 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    X_06 = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    X_07 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_08 = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    X_09 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_10 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_11 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    X_12 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    X_13 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    X_14 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_15 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_16 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_17 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_18 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_19 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_20 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_21 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_22 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_23 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_24 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_25 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    X_26 = table.Column<decimal>(type: "numeric(4,3)", nullable: true),
                    X_27 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    X_28 = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    X_29 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_30 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    X_31 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_32 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    X_33 = table.Column<string>(type: "varchar(24)", unicode: false, maxLength: 24, nullable: true),
                    X_34 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    X_35 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    X_36 = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    X_37 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    X_38 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    X_39 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    X_40 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    X_41 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    X_42 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "t_ple_compras_ND",
                columns: table => new
                {
                    PMONEDA = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    X_01 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    X_02 = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    X_03 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    X_04 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    X_05 = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    X_06 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_07 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_08 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_09 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_10 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_11 = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    X_12 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_13 = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    X_14 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_15 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_16 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    X_17 = table.Column<decimal>(type: "numeric(4,3)", nullable: true),
                    X_18 = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    X_19 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    X_20 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    X_21 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    X_22 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    X_23 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    X_24 = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    X_25 = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    X_26 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_27 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_28 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_29 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_30 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_31 = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    X_32 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    X_33 = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    X_34 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    X_35 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    X_36 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "t_ple_comprasV1",
                columns: table => new
                {
                    PMONEDA = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    X_01 = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    X_02 = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    X_03 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    X_04 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    X_05 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    X_06 = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    X_07 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_08 = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    X_09 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_10 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_11 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    X_12 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    X_13 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    X_14 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_15 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_16 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_17 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_18 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_19 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_20 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_21 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_22 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_23 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_24 = table.Column<decimal>(type: "numeric(4,3)", nullable: true),
                    X_25 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    X_26 = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    X_27 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_28 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    X_29 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_30 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_31 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    X_32 = table.Column<string>(type: "varchar(24)", unicode: false, maxLength: 24, nullable: true),
                    X_33 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    X_34 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tb_acceso_empresa",
                columns: table => new
                {
                    codi_grup_usua = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    codi_empr = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    usua_crea = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fech_crea = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tb_acceso_opcion",
                columns: table => new
                {
                    codi_grup_usua = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    codi_empr = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    codi_opcion = table.Column<int>(type: "int", nullable: false),
                    flag_nuevo = table.Column<bool>(type: "bit", nullable: false),
                    flag_modi = table.Column<bool>(type: "bit", nullable: false),
                    flag_anul = table.Column<bool>(type: "bit", nullable: false),
                    flag_elim = table.Column<bool>(type: "bit", nullable: false),
                    flag_print = table.Column<bool>(type: "bit", nullable: false),
                    flag_busc = table.Column<bool>(type: "bit", nullable: false),
                    usua_crea = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fech_crea = table.Column<DateTime>(type: "datetime", nullable: false),
                    usua_modi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fech_modi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tb_campo_documento",
                columns: table => new
                {
                    codi_empr = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    tipo_docu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    codi_campo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    secuencia = table.Column<int>(type: "int", nullable: false),
                    nomb_campo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    flag_cab_det = table.Column<bool>(type: "bit", nullable: false),
                    flag_alfa_nume = table.Column<bool>(type: "bit", nullable: false),
                    flag_obli = table.Column<bool>(type: "bit", nullable: false),
                    cant_deci = table.Column<int>(type: "int", nullable: true),
                    desc_campo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    long_campo = table.Column<int>(type: "int", nullable: false),
                    usua_crea = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fech_crea = table.Column<DateTime>(type: "datetime", nullable: false),
                    usua_modi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fech_modi = table.Column<DateTime>(type: "datetime", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tb_catalogo",
                columns: table => new
                {
                    codi_cata = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    campo_ubl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    desc_cata = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    orig_cata = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    usua_crea = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fech_crea = table.Column<DateTime>(type: "datetime", nullable: false),
                    usua_modi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fech_modi = table.Column<DateTime>(type: "datetime", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tb_catalogo_detalle",
                columns: table => new
                {
                    codi_cata = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    codi_cata_deta = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    desc_cata_deta = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    codi_equi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tb_config_adic",
                columns: table => new
                {
                    codi_empr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tipo_docu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    id_criterio = table.Column<int>(type: "int", nullable: false),
                    valor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tb_config_documento",
                columns: table => new
                {
                    codi_empr = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    tipo_docu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nomb_docu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nomb_vista = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cadena = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    usua_crea = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fech_crea = table.Column<DateTime>(type: "datetime", nullable: false),
                    usua_modi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fech_modi = table.Column<DateTime>(type: "datetime", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tb_csrv",
                columns: table => new
                {
                    codi_empr = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    tipo_docu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nume_docu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tipo_docu_clie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nume_docu_clie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tb_documento",
                columns: table => new
                {
                    codi_empr = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    tipo_docu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    codi_campo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    nume_docu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    secuencia = table.Column<int>(type: "int", nullable: false),
                    secu_docu = table.Column<int>(type: "int", nullable: false),
                    fech_docu = table.Column<DateTime>(type: "datetime", nullable: false),
                    valor_n = table.Column<decimal>(type: "numeric(18,8)", nullable: false),
                    valor_a = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    usua_crea = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fech_crea = table.Column<DateTime>(type: "datetime", nullable: false),
                    usua_modi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fech_modi = table.Column<DateTime>(type: "datetime", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tb_documento_BKP",
                columns: table => new
                {
                    codi_empr = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    tipo_docu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    codi_campo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    nume_docu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    secuencia = table.Column<int>(type: "int", nullable: false),
                    secu_docu = table.Column<int>(type: "int", nullable: false),
                    fech_docu = table.Column<DateTime>(type: "datetime", nullable: false),
                    valor_n = table.Column<decimal>(type: "numeric(18,8)", nullable: false),
                    valor_a = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    usua_crea = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fech_crea = table.Column<DateTime>(type: "datetime", nullable: false),
                    usua_modi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fech_modi = table.Column<DateTime>(type: "datetime", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tb_documento_sunat",
                columns: table => new
                {
                    codi_empr = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    tipo_docu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nume_docu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tipo_docu_clie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    nume_docu_clie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    nomb_clie = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    fech_docu = table.Column<DateTime>(type: "datetime", nullable: true),
                    moneda = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    valo_vent = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    valo_igv = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    valo_tota = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    xml_file = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    zip_file = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    pdf_file = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    zip_rpta = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    codi_barra = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    nume_ticket = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    mensaje = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    flag_error = table.Column<bool>(type: "bit", nullable: false),
                    flag_envio = table.Column<bool>(type: "bit", nullable: false),
                    usua_crea = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fech_crea = table.Column<DateTime>(type: "datetime", nullable: false),
                    usua_modi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fech_modi = table.Column<DateTime>(type: "datetime", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tb_documento_sunat_bkerror",
                columns: table => new
                {
                    codi_empr = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    tipo_docu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nume_docu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tipo_docu_clie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    nume_docu_clie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    nomb_clie = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    fech_docu = table.Column<DateTime>(type: "datetime", nullable: true),
                    moneda = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    valo_vent = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    valo_igv = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    valo_tota = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    xml_file = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    zip_file = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    pdf_file = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    zip_rpta = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    codi_barra = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    nume_ticket = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    mensaje = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    flag_error = table.Column<bool>(type: "bit", nullable: false),
                    flag_envio = table.Column<bool>(type: "bit", nullable: false),
                    usua_crea = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fech_crea = table.Column<DateTime>(type: "datetime", nullable: false),
                    usua_modi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fech_modi = table.Column<DateTime>(type: "datetime", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tb_empresa",
                columns: table => new
                {
                    codi_empr = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ruc_empr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    razo_soci = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    nomb_come = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ubigeo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    dire_empr = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    urba_empr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    prov_empr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    dpto_empr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    dist_empr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fono1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fono2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fax_empr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    correo_empr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    repr_lega = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    dni_repr_lega = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    logo_empr = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    nomb_logo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    usuario_sol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    clave_sol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    firma_digi = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    nomb_firm = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    clave_firma = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    serv_smtp = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ancho = table.Column<int>(type: "int", nullable: true),
                    alto = table.Column<int>(type: "int", nullable: true),
                    resolucion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ruta_archivo = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    web_empr = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    usua_crea = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fech_crea = table.Column<DateTime>(type: "datetime", nullable: true),
                    usua_modi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fech_modi = table.Column<DateTime>(type: "datetime", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    puerto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    correofe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    pass_corr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    cc_correo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ssl = table.Column<decimal>(type: "numeric(1,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tb_grupo_usuario",
                columns: table => new
                {
                    codi_grup_usua = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nomb_grup_usua = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    usua_crea = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fech_crea = table.Column<DateTime>(type: "datetime", nullable: false),
                    usua_modi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fech_modi = table.Column<DateTime>(type: "datetime", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tb_opcion",
                columns: table => new
                {
                    codi_opcion = table.Column<int>(type: "int", nullable: false),
                    nomb_opcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    flag_acti = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tb_pass_cliente",
                columns: table => new
                {
                    codi_empr = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    tipo_docu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nume_docu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    pass_clie = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tb_usuario",
                columns: table => new
                {
                    codi_grup_usua = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    login_usua = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nomb_usua = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    pass_usua = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    correo_usua = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    flag_pass = table.Column<bool>(type: "bit", nullable: false),
                    usua_crea = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fech_crea = table.Column<DateTime>(type: "datetime", nullable: false),
                    usua_modi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fech_modi = table.Column<DateTime>(type: "datetime", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tb_wsrv",
                columns: table => new
                {
                    codi_empr = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    tipo_docu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nume_docu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tipo_docu_clie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nume_docu_clie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    usuario_creacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TEMP_LIBMAYOR",
                columns: table => new
                {
                    CUENTA = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false),
                    NOM_CTA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    FECHA_OPER = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUM_COMP = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    GLOSA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    TD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUMERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ANEXO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    DEBE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    HABER = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(6,0)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TEMP_NUMERO",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    NUMERO_DOCUMENTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "temp_PLE_VENTAS",
                columns: table => new
                {
                    PESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    PMONEDA = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    X_01 = table.Column<decimal>(type: "numeric(8,0)", nullable: true),
                    X_02 = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    X_03 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    X_04 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    X_05 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    X_06 = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    X_07 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_08 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_09 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_10 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    X_11 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    X_12 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    X_13 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_14 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_15 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_16 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_17 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_18 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_19 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_20 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_21 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_22 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_23 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_24 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_25 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_26 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    X_27 = table.Column<decimal>(type: "numeric(4,3)", nullable: true),
                    X_28 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    X_29 = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    X_30 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_31 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_32 = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    X_33 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    X_34 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    X_35 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "temp_PLE_VENTASV1",
                columns: table => new
                {
                    PESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    PMONEDA = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    X_01 = table.Column<decimal>(type: "numeric(8,0)", nullable: true),
                    X_02 = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    X_03 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    X_04 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    X_05 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    X_06 = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    X_07 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_08 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_09 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_10 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    X_11 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    X_12 = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    X_13 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_14 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_15 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_16 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_17 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_18 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_19 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_20 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_21 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_22 = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    X_23 = table.Column<decimal>(type: "numeric(4,3)", nullable: true),
                    X_24 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    X_25 = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    X_26 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_27 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    X_28 = table.Column<decimal>(type: "numeric(20,2)", nullable: true),
                    X_29 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    X_30 = table.Column<decimal>(type: "numeric(14,2)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UTIL_FILTRO",
                columns: table => new
                {
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CONSULTA = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    FILTRO = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UTIL_MP",
                columns: table => new
                {
                    CDG_TABLA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUMERO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_MOVI = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    TIPO_IS = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ESTADO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    MOTIVO_MP = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PROB_CIERRE = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    TIPO_UTIL = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_CAJA",
                columns: table => new
                {
                    CDG_AREA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_CAJA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUM_COR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CDG_MCJA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FEC_DCJA = table.Column<DateTime>(type: "datetime", nullable: false),
                    DOC_DCJA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CNC_DCJA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IMP_DCJA = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    NUM_ORIG = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_VOUC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_PROVEEDOR = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    RUC_PRV = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_TDOC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NUM_DOCU = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    MON_DOCU = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FEC_DOCU = table.Column<DateTime>(type: "datetime", nullable: true),
                    IMP_PAG = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    TIP_CMB = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    SWT_ACT = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    CDG_CCT = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_TANA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_ANAL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    REFERENCIA1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    FECHA_LIQUIDA = table.Column<DateTime>(type: "datetime", nullable: true),
                    MON_CAJA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_CC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CDG_PEDIDO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_SUCURSAL = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true, defaultValueSql: "('0008')"),
                    NUM_REQUI = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SCDG_CC = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ID_SD = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_CAJA", x => new { x.CDG_AREA, x.NUM_CAJA, x.NUM_COR });
                    table.ForeignKey(
                        name: "FK_OPE_DETALLE_CAJA_OPE_CAJA",
                        columns: x => new { x.CDG_AREA, x.NUM_CAJA },
                        principalTable: "OPE_CAJA",
                        principalColumns: new[] { "CDG_AREA", "NUM_CAJA" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OPE_LISTA_PRECIO2",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_TIPO_CLIENTE = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    MONEDA = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    COSTO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PRECIO_VENTA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    MARGEN = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PRECIO_VENTA2 = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    PRECIO_VENTA3 = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    PRECIO_VENTA4 = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    MARGEN2 = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    MARGEN3 = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    MARGEN4 = table.Column<decimal>(type: "numeric(14,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_LISTA_PRECIO", x => new { x.CODIGO, x.CODIGO_EMPRESA, x.CODIGO_SUCURSAL, x.ID_PRODUCTO, x.ID_TIPO_CLIENTE, x.MONEDA });
                    table.ForeignKey(
                        name: "FK_OPE_LISTA_PRECIO_OPE_CLISTA_PRECIO",
                        column: x => x.CODIGO,
                        principalTable: "OPE_CLISTA_PRECIO",
                        principalColumn: "CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OPE_ANEXO_COTIZACION",
                columns: table => new
                {
                    ID_COTIZACION = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    NOMBRE_ARCHIVO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ARCHIVO = table.Column<byte[]>(type: "image", nullable: false),
                    EXTENSION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_ANEXO_COTIZACION", x => new { x.ID_COTIZACION, x.SECUENCIA });
                    table.ForeignKey(
                        name: "FK_OPE_ANEXO_COTIZACION_OPE_COTIZACION_VENTA",
                        column: x => x.ID_COTIZACION,
                        principalTable: "OPE_COTIZACION_VENTA",
                        principalColumn: "ID_COTIZACION",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLECC",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PRECIO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    AFECTO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    AFINA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SWT_COM = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SEC_P = table.Column<int>(type: "int", nullable: true),
                    CODIGO_P = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_CECO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CDG_SCECO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ID_REQ = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLECC", x => new { x.CODIGO, x.ID_PRODUCTO, x.SECUENCIA });
                    table.ForeignKey(
                        name: "FK_OPE_DETALLECC_OPE_COTIZACIONC",
                        column: x => x.CODIGO,
                        principalTable: "OPE_COTIZACIONC",
                        principalColumn: "CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OPE_ASIGNACION_ACTIVO_FIJO",
                columns: table => new
                {
                    ID_ASIGNACION = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    daf_id = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false),
                    FECHA_VENCIMIENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    usuario_modificacion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_INICIO = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_ASIGNACION_ACTIVO_FIJO", x => x.ID_ASIGNACION);
                    table.ForeignKey(
                        name: "FK_OPE_ASIGNACION_ACTIVO_FIJO_OPE_DETALLE_ACTIVO_FIJO",
                        column: x => x.daf_id,
                        principalTable: "OPE_DETALLE_ACTIVO_FIJO",
                        principalColumn: "daf_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_DOCUMENTO_VENTA",
                columns: table => new
                {
                    ID_DETALLLE = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false),
                    TIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "(1)"),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PRECIO_UNITARIO = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    MONTO_EMPRESA = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    MONTO_TRABAJADOR = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    SUB_TOTAL = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    NUMERO_COMANDA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    COMENTARIO = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    INICIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FIN = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    COSTO = table.Column<decimal>(type: "numeric(18,8)", nullable: true, defaultValueSql: "(0)"),
                    DSCTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPORTE_DSCTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    PRECIO_ORIGINAL = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IGV = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CDG_PROD = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    COMISION = table.Column<decimal>(type: "numeric(7,2)", nullable: true),
                    MARGEN = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IMPORTE_MARGEN = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    ID_DOCU = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    TIPO_LISTA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ID_PRODUCTO_PARENT = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    UNIDAD = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    POR_PERCEPCION = table.Column<decimal>(type: "numeric(7,2)", nullable: true),
                    PERCEPCION = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    OS = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FLAG_ADD = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    VALOR_VEN = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    UNID_VEN = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    FECHA_VEN = table.Column<DateTime>(type: "datetime", nullable: true),
                    CDG_KIT = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SWT_PIGV = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    SWT_PROM = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    SWT_IMP = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    CANT_KIT = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    SWT_DCOM = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SWT_FREE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    NOM_IMP = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SEC_PROD = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    TIPO_AFEC_IGV = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    CDG_TIPO_DETR = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    GRUP_TIPO_AFEC_IGV = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    POR_DETRACCION = table.Column<decimal>(type: "numeric(7,2)", nullable: true),
                    DETRACCION = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    REFERENCIA1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    POR_IGV = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    VV = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    CDG_VEND = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_DOCUMENTO_VENTA", x => new { x.ID_DETALLLE, x.ID_DOCUMENTO, x.ID_PRODUCTO, x.SECUENCIA, x.TIPO });
                    table.ForeignKey(
                        name: "FK_OPE_DETALLE_DOCUMENTO_VENTA_OPE_DOCUMENTO_VENTA",
                        column: x => x.ID_DOCUMENTO,
                        principalTable: "OPE_DOCUMENTO_VENTA",
                        principalColumn: "ID_DOCUMENTO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OPE_SUCURSAL",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    RUC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DIRECCION = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TELEFONO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FAX = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    ES_PRINCIPAL = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    VALORIZA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "(0)"),
                    PEDIDO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "(0)"),
                    REFERENCIA1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    VENTA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    IMPRESORA_MATRICIAL = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    REFERENCIA2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DEPARTAMENTO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    PROVINCIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DISTRITO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    IMPRESORA_CAJA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    SWT_WEB = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ABR = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_SUCURSAL", x => new { x.CODIGO_EMPRESA, x.CODIGO_SUCURSAL });
                    table.ForeignKey(
                        name: "FK_OPE_SUCURSAL_OPE_EMPRESA",
                        column: x => x.CODIGO_EMPRESA,
                        principalTable: "OPE_EMPRESA",
                        principalColumn: "CODIGO_EMPRESA",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_LIBBCO",
                columns: table => new
                {
                    CDG_BCO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUM_CTA = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    NUM_COR = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NUM_ITM = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CDG_TDOC = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUM_DOCU = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CDG_TMOV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IMP_DEBE = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    IMP_HABER = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    CDG_TANA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CDG_ANAL = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    MON_ORI = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CDG_CC = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NUM_ITM2 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_LIBBCO", x => new { x.CDG_BCO, x.NUM_CTA, x.NUM_COR, x.NUM_ITM });
                    table.ForeignKey(
                        name: "FK_OPE_DETALLE_LIBBCO_OPE_LIBBCO",
                        columns: x => new { x.CDG_BCO, x.NUM_CTA, x.NUM_COR },
                        principalTable: "OPE_LIBBCO",
                        principalColumns: new[] { "CDG_BCO", "NUM_CTA", "NUM_COR" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_NUMERO_DOCUMENTO",
                columns: table => new
                {
                    CODIGO_EMPRESA = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    CODIGO_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    TIPO_DOCUMENTO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SERIE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NUMERO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_NUMERO_DOCUMENTO", x => new { x.CODIGO_EMPRESA, x.CODIGO_SUCURSAL, x.TIPO_DOCUMENTO, x.SERIE, x.NUMERO });
                    table.ForeignKey(
                        name: "FK_OPE_DETALLE_NUMERO_DOCUMENTO_OPE_NUMERO_DOCUMENTO",
                        columns: x => new { x.CODIGO_EMPRESA, x.CODIGO_SUCURSAL, x.TIPO_DOCUMENTO, x.SERIE },
                        principalTable: "OPE_NUMERO_DOCUMENTO",
                        principalColumns: new[] { "CODIGO_EMPRESA", "CODIGO_SUCURSAL", "TIPO_DOCUMENTO", "SERIE" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OPE_ANEXO_PEDIDO",
                columns: table => new
                {
                    ID_PEDIDO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SECUENCIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    NOMBRE_ARCHIVO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ARCHIVO = table.Column<byte[]>(type: "image", nullable: false),
                    EXTENSION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_ANEXO_PEDIDO", x => new { x.ID_PEDIDO, x.SECUENCIA });
                    table.ForeignKey(
                        name: "FK_OPE_ANEXO_PEDIDO_OPE_PEDIDO",
                        column: x => x.ID_PEDIDO,
                        principalTable: "OPE_PEDIDO",
                        principalColumn: "ID_PEDIDO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_PRESUPUESTO",
                columns: table => new
                {
                    ID_PRESUPUESTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CDG_SERV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    COSTO = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    MARGEN = table.Column<decimal>(type: "numeric(10,5)", nullable: false),
                    DSCTO = table.Column<decimal>(type: "numeric(10,5)", nullable: false),
                    VALOR_UNIT = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: false),
                    OBSERVACION2 = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    VALOR_ORI = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    IMPORTE2 = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    UNIDAD = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ID_PROVEEDOR = table.Column<int>(type: "int", nullable: true),
                    ID_TITULO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    SEC_OH = table.Column<decimal>(type: "numeric(6,0)", nullable: true),
                    ORDEN_HOJA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_PRODUCTO2 = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    CDG_TEMP = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    NOM_TEMP = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DESC_TEMP = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    UND_TEMP = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    REND_TEMP = table.Column<decimal>(type: "numeric(10,5)", nullable: true),
                    JORN_TEMP = table.Column<decimal>(type: "numeric(10,5)", nullable: true),
                    PCON_TEMP = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    ICON_TEMP = table.Column<decimal>(type: "numeric(10,5)", nullable: true),
                    TOTAL_TEMP = table.Column<decimal>(type: "numeric(10,5)", nullable: true),
                    SEC_PRES = table.Column<int>(type: "int", nullable: true),
                    SEC_ORD = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_PRESUPUESTO", x => new { x.ID_PRESUPUESTO, x.ID_PRODUCTO, x.CDG_SERV, x.TIPO, x.SECUENCIA });
                    table.ForeignKey(
                        name: "FK_OPE_DETALLE_PRESUPUESTO_OPE_PRESUPUESTO",
                        column: x => x.ID_PRESUPUESTO,
                        principalTable: "OPE_PRESUPUESTO",
                        principalColumn: "ID_PRESUPUESTO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_DOCUMENTO_COMPRA",
                columns: table => new
                {
                    ID_DETALLLE = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_DOCUMENTO = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(14,4)", nullable: false),
                    PRECIO_COMPRA = table.Column<decimal>(type: "numeric(14,4)", nullable: true, defaultValueSql: "((0))"),
                    IMPORTE = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    IGV_PORCENTAJE = table.Column<decimal>(type: "numeric(4,2)", nullable: true),
                    IGV = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    DESCUENTO_PORCENTAJE = table.Column<decimal>(type: "numeric(4,2)", nullable: true),
                    DESCUENTO = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    DESCRIPCION_EXTENDIDA = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    ID_SUCURSAL = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false),
                    CANTIDAD_INOUT = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    SALDO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    COSTO = table.Column<decimal>(type: "numeric(18,8)", nullable: true),
                    CODIGO_UNIDAD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    COSTOF = table.Column<decimal>(type: "numeric(18,8)", nullable: true),
                    COSTOL = table.Column<decimal>(type: "numeric(18,8)", nullable: true),
                    CDG_PROD = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    COSTOD = table.Column<decimal>(type: "numeric(18,8)", nullable: true),
                    PRECIO_COMPRAD = table.Column<decimal>(type: "numeric(18,8)", nullable: true),
                    UNIDAD_EQUI = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FACTOR = table.Column<decimal>(type: "numeric(14,6)", nullable: true, defaultValueSql: "((1))"),
                    SEC_REQ = table.Column<int>(type: "int", nullable: true),
                    REQ = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ID_OC = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    COMENTARIO = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    SWT_IMP = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    ID_RECETA = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    SEC_RECETA = table.Column<decimal>(type: "numeric(4,0)", nullable: true),
                    SCDG_CC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_CC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CDG_ZONA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FILA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    COLUMNA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    IdDocumentoNavigationIdDocumento = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    IdProductoNavigationIdProducto = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_DOCUMENTO_COMPRA", x => x.ID_DETALLLE);
                    table.ForeignKey(
                        name: "FK_OPE_DETALLE_DOCUMENTO_COMPRA_OPE_DOCUMENTO_COMPRA_IdDocumentoNavigationIdDocumento",
                        column: x => x.IdDocumentoNavigationIdDocumento,
                        principalTable: "OPE_DOCUMENTO_COMPRA",
                        principalColumn: "ID_DOCUMENTO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OPE_DETALLE_DOCUMENTO_COMPRA_OPE_PRODUCTO_IdProductoNavigationIdProducto",
                        column: x => x.IdProductoNavigationIdProducto,
                        principalTable: "OPE_PRODUCTO",
                        principalColumn: "ID_PRODUCTO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OPE_DETALLE_TABLA",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NUMERO = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    ESTADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    REFERENCIA1 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA2 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    REFERENCIA3 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    FLAG_SYS = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "((0))"),
                    USUARIO_CREACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO_MODIFICACION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    REFERENCIA4 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA5 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA6 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA7 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA8 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA9 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA10 = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    IMAGEN1 = table.Column<byte[]>(type: "image", nullable: true),
                    REFERENCIA11 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA12 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA13 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA14 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA15 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA16 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA17 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA18 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA19 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA20 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA21 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA22 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA23 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA24 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA25 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA26 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA27 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA28 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA29 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA30 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA31 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA32 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA33 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA34 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    REFERENCIA35 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPE_DETALLE_TABLA", x => new { x.CODIGO, x.NUMERO });
                    table.ForeignKey(
                        name: "FK_OPE_DETALLE_TABLA_OPE_TABLA_CODIGO",
                        column: x => x.CODIGO,
                        principalTable: "OPE_TABLA",
                        principalColumn: "CODIGO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PLAN_DETALLE_PRESUPUESTO",
                columns: table => new
                {
                    ID_PRESUPUESTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    ID_PRODUCTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CDG_SERV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    SECUENCIA = table.Column<int>(type: "int", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    COSTO = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    MARGEN = table.Column<decimal>(type: "numeric(10,5)", nullable: false),
                    DSCTO = table.Column<decimal>(type: "numeric(10,5)", nullable: false),
                    VALOR_UNIT = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    OBSERVACION = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: false),
                    OBSERVACION2 = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: false),
                    MONEDA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    VALOR_ORI = table.Column<decimal>(type: "numeric(15,5)", nullable: false),
                    IMPORTE = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    IMPORTE2 = table.Column<decimal>(type: "numeric(15,5)", nullable: true),
                    UNIDAD = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ID_PROVEEDOR = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLAN_DETALLE_PRESUPUESTO", x => new { x.ID_PRESUPUESTO, x.ID_PRODUCTO, x.CDG_SERV, x.TIPO, x.SECUENCIA });
                    table.ForeignKey(
                        name: "FK_PLAN_DETALLE_PRESUPUESTO_OPE_PRESUPUESTO",
                        column: x => x.ID_PRESUPUESTO,
                        principalTable: "PLAN_PRESUPUESTO",
                        principalColumn: "ID_PRESUPUESTO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OPE_ASIGNACION_ACTIVO_FIJO_daf_id",
                table: "OPE_ASIGNACION_ACTIVO_FIJO",
                column: "daf_id");

            migrationBuilder.CreateIndex(
                name: "IX_OPE_DETALLE_DOCUMENTO_COMPRA_IdDocumentoNavigationIdDocumento",
                table: "OPE_DETALLE_DOCUMENTO_COMPRA",
                column: "IdDocumentoNavigationIdDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_OPE_DETALLE_DOCUMENTO_COMPRA_IdProductoNavigationIdProducto",
                table: "OPE_DETALLE_DOCUMENTO_COMPRA",
                column: "IdProductoNavigationIdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_OPE_DETALLE_DOCUMENTO_VENTA_ID_DOCUMENTO",
                table: "OPE_DETALLE_DOCUMENTO_VENTA",
                column: "ID_DOCUMENTO");

            migrationBuilder.CreateIndex(
                name: "IX_OPE_DOCUMENTO_VENTA",
                table: "OPE_DOCUMENTO_VENTA",
                column: "NUMERO_SERIE");

            migrationBuilder.CreateIndex(
                name: "IX_OPE_DOCUMENTO_VENTA_1",
                table: "OPE_DOCUMENTO_VENTA",
                column: "ID_PERSONA");

            migrationBuilder.CreateIndex(
                name: "IX_OPE_DOCUMENTO_VENTA_2",
                table: "OPE_DOCUMENTO_VENTA",
                column: "TIPO_DOCUMENTO");

            migrationBuilder.CreateIndex(
                name: "PK_CODIGO_PEDIDO",
                table: "OPE_PEDIDO",
                column: "NUMERO_PEDIDO")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "FK_CODIGO_BARRA_PRODUCTO",
                table: "OPE_PRODUCTO",
                column: "CODIGO_BARRA");

            migrationBuilder.CreateIndex(
                name: "FK_CODIGO_PRODUCTO",
                table: "OPE_PRODUCTO",
                column: "CODIGO");

            migrationBuilder.CreateIndex(
                name: "FK_NOMBRE_PRODUCTO",
                table: "OPE_PRODUCTO",
                column: "NOMBRE");

            migrationBuilder.CreateIndex(
                name: "IX_OPE_USUARIO",
                table: "OPE_USUARIO",
                column: "CODIGO_EMPRESA");

            migrationBuilder.CreateIndex(
                name: "ClusteredIndex-20191217-184501",
                table: "tb_documento_sunat",
                columns: new[] { "codi_empr", "tipo_docu", "nume_docu" })
                .Annotation("SqlServer:Clustered", true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACA_CRONOGRAMA_PAGO_ALUMNO");

            migrationBuilder.DropTable(
                name: "ACA_MATRICULA");

            migrationBuilder.DropTable(
                name: "ACA_MATRICULA_CURSO");

            migrationBuilder.DropTable(
                name: "ACA_PENSION_ALUMNO");

            migrationBuilder.DropTable(
                name: "AFI_ACTIVO_FIJO");

            migrationBuilder.DropTable(
                name: "AFI_DEPRECIACION");

            migrationBuilder.DropTable(
                name: "BI_DETALLE_TABLA");

            migrationBuilder.DropTable(
                name: "BI_QUERY");

            migrationBuilder.DropTable(
                name: "BI_TABLA");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "CLI_CITA");

            migrationBuilder.DropTable(
                name: "CLI_HISTORIA_PACIENTE");

            migrationBuilder.DropTable(
                name: "COM_COMISION_FACT");

            migrationBuilder.DropTable(
                name: "CONF_ALERTA");

            migrationBuilder.DropTable(
                name: "CONF_ALUS");

            migrationBuilder.DropTable(
                name: "CONF_CONDICION");

            migrationBuilder.DropTable(
                name: "CONF_DETALLE_CONDICION");

            migrationBuilder.DropTable(
                name: "CONF_DISENO_DOCUMENTO");

            migrationBuilder.DropTable(
                name: "CONF_DOCUMENTO");

            migrationBuilder.DropTable(
                name: "CONF_ECE");

            migrationBuilder.DropTable(
                name: "CONF_GEN_COD");

            migrationBuilder.DropTable(
                name: "CONF_PARAMETRO");

            migrationBuilder.DropTable(
                name: "CONF_QUERY");

            migrationBuilder.DropTable(
                name: "CONF_SERVIDOR_BD");

            migrationBuilder.DropTable(
                name: "CONF_SWT_MD");

            migrationBuilder.DropTable(
                name: "CONF_USAL");

            migrationBuilder.DropTable(
                name: "CONF_USUARIO_ALERTA");

            migrationBuilder.DropTable(
                name: "CONF_VIGENCIA");

            migrationBuilder.DropTable(
                name: "CONTA_ANALITICA");

            migrationBuilder.DropTable(
                name: "CONTA_DETALLE_MODELO");

            migrationBuilder.DropTable(
                name: "CONTA_DETALLE_VOUCHE");

            migrationBuilder.DropTable(
                name: "CONTA_DLINEA_ESFI");

            migrationBuilder.DropTable(
                name: "CONTA_LINEA_ESFI");

            migrationBuilder.DropTable(
                name: "CONTA_MODELO");

            migrationBuilder.DropTable(
                name: "CONTA_PLAN_CUENTA");

            migrationBuilder.DropTable(
                name: "CONTA_PROCESO_GESTION");

            migrationBuilder.DropTable(
                name: "CONTA_PROD_CTA");

            migrationBuilder.DropTable(
                name: "CONTA_RUBRO_ESFI");

            migrationBuilder.DropTable(
                name: "CONTA_SALDOS");

            migrationBuilder.DropTable(
                name: "CONTA_SALDOSA");

            migrationBuilder.DropTable(
                name: "CONTA_SALDOSAG");

            migrationBuilder.DropTable(
                name: "CONTA_SALDOSCG");

            migrationBuilder.DropTable(
                name: "CONTA_SALDOSD");

            migrationBuilder.DropTable(
                name: "CONTA_SALDOSDG");

            migrationBuilder.DropTable(
                name: "CONTA_SALDOSG");

            migrationBuilder.DropTable(
                name: "CONTA_TIPO_CAMBIO");

            migrationBuilder.DropTable(
                name: "CONTA_TIPO_OPERACION");

            migrationBuilder.DropTable(
                name: "CONTA_VOUCHE");

            migrationBuilder.DropTable(
                name: "CRM_ANEXO_SEGUIMIENTO");

            migrationBuilder.DropTable(
                name: "CRM_APLAZAR_AVISO");

            migrationBuilder.DropTable(
                name: "CRM_AVISO");

            migrationBuilder.DropTable(
                name: "CRM_CAMPANA");

            migrationBuilder.DropTable(
                name: "CRM_CAMPANA_CLIENTE");

            migrationBuilder.DropTable(
                name: "CRM_LISTA_MARKETING");

            migrationBuilder.DropTable(
                name: "CRM_LISTA_MKT_INTEGRANTE");

            migrationBuilder.DropTable(
                name: "CRM_SEGUIMIENTO");

            migrationBuilder.DropTable(
                name: "FE_DETALLE_RESUMEN_BAJA");

            migrationBuilder.DropTable(
                name: "FE_ERROR");

            migrationBuilder.DropTable(
                name: "FE_RESUMEN_BAJA");

            migrationBuilder.DropTable(
                name: "Hoja1");

            migrationBuilder.DropTable(
                name: "LOG_APLICACION");

            migrationBuilder.DropTable(
                name: "LOG_CAMBIO_CAMPOS");

            migrationBuilder.DropTable(
                name: "loteserie");

            migrationBuilder.DropTable(
                name: "OPE_ALMACENZONA");

            migrationBuilder.DropTable(
                name: "OPE_ANEXO_COTIZACION");

            migrationBuilder.DropTable(
                name: "OPE_ANEXO_COTIZACIONC");

            migrationBuilder.DropTable(
                name: "OPE_ANEXO_DOCUMENTO_COMPRA");

            migrationBuilder.DropTable(
                name: "OPE_ANEXO_PEDIDO");

            migrationBuilder.DropTable(
                name: "OPE_ANTICIPO");

            migrationBuilder.DropTable(
                name: "OPE_ANTICIPOP");

            migrationBuilder.DropTable(
                name: "OPE_APERTURA_CAJA");

            migrationBuilder.DropTable(
                name: "OPE_ARCHIVO_PRESUPUESTO");

            migrationBuilder.DropTable(
                name: "OPE_ARQUEO_CAJA");

            migrationBuilder.DropTable(
                name: "OPE_ASIGNACION_ACTIVO_FIJO");

            migrationBuilder.DropTable(
                name: "OPE_AZFILACOLUMNA");

            migrationBuilder.DropTable(
                name: "OPE_AZFILACOLUMNAPROD");

            migrationBuilder.DropTable(
                name: "OPE_BLOQUEO_DESBLO");

            migrationBuilder.DropTable(
                name: "OPE_CAJA2");

            migrationBuilder.DropTable(
                name: "OPE_CAJAB");

            migrationBuilder.DropTable(
                name: "OPE_CARPETA_IMPORTACION");

            migrationBuilder.DropTable(
                name: "OPE_CHECKINOUT");

            migrationBuilder.DropTable(
                name: "OPE_CIERRE_DIARIO_CAJA");

            migrationBuilder.DropTable(
                name: "OPE_CIERRE_MES");

            migrationBuilder.DropTable(
                name: "OPE_CLIENTE_PRODUCTO");

            migrationBuilder.DropTable(
                name: "OPE_COFPR_PRODUCTO");

            migrationBuilder.DropTable(
                name: "OPE_COMISION_CONTRATO");

            migrationBuilder.DropTable(
                name: "OPE_COMISION_VENTA_PERSONA");

            migrationBuilder.DropTable(
                name: "OPE_COMP_ELEC");

            migrationBuilder.DropTable(
                name: "OPE_COMPROMISO");

            migrationBuilder.DropTable(
                name: "OPE_CONSUMO");

            migrationBuilder.DropTable(
                name: "OPE_CONTRATO");

            migrationBuilder.DropTable(
                name: "OPE_CONTRATO_CUOTA_PARQUEO");

            migrationBuilder.DropTable(
                name: "OPE_CONTRATO_PARQUEO");

            migrationBuilder.DropTable(
                name: "OPE_CONTRATO_PLACA_PARQUEO");

            migrationBuilder.DropTable(
                name: "OPE_CONTROL_GARANTIA");

            migrationBuilder.DropTable(
                name: "OPE_CONTROL_MAQUINA");

            migrationBuilder.DropTable(
                name: "OPE_CONVENIO_LAB");

            migrationBuilder.DropTable(
                name: "OPE_CONVENIO_PRUEBA");

            migrationBuilder.DropTable(
                name: "OPE_CORRELATIVO");

            migrationBuilder.DropTable(
                name: "OPE_COSTEO_IMPORTACION");

            migrationBuilder.DropTable(
                name: "OPE_COSTO_PROM");

            migrationBuilder.DropTable(
                name: "OPE_COSTO_REAL_OF");

            migrationBuilder.DropTable(
                name: "OPE_CREQUERIMIENTO");

            migrationBuilder.DropTable(
                name: "OPE_CREQUERIMIENTO_NUMEROS");

            migrationBuilder.DropTable(
                name: "OPE_CUENTA_CORRIENTE_CLIENTE");

            migrationBuilder.DropTable(
                name: "OPE_CUENTA_CORRIENTE_PROVEEDOR");

            migrationBuilder.DropTable(
                name: "OPE_CUOTA_CONDPAGO");

            migrationBuilder.DropTable(
                name: "OPE_CUOTA_DOCUMENTOVENTA");

            migrationBuilder.DropTable(
                name: "OPE_CUOTA_PEDIDO");

            migrationBuilder.DropTable(
                name: "OPE_CUOTA_VENDEDOR");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_CAJA");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_CHECKINOUT");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_COMPROMISO");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_CONSUMO");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_COTIZACION");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_CPRESUPUESTO");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_DOCUMENTO_COMPRA");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_DOCUMENTO_COMPRA2");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_DOCUMENTO_VENTA");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_ENTRE");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_FRE");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_GUIA2");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_GUIA3");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_GUIA4");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_GUIAUBICACION");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_HABITACION");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_INVENTARIO_FISICO");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_LETRA_CLIENTE");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_LETRA_PROVEEDOR");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_LIBBCO");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_LIQUIDACIONM");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_NUMERO_DOCUMENTO");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_ORDEN_COMPRA");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_ORDEN_FABRICACION");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_ORDEN_SERVICIO");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_ORDEN_TRABAJO");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_PAGO_CLIENTE");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_PAGO_PROVEEDOR");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_PARTIDA_PRESUPUESTO");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_PEDIDO");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_PLAN_FABRICACION");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_PLANTILLA_RECETA");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_PRESUPUESTO");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_PRESUPUESTO2");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_PROGRAMACION_PAGO");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_RECETA");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_REQITEMS");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_REQUISICION");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_RESERVA");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_SOLICITUD_DOCUMENTO");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_SOLICITUD_REQUERIMIENTO");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_SOLICITUD_VJEVTO");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_TABLA");

            migrationBuilder.DropTable(
                name: "OPE_DETALLECC");

            migrationBuilder.DropTable(
                name: "OPE_DIST_GAST_IMPORTACION");

            migrationBuilder.DropTable(
                name: "OPE_DOCNT_DOC");

            migrationBuilder.DropTable(
                name: "OPE_DOCUMENTO_COMPRA2");

            migrationBuilder.DropTable(
                name: "OPE_DOCUMENTO_GUIA");

            migrationBuilder.DropTable(
                name: "OPE_DOCUMENTO_GUIA2");

            migrationBuilder.DropTable(
                name: "OPE_DOCUMENTO_VENTA_CONTRATO");

            migrationBuilder.DropTable(
                name: "OPE_DOCUMENTO_VENTA_PEDIDO");

            migrationBuilder.DropTable(
                name: "OPE_DSCTO_CANTIDAD_PRODUCTO");

            migrationBuilder.DropTable(
                name: "OPE_ENTRE");

            migrationBuilder.DropTable(
                name: "OPE_ENTRE2");

            migrationBuilder.DropTable(
                name: "OPE_EQUIPO_PRESUPUESTO");

            migrationBuilder.DropTable(
                name: "OPE_ESTABLECIMIENTO");

            migrationBuilder.DropTable(
                name: "OPE_ESTADO_EQUIPO_FRE");

            migrationBuilder.DropTable(
                name: "OPE_ESTADO_HABITACION");

            migrationBuilder.DropTable(
                name: "OPE_FC_DIARIO");

            migrationBuilder.DropTable(
                name: "OPE_FORM");

            migrationBuilder.DropTable(
                name: "OPE_FORMATO_LAB");

            migrationBuilder.DropTable(
                name: "OPE_FORMATO_LABVALOR");

            migrationBuilder.DropTable(
                name: "OPE_FRE");

            migrationBuilder.DropTable(
                name: "OPE_GASTO_ADICIONAL");

            migrationBuilder.DropTable(
                name: "OPE_GG_PRESUPUESTO");

            migrationBuilder.DropTable(
                name: "OPE_HABITACION");

            migrationBuilder.DropTable(
                name: "OPE_IMP_PRESUPUESTO");

            migrationBuilder.DropTable(
                name: "OPE_IMP_PROD_WEB");

            migrationBuilder.DropTable(
                name: "OPE_INGRESO_IMPORTACION");

            migrationBuilder.DropTable(
                name: "OPE_INVENTARIO_FISICO");

            migrationBuilder.DropTable(
                name: "OPE_KARDEX");

            migrationBuilder.DropTable(
                name: "OPE_LAB_FRE");

            migrationBuilder.DropTable(
                name: "OPE_LETRA_CLIENTE");

            migrationBuilder.DropTable(
                name: "OPE_LETRA_PROVEEDOR");

            migrationBuilder.DropTable(
                name: "OPE_LIMPIEZA_HABITACION");

            migrationBuilder.DropTable(
                name: "OPE_LIQUIDACIONM");

            migrationBuilder.DropTable(
                name: "OPE_LISTA_PRECIO");

            migrationBuilder.DropTable(
                name: "OPE_LISTA_PRECIO2");

            migrationBuilder.DropTable(
                name: "OPE_LOTE");

            migrationBuilder.DropTable(
                name: "OPE_MAQUINA");

            migrationBuilder.DropTable(
                name: "OPE_MESA");

            migrationBuilder.DropTable(
                name: "OPE_MOVBCO_REQ");

            migrationBuilder.DropTable(
                name: "OPE_MOVIMIENTO_DINERO");

            migrationBuilder.DropTable(
                name: "OPE_MP_DOCVEN");

            migrationBuilder.DropTable(
                name: "OPE_MP_PEDVEN");

            migrationBuilder.DropTable(
                name: "OPE_NI_GASTO_IMPORTACION");

            migrationBuilder.DropTable(
                name: "OPE_NOTA_COBRANZA");

            migrationBuilder.DropTable(
                name: "OPE_NOTA_PROYECTO");

            migrationBuilder.DropTable(
                name: "OPE_NOTAS_REQ");

            migrationBuilder.DropTable(
                name: "OPE_OCDC_PRORRATEO");

            migrationBuilder.DropTable(
                name: "OPE_ODOCUMENTO_COMPRA");

            migrationBuilder.DropTable(
                name: "OPE_OFPR_PRODUCTO");

            migrationBuilder.DropTable(
                name: "OPE_ORDEN_COMPRA");

            migrationBuilder.DropTable(
                name: "OPE_ORDEN_FABRICACION");

            migrationBuilder.DropTable(
                name: "OPE_ORDEN_FABRICACION_SERIELOTE");

            migrationBuilder.DropTable(
                name: "OPE_ORDEN_SERVICIO");

            migrationBuilder.DropTable(
                name: "OPE_ORDEN_TRABAJO");

            migrationBuilder.DropTable(
                name: "OPE_OT_PEDIDO");

            migrationBuilder.DropTable(
                name: "OPE_PAGO_CLIENTE");

            migrationBuilder.DropTable(
                name: "OPE_PAGO_TRABAJADOR");

            migrationBuilder.DropTable(
                name: "OPE_PARAMETRO");

            migrationBuilder.DropTable(
                name: "OPE_PARQUEO_VEHICULO");

            migrationBuilder.DropTable(
                name: "OPE_PEDIDO_GIRO_ICOMPLEMENTARIA");

            migrationBuilder.DropTable(
                name: "OPE_PEDIDO_MESA");

            migrationBuilder.DropTable(
                name: "OPE_PEDIDO_PAGO_IHOY");

            migrationBuilder.DropTable(
                name: "OPE_PEDIDO_PUNTAJE");

            migrationBuilder.DropTable(
                name: "OPE_PERMISO_PERSONA");

            migrationBuilder.DropTable(
                name: "OPE_PERSONA");

            migrationBuilder.DropTable(
                name: "OPE_PLAN_FABRICACION");

            migrationBuilder.DropTable(
                name: "OPE_PLAN_FACT_GASTO");

            migrationBuilder.DropTable(
                name: "OPE_PLAN_FACTURACION_OC");

            migrationBuilder.DropTable(
                name: "OPE_PLANTILLA_RECETA");

            migrationBuilder.DropTable(
                name: "OPE_PRESUPUESTO2");

            migrationBuilder.DropTable(
                name: "OPE_PRODUCTO_IMAGEN");

            migrationBuilder.DropTable(
                name: "OPE_PRODUCTO_SUCURSAL");

            migrationBuilder.DropTable(
                name: "OPE_PROGRAMACION_MN");

            migrationBuilder.DropTable(
                name: "OPE_PROGRAMACION_PAGO");

            migrationBuilder.DropTable(
                name: "OPE_PROMOCION_PRODUCTO");

            migrationBuilder.DropTable(
                name: "OPE_PROSPECTO");

            migrationBuilder.DropTable(
                name: "OPE_PROVEEDOR_PRODUCTO");

            migrationBuilder.DropTable(
                name: "OPE_PUNTOS_VENTA");

            migrationBuilder.DropTable(
                name: "OPE_RECETA");

            migrationBuilder.DropTable(
                name: "OPE_REFERENCIA_ADELANTO");

            migrationBuilder.DropTable(
                name: "OPE_REFERENCIA_BANCARIA");

            migrationBuilder.DropTable(
                name: "OPE_REFERENCIA_PERSONA");

            migrationBuilder.DropTable(
                name: "OPE_REPROGRAMACION_OC");

            migrationBuilder.DropTable(
                name: "OPE_REQITEMS");

            migrationBuilder.DropTable(
                name: "OPE_REQUERIMIENTO");

            migrationBuilder.DropTable(
                name: "OPE_REQUISICION");

            migrationBuilder.DropTable(
                name: "OPE_REQUISICION_ANEXO");

            migrationBuilder.DropTable(
                name: "OPE_RESERVA");

            migrationBuilder.DropTable(
                name: "OPE_RESULTADO_FINAL_LAB");

            migrationBuilder.DropTable(
                name: "OPE_RESULTADO_PRODUCTO");

            migrationBuilder.DropTable(
                name: "OPE_RLK");

            migrationBuilder.DropTable(
                name: "OPE_SEGUIMIENTO_COTI");

            migrationBuilder.DropTable(
                name: "OPE_SEGUIMIENTO_IMPORTACION");

            migrationBuilder.DropTable(
                name: "OPE_SEGUIMIENTO_PEDI");

            migrationBuilder.DropTable(
                name: "OPE_SOLICITUD_ANTICIPO_PROVEEDOR");

            migrationBuilder.DropTable(
                name: "OPE_SOLICITUD_DINERO");

            migrationBuilder.DropTable(
                name: "OPE_SOLICITUD_DOCUMENTO");

            migrationBuilder.DropTable(
                name: "OPE_SOLICITUD_REQUERIMIENTO");

            migrationBuilder.DropTable(
                name: "OPE_SOLICITUD_VJEVTO");

            migrationBuilder.DropTable(
                name: "OPE_STOCK_LOTE");

            migrationBuilder.DropTable(
                name: "OPE_STOCK_PRODUCTO");

            migrationBuilder.DropTable(
                name: "OPE_SUCURSAL");

            migrationBuilder.DropTable(
                name: "OPE_TARIFA");

            migrationBuilder.DropTable(
                name: "OPE_TARIFA_HABITACION");

            migrationBuilder.DropTable(
                name: "OPE_TARIFA_PRECIO");

            migrationBuilder.DropTable(
                name: "OPE_TARIFA_TEMPORADA");

            migrationBuilder.DropTable(
                name: "OPE_TARIFA_TIPO_HABITACION");

            migrationBuilder.DropTable(
                name: "OPE_TARJETA_EQUIPO");

            migrationBuilder.DropTable(
                name: "OPE_TDOC_APERTURA");

            migrationBuilder.DropTable(
                name: "OPE_TDOC_PUNTO_VENTA");

            migrationBuilder.DropTable(
                name: "OPE_TEMP_COMANDA");

            migrationBuilder.DropTable(
                name: "OPE_TEMPORADA");

            migrationBuilder.DropTable(
                name: "OPE_TICKET");

            migrationBuilder.DropTable(
                name: "OPE_TIPO_CAMBIO");

            migrationBuilder.DropTable(
                name: "OPE_TMOV_TDOC");

            migrationBuilder.DropTable(
                name: "OPE_TRANSFERENCIA");

            migrationBuilder.DropTable(
                name: "OPE_USUARIO");

            migrationBuilder.DropTable(
                name: "OPE_USUARIO_FORM");

            migrationBuilder.DropTable(
                name: "OPE_VALORIZACION");

            migrationBuilder.DropTable(
                name: "PLAN_DETALLE_PRESUPUESTO");

            migrationBuilder.DropTable(
                name: "REQ_ALMACEN");

            migrationBuilder.DropTable(
                name: "REQ_OC");

            migrationBuilder.DropTable(
                name: "RQ_DETALLE_CC_PRESUPUESTO");

            migrationBuilder.DropTable(
                name: "RQ_DETALLE_PRESUPUESTO");

            migrationBuilder.DropTable(
                name: "RQ_PRESUPUESTO");

            migrationBuilder.DropTable(
                name: "RRHH_ANEXO_PERSONAL");

            migrationBuilder.DropTable(
                name: "RRHH_ASIGNACION_RECURSO");

            migrationBuilder.DropTable(
                name: "RRHH_CAPACITACION");

            migrationBuilder.DropTable(
                name: "RRHH_CONCEPTO_PERSONA");

            migrationBuilder.DropTable(
                name: "RRHH_CONSOLIDADO_ASISTENCIA");

            migrationBuilder.DropTable(
                name: "RRHH_CONSOLIDADO_ASISTENCIA_TAREO");

            migrationBuilder.DropTable(
                name: "RRHH_CONTRATO");

            migrationBuilder.DropTable(
                name: "RRHH_CONTROL_VACACION");

            migrationBuilder.DropTable(
                name: "RRHH_CTA_5TA_CAT");

            migrationBuilder.DropTable(
                name: "RRHH_CTA_CTE_TRABAJADOR");

            migrationBuilder.DropTable(
                name: "RRHH_DERECHO_HABIENTE");

            migrationBuilder.DropTable(
                name: "RRHH_DETALLE_HORARIO");

            migrationBuilder.DropTable(
                name: "RRHH_DETALLE_INCIDENCIA_MEMO");

            migrationBuilder.DropTable(
                name: "RRHH_DETALLE_PLANILLA");

            migrationBuilder.DropTable(
                name: "RRHH_DETALLE_PRESTAMO");

            migrationBuilder.DropTable(
                name: "RRHH_DISTRIBUCION_CENTROCOSTO");

            migrationBuilder.DropTable(
                name: "RRHH_HORARIO");

            migrationBuilder.DropTable(
                name: "RRHH_INCIDENCIA_MEMO");

            migrationBuilder.DropTable(
                name: "RRHH_MARCACION_ASISTENCIA");

            migrationBuilder.DropTable(
                name: "RRHH_PERMISO_SANCION");

            migrationBuilder.DropTable(
                name: "RRHH_PLANILLA");

            migrationBuilder.DropTable(
                name: "RRHH_PRESTAMO");

            migrationBuilder.DropTable(
                name: "RRHH_RECORD_VACACIONAL");

            migrationBuilder.DropTable(
                name: "RRHH_REFERENCIA_CUENTA");

            migrationBuilder.DropTable(
                name: "RRHH_REFERENCIA_TRABAJADOR");

            migrationBuilder.DropTable(
                name: "RRHH_SEMANA");

            migrationBuilder.DropTable(
                name: "RRHH_UTIL");

            migrationBuilder.DropTable(
                name: "RRHH_VIGENCIA_REINTEGRO");

            migrationBuilder.DropTable(
                name: "SERV_ACTIVIDAD_PROYECTO");

            migrationBuilder.DropTable(
                name: "SERV_ACTIVIDAD_TECNICO");

            migrationBuilder.DropTable(
                name: "SERV_CONTRATO");

            migrationBuilder.DropTable(
                name: "SERV_CONTROL_CALIDAD_PROYECTO");

            migrationBuilder.DropTable(
                name: "SERV_DETALLE_CONTRATO");

            migrationBuilder.DropTable(
                name: "SERV_DETALLE_PLANTILLA_CC");

            migrationBuilder.DropTable(
                name: "SERV_DETALLE_SERVICIO_TECNICO");

            migrationBuilder.DropTable(
                name: "SERV_EQUIPO_MATERIAL_PROYECTO");

            migrationBuilder.DropTable(
                name: "SERV_ITEMS_PROYECTO");

            migrationBuilder.DropTable(
                name: "SERV_PLAN_FACTURACION_CONTRATO");

            migrationBuilder.DropTable(
                name: "SERV_PLAN_FACTURACION_PROYECTO");

            migrationBuilder.DropTable(
                name: "SERV_PLANTILLA_CC");

            migrationBuilder.DropTable(
                name: "SERV_PROYECTO");

            migrationBuilder.DropTable(
                name: "SERV_SERVICIO_TECNICO");

            migrationBuilder.DropTable(
                name: "SERV_SERVICIO_TECNICO_IMAGEN");

            migrationBuilder.DropTable(
                name: "SERV_TAREA_PROYECTO");

            migrationBuilder.DropTable(
                name: "SERV_TAREO");

            migrationBuilder.DropTable(
                name: "SERV_TRANSPORTE_PROYECTO");

            migrationBuilder.DropTable(
                name: "SI_FILTRO_INDICADOR");

            migrationBuilder.DropTable(
                name: "SI_INDICADOR");

            migrationBuilder.DropTable(
                name: "SPT_APP");

            migrationBuilder.DropTable(
                name: "t_ple_compras");

            migrationBuilder.DropTable(
                name: "t_ple_compras_ND");

            migrationBuilder.DropTable(
                name: "t_ple_comprasV1");

            migrationBuilder.DropTable(
                name: "tb_acceso_empresa");

            migrationBuilder.DropTable(
                name: "tb_acceso_opcion");

            migrationBuilder.DropTable(
                name: "tb_campo_documento");

            migrationBuilder.DropTable(
                name: "tb_catalogo");

            migrationBuilder.DropTable(
                name: "tb_catalogo_detalle");

            migrationBuilder.DropTable(
                name: "tb_config_adic");

            migrationBuilder.DropTable(
                name: "tb_config_documento");

            migrationBuilder.DropTable(
                name: "tb_csrv");

            migrationBuilder.DropTable(
                name: "tb_documento");

            migrationBuilder.DropTable(
                name: "tb_documento_BKP");

            migrationBuilder.DropTable(
                name: "tb_documento_sunat");

            migrationBuilder.DropTable(
                name: "tb_documento_sunat_bkerror");

            migrationBuilder.DropTable(
                name: "tb_empresa");

            migrationBuilder.DropTable(
                name: "tb_grupo_usuario");

            migrationBuilder.DropTable(
                name: "tb_opcion");

            migrationBuilder.DropTable(
                name: "tb_pass_cliente");

            migrationBuilder.DropTable(
                name: "tb_usuario");

            migrationBuilder.DropTable(
                name: "tb_wsrv");

            migrationBuilder.DropTable(
                name: "TEMP_LIBMAYOR");

            migrationBuilder.DropTable(
                name: "TEMP_NUMERO");

            migrationBuilder.DropTable(
                name: "temp_PLE_VENTAS");

            migrationBuilder.DropTable(
                name: "temp_PLE_VENTASV1");

            migrationBuilder.DropTable(
                name: "UTIL_FILTRO");

            migrationBuilder.DropTable(
                name: "UTIL_MP");

            migrationBuilder.DropTable(
                name: "OPE_COTIZACION_VENTA");

            migrationBuilder.DropTable(
                name: "OPE_PEDIDO");

            migrationBuilder.DropTable(
                name: "OPE_DETALLE_ACTIVO_FIJO");

            migrationBuilder.DropTable(
                name: "OPE_CAJA");

            migrationBuilder.DropTable(
                name: "OPE_DOCUMENTO_COMPRA");

            migrationBuilder.DropTable(
                name: "OPE_PRODUCTO");

            migrationBuilder.DropTable(
                name: "OPE_DOCUMENTO_VENTA");

            migrationBuilder.DropTable(
                name: "OPE_LIBBCO");

            migrationBuilder.DropTable(
                name: "OPE_NUMERO_DOCUMENTO");

            migrationBuilder.DropTable(
                name: "OPE_PRESUPUESTO");

            migrationBuilder.DropTable(
                name: "OPE_TABLA");

            migrationBuilder.DropTable(
                name: "OPE_COTIZACIONC");

            migrationBuilder.DropTable(
                name: "OPE_CLISTA_PRECIO");

            migrationBuilder.DropTable(
                name: "OPE_EMPRESA");

            migrationBuilder.DropTable(
                name: "PLAN_PRESUPUESTO");
        }
    }
}
