using System.Windows.Forms;

namespace EtchOSketch
{
    public partial class EtchOSketch : Form
    {
        public EtchOSketch()
        {
            InitializeComponent();
            PictureBoxSetup();
        }

        int oldX;
        int oldY;
        Color penColor = Color.Black;
        int penWidth = 1;

        //Program Logic---------------------------------------------------------------------------------------------------------

        private void SelectColor() 
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            this.penColor = colorDialog1.Color;
        }

        private void DrawWaveform() 
        { 
        
        }

        private void Sketch(int x, int y) 
        { 
            Graphics g = DisplayPictureBox.CreateGraphics();
            Pen thePen = new Pen(this.penColor, this.penWidth);

            g.DrawLine(thePen, this.oldX, this.oldY, x, y);
            this.oldX = x;
            this.oldY = y;

            g.Dispose();
            thePen.Dispose();
        }

        private void ClearDrawing() 
        {
            for (int i = 0; i < 10; i++) 
            {
                int xOffset = 100;
                int yOffset = 100;
                int y = this.Top;
                int x = this.Left;

                y = y + yOffset;
                x = x + xOffset;

                System.Threading.Thread.Sleep(100);

                xOffset *= -1;
                yOffset *= -1;
            }
            DisplayPictureBox.Invalidate();
        }

        void PictureBoxSetup() 
        {
            Bitmap bmp = new Bitmap(DisplayPictureBox.Width, DisplayPictureBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
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
            ClearDrawing();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GraphicsDesign_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Left)
            {
                Sketch(e.X, e.Y);
            }
            this.oldX = e.X;
            this.oldY = e.Y;

            if (e.Button == MouseButtons.Middle)
            {
                SelectColor();
            }
            
        }
      
    }
}
