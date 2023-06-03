namespace ui.Views
{
    partial class ComplexView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComplexView));
            this.panelComplexView = new System.Windows.Forms.Panel();
            this.labelOrderTo = new System.Windows.Forms.Label();
            this.labelOrderFrom = new System.Windows.Forms.Label();
            this.dateOrderTo = new System.Windows.Forms.DateTimePicker();
            this.dateOrderFrom = new System.Windows.Forms.DateTimePicker();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelComplexView = new System.Windows.Forms.Label();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.listBoxOrderId = new System.Windows.Forms.ListBox();
            this.pictureBoxComplexView = new System.Windows.Forms.PictureBox();
            this.panelComplexView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComplexView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelComplexView
            // 
            this.panelComplexView.BackColor = System.Drawing.Color.Honeydew;
            this.panelComplexView.Controls.Add(this.labelOrderTo);
            this.panelComplexView.Controls.Add(this.labelOrderFrom);
            this.panelComplexView.Controls.Add(this.dateOrderTo);
            this.panelComplexView.Controls.Add(this.dateOrderFrom);
            this.panelComplexView.Controls.Add(this.textBoxSearch);
            this.panelComplexView.Controls.Add(this.btnSearch);
            this.panelComplexView.Controls.Add(this.labelComplexView);
            this.panelComplexView.Controls.Add(this.btnViewDetails);
            this.panelComplexView.Controls.Add(this.listBoxOrderId);
            this.panelComplexView.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelComplexView.Location = new System.Drawing.Point(0, 0);
            this.panelComplexView.Name = "panelComplexView";
            this.panelComplexView.Size = new System.Drawing.Size(396, 679);
            this.panelComplexView.TabIndex = 0;
            // 
            // labelOrderTo
            // 
            this.labelOrderTo.AutoSize = true;
            this.labelOrderTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderTo.Location = new System.Drawing.Point(234, 257);
            this.labelOrderTo.Name = "labelOrderTo";
            this.labelOrderTo.Size = new System.Drawing.Size(114, 25);
            this.labelOrderTo.TabIndex = 8;
            this.labelOrderTo.Text = "Orders To:";
            // 
            // labelOrderFrom
            // 
            this.labelOrderFrom.AutoSize = true;
            this.labelOrderFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderFrom.Location = new System.Drawing.Point(234, 179);
            this.labelOrderFrom.Name = "labelOrderFrom";
            this.labelOrderFrom.Size = new System.Drawing.Size(138, 25);
            this.labelOrderFrom.TabIndex = 7;
            this.labelOrderFrom.Text = "Orders From:";
            // 
            // dateOrderTo
            // 
            this.dateOrderTo.CustomFormat = "dd-MM-yyyy";
            this.dateOrderTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOrderTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOrderTo.Location = new System.Drawing.Point(237, 297);
            this.dateOrderTo.Name = "dateOrderTo";
            this.dateOrderTo.ShowCheckBox = true;
            this.dateOrderTo.Size = new System.Drawing.Size(156, 31);
            this.dateOrderTo.TabIndex = 6;
            // 
            // dateOrderFrom
            // 
            this.dateOrderFrom.CustomFormat = "dd-MM-yyyy";
            this.dateOrderFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOrderFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOrderFrom.Location = new System.Drawing.Point(237, 217);
            this.dateOrderFrom.Name = "dateOrderFrom";
            this.dateOrderFrom.ShowCheckBox = true;
            this.dateOrderFrom.Size = new System.Drawing.Size(156, 31);
            this.dateOrderFrom.TabIndex = 5;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(40, 119);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(188, 31);
            this.textBoxSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(295, 118);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelComplexView
            // 
            this.labelComplexView.AutoSize = true;
            this.labelComplexView.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplexView.Location = new System.Drawing.Point(56, 20);
            this.labelComplexView.Name = "labelComplexView";
            this.labelComplexView.Size = new System.Drawing.Size(262, 33);
            this.labelComplexView.TabIndex = 2;
            this.labelComplexView.Text = "View Order details:";
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewDetails.Enabled = false;
            this.btnViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.Location = new System.Drawing.Point(194, 601);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(182, 43);
            this.btnViewDetails.TabIndex = 1;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // listBoxOrderId
            // 
            this.listBoxOrderId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listBoxOrderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOrderId.FormattingEnabled = true;
            this.listBoxOrderId.ItemHeight = 42;
            this.listBoxOrderId.Location = new System.Drawing.Point(40, 179);
            this.listBoxOrderId.Name = "listBoxOrderId";
            this.listBoxOrderId.ScrollAlwaysVisible = true;
            this.listBoxOrderId.Size = new System.Drawing.Size(188, 380);
            this.listBoxOrderId.TabIndex = 0;
            // 
            // pictureBoxComplexView
            // 
            this.pictureBoxComplexView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxComplexView.BackgroundImage = global::ui.Properties.Resources.car_dealership_unsplash;
            this.pictureBoxComplexView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxComplexView.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxComplexView.InitialImage")));
            this.pictureBoxComplexView.Location = new System.Drawing.Point(396, 0);
            this.pictureBoxComplexView.Name = "pictureBoxComplexView";
            this.pictureBoxComplexView.Size = new System.Drawing.Size(1076, 679);
            this.pictureBoxComplexView.TabIndex = 2;
            this.pictureBoxComplexView.TabStop = false;
            // 
            // ComplexView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 679);
            this.Controls.Add(this.pictureBoxComplexView);
            this.Controls.Add(this.panelComplexView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComplexView";
            this.Text = "ComplexView";
            this.panelComplexView.ResumeLayout(false);
            this.panelComplexView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComplexView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelComplexView;
        private System.Windows.Forms.PictureBox pictureBoxComplexView;
        private System.Windows.Forms.ListBox listBoxOrderId;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelComplexView;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.DateTimePicker dateOrderTo;
        private System.Windows.Forms.DateTimePicker dateOrderFrom;
        private System.Windows.Forms.Label labelOrderTo;
        private System.Windows.Forms.Label labelOrderFrom;
    }
}