namespace ProjetoAgenda.View
{
    partial class Atualixar
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
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.Txtusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.TabelaContatos = new System.Windows.Forms.DataGridView();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.TxtConsultar = new System.Windows.Forms.TextBox();
            this.LBLConsultar = new System.Windows.Forms.Label();
            this.BtnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Image = global::ProjetoAgenda.Properties.Resources.retornnar;
            this.BtnVoltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnVoltar.Location = new System.Drawing.Point(200, 101);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 53);
            this.BtnVoltar.TabIndex = 13;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(78, 52);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(158, 20);
            this.TxtSenha.TabIndex = 12;
            // 
            // Txtusuario
            // 
            this.Txtusuario.Location = new System.Drawing.Point(78, 26);
            this.Txtusuario.Name = "Txtusuario";
            this.Txtusuario.Size = new System.Drawing.Size(158, 20);
            this.Txtusuario.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuário:";
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Image = global::ProjetoAgenda.Properties.Resources.salva;
            this.Btn_Salvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Salvar.Location = new System.Drawing.Point(29, 98);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(75, 56);
            this.Btn_Salvar.TabIndex = 8;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // TabelaContatos
            // 
            this.TabelaContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaContatos.Location = new System.Drawing.Point(281, 23);
            this.TabelaContatos.Name = "TabelaContatos";
            this.TabelaContatos.Size = new System.Drawing.Size(351, 131);
            this.TabelaContatos.TabIndex = 14;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Image = global::ProjetoAgenda.Properties.Resources.excluicerto;
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnExcluir.Location = new System.Drawing.Point(120, 101);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(74, 53);
            this.BtnExcluir.TabIndex = 15;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // TxtConsultar
            // 
            this.TxtConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConsultar.Location = new System.Drawing.Point(56, 174);
            this.TxtConsultar.Name = "TxtConsultar";
            this.TxtConsultar.Size = new System.Drawing.Size(191, 22);
            this.TxtConsultar.TabIndex = 17;
            // 
            // LBLConsultar
            // 
            this.LBLConsultar.AutoSize = true;
            this.LBLConsultar.Location = new System.Drawing.Point(12, 179);
            this.LBLConsultar.Name = "LBLConsultar";
            this.LBLConsultar.Size = new System.Drawing.Size(38, 13);
            this.LBLConsultar.TabIndex = 16;
            this.LBLConsultar.Text = "Nome:";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Image = global::ProjetoAgenda.Properties.Resources.localizar;
            this.BtnConsultar.Location = new System.Drawing.Point(253, 160);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(48, 45);
            this.BtnConsultar.TabIndex = 18;
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // Atualixar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 361);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.TxtConsultar);
            this.Controls.Add(this.LBLConsultar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.TabelaContatos);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.Txtusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Salvar);
            this.Name = "Atualixar";
            this.Text = "Atualixar";
            this.Load += new System.EventHandler(this.Atualixar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaContatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox Txtusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.DataGridView TabelaContatos;
        public System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.TextBox TxtConsultar;
        private System.Windows.Forms.Label LBLConsultar;
        private System.Windows.Forms.Button BtnConsultar;
    }
}