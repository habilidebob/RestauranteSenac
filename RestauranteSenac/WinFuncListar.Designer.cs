namespace RestauranteSenac
{
    partial class WinFuncListar
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.gpxCadastro = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbFuncaoCad = new System.Windows.Forms.TextBox();
            this.lblFuncaoCad = new System.Windows.Forms.Label();
            this.txbSetorCad = new System.Windows.Forms.TextBox();
            this.lblSetorCad = new System.Windows.Forms.Label();
            this.txbTelCad = new System.Windows.Forms.MaskedTextBox();
            this.lblTelCad = new System.Windows.Forms.Label();
            this.txbEmailCad = new System.Windows.Forms.TextBox();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.gpxEditar = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbNomeEd = new System.Windows.Forms.TextBox();
            this.txbFuncaoEd = new System.Windows.Forms.TextBox();
            this.lblNomeEd = new System.Windows.Forms.Label();
            this.lblFuncaoEd = new System.Windows.Forms.Label();
            this.lblEmailEd = new System.Windows.Forms.Label();
            this.txbSetorEd = new System.Windows.Forms.TextBox();
            this.txbEmailEd = new System.Windows.Forms.TextBox();
            this.lblSetorEd = new System.Windows.Forms.Label();
            this.lblTelefoneEd = new System.Windows.Forms.Label();
            this.txbTelEd = new System.Windows.Forms.MaskedTextBox();
            this.btnPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.gpxCadastro.SuspendLayout();
            this.gpxEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(284, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(213, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Funcionários :: Listar";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToResizeColumns = false;
            this.dgvFuncionarios.AllowUserToResizeRows = false;
            this.dgvFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFuncionarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(22, 61);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.Size = new System.Drawing.Size(718, 206);
            this.dgvFuncionarios.TabIndex = 1;
            this.dgvFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellContentClick);
            this.dgvFuncionarios.SelectionChanged += new System.EventHandler(this.dgvFuncionarios_SelectionChanged);
            // 
            // gpxCadastro
            // 
            this.gpxCadastro.Controls.Add(this.btnCadastrar);
            this.gpxCadastro.Controls.Add(this.txbFuncaoCad);
            this.gpxCadastro.Controls.Add(this.lblFuncaoCad);
            this.gpxCadastro.Controls.Add(this.txbSetorCad);
            this.gpxCadastro.Controls.Add(this.lblSetorCad);
            this.gpxCadastro.Controls.Add(this.txbTelCad);
            this.gpxCadastro.Controls.Add(this.lblTelCad);
            this.gpxCadastro.Controls.Add(this.txbEmailCad);
            this.gpxCadastro.Controls.Add(this.lblEmailCad);
            this.gpxCadastro.Controls.Add(this.txbNomeCad);
            this.gpxCadastro.Controls.Add(this.lblNomeCad);
            this.gpxCadastro.Location = new System.Drawing.Point(22, 273);
            this.gpxCadastro.Name = "gpxCadastro";
            this.gpxCadastro.Size = new System.Drawing.Size(309, 198);
            this.gpxCadastro.TabIndex = 2;
            this.gpxCadastro.TabStop = false;
            this.gpxCadastro.Text = "Cadastro";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(9, 152);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(284, 40);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbFuncaoCad
            // 
            this.txbFuncaoCad.Location = new System.Drawing.Point(60, 126);
            this.txbFuncaoCad.Name = "txbFuncaoCad";
            this.txbFuncaoCad.Size = new System.Drawing.Size(233, 20);
            this.txbFuncaoCad.TabIndex = 9;
            // 
            // lblFuncaoCad
            // 
            this.lblFuncaoCad.AutoSize = true;
            this.lblFuncaoCad.Location = new System.Drawing.Point(6, 129);
            this.lblFuncaoCad.Name = "lblFuncaoCad";
            this.lblFuncaoCad.Size = new System.Drawing.Size(46, 13);
            this.lblFuncaoCad.TabIndex = 8;
            this.lblFuncaoCad.Text = "Função:";
            // 
            // txbSetorCad
            // 
            this.txbSetorCad.Location = new System.Drawing.Point(60, 100);
            this.txbSetorCad.Name = "txbSetorCad";
            this.txbSetorCad.Size = new System.Drawing.Size(233, 20);
            this.txbSetorCad.TabIndex = 7;
            // 
            // lblSetorCad
            // 
            this.lblSetorCad.AutoSize = true;
            this.lblSetorCad.Location = new System.Drawing.Point(6, 103);
            this.lblSetorCad.Name = "lblSetorCad";
            this.lblSetorCad.Size = new System.Drawing.Size(35, 13);
            this.lblSetorCad.TabIndex = 6;
            this.lblSetorCad.Text = "Setor:";
            // 
            // txbTelCad
            // 
            this.txbTelCad.Location = new System.Drawing.Point(60, 74);
            this.txbTelCad.Mask = "(99) 00000-0000";
            this.txbTelCad.Name = "txbTelCad";
            this.txbTelCad.Size = new System.Drawing.Size(233, 20);
            this.txbTelCad.TabIndex = 5;
            // 
            // lblTelCad
            // 
            this.lblTelCad.AutoSize = true;
            this.lblTelCad.Location = new System.Drawing.Point(6, 77);
            this.lblTelCad.Name = "lblTelCad";
            this.lblTelCad.Size = new System.Drawing.Size(52, 13);
            this.lblTelCad.TabIndex = 4;
            this.lblTelCad.Text = "Telefone:";
            // 
            // txbEmailCad
            // 
            this.txbEmailCad.Location = new System.Drawing.Point(60, 48);
            this.txbEmailCad.Name = "txbEmailCad";
            this.txbEmailCad.Size = new System.Drawing.Size(233, 20);
            this.txbEmailCad.TabIndex = 3;
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.Location = new System.Drawing.Point(6, 51);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(35, 13);
            this.lblEmailCad.TabIndex = 2;
            this.lblEmailCad.Text = "Email:";
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Location = new System.Drawing.Point(60, 22);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(233, 20);
            this.txbNomeCad.TabIndex = 1;
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Location = new System.Drawing.Point(6, 25);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCad.TabIndex = 0;
            this.lblNomeCad.Text = "Nome:";
            // 
            // gpxEditar
            // 
            this.gpxEditar.Controls.Add(this.btnExcluir);
            this.gpxEditar.Controls.Add(this.btnEditar);
            this.gpxEditar.Controls.Add(this.txbNomeEd);
            this.gpxEditar.Controls.Add(this.txbFuncaoEd);
            this.gpxEditar.Controls.Add(this.lblNomeEd);
            this.gpxEditar.Controls.Add(this.lblFuncaoEd);
            this.gpxEditar.Controls.Add(this.lblEmailEd);
            this.gpxEditar.Controls.Add(this.txbSetorEd);
            this.gpxEditar.Controls.Add(this.txbEmailEd);
            this.gpxEditar.Controls.Add(this.lblSetorEd);
            this.gpxEditar.Controls.Add(this.lblTelefoneEd);
            this.gpxEditar.Controls.Add(this.txbTelEd);
            this.gpxEditar.Location = new System.Drawing.Point(431, 273);
            this.gpxEditar.Name = "gpxEditar";
            this.gpxEditar.Size = new System.Drawing.Size(309, 198);
            this.gpxEditar.TabIndex = 3;
            this.gpxEditar.TabStop = false;
            this.gpxEditar.Text = "Editar";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(18, 149);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(96, 40);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(120, 149);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(182, 40);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbNomeEd
            // 
            this.txbNomeEd.Location = new System.Drawing.Point(69, 19);
            this.txbNomeEd.Name = "txbNomeEd";
            this.txbNomeEd.Size = new System.Drawing.Size(233, 20);
            this.txbNomeEd.TabIndex = 12;
            // 
            // txbFuncaoEd
            // 
            this.txbFuncaoEd.Location = new System.Drawing.Point(69, 123);
            this.txbFuncaoEd.Name = "txbFuncaoEd";
            this.txbFuncaoEd.Size = new System.Drawing.Size(233, 20);
            this.txbFuncaoEd.TabIndex = 20;
            // 
            // lblNomeEd
            // 
            this.lblNomeEd.AutoSize = true;
            this.lblNomeEd.Location = new System.Drawing.Point(15, 22);
            this.lblNomeEd.Name = "lblNomeEd";
            this.lblNomeEd.Size = new System.Drawing.Size(38, 13);
            this.lblNomeEd.TabIndex = 11;
            this.lblNomeEd.Text = "Nome:";
            // 
            // lblFuncaoEd
            // 
            this.lblFuncaoEd.AutoSize = true;
            this.lblFuncaoEd.Location = new System.Drawing.Point(15, 126);
            this.lblFuncaoEd.Name = "lblFuncaoEd";
            this.lblFuncaoEd.Size = new System.Drawing.Size(46, 13);
            this.lblFuncaoEd.TabIndex = 19;
            this.lblFuncaoEd.Text = "Função:";
            // 
            // lblEmailEd
            // 
            this.lblEmailEd.AutoSize = true;
            this.lblEmailEd.Location = new System.Drawing.Point(15, 48);
            this.lblEmailEd.Name = "lblEmailEd";
            this.lblEmailEd.Size = new System.Drawing.Size(35, 13);
            this.lblEmailEd.TabIndex = 13;
            this.lblEmailEd.Text = "Email:";
            // 
            // txbSetorEd
            // 
            this.txbSetorEd.Location = new System.Drawing.Point(69, 97);
            this.txbSetorEd.Name = "txbSetorEd";
            this.txbSetorEd.Size = new System.Drawing.Size(233, 20);
            this.txbSetorEd.TabIndex = 18;
            // 
            // txbEmailEd
            // 
            this.txbEmailEd.Location = new System.Drawing.Point(69, 45);
            this.txbEmailEd.Name = "txbEmailEd";
            this.txbEmailEd.Size = new System.Drawing.Size(233, 20);
            this.txbEmailEd.TabIndex = 14;
            // 
            // lblSetorEd
            // 
            this.lblSetorEd.AutoSize = true;
            this.lblSetorEd.Location = new System.Drawing.Point(15, 100);
            this.lblSetorEd.Name = "lblSetorEd";
            this.lblSetorEd.Size = new System.Drawing.Size(35, 13);
            this.lblSetorEd.TabIndex = 17;
            this.lblSetorEd.Text = "Setor:";
            // 
            // lblTelefoneEd
            // 
            this.lblTelefoneEd.AutoSize = true;
            this.lblTelefoneEd.Location = new System.Drawing.Point(15, 74);
            this.lblTelefoneEd.Name = "lblTelefoneEd";
            this.lblTelefoneEd.Size = new System.Drawing.Size(52, 13);
            this.lblTelefoneEd.TabIndex = 15;
            this.lblTelefoneEd.Text = "Telefone:";
            // 
            // txbTelEd
            // 
            this.txbTelEd.Location = new System.Drawing.Point(69, 71);
            this.txbTelEd.Mask = "(99) 00000-0000";
            this.txbTelEd.Name = "txbTelEd";
            this.txbTelEd.Size = new System.Drawing.Size(233, 20);
            this.txbTelEd.TabIndex = 16;
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(638, 32);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(102, 23);
            this.btnPDF.TabIndex = 4;
            this.btnPDF.Text = "Exportar PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // WinFuncListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 483);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.gpxEditar);
            this.Controls.Add(this.gpxCadastro);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.lblTitulo);
            this.Name = "WinFuncListar";
            this.Text = "Funcionários :: Listar";
            this.Load += new System.EventHandler(this.WinFuncListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.gpxCadastro.ResumeLayout(false);
            this.gpxCadastro.PerformLayout();
            this.gpxEditar.ResumeLayout(false);
            this.gpxEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.GroupBox gpxCadastro;
        private System.Windows.Forms.MaskedTextBox txbTelCad;
        private System.Windows.Forms.Label lblTelCad;
        private System.Windows.Forms.TextBox txbEmailCad;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.GroupBox gpxEditar;
        private System.Windows.Forms.TextBox txbSetorCad;
        private System.Windows.Forms.Label lblSetorCad;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbFuncaoCad;
        private System.Windows.Forms.Label lblFuncaoCad;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbNomeEd;
        private System.Windows.Forms.TextBox txbFuncaoEd;
        private System.Windows.Forms.Label lblNomeEd;
        private System.Windows.Forms.Label lblFuncaoEd;
        private System.Windows.Forms.Label lblEmailEd;
        private System.Windows.Forms.TextBox txbSetorEd;
        private System.Windows.Forms.TextBox txbEmailEd;
        private System.Windows.Forms.Label lblSetorEd;
        private System.Windows.Forms.Label lblTelefoneEd;
        private System.Windows.Forms.MaskedTextBox txbTelEd;
        private System.Windows.Forms.Button btnPDF;
    }
}