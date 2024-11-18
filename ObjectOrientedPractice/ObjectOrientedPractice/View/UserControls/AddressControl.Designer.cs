namespace ObjectOrientedPractice.View.Controls
{
    partial class AddressControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ApartamentTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.IndexTextBox = new System.Windows.Forms.TextBox();
            this.BuildingTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delivery address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Postal index:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(236, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apartment:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Country:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Building:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Street:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(236, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "City:";
            // 
            // ApartamentTextBox
            // 
            this.ApartamentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApartamentTextBox.Location = new System.Drawing.Point(319, 123);
            this.ApartamentTextBox.Name = "ApartamentTextBox";
            this.ApartamentTextBox.Size = new System.Drawing.Size(127, 20);
            this.ApartamentTextBox.TabIndex = 7;
            this.ApartamentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApartamentTextBox_KeyPress);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(61, 54);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(169, 20);
            this.CountryTextBox.TabIndex = 8;
            this.CountryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountryTextBox_KeyPress);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CityTextBox.Location = new System.Drawing.Point(277, 56);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(169, 20);
            this.CityTextBox.TabIndex = 9;
            this.CityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CityTextBox_KeyPress);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetTextBox.Location = new System.Drawing.Point(59, 88);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(387, 20);
            this.StreetTextBox.TabIndex = 10;
            this.StreetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StreetTextBox_KeyPress);
            // 
            // IndexTextBox
            // 
            this.IndexTextBox.Location = new System.Drawing.Point(93, 28);
            this.IndexTextBox.Name = "IndexTextBox";
            this.IndexTextBox.Size = new System.Drawing.Size(114, 20);
            this.IndexTextBox.TabIndex = 11;
            this.IndexTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IndexTextBox_KeyPress);
            // 
            // BuildingTextBox
            // 
            this.BuildingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BuildingTextBox.Location = new System.Drawing.Point(75, 122);
            this.BuildingTextBox.Name = "BuildingTextBox";
            this.BuildingTextBox.Size = new System.Drawing.Size(155, 20);
            this.BuildingTextBox.TabIndex = 12;
            this.BuildingTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuildingTextBox_KeyPress);
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BuildingTextBox);
            this.Controls.Add(this.IndexTextBox);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.ApartamentTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(458, 164);
            this.Load += new System.EventHandler(this.AddressControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ApartamentTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox IndexTextBox;
        private System.Windows.Forms.TextBox BuildingTextBox;
    }
}
