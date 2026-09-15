namespace ProjetoAgenda
{
    partial class TelaPrincipal
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
            this.LblUser = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxCadastro = new System.Windows.Forms.GroupBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.TabelaContatos = new System.Windows.Forms.DataGridView();
            this.LBLConsultar = new System.Windows.Forms.Label();
            this.TxtConsultar = new System.Windows.Forms.TextBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.btntrocar = new System.Windows.Forms.Button();
            this.groupBoxCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(12, 9);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(46, 13);
            this.LblUser.TabIndex = 0;
            this.LblUser.Text = "Usuário:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(65, 9);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(35, 13);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "label1";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(11, 22);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(38, 13);
            this.LblNome.TabIndex = 2;
            this.LblNome.Text = "Nome:";
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Location = new System.Drawing.Point(11, 48);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(52, 13);
            this.LblTelefone.TabIndex = 3;
            this.LblTelefone.Text = "Telefone:";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(55, 19);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(217, 20);
            this.TxtNome.TabIndex = 4;
            this.TxtNome.Enter += new System.EventHandler(this.TxtNome_Enter);
            this.TxtNome.Leave += new System.EventHandler(this.TxtNome_Leave);
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(70, 48);
            this.TxtTelefone.Mask = "(00)00000-0000";
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(97, 20);
            this.TxtTelefone.TabIndex = 5;
            this.TxtTelefone.Enter += new System.EventHandler(this.TxtTelefone_Enter);
            this.TxtTelefone.Leave += new System.EventHandler(this.TxtTelefone_Leave);
            // 
            // groupBoxCadastro
            // 
            this.groupBoxCadastro.Controls.Add(this.TxtNome);
            this.groupBoxCadastro.Controls.Add(this.BtnSalvar);
            this.groupBoxCadastro.Controls.Add(this.LblNome);
            this.groupBoxCadastro.Controls.Add(this.TxtTelefone);
            this.groupBoxCadastro.Controls.Add(this.LblTelefone);
            this.groupBoxCadastro.Location = new System.Drawing.Point(12, 303);
            this.groupBoxCadastro.Name = "groupBoxCadastro";
            this.groupBoxCadastro.Size = new System.Drawing.Size(344, 147);
            this.groupBoxCadastro.TabIndex = 7;
            this.groupBoxCadastro.TabStop = false;
            this.groupBoxCadastro.Text = "Cadastro";
            this.groupBoxCadastro.Visible = false;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Image = global::ProjetoAgenda.Properties.Resources.salva;
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalvar.Location = new System.Drawing.Point(14, 85);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(71, 56);
            this.BtnSalvar.TabIndex = 6;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TabelaContatos
            // 
            this.TabelaContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaContatos.Location = new System.Drawing.Point(15, 35);
            this.TabelaContatos.Name = "TabelaContatos";
            this.TabelaContatos.Size = new System.Drawing.Size(351, 131);
            this.TabelaContatos.TabIndex = 8;
            this.TabelaContatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaContatos_CellContentClick);
            // 
            // LBLConsultar
            // 
            this.LBLConsultar.AutoSize = true;
            this.LBLConsultar.Location = new System.Drawing.Point(20, 193);
            this.LBLConsultar.Name = "LBLConsultar";
            this.LBLConsultar.Size = new System.Drawing.Size(38, 13);
            this.LBLConsultar.TabIndex = 9;
            this.LBLConsultar.Text = "Nome:";
            // 
            // TxtConsultar
            // 
            this.TxtConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConsultar.Location = new System.Drawing.Point(64, 190);
            this.TxtConsultar.Name = "TxtConsultar";
            this.TxtConsultar.Size = new System.Drawing.Size(191, 22);
            this.TxtConsultar.TabIndex = 10;
            this.TxtConsultar.TextChanged += new System.EventHandler(this.TxtConsultar_TextChanged);
            this.TxtConsultar.Enter += new System.EventHandler(this.TxtConsultar_Enter);
            this.TxtConsultar.Leave += new System.EventHandler(this.TxtConsultar_Leave);
            // 
            // BtnSair
            // 
            this.BtnSair.Image = global::ProjetoAgenda.Properties.Resources.exitok;
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSair.Location = new System.Drawing.Point(290, 237);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(66, 45);
            this.BtnSair.TabIndex = 15;
            this.BtnSair.Text = "Sair";
            this.BtnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Image = global::ProjetoAgenda.Properties.Resources._new;
            this.BtnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNovo.Location = new System.Drawing.Point(12, 237);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(71, 45);
            this.BtnNovo.TabIndex = 14;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Image = global::ProjetoAgenda.Properties.Resources.Untitled_134;
            this.BtnAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAtualizar.Location = new System.Drawing.Point(198, 237);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(74, 46);
            this.BtnAtualizar.TabIndex = 13;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Image = global::ProjetoAgenda.Properties.Resources.excluicerto;
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnExcluir.Location = new System.Drawing.Point(105, 238);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(74, 45);
            this.BtnExcluir.TabIndex = 12;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Image = global::ProjetoAgenda.Properties.Resources.localizar;
            this.BtnConsultar.Location = new System.Drawing.Point(274, 177);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(48, 45);
            this.BtnConsultar.TabIndex = 11;
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // btntrocar
            // 
            this.btntrocar.Image = global::ProjetoAgenda.Properties.Resources.Untitled_134;
            this.btntrocar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btntrocar.Location = new System.Drawing.Point(337, 179);
            this.btntrocar.Name = "btntrocar";
            this.btntrocar.Size = new System.Drawing.Size(75, 52);
            this.btntrocar.TabIndex = 16;
            this.btntrocar.Text = "Trocar senhas";
            this.btntrocar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btntrocar.UseVisualStyleBackColor = true;
            this.btntrocar.Click += new System.EventHandler(this.btntrocar_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 462);
            this.ControlBox = false;
            this.Controls.Add(this.btntrocar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.TxtConsultar);
            this.Controls.Add(this.LBLConsultar);
            this.Controls.Add(this.TabelaContatos);
            this.Controls.Add(this.groupBoxCadastro);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblUser);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Tela Principal :::";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.groupBoxCadastro.ResumeLayout(false);
            this.groupBoxCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaContatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUser;
        public System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.MaskedTextBox TxtTelefone;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.GroupBox groupBoxCadastro;
        private System.Windows.Forms.DataGridView TabelaContatos;
        private System.Windows.Forms.Label LBLConsultar;
        private System.Windows.Forms.TextBox TxtConsultar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnSair;
        public System.Windows.Forms.Button BtnExcluir;
        public System.Windows.Forms.Button BtnAtualizar;
        public System.Windows.Forms.Button BtnNovo;
        public System.Windows.Forms.Button btntrocar;
    }
}