namespace projectcsharp
{
    partial class FormLogIn
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
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.labelUserID = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelLogIn = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(136, 65);
            this.textBoxUserID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(148, 26);
            this.textBoxUserID.TabIndex = 0;
            // 
            // labelUserID
            // 
            this.labelUserID.Location = new System.Drawing.Point(42, 69);
            this.labelUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(86, 32);
            this.labelUserID.TabIndex = 0;
            this.labelUserID.Text = "User ID";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(136, 112);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(148, 26);
            this.textBoxPassword.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.Location = new System.Drawing.Point(42, 117);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(86, 31);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // buttonExit
            // 
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(174, 166);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 35);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelLogIn
            // 
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogIn.Location = new System.Drawing.Point(18, 14);
            this.labelLogIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(66, 25);
            this.labelLogIn.TabIndex = 4;
            this.labelLogIn.Text = "Log In";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.ForeColor = System.Drawing.Color.Black;
            this.buttonLogIn.Location = new System.Drawing.Point(52, 166);
            this.buttonLogIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(112, 35);
            this.buttonLogIn.TabIndex = 2;
            this.buttonLogIn.Text = "Log in";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 231);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.labelLogIn);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.textBoxUserID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormLogIn";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.FormLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelLogIn;
        private System.Windows.Forms.Button buttonLogIn;

    }
}