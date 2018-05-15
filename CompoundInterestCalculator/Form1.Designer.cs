namespace CompoundInterestCalculator
{
    partial class compoundInterestCalculatorForm
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
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.principalTxtBox = new System.Windows.Forms.TextBox();
            this.interestRateTxtBox = new System.Windows.Forms.TextBox();
            this.compoundingsPerYearTxtBox = new System.Windows.Forms.TextBox();
            this.principalLbl = new System.Windows.Forms.Label();
            this.interestRateLbl = new System.Windows.Forms.Label();
            this.compoundingsPerYearLbl = new System.Windows.Forms.Label();
            this.amountLbl = new System.Windows.Forms.Label();
            this.numberOfYearsLbl = new System.Windows.Forms.Label();
            this.numberOfYearsTxtBox = new System.Windows.Forms.TextBox();
            this.amountValueLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(63, 9);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(146, 13);
            this.descriptionLbl.TabIndex = 0;
            this.descriptionLbl.Text = "Compound Interest Calculator";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(173, 139);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "Calculate";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // principalTxtBox
            // 
            this.principalTxtBox.Location = new System.Drawing.Point(148, 36);
            this.principalTxtBox.Name = "principalTxtBox";
            this.principalTxtBox.Size = new System.Drawing.Size(100, 20);
            this.principalTxtBox.TabIndex = 2;
            // 
            // interestRateTxtBox
            // 
            this.interestRateTxtBox.Location = new System.Drawing.Point(148, 62);
            this.interestRateTxtBox.Name = "interestRateTxtBox";
            this.interestRateTxtBox.Size = new System.Drawing.Size(100, 20);
            this.interestRateTxtBox.TabIndex = 3;
            // 
            // compoundingsPerYearTxtBox
            // 
            this.compoundingsPerYearTxtBox.Location = new System.Drawing.Point(148, 88);
            this.compoundingsPerYearTxtBox.Name = "compoundingsPerYearTxtBox";
            this.compoundingsPerYearTxtBox.Size = new System.Drawing.Size(100, 20);
            this.compoundingsPerYearTxtBox.TabIndex = 4;
            // 
            // principalLbl
            // 
            this.principalLbl.AutoSize = true;
            this.principalLbl.Location = new System.Drawing.Point(21, 39);
            this.principalLbl.Name = "principalLbl";
            this.principalLbl.Size = new System.Drawing.Size(47, 13);
            this.principalLbl.TabIndex = 5;
            this.principalLbl.Text = "Principal";
            // 
            // interestRateLbl
            // 
            this.interestRateLbl.AutoSize = true;
            this.interestRateLbl.Location = new System.Drawing.Point(21, 65);
            this.interestRateLbl.Name = "interestRateLbl";
            this.interestRateLbl.Size = new System.Drawing.Size(68, 13);
            this.interestRateLbl.TabIndex = 6;
            this.interestRateLbl.Text = "Interest Rate";
            // 
            // compoundingsPerYearLbl
            // 
            this.compoundingsPerYearLbl.AutoSize = true;
            this.compoundingsPerYearLbl.Location = new System.Drawing.Point(21, 91);
            this.compoundingsPerYearLbl.Name = "compoundingsPerYearLbl";
            this.compoundingsPerYearLbl.Size = new System.Drawing.Size(121, 13);
            this.compoundingsPerYearLbl.TabIndex = 7;
            this.compoundingsPerYearLbl.Text = "Compoundings Per Year";
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Location = new System.Drawing.Point(24, 188);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(0, 13);
            this.amountLbl.TabIndex = 8;
            // 
            // numberOfYearsLbl
            // 
            this.numberOfYearsLbl.AutoSize = true;
            this.numberOfYearsLbl.Location = new System.Drawing.Point(24, 120);
            this.numberOfYearsLbl.Name = "numberOfYearsLbl";
            this.numberOfYearsLbl.Size = new System.Drawing.Size(88, 13);
            this.numberOfYearsLbl.TabIndex = 9;
            this.numberOfYearsLbl.Text = "Number Of Years";
            // 
            // numberOfYearsTxtBox
            // 
            this.numberOfYearsTxtBox.Location = new System.Drawing.Point(148, 113);
            this.numberOfYearsTxtBox.Name = "numberOfYearsTxtBox";
            this.numberOfYearsTxtBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfYearsTxtBox.TabIndex = 10;
            // 
            // amountValueLbl
            // 
            this.amountValueLbl.AutoSize = true;
            this.amountValueLbl.Location = new System.Drawing.Point(145, 188);
            this.amountValueLbl.Name = "amountValueLbl";
            this.amountValueLbl.Size = new System.Drawing.Size(0, 13);
            this.amountValueLbl.TabIndex = 11;
            // 
            // compoundInterestCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 255);
            this.Controls.Add(this.amountValueLbl);
            this.Controls.Add(this.numberOfYearsTxtBox);
            this.Controls.Add(this.numberOfYearsLbl);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.compoundingsPerYearLbl);
            this.Controls.Add(this.interestRateLbl);
            this.Controls.Add(this.principalLbl);
            this.Controls.Add(this.compoundingsPerYearTxtBox);
            this.Controls.Add(this.interestRateTxtBox);
            this.Controls.Add(this.principalTxtBox);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.descriptionLbl);
            this.Name = "compoundInterestCalculatorForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox principalTxtBox;
        private System.Windows.Forms.TextBox interestRateTxtBox;
        private System.Windows.Forms.TextBox compoundingsPerYearTxtBox;
        private System.Windows.Forms.Label principalLbl;
        private System.Windows.Forms.Label interestRateLbl;
        private System.Windows.Forms.Label compoundingsPerYearLbl;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.Label numberOfYearsLbl;
        private System.Windows.Forms.TextBox numberOfYearsTxtBox;
        private System.Windows.Forms.Label amountValueLbl;
    }
}

