namespace CoffeeMat
{
    partial class StartScreen
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
            this.startTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CoffeeMachineButton = new System.Windows.Forms.Button();
            this.CoffeeFormattingButton = new System.Windows.Forms.Button();
            this.FillResoucesButton = new System.Windows.Forms.Button();
            this.ConsoleButton = new System.Windows.Forms.Button();
            this.startTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // startTableLayout
            // 
            this.startTableLayout.AutoSize = true;
            this.startTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.startTableLayout.ColumnCount = 1;
            this.startTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.startTableLayout.Controls.Add(this.CoffeeMachineButton, 0, 0);
            this.startTableLayout.Controls.Add(this.CoffeeFormattingButton, 0, 1);
            this.startTableLayout.Controls.Add(this.FillResoucesButton, 0, 2);
            this.startTableLayout.Controls.Add(this.ConsoleButton, 0, 3);
            this.startTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startTableLayout.Location = new System.Drawing.Point(0, 0);
            this.startTableLayout.Name = "startTableLayout";
            this.startTableLayout.RowCount = 4;
            this.startTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.startTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.startTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.startTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.startTableLayout.Size = new System.Drawing.Size(978, 544);
            this.startTableLayout.TabIndex = 0;
            // 
            // CoffeeMachineButton
            // 
            this.CoffeeMachineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoffeeMachineButton.Location = new System.Drawing.Point(5, 5);
            this.CoffeeMachineButton.Name = "CoffeeMachineButton";
            this.CoffeeMachineButton.Size = new System.Drawing.Size(968, 127);
            this.CoffeeMachineButton.TabIndex = 0;
            this.CoffeeMachineButton.Text = "Запуск кофе машины";
            this.CoffeeMachineButton.UseVisualStyleBackColor = true;
            this.CoffeeMachineButton.Click += new System.EventHandler(this.CoffeeMachineButton_Click);
            // 
            // CoffeeFormattingButton
            // 
            this.CoffeeFormattingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoffeeFormattingButton.Location = new System.Drawing.Point(5, 140);
            this.CoffeeFormattingButton.Name = "CoffeeFormattingButton";
            this.CoffeeFormattingButton.Size = new System.Drawing.Size(968, 127);
            this.CoffeeFormattingButton.TabIndex = 1;
            this.CoffeeFormattingButton.Text = "Редактирование видов кофе";
            this.CoffeeFormattingButton.UseVisualStyleBackColor = true;
            this.CoffeeFormattingButton.Click += new System.EventHandler(this.CoffeeFormattingButton_Click);
            // 
            // FillResoucesButton
            // 
            this.FillResoucesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FillResoucesButton.Location = new System.Drawing.Point(5, 275);
            this.FillResoucesButton.Name = "FillResoucesButton";
            this.FillResoucesButton.Size = new System.Drawing.Size(968, 127);
            this.FillResoucesButton.TabIndex = 2;
            this.FillResoucesButton.Text = "Восполнение ресурсов";
            this.FillResoucesButton.UseVisualStyleBackColor = true;
            this.FillResoucesButton.Click += new System.EventHandler(this.FillResoucesButton_Click);
            // 
            // ConsoleButton
            // 
            this.ConsoleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleButton.Location = new System.Drawing.Point(5, 410);
            this.ConsoleButton.Name = "ConsoleButton";
            this.ConsoleButton.Size = new System.Drawing.Size(968, 129);
            this.ConsoleButton.TabIndex = 3;
            this.ConsoleButton.Text = "Работа с консолью";
            this.ConsoleButton.UseVisualStyleBackColor = true;
            this.ConsoleButton.Click += new System.EventHandler(this.ConsoleButton_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.startTableLayout);
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartScreen";
            this.startTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel startTableLayout;
        private System.Windows.Forms.Button CoffeeMachineButton;
        private System.Windows.Forms.Button CoffeeFormattingButton;
        private System.Windows.Forms.Button FillResoucesButton;
        private System.Windows.Forms.Button ConsoleButton;
    }
}