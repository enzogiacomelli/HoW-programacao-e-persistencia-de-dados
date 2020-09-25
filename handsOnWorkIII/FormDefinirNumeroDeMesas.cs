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
    public partial class FormDefinirNumeroDeMesas : Form
    {
        public FormDefinirNumeroDeMesas()
        {
            InitializeComponent();
        }
         

        //-------------ATUALIZA O NUMERO TOTAL DE MESAS NO BANCO-------------
        public void atualizarNumDeMesasNoBanco()//atualiza o numero total de mesas no banco de dados
        {
            conexaoBanco conn = new conexaoBanco();//chama a classe conexaoBanco
            var conexaoDB = conn.conectarNoBanco();//recebe a conexão

            try
            {
                conexaoDB.Open(); //abre a conexão
                MySqlCommand comandoSql = conexaoDB.CreateCommand(); //criando o comando para inserir no banco
                comandoSql.CommandText = "UPDATE `configuracoes` SET `numero_total_mesas`= "+Convert.ToInt32(txtBoxNumeroMesas.Text)+";";
                comandoSql.ExecuteNonQuery();

                conexaoDB.Close();//fecha conexão
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
        
        //---------------ATUALIZA O CAMPO NUMERO TOTAL DE MESAS DO FORM----------------
        public void atualizarCampoNumDeMesas()//resgata o numero total de mesas do banco para preencher o textBox
        {
            conexaoBanco conn = new conexaoBanco();//chama a classe conexaoBanco
            var conexaoDB = conn.conectarNoBanco();//recebe a conexão

            try
            {
                conexaoDB.Open(); //abre a conexão
                MySqlCommand comandoSql = conexaoDB.CreateCommand(); //criando o comando para inserir no banco
                comandoSql.CommandText = "SELECT numero_total_mesas FROM `configuracoes`;";
                MySqlDataReader reader = comandoSql.ExecuteReader(); //comando de ler a query
                reader.Read();
                txtBoxNumeroMesas.Text = reader.GetInt32(0).ToString();

                conexaoDB.Close();//fecha conexão
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
    
            

        //---------------SALVAR NUMERO TOTAL DE MESAS--------------------------
        private void btnSalvar_Click(object sender, EventArgs e)//recria a tabela mesas com a nova quantidade de mesas
        {
            if (txtBoxNumeroMesas.Text != "")//impede de salvar vazio
            {
                conexaoBanco conn = new conexaoBanco();//chama a classe conexaoBanco
                var conexaoDB = conn.conectarNoBanco();//recebe a conexão
                int cont = Convert.ToInt32(txtBoxNumeroMesas.Text);//contador para o numero de vezes que o INSERT será rodado, valor resgatado do campo numero total de mesas do form

                try
                {
                    conexaoDB.Open(); //abre a conexão
                    MySqlCommand comandoSql = conexaoDB.CreateCommand(); //criando o comando para inserir no banco
                    comandoSql.CommandText = "TRUNCATE TABLE `mesa`;";//reseta a tabela(inclusive id count)
                    comandoSql.ExecuteNonQuery();
                    atualizarNumDeMesasNoBanco();//atualiza o numero total de mesas na tabela configuracoes

                    for (int i = 0; i < cont; i++)//adiciona mesas em quantidade igual ao numero máximo de mesas
                    {
                        MySqlCommand cmdSql = conexaoDB.CreateCommand();
                        cmdSql.CommandText = "INSERT INTO `mesa` (`id_mesa`, `id_reserva_mesa`) VALUES (NULL, '0')";
                        cmdSql.ExecuteNonQuery();
                    }

                    conexaoDB.Close();
                    MessageBox.Show("Atualizado com sucesso!");

                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                    MessageBox.Show("Erro ao atualizar a quantidade de mesas!");
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo antes de salvar!");
            }
        }


        //-----------------RESGATA O NUMERO TOTAL DE MESAS DO BANCO PARA ATUALIZAR O FORM-----------
        private void FormDefinirNumeroDeMesas_Load(object sender, EventArgs e)
        {
            atualizarCampoNumDeMesas();////resgata o numero total de mesas do banco para preencher o textBox
        }

    }
}
