﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Threading.Tasks;

namespace ProgramaUniversitario
{
    public class Conexion
    {
        public OdbcConnection conexion()
        {
            //creacion de la conexion via ODBC
            OdbcConnection conn = new OdbcConnection("Dsn=Proyecto");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("Conectó");
            }
            return conn;
        }
        //metodo para cerrar la conexion
        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
        }
    }
}