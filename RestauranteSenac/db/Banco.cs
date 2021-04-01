using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace RestauranteSenac.db
{
    class Banco
    {
        // Objeto de conexão SQL:
        public MySqlConnection conexao;

        // Contrutor de conexão:
        public Banco()
        {
            // String de conexão:
            string connstr = "Persist Security Info=False;server=localhost;database=sqlite;uid=root";
            // Conexão
            conexao = new MySqlConnection(connstr);
        }
        // Método para conectar:
        public void Conectar()
        {
            // Verificar se a conexão não está aberta:
            if(conexao.State != ConnectionState.Open)
            {
                // Abrir a conexão:
                conexao.Open();
            }
        }

        // Método para desconectar:
        public void Desconectar()
        {
            // Verificar se a conexão não está fechada:
            if(conexao.State != ConnectionState.Closed)
            {
                // Fechar a conexão:
                conexao.Close();
            }
        }
    }
}
