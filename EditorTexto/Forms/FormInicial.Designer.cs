namespace EditorTexto
{
    partial class FormInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            menuTopo = new MenuStrip();
            arquivMenu = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            novaJanelaToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            salvarArquivo = new ToolStripMenuItem();
            salvarComoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            texto = new TextBox();
            menuTopo.SuspendLayout();
            SuspendLayout();
            // 
            // menuTopo
            // 
            menuTopo.Items.AddRange(new ToolStripItem[] { arquivMenu, ajudaToolStripMenuItem });
            menuTopo.Location = new Point(0, 0);
            menuTopo.Name = "menuTopo";
            menuTopo.Size = new Size(800, 24);
            menuTopo.TabIndex = 0;
            menuTopo.Text = "menuStrip1";
            // 
            // arquivMenu
            // 
            arquivMenu.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, novaJanelaToolStripMenuItem, abrirToolStripMenuItem, salvarArquivo, salvarComoToolStripMenuItem, toolStripSeparator1, imprimirToolStripMenuItem, toolStripSeparator2, sairToolStripMenuItem });
            arquivMenu.Name = "arquivMenu";
            arquivMenu.Size = new Size(61, 20);
            arquivMenu.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(150, 22);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // novaJanelaToolStripMenuItem
            // 
            novaJanelaToolStripMenuItem.Name = "novaJanelaToolStripMenuItem";
            novaJanelaToolStripMenuItem.Size = new Size(150, 22);
            novaJanelaToolStripMenuItem.Text = "Nova Janela";
            novaJanelaToolStripMenuItem.Click += novaJanelaToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(150, 22);
            abrirToolStripMenuItem.Text = "Abrir...";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // salvarArquivo
            // 
            salvarArquivo.Name = "salvarArquivo";
            salvarArquivo.Size = new Size(150, 22);
            salvarArquivo.Text = "Salvar";
            salvarArquivo.Click += salvarArquivo_Click;
            // 
            // salvarComoToolStripMenuItem
            // 
            salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            salvarComoToolStripMenuItem.Size = new Size(150, 22);
            salvarComoToolStripMenuItem.Text = "Salvar Como...";
            salvarComoToolStripMenuItem.Click += salvarComoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(147, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.Size = new Size(150, 22);
            imprimirToolStripMenuItem.Text = "Imprimir";
            imprimirToolStripMenuItem.Click += imprimirToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(147, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(150, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(195, 22);
            sobreToolStripMenuItem.Text = "Sobre o Editor de Texto";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // texto
            // 
            texto.Dock = DockStyle.Fill;
            texto.Location = new Point(0, 24);
            texto.Multiline = true;
            texto.Name = "texto";
            texto.Size = new Size(800, 426);
            texto.TabIndex = 1;
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(texto);
            Controls.Add(menuTopo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuTopo;
            Name = "FormInicial";
            Text = "Form1";
            menuTopo.ResumeLayout(false);
            menuTopo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuTopo;
        private ToolStripMenuItem arquivMenu;
        private ToolStripMenuItem salvarArquivo;
        private TextBox texto;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem novaJanelaToolStripMenuItem;
        private ToolStripMenuItem salvarComoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
    }
}