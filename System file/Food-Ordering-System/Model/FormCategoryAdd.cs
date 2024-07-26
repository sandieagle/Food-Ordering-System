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

namespace Food_Ordering_System.Model
{
    public partial class FormCategoryAdd : SampleAdd
    {
        public FormCategoryAdd()
        {
            InitializeComponent();
        }

        public int id = 0;
        public override void save_btn_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click_1(object sender, EventArgs e)
        {
            string qry = "";

            if(id == 0) 
            {
                qry = "Insert into category values(@Name)";
            }
            else
            {
                qry = "Update category Set catName = @Name where catID = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", text_name.Text);

            if(MainClass.SQ1(qry,ht) > 0)
            {
                MessageBox.Show("Saved Successfully");
                id = 0;
                text_name.Text = "";
                text_name.Focus();
            }
        }

        private void FormCategoryAdd_Load(object sender, EventArgs e)
        {

        }

        private void close_btn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
