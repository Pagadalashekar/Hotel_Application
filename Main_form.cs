using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Application
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
           
        }
        Add_Item_Form AF;
        Delete_Item DF;
        Create_User CUF;
        Delete_user DUF;
        Change_password CPF;
        View_User VU;
        View_Bill VBF;
        Bill_Master BMF;
        public string UserName;
        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild!=null)
            {
                this.ActiveMdiChild.Close();
            }
            if (AF==null)
            {
                AF = new Add_Item_Form();
                AF.MdiParent = this;
                AF.FormClosed += AF_FormClosed;
                AF.Show();
                
            }
            else { AF.Activate(); }
        }

        private void AF_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            AF = null;
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            if (DF == null)
            {
                DF = new Delete_Item();
                DF.MdiParent = this;
                DF.FormClosed += DF_FormClosed;
                DF.Show();
            }
            else { DF.Activate(); }
        }

        private void DF_FormClosed(object sender, FormClosedEventArgs e)
        {
            DF = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            if (CUF == null)
            {
                CUF = new Create_User();
                CUF.MdiParent = this;
                CUF.FormClosed += CUF_FormClosed;
                CUF.Show();
            }
            else { CUF.Activate(); }
        }

        private void CUF_FormClosed(object sender, FormClosedEventArgs e)
        {
            CUF = null;
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            if (DUF == null)
            {
                DUF = new Delete_user();
                DUF.MdiParent = this;
                DUF.FormClosed += DUF_FormClosed;
                DUF.Show();
            }
            else { DUF.Activate(); }
        }

        private void DUF_FormClosed(object sender, FormClosedEventArgs e)
        {
            DUF = null;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            if (CPF == null)
            {
                CPF = new Change_password();
                CPF.MdiParent = this;
                CPF.UserName = txtUserId.Text;
                CPF.FormClosed += CPF_FormClosed;
                CPF.Show();
            }
            else { CPF.Activate(); }
        }

        private void CPF_FormClosed(object sender, FormClosedEventArgs e)
        {
            CPF = null;
        }

        private void vIewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            if (VU == null)
            {
                VU = new View_User();
                VU.MdiParent = this;
                VU.FormClosed += VU_FormClosed;
                VU.Show();
            }
            else { VU.Activate(); }
        }

        private void VU_FormClosed(object sender, FormClosedEventArgs e)
        {
            VU = null;
        }

        private void viewBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            if (VBF == null)
            {
                VBF = new View_Bill();
                VBF.MdiParent = this;
                VBF.FormClosed += VBF_FormClosed;
                VBF.Show();
            }
            else { VBF.Activate(); }
        }

        private void VBF_FormClosed(object sender, FormClosedEventArgs e)
        {
            VBF = null;
        }

        private void newBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            if (BMF == null)
            {
                BMF = new Bill_Master();
                BMF.MdiParent = this;
                BMF.FormClosed += BMF_FormClosed;
                BMF.Show();
            }
            else { BMF.Activate(); }
        }

        private void BMF_FormClosed(object sender, FormClosedEventArgs e)
        {
            BMF = null;
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            txtUserId.Text = UserName;
            txtUserId.Visible = false;
        }
    }
}
