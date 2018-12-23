namespace IVN_SYS
{
    partial class Sale_Entry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TbxSno = new System.Windows.Forms.TextBox();
            this.TbxChallenNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxPartyName = new System.Windows.Forms.ComboBox();
            this.GdvSaleEntry = new System.Windows.Forms.DataGridView();
            this.Itemcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itemdesc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kgs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TbxTotal = new System.Windows.Forms.TextBox();
            this.TbxDiscount = new System.Windows.Forms.TextBox();
            this.TbxExpense = new System.Windows.Forms.TextBox();
            this.TbxGrandTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GdvSaleEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // TbxSno
            // 
            this.TbxSno.Enabled = false;
            this.TbxSno.Location = new System.Drawing.Point(230, 12);
            this.TbxSno.Name = "TbxSno";
            this.TbxSno.Size = new System.Drawing.Size(100, 20);
            this.TbxSno.TabIndex = 0;
            // 
            // TbxChallenNo
            // 
            this.TbxChallenNo.Location = new System.Drawing.Point(231, 52);
            this.TbxChallenNo.Name = "TbxChallenNo";
            this.TbxChallenNo.Size = new System.Drawing.Size(100, 20);
            this.TbxChallenNo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "S.NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Challen No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Party Name";
            // 
            // CbxPartyName
            // 
            this.CbxPartyName.FormattingEnabled = true;
            this.CbxPartyName.Location = new System.Drawing.Point(555, 53);
            this.CbxPartyName.Name = "CbxPartyName";
            this.CbxPartyName.Size = new System.Drawing.Size(121, 21);
            this.CbxPartyName.TabIndex = 8;
            // 
            // GdvSaleEntry
            // 
            this.GdvSaleEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.GdvSaleEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GdvSaleEntry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GdvSaleEntry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GdvSaleEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GdvSaleEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Itemcode,
            this.Itemdesc,
            this.kgs,
            this.rate,
            this.amount});
            this.GdvSaleEntry.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.GdvSaleEntry.Location = new System.Drawing.Point(1, 87);
            this.GdvSaleEntry.Margin = new System.Windows.Forms.Padding(2);
            this.GdvSaleEntry.MultiSelect = false;
            this.GdvSaleEntry.Name = "GdvSaleEntry";
            this.GdvSaleEntry.RowHeadersVisible = false;
            this.GdvSaleEntry.RowTemplate.DividerHeight = 6;
            this.GdvSaleEntry.RowTemplate.Height = 24;
            this.GdvSaleEntry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GdvSaleEntry.Size = new System.Drawing.Size(835, 224);
            this.GdvSaleEntry.TabIndex = 35;
            this.GdvSaleEntry.TabStop = false;
            this.GdvSaleEntry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GdvSaleEntry_CellClick);
            this.GdvSaleEntry.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GdvSaleEntry_CellMouseClick);
            // 
            // Itemcode
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Itemcode.DefaultCellStyle = dataGridViewCellStyle2;
            this.Itemcode.DividerWidth = 1;
            this.Itemcode.HeaderText = "Code";
            this.Itemcode.Name = "Itemcode";
            this.Itemcode.Width = 58;
            // 
            // Itemdesc
            // 
            this.Itemdesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Itemdesc.DefaultCellStyle = dataGridViewCellStyle3;
            this.Itemdesc.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Itemdesc.DividerWidth = 1;
            this.Itemdesc.HeaderText = "Item Name";
            this.Itemdesc.Name = "Itemdesc";
            // 
            // kgs
            // 
            this.kgs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Format = "N5";
            dataGridViewCellStyle4.NullValue = "0";
            this.kgs.DefaultCellStyle = dataGridViewCellStyle4;
            this.kgs.DividerWidth = 1;
            this.kgs.HeaderText = "Kgs/Qty";
            this.kgs.Name = "kgs";
            this.kgs.Width = 72;
            // 
            // rate
            // 
            this.rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Format = "N5";
            dataGridViewCellStyle5.NullValue = "0";
            this.rate.DefaultCellStyle = dataGridViewCellStyle5;
            this.rate.DividerWidth = 1;
            this.rate.HeaderText = "Rate";
            this.rate.Name = "rate";
            this.rate.Width = 56;
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Format = "N6";
            dataGridViewCellStyle6.NullValue = "0";
            this.amount.DefaultCellStyle = dataGridViewCellStyle6;
            this.amount.DividerWidth = 1;
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.Width = 69;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(555, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // TbxTotal
            // 
            this.TbxTotal.Location = new System.Drawing.Point(565, 316);
            this.TbxTotal.Name = "TbxTotal";
            this.TbxTotal.Size = new System.Drawing.Size(100, 20);
            this.TbxTotal.TabIndex = 37;
            // 
            // TbxDiscount
            // 
            this.TbxDiscount.Location = new System.Drawing.Point(565, 342);
            this.TbxDiscount.Name = "TbxDiscount";
            this.TbxDiscount.Size = new System.Drawing.Size(100, 20);
            this.TbxDiscount.TabIndex = 38;
            // 
            // TbxExpense
            // 
            this.TbxExpense.Location = new System.Drawing.Point(565, 368);
            this.TbxExpense.Name = "TbxExpense";
            this.TbxExpense.Size = new System.Drawing.Size(100, 20);
            this.TbxExpense.TabIndex = 39;
            // 
            // TbxGrandTotal
            // 
            this.TbxGrandTotal.Location = new System.Drawing.Point(565, 394);
            this.TbxGrandTotal.Name = "TbxGrandTotal";
            this.TbxGrandTotal.Size = new System.Drawing.Size(100, 20);
            this.TbxGrandTotal.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Discount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Expense";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Grand Total";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(590, 420);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 40);
            this.BtnSave.TabIndex = 45;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // Sale_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 472);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbxGrandTotal);
            this.Controls.Add(this.TbxExpense);
            this.Controls.Add(this.TbxDiscount);
            this.Controls.Add(this.TbxTotal);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.GdvSaleEntry);
            this.Controls.Add(this.CbxPartyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxChallenNo);
            this.Controls.Add(this.TbxSno);
            this.Name = "Sale_Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale_Entry";
            this.Load += new System.EventHandler(this.Sale_Entry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GdvSaleEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxSno;
        private System.Windows.Forms.TextBox TbxChallenNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxPartyName;
        private System.Windows.Forms.DataGridView GdvSaleEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgs;
        private System.Windows.Forms.DataGridViewComboBoxColumn Itemdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itemcode;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TbxTotal;
        private System.Windows.Forms.TextBox TbxDiscount;
        private System.Windows.Forms.TextBox TbxExpense;
        private System.Windows.Forms.TextBox TbxGrandTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnSave;
    }
}