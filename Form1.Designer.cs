
namespace Youtube
{
    partial class blocoDeNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(blocoDeNotas));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbrirArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalvarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(745, 27);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbrirArquivo,
            this.MenuSalvar,
            this.menuSalvarComo,
            this.toolStripSeparator1,
            this.menuSair});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.fileToolStripMenuItem.Text = "Arquivo";
            // 
            // menuAbrirArquivo
            // 
            this.menuAbrirArquivo.BackColor = System.Drawing.Color.Transparent;
            this.menuAbrirArquivo.Name = "menuAbrirArquivo";
            this.menuAbrirArquivo.Size = new System.Drawing.Size(180, 24);
            this.menuAbrirArquivo.Text = "Abrir arquivo";
            this.menuAbrirArquivo.Click += new System.EventHandler(this.MenuAbrirArquivo_Click);
            // 
            // MenuSalvar
            // 
            this.MenuSalvar.BackColor = System.Drawing.Color.Transparent;
            this.MenuSalvar.Name = "MenuSalvar";
            this.MenuSalvar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuSalvar.Size = new System.Drawing.Size(180, 24);
            this.MenuSalvar.Text = "Salvar";
            this.MenuSalvar.Click += new System.EventHandler(this.MenuSalvar_Click);
            // 
            // menuSalvarComo
            // 
            this.menuSalvarComo.BackColor = System.Drawing.Color.Transparent;
            this.menuSalvarComo.Name = "menuSalvarComo";
            this.menuSalvarComo.Size = new System.Drawing.Size(180, 24);
            this.menuSalvarComo.Text = "Salvar como";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuSair
            // 
            this.menuSair.BackColor = System.Drawing.Color.Transparent;
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(180, 24);
            this.menuSair.Text = "Sair";
            // 
            // txtTexto
            // 
            this.txtTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(61)))));
            this.txtTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(252)))), ((int)(((byte)(82)))));
            this.txtTexto.Location = new System.Drawing.Point(0, 27);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTexto.Size = new System.Drawing.Size(745, 414);
            this.txtTexto.TabIndex = 1;
            this.txtTexto.WordWrap = false;
            this.txtTexto.TextChanged += new System.EventHandler(this.TxtTexto_TextChanged);
            // 
            // blocoDeNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(745, 441);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.Name = "blocoDeNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloco de Notas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BlocoDeNotas_FormClosing);
            this.Load += new System.EventHandler(this.BlocoDeNotas_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.ToolStripMenuItem menuSalvarComo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem menuAbrirArquivo;
        private System.Windows.Forms.ToolStripMenuItem MenuSalvar;
    }
}

