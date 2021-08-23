namespace SistemaWebAlumnos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlumnoDB2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumno",
                c => new
                    {
                        AlumnoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        DNI = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AlumnoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Alumno");
        }
    }
}