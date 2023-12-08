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
    public partial class FrmSalida : Form
    {
        private int nota5;
        public FrmSalida()
        {
            InitializeComponent();
        }
        public FrmSalida(int nota5): this()
        {
            this.nota5 = nota5;
        }

        private void FrmSalida_Load(object sender, EventArgs e)
        {
            txtNotaRecibe.Text = Convert.ToString(nota5);
        }
    }
}
