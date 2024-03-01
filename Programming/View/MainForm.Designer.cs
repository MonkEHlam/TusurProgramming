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
            this.groupBoxForSeasons = new System.Windows.Forms.GroupBox();
            this.groupBoxForWeekDayParser = new System.Windows.Forms.GroupBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.labelForWeekdayInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxForParse = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelForChosenValue = new System.Windows.Forms.Label();
            this.textBoxForIndex = new System.Windows.Forms.TextBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.labelOfEnumsTable = new System.Windows.Forms.Label();
            this.labelOfItemTable = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.EnumsPage.SuspendLayout();
            this.groupBoxForWeekDayParser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsPage
            // 
            this.EnumsPage.Controls.Add(this.groupBoxForSeasons);
            this.EnumsPage.Controls.Add(this.groupBoxForWeekDayParser);
            this.EnumsPage.Controls.Add(this.groupBox1);
            this.EnumsPage.Location = new System.Drawing.Point(4, 22);
            this.EnumsPage.Margin = new System.Windows.Forms.Padding(2);
            this.EnumsPage.Name = "EnumsPage";
            this.EnumsPage.Padding = new System.Windows.Forms.Padding(2);
            this.EnumsPage.Size = new System.Drawing.Size(592, 335);
            this.EnumsPage.TabIndex = 0;
            this.EnumsPage.Tag = "";
            this.EnumsPage.Text = "Enums";
            this.EnumsPage.UseVisualStyleBackColor = true;
            // 
            // groupBoxForSeasons
            // 
            this.groupBoxForSeasons.Location = new System.Drawing.Point(309, 215);
            this.groupBoxForSeasons.Name = "groupBoxForSeasons";
            this.groupBoxForSeasons.Size = new System.Drawing.Size(275, 110);
            this.groupBoxForSeasons.TabIndex = 7;
            this.groupBoxForSeasons.TabStop = false;
            this.groupBoxForSeasons.Text = "Season Handler";
            // 
            // groupBoxForWeekDayParser
            // 
            this.groupBoxForWeekDayParser.Controls.Add(this.ParseButton);
            this.groupBoxForWeekDayParser.Controls.Add(this.labelForWeekdayInfo);
            this.groupBoxForWeekDayParser.Controls.Add(this.label1);
            this.groupBoxForWeekDayParser.Controls.Add(this.TextBoxForParse);
            this.groupBoxForWeekDayParser.Location = new System.Drawing.Point(4, 215);
            this.groupBoxForWeekDayParser.Name = "groupBoxForWeekDayParser";
            this.groupBoxForWeekDayParser.Size = new System.Drawing.Size(299, 110);
            this.groupBoxForWeekDayParser.TabIndex = 6;
            this.groupBoxForWeekDayParser.TabStop = false;
            this.groupBoxForWeekDayParser.Text = "WeekDay Parser";
            // 
            // ParseButton
            // 
            this.ParseButton.Enabled = false;
            this.ParseButton.Location = new System.Drawing.Point(192, 58);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(101, 23);
            this.ParseButton.TabIndex = 3;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // labelForWeekdayInfo
            // 
            this.labelForWeekdayInfo.AutoSize = true;
            this.labelForWeekdayInfo.Location = new System.Drawing.Point(5, 88);
            this.labelForWeekdayInfo.Name = "labelForWeekdayInfo";
            this.labelForWeekdayInfo.Size = new System.Drawing.Size(0, 15);
            this.labelForWeekdayInfo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type weekday for parsing";
            // 
            // TextBoxForParse
            // 
            this.TextBoxForParse.Location = new System.Drawing.Point(6, 61);
            this.TextBoxForParse.Name = "TextBoxForParse";
            this.TextBoxForParse.Size = new System.Drawing.Size(180, 20);
            this.TextBoxForParse.TabIndex = 0;
            this.TextBoxForParse.TextChanged += new System.EventHandler(this.TextBoxForParse_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelForChosenValue);
            this.groupBox1.Controls.Add(this.textBoxForIndex);
            this.groupBox1.Controls.Add(this.EnumsListBox);
            this.groupBox1.Controls.Add(this.ValuesListBox);
            this.groupBox1.Controls.Add(this.labelOfEnumsTable);
            this.groupBox1.Controls.Add(this.labelOfItemTable);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 206);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enumerations";
            // 
            // labelForChosenValue
            // 
            this.labelForChosenValue.AutoSize = true;
            this.labelForChosenValue.Location = new System.Drawing.Point(306, 20);
            this.labelForChosenValue.Name = "labelForChosenValue";
            this.labelForChosenValue.Size = new System.Drawing.Size(55, 15);
            this.labelForChosenValue.TabIndex = 5;
            this.labelForChosenValue.Text = "Int value:";
            // 
            // textBoxForIndex
            // 
            this.textBoxForIndex.Location = new System.Drawing.Point(306, 38);
            this.textBoxForIndex.Name = "textBoxForIndex";
            this.textBoxForIndex.Size = new System.Drawing.Size(100, 20);
            this.textBoxForIndex.TabIndex = 4;
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
            this.EnumsListBox.Location = new System.Drawing.Point(9, 38);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(144, 147);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(157, 38);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(144, 147);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // labelOfEnumsTable
            // 
            this.labelOfEnumsTable.AutoSize = true;
            this.labelOfEnumsTable.Location = new System.Drawing.Point(10, 21);
            this.labelOfEnumsTable.Name = "labelOfEnumsTable";
            this.labelOfEnumsTable.Size = new System.Drawing.Size(125, 15);
            this.labelOfEnumsTable.TabIndex = 2;
            this.labelOfEnumsTable.Text = "Choose enumeration:";
            // 
            // labelOfItemTable
            // 
            this.labelOfItemTable.AutoSize = true;
            this.labelOfItemTable.Location = new System.Drawing.Point(154, 21);
            this.labelOfItemTable.Name = "labelOfItemTable";
            this.labelOfItemTable.Size = new System.Drawing.Size(84, 15);
            this.labelOfItemTable.TabIndex = 3;
            this.labelOfItemTable.Text = "Choose value:";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnumsPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(600, 361);
            this.TabControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 361);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.EnumsPage.ResumeLayout(false);
            this.groupBoxForWeekDayParser.ResumeLayout(false);
            this.groupBoxForWeekDayParser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxForSeasons;
        private System.Windows.Forms.GroupBox groupBoxForWeekDayParser;
        private System.Windows.Forms.Label labelForChosenValue;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.Label labelForWeekdayInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxForParse;
    }
}

