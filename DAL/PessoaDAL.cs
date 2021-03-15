using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class PessoaDAL
    {
        private string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=BDSistemaXYZ;Integrated Security=true";
        
        public void InserirPessoa(Pessoa objPessoa)
        {
            //Criar objeto de conexão com o banco de dados
            SqlConnection conn = new SqlConnection(connectionString);

            //Abrir a conexão
            conn.Open();

            //Criar uma variável auxiliar para escrever o comando sql a ser executado
            string sql = "INSERT INTO Pessoas VALUES (@nome, @email, @sexo, @estadoCivil, @btRecebeEmail, @btRecebeSMS)";

            //Criar um objeto do tipo comando do SQL Sever
            SqlCommand cmd = new SqlCommand(sql, conn);

            //Trocar todos os parâmetros dos comandos por valores do método
            cmd.Parameters.AddWithValue("@nome", objPessoa.Nome);
            cmd.Parameters.AddWithValue("@email", objPessoa.Email);
            cmd.Parameters.AddWithValue("@sexo", objPessoa.Sexo);
            cmd.Parameters.AddWithValue("@estadoCivil", objPessoa.EstadoCivil);
            cmd.Parameters.AddWithValue("@btRecebeEmail", objPessoa.BtRecebeEmail);
            cmd.Parameters.AddWithValue("@btRecebeSMS", objPessoa.BtRecebeSMS);

            //Executar o comando SQL Server
            cmd.ExecuteNonQuery();

            //Fechar a conexão com o banco de dados
            conn.Close();
        }
    }
}
