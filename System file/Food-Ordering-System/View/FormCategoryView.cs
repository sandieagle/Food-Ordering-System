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
    public partial class FormCategoryView : SampleView
    {
        public FormCategoryView()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "Select * from category where catName like '%"+text_search.Text+"%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            MainClass.LoadData(qry, gunaDataGridView1, lb);
        }

        private void FormCategoryView_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public override void add_img_btn_Click(object sender, EventArgs e)
        {
            // BackGround Blur Effect
            MainClass.Blurbackground(new FormCategoryAdd());
            //FormCategoryAdd frm = new FormCategoryAdd();
            //frm.ShowDialog();
            GetData();
        }

        public override void text_search_TextChanged(object sender, EventArgs e)
        {
            //Creating tables by querring first
            GetData();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                FormCategoryAdd frm = new FormCategoryAdd();
                frm.id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.text_name.Text = Convert.ToString(gunaDataGridView1.CurrentRow.Cells["dgvName"].Value);
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
                    string qry = "Delete from category where catID=" + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQ1(qry, ht);

                    MessageBox.Show("Delete SuccessFully");
                    GetData();
                }
                    
            }

        }
    }
}
