namespace Computer_Graphics_6LR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            другоеToolStripMenuItem = new ToolStripMenuItem();
            восстановитьФотоToolStripMenuItem = new ToolStripMenuItem();
            groupB_params = new GroupBox();
            sharp_lb = new Label();
            tB_sharp = new TrackBar();
            button1 = new Button();
            glass_bttn = new Button();
            filter_size_lb = new Label();
            tB_filter_size = new TrackBar();
            sigma_lb = new Label();
            tB_sigma = new TrackBar();
            gaussian_filter_bttn = new Button();
            sharp_bttn = new Button();
            circ_lb = new Label();
            lines_lb = new Label();
            dots_lb = new Label();
            tB_circ = new TrackBar();
            circ_bttn = new Button();
            lines_bttn = new Button();
            tB_lines = new TrackBar();
            dots_bttn = new Button();
            tB_dots = new TrackBar();
            groupB = new GroupBox();
            panel_img = new Panel();
            menuStrip1.SuspendLayout();
            groupB_params.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tB_sharp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tB_filter_size).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tB_sigma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tB_circ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tB_lines).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tB_dots).BeginInit();
            groupB.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, другоеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1158, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(150, 26);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // другоеToolStripMenuItem
            // 
            другоеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { восстановитьФотоToolStripMenuItem });
            другоеToolStripMenuItem.Name = "другоеToolStripMenuItem";
            другоеToolStripMenuItem.Size = new Size(72, 24);
            другоеToolStripMenuItem.Text = "Другое";
            // 
            // восстановитьФотоToolStripMenuItem
            // 
            восстановитьФотоToolStripMenuItem.Name = "восстановитьФотоToolStripMenuItem";
            восстановитьФотоToolStripMenuItem.Size = new Size(225, 26);
            восстановитьФотоToolStripMenuItem.Text = "Восстановить фото";
            восстановитьФотоToolStripMenuItem.Click += восстановитьФотоToolStripMenuItem_Click;
            // 
            // groupB_params
            // 
            groupB_params.Controls.Add(sharp_lb);
            groupB_params.Controls.Add(tB_sharp);
            groupB_params.Controls.Add(button1);
            groupB_params.Controls.Add(glass_bttn);
            groupB_params.Controls.Add(filter_size_lb);
            groupB_params.Controls.Add(tB_filter_size);
            groupB_params.Controls.Add(sigma_lb);
            groupB_params.Controls.Add(tB_sigma);
            groupB_params.Controls.Add(gaussian_filter_bttn);
            groupB_params.Controls.Add(sharp_bttn);
            groupB_params.Controls.Add(circ_lb);
            groupB_params.Controls.Add(lines_lb);
            groupB_params.Controls.Add(dots_lb);
            groupB_params.Controls.Add(tB_circ);
            groupB_params.Controls.Add(circ_bttn);
            groupB_params.Controls.Add(lines_bttn);
            groupB_params.Controls.Add(tB_lines);
            groupB_params.Controls.Add(dots_bttn);
            groupB_params.Controls.Add(tB_dots);
            groupB_params.Location = new Point(548, 40);
            groupB_params.Name = "groupB_params";
            groupB_params.Size = new Size(562, 572);
            groupB_params.TabIndex = 4;
            groupB_params.TabStop = false;
            // 
            // sharp_lb
            // 
            sharp_lb.AutoSize = true;
            sharp_lb.Location = new Point(364, 370);
            sharp_lb.Name = "sharp_lb";
            sharp_lb.Size = new Size(17, 20);
            sharp_lb.TabIndex = 17;
            sharp_lb.Text = "1";
            // 
            // tB_sharp
            // 
            tB_sharp.Location = new Point(21, 370);
            tB_sharp.Name = "tB_sharp";
            tB_sharp.Size = new Size(337, 56);
            tB_sharp.TabIndex = 16;
            tB_sharp.Scroll += tB_sharp_Scroll;
            // 
            // button1
            // 
            button1.Location = new Point(403, 246);
            button1.Name = "button1";
            button1.Size = new Size(133, 29);
            button1.TabIndex = 15;
            button1.Text = "Резкость";
            button1.UseVisualStyleBackColor = true;
            // 
            // glass_bttn
            // 
            glass_bttn.Location = new Point(21, 516);
            glass_bttn.Name = "glass_bttn";
            glass_bttn.Size = new Size(133, 29);
            glass_bttn.TabIndex = 14;
            glass_bttn.Text = "Стекло";
            glass_bttn.UseVisualStyleBackColor = true;
            glass_bttn.Click += glass_bttn_Click;
            // 
            // filter_size_lb
            // 
            filter_size_lb.AutoSize = true;
            filter_size_lb.Location = new Point(364, 231);
            filter_size_lb.Name = "filter_size_lb";
            filter_size_lb.Size = new Size(17, 20);
            filter_size_lb.TabIndex = 13;
            filter_size_lb.Text = "1";
            // 
            // tB_filter_size
            // 
            tB_filter_size.Location = new Point(21, 231);
            tB_filter_size.Name = "tB_filter_size";
            tB_filter_size.Size = new Size(337, 56);
            tB_filter_size.TabIndex = 12;
            tB_filter_size.Scroll += tB_filter_size_Scroll;
            // 
            // sigma_lb
            // 
            sigma_lb.AutoSize = true;
            sigma_lb.Location = new Point(364, 300);
            sigma_lb.Name = "sigma_lb";
            sigma_lb.Size = new Size(28, 20);
            sigma_lb.TabIndex = 11;
            sigma_lb.Text = "0,1";
            // 
            // tB_sigma
            // 
            tB_sigma.Location = new Point(21, 300);
            tB_sigma.Name = "tB_sigma";
            tB_sigma.Size = new Size(337, 56);
            tB_sigma.TabIndex = 10;
            tB_sigma.Scroll += tB_sigma_Scroll;
            // 
            // gaussian_filter_bttn
            // 
            gaussian_filter_bttn.Location = new Point(403, 281);
            gaussian_filter_bttn.Name = "gaussian_filter_bttn";
            gaussian_filter_bttn.Size = new Size(133, 29);
            gaussian_filter_bttn.TabIndex = 9;
            gaussian_filter_bttn.Text = "фильтр гаусса";
            gaussian_filter_bttn.UseVisualStyleBackColor = true;
            gaussian_filter_bttn.Click += gaussian_filter_bttn_Click;
            // 
            // sharp_bttn
            // 
            sharp_bttn.Location = new Point(21, 438);
            sharp_bttn.Name = "sharp_bttn";
            sharp_bttn.Size = new Size(133, 29);
            sharp_bttn.TabIndex = 9;
            sharp_bttn.Text = "Резкость";
            sharp_bttn.UseVisualStyleBackColor = true;
            sharp_bttn.Click += sharp_bttn_Click;
            // 
            // circ_lb
            // 
            circ_lb.AutoSize = true;
            circ_lb.Location = new Point(364, 154);
            circ_lb.Name = "circ_lb";
            circ_lb.Size = new Size(17, 20);
            circ_lb.TabIndex = 8;
            circ_lb.Text = "1";
            // 
            // lines_lb
            // 
            lines_lb.AutoSize = true;
            lines_lb.Location = new Point(364, 92);
            lines_lb.Name = "lines_lb";
            lines_lb.Size = new Size(17, 20);
            lines_lb.TabIndex = 7;
            lines_lb.Text = "1";
            // 
            // dots_lb
            // 
            dots_lb.AutoSize = true;
            dots_lb.Location = new Point(364, 30);
            dots_lb.Name = "dots_lb";
            dots_lb.Size = new Size(28, 20);
            dots_lb.TabIndex = 6;
            dots_lb.Text = "0,1";
            // 
            // tB_circ
            // 
            tB_circ.Location = new Point(21, 150);
            tB_circ.Name = "tB_circ";
            tB_circ.Size = new Size(337, 56);
            tB_circ.TabIndex = 5;
            tB_circ.Scroll += tB_circ_Scroll;
            // 
            // circ_bttn
            // 
            circ_bttn.Location = new Point(442, 150);
            circ_bttn.Name = "circ_bttn";
            circ_bttn.Size = new Size(94, 29);
            circ_bttn.TabIndex = 4;
            circ_bttn.Text = "Круги";
            circ_bttn.UseVisualStyleBackColor = true;
            circ_bttn.Click += circ_bttn_Click;
            // 
            // lines_bttn
            // 
            lines_bttn.Location = new Point(442, 88);
            lines_bttn.Name = "lines_bttn";
            lines_bttn.Size = new Size(94, 29);
            lines_bttn.TabIndex = 3;
            lines_bttn.Text = "Линии";
            lines_bttn.UseVisualStyleBackColor = true;
            lines_bttn.Click += lines_bttn_Click;
            // 
            // tB_lines
            // 
            tB_lines.Location = new Point(21, 88);
            tB_lines.Name = "tB_lines";
            tB_lines.Size = new Size(337, 56);
            tB_lines.TabIndex = 2;
            tB_lines.Scroll += tB_lines_Scroll;
            // 
            // dots_bttn
            // 
            dots_bttn.Location = new Point(442, 26);
            dots_bttn.Name = "dots_bttn";
            dots_bttn.Size = new Size(94, 29);
            dots_bttn.TabIndex = 1;
            dots_bttn.Text = "Точки";
            dots_bttn.UseVisualStyleBackColor = true;
            dots_bttn.Click += dots_bttn_Click;
            // 
            // tB_dots
            // 
            tB_dots.Location = new Point(21, 26);
            tB_dots.Name = "tB_dots";
            tB_dots.Size = new Size(337, 56);
            tB_dots.TabIndex = 0;
            tB_dots.Scroll += tB_dots_Scroll;
            // 
            // groupB
            // 
            groupB.Controls.Add(panel_img);
            groupB.Location = new Point(12, 31);
            groupB.Name = "groupB";
            groupB.Size = new Size(530, 435);
            groupB.TabIndex = 3;
            groupB.TabStop = false;
            groupB.SizeChanged += groupB_SizeChanged;
            // 
            // panel_img
            // 
            panel_img.Dock = DockStyle.Fill;
            panel_img.Location = new Point(3, 23);
            panel_img.Name = "panel_img";
            panel_img.Size = new Size(524, 409);
            panel_img.TabIndex = 0;
            panel_img.Paint += panel_img_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 688);
            Controls.Add(groupB_params);
            Controls.Add(groupB);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupB_params.ResumeLayout(false);
            groupB_params.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tB_sharp).EndInit();
            ((System.ComponentModel.ISupportInitialize)tB_filter_size).EndInit();
            ((System.ComponentModel.ISupportInitialize)tB_sigma).EndInit();
            ((System.ComponentModel.ISupportInitialize)tB_circ).EndInit();
            ((System.ComponentModel.ISupportInitialize)tB_lines).EndInit();
            ((System.ComponentModel.ISupportInitialize)tB_dots).EndInit();
            groupB.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private GroupBox groupB_params;
        private GroupBox groupB;
        private Panel panel_img;
        private Button lines_bttn;
        private TrackBar tB_lines;
        private Button dots_bttn;
        private TrackBar tB_dots;
        private TrackBar tB_circ;
        private Button circ_bttn;
        private Label circ_lb;
        private Label lines_lb;
        private Label dots_lb;
        private ToolStripMenuItem другоеToolStripMenuItem;
        private ToolStripMenuItem восстановитьФотоToolStripMenuItem;
        private Button gaussian_filter_bttn;
        private Button sharp_bttn;
        private Label label2;
        private TrackBar tB_filter_size;
        private Label label1;
        private TrackBar tB_sigma;
        private Label filter_size_lb;
        private Label sigma_lb;
        private Button glass_bttn;
        private Label sharp_lb;
        private TrackBar tB_sharp;
        private Button button1;
    }
}
