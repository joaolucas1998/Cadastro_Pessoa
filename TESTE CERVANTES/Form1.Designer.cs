namespace TESTE_CERVANTES
{
    partial class Form1
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
            dgPessoa = new DataGridView();
            labelID = new Label();
            txtID = new TextBox();
            txtNome = new TextBox();
            labelNome = new Label();
            txtCpf = new TextBox();
            labelCpf = new Label();
            txtIdade = new TextBox();
            labelIdade = new Label();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPessoa).BeginInit();
            SuspendLayout();
            // 
            // dgPessoa
            // 
            dgPessoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPessoa.Location = new Point(1, 210);
            dgPessoa.Name = "dgPessoa";
            dgPessoa.Size = new Size(480, 150);
            dgPessoa.TabIndex = 0;
            dgPessoa.CellClick += dgPessoa_CellClick;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(29, 24);
            labelID.Name = "labelID";
            labelID.Size = new Size(18, 15);
            labelID.TabIndex = 1;
            labelID.Text = "ID";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(29, 42);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(168, 42);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(299, 23);
            txtNome.TabIndex = 4;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(168, 24);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 3;
            labelNome.Text = "Nome";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(168, 106);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(299, 23);
            txtCpf.TabIndex = 6;
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(168, 88);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(28, 15);
            labelCpf.TabIndex = 5;
            labelCpf.Text = "CPF";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(29, 106);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 23);
            txtIdade.TabIndex = 8;
            // 
            // labelIdade
            // 
            labelIdade.AutoSize = true;
            labelIdade.Location = new Point(29, 88);
            labelIdade.Name = "labelIdade";
            labelIdade.Size = new Size(36, 15);
            labelIdade.TabIndex = 7;
            labelIdade.Text = "Idade";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(116, 169);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(66, 23);
            btnAdicionar.TabIndex = 9;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(220, 169);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(66, 23);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(321, 169);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(66, 23);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 372);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtIdade);
            Controls.Add(labelIdade);
            Controls.Add(txtCpf);
            Controls.Add(labelCpf);
            Controls.Add(txtNome);
            Controls.Add(labelNome);
            Controls.Add(txtID);
            Controls.Add(labelID);
            Controls.Add(dgPessoa);
            Name = "Form1";
            Text = "CADASTRO CLIENTES";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgPessoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgPessoa;
        private Label labelID;
        private TextBox txtID;
        private TextBox txtNome;
        private Label labelNome;
        private TextBox txtCpf;
        private Label labelCpf;
        private TextBox txtIdade;
        private Label labelIdade;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnExcluir;
    }
}
