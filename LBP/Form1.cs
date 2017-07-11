using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBP
{
    public partial class LBP : Form
    {
        String selectedPicLBP;
        int[] loadedPicLBP = new int[256];
        int[,] dataLBP = new int[572, 256];

        public LBP()
        {
            InitializeComponent();
            for (int i = 1; i < 573; i++)
                listBox1.Items.Add(i + "-1.png");
        }

        public int LocalBinaryPattern(int x, int y, Bitmap bitmap)
        {
            int count = 0, mindata = 256, tmpdata = 0;
            int[] data = new int[8];
            string msg = "";
            if (bitmap.GetPixel(x, y).R > bitmap.GetPixel(x - 1, y - 1).R) data[0] = 0;
            else data[0] = 1;
            if (bitmap.GetPixel(x, y).R > bitmap.GetPixel(x, y - 1).R) data[1] = 0;
            else data[1] = 1;
            if (bitmap.GetPixel(x, y).R > bitmap.GetPixel(x + 1, y - 1).R) data[2] = 0;
            else data[2] = 1;
            if (bitmap.GetPixel(x, y).R > bitmap.GetPixel(x + 1, y).R) data[3] = 0;
            else data[3] = 1;
            if (bitmap.GetPixel(x, y).R > bitmap.GetPixel(x + 1, y + 1).R) data[4] = 0;
            else data[4] = 1;
            if (bitmap.GetPixel(x, y).R > bitmap.GetPixel(x, y + 1).R) data[5] = 0;
            else data[5] = 1;
            if (bitmap.GetPixel(x, y).R > bitmap.GetPixel(x - 1, y + 1).R) data[6] = 0;
            else data[6] = 1;
            if (bitmap.GetPixel(x, y).R > bitmap.GetPixel(x - 1, y).R) data[7] = 0;
            else data[7] = 1;

            for (int i = 0; i < 8; i++)
            {
                tmpdata = Convert(data);
                if (tmpdata < mindata)
                    mindata = tmpdata;
                data = Swap(data);
            }
            return mindata;
        }

        public int Convert(int[] data)
        {
            int retval = 0, count = 7;
            int[] tmp = new int[8];
            for (int i = 0; i < 8; i++)
            {
                tmp[i] = data[count];
                count--;
            }

            for (int i = 0; i < 8; i++)
            {
                if (tmp[i] == 1)
                    retval += (int)Math.Pow(2, i);
            }
            return retval;
        }

        public int[] Swap(int[] data)
        {
            int tmp = data[0];
            data[0] = data[1];
            data[1] = data[2];
            data[2] = data[3];
            data[3] = data[4];
            data[4] = data[5];
            data[5] = data[6];
            data[6] = data[7];
            data[7] = tmp;
            return data;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "jpg (*.jpg)|*.jpg|bitmap (*.bitmap)|*.bitmap|png (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Length > 0)
            {
                SelectedPic.SizeMode = PictureBoxSizeMode.StretchImage;
                SelectedPic.Image = Image.FromFile(openFileDialog1.FileName);
                selectedPicLBP = openFileDialog1.FileName;
            }
        }

        private void BtnExtract_Click(object sender, EventArgs e)
        {
            String path = "F:/Kuliah/Semester 6/Pengolahan Citra/DatasetLBP/";
            Bitmap bitmap = (Bitmap)SelectedPic.Image;
            String[] data = new String[256];
            Color pixelColor;
            int[] nilaiLBP = new int[256];
            for (int i = 0; i < 256; i++)
                nilaiLBP[i] = 0;

            SelectedPic.Image = new Bitmap(SelectedPic.Width, SelectedPic.Height);
            for (int y = 0; y < bitmap.Height; y++)
                for (int x = 0; x < bitmap.Width; x++)
                {
                    pixelColor = bitmap.GetPixel(x, y);
                    int red = pixelColor.R;
                    int green = pixelColor.G;
                    int blue = pixelColor.B;
                    int rata = (int)(red + green + blue) / 3;
                    bitmap.SetPixel(x, y, Color.FromArgb(rata, rata, rata));
                }
            
            SelectedPic.SizeMode = PictureBoxSizeMode.StretchImage;
            SelectedPic.Image = bitmap;
            for (int y = 1; y < bitmap.Height - 1; y++)
                for (int x = 1; x < bitmap.Width - 1; x++)
                {
                    int value = LocalBinaryPattern(x, y, bitmap);
                    nilaiLBP[value] += 1;
                }
            
            loadedPicLBP = nilaiLBP;
            LoadData();
        }

        public void LoadData()
        {
            string line, msg = "";
            int count;
            for (int i = 1; i < 573; i++)
            {
                count = 0;
                System.IO.StreamReader file = new System.IO
                    .StreamReader(@"F:/Kuliah/Semester 6/Pengolahan Citra/DatasetLBP/" + i + "-1.txt");
                while ((line = file.ReadLine()) != null)
                {
                    dataLBP[i - 1, count] = Int32.Parse(line);
                    count++;
                }
            }
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            int selisih;
            string msg = "";
            int[] index = new int[572];
            int[] value = new int[572];

            for (int i = 0; i < 572; i++)
            {
                selisih = 0;
                for (int j = 0; j < 256; j++)
                    selisih += Math.Abs(loadedPicLBP[j] - dataLBP[i, j]);
                index[i] = i;
                value[i] = selisih;
            }

            for (int i = 0; i < 572; i++)
                for (int j = 0; j < 571; j++)
                    if (value[j] > value[j + 1])
                    {
                        int tmp = value[j];
                        value[j] = value[j + 1];
                        value[j + 1] = tmp;

                        tmp = index[j];
                        index[j] = index[j + 1];
                        index[j + 1] = tmp;
                    }

            OutputPic1.SizeMode = PictureBoxSizeMode.StretchImage;
            OutputPic1.Image = Image.FromFile("F:/Kuliah/Semester 6/Pengolahan Citra/DatasetLBP/" + (index[1] + 1) + "-1.png");

            OutputPic2.SizeMode = PictureBoxSizeMode.StretchImage;
            OutputPic2.Image = Image.FromFile("F:/Kuliah/Semester 6/Pengolahan Citra/DatasetLBP/" + (index[2] + 1) + "-1.png");

            OutputPic3.SizeMode = PictureBoxSizeMode.StretchImage;
            OutputPic3.Image = Image.FromFile("F:/Kuliah/Semester 6/Pengolahan Citra/DatasetLBP/" + (index[3] + 1) + "-1.png");

            OutputPic4.SizeMode = PictureBoxSizeMode.StretchImage;
            OutputPic4.Image = Image.FromFile("F:/Kuliah/Semester 6/Pengolahan Citra/DatasetLBP/" + (index[4] + 1) + "-1.png");

            OutputPic5.SizeMode = PictureBoxSizeMode.StretchImage;
            OutputPic5.Image = Image.FromFile("F:/Kuliah/Semester 6/Pengolahan Citra/DatasetLBP/" + (index[5] + 1) + "-1.png");

            OutputPic6.SizeMode = PictureBoxSizeMode.StretchImage;
            OutputPic6.Image = Image.FromFile("F:/Kuliah/Semester 6/Pengolahan Citra/DatasetLBP/" + (index[6] + 1) + "-1.png");

            OutputPic7.SizeMode = PictureBoxSizeMode.StretchImage;
            OutputPic7.Image = Image.FromFile("F:/Kuliah/Semester 6/Pengolahan Citra/DatasetLBP/" + (index[7] + 1) + "-1.png");

            OutputPic8.SizeMode = PictureBoxSizeMode.StretchImage;
            OutputPic8.Image = Image.FromFile("F:/Kuliah/Semester 6/Pengolahan Citra/DatasetLBP/" + (index[8] + 1) + "-1.png");

            OutputPic9.SizeMode = PictureBoxSizeMode.StretchImage;
            OutputPic9.Image = Image.FromFile("F:/Kuliah/Semester 6/Pengolahan Citra/DatasetLBP/" + (index[9] + 1) + "-1.png");

            OutputPic10.SizeMode = PictureBoxSizeMode.StretchImage;
            OutputPic10.Image = Image.FromFile("F:/Kuliah/Semester 6/Pengolahan Citra/DatasetLBP/" + (index[10] + 1) + "-1.png");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPic.SizeMode = PictureBoxSizeMode.StretchImage;
            SelectedPic.Image = Image.FromFile("F:/Kuliah/Semester 6/Pengolahan Citra/DatasetLBP/" + (listBox1.SelectedIndex + 1) + "-1.png");
        }
        
    }
}
