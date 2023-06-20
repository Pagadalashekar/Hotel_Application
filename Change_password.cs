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
    public partial class Change_password : Form
    {

        SqlConnection con; SqlDataAdapter da; DataSet ds;
        DataRow rec; SqlCommand cmd;
        public int selectedRow;
        public string UserName;
        public Change_password()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbtoldpassword_CheckedChanged(object sender, EventArgs e)
        {

            label4.Visible = false;
            cmbhintqs.Visible = false;
            label5.Visible = false;
            txthintans.Visible = false;

            label2.Visible = true;
            txtoldpas.Visible = true;

        }

        private void rbtusinghintquestion_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            cmbhintqs.Visible = true;
            label5.Visible = true;
            txthintans.Visible = true;

            label2.Visible = false;
            txtoldpas.Visible = false;
        }

        private void Change_password_Load(object sender, EventArgs e)
        {
            
            
            con = new SqlConnection(@"server=LAPTOP-2JR01J67\SQLEXPRESS;User ID=sa;password=shekar@20121999;Database=MyDataBase");
            cmd = new SqlCommand("Select * from Husers Where Username='" + UserName + "'", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Husers details");
            da.FillSchema(ds, SchemaType.Source, "Husers details");
            con.Close();
            cmbhintqs.Items.Add(ds.Tables[0].Rows[0][4].ToString());
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * from Husers Where Username='" + UserName + "'", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Husers details");
            da.FillSchema(ds, SchemaType.Source, "Husers details");
            con.Close();
            if (rbtusinghintquestion.Checked==true)
            {
                if (ds.Tables[0].Rows[0][5].ToString()==txthintans.Text)
                {
                    cmd = new SqlCommand("update HUsers Set Password ='"+txtnewpas.Text + "' Where Username= '" + UserName + "'", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    MessageBox.Show("Password Changed");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Provided Answer is wrong");
                }
            }
            if (rbtoldpassword.Checked==true)
            {
                if (ds.Tables[0].Rows[0][1].ToString() == txtoldpas.Text)
                {
                    cmd = new SqlCommand("update HUsers Set Password ='" + txtnewpas.Text + "' Where Username= '" + UserName + "'", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    MessageBox.Show("Password Changed");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Old Password is wrong");
                }
            }

        }

        
    }
}
