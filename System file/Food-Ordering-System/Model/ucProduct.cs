using System;
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
   
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
        }

        public event EventHandler onSelect = null;
        public int id { get; set; }

        public String PPrice { get; set; }

        public string PCategory { get; set; }
        public string PName
        {
            get { return lbl_name.Text; }
            set { lbl_name.Text = value; }
        }

        public Image PImage
        {
            get { return text_img.Image; }
            set { text_img.Image = value;  }
        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucProduct_Load(object sender, EventArgs e)
        {

        }

        private void text_img_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
