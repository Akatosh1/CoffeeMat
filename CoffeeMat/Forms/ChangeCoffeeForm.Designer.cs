namespace CoffeeMat
{
    partial class ChangeCoffeeForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CoffeeGridView = new System.Windows.Forms.DataGridView();
            this.CoffeeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NewCoffeeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CoffeeGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CoffeeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.15909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 283F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CoffeeGridView
            // 
            this.CoffeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoffeeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoffeeGridView.Location = new System.Drawing.Point(3, 42);
            this.CoffeeGridView.Name = "CoffeeGridView";
            this.CoffeeGridView.RowHeadersWidth = 62;
            this.CoffeeGridView.RowTemplate.Height = 28;
            this.CoffeeGridView.Size = new System.Drawing.Size(794, 277);
            this.CoffeeGridView.TabIndex = 0;
            // 
            // CoffeeLabel
            // 
            this.CoffeeLabel.AutoSize = true;
            this.CoffeeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoffeeLabel.Location = new System.Drawing.Point(3, 0);
            this.CoffeeLabel.Name = "CoffeeLabel";
            this.CoffeeLabel.Size = new System.Drawing.Size(794, 39);
            this.CoffeeLabel.TabIndex = 1;
            this.CoffeeLabel.Text = "Виды кофе";
            this.CoffeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.DeleteButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ChangeButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.SaveButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.NewCoffeeButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 325);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 122);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.Location = new System.Drawing.Point(400, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(391, 55);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeButton.Location = new System.Drawing.Point(3, 64);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(391, 55);
            this.ChangeButton.TabIndex = 2;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveButton.Location = new System.Drawing.Point(400, 64);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(391, 55);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // NewCoffeeButton
            // 
            this.NewCoffeeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewCoffeeButton.Location = new System.Drawing.Point(3, 3);
            this.NewCoffeeButton.Name = "NewCoffeeButton";
            this.NewCoffeeButton.Size = new System.Drawing.Size(391, 55);
            this.NewCoffeeButton.TabIndex = 4;
            this.NewCoffeeButton.Text = "Создать";
            this.NewCoffeeButton.UseVisualStyleBackColor = true;
            this.NewCoffeeButton.Click += new System.EventHandler(this.NewCoffeeButton_Click);
            // 
            // ChangeCoffeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ChangeCoffeeForm";
            this.Text = "ChangeCoffeeForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView CoffeeGridView;
        private System.Windows.Forms.Label CoffeeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NewCoffeeButton;
    }
}