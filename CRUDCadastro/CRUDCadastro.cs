using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDCadastro
{
    class CRUDCadastro
    {
        private static string Codigo;
        private static string Nome;
        private static string Telefone;
        private static string Endereco;
        private static string Funcao;

        public static void setCodigo(string _codigo) { Codigo = _codigo; }
        public static void setNome(string _nome) { Nome = _nome; }
        public static void setTelefone(string _telefone) { Telefone = _telefone; }
        public static void setEndereco(string _endereco) { Endereco = _endereco; }
        public static void setFuncao(string _funcao) { Funcao = _funcao; }
        
        public static string getCodigo() { return Codigo; }
        public static string getNome() { return Nome; }
        public static string getTelefone() { return Telefone; }
        public static string getEndereco() { return Endereco; }
        public static string getFuncao() { return Funcao; }       
    }
}