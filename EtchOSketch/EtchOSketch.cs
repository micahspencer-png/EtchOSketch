using System.Windows.Forms;

namespace EtchOSketch
{
    public partial class EtchOSketch : Form
    {
        public EtchOSketch()
        {
            InitializeComponent();
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
        
        }

        private void ClearDrawing() 
        { 
        
        }



        //Event Handlers--------------------------------------------------------------------------------------------------------
        private void SelectColorButton_Click(object sender, EventArgs e)
        {

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
            //this.Text = $"({e.X.ToString()},{e.Y.ToString()} Button: {e.Button})";

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
