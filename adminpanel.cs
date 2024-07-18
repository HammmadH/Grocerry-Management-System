using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMS
{
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
            LoadItemsFromFile();
        }

        private void adminpanel_Load(object sender, EventArgs e)
        {
            txtorderdetails.Hide();
            closetextbox.Hide();
            lblorderdetails.Hide();
            lbltotalsales.Hide();
        }

        private void backicon_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void closeicon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnadditem_Click(object sender, EventArgs e)
        {
            string itemName = txtitemname.Text;
            string itemPrice = txtitemprice.Text;

            if (string.IsNullOrWhiteSpace(itemName) && string.IsNullOrWhiteSpace(itemPrice))
            {
                MessageBox.Show("Please enter item name and correct item price!");
            }

            datagridviewitem.Rows.Add(itemName, itemPrice);
            SaveItemToFile(itemName, itemPrice);
            txtitemname.Clear();
            txtitemprice.Clear();
        }

        private void SaveItemToFile(string itemName, string itemPrice)
        {
            using (StreamWriter writer = new StreamWriter("items.txt", true))
            {
                writer.WriteLine($"{itemName},{itemPrice}");
            }
        }

        private void searchitembtn_Click(object sender, EventArgs e)
        {
            string searchItemName = txtitemname.Text.ToLower();
            if (string.IsNullOrWhiteSpace(searchItemName))
            {
                MessageBox.Show("Please enter item name to search.");
            }

            foreach (DataGridViewRow row in datagridviewitem.Rows)
            {
                if (row.Cells[0].Value.ToString().ToLower().Contains(searchItemName))
                {
                    row.Selected = true;
                    datagridviewitem.CurrentCell = row.Cells[0];
                }
            }

            MessageBox.Show("Item not found.");
        }

        private void LoadItemsFromFile()
        {
            string[] lines = File.ReadAllLines("items.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                datagridviewitem.Rows.Add(parts[0], parts[1]);
            }
        }

        private void updateitembtn_Click(object sender, EventArgs e)
        {
            if (datagridviewitem.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to update.");
            }

            string itemName = txtitemname.Text;
            string itemPrice = txtitemprice.Text;

            if (string.IsNullOrWhiteSpace(itemName) && string.IsNullOrWhiteSpace(itemPrice))
            {
                MessageBox.Show("Please enter item name and correct item price!");
            }

            DataGridViewRow selectedRow = datagridviewitem.SelectedRows[0];
            selectedRow.Cells[0].Value = itemName;
            selectedRow.Cells[1].Value = itemPrice;

            UpdateItemInFile(itemName, itemPrice);

            txtitemname.Clear();
            txtitemprice.Clear();
        }

        private void UpdateItemInFile(string itemName, string itemPrice)
        {
            string[] lines = File.ReadAllLines("items.txt");
            string updatedData = $"{itemName},{itemPrice}";

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                if (parts[0].Equals(itemName, StringComparison.OrdinalIgnoreCase))
                {
                    lines[i] = updatedData;
                    break;
                }
            }

            File.WriteAllLines("items.txt", lines);
        }

        private void datagridviewitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridviewitem.Rows[e.RowIndex];
                txtitemname.Text = row.Cells[0].Value.ToString();
                txtitemprice.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btntotalsales_Click(object sender, EventArgs e)
        {
            lbltotalsales.Show();
            string[] lines = File.ReadAllLines("order.txt");

            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];
                lbltotalsales.Text = lastLine;
            }
            else
            {
                lbltotalsales.Text = "No sales data available.";
            }
        }

        private void btncheckorder_Click(object sender, EventArgs e)
        {
            txtorderdetails.Show();
            closetextbox.Show();
            lblorderdetails.Show();
            try
            {
                using (StreamReader sr = new StreamReader("order.txt"))
                {
                    string orderDetails = sr.ReadToEnd();

                    txtorderdetails.Text = orderDetails;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening order file");
            }
        }

        private void closetextbox_Click(object sender, EventArgs e)
        {
            txtorderdetails.Hide();
            lblorderdetails.Hide();
            closetextbox.Hide();
        }
    }
}
