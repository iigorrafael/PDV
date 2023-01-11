namespace PDV
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.img03 = new System.Windows.Forms.PictureBox();
            this.img02 = new System.Windows.Forms.PictureBox();
            this.img04 = new System.Windows.Forms.PictureBox();
            this.img01 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastros,
            this.menuProdutos,
            this.menuMovimentacoes,
            this.menuRelatorios,
            this.menuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuPrincipal";
            // 
            // menuCadastros
            // 
            this.menuCadastros.Name = "menuCadastros";
            this.menuCadastros.Size = new System.Drawing.Size(71, 20);
            this.menuCadastros.Text = "Cadastros";
            // 
            // menuProdutos
            // 
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(67, 20);
            this.menuProdutos.Text = "Produtos";
            // 
            // menuMovimentacoes
            // 
            this.menuMovimentacoes.Name = "menuMovimentacoes";
            this.menuMovimentacoes.Size = new System.Drawing.Size(104, 20);
            this.menuMovimentacoes.Text = "Movimentações";
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(71, 20);
            this.menuRelatorios.Text = "Relatórios";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "Sair";
            // 
            // img03
            // 
            this.img03.Location = new System.Drawing.Point(77, 310);
            this.img03.Name = "img03";
            this.img03.Size = new System.Drawing.Size(285, 189);
            this.img03.TabIndex = 2;
            this.img03.TabStop = false;
            // 
            // img02
            // 
            this.img02.Location = new System.Drawing.Point(421, 59);
            this.img02.Name = "img02";
            this.img02.Size = new System.Drawing.Size(285, 189);
            this.img02.TabIndex = 3;
            this.img02.TabStop = false;
            // 
            // img04
            // 
            this.img04.Location = new System.Drawing.Point(421, 310);
            this.img04.Name = "img04";
            this.img04.Size = new System.Drawing.Size(285, 189);
            this.img04.TabIndex = 4;
            this.img04.TabStop = false;
            // 
            // img01
            // 
            this.img01.BackColor = System.Drawing.Color.Transparent;
            this.img01.Location = new System.Drawing.Point(77, 59);
            this.img01.Name = "img01";
            this.img01.Size = new System.Drawing.Size(285, 189);
            this.img01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img01.TabIndex = 1;
            this.img01.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.img04);
            this.Controls.Add(this.img02);
            this.Controls.Add(this.img03);
            this.Controls.Add(this.img01);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCadastros;
        private System.Windows.Forms.ToolStripMenuItem menuProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuMovimentacoes;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.PictureBox img03;
        private System.Windows.Forms.PictureBox img02;
        private System.Windows.Forms.PictureBox img04;
        private System.Windows.Forms.PictureBox img01;
    }
}

