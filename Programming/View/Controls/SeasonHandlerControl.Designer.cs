namespace Programming.View.Controls
{
    partial class SeasonHandlerControl
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
            this.groupBoxForSeasons = new System.Windows.Forms.GroupBox();
            this.SeasonsGoButton = new System.Windows.Forms.Button();
            this.ComboBoxForSeasons = new System.Windows.Forms.ComboBox();
            this.groupBoxForSeasons.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxForSeasons
            // 
            this.groupBoxForSeasons.Controls.Add(this.SeasonsGoButton);
            this.groupBoxForSeasons.Controls.Add(this.ComboBoxForSeasons);
            this.groupBoxForSeasons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxForSeasons.Location = new System.Drawing.Point(0, 0);
            this.groupBoxForSeasons.Name = "groupBoxForSeasons";
            this.groupBoxForSeasons.Size = new System.Drawing.Size(276, 110);
            this.groupBoxForSeasons.TabIndex = 8;
            this.groupBoxForSeasons.TabStop = false;
            this.groupBoxForSeasons.Text = "Season Handler";
            // 
            // SeasonsGoButton
            // 
            this.SeasonsGoButton.Location = new System.Drawing.Point(169, 49);
            this.SeasonsGoButton.Name = "SeasonsGoButton";
            this.SeasonsGoButton.Size = new System.Drawing.Size(89, 23);
            this.SeasonsGoButton.TabIndex = 1;
            this.SeasonsGoButton.Text = "Go!";
            this.SeasonsGoButton.UseVisualStyleBackColor = true;
            this.SeasonsGoButton.Click += new System.EventHandler(this.SeasonsGoButton_Click);
            // 
            // ComboBoxForSeasons
            // 
            this.ComboBoxForSeasons.FormattingEnabled = true;
            this.ComboBoxForSeasons.Location = new System.Drawing.Point(6, 49);
            this.ComboBoxForSeasons.Name = "ComboBoxForSeasons";
            this.ComboBoxForSeasons.Size = new System.Drawing.Size(157, 21);
            this.ComboBoxForSeasons.TabIndex = 0;
            // 
            // SeasonHandlerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxForSeasons);
            this.Name = "SeasonHandlerControl";
            this.Size = new System.Drawing.Size(276, 110);
            this.Load += new System.EventHandler(this.SeasonHandlerControl_Load);
            this.groupBoxForSeasons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxForSeasons;
        private System.Windows.Forms.Button SeasonsGoButton;
        private System.Windows.Forms.ComboBox ComboBoxForSeasons;
    }
}
