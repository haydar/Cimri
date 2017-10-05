namespace Cimri.WinForm
{
    partial class AddCompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCompanyForm));
            this.gbCompanyDetails = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mlblAddressCity = new MetroFramework.Controls.MetroLabel();
            this.mlblAddressDistrict = new MetroFramework.Controls.MetroLabel();
            this.mlblAddressNeighborhood = new MetroFramework.Controls.MetroLabel();
            this.mlblAddressStreet = new MetroFramework.Controls.MetroLabel();
            this.mlblAddressNo = new MetroFramework.Controls.MetroLabel();
            this.mlblFloor = new MetroFramework.Controls.MetroLabel();
            this.mlblTaxNo = new MetroFramework.Controls.MetroLabel();
            this.mlblTaxAdministration = new MetroFramework.Controls.MetroLabel();
            this.mtxtDetailTitle = new MetroFramework.Controls.MetroTextBox();
            this.mtxtCity = new MetroFramework.Controls.MetroTextBox();
            this.mtxtDistrict = new MetroFramework.Controls.MetroTextBox();
            this.mtxtNeighborhood = new MetroFramework.Controls.MetroTextBox();
            this.mtxtStreet = new MetroFramework.Controls.MetroTextBox();
            this.mtxtAdressNo = new MetroFramework.Controls.MetroTextBox();
            this.mtxtFloor = new MetroFramework.Controls.MetroTextBox();
            this.mtxtTaxNo = new MetroFramework.Controls.MetroTextBox();
            this.mtxtTaxAdministration = new MetroFramework.Controls.MetroTextBox();
            this.mlblDetailTitle = new MetroFramework.Controls.MetroLabel();
            this.mpDetailCompanyStatus = new MetroFramework.Controls.MetroPanel();
            this.mcboxDetailCustomer = new MetroFramework.Controls.MetroCheckBox();
            this.mcboxDetailSupplier = new MetroFramework.Controls.MetroCheckBox();
            this.mlblDetailCompanyStatus = new MetroFramework.Controls.MetroLabel();
            this.lblIban = new MetroFramework.Controls.MetroLabel();
            this.mtxtIban = new MetroFramework.Controls.MetroTextBox();
            this.mlblTradeRegistryNo = new MetroFramework.Controls.MetroLabel();
            this.mtxtTradeRegistryNo = new MetroFramework.Controls.MetroTextBox();
            this.mtxtMail = new MetroFramework.Controls.MetroTextBox();
            this.mlblMail = new MetroFramework.Controls.MetroLabel();
            this.mlblFax = new MetroFramework.Controls.MetroLabel();
            this.mtxtDetailFax = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDetailTel = new System.Windows.Forms.MaskedTextBox();
            this.mlblTel = new MetroFramework.Controls.MetroLabel();
            this.mlblAuthorizedPersonGender = new MetroFramework.Controls.MetroLabel();
            this.pnlAuthorizedPersonGender = new System.Windows.Forms.Panel();
            this.mrdbtnFemale = new MetroFramework.Controls.MetroRadioButton();
            this.mrdbtnMale = new MetroFramework.Controls.MetroRadioButton();
            this.mlblAuthorizedPerson = new MetroFramework.Controls.MetroLabel();
            this.mtxtAuthorizedPerson = new MetroFramework.Controls.MetroTextBox();
            this.imglAddCompany = new System.Windows.Forms.ImageList(this.components);
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.gbCompanyDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.mpDetailCompanyStatus.SuspendLayout();
            this.pnlAuthorizedPersonGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCompanyDetails
            // 
            this.gbCompanyDetails.Controls.Add(this.tableLayoutPanel1);
            this.gbCompanyDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCompanyDetails.Location = new System.Drawing.Point(20, 60);
            this.gbCompanyDetails.Name = "gbCompanyDetails";
            this.gbCompanyDetails.Size = new System.Drawing.Size(633, 406);
            this.gbCompanyDetails.TabIndex = 3;
            this.gbCompanyDetails.TabStop = false;
            this.gbCompanyDetails.Text = "Yeni Firma Bilgileri";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.49719F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.85127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.71163F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.93991F));
            this.tableLayoutPanel1.Controls.Add(this.mlblAddressCity, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mlblAddressDistrict, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mlblAddressNeighborhood, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.mlblAddressStreet, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.mlblAddressNo, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.mlblFloor, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.mlblTaxNo, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.mlblTaxAdministration, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.mtxtDetailTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mtxtCity, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.mtxtDistrict, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.mtxtNeighborhood, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.mtxtStreet, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.mtxtAdressNo, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.mtxtFloor, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.mtxtTaxNo, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.mtxtTaxAdministration, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.mlblDetailTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mpDetailCompanyStatus, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.mlblDetailCompanyStatus, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblIban, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.mtxtIban, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.mlblTradeRegistryNo, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.mtxtTradeRegistryNo, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.mtxtMail, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.mlblMail, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.mlblFax, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.mtxtDetailFax, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.mtxtDetailTel, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.mlblTel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.mlblAuthorizedPersonGender, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlAuthorizedPersonGender, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.mlblAuthorizedPerson, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.mtxtAuthorizedPerson, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddCompany, 3, 10);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 387);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // mlblAddressCity
            // 
            this.mlblAddressCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblAddressCity.AutoSize = true;
            this.mlblAddressCity.Location = new System.Drawing.Point(3, 43);
            this.mlblAddressCity.Name = "mlblAddressCity";
            this.mlblAddressCity.Size = new System.Drawing.Size(97, 19);
            this.mlblAddressCity.TabIndex = 5;
            this.mlblAddressCity.Text = "İl                :";
            // 
            // mlblAddressDistrict
            // 
            this.mlblAddressDistrict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblAddressDistrict.AutoSize = true;
            this.mlblAddressDistrict.Location = new System.Drawing.Point(3, 78);
            this.mlblAddressDistrict.Name = "mlblAddressDistrict";
            this.mlblAddressDistrict.Size = new System.Drawing.Size(97, 19);
            this.mlblAddressDistrict.TabIndex = 5;
            this.mlblAddressDistrict.Text = "İlçe            :";
            // 
            // mlblAddressNeighborhood
            // 
            this.mlblAddressNeighborhood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblAddressNeighborhood.AutoSize = true;
            this.mlblAddressNeighborhood.Location = new System.Drawing.Point(3, 113);
            this.mlblAddressNeighborhood.Name = "mlblAddressNeighborhood";
            this.mlblAddressNeighborhood.Size = new System.Drawing.Size(97, 19);
            this.mlblAddressNeighborhood.TabIndex = 5;
            this.mlblAddressNeighborhood.Text = "Mahalle     :";
            // 
            // mlblAddressStreet
            // 
            this.mlblAddressStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblAddressStreet.AutoSize = true;
            this.mlblAddressStreet.Location = new System.Drawing.Point(3, 148);
            this.mlblAddressStreet.Name = "mlblAddressStreet";
            this.mlblAddressStreet.Size = new System.Drawing.Size(97, 19);
            this.mlblAddressStreet.TabIndex = 5;
            this.mlblAddressStreet.Text = "Sokak        :";
            // 
            // mlblAddressNo
            // 
            this.mlblAddressNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblAddressNo.AutoSize = true;
            this.mlblAddressNo.Location = new System.Drawing.Point(3, 183);
            this.mlblAddressNo.Name = "mlblAddressNo";
            this.mlblAddressNo.Size = new System.Drawing.Size(97, 19);
            this.mlblAddressNo.TabIndex = 5;
            this.mlblAddressNo.Text = "Kapı No     :";
            // 
            // mlblFloor
            // 
            this.mlblFloor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblFloor.AutoSize = true;
            this.mlblFloor.Location = new System.Drawing.Point(3, 218);
            this.mlblFloor.Name = "mlblFloor";
            this.mlblFloor.Size = new System.Drawing.Size(97, 19);
            this.mlblFloor.TabIndex = 5;
            this.mlblFloor.Text = "Kat            :";
            // 
            // mlblTaxNo
            // 
            this.mlblTaxNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblTaxNo.AutoSize = true;
            this.mlblTaxNo.Location = new System.Drawing.Point(3, 253);
            this.mlblTaxNo.Name = "mlblTaxNo";
            this.mlblTaxNo.Size = new System.Drawing.Size(97, 19);
            this.mlblTaxNo.TabIndex = 5;
            this.mlblTaxNo.Text = "Vergi No    :";
            // 
            // mlblTaxAdministration
            // 
            this.mlblTaxAdministration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblTaxAdministration.AutoSize = true;
            this.mlblTaxAdministration.Location = new System.Drawing.Point(3, 288);
            this.mlblTaxAdministration.Name = "mlblTaxAdministration";
            this.mlblTaxAdministration.Size = new System.Drawing.Size(97, 19);
            this.mlblTaxAdministration.TabIndex = 5;
            this.mlblTaxAdministration.Text = "Vergi Dairesi :";
            // 
            // mtxtDetailTitle
            // 
            this.mtxtDetailTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtDetailTitle.CustomButton.Image = null;
            this.mtxtDetailTitle.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtDetailTitle.CustomButton.Name = "";
            this.mtxtDetailTitle.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtDetailTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtDetailTitle.CustomButton.TabIndex = 1;
            this.mtxtDetailTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtDetailTitle.CustomButton.UseSelectable = true;
            this.mtxtDetailTitle.CustomButton.Visible = false;
            this.mtxtDetailTitle.Lines = new string[0];
            this.mtxtDetailTitle.Location = new System.Drawing.Point(106, 5);
            this.mtxtDetailTitle.MaxLength = 32767;
            this.mtxtDetailTitle.Name = "mtxtDetailTitle";
            this.mtxtDetailTitle.PasswordChar = '\0';
            this.mtxtDetailTitle.PromptText = "Örn. Cimri Yazılım A.Ş";
            this.mtxtDetailTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtDetailTitle.SelectedText = "";
            this.mtxtDetailTitle.SelectionLength = 0;
            this.mtxtDetailTitle.SelectionStart = 0;
            this.mtxtDetailTitle.ShortcutsEnabled = true;
            this.mtxtDetailTitle.Size = new System.Drawing.Size(162, 25);
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
            this.mtxtCity.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtCity.CustomButton.Name = "";
            this.mtxtCity.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtCity.CustomButton.TabIndex = 1;
            this.mtxtCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtCity.CustomButton.UseSelectable = true;
            this.mtxtCity.CustomButton.Visible = false;
            this.mtxtCity.Lines = new string[0];
            this.mtxtCity.Location = new System.Drawing.Point(106, 40);
            this.mtxtCity.MaxLength = 32767;
            this.mtxtCity.Name = "mtxtCity";
            this.mtxtCity.PasswordChar = '\0';
            this.mtxtCity.PromptText = "Örn. İstanbul";
            this.mtxtCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCity.SelectedText = "";
            this.mtxtCity.SelectionLength = 0;
            this.mtxtCity.SelectionStart = 0;
            this.mtxtCity.ShortcutsEnabled = true;
            this.mtxtCity.Size = new System.Drawing.Size(162, 25);
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
            this.mtxtDistrict.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtDistrict.CustomButton.Name = "";
            this.mtxtDistrict.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtDistrict.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtDistrict.CustomButton.TabIndex = 1;
            this.mtxtDistrict.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtDistrict.CustomButton.UseSelectable = true;
            this.mtxtDistrict.CustomButton.Visible = false;
            this.mtxtDistrict.Lines = new string[0];
            this.mtxtDistrict.Location = new System.Drawing.Point(106, 75);
            this.mtxtDistrict.MaxLength = 32767;
            this.mtxtDistrict.Name = "mtxtDistrict";
            this.mtxtDistrict.PasswordChar = '\0';
            this.mtxtDistrict.PromptText = "Örn. Kadıköy";
            this.mtxtDistrict.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtDistrict.SelectedText = "";
            this.mtxtDistrict.SelectionLength = 0;
            this.mtxtDistrict.SelectionStart = 0;
            this.mtxtDistrict.ShortcutsEnabled = true;
            this.mtxtDistrict.Size = new System.Drawing.Size(162, 25);
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
            this.mtxtNeighborhood.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtNeighborhood.CustomButton.Name = "";
            this.mtxtNeighborhood.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtNeighborhood.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtNeighborhood.CustomButton.TabIndex = 1;
            this.mtxtNeighborhood.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtNeighborhood.CustomButton.UseSelectable = true;
            this.mtxtNeighborhood.CustomButton.Visible = false;
            this.mtxtNeighborhood.Lines = new string[0];
            this.mtxtNeighborhood.Location = new System.Drawing.Point(106, 110);
            this.mtxtNeighborhood.MaxLength = 32767;
            this.mtxtNeighborhood.Name = "mtxtNeighborhood";
            this.mtxtNeighborhood.PasswordChar = '\0';
            this.mtxtNeighborhood.PromptText = "Örn. İnönü mah.";
            this.mtxtNeighborhood.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtNeighborhood.SelectedText = "";
            this.mtxtNeighborhood.SelectionLength = 0;
            this.mtxtNeighborhood.SelectionStart = 0;
            this.mtxtNeighborhood.ShortcutsEnabled = true;
            this.mtxtNeighborhood.Size = new System.Drawing.Size(162, 25);
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
            this.mtxtStreet.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtStreet.CustomButton.Name = "";
            this.mtxtStreet.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtStreet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtStreet.CustomButton.TabIndex = 1;
            this.mtxtStreet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtStreet.CustomButton.UseSelectable = true;
            this.mtxtStreet.CustomButton.Visible = false;
            this.mtxtStreet.Lines = new string[0];
            this.mtxtStreet.Location = new System.Drawing.Point(106, 145);
            this.mtxtStreet.MaxLength = 32767;
            this.mtxtStreet.Name = "mtxtStreet";
            this.mtxtStreet.PasswordChar = '\0';
            this.mtxtStreet.PromptText = "Yalçınlar sok.";
            this.mtxtStreet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtStreet.SelectedText = "";
            this.mtxtStreet.SelectionLength = 0;
            this.mtxtStreet.SelectionStart = 0;
            this.mtxtStreet.ShortcutsEnabled = true;
            this.mtxtStreet.Size = new System.Drawing.Size(162, 25);
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
            this.mtxtAdressNo.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtAdressNo.CustomButton.Name = "";
            this.mtxtAdressNo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtAdressNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtAdressNo.CustomButton.TabIndex = 1;
            this.mtxtAdressNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtAdressNo.CustomButton.UseSelectable = true;
            this.mtxtAdressNo.CustomButton.Visible = false;
            this.mtxtAdressNo.Lines = new string[0];
            this.mtxtAdressNo.Location = new System.Drawing.Point(106, 180);
            this.mtxtAdressNo.MaxLength = 32767;
            this.mtxtAdressNo.Name = "mtxtAdressNo";
            this.mtxtAdressNo.PasswordChar = '\0';
            this.mtxtAdressNo.PromptText = "Örn. 38/B veya 17";
            this.mtxtAdressNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtAdressNo.SelectedText = "";
            this.mtxtAdressNo.SelectionLength = 0;
            this.mtxtAdressNo.SelectionStart = 0;
            this.mtxtAdressNo.ShortcutsEnabled = true;
            this.mtxtAdressNo.Size = new System.Drawing.Size(162, 25);
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
            this.mtxtFloor.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtFloor.CustomButton.Name = "";
            this.mtxtFloor.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtFloor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtFloor.CustomButton.TabIndex = 1;
            this.mtxtFloor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtFloor.CustomButton.UseSelectable = true;
            this.mtxtFloor.CustomButton.Visible = false;
            this.mtxtFloor.Lines = new string[0];
            this.mtxtFloor.Location = new System.Drawing.Point(106, 215);
            this.mtxtFloor.MaxLength = 32767;
            this.mtxtFloor.Name = "mtxtFloor";
            this.mtxtFloor.PasswordChar = '\0';
            this.mtxtFloor.PromptText = "Örn. 2.Kat";
            this.mtxtFloor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtFloor.SelectedText = "";
            this.mtxtFloor.SelectionLength = 0;
            this.mtxtFloor.SelectionStart = 0;
            this.mtxtFloor.ShortcutsEnabled = true;
            this.mtxtFloor.Size = new System.Drawing.Size(162, 25);
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
            this.mtxtTaxNo.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtTaxNo.CustomButton.Name = "";
            this.mtxtTaxNo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtTaxNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtTaxNo.CustomButton.TabIndex = 1;
            this.mtxtTaxNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtTaxNo.CustomButton.UseSelectable = true;
            this.mtxtTaxNo.CustomButton.Visible = false;
            this.mtxtTaxNo.Lines = new string[0];
            this.mtxtTaxNo.Location = new System.Drawing.Point(106, 250);
            this.mtxtTaxNo.MaxLength = 11;
            this.mtxtTaxNo.Name = "mtxtTaxNo";
            this.mtxtTaxNo.PasswordChar = '\0';
            this.mtxtTaxNo.PromptText = "Örn. 4780163831";
            this.mtxtTaxNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtTaxNo.SelectedText = "";
            this.mtxtTaxNo.SelectionLength = 0;
            this.mtxtTaxNo.SelectionStart = 0;
            this.mtxtTaxNo.ShortcutsEnabled = true;
            this.mtxtTaxNo.Size = new System.Drawing.Size(162, 25);
            this.mtxtTaxNo.TabIndex = 6;
            this.mtxtTaxNo.UseSelectable = true;
            this.mtxtTaxNo.WaterMark = "Örn. 4780163831";
            this.mtxtTaxNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtTaxNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtTaxAdministration
            // 
            this.mtxtTaxAdministration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtTaxAdministration.CustomButton.Image = null;
            this.mtxtTaxAdministration.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtTaxAdministration.CustomButton.Name = "";
            this.mtxtTaxAdministration.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtTaxAdministration.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtTaxAdministration.CustomButton.TabIndex = 1;
            this.mtxtTaxAdministration.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtTaxAdministration.CustomButton.UseSelectable = true;
            this.mtxtTaxAdministration.CustomButton.Visible = false;
            this.mtxtTaxAdministration.Lines = new string[0];
            this.mtxtTaxAdministration.Location = new System.Drawing.Point(106, 285);
            this.mtxtTaxAdministration.MaxLength = 32767;
            this.mtxtTaxAdministration.Name = "mtxtTaxAdministration";
            this.mtxtTaxAdministration.PasswordChar = '\0';
            this.mtxtTaxAdministration.PromptText = "Örn. Üsküdar";
            this.mtxtTaxAdministration.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtTaxAdministration.SelectedText = "";
            this.mtxtTaxAdministration.SelectionLength = 0;
            this.mtxtTaxAdministration.SelectionStart = 0;
            this.mtxtTaxAdministration.ShortcutsEnabled = true;
            this.mtxtTaxAdministration.Size = new System.Drawing.Size(162, 25);
            this.mtxtTaxAdministration.TabIndex = 6;
            this.mtxtTaxAdministration.UseSelectable = true;
            this.mtxtTaxAdministration.WaterMark = "Örn. Üsküdar";
            this.mtxtTaxAdministration.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtTaxAdministration.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblDetailTitle
            // 
            this.mlblDetailTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblDetailTitle.AutoSize = true;
            this.mlblDetailTitle.Location = new System.Drawing.Point(3, 8);
            this.mlblDetailTitle.Name = "mlblDetailTitle";
            this.mlblDetailTitle.Size = new System.Drawing.Size(97, 19);
            this.mlblDetailTitle.TabIndex = 5;
            this.mlblDetailTitle.Text = "Ünvan        :";
            // 
            // mpDetailCompanyStatus
            // 
            this.mpDetailCompanyStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpDetailCompanyStatus.Controls.Add(this.mcboxDetailCustomer);
            this.mpDetailCompanyStatus.Controls.Add(this.mcboxDetailSupplier);
            this.mpDetailCompanyStatus.HorizontalScrollbarBarColor = true;
            this.mpDetailCompanyStatus.HorizontalScrollbarHighlightOnWheel = false;
            this.mpDetailCompanyStatus.HorizontalScrollbarSize = 10;
            this.mpDetailCompanyStatus.Location = new System.Drawing.Point(397, 248);
            this.mpDetailCompanyStatus.Name = "mpDetailCompanyStatus";
            this.mpDetailCompanyStatus.Size = new System.Drawing.Size(227, 29);
            this.mpDetailCompanyStatus.TabIndex = 12;
            this.mpDetailCompanyStatus.VerticalScrollbarBarColor = true;
            this.mpDetailCompanyStatus.VerticalScrollbarHighlightOnWheel = false;
            this.mpDetailCompanyStatus.VerticalScrollbarSize = 10;
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
            // mcboxDetailSupplier
            // 
            this.mcboxDetailSupplier.AutoSize = true;
            this.mcboxDetailSupplier.Checked = true;
            this.mcboxDetailSupplier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mcboxDetailSupplier.Location = new System.Drawing.Point(89, 8);
            this.mcboxDetailSupplier.Name = "mcboxDetailSupplier";
            this.mcboxDetailSupplier.Size = new System.Drawing.Size(70, 15);
            this.mcboxDetailSupplier.TabIndex = 5;
            this.mcboxDetailSupplier.Text = "Tedarikçi";
            this.mcboxDetailSupplier.UseSelectable = true;
            // 
            // mlblDetailCompanyStatus
            // 
            this.mlblDetailCompanyStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblDetailCompanyStatus.AutoSize = true;
            this.mlblDetailCompanyStatus.Location = new System.Drawing.Point(274, 253);
            this.mlblDetailCompanyStatus.Name = "mlblDetailCompanyStatus";
            this.mlblDetailCompanyStatus.Size = new System.Drawing.Size(87, 19);
            this.mlblDetailCompanyStatus.TabIndex = 5;
            this.mlblDetailCompanyStatus.Text = "Kurum Tipi   :";
            // 
            // lblIban
            // 
            this.lblIban.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIban.AutoSize = true;
            this.lblIban.Location = new System.Drawing.Point(274, 218);
            this.lblIban.Name = "lblIban";
            this.lblIban.Size = new System.Drawing.Size(103, 19);
            this.lblIban.TabIndex = 5;
            this.lblIban.Text = "Iban  No          :";
            // 
            // mtxtIban
            // 
            this.mtxtIban.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtIban.CustomButton.Image = null;
            this.mtxtIban.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.mtxtIban.CustomButton.Name = "";
            this.mtxtIban.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtIban.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtIban.CustomButton.TabIndex = 1;
            this.mtxtIban.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtIban.CustomButton.UseSelectable = true;
            this.mtxtIban.CustomButton.Visible = false;
            this.mtxtIban.Lines = new string[0];
            this.mtxtIban.Location = new System.Drawing.Point(397, 215);
            this.mtxtIban.MaxLength = 32767;
            this.mtxtIban.Name = "mtxtIban";
            this.mtxtIban.PasswordChar = '\0';
            this.mtxtIban.PromptText = "Örn. TR56 0006 2000 0001 2990 0226 04";
            this.mtxtIban.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtIban.SelectedText = "";
            this.mtxtIban.SelectionLength = 0;
            this.mtxtIban.SelectionStart = 0;
            this.mtxtIban.ShortcutsEnabled = true;
            this.mtxtIban.Size = new System.Drawing.Size(227, 25);
            this.mtxtIban.TabIndex = 6;
            this.mtxtIban.UseSelectable = true;
            this.mtxtIban.WaterMark = "Örn. TR56 0006 2000 0001 2990 0226 04";
            this.mtxtIban.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtIban.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblTradeRegistryNo
            // 
            this.mlblTradeRegistryNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblTradeRegistryNo.AutoSize = true;
            this.mlblTradeRegistryNo.Location = new System.Drawing.Point(274, 183);
            this.mlblTradeRegistryNo.Name = "mlblTradeRegistryNo";
            this.mlblTradeRegistryNo.Size = new System.Drawing.Size(107, 19);
            this.mlblTradeRegistryNo.TabIndex = 5;
            this.mlblTradeRegistryNo.Text = "Ticaret Sicil No : ";
            // 
            // mtxtTradeRegistryNo
            // 
            this.mtxtTradeRegistryNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtTradeRegistryNo.CustomButton.Image = null;
            this.mtxtTradeRegistryNo.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.mtxtTradeRegistryNo.CustomButton.Name = "";
            this.mtxtTradeRegistryNo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtTradeRegistryNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtTradeRegistryNo.CustomButton.TabIndex = 1;
            this.mtxtTradeRegistryNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtTradeRegistryNo.CustomButton.UseSelectable = true;
            this.mtxtTradeRegistryNo.CustomButton.Visible = false;
            this.mtxtTradeRegistryNo.Lines = new string[0];
            this.mtxtTradeRegistryNo.Location = new System.Drawing.Point(397, 180);
            this.mtxtTradeRegistryNo.MaxLength = 32767;
            this.mtxtTradeRegistryNo.Name = "mtxtTradeRegistryNo";
            this.mtxtTradeRegistryNo.PasswordChar = '\0';
            this.mtxtTradeRegistryNo.PromptText = "Örn. 12345678912";
            this.mtxtTradeRegistryNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtTradeRegistryNo.SelectedText = "";
            this.mtxtTradeRegistryNo.SelectionLength = 0;
            this.mtxtTradeRegistryNo.SelectionStart = 0;
            this.mtxtTradeRegistryNo.ShortcutsEnabled = true;
            this.mtxtTradeRegistryNo.Size = new System.Drawing.Size(227, 25);
            this.mtxtTradeRegistryNo.TabIndex = 6;
            this.mtxtTradeRegistryNo.UseSelectable = true;
            this.mtxtTradeRegistryNo.WaterMark = "Örn. 12345678912";
            this.mtxtTradeRegistryNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtTradeRegistryNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtMail
            // 
            this.mtxtMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtMail.CustomButton.Image = null;
            this.mtxtMail.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.mtxtMail.CustomButton.Name = "";
            this.mtxtMail.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtMail.CustomButton.TabIndex = 1;
            this.mtxtMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtMail.CustomButton.UseSelectable = true;
            this.mtxtMail.CustomButton.Visible = false;
            this.mtxtMail.Lines = new string[0];
            this.mtxtMail.Location = new System.Drawing.Point(397, 145);
            this.mtxtMail.MaxLength = 32767;
            this.mtxtMail.Name = "mtxtMail";
            this.mtxtMail.PasswordChar = '\0';
            this.mtxtMail.PromptText = "Örn. info@sirket.com";
            this.mtxtMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtMail.SelectedText = "";
            this.mtxtMail.SelectionLength = 0;
            this.mtxtMail.SelectionStart = 0;
            this.mtxtMail.ShortcutsEnabled = true;
            this.mtxtMail.Size = new System.Drawing.Size(227, 25);
            this.mtxtMail.TabIndex = 6;
            this.mtxtMail.UseSelectable = true;
            this.mtxtMail.WaterMark = "Örn. info@sirket.com";
            this.mtxtMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblMail
            // 
            this.mlblMail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblMail.AutoSize = true;
            this.mlblMail.Location = new System.Drawing.Point(274, 148);
            this.mlblMail.Name = "mlblMail";
            this.mlblMail.Size = new System.Drawing.Size(81, 19);
            this.mlblMail.TabIndex = 5;
            this.mlblMail.Text = "Mail           :";
            // 
            // mlblFax
            // 
            this.mlblFax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblFax.AutoSize = true;
            this.mlblFax.Location = new System.Drawing.Point(274, 113);
            this.mlblFax.Name = "mlblFax";
            this.mlblFax.Size = new System.Drawing.Size(79, 19);
            this.mlblFax.TabIndex = 5;
            this.mlblFax.Text = "Fax            :";
            // 
            // mtxtDetailFax
            // 
            this.mtxtDetailFax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtDetailFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDetailFax.Location = new System.Drawing.Point(397, 110);
            this.mtxtDetailFax.Mask = "(999) 000-0000";
            this.mtxtDetailFax.Name = "mtxtDetailFax";
            this.mtxtDetailFax.Size = new System.Drawing.Size(227, 24);
            this.mtxtDetailFax.TabIndex = 9;
            // 
            // mtxtDetailTel
            // 
            this.mtxtDetailTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtDetailTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDetailTel.Location = new System.Drawing.Point(397, 75);
            this.mtxtDetailTel.Mask = "(999) 000-0000";
            this.mtxtDetailTel.Name = "mtxtDetailTel";
            this.mtxtDetailTel.Size = new System.Drawing.Size(227, 24);
            this.mtxtDetailTel.TabIndex = 8;
            // 
            // mlblTel
            // 
            this.mlblTel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblTel.AutoSize = true;
            this.mlblTel.Location = new System.Drawing.Point(274, 78);
            this.mlblTel.Name = "mlblTel";
            this.mlblTel.Size = new System.Drawing.Size(79, 19);
            this.mlblTel.TabIndex = 5;
            this.mlblTel.Text = "Tel             :";
            // 
            // mlblAuthorizedPersonGender
            // 
            this.mlblAuthorizedPersonGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblAuthorizedPersonGender.AutoSize = true;
            this.mlblAuthorizedPersonGender.Location = new System.Drawing.Point(274, 43);
            this.mlblAuthorizedPersonGender.Name = "mlblAuthorizedPersonGender";
            this.mlblAuthorizedPersonGender.Size = new System.Drawing.Size(76, 19);
            this.mlblAuthorizedPersonGender.TabIndex = 5;
            this.mlblAuthorizedPersonGender.Text = "Cinsiyet     :";
            // 
            // pnlAuthorizedPersonGender
            // 
            this.pnlAuthorizedPersonGender.Controls.Add(this.mrdbtnFemale);
            this.pnlAuthorizedPersonGender.Controls.Add(this.mrdbtnMale);
            this.pnlAuthorizedPersonGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAuthorizedPersonGender.Location = new System.Drawing.Point(397, 38);
            this.pnlAuthorizedPersonGender.Name = "pnlAuthorizedPersonGender";
            this.pnlAuthorizedPersonGender.Size = new System.Drawing.Size(227, 29);
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
            // mlblAuthorizedPerson
            // 
            this.mlblAuthorizedPerson.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mlblAuthorizedPerson.AutoSize = true;
            this.mlblAuthorizedPerson.Location = new System.Drawing.Point(274, 8);
            this.mlblAuthorizedPerson.Name = "mlblAuthorizedPerson";
            this.mlblAuthorizedPerson.Size = new System.Drawing.Size(74, 19);
            this.mlblAuthorizedPerson.TabIndex = 5;
            this.mlblAuthorizedPerson.Text = "Yetkili Kişi  :";
            // 
            // mtxtAuthorizedPerson
            // 
            this.mtxtAuthorizedPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtAuthorizedPerson.CustomButton.Image = null;
            this.mtxtAuthorizedPerson.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.mtxtAuthorizedPerson.CustomButton.Name = "";
            this.mtxtAuthorizedPerson.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtAuthorizedPerson.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtAuthorizedPerson.CustomButton.TabIndex = 1;
            this.mtxtAuthorizedPerson.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtAuthorizedPerson.CustomButton.UseSelectable = true;
            this.mtxtAuthorizedPerson.CustomButton.Visible = false;
            this.mtxtAuthorizedPerson.Lines = new string[0];
            this.mtxtAuthorizedPerson.Location = new System.Drawing.Point(397, 5);
            this.mtxtAuthorizedPerson.MaxLength = 32767;
            this.mtxtAuthorizedPerson.Name = "mtxtAuthorizedPerson";
            this.mtxtAuthorizedPerson.PasswordChar = '\0';
            this.mtxtAuthorizedPerson.PromptText = "Örn. Sibel Yıldız";
            this.mtxtAuthorizedPerson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtAuthorizedPerson.SelectedText = "";
            this.mtxtAuthorizedPerson.SelectionLength = 0;
            this.mtxtAuthorizedPerson.SelectionStart = 0;
            this.mtxtAuthorizedPerson.ShortcutsEnabled = true;
            this.mtxtAuthorizedPerson.Size = new System.Drawing.Size(227, 25);
            this.mtxtAuthorizedPerson.TabIndex = 6;
            this.mtxtAuthorizedPerson.UseSelectable = true;
            this.mtxtAuthorizedPerson.WaterMark = "Örn. Sibel Yıldız";
            this.mtxtAuthorizedPerson.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtAuthorizedPerson.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // imglAddCompany
            // 
            this.imglAddCompany.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglAddCompany.ImageStream")));
            this.imglAddCompany.TransparentColor = System.Drawing.Color.Transparent;
            this.imglAddCompany.Images.SetKeyName(0, "addcompany.png");
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAddCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCompany.ImageKey = "addcompany.png";
            this.btnAddCompany.ImageList = this.imglAddCompany;
            this.btnAddCompany.Location = new System.Drawing.Point(431, 353);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(158, 31);
            this.btnAddCompany.TabIndex = 13;
            this.btnAddCompany.Text = "Firma Ekle";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // AddCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 486);
            this.Controls.Add(this.gbCompanyDetails);
            this.MaximizeBox = false;
            this.Name = "AddCompanyForm";
            this.Text = "Firma Ekle";
            this.Load += new System.EventHandler(this.AddCompany_Load);
            this.Resize += new System.EventHandler(this.AddCompany_Resize);
            this.gbCompanyDetails.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.mpDetailCompanyStatus.ResumeLayout(false);
            this.mpDetailCompanyStatus.PerformLayout();
            this.pnlAuthorizedPersonGender.ResumeLayout(false);
            this.pnlAuthorizedPersonGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gbCompanyDetails;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.MaskedTextBox mtxtDetailFax;
        public MetroFramework.Controls.MetroLabel mlblAddressCity;
        public MetroFramework.Controls.MetroLabel mlblAddressDistrict;
        public MetroFramework.Controls.MetroLabel mlblAddressNeighborhood;
        public MetroFramework.Controls.MetroLabel mlblAddressStreet;
        public MetroFramework.Controls.MetroLabel mlblAddressNo;
        public MetroFramework.Controls.MetroLabel mlblFloor;
        public MetroFramework.Controls.MetroLabel mlblTaxNo;
        public MetroFramework.Controls.MetroLabel mlblTaxAdministration;
        public MetroFramework.Controls.MetroLabel mlblAuthorizedPersonGender;
        public MetroFramework.Controls.MetroLabel mlblTel;
        public MetroFramework.Controls.MetroLabel mlblFax;
        public MetroFramework.Controls.MetroLabel mlblMail;
        public MetroFramework.Controls.MetroLabel mlblTradeRegistryNo;
        public MetroFramework.Controls.MetroTextBox mtxtDetailTitle;
        public MetroFramework.Controls.MetroTextBox mtxtCity;
        public MetroFramework.Controls.MetroTextBox mtxtDistrict;
        public MetroFramework.Controls.MetroTextBox mtxtNeighborhood;
        public MetroFramework.Controls.MetroTextBox mtxtStreet;
        public MetroFramework.Controls.MetroTextBox mtxtAdressNo;
        public MetroFramework.Controls.MetroTextBox mtxtFloor;
        public MetroFramework.Controls.MetroTextBox mtxtTaxNo;
        public MetroFramework.Controls.MetroTextBox mtxtTaxAdministration;
        public MetroFramework.Controls.MetroTextBox mtxtMail;
        public MetroFramework.Controls.MetroTextBox mtxtTradeRegistryNo;
        public System.Windows.Forms.MaskedTextBox mtxtDetailTel;
        public MetroFramework.Controls.MetroLabel mlblDetailTitle;
        public MetroFramework.Controls.MetroLabel mlblAuthorizedPerson;
        public MetroFramework.Controls.MetroTextBox mtxtAuthorizedPerson;
        public MetroFramework.Controls.MetroLabel lblIban;
        public MetroFramework.Controls.MetroTextBox mtxtIban;
        public MetroFramework.Controls.MetroLabel mlblDetailCompanyStatus;
        public MetroFramework.Controls.MetroPanel mpDetailCompanyStatus;
        public MetroFramework.Controls.MetroCheckBox mcboxDetailCustomer;
        public MetroFramework.Controls.MetroCheckBox mcboxDetailSupplier;
        public System.Windows.Forms.Panel pnlAuthorizedPersonGender;
        public MetroFramework.Controls.MetroRadioButton mrdbtnFemale;
        public MetroFramework.Controls.MetroRadioButton mrdbtnMale;
        private System.Windows.Forms.ImageList imglAddCompany;
        private System.Windows.Forms.Button btnAddCompany;
    }
}