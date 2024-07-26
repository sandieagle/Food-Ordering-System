using Food_Ordering_System.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Ordering_System.View
{
    public partial class FormProductView : SampleView
    {
        public FormProductView()
        {
            InitializeComponent();
        }

        private void FormProductView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string qry = "select pID,pName,pPrice,CategoryID,c.catName from FoodProducts p inner join category c on c.catID = p.CategoryID where pName like '%" + text_search.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvCatID);
            lb.Items.Add(dgvCat);

            MainClass.LoadData(qry, gunaDataGridView1, lb);
        }

        public override void add_img_btn_Click(object sender, EventArgs e)
        {
            // BackGround Blur Effect
            MainClass.Blurbackground(new Model.FormProductAdd());
            //FormCategoryAdd frm = new FormCategoryAdd();
            //frm.ShowDialog();
            GetData();
        }

        public override void text_search_TextChanged(object sender, EventArgs e)
        {
            //Creating tables by querring first
            GetData();
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                FormProductAdd frm = new FormProductAdd();
                frm.id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.cID = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvCatID"].Value);
                
                MainClass.Blurbackground(frm);
                GetData();
            }

            if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                //Confirmation of deletion will want to add
                DialogResult result = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check the user's choice
                if (result == DialogResult.Yes)
                {
                    // User clicked "Yes," perform your action here
                    int id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete from FoodProducts where pID=" + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQ1(qry, ht);

                    MessageBox.Show("Delete SuccessFully");
                    GetData();
                }

            }

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
