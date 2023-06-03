namespace ui.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.panelMainView = new System.Windows.Forms.Panel();
            this.btnComplexView = new System.Windows.Forms.Button();
            this.btnShowBareBones = new System.Windows.Forms.Button();
            this.labelMainView = new System.Windows.Forms.Label();
            this.panelChildView = new System.Windows.Forms.Panel();
            this.panelMainView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainView
            // 
            this.panelMainView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainView.BackColor = System.Drawing.Color.Honeydew;
            this.panelMainView.Controls.Add(this.btnComplexView);
            this.panelMainView.Controls.Add(this.btnShowBareBones);
            this.panelMainView.Controls.Add(this.labelMainView);
            this.panelMainView.Location = new System.Drawing.Point(0, 0);
            this.panelMainView.Name = "panelMainView";
            this.panelMainView.Size = new System.Drawing.Size(1485, 83);
            this.panelMainView.TabIndex = 0;
            // 
            // btnComplexView
            // 
            this.btnComplexView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComplexView.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplexView.Location = new System.Drawing.Point(937, 23);
            this.btnComplexView.Name = "btnComplexView";
            this.btnComplexView.Size = new System.Drawing.Size(517, 39);
            this.btnComplexView.TabIndex = 2;
            this.btnComplexView.Text = "Complex View";
            this.btnComplexView.UseVisualStyleBackColor = true;
            this.btnComplexView.Click += new System.EventHandler(this.btnComplexView_Click);
            // 
            // btnShowBareBones
            // 
            this.btnShowBareBones.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBareBones.Location = new System.Drawing.Point(33, 23);
            this.btnShowBareBones.Name = "btnShowBareBones";
            this.btnShowBareBones.Size = new System.Drawing.Size(517, 39);
            this.btnShowBareBones.TabIndex = 1;
            this.btnShowBareBones.Text = "BareBones View";
            this.btnShowBareBones.UseVisualStyleBackColor = true;
            this.btnShowBareBones.Click += new System.EventHandler(this.btnShowBareBones_Click);
            // 
            // labelMainView
            // 
            this.labelMainView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelMainView.AutoSize = true;
            this.labelMainView.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainView.Location = new System.Drawing.Point(617, 23);
            this.labelMainView.Name = "labelMainView";
            this.labelMainView.Size = new System.Drawing.Size(229, 39);
            this.labelMainView.TabIndex = 0;
            this.labelMainView.Text = "Practical Test";
            // 
            // panelChildView
            // 
            this.panelChildView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildView.BackColor = System.Drawing.Color.MintCream;
            this.panelChildView.Location = new System.Drawing.Point(0, 80);
            this.panelChildView.MinimumSize = new System.Drawing.Size(1485, 720);
            this.panelChildView.Name = "panelChildView";
            this.panelChildView.Size = new System.Drawing.Size(1485, 720);
            this.panelChildView.TabIndex = 1;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 799);
            this.Controls.Add(this.panelChildView);
            this.Controls.Add(this.panelMainView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1501, 838);
            this.Name = "MainView";
            this.Text = "Practical Test";
            this.panelMainView.ResumeLayout(false);
            this.panelMainView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainView;
        private System.Windows.Forms.Button btnShowBareBones;
        private System.Windows.Forms.Label labelMainView;
        private System.Windows.Forms.Button btnComplexView;
        private System.Windows.Forms.Panel panelChildView;
    }
}