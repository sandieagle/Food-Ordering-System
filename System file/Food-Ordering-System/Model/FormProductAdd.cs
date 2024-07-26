using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Ordering_System.Model
{
    public partial class FormProductAdd : SampleAdd
    {
        public FormProductAdd()
        {
            InitializeComponent();
        }

        public int id= 0;
        public int cID = 0;
        private void FormProductAdd_Load(object sender, EventArgs e)
        {
            string qry = "Select catID 'id',catName 'name' from category ";

            MainClass.CBFill(qry, combo_category);

            if(cID > 0) //For Update
            {
                combo_category.SelectedValue = cID;
            }

            if (id > 0)
            {
                ForUpdateLoadData();
            }
        }

        string filePath;
        byte[] imageByteArray;
        private void browse_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg,.png)|*.png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                picbox_browse.Image = new Bitmap(filePath);
            }
        }

        private void save_btn_Click_1(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into FoodProducts values(@Name,@price,@cat,@img)";
            }
            else
            {
                qry = "Update FoodProducts Set pName = @Name, pPrice = @price, CategoryID = @cat, pImage = @img where pID = @id";
            }

            //For image 
            Image temp = new Bitmap(picbox_browse.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", text_name.Text);
            ht.Add("@price", text_price.Text);
            ht.Add("@cat", Convert.ToInt32(combo_category.SelectedValue));
            ht.Add("@img", imageByteArray);


            if (MainClass.SQ1(qry, ht) > 0)
            {
                MessageBox.Show("Saved Successfully");
                id = 0;
                cID = 0;
                text_name.Text = "";
                text_price.Text = "";
                combo_category.SelectedIndex = 0;
                combo_category.SelectedIndex = -1;
                picbox_browse.Image = Food_Ordering_System.Properties.Resources.food;

                text_name.Focus();
                
            }
        }

        private void ForUpdateLoadData()
        {
            string qry = @"Select * from FoodProducts where pID = "+id+"";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count > 0 )
            {
                text_name.Text = dt.Rows[0]["pName"].ToString();
                text_price.Text = dt.Rows[0]["pPrice"].ToString();
                Byte[] imageArray = (byte[])(dt.Rows[0]["pImage"]);
                Byte[] imageByteArray = imageArray;
                picbox_browse.Image = Image.FromStream(new MemoryStream(imageByteArray));               
            }
        }
    }
}
