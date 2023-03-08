namespace crud_c_sharp_sqlite
{
    partial class formEstudante
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEstudante));
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            editionButton = new Button();
            pictureBox1 = new PictureBox();
            studentDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            FatherName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            saveButton = new Button();
            addressTextBox = new TextBox();
            fatherNameTextBox = new TextBox();
            label3 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(editionButton);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(studentDataGridView);
            groupBox1.Controls.Add(saveButton);
            groupBox1.Controls.Add(addressTextBox);
            groupBox1.Controls.Add(fatherNameTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // editionButton
            // 
            resources.ApplyResources(editionButton, "editionButton");
            editionButton.Name = "editionButton";
            editionButton.UseVisualStyleBackColor = true;
            editionButton.Click += button1_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // studentDataGridView
            // 
            resources.ApplyResources(studentDataGridView, "studentDataGridView");
            studentDataGridView.AllowUserToAddRows = false;
            studentDataGridView.AllowUserToDeleteRows = false;
            studentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Name, FatherName, Address });
            studentDataGridView.ContextMenuStrip = contextMenuStrip1;
            studentDataGridView.Name = "studentDataGridView";
            studentDataGridView.RowHeadersVisible = false;
            studentDataGridView.RowTemplate.Height = 49;
            studentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentDataGridView.RowHeaderMouseDoubleClick += studentDataGridView_RowHeaderMouseDoubleClick;
            // 
            // Id
            // 
            resources.ApplyResources(Id, "Id");
            Id.Name = "Id";
            // 
            // Name
            // 
            resources.ApplyResources(Name, "Name");
            Name.Name = "Name";
            // 
            // FatherName
            // 
            resources.ApplyResources(FatherName, "FatherName");
            FatherName.Name = "FatherName";
            // 
            // Address
            // 
            resources.ApplyResources(Address, "Address");
            Address.Name = "Address";
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(contextMenuStrip1, "contextMenuStrip1");
            contextMenuStrip1.ImageScalingSize = new Size(40, 40);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // deleteToolStripMenuItem
            // 
            resources.ApplyResources(deleteToolStripMenuItem, "deleteToolStripMenuItem");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // saveButton
            // 
            resources.ApplyResources(saveButton, "saveButton");
            saveButton.Name = "saveButton";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // addressTextBox
            // 
            resources.ApplyResources(addressTextBox, "addressTextBox");
            addressTextBox.Name = "addressTextBox";
            // 
            // fatherNameTextBox
            // 
            resources.ApplyResources(fatherNameTextBox, "fatherNameTextBox");
            fatherNameTextBox.Name = "fatherNameTextBox";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // nameTextBox
            // 
            resources.ApplyResources(nameTextBox, "nameTextBox");
            nameTextBox.Name = "nameTextBox";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // formEstudante
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name.Name = "formEstudante";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox nameTextBox;
        private Label label1;
        private TextBox addressTextBox;
        private TextBox fatherNameTextBox;
        private Label label3;
        private Label label2;
        private Button saveButton;
        private DataGridView studentDataGridView;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Id;
#pragma warning disable CS0108 // O membro oculta o membro herdado; nova palavra-chave ausente
        private DataGridViewTextBoxColumn Name;
#pragma warning restore CS0108 // O membro oculta o membro herdado; nova palavra-chave ausente
        private DataGridViewTextBoxColumn FatherName;
        private DataGridViewTextBoxColumn Address;
        private Button editionButton;
        private Button button1;
        private Button button2;
    }
}