using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
 
namespace WindowsInThreads
{
    public partial class WindowsInThreads : Form
    {
        private Graphics[] canvas;
        private Thread[] threads;
        const int COUNT_THREADS = 4;

        public WindowsInThreads()
        {
            InitializeComponent();

            canvas = new Graphics[COUNT_THREADS]
            {
                firstPictureBox.CreateGraphics(), secondPictureBox.CreateGraphics(),
                thirdPictureBox.CreateGraphics(),fourthPictureBox.CreateGraphics()
            };
            threads = new Thread[COUNT_THREADS];
            threads[0] = new Thread(StartDrawingFirst);
            threads[1] = new Thread(StartDrawingSecond);
            threads[2] = new Thread(StartDrawingThird);
            threads[3] = new Thread(StartDrawingFourth);

            for (int i = 0; i < COUNT_THREADS; i++)
            {
                threads[i].Start();
            }
        }
        private void DrawCircleFirst(int x, int y)
        {
            int radius = 40;
            var contourOfShape = new Pen(Color.DarkGoldenrod);
            var colorShape = new SolidBrush(Color.Purple);
            int xCenter = x + radius, yCenter = y + radius;
            canvas[0].FillEllipse(colorShape, xCenter, yCenter, radius, radius);

            canvas[0].DrawEllipse(contourOfShape, xCenter, yCenter, radius, radius);
        }
        private void DrawCircleSecond(int x, int y)
        {
            int radius = 40;
            var contourOfShape = new Pen(Color.DarkGoldenrod);
            var colorShape = new SolidBrush(Color.Purple);
            int xCenter = x + radius, yCenter = y + radius;
            canvas[1].FillEllipse(colorShape, xCenter, yCenter, radius, radius);

            canvas[1].DrawEllipse(contourOfShape, xCenter, yCenter, radius, radius);
        }
        private void DrawCircleThird(int x, int y)
        {
            int radius = 40;
            var contourOfShape = new Pen(Color.DarkGoldenrod);
            var colorShape = new SolidBrush(Color.Purple);
            int xCenter = x + radius, yCenter = y + radius;
            canvas[2].FillEllipse(colorShape, xCenter, yCenter, radius, radius);

            canvas[2].DrawEllipse(contourOfShape, xCenter, yCenter, radius, radius);
        }
        private void DrawCircleFourth(int x, int y)
        {
            int radius = 40;
            var contourOfShape = new Pen(Color.DarkGoldenrod);
            var colorShape = new SolidBrush(Color.Purple);
            int xCenter = x + radius, yCenter = y + radius;
            canvas[3].FillEllipse(colorShape, xCenter, yCenter, radius, radius);

            canvas[3].DrawEllipse(contourOfShape, xCenter, yCenter, radius, radius);
        }
        private void StartDrawingFirst()
        {
            int radius = 40;
            int x, y;
            Random rand = new Random(new DateTime().Millisecond);
            while (true)
            {
                canvas[0].Clear(firstPictureBox.BackColor);
                x = rand.Next(firstPictureBox.Width - radius);
                y = rand.Next(firstPictureBox.Height - radius);
                DrawCircleFirst(x, y);
                Thread.Sleep(230);
            }
        }
        private void StartDrawingSecond()
        {
            int radius = 40;
            int x, y;
            Random rand = new Random(new DateTime().Millisecond);
            while (true)
            {
                canvas[1].Clear(secondPictureBox.BackColor);
                x = rand.Next(secondPictureBox.Width - radius);
                y = rand.Next(secondPictureBox.Height - radius);
                DrawCircleSecond(x, y);
                Thread.Sleep(500);
            }
        }
        private void StartDrawingThird()
        {
            int radius = 40;
            int x, y;
            Random rand = new Random(new DateTime().Millisecond);
            while (true)
            {
                canvas[2].Clear(thirdPictureBox.BackColor);
                x = rand.Next(thirdPictureBox.Width - radius);
                y = rand.Next(thirdPictureBox.Height - radius);
                DrawCircleThird(x, y);
                Thread.Sleep(500);
            }
        }
        private void StartDrawingFourth()
        {
            int radius = 40;
            int x, y;
            Random rand = new Random(new DateTime().Millisecond);
            while (true)
            {
                canvas[3].Clear(fourthPictureBox.BackColor);
                x = rand.Next(fourthPictureBox.Width - radius);
                y = rand.Next(fourthPictureBox.Height - radius);
                DrawCircleFourth(x, y);
                Thread.Sleep(500);
            }
        }

        private void SetEnabledProperty(Button first, Button second)
        {
            first.Enabled = true;
            second.Enabled = false;
        }
        private void firstButtonStartThread_Click(object sender, EventArgs e)
        {
            threads[0].Resume();
            SetEnabledProperty(firstButtonStopThread, firstButtonStartThread);
        }
        private void firstButtonStopThread_Click(object sender, EventArgs e)
        {
            threads[0].Suspend();
            SetEnabledProperty(firstButtonStartThread, firstButtonStopThread);
        }

        private void secondButtonStartThread_Click(object sender, EventArgs e)
        {
            threads[1].Resume();
            SetEnabledProperty(secondButtonStopThread, secondButtonStartThread);
        }

        private void secondButtonStopThread_Click(object sender, EventArgs e)
        {
            threads[1].Suspend();
            SetEnabledProperty(secondButtonStartThread, secondButtonStopThread);
        }

        private void thirdButtonStartThread_Click(object sender, EventArgs e)
        {
            threads[2].Resume();
            SetEnabledProperty(thirdButtonStopThread, thirdButtonStartThread);
        }

        private void thirdButtonStopThread_Click(object sender, EventArgs e)
        {
            threads[2].Suspend();
            SetEnabledProperty(thirdButtonStartThread, thirdButtonStopThread);
        }

        private void fourthButtonStartThread_Click(object sender, EventArgs e)
        {
            threads[3].Resume();
            SetEnabledProperty(fourthButtonStopThread, fourthButtonStartThread);
        }

        private void fourthButtonStopThread_Click(object sender, EventArgs e)
        {
            threads[3].Suspend();
            SetEnabledProperty(fourthButtonStartThread, fourthButtonStopThread);
        }

        private void WindowsInThreads_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < COUNT_THREADS; i++)
            {
                if (threads[i].ThreadState == ThreadState.Suspended)
                {
                    threads[i].Resume();
                }
                threads[i].Abort();
            }
        }
    }
}