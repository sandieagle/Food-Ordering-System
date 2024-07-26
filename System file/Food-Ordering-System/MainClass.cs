﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Ordering_System
{
    internal class MainClass
    {
        public static readonly string con_string = "Data Source= DESKTOP-26CRISN\\SQLEXPRESS; Initial Catalog=Food-Ordering-System;Integrated Security=True;";
        public static SqlConnection con = new SqlConnection(con_string); 


        //Method to check user validation

        public static bool IsvalidUser(string user,string pass)
        {
            bool isValid = false;

            string qry = @"Select * from users where username ='"+user+"' and upass ='"+pass+"'  ";
            SqlCommand cmd = new SqlCommand(qry,con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
                USER = "Hello, "+dt.Rows[0]["uName"] + " !";
            }

            return isValid;
        }

        //Create Propoty for User

        public static string user;

        public static string USER { 
            get
            {
                return user;
            }
            private set
            {
                user = value;
            }
        }

        //Method of CRUD operations
        public static int SQ1(string qry,Hashtable ht)
        {
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;

                foreach(DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                res = cmd.ExecuteNonQuery();

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
              
            }
            return res;
        }

        //For Loading data from database
        public static void LoadData(string qry,DataGridView gv,ListBox lb)
        {
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);

            try
            {
                SqlCommand cmd = new SqlCommand (qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for(int i = 0; i < lb.Items.Count; i++)
                {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI.WinForms.GunaDataGridView gv = (Guna.UI.WinForms.GunaDataGridView)sender;
            int count = 0;

            foreach(DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        public static void Blurbackground(Form Model)
        {
            Form Background = new Form();
            using (Model)
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.Size = MainForm.Instance.Size;
                Background.Location = MainForm.Instance.Location ;
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();   
            }
        }

        //For Cb File
        public static void CBFill(string qry, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(qry,con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb.DisplayMember = "Name";
            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;
        }

    }
}
