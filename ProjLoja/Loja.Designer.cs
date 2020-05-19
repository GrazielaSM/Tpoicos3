namespace Loja
{
    partial class FrLoja
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
            this.lbIdLoja = new System.Windows.Forms.Label();
            this.lbNomeLoja = new System.Windows.Forms.Label();
            this.lbCnpj = new System.Windows.Forms.Label();
            this.tbIdLoja = new System.Windows.Forms.TextBox();
            this.tbNomeLoja = new System.Windows.Forms.TextBox();
            this.tbCnpj = new System.Windows.Forms.TextBox();
            this.dgvLoja = new System.Windows.Forms.DataGridView();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoja)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIdLoja
            // 
            this.lbIdLoja.AutoSize = true;
            this.lbIdLoja.Location = new System.Drawing.Point(41, 43);
            this.lbIdLoja.Name = "lbIdLoja";
            this.lbIdLoja.Size = new System.Drawing.Size(53, 20);
            this.lbIdLoja.TabIndex = 0;
            this.lbIdLoja.Text = "IdLoja";
            // 
            // lbNomeLoja
            // 
            this.lbNomeLoja.AutoSize = true;
            this.lbNomeLoja.Location = new System.Drawing.Point(41, 100);
            this.lbNomeLoja.Name = "lbNomeLoja";
            this.lbNomeLoja.Size = new System.Drawing.Size(81, 20);
            this.lbNomeLoja.TabIndex = 1;
            this.lbNomeLoja.Text = "NomeLoja";
            // 
            // lbCnpj
            // 
            this.lbCnpj.AutoSize = true;
            this.lbCnpj.Location = new System.Drawing.Point(41, 165);
            this.lbCnpj.Name = "lbCnpj";
            this.lbCnpj.Size = new System.Drawing.Size(41, 20);
            this.lbCnpj.TabIndex = 2;
            this.lbCnpj.Text = "Cnpj";
            // 
            // tbIdLoja
            // 
            this.tbIdLoja.Location = new System.Drawing.Point(127, 50);
            this.tbIdLoja.Name = "tbIdLoja";
            this.tbIdLoja.Size = new System.Drawing.Size(326, 26);
            this.tbIdLoja.TabIndex = 3;
            // 
            // tbNomeLoja
            // 
            this.tbNomeLoja.Location = new System.Drawing.Point(135, 104);
            this.tbNomeLoja.Name = "tbNomeLoja";
            this.tbNomeLoja.Size = new System.Drawing.Size(318, 26);
            this.tbNomeLoja.TabIndex = 4;
            // 
            // tbCnpj
            // 
            this.tbCnpj.Location = new System.Drawing.Point(135, 165);
            this.tbCnpj.Name = "tbCnpj";
            this.tbCnpj.Size = new System.Drawing.Size(318, 26);
            this.tbCnpj.TabIndex = 5;
            // 
            // dgvLoja
            // 
            this.dgvLoja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoja.Location = new System.Drawing.Point(25, 321);
            this.dgvLoja.Name = "dgvLoja";
            this.dgvLoja.RowHeadersWidth = 62;
            this.dgvLoja.RowTemplate.Height = 28;
            this.dgvLoja.Size = new System.Drawing.Size(648, 235);
            this.dgvLoja.TabIndex = 6;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(45, 263);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(96, 32);
            this.btCadastrar.TabIndex = 7;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click_1);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(178, 262);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(76, 32);
            this.btAlterar.TabIndex = 8;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(306, 263);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(76, 35);
            this.btExcluir.TabIndex = 9;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(442, 260);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(92, 35);
            this.btConsultar.TabIndex = 10;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            // 
            // FrLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 568);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.dgvLoja);
            this.Controls.Add(this.tbCnpj);
            this.Controls.Add(this.tbNomeLoja);
            this.Controls.Add(this.tbIdLoja);
            this.Controls.Add(this.lbCnpj);
            this.Controls.Add(this.lbNomeLoja);
            this.Controls.Add(this.lbIdLoja);
            this.Name = "FrLoja";
            this.Text = "Loja";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrLoja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdLoja;
        private System.Windows.Forms.Label lbNomeLoja;
        private System.Windows.Forms.Label lbCnpj;
        private System.Windows.Forms.TextBox tbIdLoja;
        private System.Windows.Forms.TextBox tbNomeLoja;
        private System.Windows.Forms.TextBox tbCnpj;
        private System.Windows.Forms.DataGridView dgvLoja;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btConsultar;
    }
}

