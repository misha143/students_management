namespace WindowsFormsApp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_create = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_save = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_prev = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_next = new System.Windows.Forms.ToolStripMenuItem();
            this.студеннтыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_add_student = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_del_student = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pole_name = new System.Windows.Forms.TextBox();
            this.pole_surname = new System.Windows.Forms.TextBox();
            this.pole_faculty = new System.Windows.Forms.TextBox();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.search_combobox = new System.Windows.Forms.ComboBox();
            this.btn_magistr = new System.Windows.Forms.Button();
            this.bakalavr_label = new System.Windows.Forms.Label();
            this.bakalavr_data = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file_create,
            this.menu_file_open,
            this.menu_file_save});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // menu_file_create
            // 
            this.menu_file_create.Name = "menu_file_create";
            this.menu_file_create.Size = new System.Drawing.Size(261, 22);
            this.menu_file_create.Text = "Создать файл со студентами";
            this.menu_file_create.Click += new System.EventHandler(this.menu_file_create_Click);
            // 
            // menu_file_open
            // 
            this.menu_file_open.Name = "menu_file_open";
            this.menu_file_open.Size = new System.Drawing.Size(261, 22);
            this.menu_file_open.Text = "Открыть файл со студентами";
            this.menu_file_open.Click += new System.EventHandler(this.menu_file_open_Click);
            // 
            // menu_file_save
            // 
            this.menu_file_save.Name = "menu_file_save";
            this.menu_file_save.Size = new System.Drawing.Size(261, 22);
            this.menu_file_save.Text = "Сохранить файл со студентами";
            this.menu_file_save.Click += new System.EventHandler(this.menu_file_save_Click);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_prev,
            this.menu_next});
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // menu_prev
            // 
            this.menu_prev.Name = "menu_prev";
            this.menu_prev.Size = new System.Drawing.Size(154, 22);
            this.menu_prev.Text = "Предыдущий";
            this.menu_prev.Click += new System.EventHandler(this.menu_prev_Click);
            // 
            // menu_next
            // 
            this.menu_next.Name = "menu_next";
            this.menu_next.Size = new System.Drawing.Size(154, 22);
            this.menu_next.Text = "Следующий";
            this.menu_next.Click += new System.EventHandler(this.menu_next_Click);
            // 
            // студеннтыToolStripMenuItem
            // 
            this.студеннтыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_add_student,
            this.menu_del_student});
            this.студеннтыToolStripMenuItem.Name = "студеннтыToolStripMenuItem";
            this.студеннтыToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.студеннтыToolStripMenuItem.Text = "Студенты";
            // 
            // menu_add_student
            // 
            this.menu_add_student.Name = "menu_add_student";
            this.menu_add_student.Size = new System.Drawing.Size(236, 22);
            this.menu_add_student.Text = "Добавить нового студента";
            this.menu_add_student.Click += new System.EventHandler(this.menu_add_student_Click);
            // 
            // menu_del_student
            // 
            this.menu_del_student.Name = "menu_del_student";
            this.menu_del_student.Size = new System.Drawing.Size(236, 22);
            this.menu_del_student.Text = "Удалить текущего студента";
            this.menu_del_student.Click += new System.EventHandler(this.menu_del_student_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.просмотрToolStripMenuItem,
            this.студеннтыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(594, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Факультет";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pole_name
            // 
            this.pole_name.Location = new System.Drawing.Point(207, 101);
            this.pole_name.Name = "pole_name";
            this.pole_name.Size = new System.Drawing.Size(207, 26);
            this.pole_name.TabIndex = 2;
            this.pole_name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pole_name_KeyUp);
            // 
            // pole_surname
            // 
            this.pole_surname.Location = new System.Drawing.Point(207, 145);
            this.pole_surname.Name = "pole_surname";
            this.pole_surname.Size = new System.Drawing.Size(207, 26);
            this.pole_surname.TabIndex = 2;
            this.pole_surname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pole_surname_KeyUp);
            // 
            // pole_faculty
            // 
            this.pole_faculty.Location = new System.Drawing.Point(207, 193);
            this.pole_faculty.Name = "pole_faculty";
            this.pole_faculty.Size = new System.Drawing.Size(207, 26);
            this.pole_faculty.TabIndex = 2;
            this.pole_faculty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pole_faculty_KeyUp);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(122, 306);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(136, 35);
            this.btn_prev.TabIndex = 3;
            this.btn_prev.Text = "Предыдущий";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(326, 306);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(136, 35);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = "Следующий";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.search_textbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.search_combobox);
            this.groupBox1.Location = new System.Drawing.Point(37, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 68);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(285, 25);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(210, 26);
            this.search_textbox.TabIndex = 2;
            this.search_textbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.search_textbox_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "=";
            // 
            // search_combobox
            // 
            this.search_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.search_combobox.FormattingEnabled = true;
            this.search_combobox.Items.AddRange(new object[] {
            "Имя",
            "Фамилия",
            "Факультет"});
            this.search_combobox.Location = new System.Drawing.Point(10, 25);
            this.search_combobox.Name = "search_combobox";
            this.search_combobox.Size = new System.Drawing.Size(206, 28);
            this.search_combobox.TabIndex = 0;
            this.search_combobox.SelectedValueChanged += new System.EventHandler(this.search_combobox_SelectedValueChanged_1);
            // 
            // btn_magistr
            // 
            this.btn_magistr.Location = new System.Drawing.Point(207, 245);
            this.btn_magistr.Name = "btn_magistr";
            this.btn_magistr.Size = new System.Drawing.Size(207, 35);
            this.btn_magistr.TabIndex = 3;
            this.btn_magistr.Text = "Сделать магистром";
            this.btn_magistr.UseVisualStyleBackColor = true;
            this.btn_magistr.Visible = false;
            this.btn_magistr.Click += new System.EventHandler(this.btn_magistr_Click);
            // 
            // bakalavr_label
            // 
            this.bakalavr_label.AutoSize = true;
            this.bakalavr_label.Location = new System.Drawing.Point(31, 242);
            this.bakalavr_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bakalavr_label.Name = "bakalavr_label";
            this.bakalavr_label.Size = new System.Drawing.Size(153, 40);
            this.bakalavr_label.TabIndex = 1;
            this.bakalavr_label.Text = "Данные о дипломе\r\nбакалавра";
            this.bakalavr_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.bakalavr_label.Visible = false;
            // 
            // bakalavr_data
            // 
            this.bakalavr_data.Location = new System.Drawing.Point(207, 239);
            this.bakalavr_data.Name = "bakalavr_data";
            this.bakalavr_data.Size = new System.Drawing.Size(207, 26);
            this.bakalavr_data.TabIndex = 2;
            this.bakalavr_data.Visible = false;
            this.bakalavr_data.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bakalavr_data_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_magistr);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.bakalavr_data);
            this.Controls.Add(this.pole_faculty);
            this.Controls.Add(this.pole_surname);
            this.Controls.Add(this.bakalavr_label);
            this.Controls.Add(this.pole_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Работа со студентами";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_file_create;
        private System.Windows.Forms.ToolStripMenuItem menu_file_open;
        private System.Windows.Forms.ToolStripMenuItem menu_file_save;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_prev;
        private System.Windows.Forms.ToolStripMenuItem menu_next;
        private System.Windows.Forms.ToolStripMenuItem студеннтыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_add_student;
        private System.Windows.Forms.ToolStripMenuItem menu_del_student;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pole_name;
        private System.Windows.Forms.TextBox pole_surname;
        private System.Windows.Forms.TextBox pole_faculty;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox search_combobox;
        private System.Windows.Forms.Button btn_magistr;
        private System.Windows.Forms.Label bakalavr_label;
        private System.Windows.Forms.TextBox bakalavr_data;
    }
}

