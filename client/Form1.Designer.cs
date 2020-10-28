namespace client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageFind = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.GridViewSearchHouseroom = new System.Windows.Forms.DataGridView();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxAddCity = new System.Windows.Forms.TextBox();
            this.textBoxAddStreet = new System.Windows.Forms.TextBox();
            this.textBoxAddPrice = new System.Windows.Forms.TextBox();
            this.textBoxAddDescription = new System.Windows.Forms.TextBox();
            this.buttonAddHouseroom = new System.Windows.Forms.Button();
            this.labelAddCity = new System.Windows.Forms.Label();
            this.labelAddStreet = new System.Windows.Forms.Label();
            this.labelAddPrice = new System.Windows.Forms.Label();
            this.labelAddDescription = new System.Windows.Forms.Label();
            this.labelAddSub = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageFind.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSearchHouseroom)).BeginInit();
            this.tabPageAdd.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageFind);
            this.tabControl.Controls.Add(this.tabPageAdd);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            // 
            // tabPageFind
            // 
            this.tabPageFind.Controls.Add(this.tableLayoutPanel1);
            this.tabPageFind.Location = new System.Drawing.Point(4, 22);
            this.tabPageFind.Name = "tabPageFind";
            this.tabPageFind.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFind.Size = new System.Drawing.Size(792, 424);
            this.tabPageFind.TabIndex = 0;
            this.tabPageFind.Text = "Поиск жилья";
            this.tabPageFind.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GridViewSearchHouseroom, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFind);
            this.groupBox1.Controls.Add(this.textBoxPrice);
            this.groupBox1.Controls.Add(this.labelPrice);
            this.groupBox1.Controls.Add(this.textBoxStreet);
            this.groupBox1.Controls.Add(this.labelStreet);
            this.groupBox1.Controls.Add(this.textBoxCity);
            this.groupBox1.Controls.Add(this.labelCity);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск жилья";
            // 
            // buttonFind
            // 
            this.buttonFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFind.Location = new System.Drawing.Point(699, 15);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 4;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrice.Location = new System.Drawing.Point(382, 17);
            this.textBoxPrice.MaxLength = 10;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 3;
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(340, 20);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 13);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Цена:";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStreet.Location = new System.Drawing.Point(224, 17);
            this.textBoxStreet.MaxLength = 255;
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(100, 20);
            this.textBoxStreet.TabIndex = 2;
            // 
            // labelStreet
            // 
            this.labelStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(176, 20);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(42, 13);
            this.labelStreet.TabIndex = 2;
            this.labelStreet.Text = "Улица:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCity.Location = new System.Drawing.Point(62, 17);
            this.textBoxCity.MaxLength = 255;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 1;
            // 
            // labelCity
            // 
            this.labelCity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(16, 20);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(40, 13);
            this.labelCity.TabIndex = 0;
            this.labelCity.Text = "Город:";
            // 
            // GridViewSearchHouseroom
            // 
            this.GridViewSearchHouseroom.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridViewSearchHouseroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewSearchHouseroom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewSearchHouseroom.Location = new System.Drawing.Point(3, 58);
            this.GridViewSearchHouseroom.Name = "GridViewSearchHouseroom";
            this.GridViewSearchHouseroom.ReadOnly = true;
            this.GridViewSearchHouseroom.Size = new System.Drawing.Size(780, 357);
            this.GridViewSearchHouseroom.TabIndex = 1;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.tableLayoutPanel2);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(792, 424);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Добавление жилья";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxAddCity, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxAddStreet, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxAddPrice, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxAddDescription, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonAddHouseroom, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelAddCity, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelAddStreet, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelAddPrice, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelAddDescription, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelAddSub, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(780, 98);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBoxAddCity
            // 
            this.textBoxAddCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAddCity.Location = new System.Drawing.Point(3, 52);
            this.textBoxAddCity.MaxLength = 255;
            this.textBoxAddCity.Name = "textBoxAddCity";
            this.textBoxAddCity.Size = new System.Drawing.Size(150, 20);
            this.textBoxAddCity.TabIndex = 0;
            // 
            // textBoxAddStreet
            // 
            this.textBoxAddStreet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAddStreet.Location = new System.Drawing.Point(159, 52);
            this.textBoxAddStreet.MaxLength = 255;
            this.textBoxAddStreet.Name = "textBoxAddStreet";
            this.textBoxAddStreet.Size = new System.Drawing.Size(150, 20);
            this.textBoxAddStreet.TabIndex = 1;
            // 
            // textBoxAddPrice
            // 
            this.textBoxAddPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAddPrice.Location = new System.Drawing.Point(315, 52);
            this.textBoxAddPrice.MaxLength = 255;
            this.textBoxAddPrice.Name = "textBoxAddPrice";
            this.textBoxAddPrice.Size = new System.Drawing.Size(150, 20);
            this.textBoxAddPrice.TabIndex = 2;
            // 
            // textBoxAddDescription
            // 
            this.textBoxAddDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAddDescription.Location = new System.Drawing.Point(471, 52);
            this.textBoxAddDescription.MaxLength = 255;
            this.textBoxAddDescription.Name = "textBoxAddDescription";
            this.textBoxAddDescription.Size = new System.Drawing.Size(150, 20);
            this.textBoxAddDescription.TabIndex = 3;
            // 
            // buttonAddHouseroom
            // 
            this.buttonAddHouseroom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddHouseroom.Location = new System.Drawing.Point(627, 52);
            this.buttonAddHouseroom.Name = "buttonAddHouseroom";
            this.buttonAddHouseroom.Size = new System.Drawing.Size(150, 43);
            this.buttonAddHouseroom.TabIndex = 4;
            this.buttonAddHouseroom.Text = "Отправляем";
            this.buttonAddHouseroom.UseVisualStyleBackColor = true;
            this.buttonAddHouseroom.Click += new System.EventHandler(this.buttonAddHouseroom_Click);
            // 
            // labelAddCity
            // 
            this.labelAddCity.AutoSize = true;
            this.labelAddCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAddCity.Location = new System.Drawing.Point(3, 0);
            this.labelAddCity.Name = "labelAddCity";
            this.labelAddCity.Size = new System.Drawing.Size(150, 49);
            this.labelAddCity.TabIndex = 5;
            this.labelAddCity.Text = "Введите город на латинице:";
            // 
            // labelAddStreet
            // 
            this.labelAddStreet.AutoSize = true;
            this.labelAddStreet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAddStreet.Location = new System.Drawing.Point(159, 0);
            this.labelAddStreet.Name = "labelAddStreet";
            this.labelAddStreet.Size = new System.Drawing.Size(150, 49);
            this.labelAddStreet.TabIndex = 6;
            this.labelAddStreet.Text = "Введите улицу на латинице:";
            // 
            // labelAddPrice
            // 
            this.labelAddPrice.AutoSize = true;
            this.labelAddPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAddPrice.Location = new System.Drawing.Point(315, 0);
            this.labelAddPrice.Name = "labelAddPrice";
            this.labelAddPrice.Size = new System.Drawing.Size(150, 49);
            this.labelAddPrice.TabIndex = 7;
            this.labelAddPrice.Text = "Введите цену:";
            // 
            // labelAddDescription
            // 
            this.labelAddDescription.AutoSize = true;
            this.labelAddDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAddDescription.Location = new System.Drawing.Point(471, 0);
            this.labelAddDescription.Name = "labelAddDescription";
            this.labelAddDescription.Size = new System.Drawing.Size(150, 49);
            this.labelAddDescription.TabIndex = 8;
            this.labelAddDescription.Text = "Введите описание на латинице (макс. 255 знаков):";
            // 
            // labelAddSub
            // 
            this.labelAddSub.AutoSize = true;
            this.labelAddSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAddSub.Location = new System.Drawing.Point(627, 0);
            this.labelAddSub.Name = "labelAddSub";
            this.labelAddSub.Size = new System.Drawing.Size(150, 49);
            this.labelAddSub.TabIndex = 9;
            this.labelAddSub.Text = "Не забудьте отправить данные:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Аренда Жилья";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageFind.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSearchHouseroom)).EndInit();
            this.tabPageAdd.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageFind;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView GridViewSearchHouseroom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBoxAddCity;
        private System.Windows.Forms.TextBox textBoxAddStreet;
        private System.Windows.Forms.TextBox textBoxAddPrice;
        private System.Windows.Forms.TextBox textBoxAddDescription;
        private System.Windows.Forms.Button buttonAddHouseroom;
        private System.Windows.Forms.Label labelAddCity;
        private System.Windows.Forms.Label labelAddStreet;
        private System.Windows.Forms.Label labelAddPrice;
        private System.Windows.Forms.Label labelAddDescription;
        private System.Windows.Forms.Label labelAddSub;
    }
}

