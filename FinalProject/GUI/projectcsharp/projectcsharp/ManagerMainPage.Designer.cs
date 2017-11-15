namespace projectcsharp
{
    partial class ManagerMainPage
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
            this.btn_removeCustomer = new System.Windows.Forms.Button();
            this.ListViewCustomer = new System.Windows.Forms.ListView();
            this.cid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ln = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phonenum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txb_address = new System.Windows.Forms.TextBox();
            this.txb_phonenum = new System.Windows.Forms.TextBox();
            this.txb_pin = new System.Windows.Forms.TextBox();
            this.txb_ln = new System.Windows.Forms.TextBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.txb_fn = new System.Windows.Forms.TextBox();
            this.txb_cid = new System.Windows.Forms.TextBox();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_phoneNum = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_pin = new System.Windows.Forms.Label();
            this.lb_ln = new System.Windows.Forms.Label();
            this.lb_fn = new System.Windows.Forms.Label();
            this.lb_cid = new System.Windows.Forms.Label();
            this.btn_AddAccount = new System.Windows.Forms.Button();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_removeCustomer
            // 
            this.btn_removeCustomer.Location = new System.Drawing.Point(579, 73);
            this.btn_removeCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_removeCustomer.Name = "btn_removeCustomer";
            this.btn_removeCustomer.Size = new System.Drawing.Size(98, 50);
            this.btn_removeCustomer.TabIndex = 34;
            this.btn_removeCustomer.Text = "Remove Customer";
            this.btn_removeCustomer.UseVisualStyleBackColor = true;
            // 
            // ListViewCustomer
            // 
            this.ListViewCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cid,
            this.pin,
            this.fn,
            this.ln,
            this.email,
            this.phonenum,
            this.address});
            this.ListViewCustomer.GridLines = true;
            this.ListViewCustomer.Location = new System.Drawing.Point(18, 196);
            this.ListViewCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.ListViewCustomer.Name = "ListViewCustomer";
            this.ListViewCustomer.Size = new System.Drawing.Size(653, 208);
            this.ListViewCustomer.TabIndex = 33;
            this.ListViewCustomer.UseCompatibleStateImageBehavior = false;
            this.ListViewCustomer.View = System.Windows.Forms.View.Details;
            // 
            // cid
            // 
            this.cid.Text = "Customer ID";
            // 
            // pin
            // 
            this.pin.Text = "PIN";
            // 
            // fn
            // 
            this.fn.Text = "First Name";
            // 
            // ln
            // 
            this.ln.Text = "Last Name";
            // 
            // email
            // 
            this.email.Text = "Email";
            // 
            // phonenum
            // 
            this.phonenum.Text = "Phone Number";
            // 
            // address
            // 
            this.address.Text = "Address";
            this.address.Width = 237;
            // 
            // txb_address
            // 
            this.txb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_address.Location = new System.Drawing.Point(120, 150);
            this.txb_address.Margin = new System.Windows.Forms.Padding(2);
            this.txb_address.Multiline = true;
            this.txb_address.Name = "txb_address";
            this.txb_address.Size = new System.Drawing.Size(437, 25);
            this.txb_address.TabIndex = 32;
            // 
            // txb_phonenum
            // 
            this.txb_phonenum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_phonenum.Location = new System.Drawing.Point(419, 99);
            this.txb_phonenum.Margin = new System.Windows.Forms.Padding(2);
            this.txb_phonenum.Multiline = true;
            this.txb_phonenum.Name = "txb_phonenum";
            this.txb_phonenum.Size = new System.Drawing.Size(138, 25);
            this.txb_phonenum.TabIndex = 31;
            // 
            // txb_pin
            // 
            this.txb_pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_pin.Location = new System.Drawing.Point(419, 19);
            this.txb_pin.Margin = new System.Windows.Forms.Padding(2);
            this.txb_pin.Multiline = true;
            this.txb_pin.Name = "txb_pin";
            this.txb_pin.Size = new System.Drawing.Size(138, 25);
            this.txb_pin.TabIndex = 30;
            // 
            // txb_ln
            // 
            this.txb_ln.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_ln.Location = new System.Drawing.Point(419, 55);
            this.txb_ln.Margin = new System.Windows.Forms.Padding(2);
            this.txb_ln.Multiline = true;
            this.txb_ln.Name = "txb_ln";
            this.txb_ln.Size = new System.Drawing.Size(138, 25);
            this.txb_ln.TabIndex = 29;
            // 
            // txb_email
            // 
            this.txb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_email.Location = new System.Drawing.Point(120, 104);
            this.txb_email.Margin = new System.Windows.Forms.Padding(2);
            this.txb_email.Multiline = true;
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(138, 25);
            this.txb_email.TabIndex = 28;
            // 
            // txb_fn
            // 
            this.txb_fn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_fn.Location = new System.Drawing.Point(120, 57);
            this.txb_fn.Margin = new System.Windows.Forms.Padding(2);
            this.txb_fn.Multiline = true;
            this.txb_fn.Name = "txb_fn";
            this.txb_fn.Size = new System.Drawing.Size(138, 25);
            this.txb_fn.TabIndex = 27;
            // 
            // txb_cid
            // 
            this.txb_cid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_cid.Location = new System.Drawing.Point(120, 19);
            this.txb_cid.Margin = new System.Windows.Forms.Padding(2);
            this.txb_cid.Multiline = true;
            this.txb_cid.Name = "txb_cid";
            this.txb_cid.Size = new System.Drawing.Size(138, 25);
            this.txb_cid.TabIndex = 26;
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_address.Location = new System.Drawing.Point(15, 152);
            this.lb_address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(68, 20);
            this.lb_address.TabIndex = 25;
            this.lb_address.Text = "Address";
            // 
            // lb_phoneNum
            // 
            this.lb_phoneNum.AutoSize = true;
            this.lb_phoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_phoneNum.Location = new System.Drawing.Point(292, 104);
            this.lb_phoneNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_phoneNum.Name = "lb_phoneNum";
            this.lb_phoneNum.Size = new System.Drawing.Size(115, 20);
            this.lb_phoneNum.TabIndex = 24;
            this.lb_phoneNum.Text = "Phone Number";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_email.Location = new System.Drawing.Point(15, 104);
            this.lb_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(48, 20);
            this.lb_email.TabIndex = 23;
            this.lb_email.Text = "Email";
            // 
            // lb_pin
            // 
            this.lb_pin.AutoSize = true;
            this.lb_pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_pin.Location = new System.Drawing.Point(302, 21);
            this.lb_pin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_pin.Name = "lb_pin";
            this.lb_pin.Size = new System.Drawing.Size(35, 20);
            this.lb_pin.TabIndex = 22;
            this.lb_pin.Text = "PIN";
            // 
            // lb_ln
            // 
            this.lb_ln.AutoSize = true;
            this.lb_ln.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_ln.Location = new System.Drawing.Point(292, 60);
            this.lb_ln.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ln.Name = "lb_ln";
            this.lb_ln.Size = new System.Drawing.Size(86, 20);
            this.lb_ln.TabIndex = 21;
            this.lb_ln.Text = "Last Name";
            // 
            // lb_fn
            // 
            this.lb_fn.AutoSize = true;
            this.lb_fn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_fn.Location = new System.Drawing.Point(15, 62);
            this.lb_fn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_fn.Name = "lb_fn";
            this.lb_fn.Size = new System.Drawing.Size(86, 20);
            this.lb_fn.TabIndex = 20;
            this.lb_fn.Text = "First Name";
            // 
            // lb_cid
            // 
            this.lb_cid.AutoSize = true;
            this.lb_cid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_cid.Location = new System.Drawing.Point(8, 19);
            this.lb_cid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_cid.Name = "lb_cid";
            this.lb_cid.Size = new System.Drawing.Size(99, 20);
            this.lb_cid.TabIndex = 19;
            this.lb_cid.Text = "Customer ID";
            // 
            // btn_AddAccount
            // 
            this.btn_AddAccount.Location = new System.Drawing.Point(579, 143);
            this.btn_AddAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddAccount.Name = "btn_AddAccount";
            this.btn_AddAccount.Size = new System.Drawing.Size(98, 41);
            this.btn_AddAccount.TabIndex = 18;
            this.btn_AddAccount.Text = "Add Account";
            this.btn_AddAccount.UseVisualStyleBackColor = true;
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.Location = new System.Drawing.Point(579, 17);
            this.btn_AddCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(98, 44);
            this.btn_AddCustomer.TabIndex = 17;
            this.btn_AddCustomer.Text = "Add Customer";
            this.btn_AddCustomer.UseVisualStyleBackColor = true;
            // 
            // ManagerMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 420);
            this.Controls.Add(this.btn_removeCustomer);
            this.Controls.Add(this.ListViewCustomer);
            this.Controls.Add(this.txb_address);
            this.Controls.Add(this.txb_phonenum);
            this.Controls.Add(this.txb_pin);
            this.Controls.Add(this.txb_ln);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.txb_fn);
            this.Controls.Add(this.txb_cid);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.lb_phoneNum);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_pin);
            this.Controls.Add(this.lb_ln);
            this.Controls.Add(this.lb_fn);
            this.Controls.Add(this.lb_cid);
            this.Controls.Add(this.btn_AddAccount);
            this.Controls.Add(this.btn_AddCustomer);
            this.Name = "ManagerMainPage";
            this.Text = "ManagerMainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_removeCustomer;
        private System.Windows.Forms.ListView ListViewCustomer;
        private System.Windows.Forms.ColumnHeader cid;
        private System.Windows.Forms.ColumnHeader pin;
        private System.Windows.Forms.ColumnHeader fn;
        private System.Windows.Forms.ColumnHeader ln;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader phonenum;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.TextBox txb_address;
        private System.Windows.Forms.TextBox txb_phonenum;
        private System.Windows.Forms.TextBox txb_pin;
        private System.Windows.Forms.TextBox txb_ln;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.TextBox txb_fn;
        private System.Windows.Forms.TextBox txb_cid;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_phoneNum;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_pin;
        private System.Windows.Forms.Label lb_ln;
        private System.Windows.Forms.Label lb_fn;
        private System.Windows.Forms.Label lb_cid;
        private System.Windows.Forms.Button btn_AddAccount;
        private System.Windows.Forms.Button btn_AddCustomer;
    }
}