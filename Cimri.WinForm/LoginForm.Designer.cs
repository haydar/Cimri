namespace Cimri.WinForm
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mlblUsername = new MetroFramework.Controls.MetroLabel();
            this.mlblPassword = new MetroFramework.Controls.MetroLabel();
            this.mlblUserCompany = new MetroFramework.Controls.MetroLabel();
            this.mcbxUserCompany = new MetroFramework.Controls.MetroComboBox();
            this.mtxtUsername = new MetroFramework.Controls.MetroTextBox();
            this.mtxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iListLogin = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.12121F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.87879F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(337, 372);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.9697F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.0303F));
            this.tableLayoutPanel2.Controls.Add(this.mlblUsername, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.mlblPassword, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.mlblUserCompany, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.mcbxUserCompany, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.mtxtUsername, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.mtxtPassword, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnLogin, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 159);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(331, 210);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // mlblUsername
            // 
            this.mlblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblUsername.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblUsername.Location = new System.Drawing.Point(3, 16);
            this.mlblUsername.Name = "mlblUsername";
            this.mlblUsername.Size = new System.Drawing.Size(116, 19);
            this.mlblUsername.TabIndex = 0;
            this.mlblUsername.Text = "Kullanıcı Adı :";
            // 
            // mlblPassword
            // 
            this.mlblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblPassword.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblPassword.Location = new System.Drawing.Point(3, 68);
            this.mlblPassword.Name = "mlblPassword";
            this.mlblPassword.Size = new System.Drawing.Size(116, 19);
            this.mlblPassword.TabIndex = 0;
            this.mlblPassword.Text = "Şifre : ";
            // 
            // mlblUserCompany
            // 
            this.mlblUserCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblUserCompany.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblUserCompany.Location = new System.Drawing.Point(3, 120);
            this.mlblUserCompany.Name = "mlblUserCompany";
            this.mlblUserCompany.Size = new System.Drawing.Size(116, 19);
            this.mlblUserCompany.TabIndex = 0;
            this.mlblUserCompany.Text = "Kullanıcı Şirketi :";
            // 
            // mcbxUserCompany
            // 
            this.mcbxUserCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mcbxUserCompany.FormattingEnabled = true;
            this.mcbxUserCompany.ItemHeight = 23;
            this.mcbxUserCompany.Location = new System.Drawing.Point(125, 115);
            this.mcbxUserCompany.Name = "mcbxUserCompany";
            this.mcbxUserCompany.Size = new System.Drawing.Size(203, 29);
            this.mcbxUserCompany.TabIndex = 3;
            this.mcbxUserCompany.UseSelectable = true;
            // 
            // mtxtUsername
            // 
            this.mtxtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtUsername.CustomButton.Image = null;
            this.mtxtUsername.CustomButton.Location = new System.Drawing.Point(177, 2);
            this.mtxtUsername.CustomButton.Name = "";
            this.mtxtUsername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUsername.CustomButton.TabIndex = 1;
            this.mtxtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUsername.CustomButton.UseSelectable = true;
            this.mtxtUsername.CustomButton.Visible = false;
            this.mtxtUsername.DisplayIcon = true;
            this.mtxtUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtxtUsername.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.mtxtUsername.Icon = ((System.Drawing.Image)(resources.GetObject("mtxtUsername.Icon")));
            this.mtxtUsername.Lines = new string[0];
            this.mtxtUsername.Location = new System.Drawing.Point(125, 12);
            this.mtxtUsername.MaxLength = 32767;
            this.mtxtUsername.Name = "mtxtUsername";
            this.mtxtUsername.PasswordChar = '\0';
            this.mtxtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUsername.SelectedText = "";
            this.mtxtUsername.SelectionLength = 0;
            this.mtxtUsername.SelectionStart = 0;
            this.mtxtUsername.ShortcutsEnabled = true;
            this.mtxtUsername.Size = new System.Drawing.Size(203, 28);
            this.mtxtUsername.TabIndex = 0;
            this.mtxtUsername.UseSelectable = true;
            this.mtxtUsername.WaterMark = "Kullanıcı adı giriniz";
            this.mtxtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtPassword
            // 
            this.mtxtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtPassword.CustomButton.Image = null;
            this.mtxtPassword.CustomButton.Location = new System.Drawing.Point(177, 2);
            this.mtxtPassword.CustomButton.Name = "";
            this.mtxtPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPassword.CustomButton.TabIndex = 1;
            this.mtxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPassword.CustomButton.UseSelectable = true;
            this.mtxtPassword.CustomButton.Visible = false;
            this.mtxtPassword.DisplayIcon = true;
            this.mtxtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtxtPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.mtxtPassword.Icon = global::Cimri.WinForm.Properties.Resources.password;
            this.mtxtPassword.Lines = new string[0];
            this.mtxtPassword.Location = new System.Drawing.Point(125, 64);
            this.mtxtPassword.MaxLength = 32767;
            this.mtxtPassword.Name = "mtxtPassword";
            this.mtxtPassword.PasswordChar = '*';
            this.mtxtPassword.PromptText = "Şifrenizi giriniz";
            this.mtxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPassword.SelectedText = "";
            this.mtxtPassword.SelectionLength = 0;
            this.mtxtPassword.SelectionStart = 0;
            this.mtxtPassword.ShortcutsEnabled = true;
            this.mtxtPassword.Size = new System.Drawing.Size(203, 28);
            this.mtxtPassword.TabIndex = 1;
            this.mtxtPassword.UseSelectable = true;
            this.mtxtPassword.WaterMark = "Şifrenizi giriniz";
            this.mtxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.ImageIndex = 0;
            this.btnLogin.ImageList = this.iListLogin;
            this.btnLogin.Location = new System.Drawing.Point(200, 170);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(128, 37);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Oturum Aç";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Cimri.WinForm.Properties.Resources.users;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // iListLogin
            // 
            this.iListLogin.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iListLogin.ImageStream")));
            this.iListLogin.TransparentColor = System.Drawing.Color.Transparent;
            this.iListLogin.Images.SetKeyName(0, "login.png");
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(383, 408);
            this.Name = "LoginForm";
            this.Text = "Cimri | Giriş Ekranı";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel mlblUsername;
        private MetroFramework.Controls.MetroLabel mlblPassword;
        private MetroFramework.Controls.MetroLabel mlblUserCompany;
        private MetroFramework.Controls.MetroComboBox mcbxUserCompany;
        private MetroFramework.Controls.MetroTextBox mtxtUsername;
        private MetroFramework.Controls.MetroTextBox mtxtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ImageList iListLogin;
    }
}

