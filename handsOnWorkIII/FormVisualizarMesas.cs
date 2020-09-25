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
using MySqlX.XDevAPI.Relational;

namespace handsOnWorkIII
{
    public partial class FormVisualizarMesas : Form
    {
        public FormVisualizarMesas()
        {
            InitializeComponent();
        }

        //-----------ATUALIZAR GRID AO CARREGAR O FORM----------------
        private void FormVisualizarMesas_Load(object sender, EventArgs e)
        {
            atualizarGridMesas();//ao carregar o form de visualizar mesas, atualizar o grid
        }


        //-----------ATUALIZA O GRID----------------------------------
        private void atualizarGridMesas()
        {
            conexaoBanco conn = new conexaoBanco();//chama a classe conexaoBanco
            var conexaoDB = conn.conectarNoBanco();//recebe a conexão
            
            try
            {
                conexaoDB.Open(); //abre a conexão
                Console.WriteLine("Conexão para atualizar Grid realizada com sucesso.");

                MySqlCommand comandoSql = conexaoDB.CreateCommand(); //criando o comando para inserir no banco
                comandoSql.CommandText = "SELECT * FROM `mesa`";

                MySqlDataReader reader = comandoSql.ExecuteReader(); //comando de ler a query

                dataGridMesas.Rows.Clear();//limpa o grid para não acumular linhas

                while (reader.Read())//enquanto o reader possuir linhas para serem lidas (uma leitura para cada linha da tabela)
                {
                    DataGridViewRow linha = (DataGridViewRow)dataGridMesas.Rows[0].Clone();  //clona a primeira linha(que está vazia devido ao clear feito antes)
                    linha.Cells[0].Value = reader.GetInt64(0);      //ID
                    linha.Cells[1].Value = reader.GetInt64(1);      //ID_Reserva
                    
                    dataGridMesas.Rows.Add(linha);
                }

                conexaoDB.Close();//fecha conexão
                Console.WriteLine("Fechada a conexão para atualizar o grid.");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Houve algum problema ao tentar atualizar a tabela!");
                Console.WriteLine(erro.Message);
            }

        }
    }
}
