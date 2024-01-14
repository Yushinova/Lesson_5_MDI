namespace Lesson_5_MDI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_txt = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_txt = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MonthMeu = new System.Windows.Forms.ToolStripMenuItem();
            this.MonthText = new System.Windows.Forms.ToolStripTextBox();
            this.PlacceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PlaceText = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.ChangeMenu,
            this.SelectMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_txt,
            this.Save_txt});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(48, 20);
            this.FileMenu.Text = "Файл";
            // 
            // Open_txt
            // 
            this.Open_txt.Name = "Open_txt";
            this.Open_txt.Size = new System.Drawing.Size(133, 22);
            this.Open_txt.Text = "Открыть";
            this.Open_txt.Click += new System.EventHandler(this.Open_txt_Click);
            // 
            // Save_txt
            // 
            this.Save_txt.Name = "Save_txt";
            this.Save_txt.Size = new System.Drawing.Size(133, 22);
            this.Save_txt.Text = "Сохранить";
            this.Save_txt.Click += new System.EventHandler(this.Save_txt_Click);
            // 
            // ChangeMenu
            // 
            this.ChangeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateItem,
            this.ChangeItem,
            this.DeleteItem});
            this.ChangeMenu.Name = "ChangeMenu";
            this.ChangeMenu.Size = new System.Drawing.Size(59, 20);
            this.ChangeMenu.Text = "Правка";
            // 
            // CreateItem
            // 
            this.CreateItem.Name = "CreateItem";
            this.CreateItem.Size = new System.Drawing.Size(154, 22);
            this.CreateItem.Text = "Создать";
            this.CreateItem.Click += new System.EventHandler(this.CreateItem_Click);
            // 
            // ChangeItem
            // 
            this.ChangeItem.Name = "ChangeItem";
            this.ChangeItem.Size = new System.Drawing.Size(154, 22);
            this.ChangeItem.Text = "Редактировать";
            this.ChangeItem.Click += new System.EventHandler(this.ChangeItem_Click);
            // 
            // DeleteItem
            // 
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(154, 22);
            this.DeleteItem.Text = "Удалить";
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // SelectMenu
            // 
            this.SelectMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MonthMeu,
            this.PlacceMenu});
            this.SelectMenu.Name = "SelectMenu";
            this.SelectMenu.Size = new System.Drawing.Size(92, 20);
            this.SelectMenu.Text = "Выбрать по...";
            this.SelectMenu.Click += new System.EventHandler(this.SelectMenu_Click);
            // 
            // MonthMeu
            // 
            this.MonthMeu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MonthText});
            this.MonthMeu.Name = "MonthMeu";
            this.MonthMeu.Size = new System.Drawing.Size(180, 22);
            this.MonthMeu.Text = "Месяц рождения";
            this.MonthMeu.Click += new System.EventHandler(this.MonthMeu_Click);
            // 
            // MonthText
            // 
            this.MonthText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MonthText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MonthText.Name = "MonthText";
            this.MonthText.Size = new System.Drawing.Size(100, 23);
            this.MonthText.Text = "Введите число";
            this.MonthText.TextChanged += new System.EventHandler(this.MonthText_TextChanged);
            // 
            // PlacceMenu
            // 
            this.PlacceMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlaceText});
            this.PlacceMenu.Name = "PlacceMenu";
            this.PlacceMenu.Size = new System.Drawing.Size(180, 22);
            this.PlacceMenu.Text = "Место рождения";
            // 
            // PlaceText
            // 
            this.PlaceText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PlaceText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PlaceText.Name = "PlaceText";
            this.PlaceText.Size = new System.Drawing.Size(100, 23);
            this.PlaceText.Text = "Введите город";
            this.PlaceText.Click += new System.EventHandler(this.PlaceText_Click);
            this.PlaceText.TextChanged += new System.EventHandler(this.PlaceText_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(980, 423);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Фамилия";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Имя";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Отчество";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата рождения";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Место рождения";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(209, 1);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem Open_txt;
        private System.Windows.Forms.ToolStripMenuItem Save_txt;
        private System.Windows.Forms.ToolStripMenuItem ChangeMenu;
        private System.Windows.Forms.ToolStripMenuItem CreateItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolStripMenuItem SelectMenu;
        private System.Windows.Forms.ToolStripMenuItem MonthMeu;
        private System.Windows.Forms.ToolStripMenuItem PlacceMenu;
        private System.Windows.Forms.ToolStripTextBox MonthText;
        private System.Windows.Forms.ToolStripTextBox PlaceText;
        private System.Windows.Forms.Button BackButton;
    }
}

