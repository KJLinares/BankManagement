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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_deleteAccount = new System.Windows.Forms.Button();
            this.btn_addAccount = new System.Windows.Forms.Button();
            this.btn_listAccounts = new System.Windows.Forms.Button();
            this.txb_CreditLimitedAmount = new System.Windows.Forms.TextBox();
            this.txb_CreditExtraFees = new System.Windows.Forms.TextBox();
            this.lb_CreditExtraFees = new System.Windows.Forms.Label();
            this.lb_CreditLimitedAmount = new System.Windows.Forms.Label();
            this.txb_CreditInterestRate = new System.Windows.Forms.TextBox();
            this.lb_CreditInterestRate = new System.Windows.Forms.Label();
            this.txb_SavingExtraFees = new System.Windows.Forms.TextBox();
            this.lb_SavingExtraFees = new System.Windows.Forms.Label();
            this.txb_CheckingExtraFees = new System.Windows.Forms.TextBox();
            this.lb_CheckingExtraFees = new System.Windows.Forms.Label();
            this.lb_checkingCounterTrans = new System.Windows.Forms.Label();
            this.txb_checkingCounterTrans = new System.Windows.Forms.TextBox();
            this.txb_checkingLimitedTrans = new System.Windows.Forms.TextBox();
            this.lb_checkingLimitedTrans = new System.Windows.Forms.Label();
            this.txb_SavingInterestRate = new System.Windows.Forms.TextBox();
            this.lb_SavingInterestRate = new System.Windows.Forms.Label();
            this.txb_CreditAccountNum = new System.Windows.Forms.TextBox();
            this.lb_CreditAccountNum = new System.Windows.Forms.Label();
            this.txb_SavingAccountNum = new System.Windows.Forms.TextBox();
            this.lb_SavingAccountNum = new System.Windows.Forms.Label();
            this.txb_checkingAccountNUm = new System.Windows.Forms.TextBox();
            this.lb_CheckingAccountNum = new System.Windows.Forms.Label();
            this.chb_credit = new System.Windows.Forms.CheckBox();
            this.chb_saving = new System.Windows.Forms.CheckBox();
            this.chb_checking = new System.Windows.Forms.CheckBox();
            this.txb_balanceid = new System.Windows.Forms.TextBox();
            this.lb_balance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_year = new System.Windows.Forms.TextBox();
            this.txb_day = new System.Windows.Forms.TextBox();
            this.txb_month = new System.Windows.Forms.TextBox();
            this.lb_openDate = new System.Windows.Forms.Label();
            this.txb_cid = new System.Windows.Forms.TextBox();
            this.lb_cid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(41, 314);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(631, 103);
            this.listView1.TabIndex = 91;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btn_deleteAccount
            // 
            this.btn_deleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_deleteAccount.Location = new System.Drawing.Point(485, 268);
            this.btn_deleteAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deleteAccount.Name = "btn_deleteAccount";
            this.btn_deleteAccount.Size = new System.Drawing.Size(138, 26);
            this.btn_deleteAccount.TabIndex = 90;
            this.btn_deleteAccount.Text = "Delete Account";
            this.btn_deleteAccount.UseVisualStyleBackColor = true;
            // 
            // btn_addAccount
            // 
            this.btn_addAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_addAccount.Location = new System.Drawing.Point(263, 268);
            this.btn_addAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addAccount.Name = "btn_addAccount";
            this.btn_addAccount.Size = new System.Drawing.Size(138, 26);
            this.btn_addAccount.TabIndex = 89;
            this.btn_addAccount.Text = "Add Accounts";
            this.btn_addAccount.UseVisualStyleBackColor = true;
            // 
            // btn_listAccounts
            // 
            this.btn_listAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_listAccounts.Location = new System.Drawing.Point(29, 268);
            this.btn_listAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.btn_listAccounts.Name = "btn_listAccounts";
            this.btn_listAccounts.Size = new System.Drawing.Size(138, 26);
            this.btn_listAccounts.TabIndex = 88;
            this.btn_listAccounts.Text = "List All Accounts";
            this.btn_listAccounts.UseVisualStyleBackColor = true;
            // 
            // txb_CreditLimitedAmount
            // 
            this.txb_CreditLimitedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_CreditLimitedAmount.Location = new System.Drawing.Point(597, 189);
            this.txb_CreditLimitedAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txb_CreditLimitedAmount.Multiline = true;
            this.txb_CreditLimitedAmount.Name = "txb_CreditLimitedAmount";
            this.txb_CreditLimitedAmount.Size = new System.Drawing.Size(75, 25);
            this.txb_CreditLimitedAmount.TabIndex = 87;
            // 
            // txb_CreditExtraFees
            // 
            this.txb_CreditExtraFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_CreditExtraFees.Location = new System.Drawing.Point(597, 228);
            this.txb_CreditExtraFees.Margin = new System.Windows.Forms.Padding(2);
            this.txb_CreditExtraFees.Multiline = true;
            this.txb_CreditExtraFees.Name = "txb_CreditExtraFees";
            this.txb_CreditExtraFees.Size = new System.Drawing.Size(75, 25);
            this.txb_CreditExtraFees.TabIndex = 86;
            // 
            // lb_CreditExtraFees
            // 
            this.lb_CreditExtraFees.AutoSize = true;
            this.lb_CreditExtraFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_CreditExtraFees.Location = new System.Drawing.Point(466, 228);
            this.lb_CreditExtraFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_CreditExtraFees.Name = "lb_CreditExtraFees";
            this.lb_CreditExtraFees.Size = new System.Drawing.Size(86, 20);
            this.lb_CreditExtraFees.TabIndex = 85;
            this.lb_CreditExtraFees.Text = "Extra Fees";
            // 
            // lb_CreditLimitedAmount
            // 
            this.lb_CreditLimitedAmount.AutoSize = true;
            this.lb_CreditLimitedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_CreditLimitedAmount.Location = new System.Drawing.Point(466, 193);
            this.lb_CreditLimitedAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_CreditLimitedAmount.Name = "lb_CreditLimitedAmount";
            this.lb_CreditLimitedAmount.Size = new System.Drawing.Size(120, 20);
            this.lb_CreditLimitedAmount.TabIndex = 84;
            this.lb_CreditLimitedAmount.Text = "Limited Amount";
            // 
            // txb_CreditInterestRate
            // 
            this.txb_CreditInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_CreditInterestRate.Location = new System.Drawing.Point(597, 154);
            this.txb_CreditInterestRate.Margin = new System.Windows.Forms.Padding(2);
            this.txb_CreditInterestRate.Multiline = true;
            this.txb_CreditInterestRate.Name = "txb_CreditInterestRate";
            this.txb_CreditInterestRate.Size = new System.Drawing.Size(75, 25);
            this.txb_CreditInterestRate.TabIndex = 83;
            // 
            // lb_CreditInterestRate
            // 
            this.lb_CreditInterestRate.AutoSize = true;
            this.lb_CreditInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_CreditInterestRate.Location = new System.Drawing.Point(466, 154);
            this.lb_CreditInterestRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_CreditInterestRate.Name = "lb_CreditInterestRate";
            this.lb_CreditInterestRate.Size = new System.Drawing.Size(103, 20);
            this.lb_CreditInterestRate.TabIndex = 82;
            this.lb_CreditInterestRate.Text = "Interest Rate";
            // 
            // txb_SavingExtraFees
            // 
            this.txb_SavingExtraFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_SavingExtraFees.Location = new System.Drawing.Point(368, 191);
            this.txb_SavingExtraFees.Margin = new System.Windows.Forms.Padding(2);
            this.txb_SavingExtraFees.Multiline = true;
            this.txb_SavingExtraFees.Name = "txb_SavingExtraFees";
            this.txb_SavingExtraFees.Size = new System.Drawing.Size(75, 25);
            this.txb_SavingExtraFees.TabIndex = 81;
            // 
            // lb_SavingExtraFees
            // 
            this.lb_SavingExtraFees.AutoSize = true;
            this.lb_SavingExtraFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_SavingExtraFees.Location = new System.Drawing.Point(241, 191);
            this.lb_SavingExtraFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_SavingExtraFees.Name = "lb_SavingExtraFees";
            this.lb_SavingExtraFees.Size = new System.Drawing.Size(86, 20);
            this.lb_SavingExtraFees.TabIndex = 80;
            this.lb_SavingExtraFees.Text = "Extra Fees";
            // 
            // txb_CheckingExtraFees
            // 
            this.txb_CheckingExtraFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_CheckingExtraFees.Location = new System.Drawing.Point(147, 230);
            this.txb_CheckingExtraFees.Margin = new System.Windows.Forms.Padding(2);
            this.txb_CheckingExtraFees.Multiline = true;
            this.txb_CheckingExtraFees.Name = "txb_CheckingExtraFees";
            this.txb_CheckingExtraFees.Size = new System.Drawing.Size(75, 25);
            this.txb_CheckingExtraFees.TabIndex = 79;
            // 
            // lb_CheckingExtraFees
            // 
            this.lb_CheckingExtraFees.AutoSize = true;
            this.lb_CheckingExtraFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_CheckingExtraFees.Location = new System.Drawing.Point(15, 230);
            this.lb_CheckingExtraFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_CheckingExtraFees.Name = "lb_CheckingExtraFees";
            this.lb_CheckingExtraFees.Size = new System.Drawing.Size(86, 20);
            this.lb_CheckingExtraFees.TabIndex = 78;
            this.lb_CheckingExtraFees.Text = "Extra Fees";
            // 
            // lb_checkingCounterTrans
            // 
            this.lb_checkingCounterTrans.AutoSize = true;
            this.lb_checkingCounterTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_checkingCounterTrans.Location = new System.Drawing.Point(13, 193);
            this.lb_checkingCounterTrans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_checkingCounterTrans.Name = "lb_checkingCounterTrans";
            this.lb_checkingCounterTrans.Size = new System.Drawing.Size(153, 20);
            this.lb_checkingCounterTrans.TabIndex = 77;
            this.lb_checkingCounterTrans.Text = "Counter Transaction";
            // 
            // txb_checkingCounterTrans
            // 
            this.txb_checkingCounterTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_checkingCounterTrans.Location = new System.Drawing.Point(173, 191);
            this.txb_checkingCounterTrans.Margin = new System.Windows.Forms.Padding(2);
            this.txb_checkingCounterTrans.Multiline = true;
            this.txb_checkingCounterTrans.Name = "txb_checkingCounterTrans";
            this.txb_checkingCounterTrans.Size = new System.Drawing.Size(49, 25);
            this.txb_checkingCounterTrans.TabIndex = 76;
            // 
            // txb_checkingLimitedTrans
            // 
            this.txb_checkingLimitedTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_checkingLimitedTrans.Location = new System.Drawing.Point(169, 149);
            this.txb_checkingLimitedTrans.Margin = new System.Windows.Forms.Padding(2);
            this.txb_checkingLimitedTrans.Multiline = true;
            this.txb_checkingLimitedTrans.Name = "txb_checkingLimitedTrans";
            this.txb_checkingLimitedTrans.Size = new System.Drawing.Size(53, 25);
            this.txb_checkingLimitedTrans.TabIndex = 75;
            // 
            // lb_checkingLimitedTrans
            // 
            this.lb_checkingLimitedTrans.AutoSize = true;
            this.lb_checkingLimitedTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_checkingLimitedTrans.Location = new System.Drawing.Point(15, 154);
            this.lb_checkingLimitedTrans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_checkingLimitedTrans.Name = "lb_checkingLimitedTrans";
            this.lb_checkingLimitedTrans.Size = new System.Drawing.Size(147, 20);
            this.lb_checkingLimitedTrans.TabIndex = 74;
            this.lb_checkingLimitedTrans.Text = "Limited Transaction";
            // 
            // txb_SavingInterestRate
            // 
            this.txb_SavingInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_SavingInterestRate.Location = new System.Drawing.Point(368, 154);
            this.txb_SavingInterestRate.Margin = new System.Windows.Forms.Padding(2);
            this.txb_SavingInterestRate.Multiline = true;
            this.txb_SavingInterestRate.Name = "txb_SavingInterestRate";
            this.txb_SavingInterestRate.Size = new System.Drawing.Size(75, 25);
            this.txb_SavingInterestRate.TabIndex = 73;
            // 
            // lb_SavingInterestRate
            // 
            this.lb_SavingInterestRate.AutoSize = true;
            this.lb_SavingInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_SavingInterestRate.Location = new System.Drawing.Point(237, 154);
            this.lb_SavingInterestRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_SavingInterestRate.Name = "lb_SavingInterestRate";
            this.lb_SavingInterestRate.Size = new System.Drawing.Size(103, 20);
            this.lb_SavingInterestRate.TabIndex = 72;
            this.lb_SavingInterestRate.Text = "Interest Rate";
            // 
            // txb_CreditAccountNum
            // 
            this.txb_CreditAccountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_CreditAccountNum.Location = new System.Drawing.Point(597, 112);
            this.txb_CreditAccountNum.Margin = new System.Windows.Forms.Padding(2);
            this.txb_CreditAccountNum.Multiline = true;
            this.txb_CreditAccountNum.Name = "txb_CreditAccountNum";
            this.txb_CreditAccountNum.Size = new System.Drawing.Size(75, 25);
            this.txb_CreditAccountNum.TabIndex = 71;
            // 
            // lb_CreditAccountNum
            // 
            this.lb_CreditAccountNum.AutoSize = true;
            this.lb_CreditAccountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_CreditAccountNum.Location = new System.Drawing.Point(466, 114);
            this.lb_CreditAccountNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_CreditAccountNum.Name = "lb_CreditAccountNum";
            this.lb_CreditAccountNum.Size = new System.Drawing.Size(128, 20);
            this.lb_CreditAccountNum.TabIndex = 70;
            this.lb_CreditAccountNum.Text = "Account Number";
            // 
            // txb_SavingAccountNum
            // 
            this.txb_SavingAccountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_SavingAccountNum.Location = new System.Drawing.Point(368, 114);
            this.txb_SavingAccountNum.Margin = new System.Windows.Forms.Padding(2);
            this.txb_SavingAccountNum.Multiline = true;
            this.txb_SavingAccountNum.Name = "txb_SavingAccountNum";
            this.txb_SavingAccountNum.Size = new System.Drawing.Size(75, 25);
            this.txb_SavingAccountNum.TabIndex = 69;
            // 
            // lb_SavingAccountNum
            // 
            this.lb_SavingAccountNum.AutoSize = true;
            this.lb_SavingAccountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_SavingAccountNum.Location = new System.Drawing.Point(237, 116);
            this.lb_SavingAccountNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_SavingAccountNum.Name = "lb_SavingAccountNum";
            this.lb_SavingAccountNum.Size = new System.Drawing.Size(128, 20);
            this.lb_SavingAccountNum.TabIndex = 68;
            this.lb_SavingAccountNum.Text = "Account Number";
            // 
            // txb_checkingAccountNUm
            // 
            this.txb_checkingAccountNUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_checkingAccountNUm.Location = new System.Drawing.Point(147, 114);
            this.txb_checkingAccountNUm.Margin = new System.Windows.Forms.Padding(2);
            this.txb_checkingAccountNUm.Multiline = true;
            this.txb_checkingAccountNUm.Name = "txb_checkingAccountNUm";
            this.txb_checkingAccountNUm.Size = new System.Drawing.Size(75, 25);
            this.txb_checkingAccountNUm.TabIndex = 67;
            // 
            // lb_CheckingAccountNum
            // 
            this.lb_CheckingAccountNum.AutoSize = true;
            this.lb_CheckingAccountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_CheckingAccountNum.Location = new System.Drawing.Point(15, 116);
            this.lb_CheckingAccountNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_CheckingAccountNum.Name = "lb_CheckingAccountNum";
            this.lb_CheckingAccountNum.Size = new System.Drawing.Size(128, 20);
            this.lb_CheckingAccountNum.TabIndex = 66;
            this.lb_CheckingAccountNum.Text = "Account Number";
            // 
            // chb_credit
            // 
            this.chb_credit.AutoSize = true;
            this.chb_credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chb_credit.Location = new System.Drawing.Point(493, 73);
            this.chb_credit.Margin = new System.Windows.Forms.Padding(2);
            this.chb_credit.Name = "chb_credit";
            this.chb_credit.Size = new System.Drawing.Size(133, 24);
            this.chb_credit.TabIndex = 65;
            this.chb_credit.Text = "Credit Account";
            this.chb_credit.UseVisualStyleBackColor = true;
            // 
            // chb_saving
            // 
            this.chb_saving.AutoSize = true;
            this.chb_saving.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chb_saving.Location = new System.Drawing.Point(301, 73);
            this.chb_saving.Margin = new System.Windows.Forms.Padding(2);
            this.chb_saving.Name = "chb_saving";
            this.chb_saving.Size = new System.Drawing.Size(139, 24);
            this.chb_saving.TabIndex = 64;
            this.chb_saving.Text = "Saving Account";
            this.chb_saving.UseVisualStyleBackColor = true;
            // 
            // chb_checking
            // 
            this.chb_checking.AutoSize = true;
            this.chb_checking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chb_checking.Location = new System.Drawing.Point(79, 73);
            this.chb_checking.Margin = new System.Windows.Forms.Padding(2);
            this.chb_checking.Name = "chb_checking";
            this.chb_checking.Size = new System.Drawing.Size(157, 24);
            this.chb_checking.TabIndex = 63;
            this.chb_checking.Text = "Checking Account";
            this.chb_checking.UseVisualStyleBackColor = true;
            // 
            // txb_balanceid
            // 
            this.txb_balanceid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_balanceid.Location = new System.Drawing.Point(331, 33);
            this.txb_balanceid.Margin = new System.Windows.Forms.Padding(2);
            this.txb_balanceid.Multiline = true;
            this.txb_balanceid.Name = "txb_balanceid";
            this.txb_balanceid.Size = new System.Drawing.Size(75, 25);
            this.txb_balanceid.TabIndex = 62;
            // 
            // lb_balance
            // 
            this.lb_balance.AutoSize = true;
            this.lb_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_balance.Location = new System.Drawing.Point(244, 35);
            this.lb_balance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_balance.Name = "lb_balance";
            this.lb_balance.Size = new System.Drawing.Size(67, 20);
            this.lb_balance.TabIndex = 61;
            this.lb_balance.Text = "Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(604, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(557, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "/";
            // 
            // txb_year
            // 
            this.txb_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_year.Location = new System.Drawing.Point(622, 36);
            this.txb_year.Margin = new System.Windows.Forms.Padding(2);
            this.txb_year.Multiline = true;
            this.txb_year.Name = "txb_year";
            this.txb_year.Size = new System.Drawing.Size(41, 25);
            this.txb_year.TabIndex = 58;
            // 
            // txb_day
            // 
            this.txb_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_day.Location = new System.Drawing.Point(575, 36);
            this.txb_day.Margin = new System.Windows.Forms.Padding(2);
            this.txb_day.Multiline = true;
            this.txb_day.Name = "txb_day";
            this.txb_day.Size = new System.Drawing.Size(23, 25);
            this.txb_day.TabIndex = 57;
            // 
            // txb_month
            // 
            this.txb_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_month.Location = new System.Drawing.Point(529, 36);
            this.txb_month.Margin = new System.Windows.Forms.Padding(2);
            this.txb_month.Multiline = true;
            this.txb_month.Name = "txb_month";
            this.txb_month.Size = new System.Drawing.Size(26, 25);
            this.txb_month.TabIndex = 56;
            // 
            // lb_openDate
            // 
            this.lb_openDate.AutoSize = true;
            this.lb_openDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_openDate.Location = new System.Drawing.Point(426, 36);
            this.lb_openDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_openDate.Name = "lb_openDate";
            this.lb_openDate.Size = new System.Drawing.Size(87, 20);
            this.lb_openDate.TabIndex = 55;
            this.lb_openDate.Text = "Open Date";
            // 
            // txb_cid
            // 
            this.txb_cid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_cid.Location = new System.Drawing.Point(137, 34);
            this.txb_cid.Margin = new System.Windows.Forms.Padding(2);
            this.txb_cid.Multiline = true;
            this.txb_cid.Name = "txb_cid";
            this.txb_cid.Size = new System.Drawing.Size(75, 25);
            this.txb_cid.TabIndex = 54;
            // 
            // lb_cid
            // 
            this.lb_cid.AutoSize = true;
            this.lb_cid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_cid.Location = new System.Drawing.Point(25, 34);
            this.lb_cid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_cid.Name = "lb_cid";
            this.lb_cid.Size = new System.Drawing.Size(99, 20);
            this.lb_cid.TabIndex = 53;
            this.lb_cid.Text = "Customer ID";
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_deleteAccount);
            this.Controls.Add(this.btn_addAccount);
            this.Controls.Add(this.btn_listAccounts);
            this.Controls.Add(this.txb_CreditLimitedAmount);
            this.Controls.Add(this.txb_CreditExtraFees);
            this.Controls.Add(this.lb_CreditExtraFees);
            this.Controls.Add(this.lb_CreditLimitedAmount);
            this.Controls.Add(this.txb_CreditInterestRate);
            this.Controls.Add(this.lb_CreditInterestRate);
            this.Controls.Add(this.txb_SavingExtraFees);
            this.Controls.Add(this.lb_SavingExtraFees);
            this.Controls.Add(this.txb_CheckingExtraFees);
            this.Controls.Add(this.lb_CheckingExtraFees);
            this.Controls.Add(this.lb_checkingCounterTrans);
            this.Controls.Add(this.txb_checkingCounterTrans);
            this.Controls.Add(this.txb_checkingLimitedTrans);
            this.Controls.Add(this.lb_checkingLimitedTrans);
            this.Controls.Add(this.txb_SavingInterestRate);
            this.Controls.Add(this.lb_SavingInterestRate);
            this.Controls.Add(this.txb_CreditAccountNum);
            this.Controls.Add(this.lb_CreditAccountNum);
            this.Controls.Add(this.txb_SavingAccountNum);
            this.Controls.Add(this.lb_SavingAccountNum);
            this.Controls.Add(this.txb_checkingAccountNUm);
            this.Controls.Add(this.lb_CheckingAccountNum);
            this.Controls.Add(this.chb_credit);
            this.Controls.Add(this.chb_saving);
            this.Controls.Add(this.chb_checking);
            this.Controls.Add(this.txb_balanceid);
            this.Controls.Add(this.lb_balance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_year);
            this.Controls.Add(this.txb_day);
            this.Controls.Add(this.txb_month);
            this.Controls.Add(this.lb_openDate);
            this.Controls.Add(this.txb_cid);
            this.Controls.Add(this.lb_cid);
            this.Name = "FormAccount";
            this.Text = "Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_deleteAccount;
        private System.Windows.Forms.Button btn_addAccount;
        private System.Windows.Forms.Button btn_listAccounts;
        private System.Windows.Forms.TextBox txb_CreditLimitedAmount;
        private System.Windows.Forms.TextBox txb_CreditExtraFees;
        private System.Windows.Forms.Label lb_CreditExtraFees;
        private System.Windows.Forms.Label lb_CreditLimitedAmount;
        private System.Windows.Forms.TextBox txb_CreditInterestRate;
        private System.Windows.Forms.Label lb_CreditInterestRate;
        private System.Windows.Forms.TextBox txb_SavingExtraFees;
        private System.Windows.Forms.Label lb_SavingExtraFees;
        private System.Windows.Forms.TextBox txb_CheckingExtraFees;
        private System.Windows.Forms.Label lb_CheckingExtraFees;
        private System.Windows.Forms.Label lb_checkingCounterTrans;
        private System.Windows.Forms.TextBox txb_checkingCounterTrans;
        private System.Windows.Forms.TextBox txb_checkingLimitedTrans;
        private System.Windows.Forms.Label lb_checkingLimitedTrans;
        private System.Windows.Forms.TextBox txb_SavingInterestRate;
        private System.Windows.Forms.Label lb_SavingInterestRate;
        private System.Windows.Forms.TextBox txb_CreditAccountNum;
        private System.Windows.Forms.Label lb_CreditAccountNum;
        private System.Windows.Forms.TextBox txb_SavingAccountNum;
        private System.Windows.Forms.Label lb_SavingAccountNum;
        private System.Windows.Forms.TextBox txb_checkingAccountNUm;
        private System.Windows.Forms.Label lb_CheckingAccountNum;
        private System.Windows.Forms.CheckBox chb_credit;
        private System.Windows.Forms.CheckBox chb_saving;
        private System.Windows.Forms.CheckBox chb_checking;
        private System.Windows.Forms.TextBox txb_balanceid;
        private System.Windows.Forms.Label lb_balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_year;
        private System.Windows.Forms.TextBox txb_day;
        private System.Windows.Forms.TextBox txb_month;
        private System.Windows.Forms.Label lb_openDate;
        private System.Windows.Forms.TextBox txb_cid;
        private System.Windows.Forms.Label lb_cid;
    }
}