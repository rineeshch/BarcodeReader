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
using System.Drawing.Imaging;

namespace BarcodeReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string barcode = textBox1.Text;
            Bitmap bitmap = new Bitmap(barcode.Length * 40, 150);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Font oFont = new System.Drawing.Font("IDAutomationHC39M Free Version", 20);
                PointF point = new PointF(2f, 2f);
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush White = new SolidBrush(Color.White);
                graphics.FillRectangle(White, 0, 0, bitmap.Width, bitmap.Height);
                graphics.DrawString("*" + barcode + "*", oFont, black, point);
            }
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                pictureBox1.Image = bitmap;
                pictureBox1.Height = bitmap.Height;
                pictureBox1.Width = bitmap.Width;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
