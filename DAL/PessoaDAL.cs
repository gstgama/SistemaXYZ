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

        public void ExcluriPessoa(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM Pessoas WHERE Codigo = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", codigo);

            cmd.ExecuteNonQuery();
            
            conn.Close();
        }
        public void AtualizarPessoa(Pessoa objPessoa)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "UPDATE Pessoas SET Nome = @nome, Email = @email, Sexo = @sexo, EstadoCivil = @estadoCivil, BtRecebeEmail = @btRecebeEmail, BtRecebeSMS = @btRecebeSMS WHERE Codigo = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", objPessoa.Nome);
            cmd.Parameters.AddWithValue("@email", objPessoa.Email);
            cmd.Parameters.AddWithValue("@sexo", objPessoa.Sexo);
            cmd.Parameters.AddWithValue("@estadoCivil", objPessoa.EstadoCivil);
            cmd.Parameters.AddWithValue("@btRecebeSMS", objPessoa.BtRecebeSMS);
            cmd.Parameters.AddWithValue("@btRecebeEmail", objPessoa.BtRecebeEmail);
            cmd.Parameters.AddWithValue("@codigo", objPessoa.Codigo);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public Pessoa SelecionarPessoaPeloCodigo(int codigo)
        {
            Pessoa objPessoa = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Pessoas WHERE codigo = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", codigo);

            //Executar o comando, aguardando um retorno para leitura.
            SqlDataReader dr = cmd.ExecuteReader();

            //Se existe linhas no dr, e se pode ser lida.
            if(dr.HasRows && dr.Read())
            {
                objPessoa = new Pessoa();
                objPessoa.Codigo = codigo;
                objPessoa.Nome = dr["Nome"].ToString(); //"Nome" = nome da coluna do banco de dados.
                objPessoa.Email = dr["Email"].ToString();
                objPessoa.Sexo = dr["Sexo"].ToString();
                objPessoa.EstadoCivil = dr["EstadoCivil"].ToString();
                objPessoa.BtRecebeEmail = Convert.ToBoolean(dr["BtRecebeEmail"]);
                objPessoa.BtRecebeSMS = Convert.ToBoolean(dr["BtRecebeSMS"]);
            }

            conn.Close();

            return objPessoa;
        }

        public List<Pessoa> ListarPessoas()
        {
            //Instanciar uma lista do tipo pessoa.
            List<Pessoa> lista = new List<Pessoa>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Pessoas";

            SqlCommand cmd = new SqlCommand(sql, conn);

            //Objeto SqlDataReader para receber os resultados do banco.
            SqlDataReader dr = cmd.ExecuteReader();

            //Verificar se o dr tem linhas
            if (dr.HasRows)
            {
                //Criar um objeto auxiliar só para preencher os dados da pessoas.
                Pessoa p = null;

                //Ler cada uma das linhas até que chegue ao final do arquivo.
                while (dr.Read())
                {
                    p = new Pessoa();
                    p.Codigo = Convert.ToInt32(dr["Codigo"]);
                    p.Nome = dr["Nome"].ToString();
                    p.Email = dr["Email"].ToString();
                    p.Sexo = dr["Sexo"].ToString();
                    p.EstadoCivil = dr["EstadoCivil"].ToString();
                    p.BtRecebeEmail = Convert.ToBoolean(dr["BtRecebeEmail"]);
                    p.BtRecebeSMS = Convert.ToBoolean(dr["BtRecebeSMS"]);

                    lista.Add(p);
                }
            }
            conn.Close();

            return lista;
        }

    }
}
