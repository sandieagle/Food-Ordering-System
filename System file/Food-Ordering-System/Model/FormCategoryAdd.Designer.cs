namespace Food_Ordering_System.Model
{
    partial class FormCategoryAdd
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
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.text_name = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Size = new System.Drawing.Size(155, 31);
            this.gunaLabel1.Text = "Add Category";
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Image = global::Food_Ordering_System.Properties.Resources.dots;
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // close_btn
            // 
            this.close_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.close_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.close_btn.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click_1);
            // 
            // save_btn
            // 
            this.save_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.save_btn.Location = new System.Drawing.Point(53, 32);
            this.save_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.save_btn.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click_1);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(336, 100);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 253);
            this.panel2.Size = new System.Drawing.Size(336, 100);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(49, 127);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(49, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Name";
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
            this.text_name.Location = new System.Drawing.Point(45, 167);
            this.text_name.Modified = true;
            this.text_name.Name = "text_name";
            this.text_name.PasswordChar = '\0';
            this.text_name.SelectedText = "";
            this.text_name.Size = new System.Drawing.Size(246, 32);
            this.text_name.TabIndex = 3;
            // 
            // FormCategoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 353);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.gunaLabel2);
            this.Name = "FormCategoryAdd";
            this.Text = "FormCategoryAdd";
            this.Load += new System.EventHandler(this.FormCategoryAdd_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.gunaLabel2, 0);
            this.Controls.SetChildIndex(this.text_name, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI.WinForms.GunaTextBox text_name;
    }
}