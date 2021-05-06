using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace InventarioTI.Controllers
{
    class ConnectBd
    {
        private static string serverName = "127.0.1.1";
        private static string port = "5432";
        private static string userName = "postgres";
        private static string password = "Pg123";
        private static string databaseName = "gestti";
        private string connString = null;
        public ConnectBd()
        {
            connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                               serverName, port, userName, password, databaseName);
        }

        public  DataTable executeDataTable(string sqlquery )
        {
            DataTable dt = new DataTable();

            try 
            {
                //Abrindo uma conexão com o banco 
                 using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))

             
                {
                    pgsqlConnection.Open();

                    string query = sqlquery;

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(query, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }

                    pgsqlConnection.Close();

                }
            } 
            catch (NpgsqlException ex)
            {
                throw ex; 
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }
    }
}
