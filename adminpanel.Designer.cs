namespace GMS
{
    partial class adminpanel
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
            closeicon = new PictureBox();
            backicon = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtitemname = new TextBox();
            txtitemprice = new TextBox();
            btnadditem = new Button();
            datagridviewitem = new DataGridView();
            itemname = new DataGridViewTextBoxColumn();
            itemprice = new DataGridViewTextBoxColumn();
            searchitembtn = new Button();
            updateitembtn = new Button();
            lbltotalsales = new Label();
            btntotalsales = new Button();
            btncheckorder = new Button();
            txtorderdetails = new RichTextBox();
            closetextbox = new PictureBox();
            label3 = new Label();
            lblorderdetails = new Label();
            ((System.ComponentModel.ISupportInitialize)closeicon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backicon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridviewitem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closetextbox).BeginInit();
            SuspendLayout();
            // 
            // closeicon
            // 
            closeicon.BackColor = Color.Transparent;
            closeicon.Image = Properties.Resources.close_new;
            closeicon.Location = new Point(747, -12);
            closeicon.Name = "closeicon";
            closeicon.Size = new Size(69, 63);
            closeicon.SizeMode = PictureBoxSizeMode.Zoom;
            closeicon.TabIndex = 12;
            closeicon.TabStop = false;
            closeicon.Click += closeicon_Click;
            // 
            // backicon
            // 
            backicon.BackColor = Color.Transparent;
            backicon.Image = Properties.Resources.log_in_removebg_preview;
            backicon.Location = new Point(-5, 1);
            backicon.Name = "backicon";
            backicon.Size = new Size(44, 34);
            backicon.SizeMode = PictureBoxSizeMode.Zoom;
            backicon.TabIndex = 13;
            backicon.TabStop = false;
            backicon.Click += backicon_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 83);
            label1.Name = "label1";
            label1.Size = new Size(125, 24);
            label1.TabIndex = 14;
            label1.Text = "Item Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(115, 122);
            label2.Name = "label2";
            label2.Size = new Size(119, 24);
            label2.TabIndex = 15;
            label2.Text = "Item Price";
            // 
            // txtitemname
            // 
            txtitemname.BackColor = Color.IndianRed;
            txtitemname.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtitemname.Location = new Point(252, 80);
            txtitemname.Name = "txtitemname";
            txtitemname.Size = new Size(138, 32);
            txtitemname.TabIndex = 16;
            // 
            // txtitemprice
            // 
            txtitemprice.BackColor = Color.IndianRed;
            txtitemprice.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtitemprice.Location = new Point(252, 119);
            txtitemprice.Name = "txtitemprice";
            txtitemprice.Size = new Size(138, 32);
            txtitemprice.TabIndex = 17;
            // 
            // btnadditem
            // 
            btnadditem.BackColor = Color.IndianRed;
            btnadditem.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadditem.Location = new Point(107, 192);
            btnadditem.Name = "btnadditem";
            btnadditem.Size = new Size(139, 38);
            btnadditem.TabIndex = 18;
            btnadditem.Text = "Add Item";
            btnadditem.UseVisualStyleBackColor = false;
            btnadditem.Click += btnadditem_Click;
            // 
            // datagridviewitem
            // 
            datagridviewitem.BackgroundColor = Color.IndianRed;
            datagridviewitem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridviewitem.Columns.AddRange(new DataGridViewColumn[] { itemname, itemprice });
            datagridviewitem.Location = new Point(431, 80);
            datagridviewitem.Name = "datagridviewitem";
            datagridviewitem.Size = new Size(240, 194);
            datagridviewitem.TabIndex = 19;
            // 
            // itemname
            // 
            itemname.HeaderText = "ITEM NAME";
            itemname.Name = "itemname";
            // 
            // itemprice
            // 
            itemprice.HeaderText = "ITEM PRICE";
            itemprice.Name = "itemprice";
            // 
            // searchitembtn
            // 
            searchitembtn.BackColor = Color.IndianRed;
            searchitembtn.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchitembtn.Location = new Point(252, 192);
            searchitembtn.Name = "searchitembtn";
            searchitembtn.Size = new Size(139, 38);
            searchitembtn.TabIndex = 20;
            searchitembtn.Text = "Search Item";
            searchitembtn.UseVisualStyleBackColor = false;
            searchitembtn.Click += searchitembtn_Click;
            // 
            // updateitembtn
            // 
            updateitembtn.BackColor = Color.IndianRed;
            updateitembtn.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateitembtn.Location = new Point(184, 236);
            updateitembtn.Name = "updateitembtn";
            updateitembtn.Size = new Size(139, 38);
            updateitembtn.TabIndex = 21;
            updateitembtn.Text = "Update Item";
            updateitembtn.UseVisualStyleBackColor = false;
            updateitembtn.Click += updateitembtn_Click;
            // 
            // lbltotalsales
            // 
            lbltotalsales.AutoSize = true;
            lbltotalsales.BackColor = Color.Transparent;
            lbltotalsales.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltotalsales.Location = new Point(334, 300);
            lbltotalsales.Name = "lbltotalsales";
            lbltotalsales.Size = new Size(126, 24);
            lbltotalsales.TabIndex = 22;
            lbltotalsales.Text = "Total Sales";
            // 
            // btntotalsales
            // 
            btntotalsales.BackColor = Color.IndianRed;
            btntotalsales.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntotalsales.Location = new Point(334, 327);
            btntotalsales.Name = "btntotalsales";
            btntotalsales.Size = new Size(192, 60);
            btntotalsales.TabIndex = 23;
            btntotalsales.Text = "Check Total Sales";
            btntotalsales.UseVisualStyleBackColor = false;
            btntotalsales.Click += btntotalsales_Click;
            // 
            // btncheckorder
            // 
            btncheckorder.BackColor = Color.IndianRed;
            btncheckorder.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncheckorder.Location = new Point(334, 425);
            btncheckorder.Name = "btncheckorder";
            btncheckorder.Size = new Size(192, 60);
            btncheckorder.TabIndex = 24;
            btncheckorder.Text = "Check Orders";
            btncheckorder.UseVisualStyleBackColor = false;
            btncheckorder.Click += btncheckorder_Click;
            // 
            // txtorderdetails
            // 
            txtorderdetails.BackColor = Color.IndianRed;
            txtorderdetails.Location = new Point(115, 80);
            txtorderdetails.Name = "txtorderdetails";
            txtorderdetails.Size = new Size(585, 443);
            txtorderdetails.TabIndex = 25;
            txtorderdetails.Text = "ORDER DETAILS";
            // 
            // closetextbox
            // 
            closetextbox.BackColor = Color.Transparent;
            closetextbox.Image = Properties.Resources.close_new;
            closetextbox.Location = new Point(671, 80);
            closetextbox.Name = "closetextbox";
            closetextbox.Size = new Size(29, 30);
            closetextbox.SizeMode = PictureBoxSizeMode.Zoom;
            closetextbox.TabIndex = 26;
            closetextbox.TabStop = false;
            closetextbox.Click += closetextbox_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Rockwell", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(211, 9);
            label3.Name = "label3";
            label3.Size = new Size(384, 59);
            label3.TabIndex = 32;
            label3.Text = "ADMIN PANEL";
            // 
            // lblorderdetails
            // 
            lblorderdetails.AutoSize = true;
            lblorderdetails.BackColor = Color.Transparent;
            lblorderdetails.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblorderdetails.Location = new Point(307, 64);
            lblorderdetails.Name = "lblorderdetails";
            lblorderdetails.Size = new Size(195, 24);
            lblorderdetails.TabIndex = 33;
            lblorderdetails.Text = "ORDER DETAILS";
            // 
            // adminpanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images__3_;
            ClientSize = new Size(800, 535);
            Controls.Add(lblorderdetails);
            Controls.Add(label3);
            Controls.Add(closetextbox);
            Controls.Add(txtorderdetails);
            Controls.Add(btncheckorder);
            Controls.Add(btntotalsales);
            Controls.Add(lbltotalsales);
            Controls.Add(updateitembtn);
            Controls.Add(searchitembtn);
            Controls.Add(datagridviewitem);
            Controls.Add(btnadditem);
            Controls.Add(txtitemprice);
            Controls.Add(txtitemname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(backicon);
            Controls.Add(closeicon);
            Name = "adminpanel";
            Text = "adminpanel";
            Load += adminpanel_Load;
            ((System.ComponentModel.ISupportInitialize)closeicon).EndInit();
            ((System.ComponentModel.ISupportInitialize)backicon).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridviewitem).EndInit();
            ((System.ComponentModel.ISupportInitialize)closetextbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox closeicon;
        private PictureBox backicon;
        private Label label1;
        private Label label2;
        private TextBox txtitemname;
        private TextBox txtitemprice;
        private Button btnadditem;
        private DataGridView datagridviewitem;
        private DataGridViewTextBoxColumn itemname;
        private DataGridViewTextBoxColumn itemprice;
        private Button searchitembtn;
        private Button updateitembtn;
        private Label lbltotalsales;
        private Button btntotalsales;
        private Button btncheckorder;
        private RichTextBox txtorderdetails;
        private PictureBox closetextbox;
        private Label label3;
        private Label lblorderdetails;
    }
}