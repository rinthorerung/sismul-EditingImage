using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public ImageProcessor imageProcessor = new ImageProcessor();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                imageProcessor.SetImage(openFileDialog1.FileName);
                pictureBox1.Image = imageProcessor.GetImage();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imageProcessor.ApplySepia(20);
            pictureBox1.Image = imageProcessor.GetImage();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            imageProcessor.ApplySharpen(11);
            pictureBox1.Image = imageProcessor.GetImage();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            imageProcessor.ApplyEmboss(4);
            pictureBox1.Image = imageProcessor.GetImage();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            imageProcessor.ApplyInvert();
            pictureBox1.Image = imageProcessor.GetImage();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            imageProcessor.ApplyGreyscale();
            pictureBox1.Image = imageProcessor.GetImage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = "c:\\";
            saveFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp/*.jpg)|*.bmp/*.jpg";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                pictureBox1.Image = imageProcessor.GetImage();
                pictureBox1.Image.Save(saveFileDialog.FileName);
               // m_Bitmap.Save(saveFileDialog.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            imageProcessor.ApplyMeanRemoval(9);
            pictureBox1.Image = imageProcessor.GetImage();
        }


 
    }
}
