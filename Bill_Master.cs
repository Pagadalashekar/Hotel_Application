using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotel_Application
{
    public partial class Bill_Master : Form
    {
        SqlConnection con; SqlDataAdapter da; DataSet ds;
        DataRow rec; SqlCommand cmd; String StrQuery;
        SqlCommand Cmd;
        public string TotlaBillAmount;
        public Bill_Master()
        {
            InitializeComponent();
        }

        private void btnadditems_Click(object sender, EventArgs e)
        {
            Bill_Trans BTF = new Bill_Trans();
            BTF.BillNo = txtbillno.Text;
            BTF.Show();
            //comment added
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            StrQuery = "insert into HbillMaster values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)";
            Cmd = new SqlCommand(StrQuery, con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("P1", txtbillno.Text);
            Cmd.Parameters.AddWithValue("P2", Convert.ToDateTime(txtbilldate.Text));
            Cmd.Parameters.AddWithValue("P3", txtbillamount.Text);
            Cmd.Parameters.AddWithValue("P4", txtsgst.Text);
            Cmd.Parameters.AddWithValue("P5", txtcgst.Text);
            Cmd.Parameters.AddWithValue("P6", txtenterdiscount.Text);
            Cmd.Parameters.AddWithValue("P7", txttotalbill.Text);
            Cmd.Parameters.AddWithValue("P8", "Shekar");

            con.Open();
            SqlDataReader reader = Cmd.ExecuteReader();
            MessageBox.Show("Bill Created");
            con.Close();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            var billNo = txtbillno.Text;
            StrQuery = "Select Sum(TotalPrice) From HbillTrans where BillNumber='" + billNo + "'";
            cmd = new SqlCommand(StrQuery, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            DataTable table = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            table.Load(reader);
            txtbillamount.Text = table.Rows[0][0].ToString();
            con.Close();
        }

        private void Bill_Master_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"server=LAPTOP-2JR01J67\SQLEXPRESS;User ID=sa;password=shekar@20121999;Database=MyDataBase");
            txtbilldate.Text = System.DateTime.Today.ToString();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double FinalBill = 0;
            FinalBill = (Convert.ToDouble(txtbillamount.Text) + Convert.ToDouble(txtsgst.Text) + Convert.ToDouble(txtcgst.Text)) - Convert.ToDouble(txtenterdiscount.Text);
            txttotalbill.Text = FinalBill.ToString();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
