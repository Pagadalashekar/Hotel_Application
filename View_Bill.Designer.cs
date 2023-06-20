
namespace Hotel_Application
{
    partial class View_Bill
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
            this.dgvbilldetails = new System.Windows.Forms.DataGridView();
            this.dgvitemdetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbbillnumber = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbilldetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitemdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbilldetails
            // 
            this.dgvbilldetails.AllowUserToOrderColumns = true;
            this.dgvbilldetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbilldetails.Location = new System.Drawing.Point(199, 83);
            this.dgvbilldetails.Name = "dgvbilldetails";
            this.dgvbilldetails.RowHeadersWidth = 51;
            this.dgvbilldetails.RowTemplate.Height = 29;
            this.dgvbilldetails.Size = new System.Drawing.Size(730, 232);
            this.dgvbilldetails.TabIndex = 0;
            this.dgvbilldetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbilldetails_CellContentClick);
            // 
            // dgvitemdetails
            // 
            this.dgvitemdetails.AllowUserToOrderColumns = true;
            this.dgvitemdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvitemdetails.Location = new System.Drawing.Point(193, 387);
            this.dgvitemdetails.Name = "dgvitemdetails";
            this.dgvitemdetails.RowHeadersWidth = 51;
            this.dgvitemdetails.RowTemplate.Height = 29;
            this.dgvitemdetails.Size = new System.Drawing.Size(736, 217);
            this.dgvitemdetails.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bill Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Bill Number";
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(468, 627);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(94, 29);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item Details";
            // 
            // cmbbillnumber
            // 
            this.cmbbillnumber.FormattingEnabled = true;
            this.cmbbillnumber.Location = new System.Drawing.Point(549, 24);
            this.cmbbillnumber.Name = "cmbbillnumber";
            this.cmbbillnumber.Size = new System.Drawing.Size(151, 28);
            this.cmbbillnumber.TabIndex = 6;
            this.cmbbillnumber.SelectedIndexChanged += new System.EventHandler(this.cmbbillnumber_SelectedIndexChanged);
            // 
            // View_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 689);
            this.Controls.Add(this.cmbbillnumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvitemdetails);
            this.Controls.Add(this.dgvbilldetails);
            this.Name = "View_Bill";
            this.Text = "View_Bill";
            this.Load += new System.EventHandler(this.View_Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbilldetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitemdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbilldetails;
        private System.Windows.Forms.DataGridView dgvitemdetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbbillnumber;
    }
}