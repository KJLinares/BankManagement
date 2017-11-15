namespace projectcsharp
{
    partial class ManagerAccountCustomer
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
            this.btn_CustomerInfo = new System.Windows.Forms.Button();
            this.btn_AccountInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CustomerInfo
            // 
            this.btn_CustomerInfo.Location = new System.Drawing.Point(16, 17);
            this.btn_CustomerInfo.Name = "btn_CustomerInfo";
            this.btn_CustomerInfo.Size = new System.Drawing.Size(174, 57);
            this.btn_CustomerInfo.TabIndex = 35;
            this.btn_CustomerInfo.Text = "Customer Info";
            this.btn_CustomerInfo.UseVisualStyleBackColor = true;
            this.btn_CustomerInfo.Click += new System.EventHandler(this.btn_CustomerInfo_Click);
            // 
            // btn_AccountInfo
            // 
            this.btn_AccountInfo.Location = new System.Drawing.Point(196, 17);
            this.btn_AccountInfo.Name = "btn_AccountInfo";
            this.btn_AccountInfo.Size = new System.Drawing.Size(174, 57);
            this.btn_AccountInfo.TabIndex = 36;
            this.btn_AccountInfo.Text = "Account Info";
            this.btn_AccountInfo.UseVisualStyleBackColor = true;
            this.btn_AccountInfo.Click += new System.EventHandler(this.btn_AccountInfo_Click);
            // 
            // ManagerAccountCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 89);
            this.Controls.Add(this.btn_AccountInfo);
            this.Controls.Add(this.btn_CustomerInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ManagerAccountCustomer";
            this.Text = "ManagerAccountCustomer";
            this.Load += new System.EventHandler(this.ManagerAccountCustomer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CustomerInfo;
        private System.Windows.Forms.Button btn_AccountInfo;

    }
}