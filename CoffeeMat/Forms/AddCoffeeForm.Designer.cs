namespace CoffeeMat
{
    partial class AddCoffeeForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.CoffeePictureAddDialog = new System.Windows.Forms.OpenFileDialog();
            this.PictureAddButton = new System.Windows.Forms.Button();
            this.CoffeeNumeric = new System.Windows.Forms.NumericUpDown();
            this.WaterNumeric = new System.Windows.Forms.NumericUpDown();
            this.MilkNumeric = new System.Windows.Forms.NumericUpDown();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.CoffeeLabel = new System.Windows.Forms.Label();
            this.WaterLabel = new System.Windows.Forms.Label();
            this.MilkLabel = new System.Windows.Forms.Label();
            this.ReceiptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MilkNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.Location = new System.Drawing.Point(334, 385);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 30);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(303, 198);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(175, 26);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(303, 230);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(175, 26);
            this.PriceBox.TabIndex = 2;
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(250, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(292, 144);
            this.PictureBox.TabIndex = 4;
            this.PictureBox.TabStop = false;
            // 
            // CoffeePictureAddDialog
            // 
            this.CoffeePictureAddDialog.FileName = "openFileDialog1";
            // 
            // PictureAddButton
            // 
            this.PictureAddButton.AutoSize = true;
            this.PictureAddButton.Location = new System.Drawing.Point(291, 162);
            this.PictureAddButton.Name = "PictureAddButton";
            this.PictureAddButton.Size = new System.Drawing.Size(198, 30);
            this.PictureAddButton.TabIndex = 5;
            this.PictureAddButton.Text = "Добавить изображение";
            this.PictureAddButton.UseVisualStyleBackColor = true;
            this.PictureAddButton.Click += new System.EventHandler(this.PictureAddButton_Click);
            // 
            // CoffeeNumeric
            // 
            this.CoffeeNumeric.Location = new System.Drawing.Point(334, 289);
            this.CoffeeNumeric.Name = "CoffeeNumeric";
            this.CoffeeNumeric.Size = new System.Drawing.Size(120, 26);
            this.CoffeeNumeric.TabIndex = 6;
            // 
            // WaterNumeric
            // 
            this.WaterNumeric.Location = new System.Drawing.Point(334, 321);
            this.WaterNumeric.Name = "WaterNumeric";
            this.WaterNumeric.Size = new System.Drawing.Size(120, 26);
            this.WaterNumeric.TabIndex = 7;
            // 
            // MilkNumeric
            // 
            this.MilkNumeric.Location = new System.Drawing.Point(334, 353);
            this.MilkNumeric.Name = "MilkNumeric";
            this.MilkNumeric.Size = new System.Drawing.Size(120, 26);
            this.MilkNumeric.TabIndex = 8;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(214, 204);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(83, 20);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Название";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(226, 236);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(48, 20);
            this.PriceLabel.TabIndex = 10;
            this.PriceLabel.Text = "Цена";
            // 
            // CoffeeLabel
            // 
            this.CoffeeLabel.AutoSize = true;
            this.CoffeeLabel.Location = new System.Drawing.Point(246, 291);
            this.CoffeeLabel.Name = "CoffeeLabel";
            this.CoffeeLabel.Size = new System.Drawing.Size(52, 20);
            this.CoffeeLabel.TabIndex = 11;
            this.CoffeeLabel.Text = "Кофе";
            // 
            // WaterLabel
            // 
            this.WaterLabel.AutoSize = true;
            this.WaterLabel.Location = new System.Drawing.Point(248, 327);
            this.WaterLabel.Name = "WaterLabel";
            this.WaterLabel.Size = new System.Drawing.Size(49, 20);
            this.WaterLabel.TabIndex = 12;
            this.WaterLabel.Text = "Вода";
            // 
            // MilkLabel
            // 
            this.MilkLabel.AutoSize = true;
            this.MilkLabel.Location = new System.Drawing.Point(246, 359);
            this.MilkLabel.Name = "MilkLabel";
            this.MilkLabel.Size = new System.Drawing.Size(67, 20);
            this.MilkLabel.TabIndex = 13;
            this.MilkLabel.Text = "Молоко";
            // 
            // ReceiptLabel
            // 
            this.ReceiptLabel.AutoSize = true;
            this.ReceiptLabel.Location = new System.Drawing.Point(350, 266);
            this.ReceiptLabel.Name = "ReceiptLabel";
            this.ReceiptLabel.Size = new System.Drawing.Size(64, 20);
            this.ReceiptLabel.TabIndex = 14;
            this.ReceiptLabel.Text = "Рецепт";
            // 
            // CoffeeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReceiptLabel);
            this.Controls.Add(this.MilkLabel);
            this.Controls.Add(this.WaterLabel);
            this.Controls.Add(this.CoffeeLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.MilkNumeric);
            this.Controls.Add(this.WaterNumeric);
            this.Controls.Add(this.CoffeeNumeric);
            this.Controls.Add(this.PictureAddButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.AddButton);
            this.Name = "CoffeeAddForm";
            this.Text = "CoffeeAddForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MilkNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.OpenFileDialog CoffeePictureAddDialog;
        private System.Windows.Forms.Button PictureAddButton;
        private System.Windows.Forms.NumericUpDown CoffeeNumeric;
        private System.Windows.Forms.NumericUpDown WaterNumeric;
        private System.Windows.Forms.NumericUpDown MilkNumeric;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label CoffeeLabel;
        private System.Windows.Forms.Label WaterLabel;
        private System.Windows.Forms.Label MilkLabel;
        private System.Windows.Forms.Label ReceiptLabel;
    }
}