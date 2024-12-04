using System.Drawing;

namespace Computer_Graphics_6LR
{
    public partial class Form1 : Form
    {
        private Image image;
        private Image img;
        private int width;
        private int height;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            trackBar_init(tB_dots);
            trackBar_init(tB_lines);
            trackBar_init(tB_circ);
            trackBar_init(tB_filter_size);
            tB_filter_size.Maximum = 11;
            trackBar_init(tB_sigma);
            tB_sigma.Maximum = 500;
            tB_sharp.Minimum = 1;
        }

        private void trackBar_init(TrackBar trackBar)
        {
            trackBar.Minimum = 1;
            trackBar.Maximum = 100;
            trackBar.Value = 1;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Выберите изображение";
                openFileDialog.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Все файлы|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    image = Image.FromFile(filePath);   //Хранит в себе загруженную фотографию в первоначальном виде
                    img = image;                        //Хранит в себе копию выбранного фото для дальнейших преобразований
                    panel_img.Invalidate();             //Перерисовка панели, где будет отображаться само фото
                }
            }
        }

        private void panel_img_Paint(object sender, PaintEventArgs e)
        {
            if (image != null)
            {
                groupB.Width = image.Width;
                groupB.Height = image.Height;
                e.Graphics.DrawImage(new Bitmap(img), 0, 0);
            }
        }

        private void groupB_SizeChanged(object sender, EventArgs e)
        {
            groupB_params.Location = new Point(groupB.Location.X + groupB.Width, 31);
        }

        private void tB_dots_Scroll(object sender, EventArgs e)
        {
            dots_lb.Text = (((double)tB_dots.Value / 100)).ToString();
        }

        private void tB_lines_Scroll(object sender, EventArgs e)
        {
            lines_lb.Text = (tB_lines.Value).ToString();
        }

        private void tB_circ_Scroll(object sender, EventArgs e)
        {
            circ_lb.Text = (tB_circ.Value).ToString();
        }


        private void tB_filter_size_Scroll(object sender, EventArgs e)
        {
            if (tB_filter_size.Value % 2 == 0)
                tB_filter_size.Value = tB_filter_size.Value + 1;
            filter_size_lb.Text = (tB_filter_size.Value).ToString();
        }

        private void tB_sigma_Scroll(object sender, EventArgs e)
        {
            sigma_lb.Text = (((double)tB_sigma.Value / 100)).ToString();
        }

        private void tB_sharp_Scroll(object sender, EventArgs e)
        {
            sharp_lb.Text = (tB_sharp.Value).ToString();
        }

        private void sharp_bttn_Click(object sender, EventArgs e)
        {
            if (image == null) return;
            int k= tB_sharp.Value;
            int filter = tB_filter_size.Value;
            ApplySharpenFilter(k, filter);
        }

        private void dots_bttn_Click(object sender, EventArgs e)
        {
            if (image == null) return;
            ApplyDots();
        }

        private void ApplyDots()
        {
            int width = image.Width;
            int height = image.Height;

            double val = (double)tB_dots.Value / 100;

            Random rand = new Random();

            int count_dots = (int)(width * height * val);
            Bitmap bitmap = new Bitmap(img);
            for (int i = 0; i < count_dots; i++)
            {
                int x = rand.Next(width);
                int y = rand.Next(height);

                Color clr = rand.NextDouble() > 0.5 ? Color.Black : Color.White;

                bitmap.SetPixel(x, y, clr);
            }
            img = bitmap;
            panel_img.Invalidate();
        }

        private void lines_bttn_Click(object sender, EventArgs e)
        {
            if (image == null) return;
            ApplyLines();
        }

        private void ApplyLines()
        {
            Bitmap bitmap = new Bitmap(img);
            Graphics g = Graphics.FromImage(bitmap);

            int val = tB_lines.Value;

            int width = image.Width;
            int height = image.Height;

            Random rand = new Random();

            for (int i = 0; i < val; i++)
            {
                int x1 = rand.Next(width);
                int x2 = rand.Next(width);
                int y1 = rand.Next(height);
                int y2 = rand.Next(height);

                Color clr = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));

                g.DrawLine(new Pen(clr, 1), new Point(x1, y1), new Point(x2, y2));
            }
            img = bitmap;
            panel_img.Invalidate();
        }

        private void circ_bttn_Click(object sender, EventArgs e)
        {
            if (image == null) return;
            ApplyCircles();
        }

        private void ApplyCircles()
        {
            int val = tB_circ.Value;

            Bitmap bitmap = new Bitmap(img);
            Graphics g = Graphics.FromImage(bitmap);

            int width = image.Width;
            int height = image.Height;

            Random rand = new Random();

            for (int i = 0; i < val; i++)
            {
                int x = rand.Next(width);
                int y = rand.Next(height);
                int radius = rand.Next(5, 30);

                Color clr = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));

                g.DrawEllipse(new Pen(clr, 1), x, y, radius, radius);
            }
            img = bitmap;
            panel_img.Invalidate();
        }

        private void восстановитьФотоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image == null) return;

            img = image;
            panel_img.Invalidate();
        }

        private void ApplyUniformFilter(int filterSize)
        {
            Bitmap bitmap = new Bitmap(img);
            int filterArea = filterSize * filterSize;

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    int r = 0, g = 0, b = 0;

                    for (int i = -filterSize / 2; i <= filterSize / 2; i++)
                    {
                        for (int j = -filterSize / 2; j <= filterSize / 2; j++)
                        {
                            int newX = Math.Min(Math.Max(x + i, 0), bitmap.Width - 1);
                            int newY = Math.Min(Math.Max(y + j, 0), bitmap.Height - 1);
                            Color color = bitmap.GetPixel(newX, newY);
                            r += color.R;
                            g += color.G;
                            b += color.B;
                        }
                    }

                    r /= filterArea;
                    g /= filterArea;
                    b /= filterArea;

                    bitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            img = bitmap;
            panel_img.Invalidate();
        }

        private void ApplyGaussianFilter(int filterSize, double sigma)
        {
            Bitmap bitmap = new Bitmap(img);
            double[,] gaussianKernel = CreateGaussianKernel(filterSize, sigma);

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    double r = 0, g = 0, b = 0;

                    for (int i = -filterSize / 2; i <= filterSize / 2; i++)
                    {
                        for (int j = -filterSize / 2; j <= filterSize / 2; j++)
                        {
                            int newX = Math.Min(Math.Max(x + i, 0), bitmap.Width - 1);
                            int newY = Math.Min(Math.Max(y + j, 0), bitmap.Height - 1);
                            Color color = bitmap.GetPixel(newX, newY);

                            r += color.R * gaussianKernel[i + filterSize / 2, j + filterSize / 2];
                            g += color.G * gaussianKernel[i + filterSize / 2, j + filterSize / 2];
                            b += color.B * gaussianKernel[i + filterSize / 2, j + filterSize / 2];
                        }
                    }

                    bitmap.SetPixel(x, y, Color.FromArgb((int)r, (int)g, (int)b));
                }
            }

            img = bitmap;
            panel_img.Invalidate();
        }

        private double[,] CreateGaussianKernel(int size, double sigma)
        {
            double[,] kernel = new double[size, size];
            int halfSize = size / 2;
            double total = 0;

            for (int x = -halfSize; x <= halfSize; x++)
            {
                for (int y = -halfSize; y <= halfSize; y++)
                {
                    double g = Math.Exp(-(x * x + y * y) / (2 * sigma * sigma)) / (2 * Math.PI * sigma * sigma);
                    kernel[x + halfSize, y + halfSize] = g;
                    total += g;
                }
            }

            // Нормализация
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    kernel[i, j] /= total;
                }
            }

            return kernel;
        }

        private void ApplyGlassEffect()
        {
            Bitmap bitmap = new Bitmap(img);

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    //Случайным образом сдвигаем пиксели в пределах 5 пикселей
                    int offsetX = new Random().Next(-5, 6);
                    int offsetY = new Random().Next(-5, 6);

                    //Убедимся, что координаты находятся в пределах изображения
                    int newX = Math.Clamp(x + offsetX, 0, bitmap.Width - 1);
                    int newY = Math.Clamp(y + offsetY, 0, bitmap.Height - 1);

                    //Получаем цвет из смещенной позиции
                    Color color = bitmap.GetPixel(newX, newY);
                    bitmap.SetPixel(x, y, color);
                }
            }

            img = bitmap;

            panel_img.Invalidate();
        }

        private void ApplySharpenFilter(int k, int filterSize)
        {
            Bitmap bitmap = new Bitmap(img);
            int width = bitmap.Width;
            int height = bitmap.Height;
            int f = filterSize * filterSize - 1;

            // Ядро для повышения резкости
            float[,] kernel = new float[filterSize, filterSize];
            float tK = -(float)k / f;

            for (int i = 0; i < filterSize; i++)
            {
                for (int j = 0; j < filterSize; j++)
                {
                    kernel[i, j] = tK;
                }
            }
            kernel[filterSize / 2,filterSize / 2] = k + 1;

            Bitmap newBitmap = new Bitmap(width, height);

            int half_f = filterSize / 2;

            for (int x = half_f; x < width - half_f; x++)
            {
                for (int y = half_f; y < height - half_f; y++)
                {
                    float r = 0, g = 0, b = 0;

                    // Применение ядра к пикселю
                    for (int kernelX = -half_f; kernelX <= half_f; kernelX++)
                    {
                        for (int kernelY = -half_f; kernelY <= half_f; kernelY++)
                        {
                            Color neighborColor = bitmap.GetPixel(x + kernelX, y + kernelY);
                            r += neighborColor.R * kernel[kernelX + half_f, kernelY + half_f];
                            g += neighborColor.G * kernel[kernelX + half_f, kernelY + half_f];
                            b += neighborColor.B * kernel[kernelX + half_f, kernelY + half_f];
                        }
                    }

                    // Ограничение значений RGB в диапазоне [0, 255]
                    r = Math.Min(Math.Max(0, r), 255);
                    g = Math.Min(Math.Max(0, g), 255);
                    b = Math.Min(Math.Max(0, b), 255);

                    newBitmap.SetPixel(x, y, Color.FromArgb((int)r, (int)g, (int)b));
                }
            }

            img = newBitmap;
            panel_img.Invalidate();
        }

        private void unif_bttn_Click(object sender, EventArgs e)
        {
            if (image == null) return;
            int filter_size = tB_filter_size.Value;
            ApplyUniformFilter(filter_size);
        }

        private void gaussian_filter_bttn_Click(object sender, EventArgs e)
        {
            if (image == null) return;
            int filter_size = tB_filter_size.Value;
            double sigma = (double)tB_sigma.Value / 100;
            ApplyGaussianFilter(filter_size, sigma);
        }

        private void glass_bttn_Click(object sender, EventArgs e)
        {
            if (image == null) return;
            ApplyGlassEffect();
        }

        
    }
}
