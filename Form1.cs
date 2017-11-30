using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GrayscaleConverting
{
	public partial class Form1 : Form
	{
        // Исходное изображение
		private Bitmap originalImage;
        // Обработанное изображение
		private Bitmap processedImage;
        // Обработанное изображение (с разными значениями весов)
		private Bitmap processedImageWeights;
        // Разность двух предыдущих изображений
		private Bitmap differenceImage;

        // Возвращает оттенок серого от переданного цвета c.
		private Color colorToGrayScale(Color c)
		{
			int a = c.A;
			int r = c.R;
			int g = c.G;
			int b = c.B;

			int avg = (r + g + b) / 3;

			return Color.FromArgb(a, avg, avg, avg);
		}

        // Возвращает оттенок серого от переданного цвета c (метод с разными весами).
		private Color colorToGrayScaleWithWeights(Color c)
		{
			int a = c.A;
			double r = 0.299 * c.R;
			double g = 0.587 * c.G;
			double b = 0.114 * c.B;

			//find average
			int avg = (int)(r + g + b);

			return Color.FromArgb(a, avg, avg, avg);
		}

        // Возвращает разницу двух цветов по модулю.
		private Color getColorDifference(Color c1, Color c2)
		{
			int a1 = c1.A;
			int r1 = c1.R;
			int g1 = c1.G;
			int b1 = c1.B;

			int a2 = c2.A;
			int r2 = c2.R;
			int g2 = c2.G;
			int b2 = c2.B;

			int diffA = a1;
			int diffR = Math.Abs(r1 - r2);
			int diffG = Math.Abs(g1 - g2);
			int diffB = Math.Abs(b1 - b2);

			return Color.FromArgb(diffA, diffR, diffG, diffB);
		}

        // Рисует гистограмму
        private void drawBarChart(PictureBox picBoxOut)//, Bitdouble[] arr, int min, int max)
        {
            comboBox1.Enabled = false;

            PictureBox picBoxIn;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    picBoxIn = pictureBox2;
                    break;
                case 1:
                    picBoxIn = pictureBox3;
                    break;
                default:
                    picBoxIn = pictureBox4;
                    break;
            }
            // Инициализация входного и выходного битмапа
            Bitmap barChartIn = new Bitmap(picBoxIn.Image);
            Bitmap barChartOut = new Bitmap(picBoxOut.Width, picBoxOut.Height);
            Graphics g = Graphics.FromImage(barChartOut);

            // Сбор информации о распределении оттенков серого в изображении
            int columnWidth = barChartOut.Width / 256;
            double[] arr = new double[256];

            for (int i = 0; i < barChartIn.Width; ++i)
                for (int j = 0; j < barChartIn.Height; ++j)
                {
                    int value = barChartIn.GetPixel(i, j).R;
                    ++arr[value];
                }

            // Поиск максимального и минимального значения
            double minValue = int.MaxValue;
            double maxValue = int.MinValue;
            for (int i = 0; i < arr.Count(); ++i)
            {
                double value = arr[i];
                if (value > maxValue)
                    maxValue = value;
                if (value < minValue)
                    minValue = value;
            }

            // Масштабирование значений массива (чтобы колонки помещались в гистограмму)
            if (maxValue > barChartOut.Height)
            {
                double scale = (double)barChartOut.Height / maxValue;
                for (int i = 0; i < arr.Count(); ++i)
                    arr[i] *= scale;
            }

            // Отрисовка гистограммы
            for (int i = 0; i < arr.Count(); ++i)
            {
                Pen        pen   = new Pen(Color.FromArgb(255, i, i, i));
                SolidBrush brush = new SolidBrush(Color.FromArgb(255, i, i, i));
                Rectangle  rect  = new Rectangle(i * columnWidth, picBoxOut.Height - (int)arr[i], columnWidth, (int)arr[i]);
                g.DrawRectangle(pen, rect);
                g.FillRectangle(brush, rect);
                pen.Dispose();
            }

            picBoxOut.Image = barChartOut;
            comboBox1.Enabled = true;
            comboBox1.Focus();
        }

        // Инициализация выпадающего списка опций построения гистограммы
        private void initComboBox()
        {
            comboBox1.Items.AddRange(new object[] {
                "Оттенки серого",
                "Оттенки серого (разные веса)",
                "Дельта"
            });
            comboBox1.SelectedIndex = 0;
        }

        // Показывает необходимый пикчурбоксы, лэйблы и выпадающий список
        private void showControls()
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;

            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

            comboBox1.Visible = true;
        }

        // Конструктор формы
		public Form1()
		{
			InitializeComponent();
            initComboBox();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
		}

        // Обработчик нажатия на кнопку "Обработать"
		private void button1_Click(object sender, EventArgs e)
		{
			processedImage = new Bitmap(originalImage);
            processedImageWeights = new Bitmap(originalImage);

			// Получение размера изображения
			int width = processedImage.Width;
			int height = processedImage.Height;

			// Цвет пикселя
			Color p;

			// Получение изображения в оттенках серого (2 метода)
			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
				{
					// Получение цвета пикселя
					p = processedImage.GetPixel(x, y);				

					// Установка нового цвета
					processedImage.SetPixel(x, y, colorToGrayScale(p));

                    // Установка нового цвета (метод разных весов)
                    processedImageWeights.SetPixel(x, y, colorToGrayScaleWithWeights(p));
				}
			}
			pictureBox2.Image = processedImage;
            pictureBox3.Image = processedImageWeights;
            
            // Получение изображения разности двух методов преобразования в оттенки серого
			differenceImage = new Bitmap(originalImage);
			Color p1, p2;
			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
				{
                    // Получение цвета пикселя
					p1 = processedImage.GetPixel(x, y);
					p2 = processedImageWeights.GetPixel(x, y);

                    // Установка нового цвета
					differenceImage.SetPixel(x, y, getColorDifference(p1, p2));
				}
			}
			pictureBox4.Image = differenceImage;

            // Отрисовка гистограммы
            drawBarChart(pictureBox5);

            // Показывает обработанные изображения, разницу изображений и гистограмму
            showControls();
		}

        // Обработчик нажатия на кнопку "Открыть"
		private void button2_Click(object sender, EventArgs e)
		{
            // Создание файлового диалога
			Stream myStream = null;
			openFileDialog1 = new OpenFileDialog();

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					if ((myStream = openFileDialog1.OpenFile()) != null)
					{
                        using (myStream)
                        {
                            // Инициализация изображения и изменение егоразмера
                            originalImage = new Bitmap(myStream);
                            originalImage = new Bitmap(originalImage, pictureBox1.Width, pictureBox1.Height);
						    pictureBox1.Image = originalImage;

                            button1.Enabled = true;
                            textBox1.Text = Path.GetFileName(openFileDialog1.FileName); //openFileDialog1.FileName;
                            textBox1.BackColor = Color.Green;
                            label2.Visible = true;
                        }
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}
			}
        }

        // Обработчик смены типа гистограммы в выпадающем списке
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawBarChart(pictureBox5);
        }
	}
}
