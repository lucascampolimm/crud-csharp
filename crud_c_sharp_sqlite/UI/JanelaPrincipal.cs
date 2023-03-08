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
            // Método que inicializa a janela.
            InitializeComponent();
            try
            {
                // Informa a localização do banco e caso ele não exista, ele é criado.
                string connectionString = "Data Source=C:\\Users\\lucas\\Desktop\\crud-csharp\\DB\\banco_estudantes.db;";
                // Será aberto uma conexão.
                SQLiteConnection m_dbConnection = new SQLiteConnection(connectionString);
                // Chama o método para abrir conexão.
                m_dbConnection.Open();
                // Informações da tabela.
                string sql = "CREATE TABLE Students (\"Id\" INTEGER NOT NULL CONSTRAINT \"PK_Students\" PRIMARY KEY AUTOINCREMENT," +
                                                    "\"Name\" TEXT NOT NULL," +
                                                    "\"FatherName\" TEXT NOT NULL," +
                                                    "\"Address\" TEXT NOT NULL);";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                // Executa a query.
                command.ExecuteNonQuery();
                // Fecha conexão.
                m_dbConnection.Close();
            }
            catch (Exception)
            {

            }

        }

        GerenciarEstudante _gerenciarEstudante = new GerenciarEstudante();

        // Método que carrega as informações para serem exibidas.
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

        // Método que percorre a variável auxiliar para adicionar uma nova linha se necessário.
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

        // Método que obriga o usuário a preencher todos campos antes de fazer a inserção no DB.
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
                    MessageBox.Show("Digite o endereço ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    addressTextBox.Focus();
                    return;
                }
                Estudante estudante = new Estudante();
                estudante.Name = nameTextBox.Text;
                estudante.FatherName = fatherNameTextBox.Text;
                estudante.Address = addressTextBox.Text;
                if (_gerenciarEstudante.Add(estudante))
                {
                    MessageBox.Show("Estudante foi salvo! ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // Método para resetar os campos como vazio.
        private void Reset()
        {
            nameTextBox.Text = String.Empty;
            fatherNameTextBox.Clear();
            addressTextBox.Clear();
            LoadData();
        }

        // Método que permite a alterações dos dados do alunos caso de um duplo click na linha.
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

        // Método para deletar um aluno.
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = studentDataGridView.SelectedRows[0];
                if (MessageBox.Show("Você deseja deletar? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dr.Cells[0].Value;
                    bool isDelete = _gerenciarEstudante.Delete(id);
                    if (isDelete)
                    {
                        MessageBox.Show("Estudante foi removido! ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        // Faz a inserção de um estudante.
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

        // Método para atualizar a tabela.
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