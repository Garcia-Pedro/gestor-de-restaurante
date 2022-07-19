using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Sistema_restaurante : Form
    {
        public Sistema_restaurante()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Cardapio_Click(object sender, EventArgs e)
        {
            if (Menu_suspenso.Width == 1)
            {
                Menu_suspenso.Visible = true;
                Menu_suspenso.Width = 225;
                           
            }
            else if(Menu_suspenso.Width == 225)
            {
                Menu_suspenso.Visible = false;
                Menu_suspenso.Width = 1;
            }
            else{
            
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            //fastFood1.Visible = true;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            nossos_Serviços1.Visible = true;
            fastFood1.Visible = false;
            Menu_suspenso.Visible = false;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            fastFood1.Visible = true;
            nossos_Serviços1.Visible = false;
            Menu_suspenso.Visible = false;
        }
    }
}
