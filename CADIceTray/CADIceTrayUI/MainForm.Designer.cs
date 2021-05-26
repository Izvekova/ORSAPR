
namespace CADIceTrayUI
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
            this.CreateModelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.CellWidthTextBox = new System.Windows.Forms.TextBox();
            this.CellLengthTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CellLengthLabel = new System.Windows.Forms.Label();
            this.CellWidthLabel = new System.Windows.Forms.Label();
            this.CellHeightLabel = new System.Windows.Forms.Label();
            this.CellHeightTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateModelButton
            // 
            this.CreateModelButton.Location = new System.Drawing.Point(176, 227);
            this.CreateModelButton.Name = "CreateModelButton";
            this.CreateModelButton.Size = new System.Drawing.Size(100, 23);
            this.CreateModelButton.TabIndex = 7;
            this.CreateModelButton.Text = "Построить";
            this.CreateModelButton.UseVisualStyleBackColor = true;
            this.CreateModelButton.Click += new System.EventHandler(this.CreateModelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Высота формы (мм)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ширина формы (мм)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Длина формы (мм)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ширина ячейки (мм)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Длина ячейки (мм)";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(121, 71);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(70, 20);
            this.LengthTextBox.TabIndex = 3;
            this.LengthTextBox.Text = "70";
            this.LengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.LengthTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(121, 45);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(70, 20);
            this.WidthTextBox.TabIndex = 2;
            this.WidthTextBox.Text = "70";
            this.WidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.WidthTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(121, 19);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(70, 20);
            this.HeightTextBox.TabIndex = 1;
            this.HeightTextBox.Text = "30";
            this.HeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.HeightTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // CellWidthTextBox
            // 
            this.CellWidthTextBox.Location = new System.Drawing.Point(121, 45);
            this.CellWidthTextBox.Name = "CellWidthTextBox";
            this.CellWidthTextBox.Size = new System.Drawing.Size(70, 20);
            this.CellWidthTextBox.TabIndex = 5;
            this.CellWidthTextBox.Text = "25";
            this.CellWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.CellWidthTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // CellLengthTextBox
            // 
            this.CellLengthTextBox.Location = new System.Drawing.Point(121, 71);
            this.CellLengthTextBox.Name = "CellLengthTextBox";
            this.CellLengthTextBox.Size = new System.Drawing.Size(70, 20);
            this.CellLengthTextBox.TabIndex = 6;
            this.CellLengthTextBox.Text = "25";
            this.CellLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDoubleTextBoxs_KeyPress);
            this.CellLengthTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LengthTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.WidthTextBox);
            this.groupBox1.Controls.Add(this.HeightTextBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размеры формы";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "(20-40 мм)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "(70-100 мм)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "(70-100 мм)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CellLengthLabel);
            this.groupBox2.Controls.Add(this.CellWidthLabel);
            this.groupBox2.Controls.Add(this.CellHeightLabel);
            this.groupBox2.Controls.Add(this.CellHeightTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CellLengthTextBox);
            this.groupBox2.Controls.Add(this.CellWidthTextBox);
            this.groupBox2.Location = new System.Drawing.Point(8, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 104);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Размеры ячеек";
            // 
            // CellLengthLabel
            // 
            this.CellLengthLabel.AutoSize = true;
            this.CellLengthLabel.Location = new System.Drawing.Point(197, 74);
            this.CellLengthLabel.Name = "CellLengthLabel";
            this.CellLengthLabel.Size = new System.Drawing.Size(59, 13);
            this.CellLengthLabel.TabIndex = 17;
            this.CellLengthLabel.Text = "(15-25 мм)";
            // 
            // CellWidthLabel
            // 
            this.CellWidthLabel.AutoSize = true;
            this.CellWidthLabel.Location = new System.Drawing.Point(197, 48);
            this.CellWidthLabel.Name = "CellWidthLabel";
            this.CellWidthLabel.Size = new System.Drawing.Size(59, 13);
            this.CellWidthLabel.TabIndex = 16;
            this.CellWidthLabel.Text = "(15-25 мм)";
            // 
            // CellHeightLabel
            // 
            this.CellHeightLabel.AutoSize = true;
            this.CellHeightLabel.Location = new System.Drawing.Point(197, 22);
            this.CellHeightLabel.Name = "CellHeightLabel";
            this.CellHeightLabel.Size = new System.Drawing.Size(59, 13);
            this.CellHeightLabel.TabIndex = 15;
            this.CellHeightLabel.Text = "(15-25 мм)";
            // 
            // CellHeightTextBox
            // 
            this.CellHeightTextBox.Location = new System.Drawing.Point(121, 19);
            this.CellHeightTextBox.Name = "CellHeightTextBox";
            this.CellHeightTextBox.Size = new System.Drawing.Size(70, 20);
            this.CellHeightTextBox.TabIndex = 4;
            this.CellHeightTextBox.Text = "25";
            this.CellHeightTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Высота ячейки (мм)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 262);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CreateModelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADIceTray";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateModelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox CellWidthTextBox;
        private System.Windows.Forms.TextBox CellLengthTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CellHeightTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CellLengthLabel;
        private System.Windows.Forms.Label CellWidthLabel;
        private System.Windows.Forms.Label CellHeightLabel;
    }
}

