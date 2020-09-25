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
    public partial class telaInicial : Form
    {
        
        public telaInicial()
        {
            InitializeComponent();
        }

        private void btnVisualizarClientes_Click(object sender, EventArgs e)
        {
            FormVisualizarClientes tela = new FormVisualizarClientes();
            tela.Show();
        }

        private void btnVisualizarMesas_Click(object sender, EventArgs e)
        {
            FormVisualizarMesas tela = new FormVisualizarMesas();
            tela.Show();
        }

        private void btnAlterarNome_Click(object sender, EventArgs e)
        {
            FormAlterarNomeEstabelecimento tela = new FormAlterarNomeEstabelecimento();
            tela.Show();
        }


        //------------------------CARREGA TELA INICIAL, RESGATA NOME DO ESTABELECIMENTO PARA ALTERAR A LABEL--------
        private void telaInicial_Load(object sender, EventArgs e)//le o nome do estabelecimento no banco e carrega na label
        {
            conexaoBanco conn = new conexaoBanco();//chama a classe conexaoBanco
            var conexaoDB = conn.conectarNoBanco();//recebe a conexão

            try
            {
                conexaoDB.Open(); //abre a conexão
                MySqlCommand comandoSql = conexaoDB.CreateCommand(); //criando o comando para inserir no banco
                comandoSql.CommandText = "SELECT `nome_estabelecimento` FROM configuracoes";
                MySqlDataReader reader = comandoSql.ExecuteReader();
                reader.Read();
                labelNomeDoEstabelecimento.Text = reader.GetString(0);//altera a label
                conexaoDB.Close();//fecha conexão
            }
            catch
            {
                MessageBox.Show("Erro ao carregar o nome do estabelecimento!");
            }
        }

        private void configuraçõesGeraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDefinirNumeroDeMesas tela = new FormDefinirNumeroDeMesas();
            tela.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FormRealizarReservas tela = new FormRealizarReservas();
            tela.Show();
        }

    }
}
