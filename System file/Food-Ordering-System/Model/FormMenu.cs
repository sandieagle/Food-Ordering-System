
using Guna.UI.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Food_Ordering_System.Model
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        public int MainID = 0;
        public string OrderType;
        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

            gunaDataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AddCategory();

            product_panel.Controls.Clear();
            LoadPoduct();
        }

        private void AddCategory()
        {
            string qry = "Select * from category";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            category_panel.Controls.Clear();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI.WinForms.GunaButton b = new Guna.UI.WinForms.GunaButton();
                    b.BackColor = Color.FromArgb(50, 55, 89);
                    b.Size = new Size(134, 45);
                    //b.ButtonMode = Guna.UI.WinForms.Enums.ButtonMode.RadioButton;
                    b.Text = row["catName"].ToString();

                    //event for click
                    b.Click += new EventHandler(b_Click);

                    category_panel.Controls.Add(b);
                }
            }

        }

        private void b_Click(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaButton b = (Guna.UI.WinForms.GunaButton)sender;

            //if(b.Text == "All Categories")
            //{
            //    text_search.Text = "1";
            //    text_search.Text = "";
            //    return;
            //}

            foreach (var item in product_panel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());

            }
        }

        private void AddItems(string id, string proID, string name, string cat, String price, Image pimage)
        {
            var w = new ucProduct()
            {

                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(proID)
            };

            product_panel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;

                foreach (DataGridViewRow item in gunaDataGridView1.Rows)
                {
                    //This checking product is already there
                    if (Convert.ToInt32(item.Cells["dgvproID"].Value) == wdg.id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) * double.Parse(item.Cells["dgvPrice"].Value.ToString());
                        //Gettotal();
                        return;
                    }
                }

                //Add New product
                gunaDataGridView1.Rows.Add(new object[] { 0, 0, wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                Gettotal();
            };
        }

        //Getting product from database

        private void LoadPoduct()
        {
            string qry = "Select * from FoodProducts inner join category on catID = CategoryID";

            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["pimage"];
                byte[] imagebytearray = imagearray;

                AddItems("0", item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(), item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imagearray)));
            }
        }

        private void text_search_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in product_panel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PName.ToLower().Contains(text_search.Text.Trim().ToLower());

            }
        }

        private void gunaDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //For serial number
            int count = 0;

            foreach (DataGridViewRow row in gunaDataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void Gettotal()
        {
            double tot = 0;
            lbl_total.Text = "";

            foreach (DataGridViewRow item in gunaDataGridView1.Rows)
            {
                if (item.Cells["dgvAmount"].Value != null && !string.IsNullOrEmpty(item.Cells["dgvAmount"].Value.ToString()))
                {
                    tot += double.Parse(item.Cells["dgvAmount"].Value.ToString());
                }
            }
            lbl_total.Text = tot.ToString("N2");
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }


        //Clear The Datagrid and add new items to the cart
        private void btn_new_Click(object sender, EventArgs e)
        {
            lbl_table.Text = "";
            lbl_table.Visible = false;
            
            gunaDataGridView1.Rows.Clear();
            MainID = 0;
            lbl_total.Text = "0.00";
        }


        private void btn_kot_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                lbl_table.Text = "";
                lbl_table.Visible = false;
                OrderType = "Take Away";
            }
            else if (radioButton2.Checked)
            {
                OrderType = "Dine in";
            FormTableSelect frm = new FormTableSelect();
            MainClass.Blurbackground(frm);

            if (frm.TableName != "")
            {
                lbl_table.Text = frm.TableName;
                lbl_table.Visible = true;
            }
            else
            {
                lbl_table.Text = "";
                lbl_table.Visible = false;
            }
            }
            //Save The data in Database
            //Create tables
            string qry1 = ""; //main table
            string qry2 = ""; //table details

            int detailID = 0;

            if (MainID == 0) // Inserting
            {
                qry1 = @"Insert into tblMain Values(@aDate,@aTime,@TableName,@status,@orderType,@total);
                        Select SCOPE_IDENTITY()";
                //This line will get recent add id value
            }
            else //update
            {
                qry1 = @"Update tblMain Set status = @status,total = @total where MainID = @ID";
            }


            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);

            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lbl_table.Text);
            cmd.Parameters.AddWithValue("@status", "Pending");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lbl_total.Text)); //As we only saving data for kitchen value will update when paymet receive

            if (MainClass.con.State == ConnectionState.Closed)
            {
                MainClass.con.Open();
            }

            if (MainID == 0)
            {
                MainID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else
            {
                cmd.ExecuteNonQuery();
            }

            if (MainClass.con.State == ConnectionState.Open)
            {
                MainClass.con.Close();
            }

            foreach (DataGridViewRow row in gunaDataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if (detailID == 0) //insert
                {
                    qry2 = @"Insert into tblDetails Values(@MainID,@proID,@qty,@price,@amount)";
                }
                else // update
                {
                    qry2 = "Update tblDetails Set proID = @proID,qty = @qty,price = @price,amount = @amount where DetailID = @ID";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);

                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvProID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                if (MainClass.con.State == ConnectionState.Closed)
                {
                    MainClass.con.Open();
                }

                cmd2.ExecuteNonQuery();


                if (MainClass.con.State == ConnectionState.Open)
                {
                    MainClass.con.Close();
                }

                
            }
            MessageBox.Show("Saved Successfully");
            MainID = 0;
            detailID = 0;
            gunaDataGridView1.Rows.Clear();

            lbl_table.Text = "";
            lbl_table.Visible = false;
            lbl_total.Text = "0.00";

        }

        public int id = 0;

        private void product_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
            
        }
    }

}