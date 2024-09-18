using System;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PartialView.Models;
using PartialView.Repositories;

class Program
{
    static async Task Main()
    {
        string connectionString = ""; 

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Conexão bem sucedida");

                RepositoryUser repositoryUser = new RepositoryUser();

                Model insertedModel = await repositoryUser.InsertUser(userModel);
                Console.WriteLine("Usuário inserido com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Não foi possível conectar ao banco de dados: {ex.Message}");
            }
        }
    }
}
