namespace Food_Ordering_System.Model
{
    partial class FormProductAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductAdd));
            this.combo_category = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.text_price = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.text_name = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.picbox_browse = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.browse_btn = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_browse)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Size = new System.Drawing.Size(129, 25);
            this.gunaLabel1.Text = "Food Products";
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Image = global::Food_Ordering_System.Properties.Resources.food;
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // close_btn
            // 
            this.close_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.close_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.close_btn.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // save_btn
            // 
            this.save_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.save_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.save_btn.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click_1);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(757, 100);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Size = new System.Drawing.Size(757, 100);
            // 
            // combo_category
            // 
            this.combo_category.BackColor = System.Drawing.Color.Transparent;
            this.combo_category.BaseColor = System.Drawing.Color.White;
            this.combo_category.BorderColor = System.Drawing.Color.Silver;
            this.combo_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_category.FocusedColor = System.Drawing.Color.Empty;
            this.combo_category.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_category.ForeColor = System.Drawing.Color.Black;
            this.combo_category.FormattingEnabled = true;
            this.combo_category.Location = new System.Drawing.Point(33, 257);
            this.combo_category.Name = "combo_category";
            this.combo_category.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.combo_category.OnHoverItemForeColor = System.Drawing.Color.White;
            this.combo_category.Size = new System.Drawing.Size(246, 31);
            this.combo_category.TabIndex = 10;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(37, 219);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(69, 20);
            this.gunaLabel4.TabIndex = 13;
            this.gunaLabel4.Text = "Category";
            // 
            // text_price
            // 
            this.text_price.BaseColor = System.Drawing.Color.White;
            this.text_price.BorderColor = System.Drawing.Color.Silver;
            this.text_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_price.FocusedBaseColor = System.Drawing.Color.White;
            this.text_price.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.text_price.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.text_price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_price.Location = new System.Drawing.Point(308, 172);
            this.text_price.Name = "text_price";
            this.text_price.PasswordChar = '\0';
            this.text_price.SelectedText = "";
            this.text_price.Size = new System.Drawing.Size(246, 32);
            this.text_price.TabIndex = 9;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(304, 132);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(41, 20);
            this.gunaLabel3.TabIndex = 12;
            this.gunaLabel3.Text = "Price";
            // 
            // text_name
            // 
            this.text_name.BaseColor = System.Drawing.Color.White;
            this.text_name.BorderColor = System.Drawing.Color.Silver;
            this.text_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_name.FocusedBaseColor = System.Drawing.Color.White;
            this.text_name.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.text_name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.text_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_name.Location = new System.Drawing.Point(33, 172);
            this.text_name.Name = "text_name";
            this.text_name.PasswordChar = '\0';
            this.text_name.SelectedText = "";
            this.text_name.Size = new System.Drawing.Size(246, 32);
            this.text_name.TabIndex = 8;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(37, 132);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(49, 20);
            this.gunaLabel2.TabIndex = 11;
            this.gunaLabel2.Text = "Name";
            // 
            // picbox_browse
            // 
            this.picbox_browse.BaseColor = System.Drawing.Color.White;
            this.picbox_browse.Image = global::Food_Ordering_System.Properties.Resources.pic1;
            this.picbox_browse.Location = new System.Drawing.Point(578, 132);
            this.picbox_browse.Name = "picbox_browse";
            this.picbox_browse.Size = new System.Drawing.Size(146, 128);
            this.picbox_browse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_browse.TabIndex = 14;
            this.picbox_browse.TabStop = false;
            this.picbox_browse.UseTransfarantBackground = false;
            // 
            // browse_btn
            // 
            this.browse_btn.AnimationHoverSpeed = 0.07F;
            this.browse_btn.AnimationSpeed = 0.03F;
            this.browse_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.browse_btn.BorderColor = System.Drawing.Color.Black;
            this.browse_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.browse_btn.FocusedColor = System.Drawing.Color.Empty;
            this.browse_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.browse_btn.ForeColor = System.Drawing.Color.White;
            this.browse_btn.Image = ((System.Drawing.Image)(resources.GetObject("browse_btn.Image")));
            this.browse_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.browse_btn.Location = new System.Drawing.Point(581, 284);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.browse_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.browse_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.browse_btn.OnHoverImage = null;
            this.browse_btn.OnPressedColor = System.Drawing.Color.Black;
            this.browse_btn.Size = new System.Drawing.Size(143, 42);
            this.browse_btn.TabIndex = 15;
            this.browse_btn.Text = "Browse";
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // FormProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.picbox_browse);
            this.Controls.Add(this.combo_category);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.gunaLabel2);
            this.Name = "FormProductAdd";
            this.Text = "FormProductAdd";
            this.Load += new System.EventHandler(this.FormProductAdd_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.gunaLabel2, 0);
            this.Controls.SetChildIndex(this.text_name, 0);
            this.Controls.SetChildIndex(this.gunaLabel3, 0);
            this.Controls.SetChildIndex(this.text_price, 0);
            this.Controls.SetChildIndex(this.gunaLabel4, 0);
            this.Controls.SetChildIndex(this.combo_category, 0);
            this.Controls.SetChildIndex(this.picbox_browse, 0);
            this.Controls.SetChildIndex(this.browse_btn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_browse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaComboBox combo_category;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        public Guna.UI.WinForms.GunaTextBox text_price;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        public Guna.UI.WinForms.GunaTextBox text_name;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaCirclePictureBox picbox_browse;
        private Guna.UI.WinForms.GunaButton browse_btn;
    }
}