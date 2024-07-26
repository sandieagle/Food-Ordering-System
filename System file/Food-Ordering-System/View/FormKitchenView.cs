using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Ordering_System.View
{
    public partial class FormKitchenView : Form
    {
        public FormKitchenView()
        {
            InitializeComponent();
        }

        private void FormKitchenView_Load(object sender, EventArgs e)
        {
            GetOrders();
        }

        private void GetOrders()
        {
            flowLayoutPanel1.Controls.Clear();
            string qry1 = @"Select * from tblMain where status = 'Pending'";
            SqlCommand cmd1 = new SqlCommand(qry1,MainClass.con);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt1);

            FlowLayoutPanel p1;

            for(int i = 0; i < dt1.Rows.Count; i++)
            {
                p1 = new FlowLayoutPanel();
                p1.AutoSize = true;
                p1.Width = 230;
                p1.Height = 100;
                p1.FlowDirection = FlowDirection.TopDown;
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.Margin = new Padding(10,10,10,10);


                FlowLayoutPanel p2 = new FlowLayoutPanel();
                p2 = new FlowLayoutPanel();
                p2.BackColor = Color.FromArgb(50, 55, 89);
                p2.AutoSize = true;
                p2.Width = 230;
                p2.Height = 100;
                p2.FlowDirection = FlowDirection.TopDown;        
                p2.Margin = new Padding(10,10, 10, 10);

                Label lbl = new Label();
                lbl.ForeColor = Color.White;
                lbl.Margin = new Padding(10,10,3,0);
                lbl.AutoSize = true;

                Label lbl3 = new Label();
                lbl3.ForeColor = Color.White;
                lbl3.Margin = new Padding(10, 5, 3, 0);
                lbl3.AutoSize = true;

                Label lbl4 = new Label();
                lbl4.ForeColor = Color.White;
                lbl4.Margin = new Padding(10, 5, 3, 10);
                lbl4.AutoSize = true;

                lbl.Text = "Table : " + dt1.Rows[i]["TableName"].ToString();
                lbl3.Text = "Order Time : " + dt1.Rows[i]["aTime"].ToString();
                lbl4.Text = "Order Type : " + dt1.Rows[i]["orderType"].ToString();

                p2.Controls.Add(lbl);
                p2.Controls.Add(lbl3);
                p2.Controls.Add(lbl4);

                p1.Controls.Add(p2);

                // Add Products
                int mid = 0;
                mid = Convert.ToInt32(dt1.Rows[i]["MainID"].ToString());

                string qry2 = @"Select * from tblMain m inner join tblDetails d on m.MainID = d.MainID inner join FoodProducts p on p.pID = d.proID where m.MainID = "+mid+"";
               // string qry2 = @"Select * from FoodProducts p,tblMain m,tblDetails d where p.pID = d.proID AND m.KainID = d.MainID and m.KainID = " + mid + "";
                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);

                for(int j = 0; j < dt2.Rows.Count; j++)
                {
                    Label lbl5 = new Label();
                    lbl5.ForeColor = Color.Black;
                    lbl5.Margin = new Padding(10, 5, 3, 10);
                    lbl5.AutoSize = true;

                    int no = j + 1;

                    lbl5.Text = "" + no + ". " + dt2.Rows[j]["pName"].ToString() + " " + dt2.Rows[j]["qty"].ToString();

                    p1.Controls.Add(lbl5);
                }

                //Add button to change order status
                Guna.UI.WinForms.GunaButton b = new Guna.UI.WinForms.GunaButton();
                b.Size = new Size(100, 35);
                b.BackColor = Color.FromArgb(241,85,126);
                b.Margin = new Padding(60, 5, 3, 10);
                b.Text = "Complete";
                b.Tag = dt1.Rows[i]["MainID"].ToString(); //Store the id

                b.Click += new EventHandler(b_click);
                p1.Controls.Add (b);



                flowLayoutPanel1.Controls.Add(p1);

            }

        }

        private void b_click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Guna.UI.WinForms.GunaButton).Tag.ToString());

            DialogResult result = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's choice
            if (result == DialogResult.Yes)
            {
                string qry = @"Update tblMain set status = 'Complete' where MainID = @ID";
                Hashtable ht = new Hashtable();
                ht.Add("@ID", id);

                if(MainClass.SQ1(qry,ht) > 0)
                {
                    MessageBox.Show("Saved Successfully");
                }
                GetOrders();
            }
        }
    }
}
