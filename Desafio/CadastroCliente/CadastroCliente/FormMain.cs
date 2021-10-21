using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class FormMain : Form
    {
        private string constring = String.Format("Server={0};Port={1};"+
            "User Id={2};Password={3};Database={4};",
            "localhost",5432,"postgres",
            "01234", "DB_CLIENTES");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int rowIndex = -1;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(constring);
            select();
        }
        private void select()
        {
            try
            {
                conn.Open();
                sql = @"select * from tcc_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                DGVData.DataSource = null;
                DGVData.DataSource = dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
                
            } 

        }

        private void BTInsert_Click(object sender, EventArgs e)
        {
            rowIndex = -1;
            BTEdit.BackColor = Color.White;
            BTInsert.BackColor = Color.Silver;
            TBNome.Enabled = TBCNPJ.Enabled = TBCNPJ.Enabled = true;
            TBNome.Text = TBCNPJ.Text = TBCNPJ.Text = null;
            TBNome.Select();
        }

        private void BTEdit_Click(object sender, EventArgs e)
        {
            if (rowIndex<0)
            {
                MessageBox.Show("Por favor selecione um cliente para atualizar");
                return;
            }
            BTEdit.BackColor = Color.Silver;
            BTInsert.BackColor = Color.White;
            TBNome.Enabled = TBCNPJ.Enabled = TBCNPJ.Enabled = true;
        }

        private void BTDelete_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Por favor selecione um cliente para excluir");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from tcc_delete(:_codigo)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_codigo", int.Parse(DGVData.Rows[rowIndex].Cells["codigo"].Value.ToString()));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    rowIndex = -1;
                }
                conn.Close();
                MessageBox.Show("Cliente excluido com sucesso");
                select();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Falha ao excluir - Erro: "+ ex.Message);
            }
        }

        private void BTSave_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (rowIndex<0)
            {
                conn.Open();
                sql = $@"select * from tb_cadastro_cliente where tcc_cnpj = '{TBCNPJ.Text}'";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                result = dt.Rows.Count;
                conn.Close();
                if (result >= 1)
                {
                    MessageBox.Show("CNPJ ja existe");

                }
                else
                {
                    try
                    {
                        conn.Open();
                        sql = @"select * from tcc_insert(:_nome, :_cnpj, :_data_cadastro, :_endereco, :_telefone)";
                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("_nome", TBNome.Text);
                        cmd.Parameters.AddWithValue("_cnpj", TBCNPJ.Text);
                        cmd.Parameters.AddWithValue("_data_cadastro", DateTime.Today);
                        cmd.Parameters.AddWithValue("_endereco", TBEndereco.Text);
                        cmd.Parameters.AddWithValue("_telefone", TBTelefone.Text);
                        result = (int)cmd.ExecuteScalar();
                        conn.Close();
                        if (result == 1)
                        {
                            select();
                            MessageBox.Show("Cliente inserido com sucesso");

                        }
                        else
                        {
                            MessageBox.Show("Falha ao inserir");
                        }

                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("Falha ao inserir - Erro: " + ex.Message);
                    }
                }
            }
            else
            {
                conn.Open();
                sql = $@"select * from tb_cadastro_cliente where tcc_cnpj = '{TBCNPJ.Text}'";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                result = dt.Rows.Count;
                conn.Close();
                if (result >= 2)
                {
                    MessageBox.Show("CNPJ ja existe");

                }
                else
                {
                    try
                    {
                        conn.Open();
                        sql = @"select * From tcc_update(:_codigo, :_nome, :_cnpj, :_data_cadastro, :_endereco, :_telefone)";
                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("_codigo", int.Parse(DGVData.Rows[rowIndex].Cells["codigo"].Value.ToString()));
                        cmd.Parameters.AddWithValue("_nome", TBNome.Text);
                        cmd.Parameters.AddWithValue("_cnpj", TBCNPJ.Text);
                        cmd.Parameters.AddWithValue("_data_cadastro", DateTime.Today);
                        cmd.Parameters.AddWithValue("_endereco", TBEndereco.Text);
                        cmd.Parameters.AddWithValue("_telefone", TBTelefone.Text);
                        result = (int)cmd.ExecuteScalar();
                        conn.Close();
                        if (result == 1)
                        {
                            select();
                            MessageBox.Show("Atualizado com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao atualizar");
                        }

                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("Falha ao atualizar - Erro: " + ex.Message);
                    }
                }
            }
            result = 0;
            TBNome.Text = TBCNPJ.Text = TBCNPJ.Text = null;
            TBNome.Enabled = TBCNPJ.Enabled = TBCNPJ.Enabled = false;
            BTEdit.BackColor = Color.White;
            BTInsert.BackColor = Color.White;
        }

        private void DGVData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                TBNome.Text = DGVData.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                TBCNPJ.Text = DGVData.Rows[e.RowIndex].Cells["cnpj"].Value.ToString();
                TBEndereco.Text = DGVData.Rows[e.RowIndex].Cells["endereco"].Value.ToString();
                TBTelefone.Text = DGVData.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            }
        }
    }
}
