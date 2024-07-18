namespace GMS
{
    partial class userpanel
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
            backicon = new PictureBox();
            closeicon = new PictureBox();
            datagridviewitem = new DataGridView();
            ITEMNAME = new DataGridViewTextBoxColumn();
            itemprice = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtusername = new TextBox();
            txtusernum = new TextBox();
            txtuseremail = new TextBox();
            label1 = new Label();
            txtitemquantity = new TextBox();
            label2 = new Label();
            btnorder = new Button();
            lstbxcart = new ListBox();
            btnshowcart = new Button();
            btndelete = new Button();
            btnorderproceed = new Button();
            ((System.ComponentModel.ISupportInitialize)backicon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeicon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridviewitem).BeginInit();
            SuspendLayout();
            // 
            // backicon
            // 
            backicon.BackColor = Color.Transparent;
            backicon.Image = Properties.Resources.log_in_removebg_preview;
            backicon.Location = new Point(-5, -1);
            backicon.Name = "backicon";
            backicon.Size = new Size(44, 34);
            backicon.SizeMode = PictureBoxSizeMode.Zoom;
            backicon.TabIndex = 15;
            backicon.TabStop = false;
            backicon.Click += backicon_Click;
            // 
            // closeicon
            // 
            closeicon.BackColor = Color.Transparent;
            closeicon.Image = Properties.Resources.close_new;
            closeicon.Location = new Point(761, -14);
            closeicon.Name = "closeicon";
            closeicon.Size = new Size(69, 63);
            closeicon.SizeMode = PictureBoxSizeMode.Zoom;
            closeicon.TabIndex = 14;
            closeicon.TabStop = false;
            closeicon.Click += closeicon_Click;
            // 
            // datagridviewitem
            // 
            datagridviewitem.BackgroundColor = Color.IndianRed;
            datagridviewitem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridviewitem.Columns.AddRange(new DataGridViewColumn[] { ITEMNAME, itemprice });
            datagridviewitem.Location = new Point(421, 123);
            datagridviewitem.Name = "datagridviewitem";
            datagridviewitem.Size = new Size(240, 374);
            datagridviewitem.TabIndex = 20;
            // 
            // ITEMNAME
            // 
            ITEMNAME.HeaderText = "ITEM NAME";
            ITEMNAME.Name = "ITEMNAME";
            // 
            // itemprice
            // 
            itemprice.HeaderText = "ITEM PRICE";
            itemprice.Name = "itemprice";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(143, 169);
            label5.Name = "label5";
            label5.Size = new Size(71, 24);
            label5.TabIndex = 27;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(47, 127);
            label4.Name = "label4";
            label4.Size = new Size(167, 24);
            label4.TabIndex = 26;
            label4.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(98, 88);
            label3.Name = "label3";
            label3.Size = new Size(116, 24);
            label3.TabIndex = 25;
            label3.Text = "Username";
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.IndianRed;
            txtusername.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(230, 85);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(136, 32);
            txtusername.TabIndex = 28;
            // 
            // txtusernum
            // 
            txtusernum.BackColor = Color.IndianRed;
            txtusernum.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusernum.Location = new Point(230, 124);
            txtusernum.Name = "txtusernum";
            txtusernum.Size = new Size(136, 32);
            txtusernum.TabIndex = 29;
            // 
            // txtuseremail
            // 
            txtuseremail.BackColor = Color.IndianRed;
            txtuseremail.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuseremail.Location = new Point(230, 166);
            txtuseremail.Name = "txtuseremail";
            txtuseremail.Size = new Size(136, 32);
            txtuseremail.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 9);
            label1.Name = "label1";
            label1.Size = new Size(328, 59);
            label1.TabIndex = 31;
            label1.Text = "USER PANEL";
            // 
            // txtitemquantity
            // 
            txtitemquantity.BackColor = Color.IndianRed;
            txtitemquantity.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtitemquantity.Location = new Point(588, 85);
            txtitemquantity.Name = "txtitemquantity";
            txtitemquantity.Size = new Size(142, 32);
            txtitemquantity.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(421, 88);
            label2.Name = "label2";
            label2.Size = new Size(161, 24);
            label2.TabIndex = 32;
            label2.Text = "Item Quantity";
            // 
            // btnorder
            // 
            btnorder.BackColor = Color.IndianRed;
            btnorder.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnorder.Location = new Point(667, 268);
            btnorder.Name = "btnorder";
            btnorder.Size = new Size(135, 42);
            btnorder.TabIndex = 34;
            btnorder.Text = "Order";
            btnorder.UseVisualStyleBackColor = false;
            btnorder.Click += btnorder_Click;
            // 
            // lstbxcart
            // 
            lstbxcart.BackColor = Color.IndianRed;
            lstbxcart.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstbxcart.FormattingEnabled = true;
            lstbxcart.ItemHeight = 29;
            lstbxcart.Location = new Point(211, 221);
            lstbxcart.Name = "lstbxcart";
            lstbxcart.Size = new Size(173, 236);
            lstbxcart.TabIndex = 35;
            // 
            // btnshowcart
            // 
            btnshowcart.BackColor = Color.IndianRed;
            btnshowcart.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnshowcart.Location = new Point(167, 463);
            btnshowcart.Name = "btnshowcart";
            btnshowcart.Size = new Size(122, 34);
            btnshowcart.TabIndex = 36;
            btnshowcart.Text = "Show Cart";
            btnshowcart.UseVisualStyleBackColor = false;
            btnshowcart.Click += btnshowcart_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.IndianRed;
            btndelete.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.Location = new Point(295, 463);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(117, 34);
            btndelete.TabIndex = 37;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btnorderproceed
            // 
            btnorderproceed.BackColor = Color.IndianRed;
            btnorderproceed.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnorderproceed.Location = new Point(12, 298);
            btnorderproceed.Name = "btnorderproceed";
            btnorderproceed.Size = new Size(184, 63);
            btnorderproceed.TabIndex = 38;
            btnorderproceed.Text = "Order Proceed";
            btnorderproceed.UseVisualStyleBackColor = false;
            btnorderproceed.Click += btnorderproceed_Click;
            // 
            // userpanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images__3_;
            ClientSize = new Size(814, 539);
            Controls.Add(btnorderproceed);
            Controls.Add(btndelete);
            Controls.Add(btnshowcart);
            Controls.Add(lstbxcart);
            Controls.Add(btnorder);
            Controls.Add(txtitemquantity);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtuseremail);
            Controls.Add(txtusernum);
            Controls.Add(txtusername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(datagridviewitem);
            Controls.Add(backicon);
            Controls.Add(closeicon);
            Name = "userpanel";
            Text = "userpanel";
            Load += userpanel_Load;
            ((System.ComponentModel.ISupportInitialize)backicon).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeicon).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridviewitem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox backicon;
        private PictureBox closeicon;
        private DataGridView datagridviewitem;
        private DataGridViewTextBoxColumn ITEMNAME;
        private DataGridViewTextBoxColumn itemprice;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtusername;
        private TextBox txtusernum;
        private TextBox txtuseremail;
        private Label label1;
        private TextBox txtitemquantity;
        private Label label2;
        private Button btnorder;
        private ListBox lstbxcart;
        private Button btnshowcart;
        private Button btndelete;
        private Button btnorderproceed;
    }
}