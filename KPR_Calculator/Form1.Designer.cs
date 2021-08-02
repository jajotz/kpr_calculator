namespace KPR_Calculator
{
    partial class Form1
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
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numInterestRate = new System.Windows.Forms.NumericUpDown();
            this.numFixedInterestTerm = new System.Windows.Forms.NumericUpDown();
            this.numLoanTermYear = new System.Windows.Forms.NumericUpDown();
            this.numLoanTermMonths = new System.Windows.Forms.NumericUpDown();
            this.numExtraPaymentPerMonth = new System.Windows.Forms.NumericUpDown();
            this.numMortgageConstant = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupCalculated = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMonthlyPayment = new System.Windows.Forms.TextBox();
            this.txtTotalPayment = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalInterest = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAnnualPayment = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMortgageConstant = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numLoanAmount = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedInterestTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoanTermYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoanTermMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtraPaymentPerMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMortgageConstant)).BeginInit();
            this.groupCalculated.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLoanAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(21, 50);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(226, 20);
            this.txtBankName.TabIndex = 0;
            this.txtBankName.TextChanged += new System.EventHandler(this.txtBankName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interest Rate (%per year)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loan Term";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Extra Payment Per Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fixed interest Term (year)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "years";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "months";
            // 
            // numInterestRate
            // 
            this.numInterestRate.DecimalPlaces = 2;
            this.numInterestRate.Location = new System.Drawing.Point(21, 136);
            this.numInterestRate.Name = "numInterestRate";
            this.numInterestRate.Size = new System.Drawing.Size(76, 20);
            this.numInterestRate.TabIndex = 8;
            this.numInterestRate.Value = new decimal(new int[] {
            612,
            0,
            0,
            131072});
            this.numInterestRate.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // numFixedInterestTerm
            // 
            this.numFixedInterestTerm.Location = new System.Drawing.Point(162, 135);
            this.numFixedInterestTerm.Name = "numFixedInterestTerm";
            this.numFixedInterestTerm.Size = new System.Drawing.Size(63, 20);
            this.numFixedInterestTerm.TabIndex = 9;
            this.numFixedInterestTerm.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numFixedInterestTerm.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // numLoanTermYear
            // 
            this.numLoanTermYear.Location = new System.Drawing.Point(21, 177);
            this.numLoanTermYear.Name = "numLoanTermYear";
            this.numLoanTermYear.Size = new System.Drawing.Size(55, 20);
            this.numLoanTermYear.TabIndex = 10;
            this.numLoanTermYear.ThousandsSeparator = true;
            this.numLoanTermYear.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numLoanTermYear.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // numLoanTermMonths
            // 
            this.numLoanTermMonths.Location = new System.Drawing.Point(162, 177);
            this.numLoanTermMonths.Name = "numLoanTermMonths";
            this.numLoanTermMonths.Size = new System.Drawing.Size(55, 20);
            this.numLoanTermMonths.TabIndex = 11;
            this.numLoanTermMonths.ThousandsSeparator = true;
            this.numLoanTermMonths.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // numExtraPaymentPerMonth
            // 
            this.numExtraPaymentPerMonth.Increment = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numExtraPaymentPerMonth.Location = new System.Drawing.Point(21, 232);
            this.numExtraPaymentPerMonth.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numExtraPaymentPerMonth.Name = "numExtraPaymentPerMonth";
            this.numExtraPaymentPerMonth.Size = new System.Drawing.Size(150, 20);
            this.numExtraPaymentPerMonth.TabIndex = 12;
            this.numExtraPaymentPerMonth.ThousandsSeparator = true;
            this.numExtraPaymentPerMonth.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // numMortgageConstant
            // 
            this.numMortgageConstant.DecimalPlaces = 2;
            this.numMortgageConstant.Location = new System.Drawing.Point(162, 91);
            this.numMortgageConstant.Name = "numMortgageConstant";
            this.numMortgageConstant.Size = new System.Drawing.Size(63, 20);
            this.numMortgageConstant.TabIndex = 14;
            this.numMortgageConstant.Value = new decimal(new int[] {
            1251,
            0,
            0,
            131072});
            this.numMortgageConstant.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mortgage Constant (%)";
            // 
            // groupCalculated
            // 
            this.groupCalculated.Controls.Add(this.txtMortgageConstant);
            this.groupCalculated.Controls.Add(this.label13);
            this.groupCalculated.Controls.Add(this.txtAnnualPayment);
            this.groupCalculated.Controls.Add(this.label12);
            this.groupCalculated.Controls.Add(this.txtTotalInterest);
            this.groupCalculated.Controls.Add(this.label11);
            this.groupCalculated.Controls.Add(this.txtTotalPayment);
            this.groupCalculated.Controls.Add(this.label10);
            this.groupCalculated.Controls.Add(this.txtMonthlyPayment);
            this.groupCalculated.Controls.Add(this.label9);
            this.groupCalculated.Location = new System.Drawing.Point(353, 23);
            this.groupCalculated.Name = "groupCalculated";
            this.groupCalculated.Size = new System.Drawing.Size(270, 262);
            this.groupCalculated.TabIndex = 15;
            this.groupCalculated.TabStop = false;
            this.groupCalculated.Text = "Calculated";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Monthly Payment";
            // 
            // txtMonthlyPayment
            // 
            this.txtMonthlyPayment.Location = new System.Drawing.Point(19, 48);
            this.txtMonthlyPayment.Name = "txtMonthlyPayment";
            this.txtMonthlyPayment.ReadOnly = true;
            this.txtMonthlyPayment.Size = new System.Drawing.Size(226, 20);
            this.txtMonthlyPayment.TabIndex = 16;
            this.txtMonthlyPayment.TabStop = false;
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Location = new System.Drawing.Point(19, 87);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.ReadOnly = true;
            this.txtTotalPayment.Size = new System.Drawing.Size(226, 20);
            this.txtTotalPayment.TabIndex = 18;
            this.txtTotalPayment.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Total Payment";
            // 
            // txtTotalInterest
            // 
            this.txtTotalInterest.Location = new System.Drawing.Point(19, 130);
            this.txtTotalInterest.Name = "txtTotalInterest";
            this.txtTotalInterest.ReadOnly = true;
            this.txtTotalInterest.Size = new System.Drawing.Size(226, 20);
            this.txtTotalInterest.TabIndex = 20;
            this.txtTotalInterest.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Total Interest";
            // 
            // txtAnnualPayment
            // 
            this.txtAnnualPayment.Location = new System.Drawing.Point(19, 169);
            this.txtAnnualPayment.Name = "txtAnnualPayment";
            this.txtAnnualPayment.ReadOnly = true;
            this.txtAnnualPayment.Size = new System.Drawing.Size(226, 20);
            this.txtAnnualPayment.TabIndex = 22;
            this.txtAnnualPayment.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Annual Payment";
            // 
            // txtMortgageConstant
            // 
            this.txtMortgageConstant.Location = new System.Drawing.Point(19, 208);
            this.txtMortgageConstant.Name = "txtMortgageConstant";
            this.txtMortgageConstant.ReadOnly = true;
            this.txtMortgageConstant.Size = new System.Drawing.Size(226, 20);
            this.txtMortgageConstant.TabIndex = 24;
            this.txtMortgageConstant.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Mortgage Constant";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(29, 313);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 38);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numLoanAmount);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBankName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numMortgageConstant);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numExtraPaymentPerMonth);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numLoanTermMonths);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numLoanTermYear);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.numFixedInterestTerm);
            this.groupBox2.Controls.Add(this.numInterestRate);
            this.groupBox2.Location = new System.Drawing.Point(26, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 266);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INPUT";
            // 
            // numLoanAmount
            // 
            this.numLoanAmount.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numLoanAmount.Location = new System.Drawing.Point(21, 92);
            this.numLoanAmount.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numLoanAmount.Name = "numLoanAmount";
            this.numLoanAmount.Size = new System.Drawing.Size(135, 20);
            this.numLoanAmount.TabIndex = 13;
            this.numLoanAmount.ThousandsSeparator = true;
            this.numLoanAmount.Value = new decimal(new int[] {
            850000000,
            0,
            0,
            0});
            this.numLoanAmount.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "LoanAmount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 378);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupCalculated);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedInterestTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoanTermYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoanTermMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtraPaymentPerMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMortgageConstant)).EndInit();
            this.groupCalculated.ResumeLayout(false);
            this.groupCalculated.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLoanAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numInterestRate;
        private System.Windows.Forms.NumericUpDown numFixedInterestTerm;
        private System.Windows.Forms.NumericUpDown numLoanTermYear;
        private System.Windows.Forms.NumericUpDown numLoanTermMonths;
        private System.Windows.Forms.NumericUpDown numExtraPaymentPerMonth;
        private System.Windows.Forms.NumericUpDown numMortgageConstant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupCalculated;
        private System.Windows.Forms.TextBox txtMortgageConstant;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAnnualPayment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotalInterest;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalPayment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMonthlyPayment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numLoanAmount;
        private System.Windows.Forms.Label label14;
    }
}

