namespace Dentalcl
{
    partial class signuppage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signuppage));
            this.label1 = new System.Windows.Forms.Label();
            this.newstaffname = new System.Windows.Forms.TextBox();
            this.newemailstaff = new System.Windows.Forms.TextBox();
            this.newpasswordstaff = new System.Windows.Forms.TextBox();
            this.confirmcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.regester = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(97, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // newstaffname
            // 
            this.newstaffname.BackColor = System.Drawing.SystemColors.HighlightText;
            this.newstaffname.Location = new System.Drawing.Point(267, 126);
            this.newstaffname.Name = "newstaffname";
            this.newstaffname.Size = new System.Drawing.Size(255, 22);
            this.newstaffname.TabIndex = 1;
            this.newstaffname.TextChanged += new System.EventHandler(this.newstaffname_TextChanged);
            // 
            // newemailstaff
            // 
            this.newemailstaff.BackColor = System.Drawing.SystemColors.HighlightText;
            this.newemailstaff.Location = new System.Drawing.Point(267, 186);
            this.newemailstaff.Name = "newemailstaff";
            this.newemailstaff.Size = new System.Drawing.Size(255, 22);
            this.newemailstaff.TabIndex = 2;
            // 
            // newpasswordstaff
            // 
            this.newpasswordstaff.BackColor = System.Drawing.SystemColors.HighlightText;
            this.newpasswordstaff.Location = new System.Drawing.Point(267, 270);
            this.newpasswordstaff.Name = "newpasswordstaff";
            this.newpasswordstaff.Size = new System.Drawing.Size(255, 22);
            this.newpasswordstaff.TabIndex = 3;
            this.newpasswordstaff.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // confirmcode
            // 
            this.confirmcode.BackColor = System.Drawing.SystemColors.HighlightText;
            this.confirmcode.Location = new System.Drawing.Point(267, 351);
            this.confirmcode.Name = "confirmcode";
            this.confirmcode.Size = new System.Drawing.Size(255, 22);
            this.confirmcode.TabIndex = 4;
            this.confirmcode.TextChanged += new System.EventHandler(this.confirmcode_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(97, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(97, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "password";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(97, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "confirm code";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // regester
            // 
            this.regester.Location = new System.Drawing.Point(684, 511);
            this.regester.Name = "regester";
            this.regester.Size = new System.Drawing.Size(261, 34);
            this.regester.TabIndex = 9;
            this.regester.Text = "Register";
            this.regester.UseVisualStyleBackColor = true;
            this.regester.Click += new System.EventHandler(this.regester_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // signuppage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(960, 588);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.regester);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmcode);
            this.Controls.Add(this.newpasswordstaff);
            this.Controls.Add(this.newemailstaff);
            this.Controls.Add(this.newstaffname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signuppage";
            this.Text = "signuppage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newstaffname;
        private System.Windows.Forms.TextBox newemailstaff;
        private System.Windows.Forms.TextBox newpasswordstaff;
        private System.Windows.Forms.TextBox confirmcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button regester;
        private System.Windows.Forms.Button button1;
    }
}