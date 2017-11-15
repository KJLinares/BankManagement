namespace projectcsharp
{
    partial class FormDepoWithd
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
            this.labelDeposit = new System.Windows.Forms.Label();
            this.labelWithdrawal = new System.Windows.Forms.Label();
            this.buttonWithdrawal = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDeposit
            // 
            this.labelDeposit.AutoSize = true;
            this.labelDeposit.Location = new System.Drawing.Point(97, 205);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Size = new System.Drawing.Size(43, 13);
            this.labelDeposit.TabIndex = 2;
            this.labelDeposit.Text = "Deposit";
            // 
            // labelWithdrawal
            // 
            this.labelWithdrawal.AutoSize = true;
            this.labelWithdrawal.Location = new System.Drawing.Point(298, 206);
            this.labelWithdrawal.Name = "labelWithdrawal";
            this.labelWithdrawal.Size = new System.Drawing.Size(60, 13);
            this.labelWithdrawal.TabIndex = 3;
            this.labelWithdrawal.Text = "Withdrawal";
            // 
            // buttonWithdrawal
            // 
            this.buttonWithdrawal.Image = global::projectcsharp.Properties.Resources.wit;
            this.buttonWithdrawal.Location = new System.Drawing.Point(225, 12);
            this.buttonWithdrawal.Name = "buttonWithdrawal";
            this.buttonWithdrawal.Size = new System.Drawing.Size(201, 191);
            this.buttonWithdrawal.TabIndex = 1;
            this.buttonWithdrawal.UseVisualStyleBackColor = true;
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Image = global::projectcsharp.Properties.Resources.depo;
            this.buttonDeposit.Location = new System.Drawing.Point(12, 12);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(207, 190);
            this.buttonDeposit.TabIndex = 0;
            this.buttonDeposit.UseVisualStyleBackColor = true;
            // 
            // FormDepoWithd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 230);
            this.Controls.Add(this.labelWithdrawal);
            this.Controls.Add(this.labelDeposit);
            this.Controls.Add(this.buttonWithdrawal);
            this.Controls.Add(this.buttonDeposit);
            this.Name = "FormDepoWithd";
            this.Text = "Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonWithdrawal;
        private System.Windows.Forms.Label labelDeposit;
        private System.Windows.Forms.Label labelWithdrawal;
    }
}