using System;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Conexão bem sucedida");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" não foi possivel conectar ao Bando de dados{ex.Message}");
            }
        }
    }
}
