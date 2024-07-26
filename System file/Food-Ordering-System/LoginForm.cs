using Food_Ordering_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Ordering_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(128, Color.White);
            panel2.BackColor = Color.FromArgb(128, Color.Black);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            //creating database
            if(MainClass.IsvalidUser(user_text.Text,pw_text.Text) == false)
            {
                MessageBox.Show("Invalid username or password");
                return;
            }
            else
            {
                this.Hide();
                MainForm frm = new MainForm();
                frm.Show();

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void gunaControlBox4_Click(object sender, EventArgs e)
        {

        }

        private void gunaControlBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
