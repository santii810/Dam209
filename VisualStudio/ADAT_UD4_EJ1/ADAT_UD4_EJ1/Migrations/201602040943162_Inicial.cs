namespace ADAT_UD4_EJ1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Asistencias",
                c => new
                    {
                        asistenciaID = c.String(nullable: false, maxLength: 128),
                        fechaHoraInicio = c.DateTime(nullable: false),
                        fechaHoraFin = c.DateTime(nullable: false),
                        descripcion = c.String(),
                        numSerie = c.String(maxLength: 128),
                        contactoId = c.String(maxLength: 128),
                        usuarioId = c.String(maxLength: 128),
                        numeroINC = c.String(),
                        incidencia_numeroINC = c.Int(),
                    })
                .PrimaryKey(t => t.asistenciaID)
                .ForeignKey("dbo.Contactoes", t => t.contactoId)
                .ForeignKey("dbo.Equipoes", t => t.numSerie)
                .ForeignKey("dbo.Incidencias", t => t.incidencia_numeroINC)
                .ForeignKey("dbo.Usuarios", t => t.usuarioId)
                .Index(t => t.numSerie)
                .Index(t => t.contactoId)
                .Index(t => t.usuarioId)
                .Index(t => t.incidencia_numeroINC);
            
            CreateTable(
                "dbo.Contactoes",
                c => new
                    {
                        contactoId = c.String(nullable: false, maxLength: 128),
                        nombre = c.String(),
                        telefono = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.contactoId);
            
            CreateTable(
                "dbo.Equipoes",
                c => new
                    {
                        numSerie = c.String(nullable: false, maxLength: 128),
                        tipo = c.String(),
                        descripcion = c.String(),
                        contraro = c.String(),
                        codEspec = c.String(),
                        codCliente = c.String(),
                        cliente_codCliente = c.Int(),
                    })
                .PrimaryKey(t => t.numSerie)
                .ForeignKey("dbo.Clientes", t => t.cliente_codCliente)
                .Index(t => t.cliente_codCliente);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        codCliente = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        descripcion = c.String(),
                        tipo = c.String(),
                        correo = c.String(),
                        codPostal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.codCliente);
            
            CreateTable(
                "dbo.Incidencias",
                c => new
                    {
                        numeroINC = c.Int(nullable: false, identity: true),
                        fechaHoraInicio = c.DateTime(nullable: false),
                        fechaHoraFin = c.DateTime(nullable: false),
                        numAsis = c.Int(nullable: false),
                        concluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.numeroINC);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        usuarioId = c.String(nullable: false, maxLength: 128),
                        nombre = c.String(),
                        password = c.String(),
                        numTecnico = c.Int(nullable: false),
                        tipo = c.String(),
                        correo = c.String(),
                        ventanas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.usuarioId);
            
            CreateTable(
                "dbo.Tareas",
                c => new
                    {
                        tareaId = c.String(nullable: false, maxLength: 128),
                        horaInicio = c.DateTime(nullable: false),
                        FechaInicio = c.DateTime(nullable: false),
                        prioridad = c.Int(nullable: false),
                        descripcion = c.String(),
                        concluido = c.Boolean(nullable: false),
                        propia = c.Boolean(nullable: false),
                        progreso = c.Int(nullable: false),
                        usuario_usuarioId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.tareaId)
                .ForeignKey("dbo.Usuarios", t => t.usuario_usuarioId)
                .Index(t => t.usuario_usuarioId);
            
            CreateTable(
                "dbo.Conexions",
                c => new
                    {
                        conexionId = c.String(nullable: false, maxLength: 128),
                        parametro = c.String(),
                        valor = c.String(),
                    })
                .PrimaryKey(t => t.conexionId);
            
            CreateTable(
                "dbo.Visitas",
                c => new
                    {
                        fechaHoraEfecto = c.DateTime(nullable: false),
                        descripcion = c.String(),
                    })
                .PrimaryKey(t => t.fechaHoraEfecto);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tareas", "usuario_usuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Asistencias", "usuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Asistencias", "incidencia_numeroINC", "dbo.Incidencias");
            DropForeignKey("dbo.Equipoes", "cliente_codCliente", "dbo.Clientes");
            DropForeignKey("dbo.Asistencias", "numSerie", "dbo.Equipoes");
            DropForeignKey("dbo.Asistencias", "contactoId", "dbo.Contactoes");
            DropIndex("dbo.Tareas", new[] { "usuario_usuarioId" });
            DropIndex("dbo.Equipoes", new[] { "cliente_codCliente" });
            DropIndex("dbo.Asistencias", new[] { "incidencia_numeroINC" });
            DropIndex("dbo.Asistencias", new[] { "usuarioId" });
            DropIndex("dbo.Asistencias", new[] { "contactoId" });
            DropIndex("dbo.Asistencias", new[] { "numSerie" });
            DropTable("dbo.Visitas");
            DropTable("dbo.Conexions");
            DropTable("dbo.Tareas");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Incidencias");
            DropTable("dbo.Clientes");
            DropTable("dbo.Equipoes");
            DropTable("dbo.Contactoes");
            DropTable("dbo.Asistencias");
        }
    }
}
