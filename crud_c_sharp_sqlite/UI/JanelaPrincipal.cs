using crud_c_sharp_sqlite.Manager;
using crud_c_sharp_sqlite.Migrations;
using crud_c_sharp_sqlite.Models;
using crud_c_sharp_sqlite.UI;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;

namespace crud_c_sharp_sqlite
{
    public partial class formEstudante : Form
    {
        public formEstudante()
        {
            // M�todo que inicializa a janela.
            InitializeComponent();
            try
            {
                // Informa a localiza��o do banco e caso ele n�o exista, ele � criado.
                string connectionString = "Data Source=C:\\Users\\lucas\\Desktop\\crud-csharp\\DB\\banco_estudantes.db;";
                // Ser� aberto uma conex�o.
                SQLiteConnection m_dbConnection = new SQLiteConnection(connectionString);
                // Chama o m�todo para abrir conex�o.
                m_dbConnection.Open();
                // Informa��es da tabela.
                string sql = "CREATE TABLE Students (\"Id\" INTEGER NOT NULL CONSTRAINT \"PK_Students\" PRIMARY KEY AUTOINCREMENT," +
                                                    "\"Name\" TEXT NOT NULL," +
                                                    "\"FatherName\" TEXT NOT NULL," +
                                                    "\"Address\" TEXT NOT NULL);";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                // Executa a query.
                command.ExecuteNonQuery();
                // Fecha conex�o.
                m_dbConnection.Close();
            }
            catch (Exception)
            {

            }

        }

        GerenciarEstudante _gerenciarEstudante = new GerenciarEstudante();

        // M�todo que carrega as informa��es para serem exibidas.
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // M�todo que percorre a vari�vel auxiliar para adicionar uma nova linha se necess�rio.
        public void LoadData()
        {
            GerenciarEstudante studentManager = new GerenciarEstudante();
            var estudantes = studentManager.GetAll();
            studentDataGridView.Rows.Clear();
            foreach (var estudante in estudantes)
            {   
                studentDataGridView.Rows.Add(estudante.Id, estudante.Name, estudante.FatherName, estudante.Address);
            }
        }

        // M�todo que obriga o usu�rio a preencher todos campos antes de fazer a inser��o no DB.
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Digite o nome do aluno ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nameTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(fatherNameTextBox.Text))
                {
                    MessageBox.Show("Digite o nome do pai ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fatherNameTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(addressTextBox.Text))
                {
                    MessageBox.Show("Digite o endere�o ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    addressTextBox.Focus();
                    return;
                }
                Estudante estudante = new Estudante();
                estudante.Name = nameTextBox.Text;
                estudante.FatherName = fatherNameTextBox.Text;
                estudante.Address = addressTextBox.Text;
                if (_gerenciarEstudante.Add(estudante))
                {
                    MessageBox.Show("Estudante foi salvo! ", "Informa��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Falha ao salvar estudante! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // M�todo para resetar os campos como vazio.
        private void Reset()
        {
            nameTextBox.Text = String.Empty;
            fatherNameTextBox.Clear();
            addressTextBox.Clear();
            LoadData();
        }

        // M�todo que permite a altera��es dos dados do alunos caso de um duplo click na linha.
        private void studentDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = studentDataGridView.SelectedRows[0];
                DetalheEstudante frm = new DetalheEstudante(this);
                frm.idLabel.Text = dr.Cells[0].Value.ToString();
                frm.nameTextBox.Text = dr.Cells[1].Value.ToString();
                frm.fatherNameTextBox.Text = dr.Cells[2].Value.ToString();
                frm.addressTextBox.Text = dr.Cells[3].Value.ToString();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // M�todo para deletar um aluno.
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = studentDataGridView.SelectedRows[0];
                if (MessageBox.Show("Voc� deseja deletar? ", "Aten��o", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dr.Cells[0].Value;
                    bool isDelete = _gerenciarEstudante.Delete(id);
                    if (isDelete)
                    {
                        MessageBox.Show("Estudante foi removido! ", "Informa��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        studentDataGridView.Rows.Remove(dr);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao remover estudante! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Faz a inser��o de um estudante.
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = studentDataGridView.SelectedRows[0];
                DetalheEstudante frm = new DetalheEstudante(this);
                frm.idLabel.Text = dr.Cells[0].Value.ToString();
                frm.nameTextBox.Text = dr.Cells[1].Value.ToString();
                frm.fatherNameTextBox.Text = dr.Cells[2].Value.ToString();
                frm.addressTextBox.Text = dr.Cells[3].Value.ToString();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Exibe a busca pelo estudante.
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                BuscarEstudante frm = new BuscarEstudante(this);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // M�todo para atualizar a tabela.
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                MessageBox.Show("Lista atualizada! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}