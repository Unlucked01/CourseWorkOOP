namespace course_work_FestivalFilmov_Afonin
{
    partial class GuestFestivalForm
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
            this.ButtonCloseGuestTable = new System.Windows.Forms.Button();
            this.ButtonAllDeleteGuest = new System.Windows.Forms.Button();
            this.ButtonDeleteGuest = new System.Windows.Forms.Button();
            this.ButtonCreateGuest = new System.Windows.Forms.Button();
            this.TextBoxCountGuest = new System.Windows.Forms.TextBox();
            this.labelCountGuest = new System.Windows.Forms.Label();
            this.dataGridViewGuestTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuestTable)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCloseGuestTable
            // 
            this.ButtonCloseGuestTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCloseGuestTable.Location = new System.Drawing.Point(792, 542);
            this.ButtonCloseGuestTable.Name = "ButtonCloseGuestTable";
            this.ButtonCloseGuestTable.Size = new System.Drawing.Size(123, 48);
            this.ButtonCloseGuestTable.TabIndex = 13;
            this.ButtonCloseGuestTable.Text = "Закрыть форму";
            this.ButtonCloseGuestTable.UseVisualStyleBackColor = true;
            this.ButtonCloseGuestTable.Click += new System.EventHandler(this.ButtonCloseGuestTable_Click);
            // 
            // ButtonAllDeleteGuest
            // 
            this.ButtonAllDeleteGuest.Location = new System.Drawing.Point(11, 80);
            this.ButtonAllDeleteGuest.Name = "ButtonAllDeleteGuest";
            this.ButtonAllDeleteGuest.Size = new System.Drawing.Size(123, 48);
            this.ButtonAllDeleteGuest.TabIndex = 12;
            this.ButtonAllDeleteGuest.Text = "Удалить всех гостей";
            this.ButtonAllDeleteGuest.UseVisualStyleBackColor = true;
            this.ButtonAllDeleteGuest.Click += new System.EventHandler(this.ButtonAllDeleteGuest_Click);
            // 
            // ButtonDeleteGuest
            // 
            this.ButtonDeleteGuest.Location = new System.Drawing.Point(159, 26);
            this.ButtonDeleteGuest.Name = "ButtonDeleteGuest";
            this.ButtonDeleteGuest.Size = new System.Drawing.Size(123, 48);
            this.ButtonDeleteGuest.TabIndex = 11;
            this.ButtonDeleteGuest.Text = "Удалить гостя";
            this.ButtonDeleteGuest.UseVisualStyleBackColor = true;
            this.ButtonDeleteGuest.Click += new System.EventHandler(this.ButtonDeleteGuest_Click);
            // 
            // ButtonCreateGuest
            // 
            this.ButtonCreateGuest.Location = new System.Drawing.Point(11, 26);
            this.ButtonCreateGuest.Name = "ButtonCreateGuest";
            this.ButtonCreateGuest.Size = new System.Drawing.Size(123, 48);
            this.ButtonCreateGuest.TabIndex = 10;
            this.ButtonCreateGuest.Text = "Добавить гостя";
            this.ButtonCreateGuest.UseVisualStyleBackColor = true;
            this.ButtonCreateGuest.Click += new System.EventHandler(this.ButtonCreateGuest_Click);
            // 
            // TextBoxCountGuest
            // 
            this.TextBoxCountGuest.Location = new System.Drawing.Point(169, 151);
            this.TextBoxCountGuest.Name = "TextBoxCountGuest";
            this.TextBoxCountGuest.Size = new System.Drawing.Size(113, 22);
            this.TextBoxCountGuest.TabIndex = 9;
            // 
            // labelCountGuest
            // 
            this.labelCountGuest.AutoSize = true;
            this.labelCountGuest.Location = new System.Drawing.Point(8, 151);
            this.labelCountGuest.Name = "labelCountGuest";
            this.labelCountGuest.Size = new System.Drawing.Size(132, 16);
            this.labelCountGuest.TabIndex = 8;
            this.labelCountGuest.Text = "Количество гостей";
            // 
            // dataGridViewGuestTable
            // 
            this.dataGridViewGuestTable.AllowUserToAddRows = false;
            this.dataGridViewGuestTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGuestTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewGuestTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuestTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewGuestTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGuestTable.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewGuestTable.Name = "dataGridViewGuestTable";
            this.dataGridViewGuestTable.ReadOnly = true;
            this.dataGridViewGuestTable.RowHeadersVisible = false;
            this.dataGridViewGuestTable.RowHeadersWidth = 51;
            this.dataGridViewGuestTable.RowTemplate.Height = 24;
            this.dataGridViewGuestTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGuestTable.Size = new System.Drawing.Size(891, 331);
            this.dataGridViewGuestTable.TabIndex = 7;
            this.dataGridViewGuestTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGuestTable_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя гостя";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия гостя";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Номер места гостя";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Электронная почта гостя";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Фильтрация поля";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(352, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 150);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск и Фильтрация";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 3);
            this.panel1.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "имени",
            "фамилии",
            "номеру места"});
            this.comboBox2.Location = new System.Drawing.Point(165, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(177, 24);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Фильтрация поля";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "имени",
            "фамилии",
            "номеру места",
            "электронной почте"});
            this.comboBox1.Location = new System.Drawing.Point(165, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(377, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.TextBoxCountGuest);
            this.groupBox2.Controls.Add(this.labelCountGuest);
            this.groupBox2.Controls.Add(this.ButtonCreateGuest);
            this.groupBox2.Controls.Add(this.ButtonAllDeleteGuest);
            this.groupBox2.Controls.Add(this.ButtonDeleteGuest);
            this.groupBox2.Location = new System.Drawing.Point(16, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 194);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Взаимодействие";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewGuestTable);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 352);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Гости";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "по";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(400, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 34);
            this.button2.TabIndex = 30;
            this.button2.Text = "Сбросить поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(400, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(166, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 22);
            this.textBox2.TabIndex = 31;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // GuestFestivalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 602);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ButtonCloseGuestTable);
            this.Controls.Add(this.groupBox1);
            this.Name = "GuestFestivalForm";
            this.Text = "GuestFestivalForm";
            this.Load += new System.EventHandler(this.GuestFestivalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuestTable)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCloseGuestTable;
        private System.Windows.Forms.Button ButtonAllDeleteGuest;
        private System.Windows.Forms.Button ButtonDeleteGuest;
        private System.Windows.Forms.Button ButtonCreateGuest;
        private System.Windows.Forms.TextBox TextBoxCountGuest;
        private System.Windows.Forms.Label labelCountGuest;
        private System.Windows.Forms.DataGridView dataGridViewGuestTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
    }
}