namespace CoffeeMat.Forms
{
    partial class ShowOrderForm
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
            this.PurchaseGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PurchaseGridView
            // 
            this.PurchaseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PurchaseGridView.Location = new System.Drawing.Point(0, 0);
            this.PurchaseGridView.Name = "PurchaseGridView";
            this.PurchaseGridView.RowHeadersWidth = 62;
            this.PurchaseGridView.RowTemplate.Height = 28;
            this.PurchaseGridView.Size = new System.Drawing.Size(800, 450);
            this.PurchaseGridView.TabIndex = 0;
            // 
            // ShowOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PurchaseGridView);
            this.Name = "ShowOrderForm";
            this.Text = "ShowOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PurchaseGridView;
    }
}