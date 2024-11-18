using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Panels
{
    partial class CartsTab
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.AmouthLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomersComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AddToCartButton);
            this.splitContainer1.Panel1.Controls.Add(this.ItemsListBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.RemoveButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CartListBox);
            this.splitContainer1.Panel2.Controls.Add(this.AmouthLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.RemoveItemButton);
            this.splitContainer1.Panel2.Controls.Add(this.ClearCartButton);
            this.splitContainer1.Panel2.Controls.Add(this.CreateButton);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.CustomersComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(657, 460);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddToCartButton.Location = new System.Drawing.Point(4, 413);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(87, 36);
            this.AddToCartButton.TabIndex = 5;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(4, 24);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(191, 381);
            this.ItemsListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Items";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.Location = new System.Drawing.Point(96, 783);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(87, 36);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // CartListBox
            // 
            this.CartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.Location = new System.Drawing.Point(12, 60);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(423, 173);
            this.CartListBox.TabIndex = 11;
            // 
            // AmouthLabel
            // 
            this.AmouthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmouthLabel.AutoSize = true;
            this.AmouthLabel.Location = new System.Drawing.Point(348, 257);
            this.AmouthLabel.Name = "AmouthLabel";
            this.AmouthLabel.Size = new System.Drawing.Size(22, 13);
            this.AmouthLabel.TabIndex = 10;
            this.AmouthLabel.Text = "0.0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Amouth:";
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveItemButton.Location = new System.Drawing.Point(257, 283);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(87, 36);
            this.RemoveItemButton.TabIndex = 8;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearCartButton.Location = new System.Drawing.Point(348, 283);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(87, 36);
            this.ClearCartButton.TabIndex = 7;
            this.ClearCartButton.Text = "Clear Cart";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            this.ClearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateButton.Location = new System.Drawing.Point(12, 283);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(87, 36);
            this.CreateButton.TabIndex = 6;
            this.CreateButton.Text = "Create Order";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cart:";
            // 
            // CustomersComboBox
            // 
            this.CustomersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomersComboBox.FormattingEnabled = true;
            this.CustomersComboBox.Location = new System.Drawing.Point(68, 9);
            this.CustomersComboBox.Name = "CustomersComboBox";
            this.CustomersComboBox.Size = new System.Drawing.Size(214, 21);
            this.CustomersComboBox.TabIndex = 1;
            this.CustomersComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomersComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer";
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(657, 460);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Button RemoveButton;
        private ListBox ItemsListBox;
        private Button AddToCartButton;
        private Button RemoveItemButton;
        private Button ClearCartButton;
        private Button CreateButton;
        private Label label3;
        private ComboBox CustomersComboBox;
        private Label AmouthLabel;
        private Label label4;
        public Label label2;
        private ListBox CartListBox;
    }
}
