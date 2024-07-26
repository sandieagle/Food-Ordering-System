using Food_Ordering_System.Model;
using Food_Ordering_System.View;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //For MainForm Accessing
        static MainForm _obj;
        public static MainForm Instance
        { 
            get { 
                if (_obj == null)
                {
                    _obj = new MainForm();
                }
                return _obj; 
            }
        }


        //Method to add control from main form
        public void AddControls(Form f){
            center_panel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            center_panel.Controls.Add(f);
            f.Show();
            }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            lbl_user.Text = MainClass.USER;
            _obj = this;
          
        }

        private void gunaControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void category_btn_Click(object sender, EventArgs e)
        {
            AddControls(new FormCategoryView());
        }

        private void product_btn_Click(object sender, EventArgs e)
        {
            AddControls(new FormProductView());
        }

        private void center_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            FormMenu frm = new FormMenu();
            frm.Show();
            this.Hide();

        }

        private void kichen_btn_Click(object sender, EventArgs e)
        {
            AddControls(new FormKitchenView());

        }
    }
}
