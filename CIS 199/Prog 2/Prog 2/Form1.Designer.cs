namespace Prog_2
{
    partial class Prog2
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
            this.lastnametextBox = new System.Windows.Forms.TextBox();
            this.lastnamelabel = new System.Windows.Forms.Label();
            this.seniorradioButton = new System.Windows.Forms.RadioButton();
            this.juniorradioButton = new System.Windows.Forms.RadioButton();
            this.sophomoreradioButton = new System.Windows.Forms.RadioButton();
            this.freshmanradioButton = new System.Windows.Forms.RadioButton();
            this.submitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastnametextBox
            // 
            this.lastnametextBox.Location = new System.Drawing.Point(67, 63);
            this.lastnametextBox.Name = "lastnametextBox";
            this.lastnametextBox.Size = new System.Drawing.Size(100, 20);
            this.lastnametextBox.TabIndex = 0;
            // 
            // lastnamelabel
            // 
            this.lastnamelabel.AutoSize = true;
            this.lastnamelabel.Location = new System.Drawing.Point(2, 66);
            this.lastnamelabel.Name = "lastnamelabel";
            this.lastnamelabel.Size = new System.Drawing.Size(59, 13);
            this.lastnamelabel.TabIndex = 1;
            this.lastnamelabel.Text = "Last name:";
            // 
            // seniorradioButton
            // 
            this.seniorradioButton.AutoSize = true;
            this.seniorradioButton.Location = new System.Drawing.Point(220, 89);
            this.seniorradioButton.Name = "seniorradioButton";
            this.seniorradioButton.Size = new System.Drawing.Size(55, 17);
            this.seniorradioButton.TabIndex = 2;
            this.seniorradioButton.Text = "Senior";
            this.seniorradioButton.UseVisualStyleBackColor = true;
            // 
            // juniorradioButton
            // 
            this.juniorradioButton.AutoSize = true;
            this.juniorradioButton.Location = new System.Drawing.Point(220, 66);
            this.juniorradioButton.Name = "juniorradioButton";
            this.juniorradioButton.Size = new System.Drawing.Size(53, 17);
            this.juniorradioButton.TabIndex = 3;
            this.juniorradioButton.TabStop = true;
            this.juniorradioButton.Text = "Junior";
            this.juniorradioButton.UseVisualStyleBackColor = true;
            // 
            // sophomoreradioButton
            // 
            this.sophomoreradioButton.AutoSize = true;
            this.sophomoreradioButton.Location = new System.Drawing.Point(220, 43);
            this.sophomoreradioButton.Name = "sophomoreradioButton";
            this.sophomoreradioButton.Size = new System.Drawing.Size(79, 17);
            this.sophomoreradioButton.TabIndex = 4;
            this.sophomoreradioButton.TabStop = true;
            this.sophomoreradioButton.Text = "Sophomore";
            this.sophomoreradioButton.UseVisualStyleBackColor = true;
            // 
            // freshmanradioButton
            // 
            this.freshmanradioButton.AutoSize = true;
            this.freshmanradioButton.Checked = true;
            this.freshmanradioButton.Location = new System.Drawing.Point(220, 20);
            this.freshmanradioButton.Name = "freshmanradioButton";
            this.freshmanradioButton.Size = new System.Drawing.Size(71, 17);
            this.freshmanradioButton.TabIndex = 5;
            this.freshmanradioButton.TabStop = true;
            this.freshmanradioButton.Text = "Freshman";
            this.freshmanradioButton.UseVisualStyleBackColor = true;
            // 
            // submitbutton
            // 
            this.submitbutton.Location = new System.Drawing.Point(142, 136);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(75, 23);
            this.submitbutton.TabIndex = 6;
            this.submitbutton.Text = "Submit";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // Prog2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 192);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.freshmanradioButton);
            this.Controls.Add(this.sophomoreradioButton);
            this.Controls.Add(this.juniorradioButton);
            this.Controls.Add(this.seniorradioButton);
            this.Controls.Add(this.lastnamelabel);
            this.Controls.Add(this.lastnametextBox);
            this.Name = "Prog2";
            this.Text = "Prog 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastnametextBox;
        private System.Windows.Forms.Label lastnamelabel;
        private System.Windows.Forms.RadioButton seniorradioButton;
        private System.Windows.Forms.RadioButton juniorradioButton;
        private System.Windows.Forms.RadioButton sophomoreradioButton;
        private System.Windows.Forms.RadioButton freshmanradioButton;
        private System.Windows.Forms.Button submitbutton;
    }
}

