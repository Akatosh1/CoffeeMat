namespace CoffeeMat.Forms
{
    partial class AddExtrasForm
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
            this.ExtrasTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // ExtrasTablePanel
            // 
            this.ExtrasTablePanel.ColumnCount = 1;
            this.ExtrasTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ExtrasTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExtrasTablePanel.Location = new System.Drawing.Point(0, 0);
            this.ExtrasTablePanel.Name = "ExtrasTablePanel";
            this.ExtrasTablePanel.RowCount = 3;
            this.ExtrasTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ExtrasTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ExtrasTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ExtrasTablePanel.Size = new System.Drawing.Size(800, 450);
            this.ExtrasTablePanel.TabIndex = 0;
            // 
            // AddExtrasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExtrasTablePanel);
            this.Name = "AddExtrasForm";
            this.Text = "AddExtrasForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ExtrasTablePanel;
    }
}