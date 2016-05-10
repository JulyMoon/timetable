namespace Timetable
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.classListBox = new System.Windows.Forms.ListBox();
            this.classesComboBox = new System.Windows.Forms.ComboBox();
            this.bringBookClassListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.earlyClassCheckBox = new System.Windows.Forms.CheckBox();
            this.aboutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classListBox
            // 
            this.classListBox.BackColor = System.Drawing.SystemColors.Control;
            this.classListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classListBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classListBox.FormattingEnabled = true;
            this.classListBox.ItemHeight = 18;
            this.classListBox.Location = new System.Drawing.Point(12, 12);
            this.classListBox.Name = "classListBox";
            this.classListBox.Size = new System.Drawing.Size(203, 146);
            this.classListBox.TabIndex = 2;
            this.classListBox.SelectedIndexChanged += new System.EventHandler(this.classListBox_SelectedIndexChanged);
            // 
            // classesComboBox
            // 
            this.classesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classesComboBox.Enabled = false;
            this.classesComboBox.FormattingEnabled = true;
            this.classesComboBox.Location = new System.Drawing.Point(221, 12);
            this.classesComboBox.Name = "classesComboBox";
            this.classesComboBox.Size = new System.Drawing.Size(142, 21);
            this.classesComboBox.Sorted = true;
            this.classesComboBox.TabIndex = 3;
            this.classesComboBox.SelectedIndexChanged += new System.EventHandler(this.classesComboBox_SelectedIndexChanged);
            // 
            // bringBookClassListBox
            // 
            this.bringBookClassListBox.BackColor = System.Drawing.SystemColors.Control;
            this.bringBookClassListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bringBookClassListBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.bringBookClassListBox.FormattingEnabled = true;
            this.bringBookClassListBox.ItemHeight = 18;
            this.bringBookClassListBox.Location = new System.Drawing.Point(12, 157);
            this.bringBookClassListBox.Name = "bringBookClassListBox";
            this.bringBookClassListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.bringBookClassListBox.Size = new System.Drawing.Size(203, 56);
            this.bringBookClassListBox.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(221, 39);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(68, 27);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(295, 39);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(68, 27);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Enabled = false;
            this.resetButton.Location = new System.Drawing.Point(221, 153);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(142, 27);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Сброс";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // upButton
            // 
            this.upButton.Enabled = false;
            this.upButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upButton.Location = new System.Drawing.Point(221, 72);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(68, 27);
            this.upButton.TabIndex = 8;
            this.upButton.Text = "↑";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            this.downButton.Enabled = false;
            this.downButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downButton.Location = new System.Drawing.Point(295, 72);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(68, 27);
            this.downButton.TabIndex = 9;
            this.downButton.Text = "↓";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // earlyClassCheckBox
            // 
            this.earlyClassCheckBox.AutoSize = true;
            this.earlyClassCheckBox.Location = new System.Drawing.Point(235, 118);
            this.earlyClassCheckBox.Name = "earlyClassCheckBox";
            this.earlyClassCheckBox.Size = new System.Drawing.Size(95, 17);
            this.earlyClassCheckBox.TabIndex = 10;
            this.earlyClassCheckBox.Text = "Нулевой урок";
            this.earlyClassCheckBox.UseVisualStyleBackColor = true;
            this.earlyClassCheckBox.CheckedChanged += new System.EventHandler(this.earlyClassCheckBox_CheckedChanged);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(221, 186);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(142, 27);
            this.aboutButton.TabIndex = 11;
            this.aboutButton.Text = "О программе";
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 225);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.earlyClassCheckBox);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.bringBookClassListBox);
            this.Controls.Add(this.classesComboBox);
            this.Controls.Add(this.classListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Роспёсаня";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox classListBox;
        private System.Windows.Forms.ComboBox classesComboBox;
        private System.Windows.Forms.ListBox bringBookClassListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.CheckBox earlyClassCheckBox;
        private System.Windows.Forms.Button aboutButton;
    }
}

