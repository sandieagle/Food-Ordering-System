namespace Food_Ordering_System
{
    partial class SampleView
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
            this.text_search = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.add_img_btn = new Guna.UI.WinForms.GunaImageButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.SuspendLayout();
            // 
            // text_search
            // 
            this.text_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_search.BaseColor = System.Drawing.Color.White;
            this.text_search.BorderColor = System.Drawing.Color.Silver;
            this.text_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_search.FocusedBaseColor = System.Drawing.Color.White;
            this.text_search.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.text_search.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.text_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_search.Location = new System.Drawing.Point(452, 105);
            this.text_search.Name = "text_search";
            this.text_search.PasswordChar = '\0';
            this.text_search.SelectedText = "";
            this.text_search.Size = new System.Drawing.Size(321, 32);
            this.text_search.TabIndex = 0;
            this.text_search.TextChanged += new System.EventHandler(this.text_search_TextChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(447, 77);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(64, 25);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Search";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // add_img_btn
            // 
            this.add_img_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add_img_btn.Image = global::Food_Ordering_System.Properties.Resources.add;
            this.add_img_btn.ImageSize = new System.Drawing.Size(64, 64);
            this.add_img_btn.Location = new System.Drawing.Point(29, 82);
            this.add_img_btn.Name = "add_img_btn";
            this.add_img_btn.OnHoverImage = null;
            this.add_img_btn.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.add_img_btn.Size = new System.Drawing.Size(64, 64);
            this.add_img_btn.TabIndex = 2;
            this.add_img_btn.Click += new System.EventHandler(this.add_img_btn_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(126, 105);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(104, 25);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Header Text";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(13, 152);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(760, 10);
            this.gunaSeparator1.TabIndex = 4;
            // 
            // SampleView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.add_img_btn);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.text_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SampleView";
            this.Text = "SampleView";
            this.Load += new System.EventHandler(this.SampleView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        public Guna.UI.WinForms.GunaTextBox text_search;
        public Guna.UI.WinForms.GunaImageButton add_img_btn;
        public Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}