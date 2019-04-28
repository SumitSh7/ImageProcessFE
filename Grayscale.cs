  private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(pictureBox1.Image);
            int width = bmp1.Width;
            int height = bmp1.Height;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //extract pixel component ARGB
                    Color p = bmp1.GetPixel(x, y);
                    int a = p.A;
                    int b = p.B;
                    int r = p.R;
                    int g = p.G;
                    int avg = (r + g + b) / 3;
                    bmp2.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                    pictureBox2.Image = bmp2;

                }
            }
        }