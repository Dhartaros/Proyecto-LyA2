using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniJava
{
    public partial class Form1 : Form
    {
        private string url;
        OpenFileDialog ofd = new OpenFileDialog();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void analizar_Click(object sender, EventArgs e)
        {

        }

        private void abrir_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                    codigoStream.Text = sr.ReadToEnd();
                    sr.Close();
                }
                catch
                {
                    MessageBox.Show("No se pudo copiar el archivo","Error de lectura",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {

        }
    }
}
