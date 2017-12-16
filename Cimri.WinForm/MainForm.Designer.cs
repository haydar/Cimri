namespace Cimri.WinForm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.mtcMain = new MetroFramework.Controls.MetroTabControl();
            this.mtpMain = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtpCompanies = new MetroFramework.Controls.MetroTabPage();
            this.tlpCompanies = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCompanyDetails = new System.Windows.Forms.TableLayoutPanel();
            this.gbCompanyDetails = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDetailCompanyStates = new System.Windows.Forms.Panel();
            this.mrdbtnPassive = new MetroFramework.Controls.MetroRadioButton();
            this.mrdbtnActive = new MetroFramework.Controls.MetroRadioButton();
            this.mtxtDetailFax = new System.Windows.Forms.MaskedTextBox();
            this.mlbCompanyDetailId = new MetroFramework.Controls.MetroLabel();
            this.mlblDetailTitle = new MetroFramework.Controls.MetroLabel();
            this.mlblAddressCity = new MetroFramework.Controls.MetroLabel();
            this.mlblAddressDistrict = new MetroFramework.Controls.MetroLabel();
            this.mlblAddressNeighborhood = new MetroFramework.Controls.MetroLabel();
            this.mlblAddressStreet = new MetroFramework.Controls.MetroLabel();
            this.mlblAddressNo = new MetroFramework.Controls.MetroLabel();
            this.mlblFloor = new MetroFramework.Controls.MetroLabel();
            this.mlblTaxNo = new MetroFramework.Controls.MetroLabel();
            this.mlblTaxAdministration = new MetroFramework.Controls.MetroLabel();
            this.mlblAuthorizedPerson = new MetroFramework.Controls.MetroLabel();
            this.mlblAuthorizedPersonGender = new MetroFramework.Controls.MetroLabel();
            this.mlblTel = new MetroFramework.Controls.MetroLabel();
            this.mlblFax = new MetroFramework.Controls.MetroLabel();
            this.mlblMail = new MetroFramework.Controls.MetroLabel();
            this.mlblTradeRegistryNo = new MetroFramework.Controls.MetroLabel();
            this.mlblCreateDate = new MetroFramework.Controls.MetroLabel();
            this.mlblDetailIsActive = new MetroFramework.Controls.MetroLabel();
            this.lblIban = new MetroFramework.Controls.MetroLabel();
            this.mlblDetailCompanyStatus = new MetroFramework.Controls.MetroLabel();
            this.mtxtDetailTitle = new MetroFramework.Controls.MetroTextBox();
            this.mtxtCity = new MetroFramework.Controls.MetroTextBox();
            this.mtxtDistrict = new MetroFramework.Controls.MetroTextBox();
            this.mtxtNeighborhood = new MetroFramework.Controls.MetroTextBox();
            this.mtxtStreet = new MetroFramework.Controls.MetroTextBox();
            this.mtxtAdressNo = new MetroFramework.Controls.MetroTextBox();
            this.mtxtFloor = new MetroFramework.Controls.MetroTextBox();
            this.mtxtTaxNo = new MetroFramework.Controls.MetroTextBox();
            this.mtxtTaxAdministration = new MetroFramework.Controls.MetroTextBox();
            this.mtxtAuthorizedPerson = new MetroFramework.Controls.MetroTextBox();
            this.mtxtMail = new MetroFramework.Controls.MetroTextBox();
            this.mtxtTradeRegistryNo = new MetroFramework.Controls.MetroTextBox();
            this.mtxtIban = new MetroFramework.Controls.MetroTextBox();
            this.mlblGivenCompanyId = new MetroFramework.Controls.MetroLabel();
            this.pnlAuthorizedPersonGender = new System.Windows.Forms.Panel();
            this.mrdbtnFemale = new MetroFramework.Controls.MetroRadioButton();
            this.mrdbtnMale = new MetroFramework.Controls.MetroRadioButton();
            this.mtxtDetailTel = new System.Windows.Forms.MaskedTextBox();
            this.mdtimeCreateDate = new MetroFramework.Controls.MetroDateTime();
            this.mpDetailCompanyStatus = new MetroFramework.Controls.MetroPanel();
            this.mcboxDetailSupplier = new MetroFramework.Controls.MetroCheckBox();
            this.mcboxDetailCustomer = new MetroFramework.Controls.MetroCheckBox();
            this.mlblBalance = new MetroFramework.Controls.MetroLabel();
            this.mblGivenBalance = new MetroFramework.Controls.MetroLabel();
            this.btnGoFinancialTransaction = new System.Windows.Forms.Button();
            this.imglIcons = new System.Windows.Forms.ImageList(this.components);
            this.pnlCompanyGrid = new System.Windows.Forms.Panel();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.gbCompanies = new System.Windows.Forms.GroupBox();
            this.mdgCompanies = new MetroFramework.Controls.MetroGrid();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrintCachedCompanyInfo = new System.Windows.Forms.Button();
            this.btnUpdateCompany = new System.Windows.Forms.Button();
            this.tlp_SearchCompany = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearchCompany = new System.Windows.Forms.Button();
            this.tlpSeachCompanyFields = new System.Windows.Forms.TableLayoutPanel();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.mlblTitle = new MetroFramework.Controls.MetroLabel();
            this.mtlTel = new MetroFramework.Controls.MetroLabel();
            this.mtxtTitle = new MetroFramework.Controls.MetroTextBox();
            this.mpBalanceStatus = new MetroFramework.Controls.MetroPanel();
            this.mpIsActive = new MetroFramework.Controls.MetroPanel();
            this.mcboxPassive = new MetroFramework.Controls.MetroCheckBox();
            this.mcboxActive = new MetroFramework.Controls.MetroCheckBox();
            this.mpCompanyType = new MetroFramework.Controls.MetroPanel();
            this.mcboxSupplier = new MetroFramework.Controls.MetroCheckBox();
            this.mcboxCustomer = new MetroFramework.Controls.MetroCheckBox();
            this.mlblCompanyType = new MetroFramework.Controls.MetroLabel();
            this.mlblIsActive = new MetroFramework.Controls.MetroLabel();
            this.btnBringAllCompany = new System.Windows.Forms.Button();
            this.mtpProducts = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlStock = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.gbProduct = new System.Windows.Forms.GroupBox();
            this.mdgProducts = new MetroFramework.Controls.MetroGrid();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtxtSearchProductName = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.mcbSearchRunOut = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnBringAllStock = new System.Windows.Forms.Button();
            this.mtpInvoice = new MetroFramework.Controls.MetroTabPage();
            this.mtpFinancialOperations = new MetroFramework.Controls.MetroTabPage();
            this.mtpServices = new MetroFramework.Controls.MetroTabPage();
            this.mlbl_Username = new MetroFramework.Controls.MetroLabel();
            this.tlpUsername = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMain.SuspendLayout();
            this.mtcMain.SuspendLayout();
            this.mtpMain.SuspendLayout();
            this.mtpCompanies.SuspendLayout();
            this.tlpCompanies.SuspendLayout();
            this.tlpCompanyDetails.SuspendLayout();
            this.gbCompanyDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlDetailCompanyStates.SuspendLayout();
            this.pnlAuthorizedPersonGender.SuspendLayout();
            this.mpDetailCompanyStatus.SuspendLayout();
            this.pnlCompanyGrid.SuspendLayout();
            this.gbCompanies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgCompanies)).BeginInit();
            this.tlpButtons.SuspendLayout();
            this.tlp_SearchCompany.SuspendLayout();
            this.tlpSeachCompanyFields.SuspendLayout();
            this.mpBalanceStatus.SuspendLayout();
            this.mpIsActive.SuspendLayout();
            this.mpCompanyType.SuspendLayout();
            this.mtpProducts.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.pnlStock.SuspendLayout();
            this.gbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgProducts)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.tlpUsername.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.mtcMain, 0, 0);
            this.tlpMain.Location = new System.Drawing.Point(20, 60);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(936, 615);
            this.tlpMain.TabIndex = 0;
            // 
            // mtcMain
            // 
            this.mtcMain.Controls.Add(this.mtpMain);
            this.mtcMain.Controls.Add(this.mtpCompanies);
            this.mtcMain.Controls.Add(this.mtpProducts);
            this.mtcMain.Controls.Add(this.mtpInvoice);
            this.mtcMain.Controls.Add(this.mtpFinancialOperations);
            this.mtcMain.Controls.Add(this.mtpServices);
            this.mtcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtcMain.HotTrack = true;
            this.mtcMain.Location = new System.Drawing.Point(3, 3);
            this.mtcMain.Name = "mtcMain";
            this.mtcMain.SelectedIndex = 1;
            this.mtcMain.Size = new System.Drawing.Size(930, 609);
            this.mtcMain.TabIndex = 3;
            this.mtcMain.UseSelectable = true;
            // 
            // mtpMain
            // 
            this.mtpMain.Controls.Add(this.metroLabel1);
            this.mtpMain.HorizontalScrollbarBarColor = true;
            this.mtpMain.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpMain.HorizontalScrollbarSize = 10;
            this.mtpMain.Location = new System.Drawing.Point(4, 38);
            this.mtpMain.Name = "mtpMain";
            this.mtpMain.Size = new System.Drawing.Size(922, 567);
            this.mtpMain.TabIndex = 0;
            this.mtpMain.Text = "Genel Durum";
            this.mtpMain.VerticalScrollbarBarColor = true;
            this.mtpMain.VerticalScrollbarHighlightOnWheel = false;
            this.mtpMain.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(57, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // mtpCompanies
            // 
            this.mtpCompanies.Controls.Add(this.tlpCompanies);
            this.mtpCompanies.HorizontalScrollbarBarColor = true;
            this.mtpCompanies.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpCompanies.HorizontalScrollbarSize = 10;
            this.mtpCompanies.Location = new System.Drawing.Point(4, 38);
            this.mtpCompanies.Name = "mtpCompanies";
            this.mtpCompanies.Size = new System.Drawing.Size(922, 567);
            this.mtpCompanies.TabIndex = 1;
            this.mtpCompanies.Text = "Firmalar";
            this.mtpCompanies.VerticalScrollbarBarColor = true;
            this.mtpCompanies.VerticalScrollbarHighlightOnWheel = false;
            this.mtpCompanies.VerticalScrollbarSize = 10;
            // 
            // tlpCompanies
            // 
            this.tlpCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCompanies.BackColor = System.Drawing.Color.White;
            this.tlpCompanies.ColumnCount = 1;
            this.tlpCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.53473F));
            this.tlpCompanies.Controls.Add(this.tlpCompanyDetails, 0, 1);
            this.tlpCompanies.Controls.Add(this.tlp_SearchCompany, 0, 0);
            this.tlpCompanies.Location = new System.Drawing.Point(0, 4);
            this.tlpCompanies.Name = "tlpCompanies";
            this.tlpCompanies.RowCount = 2;
            this.tlpCompanies.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.68327F));
            this.tlpCompanies.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.31673F));
            this.tlpCompanies.Size = new System.Drawing.Size(922, 562);
            this.tlpCompanies.TabIndex = 3;
            // 
            // tlpCompanyDetails
            // 
            this.tlpCompanyDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCompanyDetails.ColumnCount = 2;
            this.tlpCompanyDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.34101F));
            this.tlpCompanyDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.65899F));
            this.tlpCompanyDetails.Controls.Add(this.gbCompanyDetails, 1, 0);
            this.tlpCompanyDetails.Controls.Add(this.pnlCompanyGrid, 0, 0);
            this.tlpCompanyDetails.Controls.Add(this.tlpButtons, 1, 1);
            this.tlpCompanyDetails.Location = new System.Drawing.Point(3, 107);
            this.tlpCompanyDetails.Name = "tlpCompanyDetails";
            this.tlpCompanyDetails.RowCount = 2;
            this.tlpCompanyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCompanyDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpCompanyDetails.Size = new System.Drawing.Size(916, 452);
            this.tlpCompanyDetails.TabIndex = 6;
            // 
            // gbCompanyDetails
            // 
            this.gbCompanyDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCompanyDetails.Controls.Add(this.tableLayoutPanel1);
            this.gbCompanyDetails.Location = new System.Drawing.Point(262, 3);
            this.gbCompanyDetails.Name = "gbCompanyDetails";
            this.gbCompanyDetails.Size = new System.Drawing.Size(651, 397);
            this.gbCompanyDetails.TabIndex = 1;
            this.gbCompanyDetails.TabStop = false;
            this.gbCompanyDetails.Text = "Firma Detayları";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.49719F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.85127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.71163F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.93991F));
            this.tableLayoutPanel1.Controls.Add(this.pnlDetailCompanyStates, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.mtxtDetailFax, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.mlbCompanyDetailId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mlblDetailTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mlblAddressCity, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mlblAddressDistrict, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.mlblAddressNeighborhood, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.mlblAddressStreet, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.mlblAddressNo, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.mlblFloor, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.mlblTaxNo, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.mlblTaxAdministration, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.mlblAuthorizedPerson, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.mlblAuthorizedPersonGender, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.mlblTel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.mlblFax, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.mlblMail, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.mlblTradeRegistryNo, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.mlblCreateDate, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.mlblDetailIsActive, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblIban, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.mlblDetailCompanyStatus, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.mtxtDetailTitle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.mtxtCity, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.mtxtDistrict, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.mtxtNeighborhood, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.mtxtStreet, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.mtxtAdressNo, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.mtxtFloor, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.mtxtTaxNo, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.mtxtTaxAdministration, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.mtxtAuthorizedPerson, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.mtxtMail, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.mtxtTradeRegistryNo, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.mtxtIban, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.mlblGivenCompanyId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlAuthorizedPersonGender, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.mtxtDetailTel, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.mdtimeCreateDate, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.mpDetailCompanyStatus, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.mlblBalance, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.mblGivenBalance, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.btnGoFinancialTransaction, 3, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(645, 378);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pnlDetailCompanyStates
            // 
            this.pnlDetailCompanyStates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetailCompanyStates.Controls.Add(this.mrdbtnPassive);
            this.pnlDetailCompanyStates.Controls.Add(this.mrdbtnActive);
            this.pnlDetailCompanyStates.Location = new System.Drawing.Point(409, 242);
            this.pnlDetailCompanyStates.Name = "pnlDetailCompanyStates";
            this.pnlDetailCompanyStates.Size = new System.Drawing.Size(233, 25);
            this.pnlDetailCompanyStates.TabIndex = 11;
            // 
            // mrdbtnPassive
            // 
            this.mrdbtnPassive.AutoSize = true;
            this.mrdbtnPassive.Location = new System.Drawing.Point(95, 7);
            this.mrdbtnPassive.Name = "mrdbtnPassive";
            this.mrdbtnPassive.Size = new System.Drawing.Size(57, 15);
            this.mrdbtnPassive.TabIndex = 0;
            this.mrdbtnPassive.Text = "Pasif   ";
            this.mrdbtnPassive.UseSelectable = true;
            // 
            // mrdbtnActive
            // 
            this.mrdbtnActive.AutoSize = true;
            this.mrdbtnActive.Location = new System.Drawing.Point(0, 7);
            this.mrdbtnActive.Name = "mrdbtnActive";
            this.mrdbtnActive.Size = new System.Drawing.Size(54, 15);
            this.mrdbtnActive.TabIndex = 0;
            this.mrdbtnActive.Text = "Aktif  ";
            this.mrdbtnActive.UseSelectable = true;
            // 
            // mtxtDetailFax
            // 
            this.mtxtDetailFax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtDetailFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDetailFax.Location = new System.Drawing.Point(409, 107);
            this.mtxtDetailFax.Mask = "(999) 000-0000";
            this.mtxtDetailFax.Name = "mtxtDetailFax";
            this.mtxtDetailFax.Size = new System.Drawing.Size(233, 24);
            this.mtxtDetailFax.TabIndex = 9;
            // 
            // mlbCompanyDetailId
            // 
            this.mlbCompanyDetailId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlbCompanyDetailId.AutoSize = true;
            this.mlbCompanyDetailId.Location = new System.Drawing.Point(3, 7);
            this.mlbCompanyDetailId.Name = "mlbCompanyDetailId";
            this.mlbCompanyDetailId.Size = new System.Drawing.Size(100, 19);
            this.mlbCompanyDetailId.TabIndex = 4;
            this.mlbCompanyDetailId.Text = "Firma No   :";
            // 
            // mlblDetailTitle
            // 
            this.mlblDetailTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblDetailTitle.AutoSize = true;
            this.mlblDetailTitle.Location = new System.Drawing.Point(3, 41);
            this.mlblDetailTitle.Name = "mlblDetailTitle";
            this.mlblDetailTitle.Size = new System.Drawing.Size(100, 19);
            this.mlblDetailTitle.TabIndex = 5;
            this.mlblDetailTitle.Text = "Ünvan        :";
            // 
            // mlblAddressCity
            // 
            this.mlblAddressCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblAddressCity.AutoSize = true;
            this.mlblAddressCity.Location = new System.Drawing.Point(3, 75);
            this.mlblAddressCity.Name = "mlblAddressCity";
            this.mlblAddressCity.Size = new System.Drawing.Size(100, 19);
            this.mlblAddressCity.TabIndex = 5;
            this.mlblAddressCity.Text = "İl                :";
            // 
            // mlblAddressDistrict
            // 
            this.mlblAddressDistrict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblAddressDistrict.AutoSize = true;
            this.mlblAddressDistrict.Location = new System.Drawing.Point(3, 109);
            this.mlblAddressDistrict.Name = "mlblAddressDistrict";
            this.mlblAddressDistrict.Size = new System.Drawing.Size(100, 19);
            this.mlblAddressDistrict.TabIndex = 5;
            this.mlblAddressDistrict.Text = "İlçe            :";
            // 
            // mlblAddressNeighborhood
            // 
            this.mlblAddressNeighborhood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblAddressNeighborhood.AutoSize = true;
            this.mlblAddressNeighborhood.Location = new System.Drawing.Point(3, 143);
            this.mlblAddressNeighborhood.Name = "mlblAddressNeighborhood";
            this.mlblAddressNeighborhood.Size = new System.Drawing.Size(100, 19);
            this.mlblAddressNeighborhood.TabIndex = 5;
            this.mlblAddressNeighborhood.Text = "Mahalle     :";
            // 
            // mlblAddressStreet
            // 
            this.mlblAddressStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblAddressStreet.AutoSize = true;
            this.mlblAddressStreet.Location = new System.Drawing.Point(3, 177);
            this.mlblAddressStreet.Name = "mlblAddressStreet";
            this.mlblAddressStreet.Size = new System.Drawing.Size(100, 19);
            this.mlblAddressStreet.TabIndex = 5;
            this.mlblAddressStreet.Text = "Sokak        :";
            // 
            // mlblAddressNo
            // 
            this.mlblAddressNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblAddressNo.AutoSize = true;
            this.mlblAddressNo.Location = new System.Drawing.Point(3, 211);
            this.mlblAddressNo.Name = "mlblAddressNo";
            this.mlblAddressNo.Size = new System.Drawing.Size(100, 19);
            this.mlblAddressNo.TabIndex = 5;
            this.mlblAddressNo.Text = "Kapı No     :";
            // 
            // mlblFloor
            // 
            this.mlblFloor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblFloor.AutoSize = true;
            this.mlblFloor.Location = new System.Drawing.Point(3, 245);
            this.mlblFloor.Name = "mlblFloor";
            this.mlblFloor.Size = new System.Drawing.Size(100, 19);
            this.mlblFloor.TabIndex = 5;
            this.mlblFloor.Text = "Kat            :";
            // 
            // mlblTaxNo
            // 
            this.mlblTaxNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblTaxNo.AutoSize = true;
            this.mlblTaxNo.Location = new System.Drawing.Point(3, 279);
            this.mlblTaxNo.Name = "mlblTaxNo";
            this.mlblTaxNo.Size = new System.Drawing.Size(100, 19);
            this.mlblTaxNo.TabIndex = 5;
            this.mlblTaxNo.Text = "Vergi No    :";
            // 
            // mlblTaxAdministration
            // 
            this.mlblTaxAdministration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblTaxAdministration.AutoSize = true;
            this.mlblTaxAdministration.Location = new System.Drawing.Point(3, 313);
            this.mlblTaxAdministration.Name = "mlblTaxAdministration";
            this.mlblTaxAdministration.Size = new System.Drawing.Size(100, 19);
            this.mlblTaxAdministration.TabIndex = 5;
            this.mlblTaxAdministration.Text = "Vergi Dairesi :";
            // 
            // mlblAuthorizedPerson
            // 
            this.mlblAuthorizedPerson.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblAuthorizedPerson.AutoSize = true;
            this.mlblAuthorizedPerson.Location = new System.Drawing.Point(282, 7);
            this.mlblAuthorizedPerson.Name = "mlblAuthorizedPerson";
            this.mlblAuthorizedPerson.Size = new System.Drawing.Size(74, 19);
            this.mlblAuthorizedPerson.TabIndex = 5;
            this.mlblAuthorizedPerson.Text = "Yetkili Kişi  :";
            // 
            // mlblAuthorizedPersonGender
            // 
            this.mlblAuthorizedPersonGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblAuthorizedPersonGender.AutoSize = true;
            this.mlblAuthorizedPersonGender.Location = new System.Drawing.Point(282, 41);
            this.mlblAuthorizedPersonGender.Name = "mlblAuthorizedPersonGender";
            this.mlblAuthorizedPersonGender.Size = new System.Drawing.Size(76, 19);
            this.mlblAuthorizedPersonGender.TabIndex = 5;
            this.mlblAuthorizedPersonGender.Text = "Cinsiyet     :";
            // 
            // mlblTel
            // 
            this.mlblTel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblTel.AutoSize = true;
            this.mlblTel.Location = new System.Drawing.Point(282, 75);
            this.mlblTel.Name = "mlblTel";
            this.mlblTel.Size = new System.Drawing.Size(79, 19);
            this.mlblTel.TabIndex = 5;
            this.mlblTel.Text = "Tel             :";
            // 
            // mlblFax
            // 
            this.mlblFax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblFax.AutoSize = true;
            this.mlblFax.Location = new System.Drawing.Point(282, 109);
            this.mlblFax.Name = "mlblFax";
            this.mlblFax.Size = new System.Drawing.Size(79, 19);
            this.mlblFax.TabIndex = 5;
            this.mlblFax.Text = "Fax            :";
            // 
            // mlblMail
            // 
            this.mlblMail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblMail.AutoSize = true;
            this.mlblMail.Location = new System.Drawing.Point(282, 143);
            this.mlblMail.Name = "mlblMail";
            this.mlblMail.Size = new System.Drawing.Size(81, 19);
            this.mlblMail.TabIndex = 5;
            this.mlblMail.Text = "Mail           :";
            // 
            // mlblTradeRegistryNo
            // 
            this.mlblTradeRegistryNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblTradeRegistryNo.AutoSize = true;
            this.mlblTradeRegistryNo.Location = new System.Drawing.Point(282, 177);
            this.mlblTradeRegistryNo.Name = "mlblTradeRegistryNo";
            this.mlblTradeRegistryNo.Size = new System.Drawing.Size(107, 19);
            this.mlblTradeRegistryNo.TabIndex = 5;
            this.mlblTradeRegistryNo.Text = "Ticaret Sicil No : ";
            // 
            // mlblCreateDate
            // 
            this.mlblCreateDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblCreateDate.AutoSize = true;
            this.mlblCreateDate.Location = new System.Drawing.Point(282, 211);
            this.mlblCreateDate.Name = "mlblCreateDate";
            this.mlblCreateDate.Size = new System.Drawing.Size(101, 19);
            this.mlblCreateDate.TabIndex = 5;
            this.mlblCreateDate.Text = "Kayıt Tarihi       :";
            // 
            // mlblDetailIsActive
            // 
            this.mlblDetailIsActive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblDetailIsActive.AutoSize = true;
            this.mlblDetailIsActive.Location = new System.Drawing.Point(282, 245);
            this.mlblDetailIsActive.Name = "mlblDetailIsActive";
            this.mlblDetailIsActive.Size = new System.Drawing.Size(113, 19);
            this.mlblDetailIsActive.TabIndex = 5;
            this.mlblDetailIsActive.Text = "Kurum Durumu   :";
            // 
            // lblIban
            // 
            this.lblIban.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIban.AutoSize = true;
            this.lblIban.Location = new System.Drawing.Point(282, 279);
            this.lblIban.Name = "lblIban";
            this.lblIban.Size = new System.Drawing.Size(103, 19);
            this.lblIban.TabIndex = 5;
            this.lblIban.Text = "Iban  No          :";
            // 
            // mlblDetailCompanyStatus
            // 
            this.mlblDetailCompanyStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblDetailCompanyStatus.AutoSize = true;
            this.mlblDetailCompanyStatus.Location = new System.Drawing.Point(282, 313);
            this.mlblDetailCompanyStatus.Name = "mlblDetailCompanyStatus";
            this.mlblDetailCompanyStatus.Size = new System.Drawing.Size(87, 19);
            this.mlblDetailCompanyStatus.TabIndex = 5;
            this.mlblDetailCompanyStatus.Text = "Kurum Tipi   :";
            // 
            // mtxtDetailTitle
            // 
            this.mtxtDetailTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtDetailTitle.CustomButton.Image = null;
            this.mtxtDetailTitle.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.mtxtDetailTitle.CustomButton.Name = "";
            this.mtxtDetailTitle.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtDetailTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtDetailTitle.CustomButton.TabIndex = 1;
            this.mtxtDetailTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtDetailTitle.CustomButton.UseSelectable = true;
            this.mtxtDetailTitle.CustomButton.Visible = false;
            this.mtxtDetailTitle.Lines = new string[0];
            this.mtxtDetailTitle.Location = new System.Drawing.Point(109, 38);
            this.mtxtDetailTitle.MaxLength = 32767;
            this.mtxtDetailTitle.Name = "mtxtDetailTitle";
            this.mtxtDetailTitle.PasswordChar = '\0';
            this.mtxtDetailTitle.PromptText = "Örn. Cimri Yazılım A.Ş";
            this.mtxtDetailTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtDetailTitle.SelectedText = "";
            this.mtxtDetailTitle.SelectionLength = 0;
            this.mtxtDetailTitle.SelectionStart = 0;
            this.mtxtDetailTitle.ShortcutsEnabled = true;
            this.mtxtDetailTitle.Size = new System.Drawing.Size(167, 25);
            this.mtxtDetailTitle.TabIndex = 6;
            this.mtxtDetailTitle.UseSelectable = true;
            this.mtxtDetailTitle.WaterMark = "Örn. Cimri Yazılım A.Ş";
            this.mtxtDetailTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtDetailTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtCity
            // 
            this.mtxtCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtCity.CustomButton.Image = null;
            this.mtxtCity.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.mtxtCity.CustomButton.Name = "";
            this.mtxtCity.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtCity.CustomButton.TabIndex = 1;
            this.mtxtCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtCity.CustomButton.UseSelectable = true;
            this.mtxtCity.CustomButton.Visible = false;
            this.mtxtCity.Lines = new string[0];
            this.mtxtCity.Location = new System.Drawing.Point(109, 72);
            this.mtxtCity.MaxLength = 32767;
            this.mtxtCity.Name = "mtxtCity";
            this.mtxtCity.PasswordChar = '\0';
            this.mtxtCity.PromptText = "Örn. İstanbul";
            this.mtxtCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCity.SelectedText = "";
            this.mtxtCity.SelectionLength = 0;
            this.mtxtCity.SelectionStart = 0;
            this.mtxtCity.ShortcutsEnabled = true;
            this.mtxtCity.Size = new System.Drawing.Size(167, 25);
            this.mtxtCity.TabIndex = 6;
            this.mtxtCity.UseSelectable = true;
            this.mtxtCity.WaterMark = "Örn. İstanbul";
            this.mtxtCity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtCity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtDistrict
            // 
            this.mtxtDistrict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtDistrict.CustomButton.Image = null;
            this.mtxtDistrict.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.mtxtDistrict.CustomButton.Name = "";
            this.mtxtDistrict.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtDistrict.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtDistrict.CustomButton.TabIndex = 1;
            this.mtxtDistrict.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtDistrict.CustomButton.UseSelectable = true;
            this.mtxtDistrict.CustomButton.Visible = false;
            this.mtxtDistrict.Lines = new string[0];
            this.mtxtDistrict.Location = new System.Drawing.Point(109, 106);
            this.mtxtDistrict.MaxLength = 32767;
            this.mtxtDistrict.Name = "mtxtDistrict";
            this.mtxtDistrict.PasswordChar = '\0';
            this.mtxtDistrict.PromptText = "Örn. Kadıköy";
            this.mtxtDistrict.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtDistrict.SelectedText = "";
            this.mtxtDistrict.SelectionLength = 0;
            this.mtxtDistrict.SelectionStart = 0;
            this.mtxtDistrict.ShortcutsEnabled = true;
            this.mtxtDistrict.Size = new System.Drawing.Size(167, 25);
            this.mtxtDistrict.TabIndex = 6;
            this.mtxtDistrict.UseSelectable = true;
            this.mtxtDistrict.WaterMark = "Örn. Kadıköy";
            this.mtxtDistrict.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtDistrict.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtNeighborhood
            // 
            this.mtxtNeighborhood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtNeighborhood.CustomButton.Image = null;
            this.mtxtNeighborhood.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.mtxtNeighborhood.CustomButton.Name = "";
            this.mtxtNeighborhood.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtNeighborhood.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtNeighborhood.CustomButton.TabIndex = 1;
            this.mtxtNeighborhood.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtNeighborhood.CustomButton.UseSelectable = true;
            this.mtxtNeighborhood.CustomButton.Visible = false;
            this.mtxtNeighborhood.Lines = new string[0];
            this.mtxtNeighborhood.Location = new System.Drawing.Point(109, 140);
            this.mtxtNeighborhood.MaxLength = 32767;
            this.mtxtNeighborhood.Name = "mtxtNeighborhood";
            this.mtxtNeighborhood.PasswordChar = '\0';
            this.mtxtNeighborhood.PromptText = "Örn. İnönü mah.";
            this.mtxtNeighborhood.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtNeighborhood.SelectedText = "";
            this.mtxtNeighborhood.SelectionLength = 0;
            this.mtxtNeighborhood.SelectionStart = 0;
            this.mtxtNeighborhood.ShortcutsEnabled = true;
            this.mtxtNeighborhood.Size = new System.Drawing.Size(167, 25);
            this.mtxtNeighborhood.TabIndex = 6;
            this.mtxtNeighborhood.UseSelectable = true;
            this.mtxtNeighborhood.WaterMark = "Örn. İnönü mah.";
            this.mtxtNeighborhood.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtNeighborhood.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtStreet
            // 
            this.mtxtStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtStreet.CustomButton.Image = null;
            this.mtxtStreet.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.mtxtStreet.CustomButton.Name = "";
            this.mtxtStreet.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtStreet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtStreet.CustomButton.TabIndex = 1;
            this.mtxtStreet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtStreet.CustomButton.UseSelectable = true;
            this.mtxtStreet.CustomButton.Visible = false;
            this.mtxtStreet.Lines = new string[0];
            this.mtxtStreet.Location = new System.Drawing.Point(109, 174);
            this.mtxtStreet.MaxLength = 32767;
            this.mtxtStreet.Name = "mtxtStreet";
            this.mtxtStreet.PasswordChar = '\0';
            this.mtxtStreet.PromptText = "Yalçınlar sok.";
            this.mtxtStreet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtStreet.SelectedText = "";
            this.mtxtStreet.SelectionLength = 0;
            this.mtxtStreet.SelectionStart = 0;
            this.mtxtStreet.ShortcutsEnabled = true;
            this.mtxtStreet.Size = new System.Drawing.Size(167, 25);
            this.mtxtStreet.TabIndex = 6;
            this.mtxtStreet.UseSelectable = true;
            this.mtxtStreet.WaterMark = "Yalçınlar sok.";
            this.mtxtStreet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtStreet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtAdressNo
            // 
            this.mtxtAdressNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtAdressNo.CustomButton.Image = null;
            this.mtxtAdressNo.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.mtxtAdressNo.CustomButton.Name = "";
            this.mtxtAdressNo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtAdressNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtAdressNo.CustomButton.TabIndex = 1;
            this.mtxtAdressNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtAdressNo.CustomButton.UseSelectable = true;
            this.mtxtAdressNo.CustomButton.Visible = false;
            this.mtxtAdressNo.Lines = new string[0];
            this.mtxtAdressNo.Location = new System.Drawing.Point(109, 208);
            this.mtxtAdressNo.MaxLength = 32767;
            this.mtxtAdressNo.Name = "mtxtAdressNo";
            this.mtxtAdressNo.PasswordChar = '\0';
            this.mtxtAdressNo.PromptText = "Örn. 38/B veya 17";
            this.mtxtAdressNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtAdressNo.SelectedText = "";
            this.mtxtAdressNo.SelectionLength = 0;
            this.mtxtAdressNo.SelectionStart = 0;
            this.mtxtAdressNo.ShortcutsEnabled = true;
            this.mtxtAdressNo.Size = new System.Drawing.Size(167, 25);
            this.mtxtAdressNo.TabIndex = 6;
            this.mtxtAdressNo.UseSelectable = true;
            this.mtxtAdressNo.WaterMark = "Örn. 38/B veya 17";
            this.mtxtAdressNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtAdressNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtFloor
            // 
            this.mtxtFloor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtFloor.CustomButton.Image = null;
            this.mtxtFloor.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.mtxtFloor.CustomButton.Name = "";
            this.mtxtFloor.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtFloor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtFloor.CustomButton.TabIndex = 1;
            this.mtxtFloor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtFloor.CustomButton.UseSelectable = true;
            this.mtxtFloor.CustomButton.Visible = false;
            this.mtxtFloor.Lines = new string[0];
            this.mtxtFloor.Location = new System.Drawing.Point(109, 242);
            this.mtxtFloor.MaxLength = 32767;
            this.mtxtFloor.Name = "mtxtFloor";
            this.mtxtFloor.PasswordChar = '\0';
            this.mtxtFloor.PromptText = "Örn. 2.Kat";
            this.mtxtFloor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtFloor.SelectedText = "";
            this.mtxtFloor.SelectionLength = 0;
            this.mtxtFloor.SelectionStart = 0;
            this.mtxtFloor.ShortcutsEnabled = true;
            this.mtxtFloor.Size = new System.Drawing.Size(167, 25);
            this.mtxtFloor.TabIndex = 6;
            this.mtxtFloor.UseSelectable = true;
            this.mtxtFloor.WaterMark = "Örn. 2.Kat";
            this.mtxtFloor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtFloor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtTaxNo
            // 
            this.mtxtTaxNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtTaxNo.CustomButton.Image = null;
            this.mtxtTaxNo.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.mtxtTaxNo.CustomButton.Name = "";
            this.mtxtTaxNo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtTaxNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtTaxNo.CustomButton.TabIndex = 1;
            this.mtxtTaxNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtTaxNo.CustomButton.UseSelectable = true;
            this.mtxtTaxNo.CustomButton.Visible = false;
            this.mtxtTaxNo.Lines = new string[0];
            this.mtxtTaxNo.Location = new System.Drawing.Point(109, 276);
            this.mtxtTaxNo.MaxLength = 11;
            this.mtxtTaxNo.Name = "mtxtTaxNo";
            this.mtxtTaxNo.PasswordChar = '\0';
            this.mtxtTaxNo.PromptText = "Örn. 4780163831";
            this.mtxtTaxNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtTaxNo.SelectedText = "";
            this.mtxtTaxNo.SelectionLength = 0;
            this.mtxtTaxNo.SelectionStart = 0;
            this.mtxtTaxNo.ShortcutsEnabled = true;
            this.mtxtTaxNo.Size = new System.Drawing.Size(167, 25);
            this.mtxtTaxNo.TabIndex = 6;
            this.mtxtTaxNo.UseSelectable = true;
            this.mtxtTaxNo.WaterMark = "Örn. 4780163831";
            this.mtxtTaxNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtTaxNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtTaxNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtTaxNo_KeyPress);
            // 
            // mtxtTaxAdministration
            // 
            this.mtxtTaxAdministration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtTaxAdministration.CustomButton.Image = null;
            this.mtxtTaxAdministration.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.mtxtTaxAdministration.CustomButton.Name = "";
            this.mtxtTaxAdministration.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtTaxAdministration.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtTaxAdministration.CustomButton.TabIndex = 1;
            this.mtxtTaxAdministration.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtTaxAdministration.CustomButton.UseSelectable = true;
            this.mtxtTaxAdministration.CustomButton.Visible = false;
            this.mtxtTaxAdministration.Lines = new string[0];
            this.mtxtTaxAdministration.Location = new System.Drawing.Point(109, 310);
            this.mtxtTaxAdministration.MaxLength = 32767;
            this.mtxtTaxAdministration.Name = "mtxtTaxAdministration";
            this.mtxtTaxAdministration.PasswordChar = '\0';
            this.mtxtTaxAdministration.PromptText = "Örn. Üsküdar";
            this.mtxtTaxAdministration.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtTaxAdministration.SelectedText = "";
            this.mtxtTaxAdministration.SelectionLength = 0;
            this.mtxtTaxAdministration.SelectionStart = 0;
            this.mtxtTaxAdministration.ShortcutsEnabled = true;
            this.mtxtTaxAdministration.Size = new System.Drawing.Size(167, 25);
            this.mtxtTaxAdministration.TabIndex = 6;
            this.mtxtTaxAdministration.UseSelectable = true;
            this.mtxtTaxAdministration.WaterMark = "Örn. Üsküdar";
            this.mtxtTaxAdministration.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtTaxAdministration.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtAuthorizedPerson
            // 
            this.mtxtAuthorizedPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtAuthorizedPerson.CustomButton.Image = null;
            this.mtxtAuthorizedPerson.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.mtxtAuthorizedPerson.CustomButton.Name = "";
            this.mtxtAuthorizedPerson.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtAuthorizedPerson.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtAuthorizedPerson.CustomButton.TabIndex = 1;
            this.mtxtAuthorizedPerson.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtAuthorizedPerson.CustomButton.UseSelectable = true;
            this.mtxtAuthorizedPerson.CustomButton.Visible = false;
            this.mtxtAuthorizedPerson.Lines = new string[0];
            this.mtxtAuthorizedPerson.Location = new System.Drawing.Point(409, 4);
            this.mtxtAuthorizedPerson.MaxLength = 32767;
            this.mtxtAuthorizedPerson.Name = "mtxtAuthorizedPerson";
            this.mtxtAuthorizedPerson.PasswordChar = '\0';
            this.mtxtAuthorizedPerson.PromptText = "Örn. Sibel Yıldız";
            this.mtxtAuthorizedPerson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtAuthorizedPerson.SelectedText = "";
            this.mtxtAuthorizedPerson.SelectionLength = 0;
            this.mtxtAuthorizedPerson.SelectionStart = 0;
            this.mtxtAuthorizedPerson.ShortcutsEnabled = true;
            this.mtxtAuthorizedPerson.Size = new System.Drawing.Size(233, 25);
            this.mtxtAuthorizedPerson.TabIndex = 6;
            this.mtxtAuthorizedPerson.UseSelectable = true;
            this.mtxtAuthorizedPerson.WaterMark = "Örn. Sibel Yıldız";
            this.mtxtAuthorizedPerson.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtAuthorizedPerson.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtMail
            // 
            this.mtxtMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtMail.CustomButton.Image = null;
            this.mtxtMail.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.mtxtMail.CustomButton.Name = "";
            this.mtxtMail.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtMail.CustomButton.TabIndex = 1;
            this.mtxtMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtMail.CustomButton.UseSelectable = true;
            this.mtxtMail.CustomButton.Visible = false;
            this.mtxtMail.Lines = new string[0];
            this.mtxtMail.Location = new System.Drawing.Point(409, 140);
            this.mtxtMail.MaxLength = 32767;
            this.mtxtMail.Name = "mtxtMail";
            this.mtxtMail.PasswordChar = '\0';
            this.mtxtMail.PromptText = "Örn. info@sirket.com";
            this.mtxtMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtMail.SelectedText = "";
            this.mtxtMail.SelectionLength = 0;
            this.mtxtMail.SelectionStart = 0;
            this.mtxtMail.ShortcutsEnabled = true;
            this.mtxtMail.Size = new System.Drawing.Size(233, 25);
            this.mtxtMail.TabIndex = 6;
            this.mtxtMail.UseSelectable = true;
            this.mtxtMail.WaterMark = "Örn. info@sirket.com";
            this.mtxtMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtTradeRegistryNo
            // 
            this.mtxtTradeRegistryNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtTradeRegistryNo.CustomButton.Image = null;
            this.mtxtTradeRegistryNo.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.mtxtTradeRegistryNo.CustomButton.Name = "";
            this.mtxtTradeRegistryNo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtTradeRegistryNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtTradeRegistryNo.CustomButton.TabIndex = 1;
            this.mtxtTradeRegistryNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtTradeRegistryNo.CustomButton.UseSelectable = true;
            this.mtxtTradeRegistryNo.CustomButton.Visible = false;
            this.mtxtTradeRegistryNo.Lines = new string[0];
            this.mtxtTradeRegistryNo.Location = new System.Drawing.Point(409, 174);
            this.mtxtTradeRegistryNo.MaxLength = 32767;
            this.mtxtTradeRegistryNo.Name = "mtxtTradeRegistryNo";
            this.mtxtTradeRegistryNo.PasswordChar = '\0';
            this.mtxtTradeRegistryNo.PromptText = "Örn. 12345678912";
            this.mtxtTradeRegistryNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtTradeRegistryNo.SelectedText = "";
            this.mtxtTradeRegistryNo.SelectionLength = 0;
            this.mtxtTradeRegistryNo.SelectionStart = 0;
            this.mtxtTradeRegistryNo.ShortcutsEnabled = true;
            this.mtxtTradeRegistryNo.Size = new System.Drawing.Size(233, 25);
            this.mtxtTradeRegistryNo.TabIndex = 6;
            this.mtxtTradeRegistryNo.UseSelectable = true;
            this.mtxtTradeRegistryNo.WaterMark = "Örn. 12345678912";
            this.mtxtTradeRegistryNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtTradeRegistryNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtTradeRegistryNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtTradeRegistryNo_KeyPress);
            // 
            // mtxtIban
            // 
            this.mtxtIban.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtIban.CustomButton.Image = null;
            this.mtxtIban.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.mtxtIban.CustomButton.Name = "";
            this.mtxtIban.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtIban.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtIban.CustomButton.TabIndex = 1;
            this.mtxtIban.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtIban.CustomButton.UseSelectable = true;
            this.mtxtIban.CustomButton.Visible = false;
            this.mtxtIban.Lines = new string[0];
            this.mtxtIban.Location = new System.Drawing.Point(409, 276);
            this.mtxtIban.MaxLength = 32767;
            this.mtxtIban.Name = "mtxtIban";
            this.mtxtIban.PasswordChar = '\0';
            this.mtxtIban.PromptText = "Örn. TR56 0006 2000 0001 2990 0226 04";
            this.mtxtIban.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtIban.SelectedText = "";
            this.mtxtIban.SelectionLength = 0;
            this.mtxtIban.SelectionStart = 0;
            this.mtxtIban.ShortcutsEnabled = true;
            this.mtxtIban.Size = new System.Drawing.Size(233, 25);
            this.mtxtIban.TabIndex = 6;
            this.mtxtIban.UseSelectable = true;
            this.mtxtIban.WaterMark = "Örn. TR56 0006 2000 0001 2990 0226 04";
            this.mtxtIban.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtIban.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblGivenCompanyId
            // 
            this.mlblGivenCompanyId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblGivenCompanyId.AutoSize = true;
            this.mlblGivenCompanyId.Location = new System.Drawing.Point(109, 7);
            this.mlblGivenCompanyId.Name = "mlblGivenCompanyId";
            this.mlblGivenCompanyId.Size = new System.Drawing.Size(167, 19);
            this.mlblGivenCompanyId.TabIndex = 4;
            this.mlblGivenCompanyId.Text = "CompanyId";
            // 
            // pnlAuthorizedPersonGender
            // 
            this.pnlAuthorizedPersonGender.Controls.Add(this.mrdbtnFemale);
            this.pnlAuthorizedPersonGender.Controls.Add(this.mrdbtnMale);
            this.pnlAuthorizedPersonGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAuthorizedPersonGender.Location = new System.Drawing.Point(409, 37);
            this.pnlAuthorizedPersonGender.Name = "pnlAuthorizedPersonGender";
            this.pnlAuthorizedPersonGender.Size = new System.Drawing.Size(233, 28);
            this.pnlAuthorizedPersonGender.TabIndex = 7;
            // 
            // mrdbtnFemale
            // 
            this.mrdbtnFemale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mrdbtnFemale.AutoSize = true;
            this.mrdbtnFemale.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mrdbtnFemale.Location = new System.Drawing.Point(95, 9);
            this.mrdbtnFemale.Name = "mrdbtnFemale";
            this.mrdbtnFemale.Size = new System.Drawing.Size(64, 15);
            this.mrdbtnFemale.TabIndex = 0;
            this.mrdbtnFemale.Text = "Bayan   ";
            this.mrdbtnFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mrdbtnFemale.UseSelectable = true;
            // 
            // mrdbtnMale
            // 
            this.mrdbtnMale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mrdbtnMale.AutoSize = true;
            this.mrdbtnMale.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mrdbtnMale.Location = new System.Drawing.Point(3, 9);
            this.mrdbtnMale.Name = "mrdbtnMale";
            this.mrdbtnMale.Size = new System.Drawing.Size(51, 15);
            this.mrdbtnMale.TabIndex = 0;
            this.mrdbtnMale.Text = "Bay   ";
            this.mrdbtnMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mrdbtnMale.UseSelectable = true;
            // 
            // mtxtDetailTel
            // 
            this.mtxtDetailTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtDetailTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDetailTel.Location = new System.Drawing.Point(409, 73);
            this.mtxtDetailTel.Mask = "(999) 000-0000";
            this.mtxtDetailTel.Name = "mtxtDetailTel";
            this.mtxtDetailTel.Size = new System.Drawing.Size(233, 24);
            this.mtxtDetailTel.TabIndex = 8;
            // 
            // mdtimeCreateDate
            // 
            this.mdtimeCreateDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mdtimeCreateDate.Location = new System.Drawing.Point(409, 207);
            this.mdtimeCreateDate.MinimumSize = new System.Drawing.Size(4, 29);
            this.mdtimeCreateDate.Name = "mdtimeCreateDate";
            this.mdtimeCreateDate.Size = new System.Drawing.Size(233, 29);
            this.mdtimeCreateDate.TabIndex = 10;
            // 
            // mpDetailCompanyStatus
            // 
            this.mpDetailCompanyStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpDetailCompanyStatus.Controls.Add(this.mcboxDetailSupplier);
            this.mpDetailCompanyStatus.Controls.Add(this.mcboxDetailCustomer);
            this.mpDetailCompanyStatus.HorizontalScrollbarBarColor = true;
            this.mpDetailCompanyStatus.HorizontalScrollbarHighlightOnWheel = false;
            this.mpDetailCompanyStatus.HorizontalScrollbarSize = 10;
            this.mpDetailCompanyStatus.Location = new System.Drawing.Point(409, 309);
            this.mpDetailCompanyStatus.Name = "mpDetailCompanyStatus";
            this.mpDetailCompanyStatus.Size = new System.Drawing.Size(233, 28);
            this.mpDetailCompanyStatus.TabIndex = 12;
            this.mpDetailCompanyStatus.VerticalScrollbarBarColor = true;
            this.mpDetailCompanyStatus.VerticalScrollbarHighlightOnWheel = false;
            this.mpDetailCompanyStatus.VerticalScrollbarSize = 10;
            // 
            // mcboxDetailSupplier
            // 
            this.mcboxDetailSupplier.AutoSize = true;
            this.mcboxDetailSupplier.Checked = true;
            this.mcboxDetailSupplier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mcboxDetailSupplier.Location = new System.Drawing.Point(107, 7);
            this.mcboxDetailSupplier.Name = "mcboxDetailSupplier";
            this.mcboxDetailSupplier.Size = new System.Drawing.Size(70, 15);
            this.mcboxDetailSupplier.TabIndex = 5;
            this.mcboxDetailSupplier.Text = "Tedarikçi";
            this.mcboxDetailSupplier.UseSelectable = true;
            // 
            // mcboxDetailCustomer
            // 
            this.mcboxDetailCustomer.AutoSize = true;
            this.mcboxDetailCustomer.Checked = true;
            this.mcboxDetailCustomer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mcboxDetailCustomer.Location = new System.Drawing.Point(0, 7);
            this.mcboxDetailCustomer.Name = "mcboxDetailCustomer";
            this.mcboxDetailCustomer.Size = new System.Drawing.Size(63, 15);
            this.mcboxDetailCustomer.TabIndex = 5;
            this.mcboxDetailCustomer.Text = "Müşteri";
            this.mcboxDetailCustomer.UseSelectable = true;
            // 
            // mlblBalance
            // 
            this.mlblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblBalance.AutoSize = true;
            this.mlblBalance.Location = new System.Drawing.Point(3, 349);
            this.mlblBalance.Name = "mlblBalance";
            this.mlblBalance.Size = new System.Drawing.Size(100, 19);
            this.mlblBalance.TabIndex = 4;
            this.mlblBalance.Text = "Bakiye          :";
            // 
            // mblGivenBalance
            // 
            this.mblGivenBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mblGivenBalance.AutoSize = true;
            this.mblGivenBalance.Location = new System.Drawing.Point(109, 349);
            this.mblGivenBalance.Name = "mblGivenBalance";
            this.mblGivenBalance.Size = new System.Drawing.Size(167, 19);
            this.mblGivenBalance.TabIndex = 4;
            this.mblGivenBalance.Text = "mlblBalance";
            // 
            // btnGoFinancialTransaction
            // 
            this.btnGoFinancialTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnGoFinancialTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoFinancialTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoFinancialTransaction.ImageKey = "finance.png";
            this.btnGoFinancialTransaction.ImageList = this.imglIcons;
            this.btnGoFinancialTransaction.Location = new System.Drawing.Point(433, 343);
            this.btnGoFinancialTransaction.Name = "btnGoFinancialTransaction";
            this.btnGoFinancialTransaction.Size = new System.Drawing.Size(184, 32);
            this.btnGoFinancialTransaction.TabIndex = 13;
            this.btnGoFinancialTransaction.Text = "Mali İşlemlere Git";
            this.btnGoFinancialTransaction.UseVisualStyleBackColor = true;
            // 
            // imglIcons
            // 
            this.imglIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglIcons.ImageStream")));
            this.imglIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imglIcons.Images.SetKeyName(0, "search.png");
            this.imglIcons.Images.SetKeyName(1, "AllData.png");
            this.imglIcons.Images.SetKeyName(2, "add.png");
            this.imglIcons.Images.SetKeyName(3, "update.png");
            this.imglIcons.Images.SetKeyName(4, "cancel.png");
            this.imglIcons.Images.SetKeyName(5, "finance.png");
            // 
            // pnlCompanyGrid
            // 
            this.pnlCompanyGrid.Controls.Add(this.btnAddCompany);
            this.pnlCompanyGrid.Controls.Add(this.gbCompanies);
            this.pnlCompanyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCompanyGrid.Location = new System.Drawing.Point(3, 3);
            this.pnlCompanyGrid.Name = "pnlCompanyGrid";
            this.pnlCompanyGrid.Size = new System.Drawing.Size(253, 397);
            this.pnlCompanyGrid.TabIndex = 2;
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCompany.ImageIndex = 2;
            this.btnAddCompany.ImageList = this.imglIcons;
            this.btnAddCompany.Location = new System.Drawing.Point(0, 0);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(253, 42);
            this.btnAddCompany.TabIndex = 6;
            this.btnAddCompany.Text = "Firma Ekle";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // gbCompanies
            // 
            this.gbCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCompanies.Controls.Add(this.mdgCompanies);
            this.gbCompanies.Location = new System.Drawing.Point(0, 48);
            this.gbCompanies.Name = "gbCompanies";
            this.gbCompanies.Size = new System.Drawing.Size(247, 346);
            this.gbCompanies.TabIndex = 0;
            this.gbCompanies.TabStop = false;
            this.gbCompanies.Text = "Firmalar";
            // 
            // mdgCompanies
            // 
            this.mdgCompanies.AllowUserToAddRows = false;
            this.mdgCompanies.AllowUserToDeleteRows = false;
            this.mdgCompanies.AllowUserToResizeRows = false;
            this.mdgCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mdgCompanies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mdgCompanies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mdgCompanies.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgCompanies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgCompanies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgCompanies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgCompanies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgCompanies.DefaultCellStyle = dataGridViewCellStyle2;
            this.mdgCompanies.EnableHeadersVisualStyles = false;
            this.mdgCompanies.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgCompanies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgCompanies.Location = new System.Drawing.Point(3, 16);
            this.mdgCompanies.MultiSelect = false;
            this.mdgCompanies.Name = "mdgCompanies";
            this.mdgCompanies.ReadOnly = true;
            this.mdgCompanies.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgCompanies.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mdgCompanies.RowHeadersVisible = false;
            this.mdgCompanies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mdgCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgCompanies.Size = new System.Drawing.Size(241, 327);
            this.mdgCompanies.TabIndex = 0;
            this.mdgCompanies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgdCompanies_CellClick);
            this.mdgCompanies.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mdgCompanies_KeyDown);
            this.mdgCompanies.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mdgCompanies_KeyUp);
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtons.Controls.Add(this.btnPrintCachedCompanyInfo, 0, 0);
            this.tlpButtons.Controls.Add(this.btnUpdateCompany, 1, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpButtons.Location = new System.Drawing.Point(262, 406);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(651, 43);
            this.tlpButtons.TabIndex = 14;
            // 
            // btnPrintCachedCompanyInfo
            // 
            this.btnPrintCachedCompanyInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPrintCachedCompanyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintCachedCompanyInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintCachedCompanyInfo.ImageKey = "cancel.png";
            this.btnPrintCachedCompanyInfo.ImageList = this.imglIcons;
            this.btnPrintCachedCompanyInfo.Location = new System.Drawing.Point(70, 3);
            this.btnPrintCachedCompanyInfo.Name = "btnPrintCachedCompanyInfo";
            this.btnPrintCachedCompanyInfo.Size = new System.Drawing.Size(184, 37);
            this.btnPrintCachedCompanyInfo.TabIndex = 13;
            this.btnPrintCachedCompanyInfo.Text = "Değişikliği Yok Say";
            this.btnPrintCachedCompanyInfo.UseVisualStyleBackColor = true;
            this.btnPrintCachedCompanyInfo.Click += new System.EventHandler(this.btnPrintCachedCompanyInfo_Click);
            // 
            // btnUpdateCompany
            // 
            this.btnUpdateCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnUpdateCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCompany.ImageKey = "update.png";
            this.btnUpdateCompany.ImageList = this.imglIcons;
            this.btnUpdateCompany.Location = new System.Drawing.Point(396, 3);
            this.btnUpdateCompany.Name = "btnUpdateCompany";
            this.btnUpdateCompany.Size = new System.Drawing.Size(184, 37);
            this.btnUpdateCompany.TabIndex = 13;
            this.btnUpdateCompany.Text = "Güncelle";
            this.btnUpdateCompany.UseVisualStyleBackColor = true;
            this.btnUpdateCompany.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // tlp_SearchCompany
            // 
            this.tlp_SearchCompany.ColumnCount = 3;
            this.tlp_SearchCompany.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.4977F));
            this.tlp_SearchCompany.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.52074F));
            this.tlp_SearchCompany.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.98157F));
            this.tlp_SearchCompany.Controls.Add(this.btnSearchCompany, 1, 0);
            this.tlp_SearchCompany.Controls.Add(this.tlpSeachCompanyFields, 0, 0);
            this.tlp_SearchCompany.Controls.Add(this.btnBringAllCompany, 2, 0);
            this.tlp_SearchCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_SearchCompany.Location = new System.Drawing.Point(3, 3);
            this.tlp_SearchCompany.Name = "tlp_SearchCompany";
            this.tlp_SearchCompany.RowCount = 1;
            this.tlp_SearchCompany.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_SearchCompany.Size = new System.Drawing.Size(916, 95);
            this.tlp_SearchCompany.TabIndex = 5;
            // 
            // btnSearchCompany
            // 
            this.btnSearchCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCompany.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearchCompany.ImageIndex = 0;
            this.btnSearchCompany.ImageList = this.imglIcons;
            this.btnSearchCompany.Location = new System.Drawing.Point(703, 3);
            this.btnSearchCompany.Name = "btnSearchCompany";
            this.btnSearchCompany.Size = new System.Drawing.Size(99, 89);
            this.btnSearchCompany.TabIndex = 5;
            this.btnSearchCompany.Text = "Ara";
            this.btnSearchCompany.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchCompany.UseVisualStyleBackColor = true;
            this.btnSearchCompany.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tlpSeachCompanyFields
            // 
            this.tlpSeachCompanyFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSeachCompanyFields.ColumnCount = 4;
            this.tlpSeachCompanyFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.36207F));
            this.tlpSeachCompanyFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.63793F));
            this.tlpSeachCompanyFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tlpSeachCompanyFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.tlpSeachCompanyFields.Controls.Add(this.mtxtTel, 0, 1);
            this.tlpSeachCompanyFields.Controls.Add(this.mlblTitle, 0, 0);
            this.tlpSeachCompanyFields.Controls.Add(this.mtlTel, 0, 1);
            this.tlpSeachCompanyFields.Controls.Add(this.mtxtTitle, 1, 0);
            this.tlpSeachCompanyFields.Controls.Add(this.mpBalanceStatus, 3, 1);
            this.tlpSeachCompanyFields.Controls.Add(this.mpCompanyType, 3, 0);
            this.tlpSeachCompanyFields.Controls.Add(this.mlblCompanyType, 2, 0);
            this.tlpSeachCompanyFields.Controls.Add(this.mlblIsActive, 2, 1);
            this.tlpSeachCompanyFields.Location = new System.Drawing.Point(3, 3);
            this.tlpSeachCompanyFields.Name = "tlpSeachCompanyFields";
            this.tlpSeachCompanyFields.RowCount = 2;
            this.tlpSeachCompanyFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSeachCompanyFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSeachCompanyFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSeachCompanyFields.Size = new System.Drawing.Size(694, 89);
            this.tlpSeachCompanyFields.TabIndex = 0;
            // 
            // mtxtTel
            // 
            this.mtxtTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTel.Location = new System.Drawing.Point(86, 54);
            this.mtxtTel.Mask = "(999) 000-0000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.Size = new System.Drawing.Size(127, 24);
            this.mtxtTel.TabIndex = 10;
            this.mtxtTel.TextChanged += new System.EventHandler(this.mtxtTel_TextChanged);
            // 
            // mlblTitle
            // 
            this.mlblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblTitle.AutoSize = true;
            this.mlblTitle.Location = new System.Drawing.Point(3, 12);
            this.mlblTitle.Name = "mlblTitle";
            this.mlblTitle.Size = new System.Drawing.Size(77, 19);
            this.mlblTitle.TabIndex = 3;
            this.mlblTitle.Text = "Ünvan        :";
            // 
            // mtlTel
            // 
            this.mtlTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlTel.AutoSize = true;
            this.mtlTel.Location = new System.Drawing.Point(3, 57);
            this.mtlTel.Name = "mtlTel";
            this.mtlTel.Size = new System.Drawing.Size(77, 19);
            this.mtlTel.TabIndex = 3;
            this.mtlTel.Text = "Telefon       :";
            // 
            // mtxtTitle
            // 
            this.mtxtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtTitle.CustomButton.Image = null;
            this.mtxtTitle.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.mtxtTitle.CustomButton.Name = "";
            this.mtxtTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtTitle.CustomButton.TabIndex = 1;
            this.mtxtTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtTitle.CustomButton.UseSelectable = true;
            this.mtxtTitle.CustomButton.Visible = false;
            this.mtxtTitle.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtxtTitle.Lines = new string[0];
            this.mtxtTitle.Location = new System.Drawing.Point(86, 10);
            this.mtxtTitle.MaxLength = 32767;
            this.mtxtTitle.Name = "mtxtTitle";
            this.mtxtTitle.PasswordChar = '\0';
            this.mtxtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtTitle.SelectedText = "";
            this.mtxtTitle.SelectionLength = 0;
            this.mtxtTitle.SelectionStart = 0;
            this.mtxtTitle.ShortcutsEnabled = true;
            this.mtxtTitle.Size = new System.Drawing.Size(127, 23);
            this.mtxtTitle.TabIndex = 4;
            this.mtxtTitle.UseSelectable = true;
            this.mtxtTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtTitle.TextChanged += new System.EventHandler(this.mtxtTitle_TextChanged);
            // 
            // mpBalanceStatus
            // 
            this.mpBalanceStatus.Controls.Add(this.mpIsActive);
            this.mpBalanceStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpBalanceStatus.HorizontalScrollbarBarColor = true;
            this.mpBalanceStatus.HorizontalScrollbarHighlightOnWheel = false;
            this.mpBalanceStatus.HorizontalScrollbarSize = 10;
            this.mpBalanceStatus.Location = new System.Drawing.Point(337, 47);
            this.mpBalanceStatus.Name = "mpBalanceStatus";
            this.mpBalanceStatus.Size = new System.Drawing.Size(354, 39);
            this.mpBalanceStatus.TabIndex = 7;
            this.mpBalanceStatus.VerticalScrollbarBarColor = true;
            this.mpBalanceStatus.VerticalScrollbarHighlightOnWheel = false;
            this.mpBalanceStatus.VerticalScrollbarSize = 10;
            // 
            // mpIsActive
            // 
            this.mpIsActive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpIsActive.Controls.Add(this.mcboxPassive);
            this.mpIsActive.Controls.Add(this.mcboxActive);
            this.mpIsActive.HorizontalScrollbarBarColor = true;
            this.mpIsActive.HorizontalScrollbarHighlightOnWheel = false;
            this.mpIsActive.HorizontalScrollbarSize = 10;
            this.mpIsActive.Location = new System.Drawing.Point(0, 3);
            this.mpIsActive.Name = "mpIsActive";
            this.mpIsActive.Size = new System.Drawing.Size(354, 41);
            this.mpIsActive.TabIndex = 10;
            this.mpIsActive.VerticalScrollbarBarColor = true;
            this.mpIsActive.VerticalScrollbarHighlightOnWheel = false;
            this.mpIsActive.VerticalScrollbarSize = 10;
            // 
            // mcboxPassive
            // 
            this.mcboxPassive.AutoSize = true;
            this.mcboxPassive.Location = new System.Drawing.Point(107, 7);
            this.mcboxPassive.Name = "mcboxPassive";
            this.mcboxPassive.Size = new System.Drawing.Size(48, 15);
            this.mcboxPassive.TabIndex = 5;
            this.mcboxPassive.Text = "Pasif";
            this.mcboxPassive.UseSelectable = true;
            this.mcboxPassive.CheckedChanged += new System.EventHandler(this.mcboxPassive_CheckedChanged);
            // 
            // mcboxActive
            // 
            this.mcboxActive.AutoSize = true;
            this.mcboxActive.Checked = true;
            this.mcboxActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mcboxActive.Location = new System.Drawing.Point(0, 7);
            this.mcboxActive.Name = "mcboxActive";
            this.mcboxActive.Size = new System.Drawing.Size(48, 15);
            this.mcboxActive.TabIndex = 5;
            this.mcboxActive.Text = "Aktif";
            this.mcboxActive.UseSelectable = true;
            this.mcboxActive.CheckedChanged += new System.EventHandler(this.mcboxActive_CheckedChanged);
            // 
            // mpCompanyType
            // 
            this.mpCompanyType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpCompanyType.Controls.Add(this.mcboxSupplier);
            this.mpCompanyType.Controls.Add(this.mcboxCustomer);
            this.mpCompanyType.HorizontalScrollbarBarColor = true;
            this.mpCompanyType.HorizontalScrollbarHighlightOnWheel = false;
            this.mpCompanyType.HorizontalScrollbarSize = 10;
            this.mpCompanyType.Location = new System.Drawing.Point(337, 3);
            this.mpCompanyType.Name = "mpCompanyType";
            this.mpCompanyType.Size = new System.Drawing.Size(354, 38);
            this.mpCompanyType.TabIndex = 8;
            this.mpCompanyType.VerticalScrollbarBarColor = true;
            this.mpCompanyType.VerticalScrollbarHighlightOnWheel = false;
            this.mpCompanyType.VerticalScrollbarSize = 10;
            // 
            // mcboxSupplier
            // 
            this.mcboxSupplier.AutoSize = true;
            this.mcboxSupplier.Checked = true;
            this.mcboxSupplier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mcboxSupplier.Location = new System.Drawing.Point(107, 7);
            this.mcboxSupplier.Name = "mcboxSupplier";
            this.mcboxSupplier.Size = new System.Drawing.Size(70, 15);
            this.mcboxSupplier.TabIndex = 5;
            this.mcboxSupplier.Text = "Tedarikçi";
            this.mcboxSupplier.UseSelectable = true;
            this.mcboxSupplier.CheckedChanged += new System.EventHandler(this.mcboxSupplier_CheckedChanged);
            // 
            // mcboxCustomer
            // 
            this.mcboxCustomer.AutoSize = true;
            this.mcboxCustomer.Checked = true;
            this.mcboxCustomer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mcboxCustomer.Location = new System.Drawing.Point(0, 7);
            this.mcboxCustomer.Name = "mcboxCustomer";
            this.mcboxCustomer.Size = new System.Drawing.Size(63, 15);
            this.mcboxCustomer.TabIndex = 5;
            this.mcboxCustomer.Text = "Müşteri";
            this.mcboxCustomer.UseSelectable = true;
            this.mcboxCustomer.CheckedChanged += new System.EventHandler(this.mcboxCustomer_CheckedChanged);
            // 
            // mlblCompanyType
            // 
            this.mlblCompanyType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblCompanyType.AutoSize = true;
            this.mlblCompanyType.Location = new System.Drawing.Point(219, 12);
            this.mlblCompanyType.Name = "mlblCompanyType";
            this.mlblCompanyType.Size = new System.Drawing.Size(83, 19);
            this.mlblCompanyType.TabIndex = 9;
            this.mlblCompanyType.Text = "Kurum Tipi  :";
            // 
            // mlblIsActive
            // 
            this.mlblIsActive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblIsActive.AutoSize = true;
            this.mlblIsActive.Location = new System.Drawing.Point(219, 57);
            this.mlblIsActive.Name = "mlblIsActive";
            this.mlblIsActive.Size = new System.Drawing.Size(109, 19);
            this.mlblIsActive.TabIndex = 9;
            this.mlblIsActive.Text = "Kurum Durumu  :";
            // 
            // btnBringAllCompany
            // 
            this.btnBringAllCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBringAllCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBringAllCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBringAllCompany.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBringAllCompany.ImageIndex = 1;
            this.btnBringAllCompany.ImageList = this.imglIcons;
            this.btnBringAllCompany.Location = new System.Drawing.Point(808, 3);
            this.btnBringAllCompany.Name = "btnBringAllCompany";
            this.btnBringAllCompany.Size = new System.Drawing.Size(105, 89);
            this.btnBringAllCompany.TabIndex = 5;
            this.btnBringAllCompany.Text = "Hepsini Getir";
            this.btnBringAllCompany.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBringAllCompany.UseVisualStyleBackColor = true;
            this.btnBringAllCompany.Click += new System.EventHandler(this.btnBringAll_Click);
            // 
            // mtpProducts
            // 
            this.mtpProducts.Controls.Add(this.tableLayoutPanel2);
            this.mtpProducts.HorizontalScrollbarBarColor = true;
            this.mtpProducts.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpProducts.HorizontalScrollbarSize = 10;
            this.mtpProducts.Location = new System.Drawing.Point(4, 38);
            this.mtpProducts.Name = "mtpProducts";
            this.mtpProducts.Size = new System.Drawing.Size(922, 567);
            this.mtpProducts.TabIndex = 4;
            this.mtpProducts.Text = "Ürünler";
            this.mtpProducts.ToolTipText = "denme";
            this.mtpProducts.VerticalScrollbarBarColor = true;
            this.mtpProducts.VerticalScrollbarHighlightOnWheel = false;
            this.mtpProducts.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.53473F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.16726F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.83274F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(922, 562);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.0917F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.90829F));
            this.tableLayoutPanel3.Controls.Add(this.pnlStock, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 77);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(916, 482);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // pnlStock
            // 
            this.pnlStock.Controls.Add(this.btnAddProduct);
            this.pnlStock.Controls.Add(this.gbProduct);
            this.pnlStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStock.Location = new System.Drawing.Point(3, 3);
            this.pnlStock.Name = "pnlStock";
            this.pnlStock.Size = new System.Drawing.Size(233, 427);
            this.pnlStock.TabIndex = 2;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.ImageIndex = 2;
            this.btnAddProduct.ImageList = this.imglIcons;
            this.btnAddProduct.Location = new System.Drawing.Point(0, 0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(233, 42);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.Text = "Stok Ekle";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // gbProduct
            // 
            this.gbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProduct.Controls.Add(this.mdgProducts);
            this.gbProduct.Location = new System.Drawing.Point(0, 48);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Size = new System.Drawing.Size(227, 376);
            this.gbProduct.TabIndex = 0;
            this.gbProduct.TabStop = false;
            this.gbProduct.Text = "Ürünler";
            // 
            // mdgProducts
            // 
            this.mdgProducts.AllowUserToAddRows = false;
            this.mdgProducts.AllowUserToDeleteRows = false;
            this.mdgProducts.AllowUserToResizeRows = false;
            this.mdgProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mdgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mdgProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mdgProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgProducts.DefaultCellStyle = dataGridViewCellStyle5;
            this.mdgProducts.EnableHeadersVisualStyles = false;
            this.mdgProducts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgProducts.Location = new System.Drawing.Point(3, 16);
            this.mdgProducts.MultiSelect = false;
            this.mdgProducts.Name = "mdgProducts";
            this.mdgProducts.ReadOnly = true;
            this.mdgProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mdgProducts.RowHeadersVisible = false;
            this.mdgProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mdgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgProducts.Size = new System.Drawing.Size(221, 357);
            this.mdgProducts.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.button4, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(242, 436);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(671, 43);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageKey = "cancel.png";
            this.button3.ImageList = this.imglIcons;
            this.button3.Location = new System.Drawing.Point(75, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 37);
            this.button3.TabIndex = 13;
            this.button3.Text = "İptal";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageKey = "update.png";
            this.button4.ImageList = this.imglIcons;
            this.button4.Location = new System.Drawing.Point(411, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 37);
            this.button4.TabIndex = 13;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(242, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 427);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firma Detayları";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.92139F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.28384F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.90393F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.button5, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnBringAllStock, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(916, 67);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.30131F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.69869F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tableLayoutPanel4.Controls.Add(this.metroLabel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.mtxtSearchProductName, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.metroPanel3, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.metroLabel4, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(606, 61);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 21);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Ürün Adı     :";
            // 
            // mtxtSearchProductName
            // 
            this.mtxtSearchProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtSearchProductName.CustomButton.Image = null;
            this.mtxtSearchProductName.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.mtxtSearchProductName.CustomButton.Name = "";
            this.mtxtSearchProductName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtSearchProductName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtSearchProductName.CustomButton.TabIndex = 1;
            this.mtxtSearchProductName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtSearchProductName.CustomButton.UseSelectable = true;
            this.mtxtSearchProductName.CustomButton.Visible = false;
            this.mtxtSearchProductName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtxtSearchProductName.Lines = new string[0];
            this.mtxtSearchProductName.Location = new System.Drawing.Point(90, 19);
            this.mtxtSearchProductName.MaxLength = 32767;
            this.mtxtSearchProductName.Name = "mtxtSearchProductName";
            this.mtxtSearchProductName.PasswordChar = '\0';
            this.mtxtSearchProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtSearchProductName.SelectedText = "";
            this.mtxtSearchProductName.SelectionLength = 0;
            this.mtxtSearchProductName.SelectionStart = 0;
            this.mtxtSearchProductName.ShortcutsEnabled = true;
            this.mtxtSearchProductName.Size = new System.Drawing.Size(129, 23);
            this.mtxtSearchProductName.TabIndex = 4;
            this.mtxtSearchProductName.UseSelectable = true;
            this.mtxtSearchProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtSearchProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel3.Controls.Add(this.metroCheckBox3);
            this.metroPanel3.Controls.Add(this.mcbSearchRunOut);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(318, 3);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(285, 55);
            this.metroPanel3.TabIndex = 8;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.AutoSize = true;
            this.metroCheckBox3.Checked = true;
            this.metroCheckBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBox3.Location = new System.Drawing.Point(118, 24);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(70, 15);
            this.metroCheckBox3.TabIndex = 5;
            this.metroCheckBox3.Text = "Tedarikçi";
            this.metroCheckBox3.UseSelectable = true;
            // 
            // mcbSearchRunOut
            // 
            this.mcbSearchRunOut.AutoSize = true;
            this.mcbSearchRunOut.Checked = true;
            this.mcbSearchRunOut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mcbSearchRunOut.Location = new System.Drawing.Point(12, 22);
            this.mcbSearchRunOut.Name = "mcbSearchRunOut";
            this.mcbSearchRunOut.Size = new System.Drawing.Size(63, 15);
            this.mcbSearchRunOut.TabIndex = 5;
            this.mcbSearchRunOut.Text = "Müşteri";
            this.mcbSearchRunOut.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(225, 21);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Kurum Tipi  :";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageIndex = 0;
            this.button5.ImageList = this.imglIcons;
            this.button5.Location = new System.Drawing.Point(615, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 61);
            this.button5.TabIndex = 5;
            this.button5.Text = "Ara";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnBringAllStock
            // 
            this.btnBringAllStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBringAllStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBringAllStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBringAllStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBringAllStock.ImageIndex = 1;
            this.btnBringAllStock.ImageList = this.imglIcons;
            this.btnBringAllStock.Location = new System.Drawing.Point(754, 3);
            this.btnBringAllStock.Name = "btnBringAllStock";
            this.btnBringAllStock.Size = new System.Drawing.Size(159, 61);
            this.btnBringAllStock.TabIndex = 5;
            this.btnBringAllStock.Text = "Hepsini\r\nGetir";
            this.btnBringAllStock.UseVisualStyleBackColor = true;
            this.btnBringAllStock.Click += new System.EventHandler(this.btnBringAllStock_Click);
            // 
            // mtpInvoice
            // 
            this.mtpInvoice.HorizontalScrollbarBarColor = true;
            this.mtpInvoice.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpInvoice.HorizontalScrollbarSize = 10;
            this.mtpInvoice.Location = new System.Drawing.Point(4, 38);
            this.mtpInvoice.Name = "mtpInvoice";
            this.mtpInvoice.Size = new System.Drawing.Size(922, 567);
            this.mtpInvoice.TabIndex = 3;
            this.mtpInvoice.Text = "Fatura";
            this.mtpInvoice.UseWaitCursor = true;
            this.mtpInvoice.VerticalScrollbarBarColor = true;
            this.mtpInvoice.VerticalScrollbarHighlightOnWheel = false;
            this.mtpInvoice.VerticalScrollbarSize = 10;
            // 
            // mtpFinancialOperations
            // 
            this.mtpFinancialOperations.HorizontalScrollbarBarColor = true;
            this.mtpFinancialOperations.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpFinancialOperations.HorizontalScrollbarSize = 10;
            this.mtpFinancialOperations.Location = new System.Drawing.Point(4, 38);
            this.mtpFinancialOperations.Name = "mtpFinancialOperations";
            this.mtpFinancialOperations.Size = new System.Drawing.Size(922, 567);
            this.mtpFinancialOperations.TabIndex = 2;
            this.mtpFinancialOperations.Text = "Mali İşlemler";
            this.mtpFinancialOperations.VerticalScrollbarBarColor = true;
            this.mtpFinancialOperations.VerticalScrollbarHighlightOnWheel = false;
            this.mtpFinancialOperations.VerticalScrollbarSize = 10;
            // 
            // mtpServices
            // 
            this.mtpServices.HorizontalScrollbarBarColor = true;
            this.mtpServices.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpServices.HorizontalScrollbarSize = 10;
            this.mtpServices.Location = new System.Drawing.Point(4, 38);
            this.mtpServices.Name = "mtpServices";
            this.mtpServices.Size = new System.Drawing.Size(922, 567);
            this.mtpServices.TabIndex = 5;
            this.mtpServices.Text = "Hizmetler";
            this.mtpServices.VerticalScrollbarBarColor = true;
            this.mtpServices.VerticalScrollbarHighlightOnWheel = false;
            this.mtpServices.VerticalScrollbarSize = 10;
            // 
            // mlbl_Username
            // 
            this.mlbl_Username.AutoSize = true;
            this.mlbl_Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlbl_Username.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlbl_Username.Location = new System.Drawing.Point(3, 0);
            this.mlbl_Username.Name = "mlbl_Username";
            this.mlbl_Username.Size = new System.Drawing.Size(194, 31);
            this.mlbl_Username.TabIndex = 1;
            this.mlbl_Username.Text = "usernameField";
            // 
            // tlpUsername
            // 
            this.tlpUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpUsername.ColumnCount = 1;
            this.tlpUsername.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUsername.Controls.Add(this.mlbl_Username, 0, 0);
            this.tlpUsername.Location = new System.Drawing.Point(756, 26);
            this.tlpUsername.Name = "tlpUsername";
            this.tlpUsername.RowCount = 1;
            this.tlpUsername.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUsername.Size = new System.Drawing.Size(200, 31);
            this.tlpUsername.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 695);
            this.Controls.Add(this.tlpUsername);
            this.Controls.Add(this.tlpMain);
            this.Name = "MainForm";
            this.Text = "Cimri | Anasayfa";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tlpMain.ResumeLayout(false);
            this.mtcMain.ResumeLayout(false);
            this.mtpMain.ResumeLayout(false);
            this.mtpMain.PerformLayout();
            this.mtpCompanies.ResumeLayout(false);
            this.tlpCompanies.ResumeLayout(false);
            this.tlpCompanyDetails.ResumeLayout(false);
            this.gbCompanyDetails.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlDetailCompanyStates.ResumeLayout(false);
            this.pnlDetailCompanyStates.PerformLayout();
            this.pnlAuthorizedPersonGender.ResumeLayout(false);
            this.pnlAuthorizedPersonGender.PerformLayout();
            this.mpDetailCompanyStatus.ResumeLayout(false);
            this.mpDetailCompanyStatus.PerformLayout();
            this.pnlCompanyGrid.ResumeLayout(false);
            this.gbCompanies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mdgCompanies)).EndInit();
            this.tlpButtons.ResumeLayout(false);
            this.tlp_SearchCompany.ResumeLayout(false);
            this.tlpSeachCompanyFields.ResumeLayout(false);
            this.tlpSeachCompanyFields.PerformLayout();
            this.mpBalanceStatus.ResumeLayout(false);
            this.mpIsActive.ResumeLayout(false);
            this.mpIsActive.PerformLayout();
            this.mpCompanyType.ResumeLayout(false);
            this.mpCompanyType.PerformLayout();
            this.mtpProducts.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.pnlStock.ResumeLayout(false);
            this.gbProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mdgProducts)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.tlpUsername.ResumeLayout(false);
            this.tlpUsername.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tlpButtons;
        public System.Windows.Forms.Button btnUpdateCompany;
        public System.Windows.Forms.TableLayoutPanel tlpMain;
        public System.Windows.Forms.ImageList imglIcons;
        public MetroFramework.Controls.MetroTabControl mtcMain;
        public MetroFramework.Controls.MetroTabPage mtpFinancialOperations;
        public MetroFramework.Controls.MetroTabPage mtpMain;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroTabPage mtpInvoice;
        public MetroFramework.Controls.MetroTabPage mtpProducts;
        public MetroFramework.Controls.MetroTabPage mtpServices;
        public MetroFramework.Controls.MetroLabel mlbl_Username;
        public System.Windows.Forms.TableLayoutPanel tlpUsername;
        public MetroFramework.Controls.MetroTabPage mtpCompanies;
        public System.Windows.Forms.TableLayoutPanel tlpCompanies;
        public MetroFramework.Controls.MetroLabel mlblTitle;
        public System.Windows.Forms.TableLayoutPanel tlp_SearchCompany;
        public System.Windows.Forms.TableLayoutPanel tlpSeachCompanyFields;
        public MetroFramework.Controls.MetroLabel mtlTel;
        public MetroFramework.Controls.MetroTextBox mtxtTitle;
        public MetroFramework.Controls.MetroPanel mpBalanceStatus;
        public MetroFramework.Controls.MetroLabel mlblCompanyType;
        public MetroFramework.Controls.MetroPanel mpCompanyType;
        public MetroFramework.Controls.MetroCheckBox mcboxSupplier;
        public MetroFramework.Controls.MetroCheckBox mcboxCustomer;
        public MetroFramework.Controls.MetroLabel mlblIsActive;
        public MetroFramework.Controls.MetroPanel mpIsActive;
        public System.Windows.Forms.Button btnSearchCompany;
        public System.Windows.Forms.Button btnBringAllCompany;
        public MetroFramework.Controls.MetroCheckBox mcboxPassive;
        public MetroFramework.Controls.MetroCheckBox mcboxActive;
        public System.Windows.Forms.TableLayoutPanel tlpCompanyDetails;
        public System.Windows.Forms.GroupBox gbCompanyDetails;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Panel pnlCompanyGrid;
        public System.Windows.Forms.Button btnAddCompany;
        public System.Windows.Forms.GroupBox gbCompanies;
        public MetroFramework.Controls.MetroGrid mdgCompanies;
        public MetroFramework.Controls.MetroLabel mlbCompanyDetailId;
        public MetroFramework.Controls.MetroLabel mlblDetailTitle;
        public MetroFramework.Controls.MetroLabel mlblAddressCity;
        public MetroFramework.Controls.MetroLabel mlblAddressDistrict;
        public MetroFramework.Controls.MetroLabel mlblAddressNeighborhood;
        public MetroFramework.Controls.MetroLabel mlblAddressStreet;
        public MetroFramework.Controls.MetroLabel mlblAddressNo;
        public MetroFramework.Controls.MetroLabel mlblFloor;
        public MetroFramework.Controls.MetroLabel mlblTaxNo;
        public MetroFramework.Controls.MetroLabel mlblTaxAdministration;
        public MetroFramework.Controls.MetroLabel mlblAuthorizedPerson;
        public MetroFramework.Controls.MetroLabel mlblAuthorizedPersonGender;
        public MetroFramework.Controls.MetroLabel mlblTel;
        public MetroFramework.Controls.MetroLabel mlblFax;
        public MetroFramework.Controls.MetroLabel mlblMail;
        public MetroFramework.Controls.MetroLabel mlblTradeRegistryNo;
        public MetroFramework.Controls.MetroLabel mlblCreateDate;
        public MetroFramework.Controls.MetroLabel mlblDetailIsActive;
        public MetroFramework.Controls.MetroLabel lblIban;
        public MetroFramework.Controls.MetroLabel mlblDetailCompanyStatus;
        public MetroFramework.Controls.MetroTextBox mtxtDetailTitle;
        public MetroFramework.Controls.MetroTextBox mtxtCity;
        public MetroFramework.Controls.MetroTextBox mtxtDistrict;
        public MetroFramework.Controls.MetroTextBox mtxtNeighborhood;
        public MetroFramework.Controls.MetroTextBox mtxtStreet;
        public MetroFramework.Controls.MetroTextBox mtxtAdressNo;
        public MetroFramework.Controls.MetroTextBox mtxtFloor;
        public MetroFramework.Controls.MetroTextBox mtxtTaxNo;
        public MetroFramework.Controls.MetroTextBox mtxtTaxAdministration;
        public MetroFramework.Controls.MetroTextBox mtxtAuthorizedPerson;
        public MetroFramework.Controls.MetroTextBox mtxtTradeRegistryNo;
        public MetroFramework.Controls.MetroTextBox mtxtIban;
        public MetroFramework.Controls.MetroLabel mlblGivenCompanyId;
        public System.Windows.Forms.Panel pnlAuthorizedPersonGender;
        public MetroFramework.Controls.MetroRadioButton mrdbtnFemale;
        public MetroFramework.Controls.MetroRadioButton mrdbtnMale;
        public System.Windows.Forms.MaskedTextBox mtxtDetailTel;
        public System.Windows.Forms.MaskedTextBox mtxtDetailFax;
        public MetroFramework.Controls.MetroTextBox mtxtMail;
        public MetroFramework.Controls.MetroDateTime mdtimeCreateDate;
        public System.Windows.Forms.Panel pnlDetailCompanyStates;
        public MetroFramework.Controls.MetroRadioButton mrdbtnPassive;
        public MetroFramework.Controls.MetroRadioButton mrdbtnActive;
        public MetroFramework.Controls.MetroPanel mpDetailCompanyStatus;
        public MetroFramework.Controls.MetroCheckBox mcboxDetailSupplier;
        public MetroFramework.Controls.MetroCheckBox mcboxDetailCustomer;
        public MetroFramework.Controls.MetroLabel mlblBalance;
        public MetroFramework.Controls.MetroLabel mblGivenBalance;
        public System.Windows.Forms.Button btnGoFinancialTransaction;
        public System.Windows.Forms.Button btnPrintCachedCompanyInfo;
        public System.Windows.Forms.MaskedTextBox mtxtTel;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Panel pnlStock;
        public System.Windows.Forms.Button btnAddProduct;
        public System.Windows.Forms.GroupBox gbProduct;
        public MetroFramework.Controls.MetroGrid mdgProducts;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button btnBringAllStock;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroTextBox mtxtSearchProductName;
        public MetroFramework.Controls.MetroPanel metroPanel3;
        public MetroFramework.Controls.MetroCheckBox metroCheckBox3;
        public MetroFramework.Controls.MetroCheckBox mcbSearchRunOut;
        public MetroFramework.Controls.MetroLabel metroLabel4;
    }
}