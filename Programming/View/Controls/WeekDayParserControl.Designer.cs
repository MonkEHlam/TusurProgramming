namespace Programming.View.Controls
{
    partial class WeekDayParserControl
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
            this.groupBoxForWeekDayParser = new System.Windows.Forms.GroupBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.labelForWeekdayInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxForParse = new System.Windows.Forms.TextBox();
            this.groupBoxForWeekDayParser.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxForWeekDayParser
            // 
            this.groupBoxForWeekDayParser.Controls.Add(this.ParseButton);
            this.groupBoxForWeekDayParser.Controls.Add(this.labelForWeekdayInfo);
            this.groupBoxForWeekDayParser.Controls.Add(this.label1);
            this.groupBoxForWeekDayParser.Controls.Add(this.TextBoxForParse);
            this.groupBoxForWeekDayParser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxForWeekDayParser.Location = new System.Drawing.Point(0, 0);
            this.groupBoxForWeekDayParser.Name = "groupBoxForWeekDayParser";
            this.groupBoxForWeekDayParser.Size = new System.Drawing.Size(300, 73);
            this.groupBoxForWeekDayParser.TabIndex = 7;
            this.groupBoxForWeekDayParser.TabStop = false;
            this.groupBoxForWeekDayParser.Text = "WeekDay Parser";
            // 
            // ParseButton
            // 
            this.ParseButton.Enabled = false;
            this.ParseButton.Location = new System.Drawing.Point(193, 39);
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
            this.labelForWeekdayInfo.Size = new System.Drawing.Size(0, 13);
            this.labelForWeekdayInfo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type weekday for parsing";
            // 
            // TextBoxForParse
            // 
            this.TextBoxForParse.Location = new System.Drawing.Point(7, 42);
            this.TextBoxForParse.Name = "TextBoxForParse";
            this.TextBoxForParse.Size = new System.Drawing.Size(180, 20);
            this.TextBoxForParse.TabIndex = 0;
            this.TextBoxForParse.TextChanged += new System.EventHandler(this.TextBoxForParse_TextChanged);
            // 
            // WeekDayParserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxForWeekDayParser);
            this.Name = "WeekDayParserControl";
            this.Size = new System.Drawing.Size(300, 73);
            this.groupBoxForWeekDayParser.ResumeLayout(false);
            this.groupBoxForWeekDayParser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxForWeekDayParser;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.Label labelForWeekdayInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxForParse;
    }
}
