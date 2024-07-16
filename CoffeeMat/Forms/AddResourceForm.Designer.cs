namespace CoffeeMat.Forms
{
    partial class AddResourceForm
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
            this.ResourcePictureBox = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.ResourceNameBox = new System.Windows.Forms.TextBox();
            this.ResourceAmountBox = new System.Windows.Forms.NumericUpDown();
            this.AddResourceItemButton = new System.Windows.Forms.Button();
            this.ResourcePictureAddDialog = new System.Windows.Forms.OpenFileDialog();
            this.AddPictureButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResourcePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResourceAmountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ResourcePictureBox
            // 
            this.ResourcePictureBox.Location = new System.Drawing.Point(275, 12);
            this.ResourcePictureBox.Name = "ResourcePictureBox";
            this.ResourcePictureBox.Size = new System.Drawing.Size(239, 144);
            this.ResourcePictureBox.TabIndex = 0;
            this.ResourcePictureBox.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(233, 199);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(83, 20);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Название";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(216, 239);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(100, 20);
            this.AmountLabel.TabIndex = 2;
            this.AmountLabel.Text = "Количество";
            // 
            // ResourceNameBox
            // 
            this.ResourceNameBox.Location = new System.Drawing.Point(322, 196);
            this.ResourceNameBox.Name = "ResourceNameBox";
            this.ResourceNameBox.Size = new System.Drawing.Size(141, 26);
            this.ResourceNameBox.TabIndex = 3;
            this.ResourceNameBox.TextChanged += new System.EventHandler(this.ResourceNameBox_TextChanged);
            // 
            // ResourceAmountBox
            // 
            this.ResourceAmountBox.Location = new System.Drawing.Point(322, 239);
            this.ResourceAmountBox.Name = "ResourceAmountBox";
            this.ResourceAmountBox.Size = new System.Drawing.Size(141, 26);
            this.ResourceAmountBox.TabIndex = 4;
            // 
            // AddResourceItemButton
            // 
            this.AddResourceItemButton.Location = new System.Drawing.Point(322, 271);
            this.AddResourceItemButton.Name = "AddResourceItemButton";
            this.AddResourceItemButton.Size = new System.Drawing.Size(141, 44);
            this.AddResourceItemButton.TabIndex = 5;
            this.AddResourceItemButton.Text = "Добавить";
            this.AddResourceItemButton.UseVisualStyleBackColor = true;
            this.AddResourceItemButton.Click += new System.EventHandler(this.AddResourceButton_Click);
            // 
            // ResourcePictureAddDialog
            // 
            this.ResourcePictureAddDialog.FileName = "openFileDialog1";
            // 
            // AddPictureButton
            // 
            this.AddPictureButton.Location = new System.Drawing.Point(322, 163);
            this.AddPictureButton.Name = "AddPictureButton";
            this.AddPictureButton.Size = new System.Drawing.Size(141, 27);
            this.AddPictureButton.TabIndex = 6;
            this.AddPictureButton.Text = "Добавить";
            this.AddPictureButton.UseVisualStyleBackColor = true;
            this.AddPictureButton.Click += new System.EventHandler(this.AddPictureButton_Click);
            // 
            // AddResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddPictureButton);
            this.Controls.Add(this.AddResourceItemButton);
            this.Controls.Add(this.ResourceAmountBox);
            this.Controls.Add(this.ResourceNameBox);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ResourcePictureBox);
            this.Name = "AddResourceForm";
            this.Text = "AddResourceForm";
            ((System.ComponentModel.ISupportInitialize)(this.ResourcePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResourceAmountBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ResourcePictureBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox ResourceNameBox;
        private System.Windows.Forms.NumericUpDown ResourceAmountBox;
        private System.Windows.Forms.Button AddResourceItemButton;
        private System.Windows.Forms.OpenFileDialog ResourcePictureAddDialog;
        private System.Windows.Forms.Button AddPictureButton;
    }
}