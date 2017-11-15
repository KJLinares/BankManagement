namespace projectcsharp
{
    partial class FormAccount
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
            this.labelSelectAccount = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelAmount = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.checkBoxChecking = new System.Windows.Forms.CheckBox();
            this.checkBoxSaving = new System.Windows.Forms.CheckBox();
            this.textBoxAmont = new System.Windows.Forms.TextBox();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSelectAccount
            // 
            this.labelSelectAccount.AutoSize = true;
            this.labelSelectAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectAccount.Location = new System.Drawing.Point(12, 9);
            this.labelSelectAccount.Name = "labelSelectAccount";
            this.labelSelectAccount.Size = new System.Drawing.Size(115, 20);
            this.labelSelectAccount.TabIndex = 0;
            this.labelSelectAccount.Text = "Select account";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(193, 127);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(65, 94);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(43, 13);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Amount";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.checkBoxChecking);
            this.groupBox.Controls.Add(this.checkBoxSaving);
            this.groupBox.Location = new System.Drawing.Point(47, 41);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(189, 35);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBoxChecking
            // 
            this.checkBoxChecking.AutoSize = true;
            this.checkBoxChecking.Location = new System.Drawing.Point(106, 12);
            this.checkBoxChecking.Name = "checkBoxChecking";
            this.checkBoxChecking.Size = new System.Drawing.Size(71, 17);
            this.checkBoxChecking.TabIndex = 1;
            this.checkBoxChecking.Text = "Checking";
            this.checkBoxChecking.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaving
            // 
            this.checkBoxSaving.AutoSize = true;
            this.checkBoxSaving.Location = new System.Drawing.Point(21, 12);
            this.checkBoxSaving.Name = "checkBoxSaving";
            this.checkBoxSaving.Size = new System.Drawing.Size(59, 17);
            this.checkBoxSaving.TabIndex = 0;
            this.checkBoxSaving.Text = "Saving";
            this.checkBoxSaving.UseVisualStyleBackColor = true;
            // 
            // textBoxAmont
            // 
            this.textBoxAmont.Location = new System.Drawing.Point(111, 91);
            this.textBoxAmont.Name = "textBoxAmont";
            this.textBoxAmont.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmont.TabIndex = 4;
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Location = new System.Drawing.Point(103, 127);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(75, 23);
            this.buttonWithdraw.TabIndex = 15;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(13, 127);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(75, 23);
            this.buttonDeposit.TabIndex = 14;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 162);
            this.Controls.Add(this.buttonWithdraw);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.textBoxAmont);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelSelectAccount);
            this.Name = "FormAccount";
            this.Text = "Account";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectAccount;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox textBoxAmont;
        private System.Windows.Forms.CheckBox checkBoxChecking;
        private System.Windows.Forms.CheckBox checkBoxSaving;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Button buttonDeposit;
    }
}