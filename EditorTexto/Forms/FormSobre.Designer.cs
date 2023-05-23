namespace EditorTexto.Forms
{
    partial class FormSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSobre));
            lblTitulo = new Label();
            txtSobre = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft YaHei", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(-2, 45);
            lblTitulo.Margin = new Padding(6, 0, 6, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(309, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Editor de Texto";
            // 
            // txtSobre
            // 
            txtSobre.BackColor = SystemColors.Control;
            txtSobre.BorderStyle = BorderStyle.None;
            txtSobre.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSobre.Location = new Point(-2, 114);
            txtSobre.Multiline = true;
            txtSobre.Name = "txtSobre";
            txtSobre.Size = new Size(329, 280);
            txtSobre.TabIndex = 1;
            txtSobre.Text = resources.GetString("txtSobre.Text");
            // 
            // FormSobre
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 399);
            Controls.Add(txtSobre);
            Controls.Add(lblTitulo);
            Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "FormSobre";
            Text = "Sobre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtSobre;
    }
}