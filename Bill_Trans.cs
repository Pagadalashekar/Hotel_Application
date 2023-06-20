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
    public partial class Bill_Trans : Form
    {

        SqlConnection con; SqlDataAdapter da; DataSet ds;
        DataRow rec; SqlCommand cmd;string StrQuery;
        public string BillNo;
        public Bill_Trans()
        {
            InitializeComponent();
        }

        private void Bill_Trans_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"server=LAPTOP-2JR01J67\SQLEXPRESS;User ID=sa;password=shekar@20121999;Database=MyDataBase");
           
            StrQuery = "select Items from Hitems";
            cmd = new SqlCommand(StrQuery, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            DataTable table = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            table.Load(reader);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cmbitem.Items.Add(table.Rows[i][0]);
            }

            StrQuery = "Select * from HbillTrans details where BillNumber='" + BillNo + "'";
            cmd = new SqlCommand(StrQuery, con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "BillTransdetails");
            da.FillSchema(ds, SchemaType.Source, "BillTransDetails");
            dgvbill.DataSource = ds.Tables[0];
            con.Close();
        }

        private void cmbitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = cmbitem.SelectedItem;
            StrQuery = "select Price from Hitems where Items='" + item + "'";
            cmd = new SqlCommand(StrQuery, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            DataTable table = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            table.Load(reader);
            txtprice.Text = table.Rows[0][0].ToString();
            con.Close();
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            double Price = Convert.ToDouble(txtprice.Text);
            int Qty = Convert.ToInt32(txtquantity.Text);
            double TotlPrice= Price * Qty;
            txttotalprice.Text = TotlPrice.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            rec = ds.Tables[0].NewRow();
            rec[0] = BillNo;
            rec[1] = cmbitem.SelectedItem;
            rec[2] = txtprice.Text;
            rec[3] = txtquantity.Text;
            rec[4] = txttotalprice.Text;
            ds.Tables[0].Rows.Add(rec);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(da);// UPDATE, INSERT, and DELETE commands to be generated for the adapter
            builder.GetInsertCommand();
            DataTable finalDatatab = new DataTable();
            finalDatatab = (DataTable)dgvbill.DataSource;
            da.Update(finalDatatab);
            con.Close();
            MessageBox.Show("dataset data is updated to database");
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double TotalBill=0;
            for (int i = 0; i < dgvbill.Rows.Count; i++)
            {
                if (dgvbill.Rows[i].DataBoundItem!=null)
                {
                    TotalBill += Convert.ToDouble(dgvbill.Rows[i].Cells[4].Value.ToString());
                }
            }

            Bill_Master BM = new Bill_Master();
            BM.TotlaBillAmount = TotalBill.ToString();
            this.Close();
            
        }
    }
}
