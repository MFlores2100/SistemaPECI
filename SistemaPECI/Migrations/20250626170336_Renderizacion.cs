using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaPECI.Migrations
{
    /// <inheritdoc />
    public partial class Renderizacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Departamento_IDDepartamento",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Persona_IDPersona",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persona",
                table: "Persona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamento",
                table: "Departamento");

            migrationBuilder.RenameTable(
                name: "Persona",
                newName: "Personas");

            migrationBuilder.RenameTable(
                name: "Departamento",
                newName: "Departamentos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "IDPersona");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos",
                column: "IDDepartamento");

            migrationBuilder.CreateTable(
                name: "Cantones",
                columns: table => new
                {
                    IDCanton = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cantones", x => x.IDCanton);
                });

            migrationBuilder.CreateTable(
                name: "ListaPrecios",
                columns: table => new
                {
                    IDListaPrecios = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InflacionCR = table.Column<double>(type: "REAL", nullable: false),
                    InflacionUSA = table.Column<double>(type: "REAL", nullable: false),
                    TipoCambioVentaFinal = table.Column<double>(type: "REAL", nullable: false),
                    VariacionTipoCambioFinal = table.Column<double>(type: "REAL", nullable: false),
                    TipoCambioVentaPromedio = table.Column<double>(type: "REAL", nullable: false),
                    VariacionTipoCambioPromedio = table.Column<double>(type: "REAL", nullable: false),
                    TasaImpuestosSobreMateriales = table.Column<double>(type: "REAL", nullable: false),
                    CostosIndirectos = table.Column<double>(type: "REAL", nullable: false),
                    CostosPromedioOperacion = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaPrecios", x => x.IDListaPrecios);
                });

            migrationBuilder.CreateTable(
                name: "MaterialesEquipos",
                columns: table => new
                {
                    IDMaterialEquipo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialesEquipos", x => x.IDMaterialEquipo);
                });

            migrationBuilder.CreateTable(
                name: "Regiones",
                columns: table => new
                {
                    IDRegion = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regiones", x => x.IDRegion);
                });

            migrationBuilder.CreateTable(
                name: "RegistrosAuditoria",
                columns: table => new
                {
                    IDAuditoria = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FechaHora = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TipoOperacion = table.Column<string>(type: "TEXT", nullable: false),
                    EntidadAfectada = table.Column<string>(type: "TEXT", nullable: false),
                    DatosPrevios = table.Column<string>(type: "TEXT", nullable: false),
                    DatosNuevos = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrosAuditoria", x => x.IDAuditoria);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    IDProvincia = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    IDCanton = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.IDProvincia);
                    table.ForeignKey(
                        name: "FK_Provincias_Cantones_IDCanton",
                        column: x => x.IDCanton,
                        principalTable: "Cantones",
                        principalColumn: "IDCanton",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proyectos",
                columns: table => new
                {
                    IDProyecto = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CodigoPINE = table.Column<string>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    AnioInicio = table.Column<int>(type: "INTEGER", nullable: false),
                    Duracion = table.Column<int>(type: "INTEGER", nullable: false),
                    Material = table.Column<string>(type: "TEXT", nullable: false),
                    ManoObra = table.Column<string>(type: "TEXT", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: false),
                    Responsable = table.Column<string>(type: "TEXT", nullable: false),
                    IDRegion = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyectos", x => x.IDProyecto);
                    table.ForeignKey(
                        name: "FK_Proyectos_Regiones_IDRegion",
                        column: x => x.IDRegion,
                        principalTable: "Regiones",
                        principalColumn: "IDRegion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesAuditorias",
                columns: table => new
                {
                    IDDetalleAuditoria = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IDUsuario = table.Column<int>(type: "INTEGER", nullable: false),
                    IDAuditoria = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesAuditorias", x => x.IDDetalleAuditoria);
                    table.ForeignKey(
                        name: "FK_DetallesAuditorias_RegistrosAuditoria_IDAuditoria",
                        column: x => x.IDAuditoria,
                        principalTable: "RegistrosAuditoria",
                        principalColumn: "IDAuditoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesAuditorias_Usuarios_IDUsuario",
                        column: x => x.IDUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IDUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesRegiones",
                columns: table => new
                {
                    IDDetalleRegion = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    DireccionExacta = table.Column<string>(type: "TEXT", nullable: false),
                    IDRegion = table.Column<int>(type: "INTEGER", nullable: false),
                    IDProvincia = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesRegiones", x => x.IDDetalleRegion);
                    table.ForeignKey(
                        name: "FK_DetallesRegiones_Provincias_IDProvincia",
                        column: x => x.IDProvincia,
                        principalTable: "Provincias",
                        principalColumn: "IDProvincia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesRegiones_Regiones_IDRegion",
                        column: x => x.IDRegion,
                        principalTable: "Regiones",
                        principalColumn: "IDRegion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComposicionInversiones",
                columns: table => new
                {
                    IDComposicionInversion = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Anual = table.Column<double>(type: "REAL", nullable: false),
                    Acumulado = table.Column<double>(type: "REAL", nullable: false),
                    Porcentaje = table.Column<double>(type: "REAL", nullable: false),
                    IDProyecto = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComposicionInversiones", x => x.IDComposicionInversion);
                    table.ForeignKey(
                        name: "FK_ComposicionInversiones_Proyectos_IDProyecto",
                        column: x => x.IDProyecto,
                        principalTable: "Proyectos",
                        principalColumn: "IDProyecto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GestionFinanciamientos",
                columns: table => new
                {
                    IDGestionFinanciamiento = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Opex = table.Column<bool>(type: "INTEGER", nullable: false),
                    Capex = table.Column<bool>(type: "INTEGER", nullable: false),
                    Material = table.Column<double>(type: "REAL", nullable: false),
                    ManoObra = table.Column<double>(type: "REAL", nullable: false),
                    TotalMaterialObra = table.Column<double>(type: "REAL", nullable: false),
                    DesgloseMeses = table.Column<double>(type: "REAL", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    Monto = table.Column<double>(type: "REAL", nullable: false),
                    IDProyecto = table.Column<int>(type: "INTEGER", nullable: false),
                    IDRegion = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GestionFinanciamientos", x => x.IDGestionFinanciamiento);
                    table.ForeignKey(
                        name: "FK_GestionFinanciamientos_Proyectos_IDProyecto",
                        column: x => x.IDProyecto,
                        principalTable: "Proyectos",
                        principalColumn: "IDProyecto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GestionFinanciamientos_Regiones_IDRegion",
                        column: x => x.IDRegion,
                        principalTable: "Regiones",
                        principalColumn: "IDRegion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialesRequeridos",
                columns: table => new
                {
                    IDMaterialRequerido = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoMaterial = table.Column<string>(type: "TEXT", nullable: false),
                    Cantidad = table.Column<string>(type: "TEXT", nullable: false),
                    IDProyecto = table.Column<int>(type: "INTEGER", nullable: false),
                    IDMaterialEquipo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialesRequeridos", x => x.IDMaterialRequerido);
                    table.ForeignKey(
                        name: "FK_MaterialesRequeridos_MaterialesEquipos_IDMaterialEquipo",
                        column: x => x.IDMaterialEquipo,
                        principalTable: "MaterialesEquipos",
                        principalColumn: "IDMaterialEquipo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialesRequeridos_Proyectos_IDProyecto",
                        column: x => x.IDProyecto,
                        principalTable: "Proyectos",
                        principalColumn: "IDProyecto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProyectosRegiones",
                columns: table => new
                {
                    IDProyectoRegion = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IDProyecto = table.Column<int>(type: "INTEGER", nullable: false),
                    IDRegion = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectosRegiones", x => x.IDProyectoRegion);
                    table.ForeignKey(
                        name: "FK_ProyectosRegiones_Proyectos_IDProyecto",
                        column: x => x.IDProyecto,
                        principalTable: "Proyectos",
                        principalColumn: "IDProyecto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProyectosRegiones_Regiones_IDRegion",
                        column: x => x.IDRegion,
                        principalTable: "Regiones",
                        principalColumn: "IDRegion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProyectoUsuarios",
                columns: table => new
                {
                    IDProyectoUsuario = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IDProyecto = table.Column<int>(type: "INTEGER", nullable: false),
                    IDUsuario = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectoUsuarios", x => x.IDProyectoUsuario);
                    table.ForeignKey(
                        name: "FK_ProyectoUsuarios_Proyectos_IDProyecto",
                        column: x => x.IDProyecto,
                        principalTable: "Proyectos",
                        principalColumn: "IDProyecto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProyectoUsuarios_Usuarios_IDUsuario",
                        column: x => x.IDUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IDUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComposicionInversiones_IDProyecto",
                table: "ComposicionInversiones",
                column: "IDProyecto");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesAuditorias_IDAuditoria",
                table: "DetallesAuditorias",
                column: "IDAuditoria");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesAuditorias_IDUsuario",
                table: "DetallesAuditorias",
                column: "IDUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesRegiones_IDProvincia",
                table: "DetallesRegiones",
                column: "IDProvincia");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesRegiones_IDRegion",
                table: "DetallesRegiones",
                column: "IDRegion");

            migrationBuilder.CreateIndex(
                name: "IX_GestionFinanciamientos_IDProyecto",
                table: "GestionFinanciamientos",
                column: "IDProyecto");

            migrationBuilder.CreateIndex(
                name: "IX_GestionFinanciamientos_IDRegion",
                table: "GestionFinanciamientos",
                column: "IDRegion");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialesRequeridos_IDMaterialEquipo",
                table: "MaterialesRequeridos",
                column: "IDMaterialEquipo");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialesRequeridos_IDProyecto",
                table: "MaterialesRequeridos",
                column: "IDProyecto");

            migrationBuilder.CreateIndex(
                name: "IX_Provincias_IDCanton",
                table: "Provincias",
                column: "IDCanton");

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_IDRegion",
                table: "Proyectos",
                column: "IDRegion");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectosRegiones_IDProyecto",
                table: "ProyectosRegiones",
                column: "IDProyecto");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectosRegiones_IDRegion",
                table: "ProyectosRegiones",
                column: "IDRegion");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoUsuarios_IDProyecto",
                table: "ProyectoUsuarios",
                column: "IDProyecto");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoUsuarios_IDUsuario",
                table: "ProyectoUsuarios",
                column: "IDUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Departamentos_IDDepartamento",
                table: "Usuarios",
                column: "IDDepartamento",
                principalTable: "Departamentos",
                principalColumn: "IDDepartamento",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Personas_IDPersona",
                table: "Usuarios",
                column: "IDPersona",
                principalTable: "Personas",
                principalColumn: "IDPersona",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Departamentos_IDDepartamento",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Personas_IDPersona",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "ComposicionInversiones");

            migrationBuilder.DropTable(
                name: "DetallesAuditorias");

            migrationBuilder.DropTable(
                name: "DetallesRegiones");

            migrationBuilder.DropTable(
                name: "GestionFinanciamientos");

            migrationBuilder.DropTable(
                name: "ListaPrecios");

            migrationBuilder.DropTable(
                name: "MaterialesRequeridos");

            migrationBuilder.DropTable(
                name: "ProyectosRegiones");

            migrationBuilder.DropTable(
                name: "ProyectoUsuarios");

            migrationBuilder.DropTable(
                name: "RegistrosAuditoria");

            migrationBuilder.DropTable(
                name: "Provincias");

            migrationBuilder.DropTable(
                name: "MaterialesEquipos");

            migrationBuilder.DropTable(
                name: "Proyectos");

            migrationBuilder.DropTable(
                name: "Cantones");

            migrationBuilder.DropTable(
                name: "Regiones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos");

            migrationBuilder.RenameTable(
                name: "Personas",
                newName: "Persona");

            migrationBuilder.RenameTable(
                name: "Departamentos",
                newName: "Departamento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persona",
                table: "Persona",
                column: "IDPersona");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamento",
                table: "Departamento",
                column: "IDDepartamento");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Departamento_IDDepartamento",
                table: "Usuarios",
                column: "IDDepartamento",
                principalTable: "Departamento",
                principalColumn: "IDDepartamento",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Persona_IDPersona",
                table: "Usuarios",
                column: "IDPersona",
                principalTable: "Persona",
                principalColumn: "IDPersona",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
