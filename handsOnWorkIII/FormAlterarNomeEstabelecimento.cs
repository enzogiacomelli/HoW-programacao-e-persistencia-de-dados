using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace handsOnWorkIII
{
    public partial class FormAlterarNomeEstabelecimento : Form
    {
        public FormAlterarNomeEstabelecimento()
        {
            InitializeComponent();
        }

        //-------------SALVAR NOME DO ESTABELECIMENTO NO BANCO-----
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            conexaoBanco conn = new conexaoBanco();//chama a classe conexaoBanco
            var conexaoDB = conn.conectarNoBanco();//recebe a conexão
            if (textBoxNome.Text == "")//validar para não permitir salvar nada
            {
                MessageBox.Show("Insira um nome válido!");
            }
            else
            {
                try
                {
                    conexaoDB.Open(); //abre a conexão
                    MySqlCommand comandoSql = conexaoDB.CreateCommand(); //criando o comando para inserir no banco
                    comandoSql.CommandText = "UPDATE configuracoes SET nome_estabelecimento = '" + textBoxNome.Text + "'";
                    comandoSql.ExecuteNonQuery();
                    conexaoDB.Close();//fecha conexão
                    MessageBox.Show("Alterado com sucesso!");
                    Close();
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            }
            
        }
    }
}
