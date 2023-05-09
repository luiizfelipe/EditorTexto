using System.Drawing.Printing;
using System.Windows.Forms;

namespace EditorTexto
{
    public partial class FormInicial : Form
    {
        string nomeArquivo = "Sem título";
        public FormInicial()
        {
            InitializeComponent();

            mudarTitulo(nomeArquivo);
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvaArquivo();
        }

        private void salvarArquivo_Click(object sender, EventArgs e)
        {
            salvaArquivo();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.texto.Text != "")

            {

                DialogResult resultado = MessageBox.Show("Você gostaria de salvar as mudanças feitas no arquivo?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None);
                if (resultado == DialogResult.Yes)
                {
                    salvaArquivo();
                }
                else if (resultado == DialogResult.No)
                {
                    this.texto.Text = "";
                }

            }
        }

        private void salvaArquivo()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string texto = this.texto.Text;

            saveFileDialog1.Title = "Salvar Arquivo";
            saveFileDialog1.Filter = "Arquivos de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                File.WriteAllText(filePath, texto);
                MessageBox.Show("Salvar", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string appName = Application.ExecutablePath;
            System.Diagnostics.Process.Start(appName);

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();


            openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.Filter = "Arquivos de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                mudarTitulo(openFileDialog1.SafeFileNames[0]);
                string filePath = openFileDialog1.FileName;
                string text = File.ReadAllText(filePath);
                this.texto.Text = text;
            }
        }

        private void mudarTitulo(string titulo)
        {
            nomeArquivo = titulo;
            this.Text = $"{nomeArquivo} - Editor de texto";
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.UseEXDialog = true;
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDialog.Document.Print();
            }

        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font fonte = new Font("Arial", 12);
            int x = 100;
            int y = 100;           
            e.Graphics.DrawString(this.texto.Text, fonte, Brushes.Black, x, y);
        }

    }
}