using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Application
{
    public partial class Create_User : Form
    {
        SqlConnection con; SqlDataAdapter da; DataSet ds;
        DataRow rec; SqlCommand cmd; String StrQuery;
        SqlCommand Cmd;

        public Create_User()
        {
            InitializeComponent();
            txtpassword.PasswordChar = '*';
            txtconfirmpassword.PasswordChar = '*';
        }

        private void Create_User_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"server=LAPTOP-2JR01J67\SQLEXPRESS;User ID=sa;password=shekar@20121999;Database=MyDataBase");
            cmdhint.Items.Add("Who is your favarite hero");
            cmdhint.Items.Add("Your Birthday Year");
            cmdhint.Items.Add("Your Favarite place");
            cmdhint.Items.Add("Your favarite person");
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            StrQuery = "insert into Husers values(@P1,@P2,@P3,@P4,@P5,@P6)";
            Cmd = new SqlCommand(StrQuery, con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("P1", txtusername.Text);
            Cmd.Parameters.AddWithValue("P2", txtpassword.Text);
            Cmd.Parameters.AddWithValue("P3", txtfirstname.Text);
            Cmd.Parameters.AddWithValue("P4", txtlastname.Text);
            Cmd.Parameters.AddWithValue("P5", cmdhint.SelectedItem);
            Cmd.Parameters.AddWithValue("P6", txthintanswer.Text);
            if (txtconfirmpassword.Text.Equals(txtconfirmpassword.Text))
            {
                con.Open();
                SqlDataReader reader = Cmd.ExecuteReader();
                MessageBox.Show("User Created");
                con.Close();
            }
            else
            {
                MessageBox.Show("confom password not match");
            }

            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            txtfirstname.Text = "";
            txtlastname.Text = "";
            cmdhint.SelectedIndex = -1;
            txtconfirmpassword.Text = "";
            txthintanswer.Text = "";

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdhint_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
