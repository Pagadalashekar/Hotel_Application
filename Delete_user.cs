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
    
    public partial class Delete_user : Form
    {
        SqlConnection con; SqlDataAdapter da; DataSet ds;
        DataRow rec; SqlCommand cmd;
        public int selectedRow;
        public Delete_user()
        {
            InitializeComponent();
        }

        private void dgvdeleteuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rec = ds.Tables[0].Rows[e.RowIndex];
            selectedRow = e.RowIndex;
        }

        private void Delete_user_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"server=LAPTOP-2JR01J67\SQLEXPRESS;User ID=sa;password=shekar@20121999;Database=MyDataBase");
            cmd = new SqlCommand("Select * from Husers details", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Husers details");
            da.FillSchema(ds, SchemaType.Source, "Husers details");
            dgvdeleteuser.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            rec = ds.Tables[0].Rows.Find(ds.Tables[0].Rows[selectedRow][0]);
            rec.Delete();

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(da);      // UPDATE, INSERT, and DELETE commands to be generated for the adapter
            builder.GetDeleteCommand();
            DataTable finalDatatab = new DataTable();
            finalDatatab = (DataTable)dgvdeleteuser.DataSource;
            da.Update(finalDatatab);
            con.Close();
            MessageBox.Show("dataset data is updated to database");
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
