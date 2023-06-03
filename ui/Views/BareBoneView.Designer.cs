namespace ui
{
    partial class BareBoneView
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
            this.components = new System.ComponentModel.Container();
            this.bareBoneOrdersGridView = new System.Windows.Forms.DataGridView();
            this.panelBBMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxBBSearch = new System.Windows.Forms.TextBox();
            this.labelBBView = new System.Windows.Forms.Label();
            this.btnBBSearch = new System.Windows.Forms.Button();
            this.panelBottomBareBones = new System.Windows.Forms.Panel();
            this.labelPageSizeSelection = new System.Windows.Forms.Label();
            this.comboBoxPageSize = new System.Windows.Forms.ComboBox();
            this.labelPageNumbers = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceBBGridView = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bareBoneOrdersGridView)).BeginInit();
            this.panelBBMain.SuspendLayout();
            this.panelBottomBareBones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBBGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bareBoneOrdersGridView
            // 
            this.bareBoneOrdersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bareBoneOrdersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bareBoneOrdersGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.bareBoneOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bareBoneOrdersGridView.Location = new System.Drawing.Point(0, 82);
            this.bareBoneOrdersGridView.Name = "bareBoneOrdersGridView";
            this.bareBoneOrdersGridView.ReadOnly = true;
            this.bareBoneOrdersGridView.Size = new System.Drawing.Size(1487, 570);
            this.bareBoneOrdersGridView.TabIndex = 0;
            // 
            // panelBBMain
            // 
            this.panelBBMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBBMain.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelBBMain.Controls.Add(this.label1);
            this.panelBBMain.Controls.Add(this.labelFrom);
            this.panelBBMain.Controls.Add(this.endDate);
            this.panelBBMain.Controls.Add(this.startDate);
            this.panelBBMain.Controls.Add(this.textBoxBBSearch);
            this.panelBBMain.Controls.Add(this.labelBBView);
            this.panelBBMain.Controls.Add(this.btnBBSearch);
            this.panelBBMain.Location = new System.Drawing.Point(0, 0);
            this.panelBBMain.Name = "panelBBMain";
            this.panelBBMain.Size = new System.Drawing.Size(1487, 87);
            this.panelBBMain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1078, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "To";
            // 
            // labelFrom
            // 
            this.labelFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(837, 20);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(61, 25);
            this.labelFrom.TabIndex = 5;
            this.labelFrom.Text = "From";
            // 
            // endDate
            // 
            this.endDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endDate.CustomFormat = "dd-MM-yyyy";
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDate.Location = new System.Drawing.Point(1121, 17);
            this.endDate.Name = "endDate";
            this.endDate.ShowCheckBox = true;
            this.endDate.ShowUpDown = true;
            this.endDate.Size = new System.Drawing.Size(153, 29);
            this.endDate.TabIndex = 4;
            // 
            // startDate
            // 
            this.startDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startDate.CustomFormat = "dd-MM-yyyy";
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(904, 16);
            this.startDate.Name = "startDate";
            this.startDate.ShowCheckBox = true;
            this.startDate.ShowUpDown = true;
            this.startDate.Size = new System.Drawing.Size(148, 29);
            this.startDate.TabIndex = 3;
            // 
            // textBoxBBSearch
            // 
            this.textBoxBBSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBBSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBBSearch.Location = new System.Drawing.Point(17, 17);
            this.textBoxBBSearch.Name = "textBoxBBSearch";
            this.textBoxBBSearch.Size = new System.Drawing.Size(814, 35);
            this.textBoxBBSearch.TabIndex = 2;
            this.textBoxBBSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBBSearch_KeyPress);
            // 
            // labelBBView
            // 
            this.labelBBView.AutoSize = true;
            this.labelBBView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBBView.Location = new System.Drawing.Point(12, 54);
            this.labelBBView.Name = "labelBBView";
            this.labelBBView.Size = new System.Drawing.Size(125, 25);
            this.labelBBView.TabIndex = 1;
            this.labelBBView.Text = "Total Rows:";
            // 
            // btnBBSearch
            // 
            this.btnBBSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBBSearch.Location = new System.Drawing.Point(1325, 12);
            this.btnBBSearch.Name = "btnBBSearch";
            this.btnBBSearch.Size = new System.Drawing.Size(148, 39);
            this.btnBBSearch.TabIndex = 0;
            this.btnBBSearch.Text = "Search";
            this.btnBBSearch.UseVisualStyleBackColor = true;
            this.btnBBSearch.Click += new System.EventHandler(this.btnBBSearch_Click);
            // 
            // panelBottomBareBones
            // 
            this.panelBottomBareBones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottomBareBones.Controls.Add(this.labelPageSizeSelection);
            this.panelBottomBareBones.Controls.Add(this.comboBoxPageSize);
            this.panelBottomBareBones.Controls.Add(this.labelPageNumbers);
            this.panelBottomBareBones.Controls.Add(this.btnNext);
            this.panelBottomBareBones.Controls.Add(this.btnPrevious);
            this.panelBottomBareBones.Location = new System.Drawing.Point(0, 651);
            this.panelBottomBareBones.Name = "panelBottomBareBones";
            this.panelBottomBareBones.Size = new System.Drawing.Size(1487, 69);
            this.panelBottomBareBones.TabIndex = 2;
            // 
            // labelPageSizeSelection
            // 
            this.labelPageSizeSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPageSizeSelection.AutoSize = true;
            this.labelPageSizeSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageSizeSelection.Location = new System.Drawing.Point(1321, 24);
            this.labelPageSizeSelection.Name = "labelPageSizeSelection";
            this.labelPageSizeSelection.Size = new System.Drawing.Size(155, 24);
            this.labelPageSizeSelection.TabIndex = 4;
            this.labelPageSizeSelection.Text = "- results on page.";
            // 
            // comboBoxPageSize
            // 
            this.comboBoxPageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPageSize.FormattingEnabled = true;
            this.comboBoxPageSize.Location = new System.Drawing.Point(1194, 21);
            this.comboBoxPageSize.Name = "comboBoxPageSize";
            this.comboBoxPageSize.Size = new System.Drawing.Size(121, 32);
            this.comboBoxPageSize.TabIndex = 3;
            // 
            // labelPageNumbers
            // 
            this.labelPageNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPageNumbers.AutoSize = true;
            this.labelPageNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageNumbers.Location = new System.Drawing.Point(456, 21);
            this.labelPageNumbers.Name = "labelPageNumbers";
            this.labelPageNumbers.Size = new System.Drawing.Size(54, 24);
            this.labelPageNumbers.TabIndex = 2;
            this.labelPageNumbers.Text = "Page";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(923, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(129, 43);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(32, 12);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(129, 43);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // BareBoneView
            // 
            this.ClientSize = new System.Drawing.Size(1485, 718);
            this.Controls.Add(this.panelBottomBareBones);
            this.Controls.Add(this.panelBBMain);
            this.Controls.Add(this.bareBoneOrdersGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BareBoneView";
            ((System.ComponentModel.ISupportInitialize)(this.bareBoneOrdersGridView)).EndInit();
            this.panelBBMain.ResumeLayout(false);
            this.panelBBMain.PerformLayout();
            this.panelBottomBareBones.ResumeLayout(false);
            this.panelBottomBareBones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBBGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bareBoneOrdersGridView;
        private System.Windows.Forms.Panel panelBBMain;
        private System.Windows.Forms.Button btnBBSearch;
        private System.Windows.Forms.Label labelBBView;
        private System.Windows.Forms.TextBox textBoxBBSearch;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Panel panelBottomBareBones;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSourceBBGridView;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label labelPageNumbers;
        private System.Windows.Forms.Label labelPageSizeSelection;
        private System.Windows.Forms.ComboBox comboBoxPageSize;
    }
}

