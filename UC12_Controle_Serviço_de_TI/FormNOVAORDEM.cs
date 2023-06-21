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

            servidor = "Server=10.55.51.1;Database=ordem_servico;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();


            atualizar_combobox();
        }

        public void atualizar_combobox()
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT nome FROM cliente";

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
                comando.CommandText = "SELECT nome FROM colaborador";

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
                comando.CommandText = "SELECT endereco FROM colaborador";

                MySqlDataReader readerColaborador = comando.ExecuteReader();

                while (readerColaborador.Read())
                {
                    comboBox_endereco.Items.Add(readerColaborador.GetString(0));
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
                comando.CommandText = "SELECT marca FROM equipamento";

                MySqlDataReader readerMarca = comando.ExecuteReader();

                while (readerMarca.Read())
                {
                    comboBox_marca.Items.Add(readerMarca.GetString(0));
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
                comando.CommandText = "SELECT modelo FROM equipamento";

                MySqlDataReader readerModelo = comando.ExecuteReader();

                while (readerModelo.Read())
                {
                    comboBox_Modelo.Items.Add(readerModelo.GetString(0));
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
                comando.CommandText = "INSERT INTO equipamento(entrada_equipamento, retirada_equipamento, marca, modelo) VALUES ('"+ textBoxDATAENTRADA.Text + "', '" + textBoxDATASAIDA.Text + "', '" + comboBox_marca.Text + "', '" + comboBox_Modelo.Text + "'); ";

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
                comando.CommandText = "INSERT INTO orcamento(valor_total) VALUES ('" + textBoxORCAMENTO + "'); ";

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
                comando.CommandText = "INSERT into ordem_de_servico (entrada_equipamento, retirada_equipamento, marca, modelo) VALUES ('" + textBoxDATAENTRADA + "', '" + textBoxDATASAIDA + "', '" + comboBox_marca.Text + "', '" + comboBox_Modelo.Text + "', ); ";

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

        }

        private void comboBox_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
