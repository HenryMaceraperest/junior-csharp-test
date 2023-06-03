using System;
using System.Windows.Forms;
using ui.Models;
using ui.ViewModels;

namespace ui.Views
{
    public partial class ComplexDetailedView : Form
    {
        private readonly ComplexViewModel complexViewModel;
        public event EventHandler HideComplexDetailedView;
        public ComplexDetailedView()
        {
            InitializeComponent();
            complexViewModel = new ComplexViewModel();
        }

        private void OnHideComplexDetailedView()
        {
            HideComplexDetailedView?.Invoke(this, EventArgs.Empty);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            OnHideComplexDetailedView();
        }

        public void FillComplexDetailedView(string orderId)
        {
            if (orderId != null) {
                try
                {
                    complexViewModel.SetComplexDetailedViewOrder(orderId);
                    OrderModel orderModel = complexViewModel.OrderDetailModel;
                    if (orderModel != null)
                    {
                        textBoxOrderNr.Text = orderModel.OrderNumber.ToString();
                        textBoxOrderDate.Text = orderModel.OrderDate.ToString("dd-MM-yyyy");
                        textBoxSalePrice.Text = orderModel.SalePrice.ToString();
                        textBoxOrderDeposit.Text = orderModel.Deposit.ToString();
                        textBoxCustomerNr.Text = orderModel.Customer.CustomerNumber.ToString();
                        textBoxCustomerForename.Text = orderModel.Customer.Forename.ToString();
                        textBoxCustomerSurname.Text = orderModel.Customer.Surname.ToString();
                        textBoxCustomerPhone.Text = orderModel.Customer.TelephoneNumber.ToString();
                        textBoxBranchName.Text = orderModel.Employee.Branch.BranchName.ToString();
                        textBoxBranchPostal.Text = orderModel.Employee.Branch.Postcode.ToString();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    MessageBox.Show("Something went wrong with loading the details. Please try again later or contact support for assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
