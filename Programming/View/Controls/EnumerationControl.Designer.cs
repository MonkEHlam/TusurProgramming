namespace Programming.View.Controls
{
    partial class EnumerationControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelForChosenValue = new System.Windows.Forms.Label();
            this.TextBoxForIndex = new System.Windows.Forms.TextBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.labelOfEnumsTable = new System.Windows.Forms.Label();
            this.labelOfItemTable = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelForChosenValue);
            this.groupBox1.Controls.Add(this.TextBoxForIndex);
            this.groupBox1.Controls.Add(this.EnumsListBox);
            this.groupBox1.Controls.Add(this.ValuesListBox);
            this.groupBox1.Controls.Add(this.labelOfEnumsTable);
            this.groupBox1.Controls.Add(this.labelOfItemTable);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 174);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enumerations";
            // 
            // labelForChosenValue
            // 
            this.labelForChosenValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelForChosenValue.AutoSize = true;
            this.labelForChosenValue.Location = new System.Drawing.Point(312, 38);
            this.labelForChosenValue.Name = "labelForChosenValue";
            this.labelForChosenValue.Size = new System.Drawing.Size(51, 13);
            this.labelForChosenValue.TabIndex = 5;
            this.labelForChosenValue.Text = "Int value:";
            // 
            // TextBoxForIndex
            // 
            this.TextBoxForIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxForIndex.Location = new System.Drawing.Point(312, 56);
            this.TextBoxForIndex.Name = "TextBoxForIndex";
            this.TextBoxForIndex.Size = new System.Drawing.Size(100, 20);
            this.TextBoxForIndex.TabIndex = 4;
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
            this.ValuesListBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(160, 38);
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
            this.labelOfEnumsTable.Size = new System.Drawing.Size(107, 13);
            this.labelOfEnumsTable.TabIndex = 2;
            this.labelOfEnumsTable.Text = "Choose enumeration:";
            // 
            // labelOfItemTable
            // 
            this.labelOfItemTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOfItemTable.AutoSize = true;
            this.labelOfItemTable.Location = new System.Drawing.Point(157, 21);
            this.labelOfItemTable.Name = "labelOfItemTable";
            this.labelOfItemTable.Size = new System.Drawing.Size(75, 13);
            this.labelOfItemTable.TabIndex = 3;
            this.labelOfItemTable.Text = "Choose value:";
            // 
            // EnumerationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "EnumerationControl";
            this.Size = new System.Drawing.Size(429, 174);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelForChosenValue;
        private System.Windows.Forms.TextBox TextBoxForIndex;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label labelOfEnumsTable;
        private System.Windows.Forms.Label labelOfItemTable;
    }
}
