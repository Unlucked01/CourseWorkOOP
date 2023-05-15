namespace course_work_FestivalFilmov_Afonin
{
    partial class ParticipantsFestivalForm
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
            this.ButtonCloseParticipantsTable = new System.Windows.Forms.Button();
            this.ButtonAllDeleteParticipants = new System.Windows.Forms.Button();
            this.ButtonDeleteParticipants = new System.Windows.Forms.Button();
            this.ButtonCreateParticipants = new System.Windows.Forms.Button();
            this.TextBoxCountParticipants = new System.Windows.Forms.TextBox();
            this.labelCountParticipants = new System.Windows.Forms.Label();
            this.dataGridViewParticipantsTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipantsTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCloseParticipantsTable
            // 
            this.ButtonCloseParticipantsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCloseParticipantsTable.Location = new System.Drawing.Point(828, 521);
            this.ButtonCloseParticipantsTable.Name = "ButtonCloseParticipantsTable";
            this.ButtonCloseParticipantsTable.Size = new System.Drawing.Size(123, 48);
            this.ButtonCloseParticipantsTable.TabIndex = 13;
            this.ButtonCloseParticipantsTable.Text = "Закрыть форму";
            this.ButtonCloseParticipantsTable.UseVisualStyleBackColor = true;
            this.ButtonCloseParticipantsTable.Click += new System.EventHandler(this.ButtonCloseFilmTable_Click);
            // 
            // ButtonAllDeleteParticipants
            // 
            this.ButtonAllDeleteParticipants.Location = new System.Drawing.Point(2, 75);
            this.ButtonAllDeleteParticipants.Name = "ButtonAllDeleteParticipants";
            this.ButtonAllDeleteParticipants.Size = new System.Drawing.Size(123, 48);
            this.ButtonAllDeleteParticipants.TabIndex = 12;
            this.ButtonAllDeleteParticipants.Text = "Удалить всех участников";
            this.ButtonAllDeleteParticipants.UseVisualStyleBackColor = true;
            this.ButtonAllDeleteParticipants.Click += new System.EventHandler(this.ButtonAllDeleteParticipants_Click);
            // 
            // ButtonDeleteParticipants
            // 
            this.ButtonDeleteParticipants.Location = new System.Drawing.Point(160, 21);
            this.ButtonDeleteParticipants.Name = "ButtonDeleteParticipants";
            this.ButtonDeleteParticipants.Size = new System.Drawing.Size(123, 48);
            this.ButtonDeleteParticipants.TabIndex = 11;
            this.ButtonDeleteParticipants.Text = "Удалить участника";
            this.ButtonDeleteParticipants.UseVisualStyleBackColor = true;
            this.ButtonDeleteParticipants.Click += new System.EventHandler(this.ButtonDeleteParticipants_Click);
            // 
            // ButtonCreateParticipants
            // 
            this.ButtonCreateParticipants.Location = new System.Drawing.Point(2, 21);
            this.ButtonCreateParticipants.Name = "ButtonCreateParticipants";
            this.ButtonCreateParticipants.Size = new System.Drawing.Size(123, 48);
            this.ButtonCreateParticipants.TabIndex = 10;
            this.ButtonCreateParticipants.Text = "Добавить участника";
            this.ButtonCreateParticipants.UseVisualStyleBackColor = true;
            this.ButtonCreateParticipants.Click += new System.EventHandler(this.ButtonCreateParticipants_Click);
            // 
            // TextBoxCountParticipants
            // 
            this.TextBoxCountParticipants.Location = new System.Drawing.Point(185, 499);
            this.TextBoxCountParticipants.Name = "TextBoxCountParticipants";
            this.TextBoxCountParticipants.Size = new System.Drawing.Size(113, 22);
            this.TextBoxCountParticipants.TabIndex = 9;
            // 
            // labelCountParticipants
            // 
            this.labelCountParticipants.AutoSize = true;
            this.labelCountParticipants.Location = new System.Drawing.Point(-1, 134);
            this.labelCountParticipants.Name = "labelCountParticipants";
            this.labelCountParticipants.Size = new System.Drawing.Size(165, 16);
            this.labelCountParticipants.TabIndex = 8;
            this.labelCountParticipants.Text = "Количество участников";
            // 
            // dataGridViewParticipantsTable
            // 
            this.dataGridViewParticipantsTable.AllowUserToAddRows = false;
            this.dataGridViewParticipantsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewParticipantsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewParticipantsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipantsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewParticipantsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewParticipantsTable.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewParticipantsTable.Name = "dataGridViewParticipantsTable";
            this.dataGridViewParticipantsTable.ReadOnly = true;
            this.dataGridViewParticipantsTable.RowHeadersVisible = false;
            this.dataGridViewParticipantsTable.RowHeadersWidth = 51;
            this.dataGridViewParticipantsTable.RowTemplate.Height = 24;
            this.dataGridViewParticipantsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewParticipantsTable.Size = new System.Drawing.Size(933, 335);
            this.dataGridViewParticipantsTable.TabIndex = 7;
            this.dataGridViewParticipantsTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParticipantsTable_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя участника";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия участника";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Город участника";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Возраст участника";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridViewParticipantsTable);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 356);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Участники фестиваля";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonCreateParticipants);
            this.groupBox2.Controls.Add(this.ButtonDeleteParticipants);
            this.groupBox2.Controls.Add(this.ButtonAllDeleteParticipants);
            this.groupBox2.Controls.Add(this.labelCountParticipants);
            this.groupBox2.Location = new System.Drawing.Point(15, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 165);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Взаимодействие";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(388, 374);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(556, 134);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск и фильтрация";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "имя участника",
            "фамилия участника",
            "городу участника"});
            this.comboBox2.Location = new System.Drawing.Point(156, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(176, 24);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
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
            this.panel1.Size = new System.Drawing.Size(557, 3);
            this.panel1.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(364, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "имени участника",
            "фамилии участника",
            "городу участника",
            "возрасту участника"});
            this.comboBox1.Location = new System.Drawing.Point(156, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Фильтрация поля";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "по";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(156, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 22);
            this.textBox2.TabIndex = 26;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(402, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 34);
            this.button2.TabIndex = 28;
            this.button2.Text = "Сбросить поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(402, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ParticipantsFestivalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 576);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ButtonCloseParticipantsTable);
            this.Controls.Add(this.TextBoxCountParticipants);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ParticipantsFestivalForm";
            this.Text = "ParticipantsFestivalForm";
            this.Load += new System.EventHandler(this.ParticipantsFestivalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipantsTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCloseParticipantsTable;
        private System.Windows.Forms.Button ButtonAllDeleteParticipants;
        private System.Windows.Forms.Button ButtonDeleteParticipants;
        private System.Windows.Forms.Button ButtonCreateParticipants;
        private System.Windows.Forms.TextBox TextBoxCountParticipants;
        private System.Windows.Forms.Label labelCountParticipants;
        private System.Windows.Forms.DataGridView dataGridViewParticipantsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}