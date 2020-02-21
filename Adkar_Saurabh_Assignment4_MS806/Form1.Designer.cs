namespace InvestMe
{
    partial class investMeApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(investMeApp));
            this.bankNameLabel = new System.Windows.Forms.Label();
            this.amountToBeInvestedLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.termInterestRateTable = new System.Windows.Forms.ListBox();
            this.termLabel = new System.Windows.Forms.Label();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.accuredAmountLabel = new System.Windows.Forms.Label();
            this.proceedButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.customerDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.customerEmailTextBox = new System.Windows.Forms.TextBox();
            this.customerTelephoneTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerEmailLabel = new System.Windows.Forms.Label();
            this.customerTelephoneLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.customerLoginButton = new System.Windows.Forms.Button();
            this.employeeLoginButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.summaryButton = new System.Windows.Forms.Button();
            this.investmentSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.averageDurationSummaryLabel = new System.Windows.Forms.Label();
            this.totalInterestSummaryLabel = new System.Windows.Forms.Label();
            this.totalAmountInvestedSummaryLabel = new System.Windows.Forms.Label();
            this.transactionNumbersSummaryLabel = new System.Windows.Forms.Label();
            this.averageDurationSummaryTextBox = new System.Windows.Forms.TextBox();
            this.totalInterestSummaryTextBox = new System.Windows.Forms.TextBox();
            this.totalAmountInvestedSummaryTextBox = new System.Windows.Forms.TextBox();
            this.transactionNumbersSummaryTextBox = new System.Windows.Forms.RichTextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.enterKeywordLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.supportLabel = new System.Windows.Forms.Label();
            this.customerDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.investmentSummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bankNameLabel
            // 
            this.bankNameLabel.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankNameLabel.Location = new System.Drawing.Point(452, 43);
            this.bankNameLabel.Name = "bankNameLabel";
            this.bankNameLabel.Size = new System.Drawing.Size(330, 53);
            this.bankNameLabel.TabIndex = 0;
            this.bankNameLabel.Text = "MyMoney Bank Corp ";
            this.bankNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amountToBeInvestedLabel
            // 
            this.amountToBeInvestedLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountToBeInvestedLabel.Location = new System.Drawing.Point(192, 137);
            this.amountToBeInvestedLabel.Name = "amountToBeInvestedLabel";
            this.amountToBeInvestedLabel.Size = new System.Drawing.Size(247, 58);
            this.amountToBeInvestedLabel.TabIndex = 1;
            this.amountToBeInvestedLabel.Text = " Amount to be Invested";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(445, 128);
            this.amountTextBox.Multiline = true;
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(293, 42);
            this.amountTextBox.TabIndex = 2;
            this.amountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTextBox_KeyPress);
            // 
            // displayButton
            // 
            this.displayButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButton.Location = new System.Drawing.Point(511, 191);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(154, 57);
            this.displayButton.TabIndex = 3;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // termInterestRateTable
            // 
            this.termInterestRateTable.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termInterestRateTable.FormattingEnabled = true;
            this.termInterestRateTable.ItemHeight = 23;
            this.termInterestRateTable.Location = new System.Drawing.Point(372, 363);
            this.termInterestRateTable.Name = "termInterestRateTable";
            this.termInterestRateTable.Size = new System.Drawing.Size(485, 142);
            this.termInterestRateTable.TabIndex = 4;
            // 
            // termLabel
            // 
            this.termLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termLabel.Location = new System.Drawing.Point(378, 324);
            this.termLabel.Name = "termLabel";
            this.termLabel.Size = new System.Drawing.Size(96, 36);
            this.termLabel.TabIndex = 10;
            this.termLabel.Text = "Term";
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestRateLabel.Location = new System.Drawing.Point(506, 324);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(308, 36);
            this.interestRateLabel.TabIndex = 11;
            this.interestRateLabel.Text = "Interest Rate";
            // 
            // accuredAmountLabel
            // 
            this.accuredAmountLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuredAmountLabel.Location = new System.Drawing.Point(674, 324);
            this.accuredAmountLabel.Name = "accuredAmountLabel";
            this.accuredAmountLabel.Size = new System.Drawing.Size(334, 36);
            this.accuredAmountLabel.TabIndex = 12;
            this.accuredAmountLabel.Text = "Accured Amount";
            // 
            // proceedButton
            // 
            this.proceedButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedButton.Location = new System.Drawing.Point(530, 557);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(154, 50);
            this.proceedButton.TabIndex = 13;
            this.proceedButton.Text = "&Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1019, 595);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(154, 50);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(1019, 522);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(154, 50);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // customerDetailsGroupBox
            // 
            this.customerDetailsGroupBox.Controls.Add(this.confirmButton);
            this.customerDetailsGroupBox.Controls.Add(this.customerEmailTextBox);
            this.customerDetailsGroupBox.Controls.Add(this.customerTelephoneTextBox);
            this.customerDetailsGroupBox.Controls.Add(this.customerNameTextBox);
            this.customerDetailsGroupBox.Controls.Add(this.customerEmailLabel);
            this.customerDetailsGroupBox.Controls.Add(this.customerTelephoneLabel);
            this.customerDetailsGroupBox.Controls.Add(this.customerNameLabel);
            this.customerDetailsGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDetailsGroupBox.Location = new System.Drawing.Point(381, 191);
            this.customerDetailsGroupBox.Name = "customerDetailsGroupBox";
            this.customerDetailsGroupBox.Size = new System.Drawing.Size(476, 359);
            this.customerDetailsGroupBox.TabIndex = 16;
            this.customerDetailsGroupBox.TabStop = false;
            this.customerDetailsGroupBox.Text = "Customer Details";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(346, 284);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(114, 54);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "&Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // customerEmailTextBox
            // 
            this.customerEmailTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerEmailTextBox.Location = new System.Drawing.Point(165, 199);
            this.customerEmailTextBox.Multiline = true;
            this.customerEmailTextBox.Name = "customerEmailTextBox";
            this.customerEmailTextBox.Size = new System.Drawing.Size(260, 41);
            this.customerEmailTextBox.TabIndex = 5;
            // 
            // customerTelephoneTextBox
            // 
            this.customerTelephoneTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTelephoneTextBox.Location = new System.Drawing.Point(165, 130);
            this.customerTelephoneTextBox.Multiline = true;
            this.customerTelephoneTextBox.Name = "customerTelephoneTextBox";
            this.customerTelephoneTextBox.Size = new System.Drawing.Size(260, 41);
            this.customerTelephoneTextBox.TabIndex = 4;
            this.customerTelephoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customerTelephoneTextBox_KeyPress);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(165, 54);
            this.customerNameTextBox.Multiline = true;
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(260, 44);
            this.customerNameTextBox.TabIndex = 3;
            this.customerNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customerNameTextBox_KeyPress);
            // 
            // customerEmailLabel
            // 
            this.customerEmailLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerEmailLabel.Location = new System.Drawing.Point(22, 202);
            this.customerEmailLabel.Name = "customerEmailLabel";
            this.customerEmailLabel.Size = new System.Drawing.Size(87, 30);
            this.customerEmailLabel.TabIndex = 2;
            this.customerEmailLabel.Text = "Email";
            // 
            // customerTelephoneLabel
            // 
            this.customerTelephoneLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTelephoneLabel.Location = new System.Drawing.Point(22, 133);
            this.customerTelephoneLabel.Name = "customerTelephoneLabel";
            this.customerTelephoneLabel.Size = new System.Drawing.Size(124, 27);
            this.customerTelephoneLabel.TabIndex = 1;
            this.customerTelephoneLabel.Text = "Telephone";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(22, 57);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(100, 23);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Name";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(770, 128);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(280, 42);
            this.searchTextBox.TabIndex = 17;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(835, 191);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(154, 57);
            this.searchButton.TabIndex = 18;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(415, 219);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(384, 48);
            this.passwordTextBox.TabIndex = 19;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customerLoginButton
            // 
            this.customerLoginButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLoginButton.Location = new System.Drawing.Point(415, 296);
            this.customerLoginButton.Name = "customerLoginButton";
            this.customerLoginButton.Size = new System.Drawing.Size(171, 83);
            this.customerLoginButton.TabIndex = 20;
            this.customerLoginButton.Text = "&Customer Login";
            this.customerLoginButton.UseVisualStyleBackColor = true;
            this.customerLoginButton.Click += new System.EventHandler(this.customerLoginButton_Click);
            // 
            // employeeLoginButton
            // 
            this.employeeLoginButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLoginButton.Location = new System.Drawing.Point(637, 296);
            this.employeeLoginButton.Name = "employeeLoginButton";
            this.employeeLoginButton.Size = new System.Drawing.Size(162, 83);
            this.employeeLoginButton.TabIndex = 21;
            this.employeeLoginButton.Text = "&Employee Login";
            this.employeeLoginButton.UseVisualStyleBackColor = true;
            this.employeeLoginButton.Click += new System.EventHandler(this.employeeLoginButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(748, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(372, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // summaryButton
            // 
            this.summaryButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryButton.Location = new System.Drawing.Point(12, 522);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(227, 120);
            this.summaryButton.TabIndex = 24;
            this.summaryButton.Text = "&Click here for Transactions Summary";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // investmentSummaryGroupBox
            // 
            this.investmentSummaryGroupBox.Controls.Add(this.averageDurationSummaryLabel);
            this.investmentSummaryGroupBox.Controls.Add(this.totalInterestSummaryLabel);
            this.investmentSummaryGroupBox.Controls.Add(this.totalAmountInvestedSummaryLabel);
            this.investmentSummaryGroupBox.Controls.Add(this.transactionNumbersSummaryLabel);
            this.investmentSummaryGroupBox.Controls.Add(this.averageDurationSummaryTextBox);
            this.investmentSummaryGroupBox.Controls.Add(this.totalInterestSummaryTextBox);
            this.investmentSummaryGroupBox.Controls.Add(this.totalAmountInvestedSummaryTextBox);
            this.investmentSummaryGroupBox.Controls.Add(this.transactionNumbersSummaryTextBox);
            this.investmentSummaryGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investmentSummaryGroupBox.Location = new System.Drawing.Point(346, 219);
            this.investmentSummaryGroupBox.Name = "investmentSummaryGroupBox";
            this.investmentSummaryGroupBox.Size = new System.Drawing.Size(483, 421);
            this.investmentSummaryGroupBox.TabIndex = 25;
            this.investmentSummaryGroupBox.TabStop = false;
            this.investmentSummaryGroupBox.Text = "Investemnt Summary";
            // 
            // averageDurationSummaryLabel
            // 
            this.averageDurationSummaryLabel.Location = new System.Drawing.Point(16, 318);
            this.averageDurationSummaryLabel.Name = "averageDurationSummaryLabel";
            this.averageDurationSummaryLabel.Size = new System.Drawing.Size(268, 88);
            this.averageDurationSummaryLabel.TabIndex = 7;
            this.averageDurationSummaryLabel.Text = "Average Duration (Term) of an Investement";
            this.averageDurationSummaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalInterestSummaryLabel
            // 
            this.totalInterestSummaryLabel.Location = new System.Drawing.Point(6, 238);
            this.totalInterestSummaryLabel.Name = "totalInterestSummaryLabel";
            this.totalInterestSummaryLabel.Size = new System.Drawing.Size(268, 59);
            this.totalInterestSummaryLabel.TabIndex = 6;
            this.totalInterestSummaryLabel.Text = "Total Interest Accuring on the Investments";
            this.totalInterestSummaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalAmountInvestedSummaryLabel
            // 
            this.totalAmountInvestedSummaryLabel.Location = new System.Drawing.Point(16, 159);
            this.totalAmountInvestedSummaryLabel.Name = "totalAmountInvestedSummaryLabel";
            this.totalAmountInvestedSummaryLabel.Size = new System.Drawing.Size(245, 59);
            this.totalAmountInvestedSummaryLabel.TabIndex = 5;
            this.totalAmountInvestedSummaryLabel.Text = "Total Amount Invested";
            this.totalAmountInvestedSummaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transactionNumbersSummaryLabel
            // 
            this.transactionNumbersSummaryLabel.Location = new System.Drawing.Point(16, 57);
            this.transactionNumbersSummaryLabel.Name = "transactionNumbersSummaryLabel";
            this.transactionNumbersSummaryLabel.Size = new System.Drawing.Size(236, 59);
            this.transactionNumbersSummaryLabel.TabIndex = 4;
            this.transactionNumbersSummaryLabel.Text = "Transaction Numbers";
            this.transactionNumbersSummaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageDurationSummaryTextBox
            // 
            this.averageDurationSummaryTextBox.Location = new System.Drawing.Point(290, 339);
            this.averageDurationSummaryTextBox.Multiline = true;
            this.averageDurationSummaryTextBox.Name = "averageDurationSummaryTextBox";
            this.averageDurationSummaryTextBox.ReadOnly = true;
            this.averageDurationSummaryTextBox.Size = new System.Drawing.Size(164, 46);
            this.averageDurationSummaryTextBox.TabIndex = 3;
            // 
            // totalInterestSummaryTextBox
            // 
            this.totalInterestSummaryTextBox.Location = new System.Drawing.Point(290, 251);
            this.totalInterestSummaryTextBox.Multiline = true;
            this.totalInterestSummaryTextBox.Name = "totalInterestSummaryTextBox";
            this.totalInterestSummaryTextBox.ReadOnly = true;
            this.totalInterestSummaryTextBox.Size = new System.Drawing.Size(164, 42);
            this.totalInterestSummaryTextBox.TabIndex = 2;
            // 
            // totalAmountInvestedSummaryTextBox
            // 
            this.totalAmountInvestedSummaryTextBox.Location = new System.Drawing.Point(290, 171);
            this.totalAmountInvestedSummaryTextBox.Multiline = true;
            this.totalAmountInvestedSummaryTextBox.Name = "totalAmountInvestedSummaryTextBox";
            this.totalAmountInvestedSummaryTextBox.ReadOnly = true;
            this.totalAmountInvestedSummaryTextBox.Size = new System.Drawing.Size(164, 47);
            this.totalAmountInvestedSummaryTextBox.TabIndex = 1;
            // 
            // transactionNumbersSummaryTextBox
            // 
            this.transactionNumbersSummaryTextBox.Location = new System.Drawing.Point(290, 41);
            this.transactionNumbersSummaryTextBox.Name = "transactionNumbersSummaryTextBox";
            this.transactionNumbersSummaryTextBox.ReadOnly = true;
            this.transactionNumbersSummaryTextBox.Size = new System.Drawing.Size(164, 96);
            this.transactionNumbersSummaryTextBox.TabIndex = 0;
            this.transactionNumbersSummaryTextBox.Text = "";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(410, 128);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(384, 60);
            this.passwordLabel.TabIndex = 26;
            this.passwordLabel.Text = "Please enter Customer/Employee password to log in";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterKeywordLabel
            // 
            this.enterKeywordLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterKeywordLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.enterKeywordLabel.Location = new System.Drawing.Point(365, 124);
            this.enterKeywordLabel.Name = "enterKeywordLabel";
            this.enterKeywordLabel.Size = new System.Drawing.Size(382, 92);
            this.enterKeywordLabel.TabIndex = 17;
            this.enterKeywordLabel.Text = "Please enter Transaction Number/Customer Email Id to see customer specific detail" +
    "s";
            this.enterKeywordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(1019, 439);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(154, 50);
            this.logoutButton.TabIndex = 27;
            this.logoutButton.Text = "&Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // supportLabel
            // 
            this.supportLabel.AutoSize = true;
            this.supportLabel.Location = new System.Drawing.Point(8, 645);
            this.supportLabel.Name = "supportLabel";
            this.supportLabel.Size = new System.Drawing.Size(445, 20);
            this.supportLabel.TabIndex = 28;
            this.supportLabel.Text = "For technical support please contact : S.Adkar1@nuigalway.ie";
            // 
            // investMeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1215, 669);
            this.Controls.Add(this.supportLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.enterKeywordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.investmentSummaryGroupBox);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.employeeLoginButton);
            this.Controls.Add(this.customerLoginButton);
            this.Controls.Add(this.customerDetailsGroupBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.accuredAmountLabel);
            this.Controls.Add(this.interestRateLabel);
            this.Controls.Add(this.termLabel);
            this.Controls.Add(this.termInterestRateTable);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.amountToBeInvestedLabel);
            this.Controls.Add(this.bankNameLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "investMeApp";
            this.Text = "InvestMe";
            this.Load += new System.EventHandler(this.investMeApp_Load);
            this.customerDetailsGroupBox.ResumeLayout(false);
            this.customerDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.investmentSummaryGroupBox.ResumeLayout(false);
            this.investmentSummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bankNameLabel;
        private System.Windows.Forms.Label amountToBeInvestedLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.ListBox termInterestRateTable;
        private System.Windows.Forms.Label termLabel;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Label accuredAmountLabel;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox customerDetailsGroupBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox customerEmailTextBox;
        private System.Windows.Forms.TextBox customerTelephoneTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label customerEmailLabel;
        private System.Windows.Forms.Label customerTelephoneLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button customerLoginButton;
        private System.Windows.Forms.Button employeeLoginButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Label averageDurationSummaryLabel;
        private System.Windows.Forms.Label totalInterestSummaryLabel;
        private System.Windows.Forms.Label totalAmountInvestedSummaryLabel;
        private System.Windows.Forms.Label transactionNumbersSummaryLabel;
        private System.Windows.Forms.TextBox averageDurationSummaryTextBox;
        private System.Windows.Forms.TextBox totalInterestSummaryTextBox;
        private System.Windows.Forms.TextBox totalAmountInvestedSummaryTextBox;
        private System.Windows.Forms.RichTextBox transactionNumbersSummaryTextBox;
        private System.Windows.Forms.GroupBox investmentSummaryGroupBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label enterKeywordLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label supportLabel;
    }
}

