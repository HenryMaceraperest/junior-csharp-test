namespace ui.Views
{
    partial class ComplexDetailedView
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
            this.panelDetailSide = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panelDetailMain = new System.Windows.Forms.Panel();
            this.panelBranchDetail = new System.Windows.Forms.Panel();
            this.labelBranchPostal = new System.Windows.Forms.Label();
            this.textBoxBranchPostal = new System.Windows.Forms.TextBox();
            this.labelBranchName = new System.Windows.Forms.Label();
            this.textBoxBranchName = new System.Windows.Forms.TextBox();
            this.labelBranchHeader = new System.Windows.Forms.Label();
            this.panelCustomerDetail = new System.Windows.Forms.Panel();
            this.labelCustomerPhone = new System.Windows.Forms.Label();
            this.textBoxCustomerPhone = new System.Windows.Forms.TextBox();
            this.labelCustomerSurname = new System.Windows.Forms.Label();
            this.textBoxCustomerSurname = new System.Windows.Forms.TextBox();
            this.labelCustomerForename = new System.Windows.Forms.Label();
            this.textBoxCustomerForename = new System.Windows.Forms.TextBox();
            this.labelCustomerNr = new System.Windows.Forms.Label();
            this.textBoxCustomerNr = new System.Windows.Forms.TextBox();
            this.labelCustomerHeader = new System.Windows.Forms.Label();
            this.panelOrderDetail = new System.Windows.Forms.Panel();
            this.textBoxOrderDeposit = new System.Windows.Forms.TextBox();
            this.textBoxSalePrice = new System.Windows.Forms.TextBox();
            this.textBoxOrderDate = new System.Windows.Forms.TextBox();
            this.labelOrderDeposit = new System.Windows.Forms.Label();
            this.labelSalePrice = new System.Windows.Forms.Label();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.labelOrderNr = new System.Windows.Forms.Label();
            this.labelOrderHeader = new System.Windows.Forms.Label();
            this.textBoxOrderNr = new System.Windows.Forms.TextBox();
            this.panelDetailSide.SuspendLayout();
            this.panelDetailMain.SuspendLayout();
            this.panelBranchDetail.SuspendLayout();
            this.panelCustomerDetail.SuspendLayout();
            this.panelOrderDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetailSide
            // 
            this.panelDetailSide.BackColor = System.Drawing.Color.Honeydew;
            this.panelDetailSide.Controls.Add(this.btnReturn);
            this.panelDetailSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDetailSide.Location = new System.Drawing.Point(0, 0);
            this.panelDetailSide.Name = "panelDetailSide";
            this.panelDetailSide.Size = new System.Drawing.Size(125, 640);
            this.panelDetailSide.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImage = global::ui.Properties.Resources.left_arrow;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Location = new System.Drawing.Point(25, 25);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 55);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panelDetailMain
            // 
            this.panelDetailMain.BackColor = System.Drawing.Color.MintCream;
            this.panelDetailMain.Controls.Add(this.panelBranchDetail);
            this.panelDetailMain.Controls.Add(this.panelCustomerDetail);
            this.panelDetailMain.Controls.Add(this.panelOrderDetail);
            this.panelDetailMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetailMain.Location = new System.Drawing.Point(125, 0);
            this.panelDetailMain.Name = "panelDetailMain";
            this.panelDetailMain.Size = new System.Drawing.Size(1328, 640);
            this.panelDetailMain.TabIndex = 1;
            // 
            // panelBranchDetail
            // 
            this.panelBranchDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBranchDetail.BackColor = System.Drawing.Color.Honeydew;
            this.panelBranchDetail.Controls.Add(this.labelBranchPostal);
            this.panelBranchDetail.Controls.Add(this.textBoxBranchPostal);
            this.panelBranchDetail.Controls.Add(this.labelBranchName);
            this.panelBranchDetail.Controls.Add(this.textBoxBranchName);
            this.panelBranchDetail.Controls.Add(this.labelBranchHeader);
            this.panelBranchDetail.Location = new System.Drawing.Point(771, 399);
            this.panelBranchDetail.Name = "panelBranchDetail";
            this.panelBranchDetail.Size = new System.Drawing.Size(491, 193);
            this.panelBranchDetail.TabIndex = 3;
            // 
            // labelBranchPostal
            // 
            this.labelBranchPostal.AutoSize = true;
            this.labelBranchPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBranchPostal.Location = new System.Drawing.Point(16, 131);
            this.labelBranchPostal.Name = "labelBranchPostal";
            this.labelBranchPostal.Size = new System.Drawing.Size(204, 25);
            this.labelBranchPostal.TabIndex = 8;
            this.labelBranchPostal.Text = "Branch Postal Index";
            // 
            // textBoxBranchPostal
            // 
            this.textBoxBranchPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBranchPostal.Location = new System.Drawing.Point(236, 131);
            this.textBoxBranchPostal.Name = "textBoxBranchPostal";
            this.textBoxBranchPostal.ReadOnly = true;
            this.textBoxBranchPostal.Size = new System.Drawing.Size(240, 40);
            this.textBoxBranchPostal.TabIndex = 7;
            this.textBoxBranchPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelBranchName
            // 
            this.labelBranchName.AutoSize = true;
            this.labelBranchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBranchName.Location = new System.Drawing.Point(17, 72);
            this.labelBranchName.Name = "labelBranchName";
            this.labelBranchName.Size = new System.Drawing.Size(142, 25);
            this.labelBranchName.TabIndex = 6;
            this.labelBranchName.Text = "Branch Name";
            // 
            // textBoxBranchName
            // 
            this.textBoxBranchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBranchName.Location = new System.Drawing.Point(170, 72);
            this.textBoxBranchName.Name = "textBoxBranchName";
            this.textBoxBranchName.ReadOnly = true;
            this.textBoxBranchName.Size = new System.Drawing.Size(306, 40);
            this.textBoxBranchName.TabIndex = 5;
            this.textBoxBranchName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelBranchHeader
            // 
            this.labelBranchHeader.AutoSize = true;
            this.labelBranchHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBranchHeader.Location = new System.Drawing.Point(15, 9);
            this.labelBranchHeader.Name = "labelBranchHeader";
            this.labelBranchHeader.Size = new System.Drawing.Size(243, 39);
            this.labelBranchHeader.TabIndex = 2;
            this.labelBranchHeader.Text = "Branch Details";
            // 
            // panelCustomerDetail
            // 
            this.panelCustomerDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCustomerDetail.BackColor = System.Drawing.Color.Honeydew;
            this.panelCustomerDetail.Controls.Add(this.labelCustomerPhone);
            this.panelCustomerDetail.Controls.Add(this.textBoxCustomerPhone);
            this.panelCustomerDetail.Controls.Add(this.labelCustomerSurname);
            this.panelCustomerDetail.Controls.Add(this.textBoxCustomerSurname);
            this.panelCustomerDetail.Controls.Add(this.labelCustomerForename);
            this.panelCustomerDetail.Controls.Add(this.textBoxCustomerForename);
            this.panelCustomerDetail.Controls.Add(this.labelCustomerNr);
            this.panelCustomerDetail.Controls.Add(this.textBoxCustomerNr);
            this.panelCustomerDetail.Controls.Add(this.labelCustomerHeader);
            this.panelCustomerDetail.Location = new System.Drawing.Point(771, 25);
            this.panelCustomerDetail.Name = "panelCustomerDetail";
            this.panelCustomerDetail.Size = new System.Drawing.Size(491, 330);
            this.panelCustomerDetail.TabIndex = 2;
            // 
            // labelCustomerPhone
            // 
            this.labelCustomerPhone.AutoSize = true;
            this.labelCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerPhone.Location = new System.Drawing.Point(17, 269);
            this.labelCustomerPhone.Name = "labelCustomerPhone";
            this.labelCustomerPhone.Size = new System.Drawing.Size(92, 25);
            this.labelCustomerPhone.TabIndex = 10;
            this.labelCustomerPhone.Text = "Phone #";
            // 
            // textBoxCustomerPhone
            // 
            this.textBoxCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerPhone.Location = new System.Drawing.Point(153, 269);
            this.textBoxCustomerPhone.Name = "textBoxCustomerPhone";
            this.textBoxCustomerPhone.ReadOnly = true;
            this.textBoxCustomerPhone.Size = new System.Drawing.Size(323, 40);
            this.textBoxCustomerPhone.TabIndex = 9;
            this.textBoxCustomerPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCustomerSurname
            // 
            this.labelCustomerSurname.AutoSize = true;
            this.labelCustomerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerSurname.Location = new System.Drawing.Point(16, 195);
            this.labelCustomerSurname.Name = "labelCustomerSurname";
            this.labelCustomerSurname.Size = new System.Drawing.Size(98, 25);
            this.labelCustomerSurname.TabIndex = 8;
            this.labelCustomerSurname.Text = "Surname";
            // 
            // textBoxCustomerSurname
            // 
            this.textBoxCustomerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerSurname.Location = new System.Drawing.Point(153, 195);
            this.textBoxCustomerSurname.Name = "textBoxCustomerSurname";
            this.textBoxCustomerSurname.ReadOnly = true;
            this.textBoxCustomerSurname.Size = new System.Drawing.Size(323, 40);
            this.textBoxCustomerSurname.TabIndex = 7;
            this.textBoxCustomerSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCustomerForename
            // 
            this.labelCustomerForename.AutoSize = true;
            this.labelCustomerForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerForename.Location = new System.Drawing.Point(16, 125);
            this.labelCustomerForename.Name = "labelCustomerForename";
            this.labelCustomerForename.Size = new System.Drawing.Size(109, 25);
            this.labelCustomerForename.TabIndex = 6;
            this.labelCustomerForename.Text = "Forename";
            // 
            // textBoxCustomerForename
            // 
            this.textBoxCustomerForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerForename.Location = new System.Drawing.Point(153, 125);
            this.textBoxCustomerForename.Name = "textBoxCustomerForename";
            this.textBoxCustomerForename.ReadOnly = true;
            this.textBoxCustomerForename.Size = new System.Drawing.Size(322, 40);
            this.textBoxCustomerForename.TabIndex = 5;
            this.textBoxCustomerForename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCustomerNr
            // 
            this.labelCustomerNr.AutoSize = true;
            this.labelCustomerNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerNr.Location = new System.Drawing.Point(17, 62);
            this.labelCustomerNr.Name = "labelCustomerNr";
            this.labelCustomerNr.Size = new System.Drawing.Size(185, 25);
            this.labelCustomerNr.TabIndex = 4;
            this.labelCustomerNr.Text = "Customer Number";
            // 
            // textBoxCustomerNr
            // 
            this.textBoxCustomerNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerNr.Location = new System.Drawing.Point(239, 62);
            this.textBoxCustomerNr.Name = "textBoxCustomerNr";
            this.textBoxCustomerNr.ReadOnly = true;
            this.textBoxCustomerNr.Size = new System.Drawing.Size(236, 40);
            this.textBoxCustomerNr.TabIndex = 3;
            this.textBoxCustomerNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCustomerHeader
            // 
            this.labelCustomerHeader.AutoSize = true;
            this.labelCustomerHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerHeader.Location = new System.Drawing.Point(15, 5);
            this.labelCustomerHeader.Name = "labelCustomerHeader";
            this.labelCustomerHeader.Size = new System.Drawing.Size(285, 39);
            this.labelCustomerHeader.TabIndex = 2;
            this.labelCustomerHeader.Text = "Customer Details";
            // 
            // panelOrderDetail
            // 
            this.panelOrderDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelOrderDetail.BackColor = System.Drawing.Color.Honeydew;
            this.panelOrderDetail.Controls.Add(this.textBoxOrderDeposit);
            this.panelOrderDetail.Controls.Add(this.textBoxSalePrice);
            this.panelOrderDetail.Controls.Add(this.textBoxOrderDate);
            this.panelOrderDetail.Controls.Add(this.labelOrderDeposit);
            this.panelOrderDetail.Controls.Add(this.labelSalePrice);
            this.panelOrderDetail.Controls.Add(this.labelOrderDate);
            this.panelOrderDetail.Controls.Add(this.labelOrderNr);
            this.panelOrderDetail.Controls.Add(this.labelOrderHeader);
            this.panelOrderDetail.Controls.Add(this.textBoxOrderNr);
            this.panelOrderDetail.Location = new System.Drawing.Point(78, 25);
            this.panelOrderDetail.Name = "panelOrderDetail";
            this.panelOrderDetail.Size = new System.Drawing.Size(646, 567);
            this.panelOrderDetail.TabIndex = 1;
            // 
            // textBoxOrderDeposit
            // 
            this.textBoxOrderDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrderDeposit.Location = new System.Drawing.Point(193, 465);
            this.textBoxOrderDeposit.Name = "textBoxOrderDeposit";
            this.textBoxOrderDeposit.ReadOnly = true;
            this.textBoxOrderDeposit.Size = new System.Drawing.Size(347, 40);
            this.textBoxOrderDeposit.TabIndex = 8;
            this.textBoxOrderDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSalePrice
            // 
            this.textBoxSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalePrice.Location = new System.Drawing.Point(193, 345);
            this.textBoxSalePrice.Name = "textBoxSalePrice";
            this.textBoxSalePrice.ReadOnly = true;
            this.textBoxSalePrice.Size = new System.Drawing.Size(347, 40);
            this.textBoxSalePrice.TabIndex = 7;
            this.textBoxSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxOrderDate
            // 
            this.textBoxOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrderDate.Location = new System.Drawing.Point(193, 223);
            this.textBoxOrderDate.Name = "textBoxOrderDate";
            this.textBoxOrderDate.ReadOnly = true;
            this.textBoxOrderDate.Size = new System.Drawing.Size(347, 40);
            this.textBoxOrderDate.TabIndex = 6;
            this.textBoxOrderDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelOrderDeposit
            // 
            this.labelOrderDeposit.AutoSize = true;
            this.labelOrderDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderDeposit.Location = new System.Drawing.Point(95, 465);
            this.labelOrderDeposit.Name = "labelOrderDeposit";
            this.labelOrderDeposit.Size = new System.Drawing.Size(85, 25);
            this.labelOrderDeposit.TabIndex = 5;
            this.labelOrderDeposit.Text = "Deposit";
            // 
            // labelSalePrice
            // 
            this.labelSalePrice.AutoSize = true;
            this.labelSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalePrice.Location = new System.Drawing.Point(77, 345);
            this.labelSalePrice.Name = "labelSalePrice";
            this.labelSalePrice.Size = new System.Drawing.Size(110, 25);
            this.labelSalePrice.TabIndex = 4;
            this.labelSalePrice.Text = "Sale Price";
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderDate.Location = new System.Drawing.Point(70, 223);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(117, 25);
            this.labelOrderDate.TabIndex = 3;
            this.labelOrderDate.Text = "Order Date";
            // 
            // labelOrderNr
            // 
            this.labelOrderNr.AutoSize = true;
            this.labelOrderNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderNr.Location = new System.Drawing.Point(40, 101);
            this.labelOrderNr.Name = "labelOrderNr";
            this.labelOrderNr.Size = new System.Drawing.Size(147, 25);
            this.labelOrderNr.TabIndex = 2;
            this.labelOrderNr.Text = "Order Number";
            // 
            // labelOrderHeader
            // 
            this.labelOrderHeader.AutoSize = true;
            this.labelOrderHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderHeader.Location = new System.Drawing.Point(18, 5);
            this.labelOrderHeader.Name = "labelOrderHeader";
            this.labelOrderHeader.Size = new System.Drawing.Size(222, 39);
            this.labelOrderHeader.TabIndex = 1;
            this.labelOrderHeader.Text = "Order Details";
            // 
            // textBoxOrderNr
            // 
            this.textBoxOrderNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrderNr.Location = new System.Drawing.Point(193, 101);
            this.textBoxOrderNr.Name = "textBoxOrderNr";
            this.textBoxOrderNr.ReadOnly = true;
            this.textBoxOrderNr.Size = new System.Drawing.Size(347, 40);
            this.textBoxOrderNr.TabIndex = 0;
            this.textBoxOrderNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ComplexDetailedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1453, 640);
            this.Controls.Add(this.panelDetailMain);
            this.Controls.Add(this.panelDetailSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComplexDetailedView";
            this.Text = "ComplexDetailedView";
            this.panelDetailSide.ResumeLayout(false);
            this.panelDetailMain.ResumeLayout(false);
            this.panelBranchDetail.ResumeLayout(false);
            this.panelBranchDetail.PerformLayout();
            this.panelCustomerDetail.ResumeLayout(false);
            this.panelCustomerDetail.PerformLayout();
            this.panelOrderDetail.ResumeLayout(false);
            this.panelOrderDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetailSide;
        private System.Windows.Forms.Panel panelDetailMain;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panelBranchDetail;
        private System.Windows.Forms.Panel panelCustomerDetail;
        private System.Windows.Forms.Panel panelOrderDetail;
        private System.Windows.Forms.Label labelOrderDeposit;
        private System.Windows.Forms.Label labelSalePrice;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.Label labelOrderNr;
        private System.Windows.Forms.Label labelOrderHeader;
        private System.Windows.Forms.TextBox textBoxOrderNr;
        private System.Windows.Forms.Label labelBranchHeader;
        private System.Windows.Forms.Label labelCustomerPhone;
        private System.Windows.Forms.TextBox textBoxCustomerPhone;
        private System.Windows.Forms.Label labelCustomerSurname;
        private System.Windows.Forms.TextBox textBoxCustomerSurname;
        private System.Windows.Forms.Label labelCustomerForename;
        private System.Windows.Forms.TextBox textBoxCustomerForename;
        private System.Windows.Forms.Label labelCustomerNr;
        private System.Windows.Forms.TextBox textBoxCustomerNr;
        private System.Windows.Forms.Label labelCustomerHeader;
        private System.Windows.Forms.TextBox textBoxOrderDeposit;
        private System.Windows.Forms.TextBox textBoxSalePrice;
        private System.Windows.Forms.TextBox textBoxOrderDate;
        private System.Windows.Forms.Label labelBranchPostal;
        private System.Windows.Forms.TextBox textBoxBranchPostal;
        private System.Windows.Forms.Label labelBranchName;
        private System.Windows.Forms.TextBox textBoxBranchName;
    }
}