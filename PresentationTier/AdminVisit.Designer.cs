namespace PresentationTier
{
    partial class AdminVisit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminVisit));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.USERSDTVIEW = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BuildDrop = new System.Windows.Forms.ComboBox();
            this.bUILDINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itlaBuildingsDataSet = new PresentationTier.ItlaBuildingsDataSet();
            this.bUILDINGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bUILDINGTableAdapter = new PresentationTier.ItlaBuildingsDataSetTableAdapters.BUILDINGTableAdapter();
            this.SectionDrop = new System.Windows.Forms.ComboBox();
            this.sECTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sECTIONBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sECTIONBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sECTIONTableAdapter = new PresentationTier.ItlaBuildingsDataSetTableAdapters.SECTIONTableAdapter();
            this.NameVisitTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.LastNameVisitTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.MailVisitTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.CheckInVisit = new Bunifu.Framework.UI.BunifuDatepicker();
            this.CheckOutVisit = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EditVisitBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DeleteVisitBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sECTIONBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.SaveVisitBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ReasonTxt = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CareerDrop = new System.Windows.Forms.ComboBox();
            this.cAREERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAREERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cAREERTableAdapter = new PresentationTier.ItlaBuildingsDataSetTableAdapters.CAREERTableAdapter();
            this.cAREERBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bUILDINGBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Exitbtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.Closebtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.MinimizeBtn = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.USERSDTVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUILDINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itlaBuildingsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUILDINGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECTIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECTIONBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECTIONBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECTIONBindingSource2)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cAREERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAREERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAREERBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUILDINGBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // USERSDTVIEW
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.USERSDTVIEW.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.USERSDTVIEW.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.USERSDTVIEW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.USERSDTVIEW.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.USERSDTVIEW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.USERSDTVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.USERSDTVIEW.DoubleBuffered = true;
            this.USERSDTVIEW.EnableHeadersVisualStyles = false;
            this.USERSDTVIEW.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.USERSDTVIEW.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.USERSDTVIEW.Location = new System.Drawing.Point(534, 103);
            this.USERSDTVIEW.Name = "USERSDTVIEW";
            this.USERSDTVIEW.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.USERSDTVIEW.Size = new System.Drawing.Size(1083, 754);
            this.USERSDTVIEW.TabIndex = 25;
            // 
            // BuildDrop
            // 
            this.BuildDrop.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.bUILDINGBindingSource, "BUILDING", true));
            this.BuildDrop.DataSource = this.bUILDINGBindingSource1;
            this.BuildDrop.DisplayMember = "BUILDING";
            this.BuildDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuildDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.BuildDrop.FormattingEnabled = true;
            this.BuildDrop.Location = new System.Drawing.Point(13, 481);
            this.BuildDrop.Name = "BuildDrop";
            this.BuildDrop.Size = new System.Drawing.Size(201, 30);
            this.BuildDrop.TabIndex = 26;
            this.BuildDrop.ValueMember = "BUILDING";
            // 
            // bUILDINGBindingSource
            // 
            this.bUILDINGBindingSource.DataMember = "BUILDING";
            this.bUILDINGBindingSource.DataSource = this.itlaBuildingsDataSet;
            // 
            // itlaBuildingsDataSet
            // 
            this.itlaBuildingsDataSet.DataSetName = "ItlaBuildingsDataSet";
            this.itlaBuildingsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bUILDINGBindingSource1
            // 
            this.bUILDINGBindingSource1.DataMember = "BUILDING";
            this.bUILDINGBindingSource1.DataSource = this.itlaBuildingsDataSet;
            // 
            // bUILDINGTableAdapter
            // 
            this.bUILDINGTableAdapter.ClearBeforeFill = true;
            // 
            // SectionDrop
            // 
            this.SectionDrop.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.sECTIONBindingSource, "SECTION", true));
            this.SectionDrop.DataSource = this.sECTIONBindingSource3;
            this.SectionDrop.DisplayMember = "SECTION";
            this.SectionDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SectionDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.SectionDrop.FormattingEnabled = true;
            this.SectionDrop.Location = new System.Drawing.Point(250, 481);
            this.SectionDrop.Name = "SectionDrop";
            this.SectionDrop.Size = new System.Drawing.Size(205, 30);
            this.SectionDrop.TabIndex = 27;
            // 
            // sECTIONBindingSource
            // 
            this.sECTIONBindingSource.DataMember = "SECTION";
            this.sECTIONBindingSource.DataSource = this.itlaBuildingsDataSet;
            // 
            // sECTIONBindingSource3
            // 
            this.sECTIONBindingSource3.DataMember = "SECTION";
            this.sECTIONBindingSource3.DataSource = this.itlaBuildingsDataSet;
            // 
            // sECTIONBindingSource1
            // 
            this.sECTIONBindingSource1.DataMember = "SECTION";
            this.sECTIONBindingSource1.DataSource = this.itlaBuildingsDataSet;
            // 
            // sECTIONTableAdapter
            // 
            this.sECTIONTableAdapter.ClearBeforeFill = true;
            // 
            // NameVisitTxt
            // 
            this.NameVisitTxt.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.NameVisitTxt.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.NameVisitTxt.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.NameVisitTxt.BorderThickness = 3;
            this.NameVisitTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameVisitTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NameVisitTxt.ForeColor = System.Drawing.Color.White;
            this.NameVisitTxt.isPassword = false;
            this.NameVisitTxt.Location = new System.Drawing.Point(13, 148);
            this.NameVisitTxt.Margin = new System.Windows.Forms.Padding(4);
            this.NameVisitTxt.Name = "NameVisitTxt";
            this.NameVisitTxt.Size = new System.Drawing.Size(370, 44);
            this.NameVisitTxt.TabIndex = 28;
            this.NameVisitTxt.Text = "Nombre ";
            this.NameVisitTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LastNameVisitTxt
            // 
            this.LastNameVisitTxt.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.LastNameVisitTxt.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.LastNameVisitTxt.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.LastNameVisitTxt.BorderThickness = 3;
            this.LastNameVisitTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastNameVisitTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LastNameVisitTxt.ForeColor = System.Drawing.Color.White;
            this.LastNameVisitTxt.isPassword = false;
            this.LastNameVisitTxt.Location = new System.Drawing.Point(14, 220);
            this.LastNameVisitTxt.Margin = new System.Windows.Forms.Padding(4);
            this.LastNameVisitTxt.Name = "LastNameVisitTxt";
            this.LastNameVisitTxt.Size = new System.Drawing.Size(370, 44);
            this.LastNameVisitTxt.TabIndex = 29;
            this.LastNameVisitTxt.Text = "Apellido";
            this.LastNameVisitTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MailVisitTxt
            // 
            this.MailVisitTxt.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.MailVisitTxt.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.MailVisitTxt.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.MailVisitTxt.BorderThickness = 3;
            this.MailVisitTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MailVisitTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MailVisitTxt.ForeColor = System.Drawing.Color.White;
            this.MailVisitTxt.isPassword = false;
            this.MailVisitTxt.Location = new System.Drawing.Point(13, 357);
            this.MailVisitTxt.Margin = new System.Windows.Forms.Padding(4);
            this.MailVisitTxt.Name = "MailVisitTxt";
            this.MailVisitTxt.Size = new System.Drawing.Size(370, 44);
            this.MailVisitTxt.TabIndex = 31;
            this.MailVisitTxt.Text = "Correo";
            this.MailVisitTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CheckInVisit
            // 
            this.CheckInVisit.BackColor = System.Drawing.Color.SeaGreen;
            this.CheckInVisit.BorderRadius = 0;
            this.CheckInVisit.ForeColor = System.Drawing.Color.White;
            this.CheckInVisit.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.CheckInVisit.FormatCustom = null;
            this.CheckInVisit.Location = new System.Drawing.Point(16, 542);
            this.CheckInVisit.Name = "CheckInVisit";
            this.CheckInVisit.Size = new System.Drawing.Size(201, 36);
            this.CheckInVisit.TabIndex = 32;
            this.CheckInVisit.Value = new System.DateTime(2022, 8, 21, 15, 1, 31, 161);
            // 
            // CheckOutVisit
            // 
            this.CheckOutVisit.BackColor = System.Drawing.Color.SeaGreen;
            this.CheckOutVisit.BorderRadius = 0;
            this.CheckOutVisit.ForeColor = System.Drawing.Color.White;
            this.CheckOutVisit.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.CheckOutVisit.FormatCustom = null;
            this.CheckOutVisit.Location = new System.Drawing.Point(254, 542);
            this.CheckOutVisit.Name = "CheckOutVisit";
            this.CheckOutVisit.Size = new System.Drawing.Size(201, 36);
            this.CheckOutVisit.TabIndex = 33;
            this.CheckOutVisit.Value = new System.DateTime(2022, 8, 21, 15, 1, 41, 583);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "bunifuFlatButton1";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(24, 1374);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(330, 89);
            this.bunifuFlatButton1.TabIndex = 35;
            this.bunifuFlatButton1.Text = "bunifuFlatButton1";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // EditVisitBtn
            // 
            this.EditVisitBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.EditVisitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.EditVisitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditVisitBtn.BorderRadius = 0;
            this.EditVisitBtn.ButtonText = "Editar";
            this.EditVisitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditVisitBtn.DisabledColor = System.Drawing.Color.Gray;
            this.EditVisitBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.EditVisitBtn.Iconimage = null;
            this.EditVisitBtn.Iconimage_right = null;
            this.EditVisitBtn.Iconimage_right_Selected = null;
            this.EditVisitBtn.Iconimage_Selected = null;
            this.EditVisitBtn.IconMarginLeft = 0;
            this.EditVisitBtn.IconMarginRight = 0;
            this.EditVisitBtn.IconRightVisible = true;
            this.EditVisitBtn.IconRightZoom = 0D;
            this.EditVisitBtn.IconVisible = true;
            this.EditVisitBtn.IconZoom = 90D;
            this.EditVisitBtn.IsTab = false;
            this.EditVisitBtn.Location = new System.Drawing.Point(183, 809);
            this.EditVisitBtn.Name = "EditVisitBtn";
            this.EditVisitBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.EditVisitBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.EditVisitBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.EditVisitBtn.selected = false;
            this.EditVisitBtn.Size = new System.Drawing.Size(169, 48);
            this.EditVisitBtn.TabIndex = 36;
            this.EditVisitBtn.Text = "Editar";
            this.EditVisitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditVisitBtn.Textcolor = System.Drawing.Color.White;
            this.EditVisitBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.EditVisitBtn.Click += new System.EventHandler(this.EditVisitBtn_Click);
            // 
            // DeleteVisitBtn
            // 
            this.DeleteVisitBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.DeleteVisitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.DeleteVisitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteVisitBtn.BorderRadius = 0;
            this.DeleteVisitBtn.ButtonText = "Eliminar";
            this.DeleteVisitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteVisitBtn.DisabledColor = System.Drawing.Color.Gray;
            this.DeleteVisitBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DeleteVisitBtn.Iconimage = null;
            this.DeleteVisitBtn.Iconimage_right = null;
            this.DeleteVisitBtn.Iconimage_right_Selected = null;
            this.DeleteVisitBtn.Iconimage_Selected = null;
            this.DeleteVisitBtn.IconMarginLeft = 0;
            this.DeleteVisitBtn.IconMarginRight = 0;
            this.DeleteVisitBtn.IconRightVisible = true;
            this.DeleteVisitBtn.IconRightZoom = 0D;
            this.DeleteVisitBtn.IconVisible = true;
            this.DeleteVisitBtn.IconZoom = 90D;
            this.DeleteVisitBtn.IsTab = false;
            this.DeleteVisitBtn.Location = new System.Drawing.Point(358, 809);
            this.DeleteVisitBtn.Name = "DeleteVisitBtn";
            this.DeleteVisitBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.DeleteVisitBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.DeleteVisitBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.DeleteVisitBtn.selected = false;
            this.DeleteVisitBtn.Size = new System.Drawing.Size(169, 48);
            this.DeleteVisitBtn.TabIndex = 37;
            this.DeleteVisitBtn.Text = "Eliminar";
            this.DeleteVisitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteVisitBtn.Textcolor = System.Drawing.Color.White;
            this.DeleteVisitBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.DeleteVisitBtn.Click += new System.EventHandler(this.DeleteVisitBtn_Click);
            // 
            // sECTIONBindingSource2
            // 
            this.sECTIONBindingSource2.DataMember = "SECTION";
            this.sECTIONBindingSource2.DataSource = this.itlaBuildingsDataSet;
            // 
            // SaveVisitBtn
            // 
            this.SaveVisitBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SaveVisitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SaveVisitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveVisitBtn.BorderRadius = 0;
            this.SaveVisitBtn.ButtonText = "Guardar";
            this.SaveVisitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveVisitBtn.DisabledColor = System.Drawing.Color.Gray;
            this.SaveVisitBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.SaveVisitBtn.Iconimage = null;
            this.SaveVisitBtn.Iconimage_right = null;
            this.SaveVisitBtn.Iconimage_right_Selected = null;
            this.SaveVisitBtn.Iconimage_Selected = null;
            this.SaveVisitBtn.IconMarginLeft = 0;
            this.SaveVisitBtn.IconMarginRight = 0;
            this.SaveVisitBtn.IconRightVisible = true;
            this.SaveVisitBtn.IconRightZoom = 0D;
            this.SaveVisitBtn.IconVisible = true;
            this.SaveVisitBtn.IconZoom = 90D;
            this.SaveVisitBtn.IsTab = false;
            this.SaveVisitBtn.Location = new System.Drawing.Point(8, 809);
            this.SaveVisitBtn.Name = "SaveVisitBtn";
            this.SaveVisitBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SaveVisitBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.SaveVisitBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.SaveVisitBtn.selected = false;
            this.SaveVisitBtn.Size = new System.Drawing.Size(169, 48);
            this.SaveVisitBtn.TabIndex = 38;
            this.SaveVisitBtn.Text = "Guardar";
            this.SaveVisitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveVisitBtn.Textcolor = System.Drawing.Color.White;
            this.SaveVisitBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveVisitBtn.Click += new System.EventHandler(this.SaveVisitBtn_Click);
            // 
            // ReasonTxt
            // 
            this.ReasonTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ReasonTxt.Location = new System.Drawing.Point(13, 634);
            this.ReasonTxt.Multiline = true;
            this.ReasonTxt.Name = "ReasonTxt";
            this.ReasonTxt.Size = new System.Drawing.Size(501, 158);
            this.ReasonTxt.TabIndex = 39;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.MinimizeBtn);
            this.bunifuGradientPanel1.Controls.Add(this.Closebtn);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-8, 1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1642, 30);
            this.bunifuGradientPanel1.TabIndex = 42;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(12, 8);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(145, 19);
            this.bunifuCustomLabel2.TabIndex = 44;
            this.bunifuCustomLabel2.Text = "Administrar Visitas";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(74, 66);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(235, 29);
            this.bunifuCustomLabel1.TabIndex = 43;
            this.bunifuCustomLabel1.Text = "Administrar Visitas";
            // 
            // CareerDrop
            // 
            this.CareerDrop.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.cAREERBindingSource, "CAREER", true));
            this.CareerDrop.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cAREERBindingSource, "ID", true));
            this.CareerDrop.DataSource = this.cAREERBindingSource1;
            this.CareerDrop.DisplayMember = "CAREER";
            this.CareerDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CareerDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.CareerDrop.FormattingEnabled = true;
            this.CareerDrop.Location = new System.Drawing.Point(16, 296);
            this.CareerDrop.Name = "CareerDrop";
            this.CareerDrop.Size = new System.Drawing.Size(367, 30);
            this.CareerDrop.TabIndex = 44;
            this.CareerDrop.ValueMember = "ID";
            // 
            // cAREERBindingSource
            // 
            this.cAREERBindingSource.DataMember = "CAREER";
            this.cAREERBindingSource.DataSource = this.itlaBuildingsDataSet;
            // 
            // cAREERBindingSource1
            // 
            this.cAREERBindingSource1.DataMember = "CAREER";
            this.cAREERBindingSource1.DataSource = this.itlaBuildingsDataSet;
            // 
            // cAREERTableAdapter
            // 
            this.cAREERTableAdapter.ClearBeforeFill = true;
            // 
            // cAREERBindingSource2
            // 
            this.cAREERBindingSource2.DataMember = "CAREER";
            this.cAREERBindingSource2.DataSource = this.itlaBuildingsDataSet;
            // 
            // bUILDINGBindingSource2
            // 
            this.bUILDINGBindingSource2.DataMember = "BUILDING";
            this.bUILDINGBindingSource2.DataSource = this.itlaBuildingsDataSet;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Back";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(8, 56);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(60, 48);
            this.bunifuFlatButton2.TabIndex = 45;
            this.bunifuFlatButton2.Text = "Back";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Exitbtn.color = System.Drawing.SystemColors.ActiveCaption;
            this.Exitbtn.colorActive = System.Drawing.Color.IndianRed;
            this.Exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exitbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.ForeColor = System.Drawing.Color.White;
            this.Exitbtn.Image = null;
            this.Exitbtn.ImagePosition = 34;
            this.Exitbtn.ImageZoom = 50;
            this.Exitbtn.LabelPosition = 34;
            this.Exitbtn.LabelText = "Cerrar sesion";
            this.Exitbtn.Location = new System.Drawing.Point(1496, 47);
            this.Exitbtn.Margin = new System.Windows.Forms.Padding(10);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(114, 42);
            this.Exitbtn.TabIndex = 46;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.BackColor = System.Drawing.Color.Transparent;
            this.Closebtn.color = System.Drawing.Color.Transparent;
            this.Closebtn.colorActive = System.Drawing.Color.Red;
            this.Closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Closebtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Closebtn.ForeColor = System.Drawing.Color.Black;
            this.Closebtn.Image = ((System.Drawing.Image)(resources.GetObject("Closebtn.Image")));
            this.Closebtn.ImagePosition = 20;
            this.Closebtn.ImageZoom = 50;
            this.Closebtn.LabelPosition = 30;
            this.Closebtn.LabelText = "x";
            this.Closebtn.Location = new System.Drawing.Point(1577, 0);
            this.Closebtn.Margin = new System.Windows.Forms.Padding(6);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(59, 30);
            this.Closebtn.TabIndex = 45;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.color = System.Drawing.Color.Transparent;
            this.MinimizeBtn.colorActive = System.Drawing.Color.SlateGray;
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.MinimizeBtn.ForeColor = System.Drawing.Color.Black;
            this.MinimizeBtn.Image = null;
            this.MinimizeBtn.ImagePosition = 20;
            this.MinimizeBtn.ImageZoom = 50;
            this.MinimizeBtn.LabelPosition = 30;
            this.MinimizeBtn.LabelText = "―";
            this.MinimizeBtn.Location = new System.Drawing.Point(1531, 0);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(52, 30);
            this.MinimizeBtn.TabIndex = 46;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // AdminVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1629, 869);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.CareerDrop);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.ReasonTxt);
            this.Controls.Add(this.SaveVisitBtn);
            this.Controls.Add(this.DeleteVisitBtn);
            this.Controls.Add(this.EditVisitBtn);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.CheckOutVisit);
            this.Controls.Add(this.CheckInVisit);
            this.Controls.Add(this.MailVisitTxt);
            this.Controls.Add(this.LastNameVisitTxt);
            this.Controls.Add(this.NameVisitTxt);
            this.Controls.Add(this.SectionDrop);
            this.Controls.Add(this.BuildDrop);
            this.Controls.Add(this.USERSDTVIEW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminVisit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminVisit";
            this.Load += new System.EventHandler(this.AdminVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USERSDTVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUILDINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itlaBuildingsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUILDINGBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECTIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECTIONBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECTIONBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECTIONBindingSource2)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cAREERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAREERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAREERBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUILDINGBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid USERSDTVIEW;
        private System.Windows.Forms.ComboBox BuildDrop;
        private ItlaBuildingsDataSet itlaBuildingsDataSet;
        private System.Windows.Forms.BindingSource bUILDINGBindingSource;
        private ItlaBuildingsDataSetTableAdapters.BUILDINGTableAdapter bUILDINGTableAdapter;
        private System.Windows.Forms.BindingSource bUILDINGBindingSource1;
        private System.Windows.Forms.ComboBox SectionDrop;
        private System.Windows.Forms.BindingSource sECTIONBindingSource;
        private ItlaBuildingsDataSetTableAdapters.SECTIONTableAdapter sECTIONTableAdapter;
        private System.Windows.Forms.BindingSource sECTIONBindingSource1;
        private Bunifu.Framework.UI.BunifuMetroTextbox MailVisitTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox LastNameVisitTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox NameVisitTxt;
        private Bunifu.Framework.UI.BunifuFlatButton DeleteVisitBtn;
        private Bunifu.Framework.UI.BunifuFlatButton EditVisitBtn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuDatepicker CheckOutVisit;
        private Bunifu.Framework.UI.BunifuDatepicker CheckInVisit;
        private System.Windows.Forms.BindingSource sECTIONBindingSource2;
        private System.Windows.Forms.BindingSource sECTIONBindingSource3;
        private Bunifu.Framework.UI.BunifuFlatButton SaveVisitBtn;
        private System.Windows.Forms.TextBox ReasonTxt;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox CareerDrop;
        private System.Windows.Forms.BindingSource cAREERBindingSource;
        private ItlaBuildingsDataSetTableAdapters.CAREERTableAdapter cAREERTableAdapter;
        private System.Windows.Forms.BindingSource cAREERBindingSource1;
        private System.Windows.Forms.BindingSource bUILDINGBindingSource2;
        private System.Windows.Forms.BindingSource cAREERBindingSource2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuTileButton Exitbtn;
        private Bunifu.Framework.UI.BunifuTileButton Closebtn;
        private Bunifu.Framework.UI.BunifuTileButton MinimizeBtn;
    }
}