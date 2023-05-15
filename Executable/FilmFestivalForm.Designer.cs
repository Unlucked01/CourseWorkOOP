namespace course_work_FestivalFilmov_Afonin
{
    partial class FilmFestivalForm
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
            this.dataGridViewFilmTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCountFilm = new System.Windows.Forms.Label();
            this.TextBoxCountFilm = new System.Windows.Forms.TextBox();
            this.ButtonCreateFilm = new System.Windows.Forms.Button();
            this.ButtonDeleteFilm = new System.Windows.Forms.Button();
            this.ButtonAllDeleteFilm = new System.Windows.Forms.Button();
            this.ButtonCloseFilmTable = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFilmTable
            // 
            this.dataGridViewFilmTable.AllowUserToAddRows = false;
            this.dataGridViewFilmTable.AllowUserToResizeColumns = false;
            this.dataGridViewFilmTable.AllowUserToResizeRows = false;
            this.dataGridViewFilmTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFilmTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFilmTable.ColumnHeadersHeight = 29;
            this.dataGridViewFilmTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewFilmTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewFilmTable.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewFilmTable.Name = "dataGridViewFilmTable";
            this.dataGridViewFilmTable.ReadOnly = true;
            this.dataGridViewFilmTable.RowHeadersVisible = false;
            this.dataGridViewFilmTable.RowHeadersWidth = 51;
            this.dataGridViewFilmTable.RowTemplate.Height = 24;
            this.dataGridViewFilmTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFilmTable.Size = new System.Drawing.Size(880, 325);
            this.dataGridViewFilmTable.TabIndex = 0;
            this.dataGridViewFilmTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFilmTable_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название фильма";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Номинация фильма";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Цена билета на фестиваль";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Рейтинг фильма";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // labelCountFilm
            // 
            this.labelCountFilm.AutoSize = true;
            this.labelCountFilm.Location = new System.Drawing.Point(11, 151);
            this.labelCountFilm.Name = "labelCountFilm";
            this.labelCountFilm.Size = new System.Drawing.Size(147, 16);
            this.labelCountFilm.TabIndex = 1;
            this.labelCountFilm.Text = "Количество фильмов";
            // 
            // TextBoxCountFilm
            // 
            this.TextBoxCountFilm.Location = new System.Drawing.Point(163, 145);
            this.TextBoxCountFilm.Name = "TextBoxCountFilm";
            this.TextBoxCountFilm.ReadOnly = true;
            this.TextBoxCountFilm.Size = new System.Drawing.Size(113, 22);
            this.TextBoxCountFilm.TabIndex = 2;
            // 
            // ButtonCreateFilm
            // 
            this.ButtonCreateFilm.Location = new System.Drawing.Point(11, 26);
            this.ButtonCreateFilm.Name = "ButtonCreateFilm";
            this.ButtonCreateFilm.Size = new System.Drawing.Size(123, 48);
            this.ButtonCreateFilm.TabIndex = 3;
            this.ButtonCreateFilm.Text = "Добавить фильм";
            this.ButtonCreateFilm.UseVisualStyleBackColor = true;
            this.ButtonCreateFilm.Click += new System.EventHandler(this.ButtonCreateFilm_Click);
            // 
            // ButtonDeleteFilm
            // 
            this.ButtonDeleteFilm.Location = new System.Drawing.Point(153, 26);
            this.ButtonDeleteFilm.Name = "ButtonDeleteFilm";
            this.ButtonDeleteFilm.Size = new System.Drawing.Size(123, 48);
            this.ButtonDeleteFilm.TabIndex = 4;
            this.ButtonDeleteFilm.Text = "Удалить фильм";
            this.ButtonDeleteFilm.UseVisualStyleBackColor = true;
            this.ButtonDeleteFilm.Click += new System.EventHandler(this.ButtonDeleteFilm_Click);
            // 
            // ButtonAllDeleteFilm
            // 
            this.ButtonAllDeleteFilm.Location = new System.Drawing.Point(11, 80);
            this.ButtonAllDeleteFilm.Name = "ButtonAllDeleteFilm";
            this.ButtonAllDeleteFilm.Size = new System.Drawing.Size(123, 48);
            this.ButtonAllDeleteFilm.TabIndex = 5;
            this.ButtonAllDeleteFilm.Text = "Удалить все фильмы";
            this.ButtonAllDeleteFilm.UseVisualStyleBackColor = true;
            this.ButtonAllDeleteFilm.Click += new System.EventHandler(this.ButtonAllDeleteFilm_Click);
            // 
            // ButtonCloseFilmTable
            // 
            this.ButtonCloseFilmTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCloseFilmTable.Location = new System.Drawing.Point(777, 526);
            this.ButtonCloseFilmTable.Name = "ButtonCloseFilmTable";
            this.ButtonCloseFilmTable.Size = new System.Drawing.Size(123, 48);
            this.ButtonCloseFilmTable.TabIndex = 6;
            this.ButtonCloseFilmTable.Text = "Закрыть форму";
            this.ButtonCloseFilmTable.UseVisualStyleBackColor = true;
            this.ButtonCloseFilmTable.Click += new System.EventHandler(this.ButtonCloseFilmTable_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(348, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Фильтрация поля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "названию фильма",
            "номинации фильма",
            "цене билета",
            "рейтингу фильма"});
            this.comboBox1.Location = new System.Drawing.Point(152, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridViewFilmTable);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 335);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильмы";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.ButtonCreateFilm);
            this.groupBox2.Controls.Add(this.ButtonDeleteFilm);
            this.groupBox2.Controls.Add(this.ButtonAllDeleteFilm);
            this.groupBox2.Controls.Add(this.TextBoxCountFilm);
            this.groupBox2.Controls.Add(this.labelCountFilm);
            this.groupBox2.Location = new System.Drawing.Point(1, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 188);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Взаимодействие";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(337, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 159);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск и Фильтрация";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 3);
            this.panel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Поиск по названию фильма";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(215, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 22);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(410, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(410, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 33);
            this.button2.TabIndex = 20;
            this.button2.Text = "Сбросить поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FilmFestivalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 579);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonCloseFilmTable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "FilmFestivalForm";
            this.Text = "FilmFestivalForm";
            this.Load += new System.EventHandler(this.FilmFestivalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFilmTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label labelCountFilm;
        private System.Windows.Forms.TextBox TextBoxCountFilm;
        private System.Windows.Forms.Button ButtonCreateFilm;
        private System.Windows.Forms.Button ButtonDeleteFilm;
        private System.Windows.Forms.Button ButtonAllDeleteFilm;
        private System.Windows.Forms.Button ButtonCloseFilmTable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}