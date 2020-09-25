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
    public partial class FormVisualizarClientes : Form
    {
        string id_selecionado;//variavel para capturar valor da seleção do grid
        public FormVisualizarClientes()
        {
            InitializeComponent();
        }


        //-----------LIMPAR CAMPOS-----------------------
        public void limparCampos()//limpar todos os campos do form
        {
            txtBoxNome.Clear();
            txtBoxCpf.Clear();
            txtBoxTelefone.Clear();
            id_selecionado = "0";//impede que seja excluido um cliente que não está mais selecionado
            btnSalvar.Enabled = true;//habilita botão de salvar
        }



        public void FormVisualizarClientes_Load(object sender, EventArgs e)
        {
            atualizarGridClientes();//atualizar tabela de clientes do form
        }


        //------------ATUALIZAR O GRID DE LISTAGEM DE CLIENTES------------------------
        private void atualizarGridClientes()
        {
            conexaoBanco conn = new conexaoBanco();//chama a classe conexaoBanco
            var conexaoDB = conn.conectarNoBanco();//recebe a conexão

            try
            {
                conexaoDB.Open(); //abre a conexão
                MySqlCommand comandoSql = conexaoDB.CreateCommand(); //criando o comando para inserir no banco
                comandoSql.CommandText = "SELECT * FROM `cliente` WHERE cliente_excluido = 0";//trazer somente quem não foi exluido logicamente
                MySqlDataReader reader = comandoSql.ExecuteReader(); //comando de ler a query
                dataGridViewClientes.Rows.Clear();//limpa o grid para não acumular linhas
                while (reader.Read())//enquanto o reader possuir linhas para serem lidas (uma leitura para cada linha da tabela)
                {
                    DataGridViewRow linha = (DataGridViewRow)dataGridViewClientes.Rows[0].Clone();  //clona a primeira linha(que está vazia devido ao clear feito antes)
                    linha.Cells[0].Value = reader.GetInt64(0);       //ID
                    linha.Cells[1].Value = reader.GetString(1);      //Nome
                    linha.Cells[2].Value = reader.GetString(2);      //cpf
                    linha.Cells[3].Value = reader.GetString(3);      //telefone
                    dataGridViewClientes.Rows.Add(linha);
                }
                conexaoDB.Close();//fecha conexão
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }


        //-------------------EVENTO CLICAR NO GRID----------------------------------
        public void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)//funcionalidade de selecionar cliente da tabela
        {
            limparCampos();
            if (dataGridViewClientes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewClientes.CurrentRow.Selected = true;//seta a linha clicada como selecionada
                id_selecionado = dataGridViewClientes.Rows[e.RowIndex].Cells["Column_ID"].FormattedValue.ToString();//captura o id do cliente selecionado para utilizar na exlusão ou edição
                txtBoxNome.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["ColumnNome"].FormattedValue.ToString();        //
                txtBoxCpf.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["ColumnCPF"].FormattedValue.ToString();          //pega os valores para os campos do form
                txtBoxTelefone.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["ColumnTelefone"].FormattedValue.ToString();//
            }
            btnSalvar.Enabled = false;//bloqueia o botão salvar para impedir cadastros de clientes duplicados
        }


        //--------------------EXCLUSÃO DE CLIENTE------------------------------------
        public void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            conexaoBanco conn = new conexaoBanco();//chama a classe conexaoBanco
            var conexaoDB = conn.conectarNoBanco();//recebe a conexão

            try
            {
                conexaoDB.Open(); //abre a conexão
                MySqlCommand comandoSql = conexaoDB.CreateCommand(); //criando o comando para inserir no banco
                comandoSql.CommandText = "UPDATE `cliente` SET cliente_excluido = 1 WHERE id_cliente = "+ id_selecionado;//exclusão lógica
                comandoSql.ExecuteNonQuery();
                conexaoDB.Close();//fecha conexão
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
            atualizarGridClientes();
            limparCampos();
        }


        //-----------------EDITAR CLIENTE--------------------------------------------
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (txtBoxNome.TextLength > 0 && txtBoxCpf.TextLength == 14 && txtBoxTelefone.TextLength == 13)//verifica se os dados atendem o tamanho padrão esperado
            {
                if (txtBoxNome.Text == "" || txtBoxCpf.Text == "   ,   ,   -  " || txtBoxTelefone.Text == "(  )    -    ")//verifica se os campos não estão vazios
                {
                    MessageBox.Show("Preencha todos os campos corretamente!");
                }
                else
                {
                    conexaoBanco conn = new conexaoBanco();//chama a classe conexaoBanco
                    var conexaoDB = conn.conectarNoBanco();//recebe a conexão
                    try
                    {
                        conexaoDB.Open(); //abre a conexão
                        MySqlCommand comandoSql = conexaoDB.CreateCommand(); //criando o comando para inserir no banco
                        comandoSql.CommandText = "UPDATE `cliente` SET `nome_cliente` = '" + txtBoxNome.Text + "', `cpf` = '" + txtBoxCpf.Text + "', `telefone_cliente` = '" + txtBoxTelefone.Text + "' WHERE `cliente`.`id_cliente` = " + id_selecionado;
                        comandoSql.ExecuteNonQuery();
                        conexaoDB.Close();//fecha conexão

                        atualizarGridClientes();
                        limparCampos();
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine(erro.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente!");
            }
        }



        //------------------BOTÃO LIMPAR CAMPOS E ATUALIZAR GRID-----------------
        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            limparCampos();
            atualizarGridClientes();
        }



        //-------------------SALVAR CLIENTES-------------------------------------
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtBoxNome.TextLength > 0 && txtBoxCpf.TextLength == 14 && txtBoxTelefone.TextLength == 13)//verifica se os dados atendem o tamanho padrão esperado
            {
                if (txtBoxNome.Text == "" || txtBoxCpf.Text == "   ,   ,   -  " || txtBoxTelefone.Text == "(  )    -    ")//verifica se os campos não estão vazios
                {
                    MessageBox.Show("Preencha todos os campos corretamente!");
                }
                else
                {
                    conexaoBanco conn = new conexaoBanco();//chama a classe conexaoBanco
                    var conexaoDB = conn.conectarNoBanco();//recebe a conexão
                    try
                    {
                        conexaoDB.Open(); //abre a conexão
                        MySqlCommand comandoSql = conexaoDB.CreateCommand(); //criando o comando para inserir no banco
                        comandoSql.CommandText = "INSERT INTO `cliente` (`id_cliente`, `nome_cliente`, `cpf`, `telefone_cliente`, `cliente_excluido`) " +
                            "VALUES(NULL, '" + txtBoxNome.Text + "', '" + txtBoxCpf.Text + "', '" + txtBoxTelefone.Text + "', '0')";

                        comandoSql.ExecuteNonQuery();
                        conexaoDB.Close();//fecha conexão
                        atualizarGridClientes();
                        limparCampos();
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine(erro.Message);
                    }

                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente!");
            }
            
            
        }
    }
}
