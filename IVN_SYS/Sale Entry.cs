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
        double discount;
        double expense;
        double grandtotal;
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
                        if (icolumn == GdvSaleEntry.Columns.Count - 1)
                        {

                            if (R > 1)
                            {
                                // var qnty = GdvSaleEntry.Rows[irow].Cells[4].Value;
                                //if (qnty != null)
                                //{
                                GdvSaleEntry.Rows.Add();
                                //b = 0;//for add value in total
                                this.GdvSaleEntry.Rows[R].Cells[0].Value = R+ 1;
                                fillComboboxOfGridView(R, 1);
                                GdvSaleEntry.CurrentCell = GdvSaleEntry[1, irow + 1];



                                //}
                                //else
                                //  return true;
                            }
                            else
                            {
                                if (GdvSaleEntry.CurrentCell.RowIndex == GdvSaleEntry.Rows.Count - 1)
                                {
                                    GdvSaleEntry.Rows.Add();
                                    //b = 0;//for add value in total
                                    this.GdvSaleEntry.Rows[R].Cells[0].Value = R+1;
                                    fillComboboxOfGridView(R , 1);
                                }
                                else
                                {
                                    GdvSaleEntry.EndEdit();
                                }
                                GdvSaleEntry.CurrentCell = GdvSaleEntry[1, irow + 1];
                            }
                        }
                        else
                        {
                            if (GdvSaleEntry.CurrentCell.ColumnIndex == 3)
                            {
                                if (GdvSaleEntry.CurrentCell.RowIndex == GdvSaleEntry.Rows.Count - 1)
                                {
                                    Int32 index = GdvSaleEntry.Rows.Count - 1; // this is count start 1,2,3,4,5,6
                                    GdvSaleEntry.EndEdit();
                                    var value = GdvSaleEntry.Rows[index].Cells[3].Value.ToString();

                                    if (value != null)
                                    {
                                        GdvSaleEntry.Rows.Add();
                                       // b = 0;//for add value in total
                                        this.GdvSaleEntry.Rows[R ].Cells[0].Value = R;
                                        fillComboboxOfGridView(R , 1);
                                        GdvSaleEntry.CurrentCell = GdvSaleEntry[1, irow + 1];
                                    }
                                    else
                                    {
                                        GdvSaleEntry.EndEdit();
                                        GdvSaleEntry.CurrentCell = GdvSaleEntry[1, irow + 1];
                                    }
                                }
                                else
                                {
                                    GdvSaleEntry.EndEdit();
                                    GdvSaleEntry.CurrentCell = GdvSaleEntry[1, irow + 1];
                                }
                            }
                            else
                            {
                                GdvSaleEntry.CurrentCell = GdvSaleEntry[icolumn + 1, irow];
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                    string valueA = row.Cells[2].Value.ToString();
                    string valueB = row.Cells[3].Value.ToString();
                    double result;
                    if (valueA != "" || valueB != "" || valueA != null || valueB != null)
                    {
                        if (double.TryParse(valueA, out result) && double.TryParse(valueB, out result))
                        {
                            row.Cells[4].Value = Math.Ceiling(Convert.ToDouble(valueA) * Convert.ToDouble(valueB));


                            //string var =  row.Cells[4].Value.ToString();
                            if (GdvSaleEntry.Rows.Count != 1)
                            {
                                if (b == 0)
                                {
                                    b = Math.Ceiling(Convert.ToDouble(valueA) * Convert.ToDouble(valueB));
                                    total = total + b;
                                    TbxTotal.Text = total.ToString();

                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insert Correct value in rate and qty");
                    }
                    
                }
            }
            catch (Exception ex)
            {

               // MessageBox.Show("Insert Correct amount" + ex.Message);
            }
        }

        private void Calculator(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }
    }
}
