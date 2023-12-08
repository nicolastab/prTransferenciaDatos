using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prTransferenciaDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nota1, nota2, nota3, nota4, nota5;
            nota1 = Convert.ToInt32(txtP1.Text);
            nota2 = Convert.ToInt32(txtP2.Text);
            nota3 = Convert.ToInt32(txtP3.Text);
            nota4 = Convert.ToInt32(txtAs.Text);
            nota5 = nota1 + nota2 + nota3 + nota4;
            txtNf.Text = Convert.ToString(nota5);

            FrmSalida form = new FrmSalida(nota5);
            form.Show();
        }
    }
}
