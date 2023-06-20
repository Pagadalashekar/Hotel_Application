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
    public partial class Delete_Item : Form
    {
        SqlConnection con; SqlDataAdapter da; DataSet ds;
        DataRow rec; SqlCommand cmd;
        public Delete_Item()
        {
            InitializeComponent();
        }

        

        private void btndelete_Click(object sender, EventArgs e)
        {
            rec = ds.Tables[0].Rows.Find(txtitem.Text);
            rec.Delete();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(da);// UPDATE, INSERT, and DELETE commands to be generated for the adapter
            builder.GetInsertCommand();
            DataTable finalDatatab = new DataTable();
            finalDatatab = (DataTable)dgvHdelete.DataSource;
            da.Update(finalDatatab);
            con.Close();
            MessageBox.Show("dataset data is updated to database");
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHdelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rec = ds.Tables[0].Rows[e.RowIndex];
            txtitem.Text = rec[0].ToString();
            txtprice.Text = rec[1].ToString();
        }

        private void Delete_Item_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"server=LAPTOP-2JR01J67\SQLEXPRESS;User ID=sa;password=shekar@20121999;Database=MyDataBase");
            cmd = new SqlCommand("Select * from Hitems details", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Hitems details");
            da.FillSchema(ds, SchemaType.Source, "Hitems details");
            dgvHdelete.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
