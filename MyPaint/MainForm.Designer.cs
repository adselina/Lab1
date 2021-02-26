
namespace MyPaint
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерХолстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.горизонтальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.упорядочитьЗначкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.красныйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.синийToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.выбратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.brashSize = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.penButton = new System.Windows.Forms.ToolStripButton();
            this.lineButton = new System.Windows.Forms.ToolStripButton();
            this.circleButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.starButton = new System.Windows.Forms.ToolStripButton();
            this.Nstar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.scalePlusButton = new System.Windows.Forms.ToolStripButton();
            this.scaleMinusButton = new System.Windows.Forms.ToolStripButton();
            this.rubberButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.colorStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.curColorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripScale = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.рисунокToolStripMenuItem,
            this.окноToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.окноToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.toolStripMenuItem3,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(353, 34);
            this.новыйToolStripMenuItem.Text = "&Новый ";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(353, 34);
            this.открытьToolStripMenuItem.Text = "&Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(350, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(353, 34);
            this.сохранитьToolStripMenuItem.Text = "&Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(353, 34);
            this.сохранитьКакToolStripMenuItem.Text = "&Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(350, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(353, 34);
            this.выходToolStripMenuItem.Text = "&Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // рисунокToolStripMenuItem
            // 
            this.рисунокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерХолстаToolStripMenuItem});
            this.рисунокToolStripMenuItem.Name = "рисунокToolStripMenuItem";
            this.рисунокToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.рисунокToolStripMenuItem.Text = "&Рисунок";
            this.рисунокToolStripMenuItem.Click += new System.EventHandler(this.рисунокToolStripMenuItem_Click);
            // 
            // размерХолстаToolStripMenuItem
            // 
            this.размерХолстаToolStripMenuItem.Name = "размерХолстаToolStripMenuItem";
            this.размерХолстаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.размерХолстаToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.размерХолстаToolStripMenuItem.Text = "&Размер холста";
            this.размерХолстаToolStripMenuItem.Click += new System.EventHandler(this.размерХолстаToolStripMenuItem_Click);
            // 
            // окноToolStripMenuItem
            // 
            this.окноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вертикальноToolStripMenuItem,
            this.горизонтальноToolStripMenuItem,
            this.каскадомToolStripMenuItem,
            this.упорядочитьЗначкиToolStripMenuItem});
            this.окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            this.окноToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.окноToolStripMenuItem.Text = "&Окно";
            // 
            // вертикальноToolStripMenuItem
            // 
            this.вертикальноToolStripMenuItem.Name = "вертикальноToolStripMenuItem";
            this.вертикальноToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F10)));
            this.вертикальноToolStripMenuItem.Size = new System.Drawing.Size(363, 34);
            this.вертикальноToolStripMenuItem.Text = "&Вертикально";
            this.вертикальноToolStripMenuItem.Click += new System.EventHandler(this.вертикальноToolStripMenuItem_Click);
            // 
            // горизонтальноToolStripMenuItem
            // 
            this.горизонтальноToolStripMenuItem.Name = "горизонтальноToolStripMenuItem";
            this.горизонтальноToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F11)));
            this.горизонтальноToolStripMenuItem.Size = new System.Drawing.Size(363, 34);
            this.горизонтальноToolStripMenuItem.Text = "&Горизонтально";
            this.горизонтальноToolStripMenuItem.Click += new System.EventHandler(this.сверхуВнизToolStripMenuItem_Click);
            // 
            // каскадомToolStripMenuItem
            // 
            this.каскадомToolStripMenuItem.Name = "каскадомToolStripMenuItem";
            this.каскадомToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F12)));
            this.каскадомToolStripMenuItem.Size = new System.Drawing.Size(363, 34);
            this.каскадомToolStripMenuItem.Text = "&Каскадом";
            this.каскадомToolStripMenuItem.Click += new System.EventHandler(this.каскадомToolStripMenuItem_Click);
            // 
            // упорядочитьЗначкиToolStripMenuItem
            // 
            this.упорядочитьЗначкиToolStripMenuItem.Name = "упорядочитьЗначкиToolStripMenuItem";
            this.упорядочитьЗначкиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F13)));
            this.упорядочитьЗначкиToolStripMenuItem.Size = new System.Drawing.Size(363, 34);
            this.упорядочитьЗначкиToolStripMenuItem.Text = "&Упорядочить значки";
            this.упорядочитьЗначкиToolStripMenuItem.Click += new System.EventHandler(this.упорядочитьЗначкиToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.справкаToolStripMenuItem.Text = "&Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.оПрограммеToolStripMenuItem.Text = "&О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.фильтрыToolStripMenuItem.Text = "&Фильтры";
            this.фильтрыToolStripMenuItem.Click += new System.EventHandler(this.фильтрыToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.brashSize,
            this.toolStripSeparator2,
            this.penButton,
            this.lineButton,
            this.circleButton,
            this.toolStripSeparator3,
            this.starButton,
            this.Nstar,
            this.toolStripButton2,
            this.scalePlusButton,
            this.scaleMinusButton,
            this.rubberButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1004, 33);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.красныйToolStripMenuItem1,
            this.зеленыйToolStripMenuItem1,
            this.синийToolStripMenuItem1,
            this.toolStripMenuItem6,
            this.выбратьToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(42, 28);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // красныйToolStripMenuItem1
            // 
            this.красныйToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("красныйToolStripMenuItem1.Image")));
            this.красныйToolStripMenuItem1.Name = "красныйToolStripMenuItem1";
            this.красныйToolStripMenuItem1.Size = new System.Drawing.Size(195, 34);
            this.красныйToolStripMenuItem1.Text = "Красный";
            this.красныйToolStripMenuItem1.Click += new System.EventHandler(this.красныйToolStripMenuItem1_Click);
            // 
            // зеленыйToolStripMenuItem1
            // 
            this.зеленыйToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("зеленыйToolStripMenuItem1.Image")));
            this.зеленыйToolStripMenuItem1.Name = "зеленыйToolStripMenuItem1";
            this.зеленыйToolStripMenuItem1.Size = new System.Drawing.Size(195, 34);
            this.зеленыйToolStripMenuItem1.Text = "Зеленый";
            this.зеленыйToolStripMenuItem1.Click += new System.EventHandler(this.зеленыйToolStripMenuItem1_Click);
            // 
            // синийToolStripMenuItem1
            // 
            this.синийToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("синийToolStripMenuItem1.Image")));
            this.синийToolStripMenuItem1.Name = "синийToolStripMenuItem1";
            this.синийToolStripMenuItem1.Size = new System.Drawing.Size(195, 34);
            this.синийToolStripMenuItem1.Text = "Синий";
            this.синийToolStripMenuItem1.Click += new System.EventHandler(this.синийToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(192, 6);
            // 
            // выбратьToolStripMenuItem
            // 
            this.выбратьToolStripMenuItem.Name = "выбратьToolStripMenuItem";
            this.выбратьToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.выбратьToolStripMenuItem.Text = "Выбрать...";
            this.выбратьToolStripMenuItem.Click += new System.EventHandler(this.выбратьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 28);
            this.toolStripLabel1.Text = "Кисть:";
            // 
            // brashSize
            // 
            this.brashSize.BackColor = System.Drawing.SystemColors.Window;
            this.brashSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.brashSize.Name = "brashSize";
            this.brashSize.Size = new System.Drawing.Size(50, 33);
            this.brashSize.Text = "3";
            this.brashSize.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.brashSize.TextChanged += new System.EventHandler(this.brashSize_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // penButton
            // 
            this.penButton.CheckOnClick = true;
            this.penButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.penButton.Image = ((System.Drawing.Image)(resources.GetObject("penButton.Image")));
            this.penButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.penButton.Name = "penButton";
            this.penButton.Size = new System.Drawing.Size(34, 28);
            this.penButton.Text = "toolStripButton1";
            this.penButton.Click += new System.EventHandler(this.penButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.CheckOnClick = true;
            this.lineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineButton.Image = ((System.Drawing.Image)(resources.GetObject("lineButton.Image")));
            this.lineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(34, 28);
            this.lineButton.Text = "toolStripButton2";
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.CheckOnClick = true;
            this.circleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.circleButton.Image = ((System.Drawing.Image)(resources.GetObject("circleButton.Image")));
            this.circleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(34, 28);
            this.circleButton.Text = "toolStripButton3";
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // starButton
            // 
            this.starButton.CheckOnClick = true;
            this.starButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.starButton.Image = ((System.Drawing.Image)(resources.GetObject("starButton.Image")));
            this.starButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.starButton.Name = "starButton";
            this.starButton.Size = new System.Drawing.Size(34, 28);
            this.starButton.Text = "toolStripButton4";
            this.starButton.Click += new System.EventHandler(this.starButton_Click);
            // 
            // Nstar
            // 
            this.Nstar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Nstar.Name = "Nstar";
            this.Nstar.Size = new System.Drawing.Size(50, 33);
            this.Nstar.Text = "4";
            this.Nstar.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nstar.TextChanged += new System.EventHandler(this.Nstar_TextChanged);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(6, 33);
            // 
            // scalePlusButton
            // 
            this.scalePlusButton.CheckOnClick = true;
            this.scalePlusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scalePlusButton.Image = ((System.Drawing.Image)(resources.GetObject("scalePlusButton.Image")));
            this.scalePlusButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scalePlusButton.Name = "scalePlusButton";
            this.scalePlusButton.Size = new System.Drawing.Size(34, 28);
            this.scalePlusButton.Text = "toolStripButton5";
            this.scalePlusButton.Click += new System.EventHandler(this.scalePlusButton_Click);
            // 
            // scaleMinusButton
            // 
            this.scaleMinusButton.CheckOnClick = true;
            this.scaleMinusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scaleMinusButton.Image = ((System.Drawing.Image)(resources.GetObject("scaleMinusButton.Image")));
            this.scaleMinusButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scaleMinusButton.Name = "scaleMinusButton";
            this.scaleMinusButton.Size = new System.Drawing.Size(34, 28);
            this.scaleMinusButton.Text = "toolStripButton6";
            this.scaleMinusButton.Click += new System.EventHandler(this.scaleMinusButton_Click);
            // 
            // rubberButton
            // 
            this.rubberButton.CheckOnClick = true;
            this.rubberButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rubberButton.Image = ((System.Drawing.Image)(resources.GetObject("rubberButton.Image")));
            this.rubberButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rubberButton.Name = "rubberButton";
            this.rubberButton.Size = new System.Drawing.Size(34, 28);
            this.rubberButton.Text = "toolStripButton1";
            this.rubberButton.Click += new System.EventHandler(this.rubberButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorStrip,
            this.curColorLabel,
            this.toolStripStatusLabel1,
            this.toolStripScale});
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1004, 32);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // colorStrip
            // 
            this.colorStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.colorStrip.Name = "colorStrip";
            this.colorStrip.Size = new System.Drawing.Size(0, 25);
            // 
            // curColorLabel
            // 
            this.curColorLabel.AutoSize = false;
            this.curColorLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.curColorLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.curColorLabel.Name = "curColorLabel";
            this.curColorLabel.Size = new System.Drawing.Size(30, 25);
            this.curColorLabel.Text = "Цвет";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Enabled = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(100, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripScale
            // 
            this.toolStripScale.Name = "toolStripScale";
            this.toolStripScale.Size = new System.Drawing.Size(94, 25);
            this.toolStripScale.Text = "Масштаб: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 608);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "My paint";
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикальноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадомToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерХолстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem горизонтальноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem упорядочитьЗначкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem красныйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem зеленыйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem синийToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem выбратьToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox brashSize;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton penButton;
        private System.Windows.Forms.ToolStripButton lineButton;
        private System.Windows.Forms.ToolStripButton circleButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton starButton;
        private System.Windows.Forms.ToolStripButton scalePlusButton;
        private System.Windows.Forms.ToolStripButton scaleMinusButton;
        private System.Windows.Forms.ToolStripButton rubberButton;
        private System.Windows.Forms.ToolStripSeparator toolStripButton2;
        private System.Windows.Forms.ToolStripTextBox Nstar;
        private System.Windows.Forms.ToolStripStatusLabel colorStrip;
        private System.Windows.Forms.ToolStripStatusLabel curColorLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripScale;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
    }
}

