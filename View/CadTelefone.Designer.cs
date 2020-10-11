namespace View
{
    partial class CadTelefone
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(97, 27);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(237, 20);
            this.txtConsulta.TabIndex = 1;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(97, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(237, 20);
            this.txtNome.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Telefone});
            this.grid.Location = new System.Drawing.Point(47, 137);
            this.grid.Name = "grid";
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(287, 150);
            this.grid.TabIndex = 6;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_cellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 44;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // BtnInserir
            // 
            this.BtnInserir.Location = new System.Drawing.Point(69, 298);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(75, 23);
            this.BtnInserir.TabIndex = 7;
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(150, 298);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 8;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(231, 298);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 9;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(97, 105);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(106, 20);
            this.txtTelefone.TabIndex = 3;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(97, 53);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(237, 20);
            this.txtID.TabIndex = 11;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(40, 53);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(19, 13);
            this.LblId.TabIndex = 10;
            this.LblId.Text = "Id:";
            // 
            // CadTelefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 347);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnInserir);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadTelefone";
            this.Text = "Cadastro de Telefone";
            this.Load += new System.EventHandler(this.CadTelefone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
    }
}

