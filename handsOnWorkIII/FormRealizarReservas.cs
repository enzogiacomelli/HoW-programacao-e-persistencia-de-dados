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
    public partial class FormRealizarReservas : Form
    {
        public FormRealizarReservas()
        {
            InitializeComponent();
            
        }
        
        private void FormRealizarReservas_Load(object sender, EventArgs e)
        {
            atualizarGridReservas();
        }

        public void limparCampos()
        {
            txtBoxDefineHora.Clear();
            txtBoxSelecionaCliente.Clear();
            txtBoxSelecionaMesa.Clear();
        }

        public string VerificaUltimoIdDeReservas()
        {
            string idReserva;
            conexaoBanco conn2 = new conexaoBanco();//chama a classe conexaoBanco
            var conexaoDB2 = conn2.conectarNoBanco();//recebe a conexão

            MySqlCommand cmdSql = conexaoDB2.CreateCommand();//select para pegar o ID da ultima reserva que sera inserido na tabela mesas
            cmdSql.CommandText = "SELECT MAX(`id_reserva`) FROM reservas";
            MySqlDataReader reader = cmdSql.ExecuteReader();
            reader.Read();
            idReserva = reader.GetInt32(0).ToString();//verificar
            reader.Close();
            conexaoDB2.Close();
            return idReserva;//sera usado para inserir o id da reserva feita na tabela mesas
        }


        public void atualizarGridReservas()
        {
            conexaoBanco conn = new conexaoBanco();//chama a classe conexaoBanco
            var conexaoDB = conn.conectarNoBanco();//recebe a conexão

            try
            {
                conexaoDB.Open(); //abre a conexão
                MySqlCommand comandoSql = conexaoDB.CreateCommand(); //criando o comando para inserir no banco
                comandoSql.CommandText = "SELECT * FROM `reservas`";//setar pra trazer somente quem não foi exluido logicamente
                MySqlDataReader reader = comandoSql.ExecuteReader(); //comando de ler a query
                dataGridViewReservas.Rows.Clear();//limpa o grid para não acumular linhas
                while (reader.Read())//enquanto o reader possuir linhas para serem lidas (uma leitura para cada linha da tabela)
                {
                    DataGridViewRow linha = (DataGridViewRow)dataGridViewReservas.Rows[0].Clone();  //clona a primeira linha(que está vazia devido ao clear feito antes)
                    linha.Cells[0].Value = reader.GetInt64(0);      //ID
                    linha.Cells[1].Value = reader.GetInt64(1);      //Mesa
                    linha.Cells[2].Value = reader.GetInt64(2);      //Cliente
                    linha.Cells[3].Value = reader.GetTimeSpan(3);   //Horário
                    dataGridViewReservas.Rows.Add(linha);
                    
                }
                conexaoDB.Close();//fecha conexão
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            conexaoBanco conn = new conexaoBanco();//chama a classe conexaoBanco
            var conexaoDB = conn.conectarNoBanco();//recebe a conexão

            try
            {
                conexaoDB.Open(); //abre a conexão
                MySqlCommand comandoSql = conexaoDB.CreateCommand(); //comando para atualizar a tabela reservas
                comandoSql.CommandText = "INSERT INTO `reservas` (`id_reserva`, `id_mesa_reservada`, `id_cliente_reserva`, `horario`) " +
                    "VALUES (NULL, '" + txtBoxSelecionaMesa.Text + "', '" + txtBoxSelecionaCliente.Text + "', '" + txtBoxDefineHora.Text + "')";
                comandoSql.ExecuteNonQuery();


                MySqlCommand cmdSql2 = conexaoDB.CreateCommand();//comando para atualizar a tabela mesa com a reserva
                cmdSql2.CommandText = "UPDATE `mesa` SET `id_reserva_mesa` = '" + VerificaUltimoIdDeReservas() + "' WHERE `id_mesa` = " + txtBoxSelecionaMesa.Text + ";";
                cmdSql2.ExecuteNonQuery();
                conexaoDB.Close();//fecha conexão
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
            MessageBox.Show("Reserva salva com sucesso!");
            limparCampos();
            atualizarGridReservas();
        }
    }
}
