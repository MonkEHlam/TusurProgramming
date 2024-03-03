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
            this.SeasonsGoButton = new System.Windows.Forms.Button();
            this.ComboBoxForSeasons = new System.Windows.Forms.ComboBox();
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
            this.ClassesPage = new System.Windows.Forms.TabPage();
            this.ClassesTabControl = new System.Windows.Forms.TabControl();
            this.RectanglesPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RectangleColorErrorLabel = new System.Windows.Forms.Label();
            this.RectangleWidthErrorLabel = new System.Windows.Forms.Label();
            this.RectangleLengthErrorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RectangleLengthLabel = new System.Windows.Forms.Label();
            this.RectangleColorTextBox = new System.Windows.Forms.TextBox();
            this.RectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectangleLengthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.MoviesPage = new System.Windows.Forms.TabPage();
            this.FindRectangleBtn = new System.Windows.Forms.Button();
            this.EnumsPage.SuspendLayout();
            this.groupBoxForSeasons.SuspendLayout();
            this.groupBoxForWeekDayParser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.ClassesPage.SuspendLayout();
            this.ClassesTabControl.SuspendLayout();
            this.RectanglesPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsPage
            // 
            this.EnumsPage.Controls.Add(this.groupBoxForSeasons);
            this.EnumsPage.Controls.Add(this.groupBoxForWeekDayParser);
            this.EnumsPage.Controls.Add(this.groupBox1);
            this.EnumsPage.Location = new System.Drawing.Point(4, 25);
            this.EnumsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsPage.Name = "EnumsPage";
            this.EnumsPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsPage.Size = new System.Drawing.Size(792, 415);
            this.EnumsPage.TabIndex = 0;
            this.EnumsPage.Tag = "";
            this.EnumsPage.Text = "Enums";
            this.EnumsPage.UseVisualStyleBackColor = true;
            // 
            // groupBoxForSeasons
            // 
            this.groupBoxForSeasons.Controls.Add(this.SeasonsGoButton);
            this.groupBoxForSeasons.Controls.Add(this.ComboBoxForSeasons);
            this.groupBoxForSeasons.Location = new System.Drawing.Point(412, 265);
            this.groupBoxForSeasons.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxForSeasons.Name = "groupBoxForSeasons";
            this.groupBoxForSeasons.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxForSeasons.Size = new System.Drawing.Size(367, 135);
            this.groupBoxForSeasons.TabIndex = 7;
            this.groupBoxForSeasons.TabStop = false;
            this.groupBoxForSeasons.Text = "Season Handler";
            // 
            // SeasonsGoButton
            // 
            this.SeasonsGoButton.Location = new System.Drawing.Point(240, 60);
            this.SeasonsGoButton.Margin = new System.Windows.Forms.Padding(4);
            this.SeasonsGoButton.Name = "SeasonsGoButton";
            this.SeasonsGoButton.Size = new System.Drawing.Size(119, 28);
            this.SeasonsGoButton.TabIndex = 1;
            this.SeasonsGoButton.Text = "Go!";
            this.SeasonsGoButton.UseVisualStyleBackColor = true;
            this.SeasonsGoButton.Click += new System.EventHandler(this.SeasonsGoButton_Click);
            // 
            // ComboBoxForSeasons
            // 
            this.ComboBoxForSeasons.FormattingEnabled = true;
            this.ComboBoxForSeasons.Location = new System.Drawing.Point(8, 60);
            this.ComboBoxForSeasons.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxForSeasons.Name = "ComboBoxForSeasons";
            this.ComboBoxForSeasons.Size = new System.Drawing.Size(223, 24);
            this.ComboBoxForSeasons.TabIndex = 0;
            // 
            // groupBoxForWeekDayParser
            // 
            this.groupBoxForWeekDayParser.Controls.Add(this.ParseButton);
            this.groupBoxForWeekDayParser.Controls.Add(this.labelForWeekdayInfo);
            this.groupBoxForWeekDayParser.Controls.Add(this.label1);
            this.groupBoxForWeekDayParser.Controls.Add(this.TextBoxForParse);
            this.groupBoxForWeekDayParser.Location = new System.Drawing.Point(5, 265);
            this.groupBoxForWeekDayParser.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxForWeekDayParser.Name = "groupBoxForWeekDayParser";
            this.groupBoxForWeekDayParser.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxForWeekDayParser.Size = new System.Drawing.Size(399, 135);
            this.groupBoxForWeekDayParser.TabIndex = 6;
            this.groupBoxForWeekDayParser.TabStop = false;
            this.groupBoxForWeekDayParser.Text = "WeekDay Parser";
            // 
            // ParseButton
            // 
            this.ParseButton.Enabled = false;
            this.ParseButton.Location = new System.Drawing.Point(256, 71);
            this.ParseButton.Margin = new System.Windows.Forms.Padding(4);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(135, 28);
            this.ParseButton.TabIndex = 3;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // labelForWeekdayInfo
            // 
            this.labelForWeekdayInfo.AutoSize = true;
            this.labelForWeekdayInfo.Location = new System.Drawing.Point(7, 108);
            this.labelForWeekdayInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForWeekdayInfo.Name = "labelForWeekdayInfo";
            this.labelForWeekdayInfo.Size = new System.Drawing.Size(0, 16);
            this.labelForWeekdayInfo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type weekday for parsing";
            // 
            // TextBoxForParse
            // 
            this.TextBoxForParse.Location = new System.Drawing.Point(8, 75);
            this.TextBoxForParse.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxForParse.Name = "TextBoxForParse";
            this.TextBoxForParse.Size = new System.Drawing.Size(239, 22);
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
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(786, 254);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enumerations";
            // 
            // labelForChosenValue
            // 
            this.labelForChosenValue.AutoSize = true;
            this.labelForChosenValue.Location = new System.Drawing.Point(408, 25);
            this.labelForChosenValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForChosenValue.Name = "labelForChosenValue";
            this.labelForChosenValue.Size = new System.Drawing.Size(59, 16);
            this.labelForChosenValue.TabIndex = 5;
            this.labelForChosenValue.Text = "Int value:";
            // 
            // textBoxForIndex
            // 
            this.textBoxForIndex.Location = new System.Drawing.Point(408, 47);
            this.textBoxForIndex.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxForIndex.Name = "textBoxForIndex";
            this.textBoxForIndex.Size = new System.Drawing.Size(132, 22);
            this.textBoxForIndex.TabIndex = 4;
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 16;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Colors",
            "FormsOfEducation",
            "Genre",
            "Seasons",
            "SmartphoneMakers",
            "WeekDay"});
            this.EnumsListBox.Location = new System.Drawing.Point(12, 47);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(191, 180);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 16;
            this.ValuesListBox.Location = new System.Drawing.Point(209, 47);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(191, 180);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // labelOfEnumsTable
            // 
            this.labelOfEnumsTable.AutoSize = true;
            this.labelOfEnumsTable.Location = new System.Drawing.Point(13, 26);
            this.labelOfEnumsTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOfEnumsTable.Name = "labelOfEnumsTable";
            this.labelOfEnumsTable.Size = new System.Drawing.Size(134, 16);
            this.labelOfEnumsTable.TabIndex = 2;
            this.labelOfEnumsTable.Text = "Choose enumeration:";
            // 
            // labelOfItemTable
            // 
            this.labelOfItemTable.AutoSize = true;
            this.labelOfItemTable.Location = new System.Drawing.Point(205, 26);
            this.labelOfItemTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOfItemTable.Name = "labelOfItemTable";
            this.labelOfItemTable.Size = new System.Drawing.Size(93, 16);
            this.labelOfItemTable.TabIndex = 3;
            this.labelOfItemTable.Text = "Choose value:";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnumsPage);
            this.TabControl.Controls.Add(this.ClassesPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 444);
            this.TabControl.TabIndex = 0;
            // 
            // ClassesPage
            // 
            this.ClassesPage.Controls.Add(this.ClassesTabControl);
            this.ClassesPage.Location = new System.Drawing.Point(4, 25);
            this.ClassesPage.Name = "ClassesPage";
            this.ClassesPage.Size = new System.Drawing.Size(792, 415);
            this.ClassesPage.TabIndex = 1;
            this.ClassesPage.Text = "Classes";
            this.ClassesPage.UseVisualStyleBackColor = true;
            // 
            // ClassesTabControl
            // 
            this.ClassesTabControl.Controls.Add(this.RectanglesPage);
            this.ClassesTabControl.Controls.Add(this.MoviesPage);
            this.ClassesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassesTabControl.Location = new System.Drawing.Point(0, 0);
            this.ClassesTabControl.Name = "ClassesTabControl";
            this.ClassesTabControl.SelectedIndex = 0;
            this.ClassesTabControl.Size = new System.Drawing.Size(792, 415);
            this.ClassesTabControl.TabIndex = 0;
            // 
            // RectanglesPage
            // 
            this.RectanglesPage.Controls.Add(this.groupBox2);
            this.RectanglesPage.Location = new System.Drawing.Point(4, 25);
            this.RectanglesPage.Name = "RectanglesPage";
            this.RectanglesPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesPage.Size = new System.Drawing.Size(784, 386);
            this.RectanglesPage.TabIndex = 0;
            this.RectanglesPage.Text = "Rectangles";
            this.RectanglesPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FindRectangleBtn);
            this.groupBox2.Controls.Add(this.RectangleColorErrorLabel);
            this.groupBox2.Controls.Add(this.RectangleWidthErrorLabel);
            this.groupBox2.Controls.Add(this.RectangleLengthErrorLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.RectangleLengthLabel);
            this.groupBox2.Controls.Add(this.RectangleColorTextBox);
            this.groupBox2.Controls.Add(this.RectangleWidthTextBox);
            this.groupBox2.Controls.Add(this.RectangleLengthTextBox);
            this.groupBox2.Controls.Add(this.RectanglesListBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 380);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rectangles";
            // 
            // RectangleColorErrorLabel
            // 
            this.RectangleColorErrorLabel.AutoSize = true;
            this.RectangleColorErrorLabel.Location = new System.Drawing.Point(422, 162);
            this.RectangleColorErrorLabel.Name = "RectangleColorErrorLabel";
            this.RectangleColorErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.RectangleColorErrorLabel.TabIndex = 9;
            // 
            // RectangleWidthErrorLabel
            // 
            this.RectangleWidthErrorLabel.AutoSize = true;
            this.RectangleWidthErrorLabel.Location = new System.Drawing.Point(422, 111);
            this.RectangleWidthErrorLabel.Name = "RectangleWidthErrorLabel";
            this.RectangleWidthErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.RectangleWidthErrorLabel.TabIndex = 8;
            // 
            // RectangleLengthErrorLabel
            // 
            this.RectangleLengthErrorLabel.AutoSize = true;
            this.RectangleLengthErrorLabel.Location = new System.Drawing.Point(422, 59);
            this.RectangleLengthErrorLabel.Name = "RectangleLengthErrorLabel";
            this.RectangleLengthErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.RectangleLengthErrorLabel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Width";
            // 
            // RectangleLengthLabel
            // 
            this.RectangleLengthLabel.AutoSize = true;
            this.RectangleLengthLabel.Location = new System.Drawing.Point(315, 32);
            this.RectangleLengthLabel.Name = "RectangleLengthLabel";
            this.RectangleLengthLabel.Size = new System.Drawing.Size(47, 16);
            this.RectangleLengthLabel.TabIndex = 4;
            this.RectangleLengthLabel.Text = "Length";
            // 
            // RectangleColorTextBox
            // 
            this.RectangleColorTextBox.Location = new System.Drawing.Point(314, 159);
            this.RectangleColorTextBox.Name = "RectangleColorTextBox";
            this.RectangleColorTextBox.Size = new System.Drawing.Size(100, 22);
            this.RectangleColorTextBox.TabIndex = 3;
            this.RectangleColorTextBox.TextChanged += new System.EventHandler(this.RectangleColorTextBox_TextChanged);
            // 
            // RectangleWidthTextBox
            // 
            this.RectangleWidthTextBox.Location = new System.Drawing.Point(314, 108);
            this.RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            this.RectangleWidthTextBox.Size = new System.Drawing.Size(100, 22);
            this.RectangleWidthTextBox.TabIndex = 2;
            this.RectangleWidthTextBox.TextChanged += new System.EventHandler(this.RectangleWidthTextBox_TextChanged);
            // 
            // RectangleLengthTextBox
            // 
            this.RectangleLengthTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RectangleLengthTextBox.Location = new System.Drawing.Point(315, 54);
            this.RectangleLengthTextBox.Name = "RectangleLengthTextBox";
            this.RectangleLengthTextBox.Size = new System.Drawing.Size(100, 22);
            this.RectangleLengthTextBox.TabIndex = 1;
            this.RectangleLengthTextBox.TextChanged += new System.EventHandler(this.RectangleLengthTextBox_TextChanged);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 16;
            this.RectanglesListBox.Location = new System.Drawing.Point(6, 21);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(276, 340);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // MoviesPage
            // 
            this.MoviesPage.Location = new System.Drawing.Point(4, 25);
            this.MoviesPage.Name = "MoviesPage";
            this.MoviesPage.Padding = new System.Windows.Forms.Padding(3);
            this.MoviesPage.Size = new System.Drawing.Size(784, 386);
            this.MoviesPage.TabIndex = 1;
            this.MoviesPage.Text = "Movies";
            this.MoviesPage.UseVisualStyleBackColor = true;
            // 
            // FindRectangleBtn
            // 
            this.FindRectangleBtn.Location = new System.Drawing.Point(315, 207);
            this.FindRectangleBtn.Name = "FindRectangleBtn";
            this.FindRectangleBtn.Size = new System.Drawing.Size(107, 23);
            this.FindRectangleBtn.TabIndex = 10;
            this.FindRectangleBtn.Text = "Find";
            this.FindRectangleBtn.UseVisualStyleBackColor = true;
            this.FindRectangleBtn.Click += new System.EventHandler(this.FindRectangleBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(818, 491);
            this.MinimumSize = new System.Drawing.Size(818, 491);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.EnumsPage.ResumeLayout(false);
            this.groupBoxForSeasons.ResumeLayout(false);
            this.groupBoxForWeekDayParser.ResumeLayout(false);
            this.groupBoxForWeekDayParser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.ClassesPage.ResumeLayout(false);
            this.ClassesTabControl.ResumeLayout(false);
            this.RectanglesPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button SeasonsGoButton;
        private System.Windows.Forms.ComboBox ComboBoxForSeasons;
        private System.Windows.Forms.TabPage ClassesPage;
        private System.Windows.Forms.TabControl ClassesTabControl;
        private System.Windows.Forms.TabPage RectanglesPage;
        private System.Windows.Forms.TabPage MoviesPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RectangleLengthLabel;
        private System.Windows.Forms.TextBox RectangleColorTextBox;
        private System.Windows.Forms.TextBox RectangleWidthTextBox;
        private System.Windows.Forms.TextBox RectangleLengthTextBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.Label RectangleWidthErrorLabel;
        private System.Windows.Forms.Label RectangleLengthErrorLabel;
        private System.Windows.Forms.Label RectangleColorErrorLabel;
        private System.Windows.Forms.Button FindRectangleBtn;
    }
}

