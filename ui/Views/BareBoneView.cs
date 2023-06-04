using System;
using System.Windows.Forms;
using ui.ViewModels;
using ui.Models;

namespace ui
{
    public partial class BareBoneView : Form
    {
        private readonly OrderViewModel orderViewModel;
        private System.Windows.Forms.ToolTip tooltip = new System.Windows.Forms.ToolTip();
        private Nullable<DateTime> searchStartDate;
        private Nullable<DateTime> searchEndDate;

        public BareBoneView()
        {
            InitializeComponent();
            orderViewModel = new OrderViewModel();
            startDate.Checked = false;
            endDate.Checked = false;
            startDate.ValueChanged += DateTimePicker_ValueChanged;
            endDate.ValueChanged += DateTimePicker_ValueChanged;

            this.Load += BareBoneView_Load;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            searchStartDate = startDate.Value;
            searchEndDate = endDate.Value;

            if (((searchStartDate != null && startDate.Checked) && (searchEndDate != null && endDate.Checked)) && searchStartDate > searchEndDate)
            {
                tooltip.Show("Invalid date range. 'From' date cannot be later than 'To' date.", endDate, -200, 30, 3000);
                endDate.Value = startDate.Value;
            }
        }

        private void BareBoneView_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                InitializeGridView();
                bareBoneOrdersGridView.DataSource = orderViewModel.OrdersForDisplay;
                InitializePageCountSelection();
                UpdateRowCountLabel();
                UpdatePageNumberLabel();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong with loading the view. Please try again later or contact support for assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void InitializeGridView()
        {
            for (int i = 0; i < orderViewModel.ColumnHeaders.Length; i++)
            {
                string columnName = orderViewModel.ColumnHeaders[i].Replace(" ", "");
                string columnHeaderText = orderViewModel.ColumnHeaders[i];

                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                column.Name = columnName;
                column.HeaderText = columnHeaderText;

                bareBoneOrdersGridView.Columns.Add(column);
            }
            bareBoneOrdersGridView.AutoGenerateColumns = false;
            bareBoneOrdersGridView.DataBindingComplete += BareBoneOrdersGridView_DataBindingComplete;
        }

        private void InitializePageCountSelection()
        {
            comboBoxPageSize.SelectedValueChanged -= ComboBoxPageSize_SelectedValueChanged;
            comboBoxPageSize.DataSource = orderViewModel.PageSizesSelection;
            comboBoxPageSize.Text = orderViewModel.PageSize.ToString();
            comboBoxPageSize.SelectedValueChanged += ComboBoxPageSize_SelectedValueChanged;
        }

        private void BareBoneOrdersGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in bareBoneOrdersGridView.Rows)
            {
                OrderModel order = (OrderModel)row.DataBoundItem;
                row.Cells["OrderNumber"].Value = order.OrderNumber;
                row.Cells["OrderDate"].Value = order.OrderDate.ToString("dd-MM-yyyy");
                row.Cells["SalePrice"].Value = order.SalePrice;
                row.Cells["Deposit"].Value = order.Deposit;
                row.Cells["Customer#"].Value = order.Customer.CustomerNumber;
                row.Cells["CustomerForename"].Value = order.Customer.Forename;
                row.Cells["CustomerSurname"].Value = order.Customer.Surname;
                row.Cells["CustomerPhone"].Value = order.Customer.TelephoneNumber;
                row.Cells["BranchName"].Value = order.Employee.Branch.BranchName;
                row.Cells["BranchPostcode"].Value = order.Employee.Branch.Postcode;
            }
        }

        private void ComboBoxPageSize_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedPageSize = (int)comboBoxPageSize.SelectedValue;
            orderViewModel.PageSize = selectedPageSize;
            btnBBSearch_Click(sender, e);
        }

        //"Order Number", "Order Date", "Sale Price", "Deposit", "Customer #", "Customer Forename", "Customer Surname", "Customer Phone", "Branch Name", "Branch Postcode"

        private void btnBBSearch_Click(object sender, EventArgs e)
        {
            string orderId = textBoxBBSearch.Text.Trim();
            if (startDate.Checked)
            {
                searchStartDate = startDate.Value.Date;
            }
            else
            {
                searchStartDate = null;
            }
            if (endDate.Checked)
            {
                searchEndDate = endDate.Value.Date;
            }
            else
            {
                searchEndDate = null;
            }

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                orderViewModel.LoadSearchData(searchStartDate, searchEndDate, orderId);
                bareBoneOrdersGridView.DataSource = orderViewModel.OrdersForDisplay;
                if (orderViewModel.TotalOrders == 0)
                {
                    tooltip.Show("No results found! Please try a different number, or different dates.", textBoxBBSearch, 0, -30, 4000);
                }    
                UpdateRowCountLabel();
                UpdatePageNumberLabel();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong with the search. Please try again later or contact support for assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void UpdateRowCountLabel()
        {
            int rowCount = orderViewModel.TotalOrders;
            labelBBView.Text = $"Total Rows: {rowCount}";
        }

        private void UpdatePageNumberLabel()
        {
            int totalPages = orderViewModel.TotalPages;
            int currentPage = orderViewModel.CurrentPage + 1;
            if (totalPages.Equals(0))
            {
                labelPageNumbers.Text = "No results!";
            }
            else
            {
                labelPageNumbers.Text = "Page " + currentPage + " of " + totalPages;
            }
        }

        private void textBoxBBSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBBSearch_Click(sender, e);
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                tooltip.Show("Please enter a numeric value!", textBoxBBSearch, 0, 20, 2000);
            }
            else
            {
                tooltip.RemoveAll();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                orderViewModel.PrevPage();
                if (orderViewModel.TotalOrders != 0)
                {
                    bareBoneOrdersGridView.DataSource = orderViewModel.OrdersForDisplay;
                    bareBoneOrdersGridView.Refresh();
                    UpdatePageNumberLabel();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong with loading the data. Please try again later or contact support for assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                orderViewModel.NextPage();
                if (orderViewModel.TotalOrders != 0)
                {
                    bareBoneOrdersGridView.DataSource = orderViewModel.OrdersForDisplay;
                    bareBoneOrdersGridView.Refresh();
                    UpdatePageNumberLabel();
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong with loading the data. Please try again later or contact support for assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
