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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResourceNameBox = new System.Windows.Forms.TextBox();
            this.ResourceAmountBox = new System.Windows.Forms.NumericUpDown();
            this.AddResourceButton = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество";
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
            // AddResourceButton
            // 
            this.AddResourceButton.Location = new System.Drawing.Point(322, 271);
            this.AddResourceButton.Name = "AddResourceButton";
            this.AddResourceButton.Size = new System.Drawing.Size(141, 44);
            this.AddResourceButton.TabIndex = 5;
            this.AddResourceButton.Text = "Добавить";
            this.AddResourceButton.UseVisualStyleBackColor = true;
            this.AddResourceButton.Click += new System.EventHandler(this.AddResourceButton_Click);
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
            this.Controls.Add(this.AddResourceButton);
            this.Controls.Add(this.ResourceAmountBox);
            this.Controls.Add(this.ResourceNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ResourceNameBox;
        private System.Windows.Forms.NumericUpDown ResourceAmountBox;
        private System.Windows.Forms.Button AddResourceButton;
        private System.Windows.Forms.OpenFileDialog ResourcePictureAddDialog;
        private System.Windows.Forms.Button AddPictureButton;
    }
}