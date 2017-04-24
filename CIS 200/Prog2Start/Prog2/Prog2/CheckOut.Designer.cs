namespace LibraryItems
{
    partial class CheckOut
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
            this.patronComboBox = new System.Windows.Forms.ComboBox();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.selectItemLabel = new System.Windows.Forms.Label();
            this.selectPatronLabel = new System.Windows.Forms.Label();
            this.checkoutOkButton = new System.Windows.Forms.Button();
            this.checkoutCancelButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // patronComboBox
            // 
            this.patronComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patronComboBox.FormattingEnabled = true;
            this.patronComboBox.Location = new System.Drawing.Point(108, 194);
            this.patronComboBox.Name = "patronComboBox";
            this.patronComboBox.Size = new System.Drawing.Size(156, 21);
            this.patronComboBox.TabIndex = 0;
            this.patronComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.patronComboBox_Validating);
            this.patronComboBox.Validated += new System.EventHandler(this.patronComboBox_Validated);
            // 
            // itemComboBox
            // 
            this.itemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(108, 28);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(156, 21);
            this.itemComboBox.TabIndex = 1;
            this.itemComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.itemComboBox_Validating);
            this.itemComboBox.Validated += new System.EventHandler(this.itemComboBox_Validated);
            // 
            // selectItemLabel
            // 
            this.selectItemLabel.AutoSize = true;
            this.selectItemLabel.Location = new System.Drawing.Point(28, 36);
            this.selectItemLabel.Name = "selectItemLabel";
            this.selectItemLabel.Size = new System.Drawing.Size(60, 13);
            this.selectItemLabel.TabIndex = 2;
            this.selectItemLabel.Text = "Select Item";
            // 
            // selectPatronLabel
            // 
            this.selectPatronLabel.AutoSize = true;
            this.selectPatronLabel.Location = new System.Drawing.Point(17, 202);
            this.selectPatronLabel.Name = "selectPatronLabel";
            this.selectPatronLabel.Size = new System.Drawing.Size(71, 13);
            this.selectPatronLabel.TabIndex = 3;
            this.selectPatronLabel.Text = "Select Patron";
            // 
            // checkoutOkButton
            // 
            this.checkoutOkButton.Location = new System.Drawing.Point(31, 322);
            this.checkoutOkButton.Name = "checkoutOkButton";
            this.checkoutOkButton.Size = new System.Drawing.Size(86, 32);
            this.checkoutOkButton.TabIndex = 4;
            this.checkoutOkButton.Text = "Check Out";
            this.checkoutOkButton.UseVisualStyleBackColor = true;
            this.checkoutOkButton.Click += new System.EventHandler(this.checkoutOkButton_Click);
            // 
            // checkoutCancelButton
            // 
            this.checkoutCancelButton.Location = new System.Drawing.Point(161, 322);
            this.checkoutCancelButton.Name = "checkoutCancelButton";
            this.checkoutCancelButton.Size = new System.Drawing.Size(86, 32);
            this.checkoutCancelButton.TabIndex = 5;
            this.checkoutCancelButton.Text = "Cancel";
            this.checkoutCancelButton.UseVisualStyleBackColor = true;
            this.checkoutCancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkoutCancelButton_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 380);
            this.Controls.Add(this.checkoutCancelButton);
            this.Controls.Add(this.checkoutOkButton);
            this.Controls.Add(this.selectPatronLabel);
            this.Controls.Add(this.selectItemLabel);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.patronComboBox);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox patronComboBox;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.Label selectItemLabel;
        private System.Windows.Forms.Label selectPatronLabel;
        private System.Windows.Forms.Button checkoutOkButton;
        private System.Windows.Forms.Button checkoutCancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}