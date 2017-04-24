namespace LibraryItems
{
    partial class NewBook
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
            this.bookTitleTextBox = new System.Windows.Forms.TextBox();
            this.bookPublisherTextBox = new System.Windows.Forms.TextBox();
            this.bookCopyrightTextBox = new System.Windows.Forms.TextBox();
            this.bookLoanPeriodTextBox = new System.Windows.Forms.TextBox();
            this.bookCallNumberTextBox = new System.Windows.Forms.TextBox();
            this.bookTitleLabel = new System.Windows.Forms.Label();
            this.bookPublisherLabel = new System.Windows.Forms.Label();
            this.bookAuthorTextBox = new System.Windows.Forms.TextBox();
            this.bookCopyrightLabel = new System.Windows.Forms.Label();
            this.bookLoanPeriodLabel = new System.Windows.Forms.Label();
            this.bookCallNumberLabel = new System.Windows.Forms.Label();
            this.bookAuthorLabel = new System.Windows.Forms.Label();
            this.bookOkButton = new System.Windows.Forms.Button();
            this.bookCancelButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.Location = new System.Drawing.Point(127, 50);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookTitleTextBox.TabIndex = 0;
            this.bookTitleTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.bookTitleText_Validating);
            this.bookTitleTextBox.Validated += new System.EventHandler(this.bookTitleText_Validated);
            // 
            // bookPublisherTextBox
            // 
            this.bookPublisherTextBox.Location = new System.Drawing.Point(127, 85);
            this.bookPublisherTextBox.Name = "bookPublisherTextBox";
            this.bookPublisherTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookPublisherTextBox.TabIndex = 1;
            this.bookPublisherTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.bookPublisherText_Validating);
            this.bookPublisherTextBox.Validated += new System.EventHandler(this.bookPublisherText_Validated);
            // 
            // bookCopyrightTextBox
            // 
            this.bookCopyrightTextBox.Location = new System.Drawing.Point(127, 120);
            this.bookCopyrightTextBox.Name = "bookCopyrightTextBox";
            this.bookCopyrightTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookCopyrightTextBox.TabIndex = 2;
            this.bookCopyrightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.bookCopyrightText_Validating);
            this.bookCopyrightTextBox.Validated += new System.EventHandler(this.bookCopyrightText_Validated);
            // 
            // bookLoanPeriodTextBox
            // 
            this.bookLoanPeriodTextBox.Location = new System.Drawing.Point(127, 158);
            this.bookLoanPeriodTextBox.Name = "bookLoanPeriodTextBox";
            this.bookLoanPeriodTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookLoanPeriodTextBox.TabIndex = 3;
            this.bookLoanPeriodTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.bookLoanPeriodText_Validating);
            this.bookLoanPeriodTextBox.Validated += new System.EventHandler(this.bookLoanPeriod_Validated);
            // 
            // bookCallNumberTextBox
            // 
            this.bookCallNumberTextBox.Location = new System.Drawing.Point(127, 194);
            this.bookCallNumberTextBox.Name = "bookCallNumberTextBox";
            this.bookCallNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookCallNumberTextBox.TabIndex = 4;
            this.bookCallNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.bookCallNumberText_Validating);
            this.bookCallNumberTextBox.Validated += new System.EventHandler(this.bookCallNumberText_Validated);
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.AutoSize = true;
            this.bookTitleLabel.Location = new System.Drawing.Point(31, 57);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(30, 13);
            this.bookTitleLabel.TabIndex = 5;
            this.bookTitleLabel.Text = "Title:";
            // 
            // bookPublisherLabel
            // 
            this.bookPublisherLabel.AutoSize = true;
            this.bookPublisherLabel.Location = new System.Drawing.Point(31, 92);
            this.bookPublisherLabel.Name = "bookPublisherLabel";
            this.bookPublisherLabel.Size = new System.Drawing.Size(53, 13);
            this.bookPublisherLabel.TabIndex = 6;
            this.bookPublisherLabel.Text = "Publisher:";
            // 
            // bookAuthorTextBox
            // 
            this.bookAuthorTextBox.Location = new System.Drawing.Point(127, 229);
            this.bookAuthorTextBox.Name = "bookAuthorTextBox";
            this.bookAuthorTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookAuthorTextBox.TabIndex = 7;
            this.bookAuthorTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.bookAuthorText_Validating);
            this.bookAuthorTextBox.Validated += new System.EventHandler(this.bookAuthorText_Validated);
            // 
            // bookCopyrightLabel
            // 
            this.bookCopyrightLabel.AutoSize = true;
            this.bookCopyrightLabel.Location = new System.Drawing.Point(31, 127);
            this.bookCopyrightLabel.Name = "bookCopyrightLabel";
            this.bookCopyrightLabel.Size = new System.Drawing.Size(54, 13);
            this.bookCopyrightLabel.TabIndex = 8;
            this.bookCopyrightLabel.Text = "Copyright:";
            // 
            // bookLoanPeriodLabel
            // 
            this.bookLoanPeriodLabel.AutoSize = true;
            this.bookLoanPeriodLabel.Location = new System.Drawing.Point(31, 165);
            this.bookLoanPeriodLabel.Name = "bookLoanPeriodLabel";
            this.bookLoanPeriodLabel.Size = new System.Drawing.Size(67, 13);
            this.bookLoanPeriodLabel.TabIndex = 9;
            this.bookLoanPeriodLabel.Text = "Loan Period:";
            // 
            // bookCallNumberLabel
            // 
            this.bookCallNumberLabel.AutoSize = true;
            this.bookCallNumberLabel.Location = new System.Drawing.Point(31, 201);
            this.bookCallNumberLabel.Name = "bookCallNumberLabel";
            this.bookCallNumberLabel.Size = new System.Drawing.Size(67, 13);
            this.bookCallNumberLabel.TabIndex = 10;
            this.bookCallNumberLabel.Text = "Call Number:";
            // 
            // bookAuthorLabel
            // 
            this.bookAuthorLabel.AutoSize = true;
            this.bookAuthorLabel.Location = new System.Drawing.Point(31, 236);
            this.bookAuthorLabel.Name = "bookAuthorLabel";
            this.bookAuthorLabel.Size = new System.Drawing.Size(41, 13);
            this.bookAuthorLabel.TabIndex = 11;
            this.bookAuthorLabel.Text = "Author:";
            // 
            // bookOkButton
            // 
            this.bookOkButton.Location = new System.Drawing.Point(58, 270);
            this.bookOkButton.Name = "bookOkButton";
            this.bookOkButton.Size = new System.Drawing.Size(90, 35);
            this.bookOkButton.TabIndex = 12;
            this.bookOkButton.Text = "Add Book";
            this.bookOkButton.UseVisualStyleBackColor = true;
            this.bookOkButton.Click += new System.EventHandler(this.bookOkButton_Click);
            // 
            // bookCancelButton
            // 
            this.bookCancelButton.Location = new System.Drawing.Point(175, 270);
            this.bookCancelButton.Name = "bookCancelButton";
            this.bookCancelButton.Size = new System.Drawing.Size(90, 35);
            this.bookCancelButton.TabIndex = 13;
            this.bookCancelButton.Text = "Cancel";
            this.bookCancelButton.UseVisualStyleBackColor = true;
            this.bookCancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bookCancelButton_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // NewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 334);
            this.Controls.Add(this.bookCancelButton);
            this.Controls.Add(this.bookOkButton);
            this.Controls.Add(this.bookAuthorLabel);
            this.Controls.Add(this.bookCallNumberLabel);
            this.Controls.Add(this.bookLoanPeriodLabel);
            this.Controls.Add(this.bookCopyrightLabel);
            this.Controls.Add(this.bookAuthorTextBox);
            this.Controls.Add(this.bookPublisherLabel);
            this.Controls.Add(this.bookTitleLabel);
            this.Controls.Add(this.bookCallNumberTextBox);
            this.Controls.Add(this.bookLoanPeriodTextBox);
            this.Controls.Add(this.bookCopyrightTextBox);
            this.Controls.Add(this.bookPublisherTextBox);
            this.Controls.Add(this.bookTitleTextBox);
            this.Name = "NewBook";
            this.Text = "Book";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bookTitleTextBox;
        private System.Windows.Forms.TextBox bookPublisherTextBox;
        private System.Windows.Forms.TextBox bookCopyrightTextBox;
        private System.Windows.Forms.TextBox bookLoanPeriodTextBox;
        private System.Windows.Forms.TextBox bookCallNumberTextBox;
        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.Label bookPublisherLabel;
        private System.Windows.Forms.TextBox bookAuthorTextBox;
        private System.Windows.Forms.Label bookCopyrightLabel;
        private System.Windows.Forms.Label bookLoanPeriodLabel;
        private System.Windows.Forms.Label bookCallNumberLabel;
        private System.Windows.Forms.Label bookAuthorLabel;
        private System.Windows.Forms.Button bookOkButton;
        private System.Windows.Forms.Button bookCancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}