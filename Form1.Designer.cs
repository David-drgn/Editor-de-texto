namespace Editor_de_texto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nmuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.opcNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.opcAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.opcSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.opcEncerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.nmuEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcRecortar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcColar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.opcSelecionarTudo = new System.Windows.Forms.ToolStripMenuItem();
            this.nmuFormatar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcFonte = new System.Windows.Forms.ToolStripMenuItem();
            this.opcCorFonte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ntsNovo = new System.Windows.Forms.ToolStripButton();
            this.ntsAbrir = new System.Windows.Forms.ToolStripButton();
            this.ntsSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ntsRecortar = new System.Windows.Forms.ToolStripButton();
            this.copiarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Texto = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nmuArquivo,
            this.nmuEditar,
            this.nmuFormatar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nmuArquivo
            // 
            this.nmuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcNovo,
            this.toolStripSeparator,
            this.opcAbrir,
            this.opcSalvar,
            this.toolStripSeparator1,
            this.opcEncerrar});
            this.nmuArquivo.Name = "nmuArquivo";
            this.nmuArquivo.Size = new System.Drawing.Size(61, 20);
            this.nmuArquivo.Text = "&Arquivo";
            // 
            // opcNovo
            // 
            this.opcNovo.Image = ((System.Drawing.Image)(resources.GetObject("opcNovo.Image")));
            this.opcNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.opcNovo.Name = "opcNovo";
            this.opcNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.opcNovo.Size = new System.Drawing.Size(180, 22);
            this.opcNovo.Text = "&Novo";
            this.opcNovo.Click += new System.EventHandler(this.opcNovo_Click);
            // 
            // opcAbrir
            // 
            this.opcAbrir.Image = ((System.Drawing.Image)(resources.GetObject("opcAbrir.Image")));
            this.opcAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.opcAbrir.Name = "opcAbrir";
            this.opcAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.opcAbrir.Size = new System.Drawing.Size(180, 22);
            this.opcAbrir.Text = "&Abrir";
            this.opcAbrir.Click += new System.EventHandler(this.opcAbrir_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // opcSalvar
            // 
            this.opcSalvar.Image = ((System.Drawing.Image)(resources.GetObject("opcSalvar.Image")));
            this.opcSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.opcSalvar.Name = "opcSalvar";
            this.opcSalvar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.opcSalvar.Size = new System.Drawing.Size(180, 22);
            this.opcSalvar.Text = "&Salvar";
            this.opcSalvar.Click += new System.EventHandler(this.opcSalvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // opcEncerrar
            // 
            this.opcEncerrar.Name = "opcEncerrar";
            this.opcEncerrar.Size = new System.Drawing.Size(180, 22);
            this.opcEncerrar.Text = "Encerrar";
            this.opcEncerrar.Click += new System.EventHandler(this.opcEncerrar_Click);
            // 
            // nmuEditar
            // 
            this.nmuEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcRecortar,
            this.opcCopiar,
            this.opcColar,
            this.toolStripSeparator4,
            this.opcSelecionarTudo});
            this.nmuEditar.Name = "nmuEditar";
            this.nmuEditar.Size = new System.Drawing.Size(49, 20);
            this.nmuEditar.Text = "&Editar";
            // 
            // opcRecortar
            // 
            this.opcRecortar.Image = ((System.Drawing.Image)(resources.GetObject("opcRecortar.Image")));
            this.opcRecortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.opcRecortar.Name = "opcRecortar";
            this.opcRecortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.opcRecortar.Size = new System.Drawing.Size(180, 22);
            this.opcRecortar.Text = "Recor&tar";
            this.opcRecortar.Click += new System.EventHandler(this.opcRecortar_Click);
            // 
            // opcCopiar
            // 
            this.opcCopiar.Image = ((System.Drawing.Image)(resources.GetObject("opcCopiar.Image")));
            this.opcCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.opcCopiar.Name = "opcCopiar";
            this.opcCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.opcCopiar.Size = new System.Drawing.Size(180, 22);
            this.opcCopiar.Text = "&Copiar";
            this.opcCopiar.Click += new System.EventHandler(this.opcCopiar_Click);
            // 
            // opcColar
            // 
            this.opcColar.Image = ((System.Drawing.Image)(resources.GetObject("opcColar.Image")));
            this.opcColar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.opcColar.Name = "opcColar";
            this.opcColar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.opcColar.Size = new System.Drawing.Size(180, 22);
            this.opcColar.Text = "C&olar";
            this.opcColar.Click += new System.EventHandler(this.opcColar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // opcSelecionarTudo
            // 
            this.opcSelecionarTudo.Name = "opcSelecionarTudo";
            this.opcSelecionarTudo.Size = new System.Drawing.Size(180, 22);
            this.opcSelecionarTudo.Text = "Selecionar &Tudo";
            this.opcSelecionarTudo.Click += new System.EventHandler(this.opcSelecionarTudo_Click);
            // 
            // nmuFormatar
            // 
            this.nmuFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcFonte,
            this.opcCorFonte});
            this.nmuFormatar.Name = "nmuFormatar";
            this.nmuFormatar.Size = new System.Drawing.Size(67, 20);
            this.nmuFormatar.Text = "Formatar";
            // 
            // opcFonte
            // 
            this.opcFonte.Name = "opcFonte";
            this.opcFonte.Size = new System.Drawing.Size(180, 22);
            this.opcFonte.Text = "F&onte";
            this.opcFonte.Click += new System.EventHandler(this.opcFonte_Click);
            // 
            // opcCorFonte
            // 
            this.opcCorFonte.Name = "opcCorFonte";
            this.opcCorFonte.Size = new System.Drawing.Size(180, 22);
            this.opcCorFonte.Text = "Co&r da fonte";
            this.opcCorFonte.Click += new System.EventHandler(this.opcCorFonte_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ntsNovo,
            this.ntsAbrir,
            this.ntsSalvar,
            this.toolStripSeparator6,
            this.ntsRecortar,
            this.copiarToolStripButton,
            this.colarToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(773, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ntsNovo
            // 
            this.ntsNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ntsNovo.Image = ((System.Drawing.Image)(resources.GetObject("ntsNovo.Image")));
            this.ntsNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ntsNovo.Name = "ntsNovo";
            this.ntsNovo.Size = new System.Drawing.Size(23, 22);
            this.ntsNovo.Text = "&Novo";
            this.ntsNovo.Click += new System.EventHandler(this.opcNovo_Click);
            // 
            // ntsAbrir
            // 
            this.ntsAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ntsAbrir.Image = ((System.Drawing.Image)(resources.GetObject("ntsAbrir.Image")));
            this.ntsAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ntsAbrir.Name = "ntsAbrir";
            this.ntsAbrir.Size = new System.Drawing.Size(23, 22);
            this.ntsAbrir.Text = "&Abrir";
            this.ntsAbrir.Click += new System.EventHandler(this.opcAbrir_Click);
            // 
            // ntsSalvar
            // 
            this.ntsSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ntsSalvar.Image = ((System.Drawing.Image)(resources.GetObject("ntsSalvar.Image")));
            this.ntsSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ntsSalvar.Name = "ntsSalvar";
            this.ntsSalvar.Size = new System.Drawing.Size(23, 22);
            this.ntsSalvar.Text = "&Salvar";
            this.ntsSalvar.Click += new System.EventHandler(this.opcSalvar_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // ntsRecortar
            // 
            this.ntsRecortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ntsRecortar.Image = ((System.Drawing.Image)(resources.GetObject("ntsRecortar.Image")));
            this.ntsRecortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ntsRecortar.Name = "ntsRecortar";
            this.ntsRecortar.Size = new System.Drawing.Size(23, 22);
            this.ntsRecortar.Text = "Recor&tar";
            this.ntsRecortar.Click += new System.EventHandler(this.opcRecortar_Click);
            // 
            // copiarToolStripButton
            // 
            this.copiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripButton.Image")));
            this.copiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripButton.Name = "copiarToolStripButton";
            this.copiarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copiarToolStripButton.Text = "&Copiar";
            this.copiarToolStripButton.Click += new System.EventHandler(this.opcCopiar_Click);
            // 
            // colarToolStripButton
            // 
            this.colarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("colarToolStripButton.Image")));
            this.colarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colarToolStripButton.Name = "colarToolStripButton";
            this.colarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.colarToolStripButton.Text = "C&olar";
            this.colarToolStripButton.Click += new System.EventHandler(this.opcColar_Click);
            // 
            // Texto
            // 
            this.Texto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Texto.Location = new System.Drawing.Point(0, 49);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(773, 463);
            this.Texto.TabIndex = 2;
            this.Texto.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 512);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nmuArquivo;
        private System.Windows.Forms.ToolStripMenuItem opcNovo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem opcAbrir;
        private System.Windows.Forms.ToolStripMenuItem opcSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem opcEncerrar;
        private System.Windows.Forms.ToolStripMenuItem nmuEditar;
        private System.Windows.Forms.ToolStripMenuItem opcRecortar;
        private System.Windows.Forms.ToolStripMenuItem opcCopiar;
        private System.Windows.Forms.ToolStripMenuItem opcColar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem opcSelecionarTudo;
        private System.Windows.Forms.ToolStripMenuItem nmuFormatar;
        private System.Windows.Forms.ToolStripMenuItem opcFonte;
        private System.Windows.Forms.ToolStripMenuItem opcCorFonte;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ntsNovo;
        private System.Windows.Forms.ToolStripButton ntsAbrir;
        private System.Windows.Forms.ToolStripButton ntsSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton ntsRecortar;
        private System.Windows.Forms.ToolStripButton copiarToolStripButton;
        private System.Windows.Forms.ToolStripButton colarToolStripButton;
        private System.Windows.Forms.RichTextBox Texto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

