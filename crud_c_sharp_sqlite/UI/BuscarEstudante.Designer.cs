namespace crud_c_sharp_sqlite.UI
{
    partial class BuscarEstudante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            deleteInfo = new Button();
            button1 = new Button();
            idTextBox = new TextBox();
            label4 = new Label();
            idLabel = new Label();
            updateButton = new Button();
            addressTextBox = new TextBox();
            fatherNameTextBox = new TextBox();
            label3 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(deleteInfo);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(idTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(idLabel);
            groupBox1.Controls.Add(updateButton);
            groupBox1.Controls.Add(addressTextBox);
            groupBox1.Controls.Add(fatherNameTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 10);
            groupBox1.Margin = new Padding(1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1);
            groupBox1.Size = new Size(410, 204);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informação do Estudante";
            // 
            // deleteInfo
            // 
            deleteInfo.Enabled = false;
            deleteInfo.Location = new Point(240, 45);
            deleteInfo.Margin = new Padding(1);
            deleteInfo.Name = "deleteInfo";
            deleteInfo.Size = new Size(77, 29);
            deleteInfo.TabIndex = 3;
            deleteInfo.Text = "Deletar";
            deleteInfo.UseVisualStyleBackColor = true;
            deleteInfo.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(319, 45);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(77, 29);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(117, 45);
            idTextBox.Margin = new Padding(1);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(121, 29);
            idTextBox.TabIndex = 1;
            idTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 43);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(25, 21);
            label4.TabIndex = 11;
            label4.Text = "ID";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(315, 19);
            idLabel.Margin = new Padding(1, 0, 1, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(0, 21);
            idLabel.TabIndex = 10;
            idLabel.Visible = false;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(319, 175);
            updateButton.Margin = new Padding(1);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(77, 29);
            updateButton.TabIndex = 4;
            updateButton.Text = "OK";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // addressTextBox
            // 
            addressTextBox.Enabled = false;
            addressTextBox.Location = new Point(117, 139);
            addressTextBox.Margin = new Padding(1);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(279, 29);
            addressTextBox.TabIndex = 6;
            // 
            // fatherNameTextBox
            // 
            fatherNameTextBox.Enabled = false;
            fatherNameTextBox.Location = new Point(117, 108);
            fatherNameTextBox.Margin = new Padding(1);
            fatherNameTextBox.Name = "fatherNameTextBox";
            fatherNameTextBox.Size = new Size(279, 29);
            fatherNameTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 139);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 3;
            label3.Text = "Endereço";
            // 
            // nameTextBox
            // 
            nameTextBox.Enabled = false;
            nameTextBox.Location = new Point(117, 76);
            nameTextBox.Margin = new Padding(1);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(279, 29);
            nameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 108);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 4;
            label2.Text = "Nome do Pai";        
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 75);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // BuscarEstudante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 224);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BuscarEstudante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Estudante";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        public Label idLabel;
        private Button updateButton;
        public TextBox addressTextBox;
        public TextBox fatherNameTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox idTextBox;
        private Label label4;
        private Button button1;
        private TextBox nameTextBox;
        private Button deleteInfo;
    }
}