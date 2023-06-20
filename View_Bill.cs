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
    public partial class View_Bill : Form
    {
        SqlConnection con;
        SqlDataAdapter Da;
        string StrQuery;
        SqlCommand Cmd;

        DataSet Ds;
        public View_Bill()
        {
            InitializeComponent();
        }

        private void View_Bill_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"server=LAPTOP-2JR01J67\SQLEXPRESS;User ID=sa;password=shekar@20121999;Database=MyDataBase");
            DataSet ds;
            StrQuery = "select BillNumber from HbillMaster";
            Cmd = new SqlCommand(StrQuery, con);
            Cmd.CommandType = CommandType.Text;
            con.Open();
            DataTable table = new DataTable();
            SqlDataReader reader = Cmd.ExecuteReader();
            table.Load(reader);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cmbbillnumber.Items.Add(table.Rows[i][0]);
            }
            con.Close();


        }

        private void dgvbilldetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string BillNumber = dgvbilldetails.Rows[e.RowIndex].Cells[0].Value.ToString();
            StrQuery = "Select * From HbillTrans where BillNumber=" + BillNumber;
            Da = new SqlDataAdapter(StrQuery, con);
            DataSet ds = new DataSet();
            con.Open();
            Da.Fill(ds, "BillDetails");
            con.Close();
            dgvitemdetails.DataSource = ds.Tables[0];
        }

        private void cmbbillnumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            var BillNumber = cmbbillnumber.SelectedItem;
            StrQuery = "Select * From HBillMaster where BillNumber=" + BillNumber;
            Da = new SqlDataAdapter(StrQuery, con);
            DataSet ds = new DataSet();
            con.Open();
            Da.Fill(ds, "BillDetails");
            con.Close();
            dgvbilldetails.DataSource = ds.Tables[0];
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
