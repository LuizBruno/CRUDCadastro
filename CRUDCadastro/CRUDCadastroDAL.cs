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
            String aux = "";

            conecta();
            strSQL = new SqlCommand(aux, conn);
            strSQL.ExecuteNonQuery();
            desconecta();
        }

        public static void deletaUmFuncionario()
        {
            String aux = "";

            conecta();
            strSQL = new SqlCommand(aux, conn);
            strSQL.ExecuteNonQuery();
            desconecta();
        }

        public static void inserirUmFuncionario()
        {
            String aux = "";

            conecta();
            strSQL = new SqlCommand(aux, conn);
            strSQL.ExecuteNonQuery();
            desconecta();
        }

        public static void consultaUmFuncionario()
        {
            String aux = "";

            conecta();
            strSQL = new SqlCommand(aux, conn);
            result = strSQL.ExecuteReader();
            Erro.setErro(false);
            if (result.Read())
            {
                //Livro.setTitulo(result.GetString(1));
                //Livro.setAutor(result.GetString(2));
                //Livro.setEditora(result.GetString(3));
                //Livro.setAno(result.GetString(4));
            }
            else
                Erro.setMsg("Livro não cadastrado.");
            desconecta();
        }
    }
}
