namespace PresentationTier
{
    partial class Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.OutBtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.MinimizeBtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sECTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sECTIONTableAdapter = new PresentationTier.ItlaBuildingsDataSetTableAdapters.SECTIONTableAdapter();
            this.sPLISTBUILDINGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bUILDINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itlaBuildingsDataSet = new PresentationTier.ItlaBuildingsDataSet();
            this.sPLISTBUILDINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itlaBuildingsDataSet2 = new PresentationTier.ItlaBuildingsDataSet2();
            this.sP_LIST_BUILDINGTableAdapter = new PresentationTier.ItlaBuildingsDataSet2TableAdapters.SP_LIST_BUILDINGTableAdapter();
            this.bUILDINGTableAdapter = new PresentationTier.ItlaBuildingsDataSetTableAdapters.BUILDINGTableAdapter();
            this.bUILDINGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bUILDINGTableAdapter1 = new PresentationTier.ItlaBuildingsDataSet2TableAdapters.BUILDINGTableAdapter();
            this.bUILDINGBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bUILDINGBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECTIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTBUILDINGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUILDINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itlaBuildingsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTBUILDINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itlaBuildingsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUILDINGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUILDINGBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUILDINGBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // OutBtn
            // 
            this.OutBtn.BackColor = System.Drawing.Color.Transparent;
            this.OutBtn.color = System.Drawing.Color.Transparent;
            this.OutBtn.colorActive = System.Drawing.Color.Red;
            this.OutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OutBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.OutBtn.ForeColor = System.Drawing.Color.White;
            this.OutBtn.Image = ((System.Drawing.Image)(resources.GetObject("OutBtn.Image")));
            this.OutBtn.ImagePosition = 20;
            this.OutBtn.ImageZoom = 50;
            this.OutBtn.LabelPosition = 30;
            this.OutBtn.LabelText = "X";
            this.OutBtn.Location = new System.Drawing.Point(1139, 3);
            this.OutBtn.Margin = new System.Windows.Forms.Padding(6);
            this.OutBtn.Name = "OutBtn";
            this.OutBtn.Size = new System.Drawing.Size(59, 30);
            this.OutBtn.TabIndex = 21;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.color = System.Drawing.Color.Transparent;
            this.MinimizeBtn.colorActive = System.Drawing.Color.SlateGray;
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.MinimizeBtn.ForeColor = System.Drawing.Color.White;
            this.MinimizeBtn.Image = null;
            this.MinimizeBtn.ImagePosition = 20;
            this.MinimizeBtn.ImageZoom = 50;
            this.MinimizeBtn.LabelPosition = 30;
            this.MinimizeBtn.LabelText = "―";
            this.MinimizeBtn.Location = new System.Drawing.Point(1086, 3);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(59, 30);
            this.MinimizeBtn.TabIndex = 22;
            // 
            // bunifuCustomDataGrid2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(497, 42);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(691, 750);
            this.bunifuCustomDataGrid2.TabIndex = 24;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.White;
            this.bunifuTileButton1.color = System.Drawing.Color.White;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Red;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 30;
            this.bunifuTileButton1.LabelText = "X";
            this.bunifuTileButton1.Location = new System.Drawing.Point(1139, 3);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(59, 30);
            this.bunifuTileButton1.TabIndex = 30;
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.White;
            this.bunifuTileButton2.color = System.Drawing.Color.White;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.SlateGray;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton2.Image = null;
            this.bunifuTileButton2.ImagePosition = 20;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 30;
            this.bunifuTileButton2.LabelText = "―";
            this.bunifuTileButton2.Location = new System.Drawing.Point(1085, 3);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(59, 30);
            this.bunifuTileButton2.TabIndex = 31;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-3, 3);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1201, 30);
            this.bunifuGradientPanel1.TabIndex = 32;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(13, 744);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(118, 48);
            this.bunifuFlatButton1.TabIndex = 42;
            this.bunifuFlatButton1.Text = "bunifuFlatButton1";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "bunifuFlatButton2";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(190, 744);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(118, 48);
            this.bunifuFlatButton2.TabIndex = 43;
            this.bunifuFlatButton2.Text = "bunifuFlatButton2";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "bunifuFlatButton3";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(363, 744);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(118, 48);
            this.bunifuFlatButton3.TabIndex = 44;
            this.bunifuFlatButton3.Text = "bunifuFlatButton3";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // sECTIONTableAdapter
            // 
            this.sECTIONTableAdapter.ClearBeforeFill = true;
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
            // sPLISTBUILDINGBindingSource
            // 
            this.sPLISTBUILDINGBindingSource.DataMember = "SP_LIST_BUILDING";
            this.sPLISTBUILDINGBindingSource.DataSource = this.itlaBuildingsDataSet2;
            // 
            // itlaBuildingsDataSet2
            // 
            this.itlaBuildingsDataSet2.DataSetName = "ItlaBuildingsDataSet2";
            this.itlaBuildingsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_LIST_BUILDINGTableAdapter
            // 
            this.sP_LIST_BUILDINGTableAdapter.ClearBeforeFill = true;
            // 
            // bUILDINGTableAdapter
            // 
            this.bUILDINGTableAdapter.ClearBeforeFill = true;
            // 
            // bUILDINGBindingSource1
            // 
            this.bUILDINGBindingSource1.DataMember = "BUILDING";
            this.bUILDINGBindingSource1.DataSource = this.itlaBuildingsDataSet2;
            // 
            // bUILDINGTableAdapter1
            // 
            this.bUILDINGTableAdapter1.ClearBeforeFill = true;
            // 
            // bUILDINGBindingSource2
            // 
            this.bUILDINGBindingSource2.DataMember = "BUILDING";
            this.bUILDINGBindingSource2.DataSource = this.itlaBuildingsDataSet2;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sPLISTBUILDINGBindingSource, "BUILDING", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.sPLISTBUILDINGBindingSource, "BUILDING", true));
            this.comboBox1.DataSource = this.bUILDINGBindingSource3;
            this.comboBox1.DisplayMember = "BUILDING";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 45;
            // 
            // bUILDINGBindingSource3
            // 
            this.bUILDINGBindingSource3.DataMember = "BUILDING";
            this.bUILDINGBindingSource3.DataSource = this.itlaBuildingsDataSet2;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1200, 804);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.bunifuTileButton2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.OutBtn);
            this.Controls.Add(this.MinimizeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
          
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECTIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTBUILDINGBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUILDINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itlaBuildingsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTBUILDINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itlaBuildingsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUILDINGBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUILDINGBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUILDINGBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuTileButton OutBtn;
        private Bunifu.Framework.UI.BunifuTileButton MinimizeBtn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.BindingSource sECTIONBindingSource;
        private ItlaBuildingsDataSetTableAdapters.SECTIONTableAdapter sECTIONTableAdapter;
        private System.Windows.Forms.BindingSource sPLISTBUILDINGBindingSource1;
        private ItlaBuildingsDataSet2 itlaBuildingsDataSet2;
        private System.Windows.Forms.BindingSource sPLISTBUILDINGBindingSource;
        private ItlaBuildingsDataSet2TableAdapters.SP_LIST_BUILDINGTableAdapter sP_LIST_BUILDINGTableAdapter;
        private ItlaBuildingsDataSet itlaBuildingsDataSet;
        private System.Windows.Forms.BindingSource bUILDINGBindingSource;
        private ItlaBuildingsDataSetTableAdapters.BUILDINGTableAdapter bUILDINGTableAdapter;
        private System.Windows.Forms.BindingSource bUILDINGBindingSource1;
        private ItlaBuildingsDataSet2TableAdapters.BUILDINGTableAdapter bUILDINGTableAdapter1;
        private System.Windows.Forms.BindingSource bUILDINGBindingSource2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bUILDINGBindingSource3;
    }
}