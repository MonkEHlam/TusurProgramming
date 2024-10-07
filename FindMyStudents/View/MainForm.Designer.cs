namespace FindMyStudents
{
    partial class MainForm
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
            this.StudentsListBox = new System.Windows.Forms.ListBox();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.RemoveStudentButton = new System.Windows.Forms.Button();
            this.SelectedStudentGroupBox = new System.Windows.Forms.GroupBox();
            this.EducationFormComboBox = new System.Windows.Forms.ComboBox();
            this.FacultyComboBox = new System.Windows.Forms.ComboBox();
            this.EducationFormLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.FacultyLabel = new System.Windows.Forms.Label();
            this.GroupTextBox = new System.Windows.Forms.TextBox();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.SelectedStudentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentsListBox
            // 
            this.StudentsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentsListBox.FormattingEnabled = true;
            this.StudentsListBox.Location = new System.Drawing.Point(3, 3);
            this.StudentsListBox.Name = "StudentsListBox";
            this.StudentsListBox.Size = new System.Drawing.Size(309, 420);
            this.StudentsListBox.TabIndex = 0;
            this.StudentsListBox.SelectedIndexChanged += new System.EventHandler(this.StudentsListBox_SelectedIndexChanged);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddStudentButton.Location = new System.Drawing.Point(12, 439);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(50, 50);
            this.AddStudentButton.TabIndex = 1;
            this.AddStudentButton.Text = "+";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveChangesButton.Location = new System.Drawing.Point(882, 439);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(50, 50);
            this.SaveChangesButton.TabIndex = 2;
            this.SaveChangesButton.Text = "Save";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // RemoveStudentButton
            // 
            this.RemoveStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveStudentButton.Enabled = false;
            this.RemoveStudentButton.Location = new System.Drawing.Point(68, 439);
            this.RemoveStudentButton.Name = "RemoveStudentButton";
            this.RemoveStudentButton.Size = new System.Drawing.Size(50, 50);
            this.RemoveStudentButton.TabIndex = 3;
            this.RemoveStudentButton.Text = "-";
            this.RemoveStudentButton.UseVisualStyleBackColor = true;
            this.RemoveStudentButton.Click += new System.EventHandler(this.RemoveStudentButton_Click);
            // 
            // SelectedStudentGroupBox
            // 
            this.SelectedStudentGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedStudentGroupBox.Controls.Add(this.EducationFormComboBox);
            this.SelectedStudentGroupBox.Controls.Add(this.FacultyComboBox);
            this.SelectedStudentGroupBox.Controls.Add(this.EducationFormLabel);
            this.SelectedStudentGroupBox.Controls.Add(this.IdTextBox);
            this.SelectedStudentGroupBox.Controls.Add(this.IdLabel);
            this.SelectedStudentGroupBox.Controls.Add(this.FacultyLabel);
            this.SelectedStudentGroupBox.Controls.Add(this.GroupTextBox);
            this.SelectedStudentGroupBox.Controls.Add(this.GroupLabel);
            this.SelectedStudentGroupBox.Controls.Add(this.FullNameTextBox);
            this.SelectedStudentGroupBox.Controls.Add(this.FullNameLabel);
            this.SelectedStudentGroupBox.Enabled = false;
            this.SelectedStudentGroupBox.Location = new System.Drawing.Point(318, 3);
            this.SelectedStudentGroupBox.Name = "SelectedStudentGroupBox";
            this.SelectedStudentGroupBox.Size = new System.Drawing.Size(616, 185);
            this.SelectedStudentGroupBox.TabIndex = 4;
            this.SelectedStudentGroupBox.TabStop = false;
            this.SelectedStudentGroupBox.Text = "Выбранный студент";
            // 
            // EducationFormComboBox
            // 
            this.EducationFormComboBox.FormattingEnabled = true;
            this.EducationFormComboBox.Location = new System.Drawing.Point(151, 150);
            this.EducationFormComboBox.Name = "EducationFormComboBox";
            this.EducationFormComboBox.Size = new System.Drawing.Size(459, 21);
            this.EducationFormComboBox.TabIndex = 11;
            this.EducationFormComboBox.SelectedIndexChanged += new System.EventHandler(this.EducationFormComboBox_SelectedIndexChanged);
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.FormattingEnabled = true;
            this.FacultyComboBox.Location = new System.Drawing.Point(109, 120);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Size = new System.Drawing.Size(501, 21);
            this.FacultyComboBox.TabIndex = 10;
            this.FacultyComboBox.SelectedIndexChanged += new System.EventHandler(this.FacultyComboBox_SelectedIndexChanged);
            // 
            // EducationFormLabel
            // 
            this.EducationFormLabel.AutoSize = true;
            this.EducationFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EducationFormLabel.Location = new System.Drawing.Point(5, 150);
            this.EducationFormLabel.Name = "EducationFormLabel";
            this.EducationFormLabel.Size = new System.Drawing.Size(140, 20);
            this.EducationFormLabel.TabIndex = 9;
            this.EducationFormLabel.Text = "Форма обучения:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IdTextBox.Location = new System.Drawing.Point(139, 60);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(471, 20);
            this.IdTextBox.TabIndex = 8;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdLabel.Location = new System.Drawing.Point(5, 60);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(128, 20);
            this.IdLabel.TabIndex = 7;
            this.IdLabel.Text = "Номер зачетки:";
            // 
            // FacultyLabel
            // 
            this.FacultyLabel.AutoSize = true;
            this.FacultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FacultyLabel.Location = new System.Drawing.Point(5, 120);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(98, 20);
            this.FacultyLabel.TabIndex = 5;
            this.FacultyLabel.Text = "Факультет:";
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupTextBox.Location = new System.Drawing.Point(76, 90);
            this.GroupTextBox.MaxLength = 10;
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(534, 20);
            this.GroupTextBox.TabIndex = 4;
            this.GroupTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GroupTextBox_KeyPress);
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupLabel.Location = new System.Drawing.Point(5, 90);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(65, 20);
            this.GroupLabel.TabIndex = 3;
            this.GroupLabel.Text = "Группа:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FullNameTextBox.Location = new System.Drawing.Point(74, 30);
            this.FullNameTextBox.MaxLength = 200;
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(536, 20);
            this.FullNameTextBox.TabIndex = 2;
            this.FullNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullNameTextBox_KeyPress);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameLabel.Location = new System.Drawing.Point(5, 30);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(63, 20);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "Ф.И.О.:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.SelectedStudentGroupBox);
            this.Controls.Add(this.RemoveStudentButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.StudentsListBox);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "MainForm";
            this.Text = "Мои студенты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SelectedStudentGroupBox.ResumeLayout(false);
            this.SelectedStudentGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox StudentsListBox;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button RemoveStudentButton;
        private System.Windows.Forms.GroupBox SelectedStudentGroupBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.ComboBox EducationFormComboBox;
        private System.Windows.Forms.ComboBox FacultyComboBox;
        private System.Windows.Forms.Label EducationFormLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label FacultyLabel;
        private System.Windows.Forms.TextBox GroupTextBox;
        private System.Windows.Forms.Label GroupLabel;
    }
}

