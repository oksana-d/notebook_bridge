namespace notebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обработкаТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПервогоВхожденияДвухСловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.статистикаToolStripMenuItem,
            this.обработкаТекстаToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.проверкаToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            resources.ApplyResources(this.файлToolStripMenuItem, "файлToolStripMenuItem");
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem1,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            // 
            // создатьToolStripMenuItem
            // 
            resources.ApplyResources(this.создатьToolStripMenuItem, "создатьToolStripMenuItem");
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            resources.ApplyResources(this.открытьToolStripMenuItem, "открытьToolStripMenuItem");
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem1
            // 
            resources.ApplyResources(this.сохранитьToolStripMenuItem1, "сохранитьToolStripMenuItem1");
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьToolStripMenuItem1_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            resources.ApplyResources(this.закрытьToolStripMenuItem, "закрытьToolStripMenuItem");
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            resources.ApplyResources(this.статистикаToolStripMenuItem, "статистикаToolStripMenuItem");
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Click += new System.EventHandler(this.статистикаToolStripMenuItem_Click);
            // 
            // обработкаТекстаToolStripMenuItem
            // 
            resources.ApplyResources(this.обработкаТекстаToolStripMenuItem, "обработкаТекстаToolStripMenuItem");
            this.обработкаТекстаToolStripMenuItem.Name = "обработкаТекстаToolStripMenuItem";
            this.обработкаТекстаToolStripMenuItem.Click += new System.EventHandler(this.обработкаТекстаToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            resources.ApplyResources(this.поискToolStripMenuItem, "поискToolStripMenuItem");
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискПервогоВхожденияДвухСловToolStripMenuItem,
            this.поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem,
            this.поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            // 
            // поискПервогоВхожденияДвухСловToolStripMenuItem
            // 
            resources.ApplyResources(this.поискПервогоВхожденияДвухСловToolStripMenuItem, "поискПервогоВхожденияДвухСловToolStripMenuItem");
            this.поискПервогоВхожденияДвухСловToolStripMenuItem.Name = "поискПервогоВхожденияДвухСловToolStripMenuItem";
            this.поискПервогоВхожденияДвухСловToolStripMenuItem.Click += new System.EventHandler(this.поискПервогоВхожденияДвухСловToolStripMenuItem_Click);
            // 
            // поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem
            // 
            resources.ApplyResources(this.поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem, "поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem");
            this.поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem.Name = "поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem";
            this.поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem.Click += new System.EventHandler(this.поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem_Click);
            // 
            // поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem
            // 
            resources.ApplyResources(this.поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem, "поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem");
            this.поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem.Name = "поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem";
            this.поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem.Click += new System.EventHandler(this.поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem_Click);
            // 
            // проверкаToolStripMenuItem
            // 
            resources.ApplyResources(this.проверкаToolStripMenuItem, "проверкаToolStripMenuItem");
            this.проверкаToolStripMenuItem.Name = "проверкаToolStripMenuItem";
            this.проверкаToolStripMenuItem.Click += new System.EventHandler(this.проверкаToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem обработкаТекстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПервогоВхожденияДвухСловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem;
    }
}

