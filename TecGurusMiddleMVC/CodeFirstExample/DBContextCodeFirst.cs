using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TecGurusMiddleMVC.CodeFirstExample
{
    // Esto sólo se hace la primera vea
    // DMARTINEZ5410
    // DBCodeFirst
    // Para checar si existe el Nuget de Entities Framework
    // En Tools/NuGet Package Manage/Manage Package for solutions
    //
    // En WEB.config -----------------------------------------------------------------------------------------------
    //    <connectionStrings>
    //       <add name = "ConnectionCodeFirst" connectionString="Data Source=DMARTINEZ5410;
    //       Database=DBCodeFirst; Integrated Security = True"
    //       providerName="System.Data.SqlClient" />
    //      <add name = "DefaultConnection" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-TecGurusMiddleMVC-20211122081105.mdf;Initial Catalog=aspnet-TecGurusMiddleMVC-20211122081105;Integrated Security=True"
    //      providerName="System.Data.SqlClient" />
    //   </connectionStrings>
    //
    // En Tools/NuGet Package Manage/Package Manager Consola
    // Enable-Migrations -ProjectName MyContextProjectNameHere -StartUpProjectName MyStartUpProjectNameHere -Verbose


    public class DBContextCodeFirst : DbContext 
    {
        // indicamos mediante el constructir de conrexto con que cadena de conexion va a conectarse
        // a sql server
        public DBContextCodeFirst() : base("name=ConnectionCodeFirst")
        {


        }

        public virtual DbSet<Students>Student { get; set; }

        public virtual DbSet<Teachers>Teacher { get; set; }


    } // fin
}