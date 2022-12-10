using System;

namespace WindowsFormPaint
{
    partial class Paint
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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentsMainPanel = new System.Windows.Forms.Panel();
            this.instrumentsPanel4 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.palitraButton = new System.Windows.Forms.Button();
            this.instrumentsPanel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.instrumentsPanel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.circleButton = new System.Windows.Forms.Button();
            this.reactangleButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.instrumentsPanel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textButton = new System.Windows.Forms.Button();
            this.pipetkaButton = new System.Windows.Forms.Button();
            this.eraserButton = new System.Windows.Forms.Button();
            this.penButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.instrumentsMainPanel.SuspendLayout();
            this.instrumentsPanel4.SuspendLayout();
            this.instrumentsPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.instrumentsPanel2.SuspendLayout();
            this.instrumentsPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // instrumentsMainPanel
            // 
            this.instrumentsMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instrumentsMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instrumentsMainPanel.Controls.Add(this.instrumentsPanel4);
            this.instrumentsMainPanel.Controls.Add(this.instrumentsPanel3);
            this.instrumentsMainPanel.Controls.Add(this.instrumentsPanel2);
            this.instrumentsMainPanel.Controls.Add(this.instrumentsPanel1);
            this.instrumentsMainPanel.Location = new System.Drawing.Point(12, 27);
            this.instrumentsMainPanel.Name = "instrumentsMainPanel";
            this.instrumentsMainPanel.Size = new System.Drawing.Size(830, 81);
            this.instrumentsMainPanel.TabIndex = 3;
            // 
            // instrumentsPanel4
            // 
            this.instrumentsPanel4.Controls.Add(this.checkBox2);
            this.instrumentsPanel4.Controls.Add(this.checkBox1);
            this.instrumentsPanel4.Controls.Add(this.label4);
            this.instrumentsPanel4.Controls.Add(this.palitraButton);
            this.instrumentsPanel4.Location = new System.Drawing.Point(463, 3);
            this.instrumentsPanel4.Name = "instrumentsPanel4";
            this.instrumentsPanel4.Size = new System.Drawing.Size(308, 68);
            this.instrumentsPanel4.TabIndex = 3;
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.BackColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(41, 20);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox2.MaximumSize = new System.Drawing.Size(100, 100);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(30, 28);
            this.checkBox2.TabIndex = 26;
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.BackColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(10, 20);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.MaximumSize = new System.Drawing.Size(100, 100);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(30, 28);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Цвета";
            // 
            // palitraButton
            // 
            this.palitraButton.BackgroundImage = global::WindowsFormPaint.Properties.Resources.icons8_палитра_45;
            this.palitraButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.palitraButton.ForeColor = System.Drawing.SystemColors.Control;
            this.palitraButton.Location = new System.Drawing.Point(74, 12);
            this.palitraButton.Name = "palitraButton";
            this.palitraButton.Size = new System.Drawing.Size(45, 45);
            this.palitraButton.TabIndex = 23;
            this.palitraButton.UseVisualStyleBackColor = true;
            this.palitraButton.Click += new System.EventHandler(this.palitraButton_Click);
            // 
            // instrumentsPanel3
            // 
            this.instrumentsPanel3.Controls.Add(this.label3);
            this.instrumentsPanel3.Controls.Add(this.trackBar);
            this.instrumentsPanel3.Location = new System.Drawing.Point(267, 3);
            this.instrumentsPanel3.Name = "instrumentsPanel3";
            this.instrumentsPanel3.Size = new System.Drawing.Size(190, 68);
            this.instrumentsPanel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Толщина";
            // 
            // trackBar
            // 
            this.trackBar.LargeChange = 1;
            this.trackBar.Location = new System.Drawing.Point(3, 20);
            this.trackBar.Maximum = 25;
            this.trackBar.Minimum = 2;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(184, 45);
            this.trackBar.TabIndex = 1;
            this.trackBar.Value = 2;
            // 
            // instrumentsPanel2
            // 
            this.instrumentsPanel2.Controls.Add(this.label2);
            this.instrumentsPanel2.Controls.Add(this.circleButton);
            this.instrumentsPanel2.Controls.Add(this.reactangleButton);
            this.instrumentsPanel2.Controls.Add(this.lineButton);
            this.instrumentsPanel2.Location = new System.Drawing.Point(152, 3);
            this.instrumentsPanel2.Name = "instrumentsPanel2";
            this.instrumentsPanel2.Size = new System.Drawing.Size(109, 68);
            this.instrumentsPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фигуры";
            // 
            // circleButton
            // 
            this.circleButton.BackgroundImage = global::WindowsFormPaint.Properties.Resources.icons8_внутри_тонкой_окружности_29;
            this.circleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.circleButton.ForeColor = System.Drawing.SystemColors.Control;
            this.circleButton.Location = new System.Drawing.Point(74, 23);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(29, 28);
            this.circleButton.TabIndex = 4;
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // reactangleButton
            // 
            this.reactangleButton.BackgroundImage = global::WindowsFormPaint.Properties.Resources.icons8_прямоугольник_29;
            this.reactangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reactangleButton.ForeColor = System.Drawing.SystemColors.Control;
            this.reactangleButton.Location = new System.Drawing.Point(39, 23);
            this.reactangleButton.Name = "reactangleButton";
            this.reactangleButton.Size = new System.Drawing.Size(29, 28);
            this.reactangleButton.TabIndex = 3;
            this.reactangleButton.UseVisualStyleBackColor = true;
            this.reactangleButton.Click += new System.EventHandler(this.reactangleButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.BackgroundImage = global::WindowsFormPaint.Properties.Resources.icons8_линия_29;
            this.lineButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lineButton.ForeColor = System.Drawing.SystemColors.Control;
            this.lineButton.Location = new System.Drawing.Point(4, 23);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(29, 28);
            this.lineButton.TabIndex = 2;
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // instrumentsPanel1
            // 
            this.instrumentsPanel1.Controls.Add(this.label1);
            this.instrumentsPanel1.Controls.Add(this.textButton);
            this.instrumentsPanel1.Controls.Add(this.pipetkaButton);
            this.instrumentsPanel1.Controls.Add(this.eraserButton);
            this.instrumentsPanel1.Controls.Add(this.penButton);
            this.instrumentsPanel1.Location = new System.Drawing.Point(3, 3);
            this.instrumentsPanel1.Name = "instrumentsPanel1";
            this.instrumentsPanel1.Size = new System.Drawing.Size(143, 68);
            this.instrumentsPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Инструменты";
            // 
            // textButton
            // 
            this.textButton.BackgroundImage = global::WindowsFormPaint.Properties.Resources.icons8_добавить_текст_29;
            this.textButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.textButton.Location = new System.Drawing.Point(109, 23);
            this.textButton.Name = "textButton";
            this.textButton.Size = new System.Drawing.Size(29, 28);
            this.textButton.TabIndex = 4;
            this.textButton.UseVisualStyleBackColor = true;
            this.textButton.Click += new System.EventHandler(this.textButton_Click);
            // 
            // pipetkaButton
            // 
            this.pipetkaButton.BackgroundImage = global::WindowsFormPaint.Properties.Resources.icons8_пипетка_29;
            this.pipetkaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pipetkaButton.Location = new System.Drawing.Point(74, 23);
            this.pipetkaButton.Name = "pipetkaButton";
            this.pipetkaButton.Size = new System.Drawing.Size(29, 28);
            this.pipetkaButton.TabIndex = 3;
            this.pipetkaButton.UseVisualStyleBackColor = true;
            this.pipetkaButton.Click += new System.EventHandler(this.pipetkaButton_Click);
            // 
            // eraserButton
            // 
            this.eraserButton.BackgroundImage = global::WindowsFormPaint.Properties.Resources.icons8_ластик_29;
            this.eraserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eraserButton.Location = new System.Drawing.Point(39, 23);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Size = new System.Drawing.Size(29, 28);
            this.eraserButton.TabIndex = 2;
            this.eraserButton.UseVisualStyleBackColor = true;
            this.eraserButton.Click += new System.EventHandler(this.eraserButton_Click);
            // 
            // penButton
            // 
            this.penButton.BackgroundImage = global::WindowsFormPaint.Properties.Resources.icons8_кончик_карандаша_29;
            this.penButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.penButton.ForeColor = System.Drawing.SystemColors.Control;
            this.penButton.Location = new System.Drawing.Point(4, 23);
            this.penButton.Name = "penButton";
            this.penButton.Size = new System.Drawing.Size(29, 28);
            this.penButton.TabIndex = 1;
            this.penButton.UseVisualStyleBackColor = true;
            this.penButton.Click += new System.EventHandler(this.penButton_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(12, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 344);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(854, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.instrumentsMainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Paint";
            this.Text = "SuperMegaPaintWF by Rinar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.instrumentsMainPanel.ResumeLayout(false);
            this.instrumentsPanel4.ResumeLayout(false);
            this.instrumentsPanel4.PerformLayout();
            this.instrumentsPanel3.ResumeLayout(false);
            this.instrumentsPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.instrumentsPanel2.ResumeLayout(false);
            this.instrumentsPanel2.PerformLayout();
            this.instrumentsPanel1.ResumeLayout(false);
            this.instrumentsPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Panel instrumentsMainPanel;
        private System.Windows.Forms.Panel instrumentsPanel1;
        private System.Windows.Forms.Panel instrumentsPanel4;
        private System.Windows.Forms.Panel instrumentsPanel3;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Panel instrumentsPanel2;
        private System.Windows.Forms.Button penButton;
        private System.Windows.Forms.Button pipetkaButton;
        private System.Windows.Forms.Button eraserButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button reactangleButton;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button textButton;
        private System.Windows.Forms.Button palitraButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

