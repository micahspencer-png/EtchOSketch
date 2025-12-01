namespace EtchOSketch
{
    partial class EtchOSketch
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Clear = new Button();
            ExitButton = new Button();
            SelectColorButton = new Button();
            WaveformButton = new Button();
            MenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            selectColorToolStripMenuItem = new ToolStripMenuItem();
            drawWaveformsToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            editToolStripMenuItem1 = new ToolStripMenuItem();
            selectColorToolStripMenuItem1 = new ToolStripMenuItem();
            drawWaveformsToolStripMenuItem1 = new ToolStripMenuItem();
            clearToolStripMenuItem1 = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            DisplayPictureBox = new PictureBox();
            MenuStrip.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            SuspendLayout();
            // 
            // Clear
            // 
            Clear.Location = new Point(733, 615);
            Clear.Name = "Clear";
            Clear.Size = new Size(146, 61);
            Clear.TabIndex = 2;
            Clear.Text = "&Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(885, 615);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(146, 61);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SelectColorButton
            // 
            SelectColorButton.Location = new Point(429, 615);
            SelectColorButton.Name = "SelectColorButton";
            SelectColorButton.Size = new Size(146, 61);
            SelectColorButton.TabIndex = 0;
            SelectColorButton.Text = "&Select Color";
            SelectColorButton.UseVisualStyleBackColor = true;
            SelectColorButton.Click += SelectColorButton_Click;
            // 
            // WaveformButton
            // 
            WaveformButton.Location = new Point(581, 615);
            WaveformButton.Name = "WaveformButton";
            WaveformButton.Size = new Size(146, 61);
            WaveformButton.TabIndex = 1;
            WaveformButton.Text = "Draw &Waveforms";
            WaveformButton.UseVisualStyleBackColor = true;
            WaveformButton.Click += WaveformButton_Click;
            // 
            // MenuStrip
            // 
            MenuStrip.ImageScalingSize = new Size(20, 20);
            MenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(1043, 28);
            MenuStrip.TabIndex = 4;
            MenuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitButton_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectColorToolStripMenuItem, drawWaveformsToolStripMenuItem, clearToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // selectColorToolStripMenuItem
            // 
            selectColorToolStripMenuItem.Name = "selectColorToolStripMenuItem";
            selectColorToolStripMenuItem.Size = new Size(205, 26);
            selectColorToolStripMenuItem.Text = "Select Color";
            selectColorToolStripMenuItem.Click += SelectColorButton_Click;
            // 
            // drawWaveformsToolStripMenuItem
            // 
            drawWaveformsToolStripMenuItem.Name = "drawWaveformsToolStripMenuItem";
            drawWaveformsToolStripMenuItem.Size = new Size(205, 26);
            drawWaveformsToolStripMenuItem.Text = "Draw Waveforms";
            drawWaveformsToolStripMenuItem.Click += WaveformButton_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(205, 26);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += Clear_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem1, editToolStripMenuItem1, helpToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(111, 76);
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem1 });
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(110, 24);
            fileToolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(116, 26);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += ExitButton_Click;
            // 
            // editToolStripMenuItem1
            // 
            editToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { selectColorToolStripMenuItem1, drawWaveformsToolStripMenuItem1, clearToolStripMenuItem1 });
            editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            editToolStripMenuItem1.Size = new Size(110, 24);
            editToolStripMenuItem1.Text = "Edit";
            // 
            // selectColorToolStripMenuItem1
            // 
            selectColorToolStripMenuItem1.Name = "selectColorToolStripMenuItem1";
            selectColorToolStripMenuItem1.Size = new Size(205, 26);
            selectColorToolStripMenuItem1.Text = "Select Color";
            selectColorToolStripMenuItem1.Click += SelectColorButton_Click;
            // 
            // drawWaveformsToolStripMenuItem1
            // 
            drawWaveformsToolStripMenuItem1.Name = "drawWaveformsToolStripMenuItem1";
            drawWaveformsToolStripMenuItem1.Size = new Size(205, 26);
            drawWaveformsToolStripMenuItem1.Text = "Draw Waveforms";
            drawWaveformsToolStripMenuItem1.Click += WaveformButton_Click;
            // 
            // clearToolStripMenuItem1
            // 
            clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            clearToolStripMenuItem1.Size = new Size(205, 26);
            clearToolStripMenuItem1.Text = "Clear";
            clearToolStripMenuItem1.Click += Clear_Click;
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem1 });
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(110, 24);
            helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(133, 26);
            aboutToolStripMenuItem1.Text = "About";
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.Location = new Point(12, 31);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(1019, 578);
            DisplayPictureBox.TabIndex = 5;
            DisplayPictureBox.TabStop = false;
            // 
            // EtchOSketch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 688);
            Controls.Add(DisplayPictureBox);
            Controls.Add(WaveformButton);
            Controls.Add(ExitButton);
            Controls.Add(SelectColorButton);
            Controls.Add(Clear);
            Controls.Add(MenuStrip);
            MainMenuStrip = MenuStrip;
            Name = "EtchOSketch";
            Text = "EtchOSketch";
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Clear;
        private Button ExitButton;
        private Button SelectColorButton;
        private Button WaveformButton;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem selectColorToolStripMenuItem;
        private ToolStripMenuItem drawWaveformsToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem selectColorToolStripMenuItem1;
        private ToolStripMenuItem drawWaveformsToolStripMenuItem1;
        private ToolStripMenuItem clearToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private PictureBox DisplayPictureBox;
    }
}
