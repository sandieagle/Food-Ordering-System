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
    public partial class SampleAdd : Form
    {
        public SampleAdd()
        {
            InitializeComponent(); 
        }

        public virtual void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void save_btn_Click(object sender, EventArgs e)
        {

        }

        private void SampleAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
