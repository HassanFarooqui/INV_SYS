using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IVN_SYS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddProduct(object sender, EventArgs e)
        {
            Add_Product add_prod = new Add_Product();
            add_prod.ShowDialog();
        }

        private void AddParty(object sender, EventArgs e)
        {
            Add_Party add_party = new Add_Party();
            add_party.ShowDialog();
        }

        private void SaleEntry(object sender, EventArgs e)
        {
            Sale_Entry sale_entry = new Sale_Entry();
            sale_entry.ShowDialog();
        }

        private void Purchase_Entry(object sender, EventArgs e)
        {
            Purchase_Entry purchase_entry = new Purchase_Entry();
            purchase_entry.ShowDialog();
        }

        private void Payment(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.ShowDialog();
        }

        private void Sale_Search(object sender, EventArgs e)
        {
            Sale_Search sale_search = new Sale_Search();
            sale_search.ShowDialog();
        }

        private void Production(object sender, EventArgs e)
        {
            Production production = new Production();
            production.ShowDialog();
        }

        private void Statement(object sender, EventArgs e)
        {
            Statement statement = new Statement();
            statement.ShowDialog();
        }

        private void Purchase_Search(object sender, EventArgs e)
        {
            Purchase_Search purchase_search = new Purchase_Search();
            purchase_search.ShowDialog();
        }
    }
}
