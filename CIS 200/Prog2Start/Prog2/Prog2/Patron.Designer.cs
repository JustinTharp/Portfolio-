namespace LibraryItems
{
    partial class NewPatron
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
            this.patronNameLabel = new System.Windows.Forms.Label();
            this.patronIdLabel = new System.Windows.Forms.Label();
            this.patronIdTextBox = new System.Windows.Forms.TextBox();
            this.patronNameTextBox = new System.Windows.Forms.TextBox();
            this.addPatronButton = new System.Windows.Forms.Button();
            this.patronCancelButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // patronNameLabel
            // 
            this.patronNameLabel.AutoSize = true;
            this.patronNameLabel.Location = new System.Drawing.Point(24, 30);
            this.patronNameLabel.Name = "patronNameLabel";
            this.patronNameLabel.Size = new System.Drawing.Size(38, 13);
            this.patronNameLabel.TabIndex = 0;
            this.patronNameLabel.Text = "Name:";
            // 
            // patronIdLabel
            // 
            this.patronIdLabel.AutoSize = true;
            this.patronIdLabel.Location = new System.Drawing.Point(24, 73);
            this.patronIdLabel.Name = "patronIdLabel";
            this.patronIdLabel.Size = new System.Drawing.Size(21, 13);
            this.patronIdLabel.TabIndex = 1;
            this.patronIdLabel.Text = "ID:";
            // 
            // patronIdTextBox
            // 
            this.patronIdTextBox.Location = new System.Drawing.Point(87, 66);
            this.patronIdTextBox.Name = "patronIdTextBox";
            this.patronIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.patronIdTextBox.TabIndex = 2;
            this.patronIdTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.patronIDText_Validating);
            this.patronIdTextBox.Validated += new System.EventHandler(this.patronIDText_Validated);
            // 
            // patronNameTextBox
            // 
            this.patronNameTextBox.Location = new System.Drawing.Point(87, 23);
            this.patronNameTextBox.Name = "patronNameTextBox";
            this.patronNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.patronNameTextBox.TabIndex = 3;
            this.patronNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.patronNameText_Validating);
            this.patronNameTextBox.Validated += new System.EventHandler(this.patronNameText_Validated);
            // 
            // addPatronButton
            // 
            this.addPatronButton.Location = new System.Drawing.Point(12, 122);
            this.addPatronButton.Name = "addPatronButton";
            this.addPatronButton.Size = new System.Drawing.Size(90, 32);
            this.addPatronButton.TabIndex = 4;
            this.addPatronButton.Text = "Add Patron";
            this.addPatronButton.UseVisualStyleBackColor = true;
            this.addPatronButton.Click += new System.EventHandler(this.patronOkButton_Click);
            // 
            // patronCancelButton
            // 
            this.patronCancelButton.Location = new System.Drawing.Point(123, 122);
            this.patronCancelButton.Name = "patronCancelButton";
            this.patronCancelButton.Size = new System.Drawing.Size(100, 32);
            this.patronCancelButton.TabIndex = 5;
            this.patronCancelButton.Text = "Cancel";
            this.patronCancelButton.UseVisualStyleBackColor = true;
            this.patronCancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.patronCancelButton_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // NewPatron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 182);
            this.Controls.Add(this.patronCancelButton);
            this.Controls.Add(this.addPatronButton);
            this.Controls.Add(this.patronNameTextBox);
            this.Controls.Add(this.patronIdTextBox);
            this.Controls.Add(this.patronIdLabel);
            this.Controls.Add(this.patronNameLabel);
            this.Name = "NewPatron";
            this.Text = "Patron";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patronNameLabel;
        private System.Windows.Forms.Label patronIdLabel;
        private System.Windows.Forms.TextBox patronIdTextBox;
        private System.Windows.Forms.TextBox patronNameTextBox;
        private System.Windows.Forms.Button addPatronButton;
        private System.Windows.Forms.Button patronCancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}