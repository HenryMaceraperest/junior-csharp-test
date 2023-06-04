using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using ui.ViewModels;

namespace ui.Views
{
    public partial class ComplexView : Form
    {
        public event EventHandler ComplexDetailedViewRequested;
        public event EventHandler<string> FillComplexDetailedViewById;
        private readonly ComplexViewModel complexViewModel;
        private Nullable<DateTime> orderFromDate;
        private Nullable<DateTime> orderToDate;

        private System.Windows.Forms.ToolTip tooltip = new System.Windows.Forms.ToolTip();
        public ComplexView()
        {
            InitializeComponent();
            complexViewModel = new ComplexViewModel();
            dateOrderFrom.Checked = false;
            dateOrderTo.Checked = false;
            listBoxOrderId.DrawItem += ListBox_DrawItem;
            listBoxOrderId.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            dateOrderFrom.ValueChanged += DateTimePicker_ValueChanged;
            dateOrderTo.ValueChanged += DateTimePicker_ValueChanged;
            this.Load += BareBoneView_Load;
        }

        private void ListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            ListBox listBoxOrderId = (ListBox)sender;

            string itemText = listBoxOrderId.GetItemText(listBoxOrderId.Items[e.Index]);

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            e.DrawBackground();
            e.Graphics.DrawString(itemText, e.Font, new SolidBrush(e.ForeColor), e.Bounds, stringFormat);
            e.DrawFocusRectangle();
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOrderId.SelectedItems != null)
            {
                btnViewDetails.Enabled = true;
            }
            else
            {
                btnViewDetails.Enabled = false;
            }
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            orderFromDate = dateOrderFrom.Value;
            orderToDate = dateOrderTo.Value;

            if (((orderFromDate != null && dateOrderFrom.Checked) && (orderToDate != null && dateOrderTo.Checked)) && orderFromDate > orderToDate)
            {
                tooltip.Show("Invalid date range. 'From' date cannot be later than 'To' date.", dateOrderFrom, 0, 140, 2000);
                dateOrderTo.Value = dateOrderFrom.Value;
            }
        }

        private void BareBoneView_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                int[] numbers = complexViewModel.OrderNumbers;
                listBoxOrderId.Items.AddRange(numbers.Select(n => n.ToString()).ToArray());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong with loading the view. Please try again later or contact support for assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void OnComplexDetailedViewRequested()
        {
            string orderId = listBoxOrderId.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(orderId))
            {
                FillComplexDetailedViewById?.Invoke(this, orderId);
            }
            ComplexDetailedViewRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string orderId = textBoxSearch.Text.Trim();
            if (dateOrderFrom.Checked)
            {
                orderFromDate = dateOrderFrom.Value.Date;
            }
            else
            {
                orderFromDate = null;
            }
            if (dateOrderTo.Checked)
            {
                orderToDate = dateOrderTo.Value.Date;
            }
            else
            {
                orderToDate = null;
            }

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                complexViewModel.LoadSearchOrderNumbers(orderFromDate, orderToDate, orderId); 
                listBoxOrderId.Items.Clear();
                Font newFont = new Font(listBoxOrderId.Font.FontFamily, 12, FontStyle.Regular);
                Font usualFont = new Font(listBoxOrderId.Font.FontFamily, 28, FontStyle.Regular);
                int[] numbers = complexViewModel.OrderNumbers;
                if (numbers.Length != 0)
                {
                    listBoxOrderId.Enabled = true;
                    listBoxOrderId.Font = usualFont;
                    listBoxOrderId.Items.AddRange(numbers.Select(n => n.ToString()).ToArray());
                }
                else
                { 
                    listBoxOrderId.Items.Clear();
                    listBoxOrderId.Font = newFont;
                    string msg = "No results found!";
                    listBoxOrderId.Items.Add(msg);
                    listBoxOrderId.Enabled = false;
                }
                if (listBoxOrderId.SelectedIndex == -1)
                {
                    btnViewDetails.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong with the search. Please try again later or contact support for assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e);
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                tooltip.Show("Please enter a numeric value!", textBoxSearch, 0, 20, 2000);
            }
            else
            {
                tooltip.RemoveAll();
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            try
            {
                OnComplexDetailedViewRequested();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong with the search. Please try again later or contact support for assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
