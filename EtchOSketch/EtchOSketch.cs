using System.Windows.Forms;

namespace EtchOSketch
{
    //Micah Spencer
    //RCET 2265
    //Fall 2025
    //Etch-O-Sketch Program
    //https://github.com/micahspencer-png/EtchOSketch.git
    public partial class EtchOSketch : Form
    {
        public EtchOSketch()
        {
            InitializeComponent();
            ClearDrawing();
        }

        Color penColor = Color.Black;
        int penWidth = 1;

        bool isDrawing = false;
        Point PreviousPoint;
        bool trueClear = false;
        //Program Logic---------------------------------------------------------------------------------------------------------

        private void SelectColor()
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            this.penColor = colorDialog1.Color;
        }

        private void DrawWaveform()
        {
            int s = 0;
            int c = 1;
            int t = 2;

            Bitmap bmp = new Bitmap(DisplayPictureBox.Width, DisplayPictureBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                g.Dispose();
            }
            DisplayPictureBox.Image = bmp;

            Graphics grid = Graphics.FromImage(DisplayPictureBox.Image);
            Pen thePen = new Pen(this.penColor, this.penWidth);
            Pen Pen1 = new Pen(Color.Red, this.penWidth);
            Pen Pen2 = new Pen(Color.Green, this.penWidth);
            Pen Pen3 = new Pen(Color.Blue, this.penWidth);

            for (int i = 1; i < 10; i++)
            {
                grid.DrawLine(thePen, i * 99, 0, i * 99, 550);
                grid.DrawLine(thePen, 0, i * 56, 990, i * 56);
                DisplayPictureBox.Invalidate();
            }

            WaveShape(s, Pen1);
            WaveShape(c, Pen2);
            WaveShape(t, Pen3);

            grid.Dispose();
            thePen.Dispose();
        }

        private void WaveShape(int waveShape, Pen draw)
        {
            int Amplitude = 275;
            double Frequency = 0.00636;
            int OffsetY = 280;
            string Text = "";
            int height = 0;
            Color color = Color.White;

            Graphics Wave = Graphics.FromImage(DisplayPictureBox.Image);

            PointF[] points = new PointF[DisplayPictureBox.Width];
            for (int x = 0; x < DisplayPictureBox.Width; x++)
            {
                double y = 0;
                if (waveShape == 0)
                {
                    y = Amplitude * Math.Sin(Frequency * x);
                    Text = "Sine Wave";
                    height = 420;
                    color = Color.Red;
                }

                if (waveShape == 1)
                {
                    y = Amplitude * Math.Cos(Frequency * x);
                    Text = "Cosine Wave";
                    height = 445;
                    color = Color.Green;
                }

                if (waveShape == 2)
                {
                    y = Amplitude * Math.Tan(Frequency * x);
                    Text = "Tangent Wave";
                    height = 470;
                    color = Color.Blue;
                }

                points[x] = new PointF(x, (float)(OffsetY - y));
            }

            Wave.DrawLines(draw, points);

            Graphics g = Graphics.FromImage(DisplayPictureBox.Image);
            Pen thePen = new Pen(Color.Cyan, 3);


            Font drawFont = new Font("Times New Roman", 18);
            SolidBrush drawBrush = new SolidBrush(color);

            g.DrawString(Text, drawFont, drawBrush, 0, height);

            g.Dispose();
            drawBrush.Dispose();

            draw.Dispose();
            Wave.Dispose();
        }
        private void Sketch(Point XY)
        {
            Graphics g = Graphics.FromImage(DisplayPictureBox.Image);
            Pen thePen = new Pen(this.penColor, this.penWidth);


            g.DrawLine(thePen, PreviousPoint, XY);
            PreviousPoint = XY;

            DisplayPictureBox.Invalidate();
            g.Dispose();
            thePen.Dispose();
        }

        private void ClearDrawing()
        {
            if (trueClear == true)
            {
                for (int i = 0; i < 10; i++)
                {
                    int xOffset = 10;
                    int yOffset = 10;
                    if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9)
                    {
                        xOffset *= -1;
                        yOffset *= -1;
                    }
                    int y = this.Top;
                    int x = this.Left;
                    int NewY = 0;
                    int NewX = 0;

                    NewY = y + yOffset;
                    NewX = x + xOffset;

                    this.Top = NewY;
                    this.Left = NewX;

                    System.Threading.Thread.Sleep(70);
                }
            }
            Bitmap bmp = new Bitmap(DisplayPictureBox.Width, DisplayPictureBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                g.Dispose();
            }
            DisplayPictureBox.Image = bmp;

        }





        //Event Handlers--------------------------------------------------------------------------------------------------------
        private void SelectColorButton_Click(object sender, EventArgs e)
        {
            SelectColor();
        }

        private void WaveformButton_Click(object sender, EventArgs e)
        {
            DrawWaveform();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            trueClear = true;
            ClearDrawing();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GraphicsDesign_MouseMove(object sender, MouseEventArgs e)
        {


            if (e.Button == MouseButtons.Middle)
            {
                SelectColor();
            }

        }
        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            PreviousPoint = e.Location;
        }

        private void Picture_MouseMovement(object sender, MouseEventArgs e)
        {
            if (isDrawing == true)
            {
                Point XY = e.Location;

                if (e.Button == MouseButtons.Left)
                {
                    Sketch(XY);
                }
            }
            if (e.Button == MouseButtons.Middle)
            {
                SelectColor();
            }
        }

        private void Picture_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Micah Spencer\n    RCET 2265\n    Fall 2025\n    Etch-O-Sketch Program\n    https://github.com/micahspencer-png/EtchOSketch.git");
        }
    }
}
