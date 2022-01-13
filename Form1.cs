using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_de_texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void opcNovo_Click(object sender, EventArgs e)
        {
            Texto.Rtf = String.Empty;
        }

        private void opcAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Abrir arquivo";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "C://";
            openFileDialog1.Filter = "Arquivos RTF|*.RTF|TUDO!!!|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader leitor = new System.IO.StreamReader(openFileDialog1.FileName);
                Texto.Rtf = leitor.ReadToEnd();
                leitor.Close();
            }
        }

        private void opcSalvar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salvar arquivo";
            saveFileDialog1.FileName = "";
            saveFileDialog1.InitialDirectory = "C://";
            saveFileDialog1.Filter = "Arquivos RTF|*.RTF";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName);
                sw.Write(Texto.Rtf);
                sw.Close();
            }
        }

        private void opcEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void opcRecortar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Texto.SelectedRtf);
            Texto.SelectedRtf = "";
        }

        private void opcCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Texto.SelectedRtf);
        }

        private void opcColar_Click(object sender, EventArgs e)
        {
            Texto.SelectedRtf = Clipboard.GetText();
        }

        private void opcSelecionarTudo_Click(object sender, EventArgs e)
        {
            Texto.SelectAll();
        }

        private void opcFonte_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                Texto.SelectionFont = fontDialog1.Font;
            }
        }

        private void opcCorFonte_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                Texto.SelectionColor = colorDialog1.Color;
            }
        }
    }
}
