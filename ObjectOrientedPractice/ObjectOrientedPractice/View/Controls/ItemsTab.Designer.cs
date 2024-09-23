namespace ObjectOrientedPractice.View.Controls
{
    partial class ItemsTab
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.InfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SelectedItemLlabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.AddButton);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 383);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(265, 54);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 50);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(89, 3);
            this.button2.Name = "RemoveButton";
            this.button2.Size = new System.Drawing.Size(80, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 25);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(265, 342);
            this.ItemsListBox.TabIndex = 4;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsLlistBox_SelectedIndexChanged);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(3, 5);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(46, 17);
            this.MainLabel.TabIndex = 3;
            this.MainLabel.Text = "Items";
            // 
            // InfoLabel
            // 
            this.InfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(284, 184);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(83, 17);
            this.InfoLabel.TabIndex = 26;
            this.InfoLabel.Text = "Description:";
            // 
            // InfoRichTextBox
            // 
            this.InfoRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoRichTextBox.Location = new System.Drawing.Point(287, 204);
            this.InfoRichTextBox.Name = "InfoRichTextBox";
            this.InfoRichTextBox.Size = new System.Drawing.Size(399, 150);
            this.InfoRichTextBox.TabIndex = 25;
            this.InfoRichTextBox.Text = "";
            this.InfoRichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InfoRichTextBox_KeyPress);
            // 
            // NameRichTextBox
            // 
            this.NameRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameRichTextBox.Location = new System.Drawing.Point(287, 123);
            this.NameRichTextBox.Name = "AddressRichTextBox";
            this.NameRichTextBox.Size = new System.Drawing.Size(399, 53);
            this.NameRichTextBox.TabIndex = 24;
            this.NameRichTextBox.Text = "";
            this.NameRichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameRichTextBox_KeyPress);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(285, 103);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 17);
            this.NameLabel.TabIndex = 23;
            this.NameLabel.Text = "Name:";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CostTextBox.Location = new System.Drawing.Point(330, 72);
            this.CostTextBox.Name = "NameTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(138, 20);
            this.CostTextBox.TabIndex = 22;
            this.CostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostTextBox_KeyPress);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTextBox.Location = new System.Drawing.Point(330, 44);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(61, 20);
            this.IdTextBox.TabIndex = 21;
            // 
            // CostLabel
            // 
            this.CostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.Location = new System.Drawing.Point(284, 73);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(40, 17);
            this.CostLabel.TabIndex = 20;
            this.CostLabel.Text = "Cost:";
            // 
            // IdLabel
            // 
            this.IdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdLabel.Location = new System.Drawing.Point(299, 45);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(25, 17);
            this.IdLabel.TabIndex = 19;
            this.IdLabel.Text = "ID:";
            // 
            // SelectedItemLlabel
            // 
            this.SelectedItemLlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemLlabel.AutoSize = true;
            this.SelectedItemLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedItemLlabel.Location = new System.Drawing.Point(285, 5);
            this.SelectedItemLlabel.Name = "SelectedItemLlabel";
            this.SelectedItemLlabel.Size = new System.Drawing.Size(106, 17);
            this.SelectedItemLlabel.TabIndex = 18;
            this.SelectedItemLlabel.Text = "Selected item";
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.InfoRichTextBox);
            this.Controls.Add(this.NameRichTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.SelectedItemLlabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.MainLabel);
            this.MinimumSize = new System.Drawing.Size(720, 440);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(720, 440);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.RichTextBox InfoRichTextBox;
        private System.Windows.Forms.RichTextBox NameRichTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label SelectedItemLlabel;
    }
}
