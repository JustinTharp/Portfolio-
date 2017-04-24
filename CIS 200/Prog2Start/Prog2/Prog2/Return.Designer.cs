namespace LibraryItems
{
    partial class Return
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
            this.components = new System.ComponentModel.Container();
            this.returnItemLabel = new System.Windows.Forms.Label();
            this.returnItemComboBox = new System.Windows.Forms.ComboBox();
            this.returnCancelButton = new System.Windows.Forms.Button();
            this.returnItemButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // returnItemLabel
            // 
            this.returnItemLabel.AutoSize = true;
            this.returnItemLabel.Location = new System.Drawing.Point(37, 58);
            this.returnItemLabel.Name = "returnItemLabel";
            this.returnItemLabel.Size = new System.Drawing.Size(27, 13);
            this.returnItemLabel.TabIndex = 0;
            this.returnItemLabel.Text = "Item";
            // 
            // returnItemComboBox
            // 
            this.returnItemComboBox.FormattingEnabled = true;
            this.returnItemComboBox.Location = new System.Drawing.Point(114, 50);
            this.returnItemComboBox.Name = "returnItemComboBox";
            this.returnItemComboBox.Size = new System.Drawing.Size(154, 21);
            this.returnItemComboBox.TabIndex = 1;
            this.returnItemComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.returnItemComboBox_Validating);
            this.returnItemComboBox.Validated += new System.EventHandler(this.returnItemComboBox_Validated);
            // 
            // returnCancelButton
            // 
            this.returnCancelButton.Location = new System.Drawing.Point(160, 214);
            this.returnCancelButton.Name = "returnCancelButton";
            this.returnCancelButton.Size = new System.Drawing.Size(75, 23);
            this.returnCancelButton.TabIndex = 2;
            this.returnCancelButton.Text = "Cancel";
            this.returnCancelButton.UseVisualStyleBackColor = true;
            this.returnCancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.returnCancelButton_MouseDown);
            // 
            // returnItemButton
            // 
            this.returnItemButton.Location = new System.Drawing.Point(40, 214);
            this.returnItemButton.Name = "returnItemButton";
            this.returnItemButton.Size = new System.Drawing.Size(75, 23);
            this.returnItemButton.TabIndex = 3;
            this.returnItemButton.Text = "Return";
            this.returnItemButton.UseVisualStyleBackColor = true;
            this.returnItemButton.Click += new System.EventHandler(this.returnItemButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.returnItemButton);
            this.Controls.Add(this.returnCancelButton);
            this.Controls.Add(this.returnItemComboBox);
            this.Controls.Add(this.returnItemLabel);
            this.Name = "Return";
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label returnItemLabel;
        private System.Windows.Forms.ComboBox returnItemComboBox;
        private System.Windows.Forms.Button returnCancelButton;
        private System.Windows.Forms.Button returnItemButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}