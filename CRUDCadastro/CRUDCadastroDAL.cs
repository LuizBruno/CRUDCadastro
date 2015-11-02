using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDCadastro
{
    class CRUDCadastroDAL
    {
        private static String strConexao = "Data Source=.\\SQLEXPRESS; Initial Catalog = Relatorio; Integrated Security=True;";
        private static SqlConnection conn = new SqlConnection(strConexao);
        private static SqlCommand strSQL;
        private static SqlDataReader result;

        public static void conecta()
        {
            conn.Open();
        }

        public static void desconecta()
        {
            conn.Close();
        }

        public static void alteraUmFuncionario()
        {
            conecta();
            strSQL = new SqlCommand("stpAlterarFuncionario", conn);
            strSQL.Parameters.AddWithValue("@codigo", CRUDCadastro.getCodigo());
            strSQL.Parameters.AddWithValue("@nome", CRUDCadastro.getNome());
            strSQL.Parameters.AddWithValue("@telefone", CRUDCadastro.getTelefone());
            strSQL.Parameters.AddWithValue("@endereco", CRUDCadastro.getEndereco());
            strSQL.Parameters.AddWithValue("@funcao", CRUDCadastro.getFuncao());
            strSQL.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                strSQL.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Erro.setMsg("Erro: " + e.ToString());
            }
            finally
            {
                desconecta();
            }
        }

        public static void deletaUmFuncionario()
        {
            conecta();
            strSQL = new SqlCommand("stpDeletarFuncionario", conn);
            strSQL.Parameters.AddWithValue("@codigo", CRUDCadastro.getCodigo());
            strSQL.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                strSQL.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Erro.setMsg("Erro: " + e.ToString());
            }
            finally
            {
                desconecta();
            }
        }

        public static void inserirUmFuncionario()
        {
            conecta();
            strSQL = new SqlCommand("stpInserirFuncionario", conn);
            strSQL.Parameters.AddWithValue("@nome", CRUDCadastro.getNome());
            strSQL.Parameters.AddWithValue("@telefone", CRUDCadastro.getTelefone());
            strSQL.Parameters.AddWithValue("@endereco", CRUDCadastro.getEndereco());
            strSQL.Parameters.AddWithValue("@funcao", CRUDCadastro.getFuncao());
            strSQL.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                strSQL.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Erro.setMsg("Erro: " + e.ToString());
            }
            finally
            {
                desconecta();
            }
        }

        public static void consultaUmFuncionario()
        {
            conecta();
            strSQL = new SqlCommand("stpConsultarFuncionario", conn);
            strSQL.Parameters.AddWithValue("@codigo", CRUDCadastro.getCodigo());
            strSQL.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                strSQL.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Erro.setMsg("Erro: " + e.ToString());
            }
            finally
            {
                desconecta();
            }
        }
    }
}