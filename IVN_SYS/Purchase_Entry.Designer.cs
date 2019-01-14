namespace IVN_SYS
{
    partial class Purchase_Entry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CbxPartyName = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TbxSno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GdvProducts = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kgQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.TbxTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TbxDiscount = new System.Windows.Forms.TextBox();
            this.TbxGrandTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TbxExpense = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GdvProducts)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::IVN_SYS.Properties.Resources.nav_bar_;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(308, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Entry";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.CbxPartyName);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.TbxSno);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 101);
            this.panel2.TabIndex = 1;
            // 
            // CbxPartyName
            // 
            this.CbxPartyName.BackColor = System.Drawing.Color.Silver;
            this.CbxPartyName.FormattingEnabled = true;
            this.CbxPartyName.Location = new System.Drawing.Point(551, 47);
            this.CbxPartyName.Name = "CbxPartyName";
            this.CbxPartyName.Size = new System.Drawing.Size(242, 21);
            this.CbxPartyName.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(550, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(445, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Party Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(103, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 20);
            this.textBox1.TabIndex = 3;
            // 
            // TbxSno
            // 
            this.TbxSno.BackColor = System.Drawing.Color.Silver;
            this.TbxSno.Enabled = false;
            this.TbxSno.Location = new System.Drawing.Point(103, 14);
            this.TbxSno.Name = "TbxSno";
            this.TbxSno.Size = new System.Drawing.Size(287, 20);
            this.TbxSno.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Challen No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "S NO :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GdvProducts);
            this.panel3.Location = new System.Drawing.Point(12, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(812, 189);
            this.panel3.TabIndex = 2;
            // 
            // GdvProducts
            // 
            this.GdvProducts.AllowUserToAddRows = false;
            this.GdvProducts.AllowUserToDeleteRows = false;
            this.GdvProducts.AllowUserToResizeColumns = false;
            this.GdvProducts.AllowUserToResizeRows = false;
            this.GdvProducts.BackgroundColor = System.Drawing.Color.White;
            this.GdvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GdvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GdvProducts.ColumnHeadersHeight = 30;
            this.GdvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.itemName,
            this.kgQty,
            this.Rate,
            this.Amount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GdvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.GdvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GdvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GdvProducts.Location = new System.Drawing.Point(0, 0);
            this.GdvProducts.MultiSelect = false;
            this.GdvProducts.Name = "GdvProducts";
            this.GdvProducts.ReadOnly = true;
            this.GdvProducts.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.GdvProducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GdvProducts.RowTemplate.DividerHeight = 10;
            this.GdvProducts.RowTemplate.Height = 30;
            this.GdvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GdvProducts.ShowEditingIcon = false;
            this.GdvProducts.Size = new System.Drawing.Size(812, 189);
            this.GdvProducts.TabIndex = 10;
            // 
            // code
            // 
            this.code.HeaderText = "Code";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Width = 108;
            // 
            // itemName
            // 
            this.itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            this.itemName.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemName.Width = 400;
            // 
            // kgQty
            // 
            this.kgQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.kgQty.HeaderText = "Kg/Qty";
            this.kgQty.Name = "kgQty";
            this.kgQty.ReadOnly = true;
            this.kgQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.TbxTotal);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.BtnSave);
            this.panel4.Controls.Add(this.TbxDiscount);
            this.panel4.Controls.Add(this.TbxGrandTotal);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.TbxExpense);
            this.panel4.Location = new System.Drawing.Point(12, 389);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(812, 100);
            this.panel4.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(89, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TbxTotal
            // 
            this.TbxTotal.BackColor = System.Drawing.Color.Silver;
            this.TbxTotal.Location = new System.Drawing.Point(89, 7);
            this.TbxTotal.Name = "TbxTotal";
            this.TbxTotal.Size = new System.Drawing.Size(277, 20);
            this.TbxTotal.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Total :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(408, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Discount :";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Lime;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Image = global::IVN_SYS.Properties.Resources.calculator;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(170, 60);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 35);
            this.BtnSave.TabIndex = 45;
            this.BtnSave.Text = "&Cal";
            this.BtnSave.UseVisualStyleBackColor = false;
            // 
            // TbxDiscount
            // 
            this.TbxDiscount.BackColor = System.Drawing.Color.Silver;
            this.TbxDiscount.Location = new System.Drawing.Point(512, 7);
            this.TbxDiscount.Name = "TbxDiscount";
            this.TbxDiscount.Size = new System.Drawing.Size(285, 20);
            this.TbxDiscount.TabIndex = 6;
            // 
            // TbxGrandTotal
            // 
            this.TbxGrandTotal.BackColor = System.Drawing.Color.Silver;
            this.TbxGrandTotal.Location = new System.Drawing.Point(512, 33);
            this.TbxGrandTotal.Name = "TbxGrandTotal";
            this.TbxGrandTotal.Size = new System.Drawing.Size(285, 20);
            this.TbxGrandTotal.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(408, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Grand Total :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Expense :";
            // 
            // TbxExpense
            // 
            this.TbxExpense.BackColor = System.Drawing.Color.Silver;
            this.TbxExpense.Location = new System.Drawing.Point(89, 36);
            this.TbxExpense.Name = "TbxExpense";
            this.TbxExpense.Size = new System.Drawing.Size(277, 20);
            this.TbxExpense.TabIndex = 5;
            // 
            // Purchase_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 497);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Purchase_Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase_Entry";
            this.Load += new System.EventHandler(this.Purchase_Entry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GdvProducts)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxSno;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CbxPartyName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TbxTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TbxDiscount;
        private System.Windows.Forms.TextBox TbxGrandTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbxExpense;
        private System.Windows.Forms.DataGridView GdvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}