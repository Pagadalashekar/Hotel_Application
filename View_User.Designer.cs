
namespace Hotel_Application
{
    partial class View_User
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
            this.dgvviewuser = new System.Windows.Forms.DataGridView();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewuser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvviewuser
            // 
            this.dgvviewuser.AllowUserToOrderColumns = true;
            this.dgvviewuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvviewuser.Location = new System.Drawing.Point(154, 56);
            this.dgvviewuser.Name = "dgvviewuser";
            this.dgvviewuser.RowHeadersWidth = 51;
            this.dgvviewuser.RowTemplate.Height = 29;
            this.dgvviewuser.Size = new System.Drawing.Size(540, 288);
            this.dgvviewuser.TabIndex = 0;
            this.dgvviewuser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvviewuser_CellContentClick);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(337, 465);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(94, 29);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // View_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 576);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.dgvviewuser);
            this.Name = "View_User";
            this.Text = "View_User";
            this.Load += new System.EventHandler(this.View_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewuser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvviewuser;
        private System.Windows.Forms.Button btnclose;
    }
}