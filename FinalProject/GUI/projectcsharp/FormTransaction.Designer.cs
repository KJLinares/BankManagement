namespace projectcsharp
{
    partial class FormTransaction
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
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.textBoxAmont = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.checkBoxCredit = new System.Windows.Forms.CheckBox();
            this.checkBoxChecking = new System.Windows.Forms.CheckBox();
            this.checkBoxSaving = new System.Windows.Forms.CheckBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelSelectAccount = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Location = new System.Drawing.Point(152, 200);
            this.buttonWithdraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(112, 35);
            this.buttonWithdraw.TabIndex = 5;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(16, 200);
            this.buttonDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(112, 35);
            this.buttonDeposit.TabIndex = 4;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // textBoxAmont
            // 
            this.textBoxAmont.Location = new System.Drawing.Point(164, 145);
            this.textBoxAmont.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAmont.Name = "textBoxAmont";
            this.textBoxAmont.Size = new System.Drawing.Size(148, 26);
            this.textBoxAmont.TabIndex = 3;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(94, 149);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(65, 20);
            this.labelAmount.TabIndex = 18;
            this.labelAmount.Text = "Amount";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.checkBoxCredit);
            this.groupBox.Controls.Add(this.checkBoxChecking);
            this.groupBox.Controls.Add(this.checkBoxSaving);
            this.groupBox.Location = new System.Drawing.Point(21, 68);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox.Size = new System.Drawing.Size(390, 54);
            this.groupBox.TabIndex = 19;
            this.groupBox.TabStop = false;
            // 
            // checkBoxCredit
            // 
            this.checkBoxCredit.AutoSize = true;
            this.checkBoxCredit.Location = new System.Drawing.Point(274, 18);
            this.checkBoxCredit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxCredit.Name = "checkBoxCredit";
            this.checkBoxCredit.Size = new System.Drawing.Size(77, 24);
            this.checkBoxCredit.TabIndex = 2;
            this.checkBoxCredit.Text = "Credit";
            this.checkBoxCredit.UseVisualStyleBackColor = true;
            this.checkBoxCredit.CheckedChanged += new System.EventHandler(this.checkBoxCredit_CheckedChanged);
            // 
            // checkBoxChecking
            // 
            this.checkBoxChecking.AutoSize = true;
            this.checkBoxChecking.Location = new System.Drawing.Point(32, 18);
            this.checkBoxChecking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxChecking.Name = "checkBoxChecking";
            this.checkBoxChecking.Size = new System.Drawing.Size(101, 24);
            this.checkBoxChecking.TabIndex = 0;
            this.checkBoxChecking.Text = "Checking";
            this.checkBoxChecking.UseVisualStyleBackColor = true;
            this.checkBoxChecking.CheckedChanged += new System.EventHandler(this.checkBoxChecking_CheckedChanged);
            // 
            // checkBoxSaving
            // 
            this.checkBoxSaving.AutoSize = true;
            this.checkBoxSaving.Location = new System.Drawing.Point(154, 18);
            this.checkBoxSaving.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxSaving.Name = "checkBoxSaving";
            this.checkBoxSaving.Size = new System.Drawing.Size(83, 24);
            this.checkBoxSaving.TabIndex = 1;
            this.checkBoxSaving.Text = "Saving";
            this.checkBoxSaving.UseVisualStyleBackColor = true;
            this.checkBoxSaving.CheckedChanged += new System.EventHandler(this.checkBoxSaving_CheckedChanged_1);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(286, 200);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 35);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelSelectAccount
            // 
            this.labelSelectAccount.AutoSize = true;
            this.labelSelectAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectAccount.Location = new System.Drawing.Point(15, 18);
            this.labelSelectAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectAccount.Name = "labelSelectAccount";
            this.labelSelectAccount.Size = new System.Drawing.Size(170, 29);
            this.labelSelectAccount.TabIndex = 16;
            this.labelSelectAccount.Text = "Select account";
            // 
            // FormTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 266);
            this.Controls.Add(this.buttonWithdraw);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.textBoxAmont);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelSelectAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormTransaction";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.TextBox textBoxAmont;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.CheckBox checkBoxChecking;
        private System.Windows.Forms.CheckBox checkBoxSaving;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelSelectAccount;
        private System.Windows.Forms.CheckBox checkBoxCredit;
    }
}