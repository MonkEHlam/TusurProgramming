namespace Programming.View.Panels
{
    partial class MoviesControl
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MovieYearLabel = new System.Windows.Forms.Label();
            this.MovieRateLabel = new System.Windows.Forms.Label();
            this.MovieGenreLabel = new System.Windows.Forms.Label();
            this.MovieDurationLabel = new System.Windows.Forms.Label();
            this.MovieNameLabel = new System.Windows.Forms.Label();
            this.MovieDurationTextBox = new System.Windows.Forms.TextBox();
            this.MovieYearTextBox = new System.Windows.Forms.TextBox();
            this.MovieGenreTextBox = new System.Windows.Forms.TextBox();
            this.MovieRateTextBox = new System.Windows.Forms.TextBox();
            this.MovieNameTextBox = new System.Windows.Forms.TextBox();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MovieYearLabel);
            this.groupBox3.Controls.Add(this.MovieRateLabel);
            this.groupBox3.Controls.Add(this.MovieGenreLabel);
            this.groupBox3.Controls.Add(this.MovieDurationLabel);
            this.groupBox3.Controls.Add(this.MovieNameLabel);
            this.groupBox3.Controls.Add(this.MovieDurationTextBox);
            this.groupBox3.Controls.Add(this.MovieYearTextBox);
            this.groupBox3.Controls.Add(this.MovieGenreTextBox);
            this.groupBox3.Controls.Add(this.MovieRateTextBox);
            this.groupBox3.Controls.Add(this.MovieNameTextBox);
            this.groupBox3.Controls.Add(this.MoviesListBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(503, 334);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movies";
            // 
            // MovieYearLabel
            // 
            this.MovieYearLabel.AutoSize = true;
            this.MovieYearLabel.Location = new System.Drawing.Point(158, 107);
            this.MovieYearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MovieYearLabel.Name = "MovieYearLabel";
            this.MovieYearLabel.Size = new System.Drawing.Size(29, 13);
            this.MovieYearLabel.TabIndex = 10;
            this.MovieYearLabel.Text = "Year";
            // 
            // MovieRateLabel
            // 
            this.MovieRateLabel.AutoSize = true;
            this.MovieRateLabel.Location = new System.Drawing.Point(158, 210);
            this.MovieRateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MovieRateLabel.Name = "MovieRateLabel";
            this.MovieRateLabel.Size = new System.Drawing.Size(30, 13);
            this.MovieRateLabel.TabIndex = 9;
            this.MovieRateLabel.Text = "Rate";
            // 
            // MovieGenreLabel
            // 
            this.MovieGenreLabel.AutoSize = true;
            this.MovieGenreLabel.Location = new System.Drawing.Point(158, 154);
            this.MovieGenreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MovieGenreLabel.Name = "MovieGenreLabel";
            this.MovieGenreLabel.Size = new System.Drawing.Size(36, 13);
            this.MovieGenreLabel.TabIndex = 8;
            this.MovieGenreLabel.Text = "Genre";
            // 
            // MovieDurationLabel
            // 
            this.MovieDurationLabel.AutoSize = true;
            this.MovieDurationLabel.Location = new System.Drawing.Point(158, 60);
            this.MovieDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MovieDurationLabel.Name = "MovieDurationLabel";
            this.MovieDurationLabel.Size = new System.Drawing.Size(47, 13);
            this.MovieDurationLabel.TabIndex = 7;
            this.MovieDurationLabel.Text = "Duration";
            // 
            // MovieNameLabel
            // 
            this.MovieNameLabel.AutoSize = true;
            this.MovieNameLabel.Location = new System.Drawing.Point(158, 15);
            this.MovieNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MovieNameLabel.Name = "MovieNameLabel";
            this.MovieNameLabel.Size = new System.Drawing.Size(27, 13);
            this.MovieNameLabel.TabIndex = 6;
            this.MovieNameLabel.Text = "Title";
            // 
            // MovieDurationTextBox
            // 
            this.MovieDurationTextBox.Location = new System.Drawing.Point(157, 76);
            this.MovieDurationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MovieDurationTextBox.Name = "MovieDurationTextBox";
            this.MovieDurationTextBox.Size = new System.Drawing.Size(76, 20);
            this.MovieDurationTextBox.TabIndex = 5;
            this.MovieDurationTextBox.TextChanged += new System.EventHandler(this.MovieDurationTextBox_TextChanged);
            // 
            // MovieYearTextBox
            // 
            this.MovieYearTextBox.Location = new System.Drawing.Point(157, 123);
            this.MovieYearTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MovieYearTextBox.Name = "MovieYearTextBox";
            this.MovieYearTextBox.Size = new System.Drawing.Size(76, 20);
            this.MovieYearTextBox.TabIndex = 4;
            this.MovieYearTextBox.TextChanged += new System.EventHandler(this.MovieYearTextBox_TextChanged);
            // 
            // MovieGenreTextBox
            // 
            this.MovieGenreTextBox.Location = new System.Drawing.Point(157, 175);
            this.MovieGenreTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MovieGenreTextBox.Name = "MovieGenreTextBox";
            this.MovieGenreTextBox.Size = new System.Drawing.Size(76, 20);
            this.MovieGenreTextBox.TabIndex = 3;
            this.MovieGenreTextBox.TextChanged += new System.EventHandler(this.MovieGenreTextBox_TextChanged);
            // 
            // MovieRateTextBox
            // 
            this.MovieRateTextBox.Location = new System.Drawing.Point(157, 225);
            this.MovieRateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MovieRateTextBox.Name = "MovieRateTextBox";
            this.MovieRateTextBox.Size = new System.Drawing.Size(76, 20);
            this.MovieRateTextBox.TabIndex = 2;
            this.MovieRateTextBox.TextChanged += new System.EventHandler(this.MovieRateTextBox_TextChanged);
            // 
            // MovieNameTextBox
            // 
            this.MovieNameTextBox.Location = new System.Drawing.Point(157, 30);
            this.MovieNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MovieNameTextBox.Name = "MovieNameTextBox";
            this.MovieNameTextBox.Size = new System.Drawing.Size(76, 20);
            this.MovieNameTextBox.TabIndex = 1;
            this.MovieNameTextBox.TextChanged += new System.EventHandler(this.MovieNameTextBox_TextChanged);
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.Location = new System.Drawing.Point(2, 15);
            this.MoviesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(151, 317);
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(503, 334);
            this.Load += new System.EventHandler(this.MoviesControl_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label MovieYearLabel;
        private System.Windows.Forms.Label MovieRateLabel;
        private System.Windows.Forms.Label MovieGenreLabel;
        private System.Windows.Forms.Label MovieDurationLabel;
        private System.Windows.Forms.Label MovieNameLabel;
        private System.Windows.Forms.TextBox MovieDurationTextBox;
        private System.Windows.Forms.TextBox MovieYearTextBox;
        private System.Windows.Forms.TextBox MovieGenreTextBox;
        private System.Windows.Forms.TextBox MovieRateTextBox;
        private System.Windows.Forms.TextBox MovieNameTextBox;
        private System.Windows.Forms.ListBox MoviesListBox;
    }
}
