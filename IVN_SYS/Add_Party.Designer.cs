namespace IVN_SYS
{
    partial class Add_Party
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbxPartyName = new System.Windows.Forms.TextBox();
            this.TbxAddress = new System.Windows.Forms.TextBox();
            this.TbxPhoneNo = new System.Windows.Forms.TextBox();
            this.TbxEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Party Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // TbxPartyName
            // 
            this.TbxPartyName.Location = new System.Drawing.Point(180, 43);
            this.TbxPartyName.Name = "TbxPartyName";
            this.TbxPartyName.Size = new System.Drawing.Size(100, 20);
            this.TbxPartyName.TabIndex = 6;
            // 
            // TbxAddress
            // 
            this.TbxAddress.Location = new System.Drawing.Point(180, 82);
            this.TbxAddress.Name = "TbxAddress";
            this.TbxAddress.Size = new System.Drawing.Size(100, 20);
            this.TbxAddress.TabIndex = 7;
            // 
            // TbxPhoneNo
            // 
            this.TbxPhoneNo.Location = new System.Drawing.Point(181, 131);
            this.TbxPhoneNo.Name = "TbxPhoneNo";
            this.TbxPhoneNo.Size = new System.Drawing.Size(100, 20);
            this.TbxPhoneNo.TabIndex = 8;
            // 
            // TbxEmail
            // 
            this.TbxEmail.Location = new System.Drawing.Point(181, 177);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.Size = new System.Drawing.Size(100, 20);
            this.TbxEmail.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveParty);
            // 
            // Add_Party
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TbxEmail);
            this.Controls.Add(this.TbxPhoneNo);
            this.Controls.Add(this.TbxAddress);
            this.Controls.Add(this.TbxPartyName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Add_Party";
            this.Text = "Add_Party";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbxPartyName;
        private System.Windows.Forms.TextBox TbxAddress;
        private System.Windows.Forms.TextBox TbxPhoneNo;
        private System.Windows.Forms.TextBox TbxEmail;
        private System.Windows.Forms.Button button1;
    }
}