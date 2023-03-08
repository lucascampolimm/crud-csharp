using crud_c_sharp_sqlite.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_c_sharp_sqlite.UI
{
    public partial class BuscarEstudante : Form
    {
        GerenciarEstudante _gerenciarEstudante = new GerenciarEstudante();
        formEstudante update;

        // É necessário realizar um update para buscar um aluno.
        public BuscarEstudante(formEstudante update)
        {
            InitializeComponent();
            this.update = update;
        }
        // 
        private void updateButton_Click(object sender, EventArgs e)
        {
            // Libera a janela logo que faz o update.
            Dispose();
        }
        // Método para buscar um aluno por ID.
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int achou = 0;
                int id = Int32.Parse(idTextBox.Text);
                GerenciarEstudante studentManager = new GerenciarEstudante();
                var estudantes = studentManager.GetAll();
                foreach (var estudante in estudantes)
                {
                    if (estudante.Id == id)
                    {
                        achou = 1;
                        // Botão de deletar ativo porque teve resultados na busca pelo aluno.
                        deleteInfo.Enabled = true;
                        nameTextBox.Text = estudante.Name;
                        fatherNameTextBox.Text = estudante.FatherName;
                        addressTextBox.Text = estudante.Address;
                        break;
                    }
                }
                if (achou == 0)
                {
                    // Botão desativado porque não tem como apagar algo que não existe.
                    deleteInfo.Enabled = false;
                    MessageBox.Show("Não existem registros com esse ID! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Você não digitou um ID válido! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Botão deletar começa desabilitado porque é preciso buscar primeiro para depois apagar.
            deleteInfo.Enabled = false;
        }

        // Função que deleta o cidadão do DB.
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Você deseja deletar? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes &&
                    nameTextBox.Text.Length > 0)
                {
                    int id = Int32.Parse(idTextBox.Text);
                    bool isDelete = _gerenciarEstudante.Delete(id);
                    if (isDelete)
                    {
                        MessageBox.Show("Estudante foi removido! ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        update.LoadData();
                        deleteInfo.Enabled = false;
                        nameTextBox.Text = string.Empty;
                        fatherNameTextBox.Text = string.Empty;
                        addressTextBox.Text = string.Empty;
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
    }
}
