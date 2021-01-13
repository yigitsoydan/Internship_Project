namespace IntertechProject
{
    partial class IntertechProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntertechProject));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblClientNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblCitizenshipNumber = new System.Windows.Forms.Label();
            this.lblMainBranchCode = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtCitizenshipNumber = new System.Windows.Forms.TextBox();
            this.txtClientNo = new System.Windows.Forms.TextBox();
            this.cmbMainBranchCode = new System.Windows.Forms.ComboBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.textSearch2 = new System.Windows.Forms.TextBox();
            this.lblUnitStatus = new System.Windows.Forms.Label();
            this.cmbUnitStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateExtra = new System.Windows.Forms.Button();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.cmbCustomerType = new System.Windows.Forms.ComboBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnUpdateBalance = new System.Windows.Forms.Button();
            this.lblReports = new System.Windows.Forms.Label();
            this.cmbReports = new System.Windows.Forms.ComboBox();
            this.btnOpenAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(603, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(241, 73);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.Location = new System.Drawing.Point(44, 120);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 20);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id";
            // 
            // lblClientNo
            // 
            this.lblClientNo.AutoSize = true;
            this.lblClientNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblClientNo.Location = new System.Drawing.Point(44, 153);
            this.lblClientNo.Name = "lblClientNo";
            this.lblClientNo.Size = new System.Drawing.Size(73, 20);
            this.lblClientNo.TabIndex = 2;
            this.lblClientNo.Text = "ClientNo";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(44, 186);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiddleName.Location = new System.Drawing.Point(44, 219);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(107, 20);
            this.lblMiddleName.TabIndex = 4;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.Location = new System.Drawing.Point(44, 252);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(76, 20);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Surname";
            // 
            // lblCitizenshipNumber
            // 
            this.lblCitizenshipNumber.AutoSize = true;
            this.lblCitizenshipNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCitizenshipNumber.Location = new System.Drawing.Point(44, 285);
            this.lblCitizenshipNumber.Name = "lblCitizenshipNumber";
            this.lblCitizenshipNumber.Size = new System.Drawing.Size(156, 20);
            this.lblCitizenshipNumber.TabIndex = 6;
            this.lblCitizenshipNumber.Text = "Citizenship Number";
            // 
            // lblMainBranchCode
            // 
            this.lblMainBranchCode.AutoSize = true;
            this.lblMainBranchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMainBranchCode.Location = new System.Drawing.Point(44, 319);
            this.lblMainBranchCode.Name = "lblMainBranchCode";
            this.lblMainBranchCode.Size = new System.Drawing.Size(107, 20);
            this.lblMainBranchCode.TabIndex = 7;
            this.lblMainBranchCode.Text = "Branch Code";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Location = new System.Drawing.Point(213, 113);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(123, 27);
            this.txtId.TabIndex = 8;
            
            // 
            // txtboxName
            // 
            this.txtboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxName.Location = new System.Drawing.Point(213, 179);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(123, 27);
            this.txtboxName.TabIndex = 9;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiddleName.Location = new System.Drawing.Point(213, 212);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(123, 27);
            this.txtMiddleName.TabIndex = 10;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.Location = new System.Drawing.Point(213, 245);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(123, 27);
            this.txtSurname.TabIndex = 11;
            // 
            // txtCitizenshipNumber
            // 
            this.txtCitizenshipNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCitizenshipNumber.Location = new System.Drawing.Point(213, 278);
            this.txtCitizenshipNumber.Name = "txtCitizenshipNumber";
            this.txtCitizenshipNumber.Size = new System.Drawing.Size(123, 27);
            this.txtCitizenshipNumber.TabIndex = 12;
            // 
            // txtClientNo
            // 
            this.txtClientNo.Enabled = false;
            this.txtClientNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtClientNo.Location = new System.Drawing.Point(213, 146);
            this.txtClientNo.Name = "txtClientNo";
            this.txtClientNo.ReadOnly = true;
            this.txtClientNo.Size = new System.Drawing.Size(123, 27);
            this.txtClientNo.TabIndex = 13;
            // 
            // cmbMainBranchCode
            // 
            this.cmbMainBranchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMainBranchCode.FormattingEnabled = true;
            this.cmbMainBranchCode.Items.AddRange(new object[] {
            "9142",
            "1570",
            "1480",
            "1690"});
            this.cmbMainBranchCode.Location = new System.Drawing.Point(213, 311);
            this.cmbMainBranchCode.Name = "cmbMainBranchCode";
            this.cmbMainBranchCode.Size = new System.Drawing.Size(123, 28);
            this.cmbMainBranchCode.TabIndex = 14;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCustomer.Location = new System.Drawing.Point(37, 378);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(138, 47);
            this.btnAddCustomer.TabIndex = 15;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(213, 378);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(138, 48);
            this.btnDeleteCustomer.TabIndex = 16;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.BackColor = System.Drawing.Color.LightCyan;
            this.btnUpdateRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateRecord.Location = new System.Drawing.Point(37, 440);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(138, 47);
            this.btnUpdateRecord.TabIndex = 19;
            this.btnUpdateRecord.Text = "Update Record";
            this.btnUpdateRecord.UseVisualStyleBackColor = false;
            this.btnUpdateRecord.Click += new System.EventHandler(this.btnUpdateRecord_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Location = new System.Drawing.Point(213, 440);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 47);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerList.Location = new System.Drawing.Point(366, 113);
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.RowTemplate.Height = 24;
            this.dgvCustomerList.Size = new System.Drawing.Size(837, 374);
            this.dgvCustomerList.TabIndex = 21;
            this.dgvCustomerList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCustomerList_RowHeaderMouseClick);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Orange;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomers.Location = new System.Drawing.Point(1224, 146);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(168, 60);
            this.btnCustomers.TabIndex = 23;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.BackColor = System.Drawing.Color.Orange;
            this.btnAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccounts.Location = new System.Drawing.Point(1224, 200);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(168, 60);
            this.btnAccounts.TabIndex = 24;
            this.btnAccounts.Text = "Accounts";
            this.btnAccounts.UseVisualStyleBackColor = false;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteAccount.Location = new System.Drawing.Point(213, 379);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(138, 48);
            this.btnDeleteAccount.TabIndex = 25;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Visible = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddAccount.Location = new System.Drawing.Point(37, 379);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(138, 47);
            this.btnAddAccount.TabIndex = 26;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Visible = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1273, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tables";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(450, 507);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(271, 28);
            this.txtSearch.TabIndex = 29;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.Location = new System.Drawing.Point(389, 513);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(55, 18);
            this.lblSearch.TabIndex = 30;
            this.lblSearch.Text = "Search";
            // 
            // textSearch2
            // 
            this.textSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSearch2.Location = new System.Drawing.Point(450, 507);
            this.textSearch2.Name = "textSearch2";
            this.textSearch2.Size = new System.Drawing.Size(271, 28);
            this.textSearch2.TabIndex = 31;
            this.textSearch2.TextChanged += new System.EventHandler(this.textSearch2_TextChanged);
            // 
            // lblUnitStatus
            // 
            this.lblUnitStatus.AutoSize = true;
            this.lblUnitStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnitStatus.Location = new System.Drawing.Point(33, 521);
            this.lblUnitStatus.Name = "lblUnitStatus";
            this.lblUnitStatus.Size = new System.Drawing.Size(87, 20);
            this.lblUnitStatus.TabIndex = 32;
            this.lblUnitStatus.Text = "UnitStatus";
            this.lblUnitStatus.Visible = false;
            // 
            // cmbUnitStatus
            // 
            this.cmbUnitStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUnitStatus.FormattingEnabled = true;
            this.cmbUnitStatus.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbUnitStatus.Location = new System.Drawing.Point(186, 513);
            this.cmbUnitStatus.Name = "cmbUnitStatus";
            this.cmbUnitStatus.Size = new System.Drawing.Size(123, 28);
            this.cmbUnitStatus.TabIndex = 33;
            this.cmbUnitStatus.Visible = false;
            // 
            // btnUpdateExtra
            // 
            this.btnUpdateExtra.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnUpdateExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateExtra.Location = new System.Drawing.Point(37, 597);
            this.btnUpdateExtra.Name = "btnUpdateExtra";
            this.btnUpdateExtra.Size = new System.Drawing.Size(186, 30);
            this.btnUpdateExtra.TabIndex = 34;
            this.btnUpdateExtra.Text = "Update Extra Info";
            this.btnUpdateExtra.UseVisualStyleBackColor = false;
            this.btnUpdateExtra.Visible = false;
            this.btnUpdateExtra.Click += new System.EventHandler(this.btnUpdateExtra_Click);
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerType.Location = new System.Drawing.Point(33, 559);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(123, 20);
            this.lblCustomerType.TabIndex = 35;
            this.lblCustomerType.Text = "Customer Type";
            this.lblCustomerType.Visible = false;
            // 
            // cmbCustomerType
            // 
            this.cmbCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCustomerType.FormattingEnabled = true;
            this.cmbCustomerType.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbCustomerType.Location = new System.Drawing.Point(186, 551);
            this.cmbCustomerType.Name = "cmbCustomerType";
            this.cmbCustomerType.Size = new System.Drawing.Size(123, 28);
            this.cmbCustomerType.TabIndex = 36;
            this.cmbCustomerType.Visible = false;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBalance.Location = new System.Drawing.Point(773, 511);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(70, 20);
            this.lblBalance.TabIndex = 37;
            this.lblBalance.Text = "Balance";
            this.lblBalance.Visible = false;
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBalance.Location = new System.Drawing.Point(858, 507);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(138, 27);
            this.txtBalance.TabIndex = 38;
            this.txtBalance.Visible = false;
            // 
            // btnUpdateBalance
            // 
            this.btnUpdateBalance.BackColor = System.Drawing.Color.Aqua;
            this.btnUpdateBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateBalance.Location = new System.Drawing.Point(1020, 503);
            this.btnUpdateBalance.Name = "btnUpdateBalance";
            this.btnUpdateBalance.Size = new System.Drawing.Size(170, 32);
            this.btnUpdateBalance.TabIndex = 39;
            this.btnUpdateBalance.Text = "Update Balance";
            this.btnUpdateBalance.UseVisualStyleBackColor = false;
            this.btnUpdateBalance.Visible = false;
            this.btnUpdateBalance.Click += new System.EventHandler(this.btnUpdateBalance_Click);
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReports.Location = new System.Drawing.Point(1273, 311);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(75, 24);
            this.lblReports.TabIndex = 40;
            this.lblReports.Text = "Reports";
            // 
            // cmbReports
            // 
            this.cmbReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbReports.FormattingEnabled = true;
            this.cmbReports.Items.AddRange(new object[] {
            "Report 1"});
            this.cmbReports.Location = new System.Drawing.Point(1209, 349);
            this.cmbReports.Name = "cmbReports";
            this.cmbReports.Size = new System.Drawing.Size(224, 28);
            this.cmbReports.TabIndex = 41;
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnOpenAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOpenAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenAccount.Location = new System.Drawing.Point(1207, 391);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(133, 36);
            this.btnOpenAccount.TabIndex = 42;
            this.btnOpenAccount.Text = "Open Report";
            this.btnOpenAccount.UseVisualStyleBackColor = false;
            this.btnOpenAccount.Click += new System.EventHandler(this.btnOpenAccount_Click);
            // 
            // IntertechProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1445, 671);
            this.Controls.Add(this.btnOpenAccount);
            this.Controls.Add(this.cmbReports);
            this.Controls.Add(this.lblReports);
            this.Controls.Add(this.btnUpdateBalance);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.cmbCustomerType);
            this.Controls.Add(this.lblCustomerType);
            this.Controls.Add(this.btnUpdateExtra);
            this.Controls.Add(this.cmbUnitStatus);
            this.Controls.Add(this.lblUnitStatus);
            this.Controls.Add(this.textSearch2);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnAccounts);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.dgvCustomerList);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdateRecord);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.cmbMainBranchCode);
            this.Controls.Add(this.txtClientNo);
            this.Controls.Add(this.txtCitizenshipNumber);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblMainBranchCode);
            this.Controls.Add(this.lblCitizenshipNumber);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblClientNo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "IntertechProject";
            this.Text = "IntertechProject";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblClientNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblCitizenshipNumber;
        private System.Windows.Forms.Label lblMainBranchCode;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtCitizenshipNumber;
        private System.Windows.Forms.TextBox txtClientNo;
        private System.Windows.Forms.ComboBox cmbMainBranchCode;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox textSearch2;
        private System.Windows.Forms.Label lblUnitStatus;
        private System.Windows.Forms.ComboBox cmbUnitStatus;
        private System.Windows.Forms.Button btnUpdateExtra;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.ComboBox cmbCustomerType;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Button btnUpdateBalance;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.ComboBox cmbReports;
        private System.Windows.Forms.Button btnOpenAccount;
    }
}

