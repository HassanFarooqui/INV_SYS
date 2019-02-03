using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using IVN_SYS.Models;

namespace IVN_SYS
{
    public partial class Sale_Entry : Form
    {
        string id;
        //List<string> productnameArray = new List<string>();
        string[] productnameArray;

      double total;
     //   double discount;
     //   double expense;
     //   double grandtotal;
        double b = 0;
        

        public Sale_Entry()
        {
            InitializeComponent();
        }

        #region // For getting new line and next cell on press enter key
        int rowselect = 0;

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            int icolumn, irow = 0;
            // string a = GdvSaleEntry.RowCount.ToString();

            // GdvSaleEntry.Rows[0].Cells[0].Value = a;
            if (keyData == Keys.Enter)
            {
                b = 0;
                try
                {
                    if (GdvSaleEntry.CurrentCell.IsInEditMode || (this.GdvSaleEntry.Focused))
                    {
                        int R = GdvSaleEntry.Rows.Count;
                        icolumn = GdvSaleEntry.CurrentCell.ColumnIndex;
                        irow = GdvSaleEntry.CurrentCell.RowIndex;
                        rowselect = irow;
                        if (icolumn == GdvSaleEntry.Columns.Count - 2)
                        {

                            if (R > 1)
                            {
                                var qnty = GdvSaleEntry.Rows[irow].Cells[4].Value.ToString();
                                if (qnty != "0")
                                {
                                GdvSaleEntry.Rows.Add();
                                //b = 0;//for add value in total
                                this.GdvSaleEntry.Rows[R].Cells[0].Value = R+ 1;
                                fillComboboxOfGridView(R, 1);
                                GdvSaleEntry.CurrentCell = GdvSaleEntry[1, irow + 1];



                                }
                                else
                                return true;
                            }
                            else
                            {
                                if (GdvSaleEntry.CurrentCell.RowIndex == GdvSaleEntry.Rows.Count - 1)
                                {
                                    var qnty = GdvSaleEntry.Rows[irow].Cells[4].Value.ToString();
                                    
                                    if (qnty != "0")
                                    {
                                        GdvSaleEntry.Rows.Add();
                                    //b = 0;//for add value in total
                                    this.GdvSaleEntry.Rows[R].Cells[0].Value = R+1;
                                    fillComboboxOfGridView(R , 1);
                                    }
                                    else
                                        return true;
                                }
                                else
                                {
                                    GdvSaleEntry.EndEdit();
                                }
                                GdvSaleEntry.CurrentCell = GdvSaleEntry[1, irow + 1];
                            }
                        }
                        //else
                        //{
                        //    if (GdvSaleEntry.CurrentCell.ColumnIndex == 3)
                        //    {
                        //        if (GdvSaleEntry.CurrentCell.RowIndex == GdvSaleEntry.Rows.Count - 1)
                        //        {
                        //            Int32 index = GdvSaleEntry.Rows.Count - 1; // this is count start 1,2,3,4,5,6
                        //            GdvSaleEntry.EndEdit();
                        //            var value = GdvSaleEntry.Rows[index].Cells[3].Value.ToString();

                        //            if (value != null)
                        //            {
                        //                GdvSaleEntry.Rows.Add();
                        //               // b = 0;//for add value in total
                        //                this.GdvSaleEntry.Rows[R ].Cells[0].Value = R;
                        //                fillComboboxOfGridView(R , 1);
                        //                GdvSaleEntry.CurrentCell = GdvSaleEntry[1, irow + 1];
                        //            }
                        //            else
                        //            {
                        //                GdvSaleEntry.EndEdit();
                        //                GdvSaleEntry.CurrentCell = GdvSaleEntry[1, irow + 1];
                        //            }
                        //        }
                        //        else
                        //        {
                        //            GdvSaleEntry.EndEdit();
                        //            GdvSaleEntry.CurrentCell = GdvSaleEntry[1, irow + 1];
                        //        }
                        //    }
                        //    else
                        //    {
                        //        GdvSaleEntry.CurrentCell = GdvSaleEntry[icolumn + 1, irow];
                        //    }
                        //}
                    }

                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.Message);
                }
                rowselect = GdvSaleEntry.CurrentCell.RowIndex;
                return true;
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion // For getting new line and next cell on press enter key

        private int GetID()
        {
            int party = 0;
            ConnectionStringClass myConnection = new ConnectionStringClass();
            SqlConnection sqlCon = myConnection.getDatabaseConnection();

            string q = "select s_no from tbl_Sale order by s_no desc;";
            SqlCommand getId = new SqlCommand(q, sqlCon);
            try
            {
                sqlCon.Open();
                int id = Convert.ToInt32(getId.ExecuteScalar()) + 1;
                party = id;
                sqlCon.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return party;
        }
        private void Sale_Entry_Load(object sender, EventArgs e) 
        {
            TbxTotal.Text = "0";
            id = Convert.ToString(this.GetID());
            TbxSno.Text = id;
            ConnectionStringClass conString = new ConnectionStringClass();
            SqlConnection myCon = conString.getDatabaseConnection();
            string query = "select party_name from tbl_AddParty";
            SqlCommand myCmd = new SqlCommand(query, myCon);
            try
            {
                myCon.Open();
                SqlDataReader PartyName = myCmd.ExecuteReader();
                while (PartyName.Read())
                {
                    string str = PartyName.GetValue(0).ToString().Trim();
                    CbxPartyName.Items.Add(str);
                }
                myCon.Close();
            }
            catch (Exception)
            {
                throw;
            }

            string queryForProductName = "select product_name from tbl_AddProduct";
            SqlCommand myCmd1 = new SqlCommand(queryForProductName, myCon);
            try
            {
                myCon.Open();
                SqlDataReader productName = myCmd1.ExecuteReader();
                List<string> productnameList = new List<string>();
                while (productName.Read())
                {
                    string str2 = productName.GetValue(0).ToString().Trim();
                    productnameList.Add(str2);
                }
                productnameArray = productnameList.ToArray();
                myCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("String array not working");
            }
            GdvSaleEntry.Rows.Clear();
            GdvSaleEntry.Rows.Add();
            fillComboboxOfGridView(0, 1);
        }


        public void fillComboboxOfGridView(int row, int column)
        {
            var abc = this.GdvSaleEntry.Rows.Count;
            DataGridViewComboBoxCell comboBox = new DataGridViewComboBoxCell();
            comboBox.Items.AddRange(productnameArray);
            this.GdvSaleEntry.Rows[row].Cells[column] = comboBox;
            
            this.GdvSaleEntry.Rows[row].Cells[column].Value = productnameArray[0];
            int b = GdvSaleEntry.Rows.Count;
            if (b == 1) 
            {
                GdvSaleEntry.Rows[0].Cells[0].Value = b;
            }
        }
        
        
        private void GdvSaleEntry_CellValidated(object sender, DataGridViewCellEventArgs e)
            {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                if (e.RowIndex > -1)
                {
                    row = GdvSaleEntry.Rows[e.RowIndex];
                    
                       
                    string Quantity = (row.Cells[2].Value != null)? row.Cells[2].Value.ToString() : "0.0";
                    string Rate = (row.Cells[3].Value != null) ? row.Cells[3].Value.ToString() : "0.0";
                    double result;
                    if (Quantity != "" || Rate != "" || Quantity != null || Rate != null)
                    {
                        if (double.TryParse(Quantity, out result) && double.TryParse(Rate, out result))
                        {
                            row.Cells[4].Value = Math.Ceiling(Convert.ToDouble(Quantity) * Convert.ToDouble(Rate));


                            //string var =  row.Cells[4].Value.ToString();
                            if (GdvSaleEntry.Rows.Count != 1)
                            {
                                if (b == 0)
                                {
                                    b = Math.Ceiling(Convert.ToDouble(Quantity) * Convert.ToDouble(Rate));
                                    total = total + b;
                                    TbxTotal.Text = total.ToString();
                                  //  GdvSaleEntry.Rows.Add();

                                }
                            }
                           
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Rate and Quantity");
                    }

                }
                else {
                    MessageBox.Show("Please Enter Item");
                }
            }
            catch (Exception ex)
            {
            MessageBox.Show("Insert Correct amount" + ex.Message);
            }
        }

        private void Calculator(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void GdvSaleEntryDeleteRow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowselect = e.RowIndex;
                if (GdvSaleEntry.Rows.Count > 1)
                {
                    if (e.RowIndex == GdvSaleEntry.NewRowIndex || e.RowIndex < 0)
                        return;

                    //Check if click is on specific column 
                    if (e.ColumnIndex == GdvSaleEntry.Columns["action"].Index)
                    {
                        //Put some logic here, for example to remove row from your binding list.
                        this.manageGridValues(e.RowIndex);
                        GdvSaleEntry.Rows.RemoveAt(e.RowIndex);
                       
                        try
                        {
                            double total_Amount = 0.0;


                         //   total_Amount = Classes.CounterSale1Methods.Cell_Amount_Sum(dataGridView2);


                         //   billAmount.Text = Math.Ceiling(total_Amount).ToString();
                           // double received_Amount = (recievedAmount.Text != "") ? Math.Ceiling(Convert.ToDouble(recievedAmount.Text)) : 0.0;

                           // refundAmount.Text = Math.Ceiling((total_Amount - received_Amount)).ToString();

                        }
                        catch
                        {


                        }
                    }
                }
                else
                {
                    if (e.RowIndex == GdvSaleEntry.NewRowIndex || e.RowIndex < 0)
                        return;

                    try
                    {
                        //Check if click is on specific column 
                        if (e.ColumnIndex == GdvSaleEntry.Columns["action"].Index)
                        {
                            //Put some logic here, for example to remove row from your binding list.


                            GdvSaleEntry.Rows[0].Cells[0].Value = 1;
                            GdvSaleEntry.Rows[0].Cells[1].Value = "";
                            GdvSaleEntry.Rows[0].Cells[2].Value = "0";
                            GdvSaleEntry.Rows[0].Cells[3].Value = "0";
                            GdvSaleEntry.Rows[0].Cells[4].Value = "0";
                           
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + "Delete 1st Row");
                    }
                  

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Row on available to delete");
            }
        }

        public void manageGridValues(int rowindex)
        {
            try
            {
                double total = Convert.ToDouble(TbxTotal.Text);
                double rowValue = Convert.ToDouble(GdvSaleEntry.Rows[rowindex].Cells[4].Value);
                double gtotal = total - rowValue;
                this.total = gtotal;
                TbxTotal.Text = gtotal.ToString();

            }
            catch (Exception)
            {

                throw;
            }
            for (int i = rowindex; i < GdvSaleEntry.Rows.Count; i++)
            {
                GdvSaleEntry.Rows[i].Cells[0].Value = i + 1;
            }

        }
    }
}
