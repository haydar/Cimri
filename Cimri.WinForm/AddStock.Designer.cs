namespace Cimri.WinForm
{
    partial class AddStockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStockForm));
            this.gbAddStock = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mlblStockName = new MetroFramework.Controls.MetroLabel();
            this.mlblStockUnitPrice = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mlblStockStartingCount = new MetroFramework.Controls.MetroLabel();
            this.mtxtStockName = new MetroFramework.Controls.MetroTextBox();
            this.mtxtUnitPrice = new MetroFramework.Controls.MetroTextBox();
            this.mtxtStockDescription = new MetroFramework.Controls.MetroTextBox();
            this.mtxtStockStartingCount = new MetroFramework.Controls.MetroTextBox();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.imglAddStock = new System.Windows.Forms.ImageList(this.components);
            this.gbAddStock.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddStock
            // 
            this.gbAddStock.Controls.Add(this.tableLayoutPanel1);
            this.gbAddStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddStock.Location = new System.Drawing.Point(20, 60);
            this.gbAddStock.Name = "gbAddStock";
            this.gbAddStock.Size = new System.Drawing.Size(400, 246);
            this.gbAddStock.TabIndex = 0;
            this.gbAddStock.TabStop = false;
            this.gbAddStock.Text = "Yeni Stok Bilgileri";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.96447F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.03553F));
            this.tableLayoutPanel1.Controls.Add(this.mlblStockName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mlblStockUnitPrice, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mlblStockStartingCount, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.mtxtStockName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mtxtUnitPrice, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.mtxtStockDescription, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.mtxtStockStartingCount, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAddStock, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 227);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mlblStockName
            // 
            this.mlblStockName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblStockName.Location = new System.Drawing.Point(3, 9);
            this.mlblStockName.Name = "mlblStockName";
            this.mlblStockName.Size = new System.Drawing.Size(116, 19);
            this.mlblStockName.TabIndex = 2;
            this.mlblStockName.Text = "Stok Adı           :";
            // 
            // mlblStockUnitPrice
            // 
            this.mlblStockUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblStockUnitPrice.Location = new System.Drawing.Point(3, 46);
            this.mlblStockUnitPrice.Name = "mlblStockUnitPrice";
            this.mlblStockUnitPrice.Size = new System.Drawing.Size(116, 19);
            this.mlblStockUnitPrice.TabIndex = 2;
            this.mlblStockUnitPrice.Text = "Birim Fiyatı  (₺)   :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.Location = new System.Drawing.Point(3, 83);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(116, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Açıklama            :";
            // 
            // mlblStockStartingCount
            // 
            this.mlblStockStartingCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblStockStartingCount.Location = new System.Drawing.Point(3, 120);
            this.mlblStockStartingCount.Name = "mlblStockStartingCount";
            this.mlblStockStartingCount.Size = new System.Drawing.Size(116, 19);
            this.mlblStockStartingCount.TabIndex = 2;
            this.mlblStockStartingCount.Text = "Başlangıç Adedi  :";
            // 
            // mtxtStockName
            // 
            this.mtxtStockName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtStockName.CustomButton.Image = null;
            this.mtxtStockName.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.mtxtStockName.CustomButton.Name = "";
            this.mtxtStockName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtStockName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtStockName.CustomButton.TabIndex = 1;
            this.mtxtStockName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtStockName.CustomButton.UseSelectable = true;
            this.mtxtStockName.CustomButton.Visible = false;
            this.mtxtStockName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtxtStockName.Lines = new string[0];
            this.mtxtStockName.Location = new System.Drawing.Point(125, 7);
            this.mtxtStockName.MaxLength = 32767;
            this.mtxtStockName.Name = "mtxtStockName";
            this.mtxtStockName.PasswordChar = '\0';
            this.mtxtStockName.PromptText = "Örn. Makina Yağı (1 Litre)";
            this.mtxtStockName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtStockName.SelectedText = "";
            this.mtxtStockName.SelectionLength = 0;
            this.mtxtStockName.SelectionStart = 0;
            this.mtxtStockName.ShortcutsEnabled = true;
            this.mtxtStockName.Size = new System.Drawing.Size(266, 23);
            this.mtxtStockName.TabIndex = 3;
            this.mtxtStockName.UseSelectable = true;
            this.mtxtStockName.WaterMark = "Örn. Makina Yağı (1 Litre)";
            this.mtxtStockName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtStockName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtUnitPrice
            // 
            this.mtxtUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtUnitPrice.CustomButton.Image = null;
            this.mtxtUnitPrice.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.mtxtUnitPrice.CustomButton.Name = "";
            this.mtxtUnitPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtUnitPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUnitPrice.CustomButton.TabIndex = 1;
            this.mtxtUnitPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUnitPrice.CustomButton.UseSelectable = true;
            this.mtxtUnitPrice.CustomButton.Visible = false;
            this.mtxtUnitPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtxtUnitPrice.Lines = new string[0];
            this.mtxtUnitPrice.Location = new System.Drawing.Point(125, 44);
            this.mtxtUnitPrice.MaxLength = 32767;
            this.mtxtUnitPrice.Name = "mtxtUnitPrice";
            this.mtxtUnitPrice.PasswordChar = '\0';
            this.mtxtUnitPrice.PromptText = "Örn. 25.75";
            this.mtxtUnitPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUnitPrice.SelectedText = "";
            this.mtxtUnitPrice.SelectionLength = 0;
            this.mtxtUnitPrice.SelectionStart = 0;
            this.mtxtUnitPrice.ShortcutsEnabled = true;
            this.mtxtUnitPrice.Size = new System.Drawing.Size(266, 23);
            this.mtxtUnitPrice.TabIndex = 3;
            this.mtxtUnitPrice.UseSelectable = true;
            this.mtxtUnitPrice.WaterMark = "Örn. 25.75";
            this.mtxtUnitPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUnitPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtUnitPrice_KeyPress);
            // 
            // mtxtStockDescription
            // 
            this.mtxtStockDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtStockDescription.CustomButton.Image = null;
            this.mtxtStockDescription.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.mtxtStockDescription.CustomButton.Name = "";
            this.mtxtStockDescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtStockDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtStockDescription.CustomButton.TabIndex = 1;
            this.mtxtStockDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtStockDescription.CustomButton.UseSelectable = true;
            this.mtxtStockDescription.CustomButton.Visible = false;
            this.mtxtStockDescription.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtxtStockDescription.Lines = new string[0];
            this.mtxtStockDescription.Location = new System.Drawing.Point(125, 81);
            this.mtxtStockDescription.MaxLength = 32767;
            this.mtxtStockDescription.Name = "mtxtStockDescription";
            this.mtxtStockDescription.PasswordChar = '\0';
            this.mtxtStockDescription.PromptText = "Örn. Sanayi Tipi  Makina Yağı (10 Numara)";
            this.mtxtStockDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtStockDescription.SelectedText = "";
            this.mtxtStockDescription.SelectionLength = 0;
            this.mtxtStockDescription.SelectionStart = 0;
            this.mtxtStockDescription.ShortcutsEnabled = true;
            this.mtxtStockDescription.Size = new System.Drawing.Size(266, 23);
            this.mtxtStockDescription.TabIndex = 3;
            this.mtxtStockDescription.UseSelectable = true;
            this.mtxtStockDescription.WaterMark = "Örn. Sanayi Tipi  Makina Yağı (10 Numara)";
            this.mtxtStockDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtStockDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtStockStartingCount
            // 
            this.mtxtStockStartingCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtStockStartingCount.CustomButton.Image = null;
            this.mtxtStockStartingCount.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.mtxtStockStartingCount.CustomButton.Name = "";
            this.mtxtStockStartingCount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtStockStartingCount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtStockStartingCount.CustomButton.TabIndex = 1;
            this.mtxtStockStartingCount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtStockStartingCount.CustomButton.UseSelectable = true;
            this.mtxtStockStartingCount.CustomButton.Visible = false;
            this.mtxtStockStartingCount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtxtStockStartingCount.Lines = new string[] {
        "0"};
            this.mtxtStockStartingCount.Location = new System.Drawing.Point(125, 118);
            this.mtxtStockStartingCount.MaxLength = 32767;
            this.mtxtStockStartingCount.Name = "mtxtStockStartingCount";
            this.mtxtStockStartingCount.PasswordChar = '\0';
            this.mtxtStockStartingCount.PromptText = "Stok oluşturulmadan önce elinizdeki miktar";
            this.mtxtStockStartingCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtStockStartingCount.SelectedText = "";
            this.mtxtStockStartingCount.SelectionLength = 0;
            this.mtxtStockStartingCount.SelectionStart = 0;
            this.mtxtStockStartingCount.ShortcutsEnabled = true;
            this.mtxtStockStartingCount.Size = new System.Drawing.Size(266, 23);
            this.mtxtStockStartingCount.TabIndex = 3;
            this.mtxtStockStartingCount.Text = "0";
            this.mtxtStockStartingCount.UseSelectable = true;
            this.mtxtStockStartingCount.WaterMark = "Stok oluşturulmadan önce elinizdeki miktar";
            this.mtxtStockStartingCount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtStockStartingCount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtStockStartingCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtStockStartingCount_KeyPress);
            // 
            // btnAddStock
            // 
            this.btnAddStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStock.ImageKey = "AddStock.png";
            this.btnAddStock.ImageList = this.imglAddStock;
            this.btnAddStock.Location = new System.Drawing.Point(180, 188);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(155, 36);
            this.btnAddStock.TabIndex = 14;
            this.btnAddStock.Text = "Stok Ekle";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // imglAddStock
            // 
            this.imglAddStock.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglAddStock.ImageStream")));
            this.imglAddStock.TransparentColor = System.Drawing.Color.Transparent;
            this.imglAddStock.Images.SetKeyName(0, "AddStock.png");
            // 
            // AddStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 326);
            this.Controls.Add(this.gbAddStock);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AddStockForm";
            this.Text = "Yeni Stok ";
            this.Load += new System.EventHandler(this.AddStock_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AddStockForm_KeyUp);
            this.Resize += new System.EventHandler(this.AddStock_Resize);
            this.gbAddStock.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gbAddStock;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public MetroFramework.Controls.MetroLabel mlblStockName;
        public MetroFramework.Controls.MetroLabel mlblStockUnitPrice;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroLabel mlblStockStartingCount;
        public MetroFramework.Controls.MetroTextBox mtxtStockName;
        public MetroFramework.Controls.MetroTextBox mtxtUnitPrice;
        public MetroFramework.Controls.MetroTextBox mtxtStockDescription;
        public MetroFramework.Controls.MetroTextBox mtxtStockStartingCount;
        public System.Windows.Forms.Button btnAddStock;
        public System.Windows.Forms.ImageList imglAddStock;
    }
}