namespace CoffeeMat
{
    partial class CoffeeMachine
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CoffeeTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.MoneyTablePanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CoffeeTablePanel);
            this.splitContainer1.Panel1MinSize = 75;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MoneyTablePanel);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 594;
            this.splitContainer1.TabIndex = 1;
            // 
            // CoffeeTablePanel
            // 
            this.CoffeeTablePanel.AutoSize = true;
            this.CoffeeTablePanel.BackColor = System.Drawing.Color.White;
            this.CoffeeTablePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CoffeeTablePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.CoffeeTablePanel.ColumnCount = 2;
            this.CoffeeTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CoffeeTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CoffeeTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoffeeTablePanel.Location = new System.Drawing.Point(0, 0);
            this.CoffeeTablePanel.Name = "CoffeeTablePanel";
            this.CoffeeTablePanel.RowCount = 1;
            this.CoffeeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CoffeeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CoffeeTablePanel.Size = new System.Drawing.Size(594, 450);
            this.CoffeeTablePanel.TabIndex = 0;
            // 
            // MoneyTablePanel
            // 
            this.MoneyTablePanel.AutoSize = true;
            this.MoneyTablePanel.BackColor = System.Drawing.Color.White;
            this.MoneyTablePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MoneyTablePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.MoneyTablePanel.ColumnCount = 1;
            this.MoneyTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MoneyTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoneyTablePanel.Location = new System.Drawing.Point(0, 0);
            this.MoneyTablePanel.Name = "MoneyTablePanel";
            this.MoneyTablePanel.RowCount = 2;
            this.MoneyTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MoneyTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MoneyTablePanel.Size = new System.Drawing.Size(202, 450);
            this.MoneyTablePanel.TabIndex = 0;
            // 
            // CoffeeMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CoffeeMachine";
            this.Text = "StartDeskForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel MoneyTablePanel;
        private System.Windows.Forms.TableLayoutPanel CoffeeTablePanel;
    }
}