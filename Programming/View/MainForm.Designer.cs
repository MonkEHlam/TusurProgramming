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
            this.weekDayParserControl1 = new Programming.View.Controls.WeekDayParserControl();
            this.enumerationControl1 = new Programming.View.Controls.EnumerationControl();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ClassesPage = new System.Windows.Forms.TabPage();
            this.ClassesTabControl = new System.Windows.Forms.TabControl();
            this.MoviesPage = new System.Windows.Forms.TabPage();
            this.moviesControl1 = new Programming.View.Panels.MoviesControl();
            this.RectanglesPage = new System.Windows.Forms.TabPage();
            this.rectangleCollisionControl1 = new Programming.View.Panels.RectangleCollisionControl();
            this.seasonHandlerControl1 = new Programming.View.Controls.SeasonHandlerControl();
            this.EnumsPage.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.ClassesPage.SuspendLayout();
            this.ClassesTabControl.SuspendLayout();
            this.MoviesPage.SuspendLayout();
            this.RectanglesPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsPage
            // 
            this.EnumsPage.Controls.Add(this.seasonHandlerControl1);
            this.EnumsPage.Controls.Add(this.weekDayParserControl1);
            this.EnumsPage.Controls.Add(this.enumerationControl1);
            this.EnumsPage.Location = new System.Drawing.Point(4, 22);
            this.EnumsPage.Margin = new System.Windows.Forms.Padding(2);
            this.EnumsPage.Name = "EnumsPage";
            this.EnumsPage.Padding = new System.Windows.Forms.Padding(2);
            this.EnumsPage.Size = new System.Drawing.Size(580, 340);
            this.EnumsPage.TabIndex = 0;
            this.EnumsPage.Tag = "";
            this.EnumsPage.Text = "Enums";
            this.EnumsPage.UseVisualStyleBackColor = true;
            // 
            // weekDayParserControl1
            // 
            this.weekDayParserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.weekDayParserControl1.Location = new System.Drawing.Point(5, 215);
            this.weekDayParserControl1.Name = "weekDayParserControl1";
            this.weekDayParserControl1.Size = new System.Drawing.Size(298, 110);
            this.weekDayParserControl1.TabIndex = 9;
            // 
            // enumerationControl1
            // 
            this.enumerationControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.enumerationControl1.Location = new System.Drawing.Point(2, 2);
            this.enumerationControl1.Name = "enumerationControl1";
            this.enumerationControl1.Size = new System.Drawing.Size(576, 207);
            this.enumerationControl1.TabIndex = 8;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnumsPage);
            this.TabControl.Controls.Add(this.ClassesPage);
            this.TabControl.Controls.Add(this.RectanglesPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(588, 366);
            this.TabControl.TabIndex = 0;
            // 
            // ClassesPage
            // 
            this.ClassesPage.Controls.Add(this.ClassesTabControl);
            this.ClassesPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesPage.Margin = new System.Windows.Forms.Padding(2);
            this.ClassesPage.Name = "ClassesPage";
            this.ClassesPage.Size = new System.Drawing.Size(580, 340);
            this.ClassesPage.TabIndex = 1;
            this.ClassesPage.Text = "Classes";
            this.ClassesPage.UseVisualStyleBackColor = true;
            // 
            // ClassesTabControl
            // 
            this.ClassesTabControl.Controls.Add(this.MoviesPage);
            this.ClassesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassesTabControl.Location = new System.Drawing.Point(0, 0);
            this.ClassesTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.ClassesTabControl.Name = "ClassesTabControl";
            this.ClassesTabControl.SelectedIndex = 0;
            this.ClassesTabControl.Size = new System.Drawing.Size(580, 340);
            this.ClassesTabControl.TabIndex = 0;
            // 
            // MoviesPage
            // 
            this.MoviesPage.Controls.Add(this.moviesControl1);
            this.MoviesPage.Location = new System.Drawing.Point(4, 22);
            this.MoviesPage.Margin = new System.Windows.Forms.Padding(2);
            this.MoviesPage.Name = "MoviesPage";
            this.MoviesPage.Padding = new System.Windows.Forms.Padding(2);
            this.MoviesPage.Size = new System.Drawing.Size(572, 314);
            this.MoviesPage.TabIndex = 1;
            this.MoviesPage.Text = "Movies";
            this.MoviesPage.UseVisualStyleBackColor = true;
            // 
            // moviesControl1
            // 
            this.moviesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviesControl1.Location = new System.Drawing.Point(2, 2);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(568, 310);
            this.moviesControl1.TabIndex = 0;
            // 
            // RectanglesPage
            // 
            this.RectanglesPage.Controls.Add(this.rectangleCollisionControl1);
            this.RectanglesPage.Location = new System.Drawing.Point(4, 22);
            this.RectanglesPage.Margin = new System.Windows.Forms.Padding(2);
            this.RectanglesPage.Name = "RectanglesPage";
            this.RectanglesPage.Size = new System.Drawing.Size(580, 340);
            this.RectanglesPage.TabIndex = 2;
            this.RectanglesPage.Text = "Rectangles";
            this.RectanglesPage.UseVisualStyleBackColor = true;
            // 
            // rectangleCollisionControl1
            // 
            this.rectangleCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectangleCollisionControl1.Location = new System.Drawing.Point(0, 0);
            this.rectangleCollisionControl1.Margin = new System.Windows.Forms.Padding(2);
            this.rectangleCollisionControl1.Name = "rectangleCollisionControl1";
            this.rectangleCollisionControl1.Size = new System.Drawing.Size(580, 340);
            this.rectangleCollisionControl1.TabIndex = 0;
            // 
            // seasonHandlerControl1
            // 
            this.seasonHandlerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.seasonHandlerControl1.Location = new System.Drawing.Point(310, 216);
            this.seasonHandlerControl1.Name = "seasonHandlerControl1";
            this.seasonHandlerControl1.Size = new System.Drawing.Size(268, 110);
            this.seasonHandlerControl1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 366);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1444, 885);
            this.MinimumSize = new System.Drawing.Size(604, 405);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.EnumsPage.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.ClassesPage.ResumeLayout(false);
            this.ClassesTabControl.ResumeLayout(false);
            this.MoviesPage.ResumeLayout(false);
            this.RectanglesPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage EnumsPage;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ClassesPage;
        private System.Windows.Forms.TabPage RectanglesPage;
        private View.Panels.RectangleCollisionControl rectangleCollisionControl1;
        private System.Windows.Forms.TabControl ClassesTabControl;
        private System.Windows.Forms.TabPage MoviesPage;
        private View.Panels.MoviesControl moviesControl1;
        private View.Controls.EnumerationControl enumerationControl1;
        private View.Controls.WeekDayParserControl weekDayParserControl1;
        private View.Controls.SeasonHandlerControl seasonHandlerControl1;
    }
}

