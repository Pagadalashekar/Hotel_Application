
namespace Hotel_Application
{
    partial class Change_password
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtoldpas = new System.Windows.Forms.TextBox();
            this.txtnewpas = new System.Windows.Forms.TextBox();
            this.txthintans = new System.Windows.Forms.TextBox();
            this.txtreenterpasswors = new System.Windows.Forms.TextBox();
            this.rbtusinghintquestion = new System.Windows.Forms.RadioButton();
            this.rbtoldpassword = new System.Windows.Forms.RadioButton();
            this.cmbhintqs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtoldpas
            // 
            this.txtoldpas.Location = new System.Drawing.Point(285, 126);
            this.txtoldpas.Name = "txtoldpas";
            this.txtoldpas.Size = new System.Drawing.Size(125, 27);
            this.txtoldpas.TabIndex = 3;
            // 
            // txtnewpas
            // 
            this.txtnewpas.Location = new System.Drawing.Point(285, 191);
            this.txtnewpas.Name = "txtnewpas";
            this.txtnewpas.Size = new System.Drawing.Size(125, 27);
            this.txtnewpas.TabIndex = 4;
            // 
            // txthintans
            // 
            this.txthintans.Location = new System.Drawing.Point(615, 184);
            this.txthintans.Name = "txthintans";
            this.txthintans.Size = new System.Drawing.Size(125, 27);
            this.txthintans.TabIndex = 5;
            // 
            // txtreenterpasswors
            // 
            this.txtreenterpasswors.Location = new System.Drawing.Point(285, 251);
            this.txtreenterpasswors.Name = "txtreenterpasswors";
            this.txtreenterpasswors.Size = new System.Drawing.Size(125, 27);
            this.txtreenterpasswors.TabIndex = 6;
            // 
            // rbtusinghintquestion
            // 
            this.rbtusinghintquestion.AutoSize = true;
            this.rbtusinghintquestion.Location = new System.Drawing.Point(578, 72);
            this.rbtusinghintquestion.Name = "rbtusinghintquestion";
            this.rbtusinghintquestion.Size = new System.Drawing.Size(162, 24);
            this.rbtusinghintquestion.TabIndex = 2;
            this.rbtusinghintquestion.TabStop = true;
            this.rbtusinghintquestion.Text = "Using Hint Question";
            this.rbtusinghintquestion.UseVisualStyleBackColor = true;
            this.rbtusinghintquestion.CheckedChanged += new System.EventHandler(this.rbtusinghintquestion_CheckedChanged);
            // 
            // rbtoldpassword
            // 
            this.rbtoldpassword.AutoSize = true;
            this.rbtoldpassword.Location = new System.Drawing.Point(269, 72);
            this.rbtoldpassword.Name = "rbtoldpassword";
            this.rbtoldpassword.Size = new System.Drawing.Size(160, 24);
            this.rbtoldpassword.TabIndex = 1;
            this.rbtoldpassword.TabStop = true;
            this.rbtoldpassword.Text = "Using Old Password";
            this.rbtoldpassword.UseVisualStyleBackColor = true;
            this.rbtoldpassword.CheckedChanged += new System.EventHandler(this.rbtoldpassword_CheckedChanged);
            // 
            // cmbhintqs
            // 
            this.cmbhintqs.FormattingEnabled = true;
            this.cmbhintqs.Location = new System.Drawing.Point(608, 126);
            this.cmbhintqs.Name = "cmbhintqs";
            this.cmbhintqs.Size = new System.Drawing.Size(151, 28);
            this.cmbhintqs.TabIndex = 8;
           // this.cmbhintqs.SelectedIndexChanged += new System.EventHandler(this.cmbhintqs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Old Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select Hint Question";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hint Answer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Re Enter New Password";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(348, 406);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(94, 29);
            this.btnsubmit.TabIndex = 14;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(513, 406);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(94, 29);
            this.btnclose.TabIndex = 15;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // Change_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 556);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbhintqs);
            this.Controls.Add(this.txtreenterpasswors);
            this.Controls.Add(this.txthintans);
            this.Controls.Add(this.txtnewpas);
            this.Controls.Add(this.txtoldpas);
            this.Controls.Add(this.rbtusinghintquestion);
            this.Controls.Add(this.rbtoldpassword);
            this.Controls.Add(this.label1);
            this.Name = "Change_password";
            this.Text = "Change_password";
            this.Load += new System.EventHandler(this.Change_password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtoldpas;
        private System.Windows.Forms.TextBox txtnewpas;
        private System.Windows.Forms.TextBox txthintans;
        private System.Windows.Forms.TextBox txtreenterpasswors;
        private System.Windows.Forms.RadioButton rbtusinghintquestion;
        private System.Windows.Forms.RadioButton rbtoldpassword;
        private System.Windows.Forms.ComboBox cmbhintqs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnclose;
    }
}