using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace handsOnWorkIII
{
    public class conexaoBanco
    {
        //cria e retorna a conexão
        public MySqlConnection conectarNoBanco()
        {
            //criando a string de conexão com os parametros do banco a ser utilizado
            MySqlConnectionStringBuilder dadosConn = new MySqlConnectionStringBuilder();
            dadosConn.Server = "localhost";
            dadosConn.Database = "how_bd";
            dadosConn.UserID = "root";
            dadosConn.Password = "";
            //cria a conexão
            MySqlConnection conexaoDB = new MySqlConnection(dadosConn.ToString());
            return conexaoDB;//retorna a conexão quando for chamada
        } 
    }
}
