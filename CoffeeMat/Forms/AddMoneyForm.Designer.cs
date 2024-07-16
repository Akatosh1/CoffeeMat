namespace CoffeeMat.Forms
{
    partial class AddMoneyForm
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
            this.MoneyPictureBox = new System.Windows.Forms.PictureBox();
            this.AddPictureButton = new System.Windows.Forms.Button();
            this.MoneyNameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AddMoneyItemButton = new System.Windows.Forms.Button();
            this.MoneyPictureAddDialog = new System.Windows.Forms.OpenFileDialog();
            this.AmountNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // MoneyPictureBox
            // 
            this.MoneyPictureBox.Location = new System.Drawing.Point(260, 12);
            this.MoneyPictureBox.Name = "MoneyPictureBox";
            this.MoneyPictureBox.Size = new System.Drawing.Size(240, 152);
            this.MoneyPictureBox.TabIndex = 0;
            this.MoneyPictureBox.TabStop = false;
            // 
            // AddPictureButton
            // 
            this.AddPictureButton.Location = new System.Drawing.Point(260, 170);
            this.AddPictureButton.Name = "AddPictureButton";
            this.AddPictureButton.Size = new System.Drawing.Size(240, 50);
            this.AddPictureButton.TabIndex = 1;
            this.AddPictureButton.Text = "Добавить изображение";
            this.AddPictureButton.UseVisualStyleBackColor = true;
            this.AddPictureButton.Click += new System.EventHandler(this.AddPictureButton_Click);
            // 
            // MoneyNameBox
            // 
            this.MoneyNameBox.Location = new System.Drawing.Point(295, 226);
            this.MoneyNameBox.Name = "MoneyNameBox";
            this.MoneyNameBox.Size = new System.Drawing.Size(160, 26);
            this.MoneyNameBox.TabIndex = 2;
            this.MoneyNameBox.TextChanged += new System.EventHandler(this.MoneyNameBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(206, 229);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(83, 20);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Название";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(206, 261);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(83, 20);
            this.AmountLabel.TabIndex = 5;
            this.AmountLabel.Text = "Ценность";
            // 
            // AddMoneyItemButton
            // 
            this.AddMoneyItemButton.Location = new System.Drawing.Point(295, 290);
            this.AddMoneyItemButton.Name = "AddMoneyItemButton";
            this.AddMoneyItemButton.Size = new System.Drawing.Size(160, 35);
            this.AddMoneyItemButton.TabIndex = 6;
            this.AddMoneyItemButton.Text = "Добавить";
            this.AddMoneyItemButton.UseVisualStyleBackColor = true;
            this.AddMoneyItemButton.Click += new System.EventHandler(this.AddMoneyExampleButton_Click);
            // 
            // MoneyPictureAddDialog
            // 
            this.MoneyPictureAddDialog.FileName = "openFileDialog1";
            // 
            // AmountNumeric
            // 
            this.AmountNumeric.Location = new System.Drawing.Point(295, 261);
            this.AmountNumeric.Name = "AmountNumeric";
            this.AmountNumeric.Size = new System.Drawing.Size(160, 26);
            this.AmountNumeric.TabIndex = 7;
            // 
            // AddMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AmountNumeric);
            this.Controls.Add(this.AddMoneyItemButton);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.MoneyNameBox);
            this.Controls.Add(this.AddPictureButton);
            this.Controls.Add(this.MoneyPictureBox);
            this.Name = "AddMoneyForm";
            this.Text = "AddMoneyForm";
            ((System.ComponentModel.ISupportInitialize)(this.MoneyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MoneyPictureBox;
        private System.Windows.Forms.Button AddPictureButton;
        private System.Windows.Forms.TextBox MoneyNameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Button AddMoneyItemButton;
        private System.Windows.Forms.OpenFileDialog MoneyPictureAddDialog;
        private System.Windows.Forms.NumericUpDown AmountNumeric;
    }
}