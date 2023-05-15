namespace course_work_FestivalFilmov_Afonin
{
    partial class JuryFestivalForm
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
            this.ButtonCloseJuryTable = new System.Windows.Forms.Button();
            this.ButtonAllDeleteJury = new System.Windows.Forms.Button();
            this.ButtonDeleteJury = new System.Windows.Forms.Button();
            this.ButtonCreateJury = new System.Windows.Forms.Button();
            this.TextBoxCountJury = new System.Windows.Forms.TextBox();
            this.labelCountJury = new System.Windows.Forms.Label();
            this.dataGridViewJuryTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJuryTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCloseJuryTable
            // 
            this.ButtonCloseJuryTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCloseJuryTable.Location = new System.Drawing.Point(826, 481);
            this.ButtonCloseJuryTable.Name = "ButtonCloseJuryTable";
            this.ButtonCloseJuryTable.Size = new System.Drawing.Size(123, 48);
            this.ButtonCloseJuryTable.TabIndex = 13;
            this.ButtonCloseJuryTable.Text = "Закрыть форму";
            this.ButtonCloseJuryTable.UseVisualStyleBackColor = true;
            this.ButtonCloseJuryTable.Click += new System.EventHandler(this.ButtonCloseJuryTable_Click);
            // 
            // ButtonAllDeleteJury
            // 
            this.ButtonAllDeleteJury.Location = new System.Drawing.Point(6, 85);
            this.ButtonAllDeleteJury.Name = "ButtonAllDeleteJury";
            this.ButtonAllDeleteJury.Size = new System.Drawing.Size(123, 48);
            this.ButtonAllDeleteJury.TabIndex = 12;
            this.ButtonAllDeleteJury.Text = "Удалить всех членов жюри";
            this.ButtonAllDeleteJury.UseVisualStyleBackColor = true;
            this.ButtonAllDeleteJury.Click += new System.EventHandler(this.ButtonAllDeleteJury_Click);
            // 
            // ButtonDeleteJury
            // 
            this.ButtonDeleteJury.Location = new System.Drawing.Point(148, 21);
            this.ButtonDeleteJury.Name = "ButtonDeleteJury";
            this.ButtonDeleteJury.Size = new System.Drawing.Size(123, 48);
            this.ButtonDeleteJury.TabIndex = 11;
            this.ButtonDeleteJury.Text = "Удалить члена жюри";
            this.ButtonDeleteJury.UseVisualStyleBackColor = true;
            this.ButtonDeleteJury.Click += new System.EventHandler(this.ButtonDeleteJury_Click);
            // 
            // ButtonCreateJury
            // 
            this.ButtonCreateJury.Location = new System.Drawing.Point(6, 21);
            this.ButtonCreateJury.Name = "ButtonCreateJury";
            this.ButtonCreateJury.Size = new System.Drawing.Size(123, 48);
            this.ButtonCreateJury.TabIndex = 10;
            this.ButtonCreateJury.Text = "Добавить члена жюри";
            this.ButtonCreateJury.UseVisualStyleBackColor = true;
            this.ButtonCreateJury.Click += new System.EventHandler(this.ButtonCreateJury_Click);
            // 
            // TextBoxCountJury
            // 
            this.TextBoxCountJury.Location = new System.Drawing.Point(179, 136);
            this.TextBoxCountJury.Name = "TextBoxCountJury";
            this.TextBoxCountJury.ReadOnly = true;
            this.TextBoxCountJury.Size = new System.Drawing.Size(113, 22);
            this.TextBoxCountJury.TabIndex = 9;
            // 
            // labelCountJury
            // 
            this.labelCountJury.AutoSize = true;
            this.labelCountJury.Location = new System.Drawing.Point(-1, 142);
            this.labelCountJury.Name = "labelCountJury";
            this.labelCountJury.Size = new System.Drawing.Size(174, 16);
            this.labelCountJury.TabIndex = 8;
            this.labelCountJury.Text = "Количество членов жюри";
            // 
            // dataGridViewJuryTable
            // 
            this.dataGridViewJuryTable.AllowUserToAddRows = false;
            this.dataGridViewJuryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewJuryTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewJuryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJuryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewJuryTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewJuryTable.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewJuryTable.Name = "dataGridViewJuryTable";
            this.dataGridViewJuryTable.ReadOnly = true;
            this.dataGridViewJuryTable.RowHeadersVisible = false;
            this.dataGridViewJuryTable.RowHeadersWidth = 51;
            this.dataGridViewJuryTable.RowTemplate.Height = 24;
            this.dataGridViewJuryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewJuryTable.Size = new System.Drawing.Size(932, 304);
            this.dataGridViewJuryTable.TabIndex = 7;
            this.dataGridViewJuryTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJuryTable_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя члена жюри";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия члена жюри";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Должность члена жюри";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelCountJury);
            this.groupBox2.Controls.Add(this.TextBoxCountJury);
            this.groupBox2.Controls.Add(this.ButtonCreateJury);
            this.groupBox2.Controls.Add(this.ButtonAllDeleteJury);
            this.groupBox2.Controls.Add(this.ButtonDeleteJury);
            this.groupBox2.Location = new System.Drawing.Point(12, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 165);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Взаимодействие";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(363, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 138);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск и фильтрация";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "имени члена жюри",
            "фамилии члена жюри"});
            this.comboBox2.Location = new System.Drawing.Point(157, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(184, 24);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Поиск по";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 3);
            this.panel1.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(376, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "имени члена жюри",
            "фамилии члена жюри",
            "должности члена жюри"});
            this.comboBox1.Location = new System.Drawing.Point(157, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridViewJuryTable);
            this.groupBox1.Location = new System.Drawing.Point(11, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 325);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Жюри";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Фильтрация поля";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "по";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(455, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 34);
            this.button2.TabIndex = 26;
            this.button2.Text = "Сбросить поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(455, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(158, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 22);
            this.textBox2.TabIndex = 27;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // JuryFestivalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 541);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ButtonCloseJuryTable);
            this.Controls.Add(this.groupBox1);
            this.Name = "JuryFestivalForm";
            this.Text = "JuryFestivalForm";
            this.Load += new System.EventHandler(this.JuryFestivalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJuryTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCloseJuryTable;
        private System.Windows.Forms.Button ButtonAllDeleteJury;
        private System.Windows.Forms.Button ButtonDeleteJury;
        private System.Windows.Forms.Button ButtonCreateJury;
        private System.Windows.Forms.TextBox TextBoxCountJury;
        private System.Windows.Forms.Label labelCountJury;
        private System.Windows.Forms.DataGridView dataGridViewJuryTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
    }
}