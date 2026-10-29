using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Paint
{
    public partial class mainForm : Form
    {
        
        bool paint = false;
        int index = 1;
        int x, y, sX, sY, cX, cY;
        Color colorP;
        Point pointX, pointY;
        Bitmap bitmapN;
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 2);
        Pen eraser = new Pen(Color.White, 2);
        ColorDialog colorDialog = new ColorDialog();


        static Point SetPoint(PictureBox pictureBox, Point point)
        {
            float pX = 1f * pictureBox.Image.Width / pictureBox.Width;
            float pY = 1f * pictureBox.Image.Height / pictureBox.Height;

            return new Point((int)(point.X * pX), (int)(point.Y * pY));
        }

        private void Validate(Bitmap bitmap, Stack<Point> pointStack, int x, int y, Color colorNew, Color colorOld)
        {
            Color cx = bitmap.GetPixel(x, y);
            if(cx == colorOld)
            {
                pointStack.Push(new Point(x, y));
                bitmap.SetPixel(x, y, colorNew);
            }
        }

        public void FillUp(Bitmap bitmap, int x, int y, Color newColor)
        {
            Color oldColor = bitmap.GetPixel(x, y);
            if (oldColor == newColor) return;  

            Stack<Point> pixelStack = new Stack<Point>();
            pixelStack.Push(new Point(x, y));
            bitmap.SetPixel(x, y, newColor);

            while (pixelStack.Count > 0)
            {
                Point point = pixelStack.Pop();
                if (point.X > 0)
                    Validate(bitmap, pixelStack, point.X - 1, point.Y, newColor, oldColor);
                if (point.Y > 0)
                    Validate(bitmap, pixelStack, point.X, point.Y - 1, newColor, oldColor);
                if (point.X < bitmap.Width - 1)
                    Validate(bitmap, pixelStack, point.X + 1, point.Y, newColor, oldColor);
                if (point.Y < bitmap.Height - 1)
                    Validate(bitmap, pixelStack, point.X, point.Y + 1, newColor, oldColor);
            }
        }




        public mainForm()
        {
            InitializeComponent();
            bitmapN = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmapN);
            graphics.Clear(Color.White);
            pictureBox.Image = bitmapN;

        }

        private void btn_width(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (int.TryParse(button.Tag.ToString(), out int width))
            {
                pen.Width = eraser.Width = width;
            }
            else
            {
                MessageBox.Show("Invalid width value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_colorSet_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            colorP = PenColor.BackColor = pen.Color = colorDialog.Color;
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            pointY = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sX = x - cX;
            sY = y - cY;

            if (index == 4)
                graphics.DrawRectangle(pen, cX, cY, sX, sY);
            if (index == 5)
                graphics.DrawLine(pen, cX, cY, x, y);
            if (index == 6)
                graphics.DrawEllipse(pen, cX, cY, x, y);
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = SetPoint(pictureBox, e.Location);
            if (index == 3)
                FillUp(bitmapN, point.X, point.Y, colorP);
        }


        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    pointX = e.Location;
                    graphics.DrawLine(pen, pointX, pointY);
                    pointY = pointX;
                }
                if (index == 2)
                {
                    pointX = e.Location;
                    graphics.DrawLine(eraser, pointX, pointY);
                    pointY = pointX;
                }
            }
            pictureBox.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (int.TryParse(button.Tag.ToString(), out int toolIndex))
            {
                index = toolIndex;
            }
            else
            {
                MessageBox.Show("Invalid tool index value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {

                Graphics graphicsPaint = e.Graphics;
                if (paint)
                {
                    if (index == 4)
                        graphicsPaint.DrawRectangle(pen, cX, cY, sX, sY);
                    if (index == 5)
                        graphicsPaint.DrawLine(pen, cX, cY, x, y);
                    if (index == 6)
                        graphicsPaint.DrawEllipse(pen, cX, cY, x, y);
                }
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Paint 1.0", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            pictureBox.Image = bitmapN;
            pen.Width = eraser.Width = 2;
            index = 1;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.png;)|*.jpg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(open.FileName);
            }    
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files(*.jpg; *.png;)|*.jpg; *.png;";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bitmapN.Clone(new Rectangle(0, 0, pictureBox.Width, pictureBox.Height), bitmapN.PixelFormat);
                btm.Save(saveFile.FileName, ImageFormat.Jpeg);
            }
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
        }
    }
    }

