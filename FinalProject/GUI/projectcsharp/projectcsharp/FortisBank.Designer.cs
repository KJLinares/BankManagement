namespace projectcsharp
{
    partial class FromFortisInternationalBank
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
            this.buttonManager = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonManager
            // 
            this.buttonManager.Image = global::projectcsharp.Properties.Resources.mag1;
            this.buttonManager.Location = new System.Drawing.Point(138, 12);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(93, 171);
            this.buttonManager.TabIndex = 1;
            this.buttonManager.UseVisualStyleBackColor = true;
            this.buttonManager.Click += new System.EventHandler(this.buttonManager_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Image = global::projectcsharp.Properties.Resources.cus2;
            this.buttonCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomer.Location = new System.Drawing.Point(28, 12);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(93, 171);
            this.buttonCustomer.TabIndex = 0;
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manager";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FromFortisInternationalBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 207);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonManager);
            this.Controls.Add(this.buttonCustomer);
            this.Name = "FromFortisInternationalBank";
            this.Text = "Fortis International Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Button buttonManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

