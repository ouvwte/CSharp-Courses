namespace brunovKpSort
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
            this.сортировкаВставкамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.описаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.быстраяСортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.описаниеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.запускToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаВставкамиToolStripMenuItem,
            this.быстраяСортировкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сортировкаВставкамиToolStripMenuItem
            // 
            this.сортировкаВставкамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.описаниеToolStripMenuItem,
            this.запускToolStripMenuItem});
            this.сортировкаВставкамиToolStripMenuItem.Name = "сортировкаВставкамиToolStripMenuItem";
            this.сортировкаВставкамиToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.сортировкаВставкамиToolStripMenuItem.Text = "Сортировка вставками";
            // 
            // описаниеToolStripMenuItem
            // 
            this.описаниеToolStripMenuItem.Name = "описаниеToolStripMenuItem";
            this.описаниеToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.описаниеToolStripMenuItem.Text = "Описание";
            this.описаниеToolStripMenuItem.Click += new System.EventHandler(this.описаниеToolStripMenuItem_Click);
            // 
            // запускToolStripMenuItem
            // 
            this.запускToolStripMenuItem.Name = "запускToolStripMenuItem";
            this.запускToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.запускToolStripMenuItem.Text = "Запуск";
            this.запускToolStripMenuItem.Click += new System.EventHandler(this.запускToolStripMenuItem_Click);
            // 
            // быстраяСортировкаToolStripMenuItem
            // 
            this.быстраяСортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.описаниеToolStripMenuItem1,
            this.запускToolStripMenuItem1});
            this.быстраяСортировкаToolStripMenuItem.Name = "быстраяСортировкаToolStripMenuItem";
            this.быстраяСортировкаToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.быстраяСортировкаToolStripMenuItem.Text = "Сортировка пузырьком";
            // 
            // описаниеToolStripMenuItem1
            // 
            this.описаниеToolStripMenuItem1.Name = "описаниеToolStripMenuItem1";
            this.описаниеToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.описаниеToolStripMenuItem1.Text = "Описание";
            this.описаниеToolStripMenuItem1.Click += new System.EventHandler(this.описаниеToolStripMenuItem1_Click);
            // 
            // запускToolStripMenuItem1
            // 
            this.запускToolStripMenuItem1.Name = "запускToolStripMenuItem1";
            this.запускToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.запускToolStripMenuItem1.Text = "Запуск";
            this.запускToolStripMenuItem1.Click += new System.EventHandler(this.запускToolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(500, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сгенерировать массив";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(500, 88);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Отсортированный массив: ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 291);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(500, 85);
            this.dataGridView2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 432);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сортировкаВставкамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem описаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запускToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem быстраяСортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem описаниеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem запускToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

