namespace Lesson_5_MDI
{
    partial class Form2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PlaceBornText = new System.Windows.Forms.TextBox();
            this.SecondNameText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.PlaseBornLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SurnameText = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.12963F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.87037F));
            this.tableLayoutPanel1.Controls.Add(this.PlaceBornText, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.SecondNameText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.NameText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PlaseBornLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.DateLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SecondNameLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.NameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SaveButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.SurnameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SurnameText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 204);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PlaceBornText
            // 
            this.PlaceBornText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlaceBornText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaceBornText.Location = new System.Drawing.Point(185, 139);
            this.PlaceBornText.Name = "PlaceBornText";
            this.PlaceBornText.Size = new System.Drawing.Size(244, 26);
            this.PlaceBornText.TabIndex = 14;
            this.PlaceBornText.TextChanged += new System.EventHandler(this.PlaceBornText_TextChanged);
            // 
            // SecondNameText
            // 
            this.SecondNameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondNameText.Location = new System.Drawing.Point(185, 71);
            this.SecondNameText.Name = "SecondNameText";
            this.SecondNameText.Size = new System.Drawing.Size(244, 26);
            this.SecondNameText.TabIndex = 12;
            this.SecondNameText.TextChanged += new System.EventHandler(this.SecondNameText_TextChanged);
            // 
            // NameText
            // 
            this.NameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(185, 37);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(244, 26);
            this.NameText.TabIndex = 11;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // PlaseBornLabel
            // 
            this.PlaseBornLabel.AutoSize = true;
            this.PlaseBornLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlaseBornLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaseBornLabel.Location = new System.Drawing.Point(3, 139);
            this.PlaseBornLabel.Margin = new System.Windows.Forms.Padding(3);
            this.PlaseBornLabel.Name = "PlaseBornLabel";
            this.PlaseBornLabel.Size = new System.Drawing.Size(176, 28);
            this.PlaseBornLabel.TabIndex = 9;
            this.PlaseBornLabel.Text = "Место рождения";
            this.PlaseBornLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(3, 105);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(3);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(176, 28);
            this.DateLabel.TabIndex = 7;
            this.DateLabel.Text = "Дата рождения";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondNameLabel.Location = new System.Drawing.Point(3, 71);
            this.SecondNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(176, 28);
            this.SecondNameLabel.TabIndex = 5;
            this.SecondNameLabel.Text = "Отчество";
            this.SecondNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(3, 37);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(176, 28);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Имя";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SaveButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.SaveButton, 2);
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(3, 173);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(426, 28);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(3, 3);
            this.SurnameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(176, 28);
            this.SurnameLabel.TabIndex = 1;
            this.SurnameLabel.Text = "Фамилия";
            this.SurnameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SurnameText
            // 
            this.SurnameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SurnameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameText.Location = new System.Drawing.Point(185, 3);
            this.SurnameText.Name = "SurnameText";
            this.SurnameText.Size = new System.Drawing.Size(244, 26);
            this.SurnameText.TabIndex = 10;
            this.SurnameText.TextChanged += new System.EventHandler(this.SurnameText_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 105);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 26);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 208);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label PlaseBornLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label SecondNameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox PlaceBornText;
        private System.Windows.Forms.TextBox SecondNameText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox SurnameText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}