using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MetroFramework.Controls.MetroTextBox;

namespace Food_Ordering_System.Model
{
    public partial class FormTableSelect : Form
    {
        public FormTableSelect()
        {
            InitializeComponent();
        }


        public string TableName;

        private void FormTableSelect_Load(object sender, EventArgs e)
        {
            string qry = "Select * from Tables";
            SqlCommand cmd = new SqlCommand(qry ,MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Guna.UI.WinForms.GunaButton b = new Guna.UI.WinForms.GunaButton();
                b.Text = row["tname"].ToString();
                b.Width = 510;
                b.Height = 50;
                b.BackColor = Color.FromArgb(241, 85, 126);
                
                //event for click
                b.Click += new EventHandler(b_Click);

                flowLayoutPanel1.Controls.Add(b);
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            TableName = (sender as Guna.UI.WinForms.GunaButton).Text.ToString();
            this.Close();
        }
    }
}
