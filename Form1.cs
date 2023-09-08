using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = SQLcontrol.Login(txtUsuario.Text, txtPass.Text);

            if(result == 1)
            {
                frmMenu menu = new frmMenu();
                this.Hide();
                menu.ShowDialog();
            }else if(result == 0)
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
