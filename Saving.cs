private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                    int width = Convert.ToInt32(pictureBox2.Width); 
                    int height = Convert.ToInt32(pictureBox2.Height); 
                    Bitmap bmp = new Bitmap(width,height);        
                    pictureBox2.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                    bmp.Save(dialog.FileName);
            }
        }