using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Nossos_Serviços : UserControl
    {
        public Nossos_Serviços()
        {
            InitializeComponent();
        }

        private void Home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToLongTimeString();
            Data.Text = DateTime.Now.ToLongDateString();
        }
    }
}
