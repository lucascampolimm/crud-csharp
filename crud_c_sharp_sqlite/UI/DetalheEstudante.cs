using crud_c_sharp_sqlite.Manager;
using crud_c_sharp_sqlite.Models;
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
    public partial class DetalheEstudante : Form
    {

        formEstudante update;
        // Inicializa a janela dando upadate.
        public DetalheEstudante(formEstudante update)
        {
            InitializeComponent();
            this.update = update;
        }
        GerenciarEstudante _gerenciarEstudante = new GerenciarEstudante();

        // Método para fazer update.
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Digite o nome do estudante ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("DIgite o endereço ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    addressTextBox.Focus();
                    return;
                }
                Estudante estudante = new Estudante();
                estudante.Id = Convert.ToInt32(idLabel.Text);
                estudante.Name = nameTextBox.Text;
                estudante.FatherName = fatherNameTextBox.Text;
                estudante.Address = addressTextBox.Text;
                if (_gerenciarEstudante.Update(estudante))
                {
                    MessageBox.Show("Dados modificados ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    update.LoadData();
                }
                else
                {
                    MessageBox.Show("Falha ao modificar estudante ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Descarta a janela caso o usuário clique em cancelar.
        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
