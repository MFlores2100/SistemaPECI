using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaPECI.Migrations
{
    /// <inheritdoc />
    public partial class RestructuracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComposicionInversiones_Proyectos_IDProyecto",
                table: "ComposicionInversiones");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallesAuditorias_RegistrosAuditoria_IDAuditoria",
                table: "DetallesAuditorias");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallesAuditorias_Usuarios_IDUsuario",
                table: "DetallesAuditorias");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallesRegiones_Provincias_IDProvincia",
                table: "DetallesRegiones");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallesRegiones_Regiones_IDRegion",
                table: "DetallesRegiones");

            migrationBuilder.DropForeignKey(
                name: "FK_GestionFinanciamientos_Proyectos_IDProyecto",
                table: "GestionFinanciamientos");

            migrationBuilder.DropForeignKey(
                name: "FK_GestionFinanciamientos_Regiones_IDRegion",
                table: "GestionFinanciamientos");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialesRequeridos_MaterialesEquipos_IDMaterialEquipo",
                table: "MaterialesRequeridos");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialesRequeridos_Proyectos_IDProyecto",
                table: "MaterialesRequeridos");

            migrationBuilder.DropForeignKey(
                name: "FK_Provincias_Cantones_IDCanton",
                table: "Provincias");

            migrationBuilder.DropForeignKey(
                name: "FK_Proyectos_Regiones_IDRegion",
                table: "Proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProyectosRegiones_Proyectos_IDProyecto",
                table: "ProyectosRegiones");

            migrationBuilder.DropForeignKey(
                name: "FK_ProyectosRegiones_Regiones_IDRegion",
                table: "ProyectosRegiones");

            migrationBuilder.DropForeignKey(
                name: "FK_ProyectoUsuarios_Proyectos_IDProyecto",
                table: "ProyectoUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_ProyectoUsuarios_Usuarios_IDUsuario",
                table: "ProyectoUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Departamentos_IDDepartamento",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Personas_IDPersona",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RegistrosAuditoria",
                table: "RegistrosAuditoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Regiones",
                table: "Regiones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProyectoUsuarios",
                table: "ProyectoUsuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProyectosRegiones",
                table: "ProyectosRegiones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proyectos",
                table: "Proyectos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provincias",
                table: "Provincias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialesRequeridos",
                table: "MaterialesRequeridos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialesEquipos",
                table: "MaterialesEquipos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GestionFinanciamientos",
                table: "GestionFinanciamientos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetallesRegiones",
                table: "DetallesRegiones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetallesAuditorias",
                table: "DetallesAuditorias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComposicionInversiones",
                table: "ComposicionInversiones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cantones",
                table: "Cantones");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuario");

            migrationBuilder.RenameTable(
                name: "RegistrosAuditoria",
                newName: "RegistroAuditoria");

            migrationBuilder.RenameTable(
                name: "Regiones",
                newName: "Region");

            migrationBuilder.RenameTable(
                name: "ProyectoUsuarios",
                newName: "ProyectoUsuario");

            migrationBuilder.RenameTable(
                name: "ProyectosRegiones",
                newName: "ProyectoRegion");

            migrationBuilder.RenameTable(
                name: "Proyectos",
                newName: "Proyecto");

            migrationBuilder.RenameTable(
                name: "Provincias",
                newName: "Provincia");

            migrationBuilder.RenameTable(
                name: "Personas",
                newName: "Persona");

            migrationBuilder.RenameTable(
                name: "MaterialesRequeridos",
                newName: "MaterialRequerido");

            migrationBuilder.RenameTable(
                name: "MaterialesEquipos",
                newName: "MaterialEquipo");

            migrationBuilder.RenameTable(
                name: "GestionFinanciamientos",
                newName: "GestionFinanciamiento");

            migrationBuilder.RenameTable(
                name: "DetallesRegiones",
                newName: "DetalleRegion");

            migrationBuilder.RenameTable(
                name: "DetallesAuditorias",
                newName: "DetalleAuditoria");

            migrationBuilder.RenameTable(
                name: "Departamentos",
                newName: "Departamento");

            migrationBuilder.RenameTable(
                name: "ComposicionInversiones",
                newName: "ComposicionInversion");

            migrationBuilder.RenameTable(
                name: "Cantones",
                newName: "Canton");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_IDPersona",
                table: "Usuario",
                newName: "IX_Usuario_IDPersona");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_IDDepartamento",
                table: "Usuario",
                newName: "IX_Usuario_IDDepartamento");

            migrationBuilder.RenameIndex(
                name: "IX_ProyectoUsuarios_IDUsuario",
                table: "ProyectoUsuario",
                newName: "IX_ProyectoUsuario_IDUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_ProyectoUsuarios_IDProyecto",
                table: "ProyectoUsuario",
                newName: "IX_ProyectoUsuario_IDProyecto");

            migrationBuilder.RenameIndex(
                name: "IX_ProyectosRegiones_IDRegion",
                table: "ProyectoRegion",
                newName: "IX_ProyectoRegion_IDRegion");

            migrationBuilder.RenameIndex(
                name: "IX_ProyectosRegiones_IDProyecto",
                table: "ProyectoRegion",
                newName: "IX_ProyectoRegion_IDProyecto");

            migrationBuilder.RenameIndex(
                name: "IX_Proyectos_IDRegion",
                table: "Proyecto",
                newName: "IX_Proyecto_IDRegion");

            migrationBuilder.RenameIndex(
                name: "IX_Provincias_IDCanton",
                table: "Provincia",
                newName: "IX_Provincia_IDCanton");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialesRequeridos_IDProyecto",
                table: "MaterialRequerido",
                newName: "IX_MaterialRequerido_IDProyecto");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialesRequeridos_IDMaterialEquipo",
                table: "MaterialRequerido",
                newName: "IX_MaterialRequerido_IDMaterialEquipo");

            migrationBuilder.RenameIndex(
                name: "IX_GestionFinanciamientos_IDRegion",
                table: "GestionFinanciamiento",
                newName: "IX_GestionFinanciamiento_IDRegion");

            migrationBuilder.RenameIndex(
                name: "IX_GestionFinanciamientos_IDProyecto",
                table: "GestionFinanciamiento",
                newName: "IX_GestionFinanciamiento_IDProyecto");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesRegiones_IDRegion",
                table: "DetalleRegion",
                newName: "IX_DetalleRegion_IDRegion");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesRegiones_IDProvincia",
                table: "DetalleRegion",
                newName: "IX_DetalleRegion_IDProvincia");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesAuditorias_IDUsuario",
                table: "DetalleAuditoria",
                newName: "IX_DetalleAuditoria_IDUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesAuditorias_IDAuditoria",
                table: "DetalleAuditoria",
                newName: "IX_DetalleAuditoria_IDAuditoria");

            migrationBuilder.RenameIndex(
                name: "IX_ComposicionInversiones_IDProyecto",
                table: "ComposicionInversion",
                newName: "IX_ComposicionInversion_IDProyecto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "IDUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegistroAuditoria",
                table: "RegistroAuditoria",
                column: "IDAuditoria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Region",
                table: "Region",
                column: "IDRegion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProyectoUsuario",
                table: "ProyectoUsuario",
                column: "IDProyectoUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProyectoRegion",
                table: "ProyectoRegion",
                column: "IDProyectoRegion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proyecto",
                table: "Proyecto",
                column: "IDProyecto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provincia",
                table: "Provincia",
                column: "IDProvincia");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persona",
                table: "Persona",
                column: "IDPersona");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialRequerido",
                table: "MaterialRequerido",
                column: "IDMaterialRequerido");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialEquipo",
                table: "MaterialEquipo",
                column: "IDMaterialEquipo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GestionFinanciamiento",
                table: "GestionFinanciamiento",
                column: "IDGestionFinanciamiento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetalleRegion",
                table: "DetalleRegion",
                column: "IDDetalleRegion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetalleAuditoria",
                table: "DetalleAuditoria",
                column: "IDDetalleAuditoria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamento",
                table: "Departamento",
                column: "IDDepartamento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComposicionInversion",
                table: "ComposicionInversion",
                column: "IDComposicionInversion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Canton",
                table: "Canton",
                column: "IDCanton");

            migrationBuilder.AddForeignKey(
                name: "FK_ComposicionInversion_Proyecto_IDProyecto",
                table: "ComposicionInversion",
                column: "IDProyecto",
                principalTable: "Proyecto",
                principalColumn: "IDProyecto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleAuditoria_RegistroAuditoria_IDAuditoria",
                table: "DetalleAuditoria",
                column: "IDAuditoria",
                principalTable: "RegistroAuditoria",
                principalColumn: "IDAuditoria",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleAuditoria_Usuario_IDUsuario",
                table: "DetalleAuditoria",
                column: "IDUsuario",
                principalTable: "Usuario",
                principalColumn: "IDUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleRegion_Provincia_IDProvincia",
                table: "DetalleRegion",
                column: "IDProvincia",
                principalTable: "Provincia",
                principalColumn: "IDProvincia",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleRegion_Region_IDRegion",
                table: "DetalleRegion",
                column: "IDRegion",
                principalTable: "Region",
                principalColumn: "IDRegion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GestionFinanciamiento_Proyecto_IDProyecto",
                table: "GestionFinanciamiento",
                column: "IDProyecto",
                principalTable: "Proyecto",
                principalColumn: "IDProyecto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GestionFinanciamiento_Region_IDRegion",
                table: "GestionFinanciamiento",
                column: "IDRegion",
                principalTable: "Region",
                principalColumn: "IDRegion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialRequerido_MaterialEquipo_IDMaterialEquipo",
                table: "MaterialRequerido",
                column: "IDMaterialEquipo",
                principalTable: "MaterialEquipo",
                principalColumn: "IDMaterialEquipo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialRequerido_Proyecto_IDProyecto",
                table: "MaterialRequerido",
                column: "IDProyecto",
                principalTable: "Proyecto",
                principalColumn: "IDProyecto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Provincia_Canton_IDCanton",
                table: "Provincia",
                column: "IDCanton",
                principalTable: "Canton",
                principalColumn: "IDCanton",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proyecto_Region_IDRegion",
                table: "Proyecto",
                column: "IDRegion",
                principalTable: "Region",
                principalColumn: "IDRegion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProyectoRegion_Proyecto_IDProyecto",
                table: "ProyectoRegion",
                column: "IDProyecto",
                principalTable: "Proyecto",
                principalColumn: "IDProyecto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProyectoRegion_Region_IDRegion",
                table: "ProyectoRegion",
                column: "IDRegion",
                principalTable: "Region",
                principalColumn: "IDRegion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProyectoUsuario_Proyecto_IDProyecto",
                table: "ProyectoUsuario",
                column: "IDProyecto",
                principalTable: "Proyecto",
                principalColumn: "IDProyecto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProyectoUsuario_Usuario_IDUsuario",
                table: "ProyectoUsuario",
                column: "IDUsuario",
                principalTable: "Usuario",
                principalColumn: "IDUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Departamento_IDDepartamento",
                table: "Usuario",
                column: "IDDepartamento",
                principalTable: "Departamento",
                principalColumn: "IDDepartamento",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Persona_IDPersona",
                table: "Usuario",
                column: "IDPersona",
                principalTable: "Persona",
                principalColumn: "IDPersona",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComposicionInversion_Proyecto_IDProyecto",
                table: "ComposicionInversion");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleAuditoria_RegistroAuditoria_IDAuditoria",
                table: "DetalleAuditoria");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleAuditoria_Usuario_IDUsuario",
                table: "DetalleAuditoria");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleRegion_Provincia_IDProvincia",
                table: "DetalleRegion");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleRegion_Region_IDRegion",
                table: "DetalleRegion");

            migrationBuilder.DropForeignKey(
                name: "FK_GestionFinanciamiento_Proyecto_IDProyecto",
                table: "GestionFinanciamiento");

            migrationBuilder.DropForeignKey(
                name: "FK_GestionFinanciamiento_Region_IDRegion",
                table: "GestionFinanciamiento");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialRequerido_MaterialEquipo_IDMaterialEquipo",
                table: "MaterialRequerido");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialRequerido_Proyecto_IDProyecto",
                table: "MaterialRequerido");

            migrationBuilder.DropForeignKey(
                name: "FK_Provincia_Canton_IDCanton",
                table: "Provincia");

            migrationBuilder.DropForeignKey(
                name: "FK_Proyecto_Region_IDRegion",
                table: "Proyecto");

            migrationBuilder.DropForeignKey(
                name: "FK_ProyectoRegion_Proyecto_IDProyecto",
                table: "ProyectoRegion");

            migrationBuilder.DropForeignKey(
                name: "FK_ProyectoRegion_Region_IDRegion",
                table: "ProyectoRegion");

            migrationBuilder.DropForeignKey(
                name: "FK_ProyectoUsuario_Proyecto_IDProyecto",
                table: "ProyectoUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_ProyectoUsuario_Usuario_IDUsuario",
                table: "ProyectoUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Departamento_IDDepartamento",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Persona_IDPersona",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RegistroAuditoria",
                table: "RegistroAuditoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Region",
                table: "Region");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProyectoUsuario",
                table: "ProyectoUsuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProyectoRegion",
                table: "ProyectoRegion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proyecto",
                table: "Proyecto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provincia",
                table: "Provincia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persona",
                table: "Persona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialRequerido",
                table: "MaterialRequerido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialEquipo",
                table: "MaterialEquipo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GestionFinanciamiento",
                table: "GestionFinanciamiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetalleRegion",
                table: "DetalleRegion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetalleAuditoria",
                table: "DetalleAuditoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamento",
                table: "Departamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComposicionInversion",
                table: "ComposicionInversion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Canton",
                table: "Canton");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "RegistroAuditoria",
                newName: "RegistrosAuditoria");

            migrationBuilder.RenameTable(
                name: "Region",
                newName: "Regiones");

            migrationBuilder.RenameTable(
                name: "ProyectoUsuario",
                newName: "ProyectoUsuarios");

            migrationBuilder.RenameTable(
                name: "ProyectoRegion",
                newName: "ProyectosRegiones");

            migrationBuilder.RenameTable(
                name: "Proyecto",
                newName: "Proyectos");

            migrationBuilder.RenameTable(
                name: "Provincia",
                newName: "Provincias");

            migrationBuilder.RenameTable(
                name: "Persona",
                newName: "Personas");

            migrationBuilder.RenameTable(
                name: "MaterialRequerido",
                newName: "MaterialesRequeridos");

            migrationBuilder.RenameTable(
                name: "MaterialEquipo",
                newName: "MaterialesEquipos");

            migrationBuilder.RenameTable(
                name: "GestionFinanciamiento",
                newName: "GestionFinanciamientos");

            migrationBuilder.RenameTable(
                name: "DetalleRegion",
                newName: "DetallesRegiones");

            migrationBuilder.RenameTable(
                name: "DetalleAuditoria",
                newName: "DetallesAuditorias");

            migrationBuilder.RenameTable(
                name: "Departamento",
                newName: "Departamentos");

            migrationBuilder.RenameTable(
                name: "ComposicionInversion",
                newName: "ComposicionInversiones");

            migrationBuilder.RenameTable(
                name: "Canton",
                newName: "Cantones");

            migrationBuilder.RenameIndex(
                name: "IX_Usuario_IDPersona",
                table: "Usuarios",
                newName: "IX_Usuarios_IDPersona");

            migrationBuilder.RenameIndex(
                name: "IX_Usuario_IDDepartamento",
                table: "Usuarios",
                newName: "IX_Usuarios_IDDepartamento");

            migrationBuilder.RenameIndex(
                name: "IX_ProyectoUsuario_IDUsuario",
                table: "ProyectoUsuarios",
                newName: "IX_ProyectoUsuarios_IDUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_ProyectoUsuario_IDProyecto",
                table: "ProyectoUsuarios",
                newName: "IX_ProyectoUsuarios_IDProyecto");

            migrationBuilder.RenameIndex(
                name: "IX_ProyectoRegion_IDRegion",
                table: "ProyectosRegiones",
                newName: "IX_ProyectosRegiones_IDRegion");

            migrationBuilder.RenameIndex(
                name: "IX_ProyectoRegion_IDProyecto",
                table: "ProyectosRegiones",
                newName: "IX_ProyectosRegiones_IDProyecto");

            migrationBuilder.RenameIndex(
                name: "IX_Proyecto_IDRegion",
                table: "Proyectos",
                newName: "IX_Proyectos_IDRegion");

            migrationBuilder.RenameIndex(
                name: "IX_Provincia_IDCanton",
                table: "Provincias",
                newName: "IX_Provincias_IDCanton");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialRequerido_IDProyecto",
                table: "MaterialesRequeridos",
                newName: "IX_MaterialesRequeridos_IDProyecto");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialRequerido_IDMaterialEquipo",
                table: "MaterialesRequeridos",
                newName: "IX_MaterialesRequeridos_IDMaterialEquipo");

            migrationBuilder.RenameIndex(
                name: "IX_GestionFinanciamiento_IDRegion",
                table: "GestionFinanciamientos",
                newName: "IX_GestionFinanciamientos_IDRegion");

            migrationBuilder.RenameIndex(
                name: "IX_GestionFinanciamiento_IDProyecto",
                table: "GestionFinanciamientos",
                newName: "IX_GestionFinanciamientos_IDProyecto");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleRegion_IDRegion",
                table: "DetallesRegiones",
                newName: "IX_DetallesRegiones_IDRegion");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleRegion_IDProvincia",
                table: "DetallesRegiones",
                newName: "IX_DetallesRegiones_IDProvincia");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleAuditoria_IDUsuario",
                table: "DetallesAuditorias",
                newName: "IX_DetallesAuditorias_IDUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleAuditoria_IDAuditoria",
                table: "DetallesAuditorias",
                newName: "IX_DetallesAuditorias_IDAuditoria");

            migrationBuilder.RenameIndex(
                name: "IX_ComposicionInversion_IDProyecto",
                table: "ComposicionInversiones",
                newName: "IX_ComposicionInversiones_IDProyecto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "IDUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegistrosAuditoria",
                table: "RegistrosAuditoria",
                column: "IDAuditoria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Regiones",
                table: "Regiones",
                column: "IDRegion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProyectoUsuarios",
                table: "ProyectoUsuarios",
                column: "IDProyectoUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProyectosRegiones",
                table: "ProyectosRegiones",
                column: "IDProyectoRegion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proyectos",
                table: "Proyectos",
                column: "IDProyecto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provincias",
                table: "Provincias",
                column: "IDProvincia");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "IDPersona");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialesRequeridos",
                table: "MaterialesRequeridos",
                column: "IDMaterialRequerido");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialesEquipos",
                table: "MaterialesEquipos",
                column: "IDMaterialEquipo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GestionFinanciamientos",
                table: "GestionFinanciamientos",
                column: "IDGestionFinanciamiento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetallesRegiones",
                table: "DetallesRegiones",
                column: "IDDetalleRegion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetallesAuditorias",
                table: "DetallesAuditorias",
                column: "IDDetalleAuditoria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos",
                column: "IDDepartamento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComposicionInversiones",
                table: "ComposicionInversiones",
                column: "IDComposicionInversion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cantones",
                table: "Cantones",
                column: "IDCanton");

            migrationBuilder.AddForeignKey(
                name: "FK_ComposicionInversiones_Proyectos_IDProyecto",
                table: "ComposicionInversiones",
                column: "IDProyecto",
                principalTable: "Proyectos",
                principalColumn: "IDProyecto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesAuditorias_RegistrosAuditoria_IDAuditoria",
                table: "DetallesAuditorias",
                column: "IDAuditoria",
                principalTable: "RegistrosAuditoria",
                principalColumn: "IDAuditoria",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesAuditorias_Usuarios_IDUsuario",
                table: "DetallesAuditorias",
                column: "IDUsuario",
                principalTable: "Usuarios",
                principalColumn: "IDUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesRegiones_Provincias_IDProvincia",
                table: "DetallesRegiones",
                column: "IDProvincia",
                principalTable: "Provincias",
                principalColumn: "IDProvincia",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesRegiones_Regiones_IDRegion",
                table: "DetallesRegiones",
                column: "IDRegion",
                principalTable: "Regiones",
                principalColumn: "IDRegion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GestionFinanciamientos_Proyectos_IDProyecto",
                table: "GestionFinanciamientos",
                column: "IDProyecto",
                principalTable: "Proyectos",
                principalColumn: "IDProyecto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GestionFinanciamientos_Regiones_IDRegion",
                table: "GestionFinanciamientos",
                column: "IDRegion",
                principalTable: "Regiones",
                principalColumn: "IDRegion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialesRequeridos_MaterialesEquipos_IDMaterialEquipo",
                table: "MaterialesRequeridos",
                column: "IDMaterialEquipo",
                principalTable: "MaterialesEquipos",
                principalColumn: "IDMaterialEquipo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialesRequeridos_Proyectos_IDProyecto",
                table: "MaterialesRequeridos",
                column: "IDProyecto",
                principalTable: "Proyectos",
                principalColumn: "IDProyecto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Provincias_Cantones_IDCanton",
                table: "Provincias",
                column: "IDCanton",
                principalTable: "Cantones",
                principalColumn: "IDCanton",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proyectos_Regiones_IDRegion",
                table: "Proyectos",
                column: "IDRegion",
                principalTable: "Regiones",
                principalColumn: "IDRegion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProyectosRegiones_Proyectos_IDProyecto",
                table: "ProyectosRegiones",
                column: "IDProyecto",
                principalTable: "Proyectos",
                principalColumn: "IDProyecto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProyectosRegiones_Regiones_IDRegion",
                table: "ProyectosRegiones",
                column: "IDRegion",
                principalTable: "Regiones",
                principalColumn: "IDRegion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProyectoUsuarios_Proyectos_IDProyecto",
                table: "ProyectoUsuarios",
                column: "IDProyecto",
                principalTable: "Proyectos",
                principalColumn: "IDProyecto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProyectoUsuarios_Usuarios_IDUsuario",
                table: "ProyectoUsuarios",
                column: "IDUsuario",
                principalTable: "Usuarios",
                principalColumn: "IDUsuario",
                onDelete: ReferentialAction.Cascade);

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
    }
}
