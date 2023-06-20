
namespace Hotel_Application
{
    partial class Delete_user
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvdeleteuser = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeleteuser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdeleteuser
            // 
            this.dgvdeleteuser.AllowUserToOrderColumns = true;
            this.dgvdeleteuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdeleteuser.Location = new System.Drawing.Point(94, 32);
            this.dgvdeleteuser.Name = "dgvdeleteuser";
            this.dgvdeleteuser.RowHeadersWidth = 51;
            this.dgvdeleteuser.RowTemplate.Height = 29;
            this.dgvdeleteuser.Size = new System.Drawing.Size(576, 368);
            this.dgvdeleteuser.TabIndex = 0;
            this.dgvdeleteuser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdeleteuser_CellContentClick);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(192, 462);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(94, 29);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(437, 462);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(94, 29);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(306, 462);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(94, 29);
            this.btndel.TabIndex = 3;
            this.btndel.Text = "Save";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // Delete_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 633);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dgvdeleteuser);
            this.Name = "Delete_user";
            this.Text = "Delete_user";
            this.Load += new System.EventHandler(this.Delete_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeleteuser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdeleteuser;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndel;
    }
}