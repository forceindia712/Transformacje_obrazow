using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FS
{
    public partial class Form1 : Form
    {
        private int szer = 0, wys = 0;
        Color k1, k2, k3;
        Bitmap b1, b2, b3;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                wys = pictureBox1.Height;
                szer = pictureBox1.Width;
                b1 = (Bitmap)pictureBox1.Image;
                b3 = (Bitmap)b1.Clone();
                pictureBox3.Image = b3;
            }
        }

        //Odejmowanie
        private void button4_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = b1.GetPixel(x, y);
                    k2 = b2.GetPixel(x, y);

                    int red = (int)(k1.R);
                    int green = (int)(k1.G);
                    int blue = (int)(k1.B);
                    int red2 = (int)(k2.R);
                    int green2 = (int)(k2.G);
                    int blue2 = (int)(k2.B);

                    int red_pnym = red + red2 - 255;
                    int green_pnym = green + green2 - 255;
                    int blue_pnym = blue + blue2 - 255;

                    if (red_pnym > 255)
                    {
                        red_pnym = 255;
                    }
                    if (red_pnym < 0)
                    {
                        red_pnym = 0;
                    }
                    if (green_pnym > 255)
                    {
                        green_pnym = 255;
                    }
                    if (green_pnym < 0)
                    {
                        green_pnym = 0;
                    }
                    if (blue_pnym > 255)
                    {
                        blue_pnym = 255;
                    }
                    if (blue_pnym < 0)
                    {
                        blue_pnym = 0;
                    }

                    k3 = Color.FromArgb(red_pnym, green_pnym, blue_pnym);
                    b3.SetPixel(x, y, k3);
                }
            }
            pictureBox3.Invalidate();
        }

        //Mnozenie
        private void button5_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = b1.GetPixel(x, y);
                    k2 = b2.GetPixel(x, y);

                    int red = (int)(k1.R);
                    int green = (int)(k1.G);
                    int blue = (int)(k1.B);
                    int red2 = (int)(k2.R);
                    int green2 = (int)(k2.G);
                    int blue2 = (int)(k2.B);

                    int red_pnym = (int)(red * red2)/255;
                    int green_pnym = (int)(green * green2)/255;
                    int blue_pnym = (int)(blue * blue2)/255;

                    if (red_pnym > 255)
                    {
                        red_pnym = 255;
                    }
                    if (red_pnym < 0)
                    {
                        red_pnym = 0;
                    }
                    if (green_pnym > 255)
                    {
                        green_pnym = 255;
                    }
                    if (green_pnym < 0)
                    {
                        green_pnym = 0;
                    }
                    if (blue_pnym > 255)
                    {
                        blue_pnym = 255;
                    }
                    if (blue_pnym < 0)
                    {
                        blue_pnym = 0;
                    }

                    k3 = Color.FromArgb(red_pnym, green_pnym, blue_pnym);
                    b3.SetPixel(x, y, k3);
                }
            }
            pictureBox3.Invalidate();
        }

        //Mnozenie odwrotnosci
        private void button6_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = b1.GetPixel(x, y);
                    k2 = b2.GetPixel(x, y);

                    int red = (int)(k1.R);
                    int green = (int)(k1.G);
                    int blue = (int)(k1.B);
                    int red2 = (int)(k2.R);
                    int green2 = (int)(k2.G);
                    int blue2 = (int)(k2.B);

                    int red_pnym = (int)(255 - (255 - red) * (255 - red2));
                    int green_pnym = (int)(255 - (255 - green) * (255 - green2));
                    int blue_pnym = (int)(255 - (255 - blue) * (255 - blue2));

                    if (red_pnym > 255)
                    {
                        red_pnym = 255;
                    }
                    if (red_pnym < 0)
                    {
                        red_pnym = 0;
                    }
                    if (green_pnym > 255)
                    {
                        green_pnym = 255;
                    }
                    if (green_pnym < 0)
                    {
                        green_pnym = 0;
                    }
                    if (blue_pnym > 255)
                    {
                        blue_pnym = 255;
                    }
                    if (blue_pnym < 0)
                    {
                        blue_pnym = 0;
                    }

                    k3 = Color.FromArgb(red_pnym, green_pnym, blue_pnym);
                    b3.SetPixel(x, y, k3);
                }
            }
            pictureBox3.Invalidate();
        }

        //Negacja
        private void button7_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = b1.GetPixel(x, y);
                    k2 = b2.GetPixel(x, y);

                    int red = (int)(k1.R);
                    int green = (int)(k1.G);
                    int blue = (int)(k1.B);
                    int red2 = (int)(k2.R);
                    int green2 = (int)(k2.G);
                    int blue2 = (int)(k2.B);

                    int red_pnym = (int)(255 - Math.Abs((255 - red - red2)));
                    int green_pnym = (int)(255 - Math.Abs((255 - green - green2)));
                    int blue_pnym = (int)(255 - Math.Abs((255 - blue - blue2)));


                    if (red_pnym > 255)
                    {
                        red_pnym = 255;
                    }
                    if (red_pnym < 0)
                    {
                        red_pnym = 0;
                    }
                    if (green_pnym > 255)
                    {
                        green_pnym = 255;
                    }
                    if (green_pnym < 0)
                    {
                        green_pnym = 0;
                    }
                    if (blue_pnym > 255)
                    {
                        blue_pnym = 255;
                    }
                    if (blue_pnym < 0)
                    {
                        blue_pnym = 0;
                    }

                    k3 = Color.FromArgb(red_pnym, green_pnym, blue_pnym);
                    b3.SetPixel(x, y, k3);
                }
            }
            pictureBox3.Invalidate();
        }

        //Ciemniejsze
        private void button8_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = b1.GetPixel(x, y);
                    k2 = b2.GetPixel(x, y);

                    int red = (int)(k1.R);
                    int green = (int)(k1.G);
                    int blue = (int)(k1.B);
                    int red2 = (int)(k2.R);
                    int green2 = (int)(k2.G);
                    int blue2 = (int)(k2.B);

                    int red_pnym, blue_pnym, green_pnym;

                    if (red < red2)
                        { red_pnym = red; }
                    else { red_pnym = red2; }

                    if (green < green2)
                    { green_pnym = green; }
                    else { green_pnym = green; }

                    if (blue < blue2)
                    { blue_pnym = blue; }
                    else { blue_pnym = blue; }


                    if (red_pnym > 255)
                    {
                        red_pnym = 255;
                    }
                    if (red_pnym < 0)
                    {
                        red_pnym = 0;
                    }
                    if (green_pnym > 255)
                    {
                        green_pnym = 255;
                    }
                    if (green_pnym < 0)
                    {
                        green_pnym = 0;
                    }
                    if (blue_pnym > 255)
                    {
                        blue_pnym = 255;
                    }
                    if (blue_pnym < 0)
                    {
                        blue_pnym = 0;
                    }

                    k3 = Color.FromArgb(red_pnym, green_pnym, blue_pnym);
                    b3.SetPixel(x, y, k3);
                }
            }
            pictureBox3.Invalidate();
        }

        //Jaśniejsze
        private void button10_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = b1.GetPixel(x, y);
                    k2 = b2.GetPixel(x, y);

                    int red = (int)(k1.R);
                    int green = (int)(k1.G);
                    int blue = (int)(k1.B);
                    int red2 = (int)(k2.R);
                    int green2 = (int)(k2.G);
                    int blue2 = (int)(k2.B);

                    int red_pnym, blue_pnym, green_pnym;

                    if (red > red2)
                    { red_pnym = red; }
                    else { red_pnym = red2; }

                    if (green > green2)
                    { green_pnym = green; }
                    else { green_pnym = green; }

                    if (blue > blue2)
                    { blue_pnym = blue; }
                    else { blue_pnym = blue; }

                    if (red_pnym > 255)
                    {
                        red_pnym = 255;
                    }
                    if (red_pnym < 0)
                    {
                        red_pnym = 0;
                    }
                    if (green_pnym > 255)
                    {
                        green_pnym = 255;
                    }
                    if (green_pnym < 0)
                    {
                        green_pnym = 0;
                    }
                    if (blue_pnym > 255)
                    {
                        blue_pnym = 255;
                    }
                    if (blue_pnym < 0)
                    {
                        blue_pnym = 0;
                    }

                    k3 = Color.FromArgb(red_pnym, green_pnym, blue_pnym);
                    b3.SetPixel(x, y, k3);
                }
            }
            pictureBox3.Invalidate();
        }

        //Wyłączenie
        private void button11_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = b1.GetPixel(x, y);
                    k2 = b2.GetPixel(x, y);

                    double red = (double)(k1.R)/255;
                    double green = (double)(k1.G)/255;
                    double blue = (double)(k1.B)/255;
                    double red2 = (double)(k2.R)/255;
                    double green2 = (double)(k2.G)/255;
                    double blue2 = (double)(k2.B)/255;

                    int red_pnym = (int)((red + red2 - 2 * red * red2)*255);
                    int green_pnym = (int)((green + green2 - 2 * green * green2)*255);
                    int blue_pnym = (int)((blue + blue2 - 2 * blue * blue)*255);

                    if (red_pnym > 255)
                    {
                        red_pnym = 255;
                    }
                    if (red_pnym < 0)
                    {
                        red_pnym = 0;
                    }
                    if (green_pnym > 255)
                    {
                        green_pnym = 255;
                    }
                    if (green_pnym < 0)
                    {
                        green_pnym = 0;
                    }
                    if (blue_pnym > 255)
                    {
                        blue_pnym = 255;
                    }
                    if (blue_pnym < 0)
                    {
                        blue_pnym = 0;
                    }

                    k3 = Color.FromArgb(red_pnym, green_pnym, blue_pnym);
                    b3.SetPixel(x, y, k3);
                }
            }
            pictureBox3.Invalidate();
        }

        //Ostre światło
        private void button13_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = b1.GetPixel(x, y);
                    k2 = b2.GetPixel(x, y);

                    double red = (double)(k1.R) / 255;
                    double green = (double)(k1.G) / 255;
                    double blue = (double)(k1.B) / 255;
                    double red2 = (double)(k2.R) / 255;
                    double green2 = (double)(k2.G) / 255;
                    double blue2 = (double)(k2.B) / 255;

                    int blue_pnym;
                    int red_pnym;
                    int green_pnym;

                    if (red2 < 0.5)
                    {
                        red_pnym = (int)(2 * red * red2 * 255);
                    }
                    else
                    {
                        red_pnym = (int)((1 - 2 * (1 - red) * (1 - red2)) * 255);
                    }

                    if (green2 < 0.5)
                    {
                        green_pnym = (int)(2 * green * green2 * 255);
                    }
                    else
                    {
                        green_pnym = (int)((1 - 2 * (1 - green) * (1 - green2)) * 255);
                    }

                    if (blue2 < 0.5)
                    {
                        blue_pnym = (int)(2 * blue * blue2 * 255);
                    }
                    else
                    {
                        blue_pnym = (int)((1 - 2 * (1 - blue) * (1 - blue2)) * 255);
                    }

                    if (red_pnym > 255)
                    {
                        red_pnym = 255;
                    }
                    if (red_pnym < 0)
                    {
                        red_pnym = 0;
                    }
                    if (green_pnym > 255)
                    {
                        green_pnym = 255;
                    }
                    if (green_pnym < 0)
                    {
                        green_pnym = 0;
                    }
                    if (blue_pnym > 255)
                    {
                        blue_pnym = 255;
                    }
                    if (blue_pnym < 0)
                    {
                        blue_pnym = 0;
                    }

                    k3 = Color.FromArgb(red_pnym, green_pnym, blue_pnym);
                    b3.SetPixel(x, y, k3);
                }
            }
            pictureBox3.Invalidate();
        }

        //Łagodne światło
        private void button14_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = b1.GetPixel(x, y);
                    k2 = b2.GetPixel(x, y);

                    double red = (double)(k1.R) / 255;
                    double green = (double)(k1.G) / 255;
                    double blue = (double)(k1.B) / 255;
                    double red2 = (double)(k2.R) / 255;
                    double green2 = (double)(k2.G) / 255;
                    double blue2 = (double)(k2.B) / 255;

                    int blue_pnym;
                    int red_pnym;
                    int green_pnym;

                    if (red2 < 0.5)
                    {
                        red_pnym = (int)((2 * red * red2 + Math.Pow(red, 2) * (1 - 2 * red2)) * 255);
                    }
                    else
                    {
                        red_pnym = (int)((Math.Sqrt(red) * (2 * red2 - 1) + (2 * red) * (1 - red2)) * 255);
                    }

                    if (green2 < 0.5)
                    {
                        green_pnym = (int)((2 * green * green2 + Math.Pow(green, 2) * (1 - 2 * green2)) * 255);
                    }
                    else
                    {
                        green_pnym = (int)((Math.Sqrt(green) * (2 * green2 - 1) + (2 * green) * (1 - green2)) * 255);
                    }

                    if (blue2 < 0.5)
                    {
                        blue_pnym = (int)((2 * blue * blue2 + Math.Pow(blue, 2) * (1 - 2 * blue2)) * 255);
                    }
                    else
                    {
                        blue_pnym = (int)((Math.Sqrt(blue) * (2 * blue2 - 1) + (2 * blue) * (1 - blue2)) * 255);
                    }

                    if (red_pnym > 255)
                    {
                        red_pnym = 255;
                    }
                    if (red_pnym < 0)
                    {
                        red_pnym = 0;
                    }
                    if (green_pnym > 255)
                    {
                        green_pnym = 255;
                    }
                    if (green_pnym < 0)
                    {
                        green_pnym = 0;
                    }
                    if (blue_pnym > 255)
                    {
                        blue_pnym = 255;
                    }
                    if (blue_pnym < 0)
                    {
                        blue_pnym = 0;
                    }

                    k3 = Color.FromArgb(red_pnym, green_pnym, blue_pnym);
                    b3.SetPixel(x, y, k3);
                }
            }
            pictureBox3.Invalidate();
        }

        //Rozcieńczenie
        private void button15_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = b1.GetPixel(x, y);
                    k2 = b2.GetPixel(x, y);

                    double red = (double)(k1.R) / 255;
                    double green = (double)(k1.G) / 255;
                    double blue = (double)(k1.B) / 255;
                    double red2 = (double)(k2.R) / 255;
                    double green2 = (double)(k2.G) / 255;
                    double blue2 = (double)(k2.B) / 255;

                    int red_pnym = (int)(red / (1 - red2)) * 255;
                    int green_pnym = (int)(green / (1 - green2)) * 255;
                    int blue_pnym = (int)(blue / (1 - blue2)) * 255;

                    if (red_pnym > 255)
                    {
                        red_pnym = 255;
                    }
                    if (red_pnym < 0)
                    {
                        red_pnym = 0;
                    }
                    if (green_pnym > 255)
                    {
                        green_pnym = 255;
                    }
                    if (green_pnym < 0)
                    {
                        green_pnym = 0;
                    }
                    if (blue_pnym > 255)
                    {
                        blue_pnym = 255;
                    }
                    if (blue_pnym < 0)
                    {
                        blue_pnym = 0;
                    }

                    k3 = Color.FromArgb(red_pnym, green_pnym, blue_pnym);
                    b3.SetPixel(x, y, k3);
                }
            }
            pictureBox3.Invalidate();
        }

        //Wypalanie
        private void button16_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = b1.GetPixel(x, y);
                    k2 = b2.GetPixel(x, y);

                    double red = (double)(k1.R) / 255;
                    double green = (double)(k1.G) / 255;
                    double blue = (double)(k1.B) / 255;
                    double red2 = (double)(k2.R) / 255;
                    double green2 = (double)(k2.G) / 255;
                    double blue2 = (double)(k2.B) / 255;

                    int red_pnym = (int)(1 - (1 - red) / red2) * 255;
                    int green_pnym = (int)(1 - (1 - green) / green2) * 255;
                    int blue_pnym = (int)(1 - (1 - blue) / blue2) * 255;

                    if (red_pnym > 255)
                    {
                        red_pnym = 255;
                    }
                    if (red_pnym < 0)
                    {
                        red_pnym = 0;
                    }
                    if (green_pnym > 255)
                    {
                        green_pnym = 255;
                    }
                    if (green_pnym < 0)
                    {
                        green_pnym = 0;
                    }
                    if (blue_pnym > 255)
                    {
                        blue_pnym = 255;
                    }
                    if (blue_pnym < 0)
                    {
                        blue_pnym = 0;
                    }

                    k3 = Color.FromArgb(red_pnym, green_pnym, blue_pnym);
                    b3.SetPixel(x, y, k3);
                }
            }
            pictureBox3.Invalidate();
        }

        //Reflect mode
        private void button17_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = b1.GetPixel(x, y);
                    k2 = b2.GetPixel(x, y);

                    double red = (double)(k1.R) / 255;
                    double green = (double)(k1.G) / 255;
                    double blue = (double)(k1.B) / 255;
                    double red2 = (double)(k2.R) / 255;
                    double green2 = (double)(k2.G) / 255;
                    double blue2 = (double)(k2.B) / 255;

                    int red_pnym = (int)((Math.Pow(red, 2) / (1 - red2)) * 255);
                    int green_pnym = (int)((Math.Pow(green, 2) / (1 - green2)) * 255);
                    int blue_pnym = (int)((Math.Pow(blue, 2) / (1 - blue2)) * 255);

                    if (red_pnym > 255)
                    {
                        red_pnym = 255;
                    }
                    if (red_pnym < 0)
                    {
                        red_pnym = 0;
                    }
                    if (green_pnym > 255)
                    {
                        green_pnym = 255;
                    }
                    if (green_pnym < 0)
                    {
                        green_pnym = 0;
                    }
                    if (blue_pnym > 255)
                    {
                        blue_pnym = 255;
                    }
                    if (blue_pnym < 0)
                    {
                        blue_pnym = 0;
                    }

                    k3 = Color.FromArgb(red_pnym, green_pnym, blue_pnym);
                    b3.SetPixel(x, y, k3);
                }
            }
            pictureBox3.Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = b1.GetPixel(x, y);
                    k2 = b2.GetPixel(x, y);

                    double red = (double)(k1.R) / 255;
                    double green = (double)(k1.G) / 255;
                    double blue = (double)(k1.B) / 255;
                    double red2 = (double)(k2.R) / 255;
                    double green2 = (double)(k2.G) / 255;
                    double blue2 = (double)(k2.B) / 255;

                    int red_pnym = (int)((((1 - (double)(trackBar1.Value) / 10) * red2) + (((double)(trackBar1.Value) / 10) * red)) * 255);
                    int green_pnym = (int)((((1 - (double)(trackBar1.Value) / 10) * green2) + (((double)(trackBar1.Value) / 10) * green)) * 255);
                    int blue_pnym = (int)((((1 - (double)(trackBar1.Value) / 10) * blue2) + (((double)(trackBar1.Value) / 10) * blue)) * 255);

                    if (red_pnym > 255)
                    {
                        red_pnym = 255;
                    }
                    if (red_pnym < 0)
                    {
                        red_pnym = 0;
                    }
                    if (green_pnym > 255)
                    {
                        green_pnym = 255;
                    }
                    if (green_pnym < 0)
                    {
                        green_pnym = 0;
                    }
                    if (blue_pnym > 255)
                    {
                        blue_pnym = 255;
                    }
                    if (blue_pnym < 0)
                    {
                        blue_pnym = 0;
                    }

                    k3 = Color.FromArgb(red_pnym, green_pnym, blue_pnym);
                    b3.SetPixel(x, y, k3);
                }
            }
            pictureBox3.Invalidate();
        }

        //Nakładka
        private void button12_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = b1.GetPixel(x, y);
                    k2 = b2.GetPixel(x, y);

                    double red = (double)(k1.R) / 255;
                    double green = (double)(k1.G) / 255;
                    double blue = (double)(k1.B) / 255;
                    double red2 = (double)(k2.R) / 255;
                    double green2 = (double)(k2.G) / 255;
                    double blue2 = (double)(k2.B) / 255;

                    int blue_pnym;
                    int red_pnym;
                    int green_pnym;

                    if (red < 0.5)
                    {
                        red_pnym = (int)(2 * red * red2 * 255);
                    }
                    else
                    {
                        red_pnym = (int)((1 - 2 * (1 - red) * (1 - red2)) * 255);
                    }

                    if (green < 0.5)
                    {
                        green_pnym = (int)(2 * green * green2 * 255);
                    }
                    else
                    {
                        green_pnym = (int)((1 - 2 * (1 - green) * (1 - green2)) * 255);
                    }

                    if (blue < 0.5)
                    {
                        blue_pnym = (int)(2 * blue * blue2 * 255);
                    }
                    else
                    {
                        blue_pnym = (int)((1 - 2 * (1 - blue) * (1 - blue2)) * 255);
                    }

                    if (red_pnym > 255)
                    {
                        red_pnym = 255;
                    }
                    if (red_pnym < 0)
                    {
                        red_pnym = 0;
                    }
                    if (green_pnym > 255)
                    {
                        green_pnym = 255;
                    }
                    if (green_pnym < 0)
                    {
                        green_pnym = 0;
                    }
                    if (blue_pnym > 255)
                    {
                        blue_pnym = 255;
                    }
                    if (blue_pnym < 0)
                    {
                        blue_pnym = 0;
                    }

                    k3 = Color.FromArgb(red_pnym, green_pnym, blue_pnym);
                    b3.SetPixel(x, y, k3);
                }
            }
            pictureBox3.Invalidate();
        }

        //suma
        private void button3_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = b1.GetPixel(x, y);
                    k2 = b2.GetPixel(x, y);

                    int red = (int)(k1.R);
                    int green = (int)(k1.G);
                    int blue = (int)(k1.B);
                    int red2 = (int)(k2.R);
                    int green2 = (int)(k2.G);
                    int blue2 = (int)(k2.B);

                    int red_pnym = red + red2;
                    int green_pnym = green + green2;
                    int blue_pnym = blue + blue2;

                    if (red_pnym > 255)
                    {
                        red_pnym = 255;
                    }
                    if (red_pnym < 0)
                    {
                        red_pnym = 0;
                    }
                    if (green_pnym > 255)
                    {
                        green_pnym = 255;
                    }
                    if (green_pnym < 0)
                    {
                        green_pnym = 0;
                    }
                    if (blue_pnym > 255)
                    {
                        blue_pnym = 255;
                    }
                    if (blue_pnym < 0)
                    {
                        blue_pnym = 0;
                    }

                    k3 = Color.FromArgb(red_pnym, green_pnym, blue_pnym);
                    b3.SetPixel(x, y, k3);
                }
            }
            pictureBox3.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Load(openFileDialog1.FileName);
                b2 = (Bitmap)pictureBox2.Image;
            }
        }

        //Różnica
        private void button9_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = b1.GetPixel(x, y);
                    k2 = b2.GetPixel(x, y);

                    int red = (int)(k1.R);
                    int green = (int)(k1.G);
                    int blue = (int)(k1.B);
                    int red2 = (int)(k2.R);
                    int green2 = (int)(k2.G);
                    int blue2 = (int)(k2.B);

                    int red_pnym = Math.Abs(red - red2);
                    int green_pnym = Math.Abs(green - green2);
                    int blue_pnym = Math.Abs(blue - blue2);

                    if (red_pnym > 255)
                    {
                        red_pnym = 255;
                    }
                    if (red_pnym < 0)
                    {
                        red_pnym = 0;
                    }
                    if (green_pnym > 255)
                    {
                        green_pnym = 255;
                    }
                    if (green_pnym < 0)
                    {
                        green_pnym = 0;
                    }
                    if (blue_pnym > 255)
                    {
                        blue_pnym = 255;
                    }
                    if (blue_pnym < 0)
                    {
                        blue_pnym = 0;
                    }

                    k3 = Color.FromArgb(red_pnym, green_pnym, blue_pnym);
                    b3.SetPixel(x, y, k3);
                }
            }
            pictureBox3.Invalidate();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
