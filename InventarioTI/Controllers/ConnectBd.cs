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

        public void InserirRegistros(string nomePeca,
                                     string marcaPeca,
                                     string modeloPeca,
                                     decimal capacidade,
                                     string unidadeCapacidade)
        {
            if (string.IsNullOrEmpty(nomePeca))
            {
                throw new ArgumentException($"'{nameof(nomePeca)}' não pode ser nulo nem vazio.", nameof(nomePeca));
            }

            if (string.IsNullOrEmpty(marcaPeca))
            {
                throw new ArgumentException($"'{nameof(marcaPeca)}' não pode ser nulo nem vazio.", nameof(marcaPeca));
            }

            if (string.IsNullOrEmpty(modeloPeca))
            {
                throw new ArgumentException($"'{nameof(modeloPeca)}' não pode ser nulo nem vazio.", nameof(modeloPeca));
            }

            if (string.IsNullOrEmpty(unidadeCapacidade))
            {
                throw new ArgumentException($"'{nameof(unidadeCapacidade)}' não pode ser nulo nem vazio.", nameof(unidadeCapacidade));
            }

            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //Abra a conexão com o PgSQL                  
                    pgsqlConnection.Open();

                    string cmdInserir = "INSERT INTO GESTPECAS( CODPECA, DESCRICAO, MODELO, MARCA, CAPACIDADE, UNIDADEMEDIDA) VALUES " +
                        " (NEXTVAL('seq_pecas_id'), :DESCRICAO, :MODELO, :MARCA, :CAPACIDADE, :UNIDADEMEDIDA)";

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdInserir, pgsqlConnection))
                    {
                        pgsqlcommand.Parameters.AddWithValue("DESCRICAO", nomePeca);
                        pgsqlcommand.Parameters.AddWithValue("MODELO", modeloPeca);
                        pgsqlcommand.Parameters.AddWithValue("MARCA", marcaPeca);
                        pgsqlcommand.Parameters.AddWithValue("CAPACIDADE", capacidade);
                        pgsqlcommand.Parameters.AddWithValue("UNIDADEMEDIDA", unidadeCapacidade);

                        pgsqlcommand.ExecuteScalar();
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

        }
    }
}
