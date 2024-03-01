namespace Programming
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
            this.EnumsPage = new System.Windows.Forms.TabPage();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.labelOfEnumsTable = new System.Windows.Forms.Label();
            this.labelOfItemTable = new System.Windows.Forms.Label();
            this.textBoxForIndex = new System.Windows.Forms.TextBox();
            this.EnumsPage.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsPage
            // 
            this.EnumsPage.Controls.Add(this.textBoxForIndex);
            this.EnumsPage.Controls.Add(this.labelOfItemTable);
            this.EnumsPage.Controls.Add(this.labelOfEnumsTable);
            this.EnumsPage.Controls.Add(this.ValuesListBox);
            this.EnumsPage.Controls.Add(this.EnumsListBox);
            this.EnumsPage.Location = new System.Drawing.Point(4, 22);
            this.EnumsPage.Margin = new System.Windows.Forms.Padding(2);
            this.EnumsPage.Name = "EnumsPage";
            this.EnumsPage.Padding = new System.Windows.Forms.Padding(2);
            this.EnumsPage.Size = new System.Drawing.Size(592, 340);
            this.EnumsPage.TabIndex = 0;
            this.EnumsPage.Tag = "";
            this.EnumsPage.Text = "Enums";
            this.EnumsPage.UseVisualStyleBackColor = true;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(154, 32);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(144, 303);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Colors",
            "FormsOfEducation",
            "Genre",
            "Seasons",
            "SmartphoneMakers",
            "WeekDay"});
            this.EnumsListBox.Location = new System.Drawing.Point(7, 32);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(144, 303);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnumsPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(600, 366);
            this.TabControl.TabIndex = 0;
            // 
            // labelOfEnumsTable
            // 
            this.labelOfEnumsTable.AutoSize = true;
            this.labelOfEnumsTable.Location = new System.Drawing.Point(9, 12);
            this.labelOfEnumsTable.Name = "labelOfEnumsTable";
            this.labelOfEnumsTable.Size = new System.Drawing.Size(125, 15);
            this.labelOfEnumsTable.TabIndex = 2;
            this.labelOfEnumsTable.Text = "Choose enumeration:";
            // 
            // labelOfItemTable
            // 
            this.labelOfItemTable.AutoSize = true;
            this.labelOfItemTable.Location = new System.Drawing.Point(151, 12);
            this.labelOfItemTable.Name = "labelOfItemTable";
            this.labelOfItemTable.Size = new System.Drawing.Size(84, 15);
            this.labelOfItemTable.TabIndex = 3;
            this.labelOfItemTable.Text = "Choose value:";
            // 
            // textBoxForIndex
            // 
            this.textBoxForIndex.Location = new System.Drawing.Point(304, 32);
            this.textBoxForIndex.Name = "textBoxForIndex";
            this.textBoxForIndex.Size = new System.Drawing.Size(100, 20);
            this.textBoxForIndex.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.EnumsPage.ResumeLayout(false);
            this.EnumsPage.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage EnumsPage;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label labelOfItemTable;
        private System.Windows.Forms.Label labelOfEnumsTable;
        private System.Windows.Forms.TextBox textBoxForIndex;
    }
}

