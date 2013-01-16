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

    }
}
