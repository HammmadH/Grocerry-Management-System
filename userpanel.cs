using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMS
{
    public partial class userpanel : Form
    {
        private Dictionary<string, string> itemsDictionary = new Dictionary<string, string>();
        private List<string> cartItems = new List<string>();
        public userpanel()
        {
            InitializeComponent();
            LoadItemsFromFile();
        }

        private void closeicon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backicon_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void LoadItemsFromFile()
        {
            string[] lines = File.ReadAllLines("items.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                itemsDictionary.Add(parts[0], parts[1]);
            }

            datagridviewitem.Rows.Clear();
            foreach (var item in itemsDictionary)
            {
                datagridviewitem.Rows.Add(item.Key, item.Value);
            }
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            if (datagridviewitem.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to order.");
            }

            string itemName = datagridviewitem.SelectedRows[0].Cells[0].Value.ToString();
            string itemPrice = datagridviewitem.SelectedRows[0].Cells[1].Value.ToString();
            int quantity;

            if (!int.TryParse(txtitemquantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
            }
            decimal itemprice = decimal.Parse(itemPrice);
            string orderInfo = $"{itemName} - Quantity: {quantity} - Total Price: {itemprice * quantity}";
            cartItems.Add(orderInfo);
            lstbxcart.Items.Add(orderInfo);
            txtitemquantity.Clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (lstbxcart.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to delete.");
            }

            cartItems.RemoveAt(lstbxcart.SelectedIndex);
            lstbxcart.Items.RemoveAt(lstbxcart.SelectedIndex);
        }

        private void btnorderproceed_Click(object sender, EventArgs e)
        {
            string userName = txtusername.Text;
            string userNumber = txtusernum.Text;
            string userEmail = txtuseremail.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(userNumber) || string.IsNullOrWhiteSpace(userEmail))
            {
                MessageBox.Show("Please fill in all the user information.");
            }

            if (lstbxcart.Items.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Please add items to proceed.");
            }

            string orderNumber;
            if (File.Exists("last_order_number.txt"))
            {
                orderNumber = File.ReadAllText("last_order_number.txt");
            }
            else
            {
                orderNumber = "000";
            }

            int nextOrderNumber = int.Parse(orderNumber) + 1;
            orderNumber = nextOrderNumber.ToString().PadLeft(3, '0');

            decimal totalPrice = 0;
            foreach (var item in cartItems)
            {
                string[] parts = item.Split('-');
                decimal itemPrice;
                if (!decimal.TryParse(parts[2].Split(':')[1].Trim(), out itemPrice))
                {
                    MessageBox.Show($"Error parsing item price: {parts[2].Split(':')[1].Trim()}");
                }
                totalPrice += itemPrice;
            }

            if (totalPrice >= 2000)
            {
                totalPrice *= 0.8m;
                MessageBox.Show("Dear " + txtusername.Text + " order placed successfully! " + " Your Order Number is = " + orderNumber + " Your Total Bill is = " + totalPrice + " Rs. 20% Discount because you shopped above 1999 Rs.", "Grocery Shop");
            }
            else if (totalPrice >= 1500)
            {
                totalPrice *= 0.9m;
                MessageBox.Show("Dear " + txtusername.Text + " order placed successfully! " + " Your Order Number is = " + orderNumber + " Your Total Bill is = " + totalPrice + " Rs. 10% Discount because you shopped above 1499 Rs.", "Grocery Shop");
            }
            else if (totalPrice >= 1000)
            {
                totalPrice *= 0.95m;
                MessageBox.Show("Dear " + txtusername.Text + " order placed successfully! " + " Your Order Number is = " + orderNumber + " Your Total Bill is = " + totalPrice + " Rs. 5% Discount because you shopped above 999 Rs.", "Grocery Shop");
            }

            string orderDetails = $"Order Number: {orderNumber}\nUser Name: {userName}\nUser Number: {userNumber}\nUser Email: {userEmail}\n\nItems Ordered:\n";

            foreach (var item in cartItems)
            {
                orderDetails += $"{item}\n";
            }

            orderDetails += $"\nTotal Price: {totalPrice}";

            decimal previousTotal = 0;
            decimal totalsales = 0;
            string[] lines = File.ReadAllLines("order.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];
                if (lastLine.StartsWith("Total Sales:"))
                {
                    string[] parts = lastLine.Split(':');
                    if (decimal.TryParse(parts[1], out previousTotal))
                    {
                        totalsales = totalPrice + previousTotal;
                    }
                }
            }
            else
            {
                totalsales = totalPrice;
            }

            orderDetails += $"\nTotal Sales: {totalsales}";

            File.WriteAllText("last_order_number.txt", orderNumber);

            File.AppendAllText("order.txt", orderDetails + Environment.NewLine);

            txtuseremail.Clear();
            txtusername.Clear();
            txtusernum.Clear();
            lstbxcart.Items.Clear();
        }

        private void userpanel_Load(object sender, EventArgs e)
        {
            lstbxcart.Hide();
        }

        private void btnshowcart_Click(object sender, EventArgs e)
        {
            lstbxcart.Show();
        }
    }
}