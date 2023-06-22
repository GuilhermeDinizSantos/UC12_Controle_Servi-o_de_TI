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

namespace UC12_Controle_Serviço_de_TI
{

    

    public partial class FormNOVAORDEM : Form
    {

        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public FormNOVAORDEM()
        {

            InitializeComponent();

            servidor = "Server=localhost;Database=bd_ordem_ti;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();


            atualizar_combobox();
        }

        public void atualizar_combobox()
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT nome FROM tbl_cliente";

                MySqlDataReader readerCliente = comando.ExecuteReader();

                while (readerCliente.Read())
                {
                    comboBox_clientes.Items.Add(readerCliente.GetString(0));
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            finally
            {
                conexao.Close();

            }


            try
            {
                conexao.Open();
                comando.CommandText = "SELECT nome FROM tbl_colaborador";

                MySqlDataReader readerCliente = comando.ExecuteReader();

                while (readerCliente.Read())
                {
                    comboBox_colaboradores.Items.Add(readerCliente.GetString(0));
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            finally
            {
                conexao.Close();

            }



            try
            {
                conexao.Open();
                comando.CommandText = "SELECT endereco FROM tbl_cliente";

                MySqlDataReader readerColaborador = comando.ExecuteReader();

                while (readerColaborador.Read())
                {
                    textBoxENDERECO.Text = (readerColaborador.GetString(0));
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            finally
            {
                conexao.Close();

            }
        }


        private void button_CRIAR_Click(object sender, EventArgs e)
        {

            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO tbl_servico(data_entrada, data_saida, equipamento, orcamento, status) VALUES ('"+ textBoxDATAENTRADA.Text + "', '" + textBoxDATASAIDA.Text + "', '" + textBoxEQUIP.Text + "', '" + textBoxORCAMENTO.Text + "', '" + textBoxSTATUS.Text + "'); ";

                MySqlDataReader readerCliente = comando.ExecuteReader();

                while (readerCliente.Read())
                {
                    comboBox_clientes.Items.Add(readerCliente.GetString(0));
                    MessageBox.Show("Deu certo");
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            finally
            {
                conexao.Close();
            }
        }

        private void comboBox_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
