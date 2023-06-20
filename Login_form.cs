using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Application
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server = LAPTOP-2JR01J67\SQLEXPRESS; User ID = sa; password = shekar@20121999; Database = MyDataBase");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Husers where Username='" + txtusername.Text +"' and Password ='" + txtpassword.Text + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                
                this.Show();
                Main_form Mainform = new Main_form();
                Mainform.UserName = txtusername.Text;
                Mainform.Show();
                
            }
            else
            {
                MessageBox.Show("Please Check UserName and Password");
            }
           

          
        }

        private void Login_form_Load(object sender, EventArgs e)
        {

        }
    }
}
