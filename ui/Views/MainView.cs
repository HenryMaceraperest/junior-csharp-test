using System;
using System.Windows.Forms;

namespace ui.Views
{
    public partial class MainView : Form
    {
        private BareBoneView bareBoneView;
        private ComplexView complexView;
        private ComplexDetailedView complexDetailedView;

        public MainView()
        {
            InitializeComponent();
            InitializeViews();
            complexView.ComplexDetailedViewRequested += complexView_ComplexDetailedViewRequested;
            complexDetailedView.HideComplexDetailedView += complexDetailedView_HideComplexDetailedView;
            complexView.FillComplexDetailedViewById += ComplexView_FillComplexDetailedViewById;
            HideAllChildViews();
        }

        private void InitializeViews()
        {
            bareBoneView = new BareBoneView();
            complexView = new ComplexView();
            complexDetailedView = new ComplexDetailedView();
            bareBoneView.TopLevel = false;
            complexView.TopLevel = false;
            complexDetailedView.TopLevel = false;
            bareBoneView.FormBorderStyle = FormBorderStyle.None;
            complexView.FormBorderStyle = FormBorderStyle.None;
            complexDetailedView.FormBorderStyle = FormBorderStyle.None;
            bareBoneView.Dock = DockStyle.Fill;
            complexView.Dock = DockStyle.Fill;
            complexDetailedView.Dock = DockStyle.Fill;
            panelChildView.Controls.Add(bareBoneView);
            panelChildView.Controls.Add(complexView);
            panelChildView.Controls.Add(complexDetailedView);
            complexDetailedView.Visible = false;
        }

        private void complexView_ComplexDetailedViewRequested(object sender, EventArgs e)
        {
            if (!complexDetailedView.Visible)
            {
                bareBoneView.Visible = false;
                complexView.Visible = false;
                complexDetailedView.Visible = true;
            }
        }

        private void ComplexView_FillComplexDetailedViewById(object sender, string e)
        {
            complexDetailedView.FillComplexDetailedView(e);
        }

        private void complexDetailedView_HideComplexDetailedView(object sender, EventArgs e)
        {
            if (complexDetailedView.Visible)
            {
                complexDetailedView.Visible = false;
                complexView.Visible = true;
                bareBoneView.Visible = false;
            }
        }

        private void HideAllChildViews()
        {
            if (bareBoneView != null)
            {
                bareBoneView.Visible = false;
            }
            if (complexView != null)
            {
                complexView.Visible = false;
            }
            if (complexDetailedView != null)
            {
                complexDetailedView.Visible = false;
            }
        }

        private void ShowBareBoneView()
        {
            btnComplexView.Visible = true;
            btnShowBareBones.Visible = false;
            if (!bareBoneView.Visible)
            {
                complexDetailedView.Visible = false;
                complexView.Visible = false;
                bareBoneView.Visible = true;
            }
        }

        private void ShowComplexView()
        {
            if (!complexView.Visible)
            {
                complexView.Visible = true;
                bareBoneView.Visible = false;
                complexDetailedView.Visible = false;
            }
            btnComplexView.Visible = false;
            btnShowBareBones.Visible = true;
        }

        private void btnShowBareBones_Click(object sender, EventArgs e)
        {
            ShowBareBoneView();
        }

        private void btnComplexView_Click(object sender, EventArgs e)
        {
            ShowComplexView();
        }
    }
}
