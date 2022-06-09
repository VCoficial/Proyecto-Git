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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (TxtNumero.Text == "")
            {
            MessageBox.Show("Por favor, ingrese un numero");
            }
            else {
            int num = Convert.ToInt32(TxtNumero.Text);
            MessageBox.Show("El numero mostrado es " + num);
            }
        }
    }
}
