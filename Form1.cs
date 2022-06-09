using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFrm2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            DialogResult rpta = new DialogResult();
            rpta =MessageBox.Show("Deseas Mostrar este Formulario", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rpta == DialogResult.OK) { frm.ShowDialog(); }
        }
    }
}
