
namespace Поваренок.View
{
    partial class FormProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelInfo = new System.Windows.Forms.TableLayoutPanel();
            this.labelCountProduct = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanelParametrs = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.comboBoxSale = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelBottom.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanelInfo.SuspendLayout();
            this.tableLayoutPanelParametrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.ColumnCount = 1;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottom.Controls.Add(this.tableLayoutPanelTop, 0, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 3;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.48159F));
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.13598F));
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.277728F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(1107, 706);
            this.tableLayoutPanelBottom.TabIndex = 0;
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.ColumnCount = 3;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelTop.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanelTop.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.buttonExit, 2, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(1101, 68);
            this.tableLayoutPanelTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(113, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список товаров";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Поваренок.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 62);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.buttonExit.Location = new System.Drawing.Point(773, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(325, 62);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanelInfo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanelParametrs, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewProduct, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 77);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1101, 588);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanelInfo
            // 
            this.tableLayoutPanelInfo.ColumnCount = 2;
            this.tableLayoutPanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInfo.Controls.Add(this.labelCountProduct, 0, 0);
            this.tableLayoutPanelInfo.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInfo.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelInfo.Name = "tableLayoutPanelInfo";
            this.tableLayoutPanelInfo.RowCount = 1;
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInfo.Size = new System.Drawing.Size(1095, 35);
            this.tableLayoutPanelInfo.TabIndex = 0;
            // 
            // labelCountProduct
            // 
            this.labelCountProduct.AutoSize = true;
            this.labelCountProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCountProduct.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelCountProduct.Location = new System.Drawing.Point(3, 0);
            this.labelCountProduct.Name = "labelCountProduct";
            this.labelCountProduct.Size = new System.Drawing.Size(541, 35);
            this.labelCountProduct.TabIndex = 0;
            this.labelCountProduct.Text = "Количество записей";
            this.labelCountProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label3.Location = new System.Drawing.Point(550, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(542, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "ФИО пользователя";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanelParametrs
            // 
            this.tableLayoutPanelParametrs.ColumnCount = 8;
            this.tableLayoutPanelParametrs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.4712F));
            this.tableLayoutPanelParametrs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.08901F));
            this.tableLayoutPanelParametrs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.4712F));
            this.tableLayoutPanelParametrs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.08901F));
            this.tableLayoutPanelParametrs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.4712F));
            this.tableLayoutPanelParametrs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.08901F));
            this.tableLayoutPanelParametrs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.4712F));
            this.tableLayoutPanelParametrs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.84817F));
            this.tableLayoutPanelParametrs.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanelParametrs.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanelParametrs.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanelParametrs.Controls.Add(this.label7, 6, 0);
            this.tableLayoutPanelParametrs.Controls.Add(this.comboBoxSort, 1, 0);
            this.tableLayoutPanelParametrs.Controls.Add(this.comboBoxSale, 3, 0);
            this.tableLayoutPanelParametrs.Controls.Add(this.comboBoxCategory, 5, 0);
            this.tableLayoutPanelParametrs.Controls.Add(this.textBoxSearch, 7, 0);
            this.tableLayoutPanelParametrs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelParametrs.Location = new System.Drawing.Point(3, 44);
            this.tableLayoutPanelParametrs.Name = "tableLayoutPanelParametrs";
            this.tableLayoutPanelParametrs.RowCount = 1;
            this.tableLayoutPanelParametrs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelParametrs.Size = new System.Drawing.Size(1095, 23);
            this.tableLayoutPanelParametrs.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Сортировка";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label5.Location = new System.Drawing.Point(260, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Скидка";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label6.Location = new System.Drawing.Point(517, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Категории";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label7.Location = new System.Drawing.Point(774, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Название";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.UseCompatibleTextRendering = true;
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "по убыванию",
            "по возрастанию"});
            this.comboBoxSort.Location = new System.Drawing.Point(117, 3);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(137, 24);
            this.comboBoxSort.TabIndex = 4;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // comboBoxSale
            // 
            this.comboBoxSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSale.FormattingEnabled = true;
            this.comboBoxSale.Items.AddRange(new object[] {
            "Все диапазоны",
            "0-9,99%",
            "10-14,99%",
            "15% и более"});
            this.comboBoxSale.Location = new System.Drawing.Point(374, 3);
            this.comboBoxSale.Name = "comboBoxSale";
            this.comboBoxSale.Size = new System.Drawing.Size(137, 24);
            this.comboBoxSale.TabIndex = 5;
            this.comboBoxSale.SelectedIndexChanged += new System.EventHandler(this.comboBoxSale_SelectedIndexChanged);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Все категории"});
            this.comboBoxCategory.Location = new System.Drawing.Point(631, 3);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(137, 24);
            this.comboBoxCategory.TabIndex = 6;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch.Location = new System.Drawing.Point(888, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(204, 22);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.ColumnHeadersVisible = false;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Article,
            this.Photo,
            this.Desc});
            this.dataGridViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProduct.Location = new System.Drawing.Point(3, 73);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            this.dataGridViewProduct.RowHeadersVisible = false;
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.Size = new System.Drawing.Size(1095, 482);
            this.dataGridViewProduct.TabIndex = 2;
            this.dataGridViewProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellContentClick);
            // 
            // Article
            // 
            this.Article.HeaderText = "ColumnArticle";
            this.Article.MinimumWidth = 6;
            this.Article.Name = "Article";
            this.Article.ReadOnly = true;
            this.Article.Visible = false;
            this.Article.Width = 24;
            // 
            // Photo
            // 
            this.Photo.HeaderText = "ColumnPhoto";
            this.Photo.Image = global::Поваренок.Properties.Resources.logo;
            this.Photo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Photo.MinimumWidth = 6;
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            this.Photo.Width = 125;
            // 
            // Desc
            // 
            this.Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Desc.DefaultCellStyle = dataGridViewCellStyle1;
            this.Desc.HeaderText = "ColumnDesc";
            this.Desc.MinimumWidth = 6;
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            this.Desc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 706);
            this.Controls.Add(this.tableLayoutPanelBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProduct";
            this.Text = "Каталог";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanelInfo.ResumeLayout(false);
            this.tableLayoutPanelInfo.PerformLayout();
            this.tableLayoutPanelParametrs.ResumeLayout(false);
            this.tableLayoutPanelParametrs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInfo;
        private System.Windows.Forms.Label labelCountProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelParametrs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.ComboBox comboBoxSale;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Article;
        private System.Windows.Forms.DataGridViewImageColumn Photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
    }
}