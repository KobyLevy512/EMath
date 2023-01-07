
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ConsoleApp3.ExtendMath
{
    public enum PlotStyle
    {
        Points,
        Squares,
        Lines,
        Filled
    }
    internal class Plot
    {
        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        Graphics g,bg;
        Bitmap b = new Bitmap(600, 400);
        Font f = new Font(FontFamily.GenericSerif, 12);
        const double maxRows = 10.42857;
        double maxCols = 100d;
        string format = "0.0000";
        int pointSize = 5;
        public string Format
        {
            get=>format;
            set => format = value;
        }
        public Font Font
        {
            get => f;
            set => f = value;
        }
        public int PointSize
        {
            get => pointSize;
            set
            {
                pointSize = value;
                maxCols = 500d / pointSize;
            }
        }
        public Plot()
        {
            g = Graphics.FromHwnd(GetConsoleWindow());
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            bg = Graphics.FromImage(b);
        }

        public void PlotArray<T>(T[] arr, PlotStyle style = PlotStyle.Points, bool horizontal = true)
        {
            RECT wnd;
            
            GetWindowRect(GetConsoleWindow(), out wnd);
            int width = wnd.Right - wnd.Left;
            int height = wnd.Bottom - wnd.Top;

            SolidBrush sb = new SolidBrush(Color.Black);

            dynamic max = EMath.Max(arr);
            dynamic min = EMath.Min(arr);
            dynamic range = max - min;

            double s = range / maxRows;

            bg.FillRectangle(Brushes.White, 0, 0, b.Width, b.Height);
            bg.DrawRectangle(new Pen(Color.Green, 3), 0, 0, 599, b.Height);
            bg.DrawLine(Pens.Black, 60, 20, 60, 370);
            bg.DrawLine(Pens.Black, 60, 370, 570, 370);

            bg.DrawString(max.ToString(format), f, Brushes.Black, 2, 20);
            max -= s;
            bg.DrawString(max.ToString(format), f, Brushes.Black, 2, 50);
            max -= s;
            bg.DrawString(max.ToString(format), f, Brushes.Black, 2, 80);
            max -= s;
            bg.DrawString(max.ToString(format), f, Brushes.Black, 2, 110);
            max -= s;
            bg.DrawString(max.ToString(format), f, Brushes.Black, 2, 140);
            max -= s;
            bg.DrawString(max.ToString(format), f, Brushes.Black, 2, 170);
            max -= s;
            bg.DrawString(max.ToString(format), f, Brushes.Black, 2, 200);
            max -= s;
            bg.DrawString(max.ToString(format), f, Brushes.Black, 2, 230);
            max -= s;
            bg.DrawString(max.ToString(format), f, Brushes.Black, 2, 260);
            max -= s;
            bg.DrawString(max.ToString(format), f, Brushes.Black, 2, 290);
            max -= s;
            bg.DrawString(max.ToString(format), f, Brushes.Black, 2, 320);
            bg.DrawString(min.ToString(format), f, Brushes.Black, 2, 350);

            if (horizontal)
            {
                switch(style) 
                {
                    case PlotStyle.Points:
                        plotArray1D1(arr, sb);
                        break;
                }
            }

            g.DrawImage(b, width / 2 - b.Width / 2, height / 2 - b.Height / 2);
        }

        void plotArray1D1<T>(T[] arr, SolidBrush sb)
        {
            dynamic max = EMath.Max(arr);
            dynamic min = EMath.Min(arr);
            double avg = EMath.Mean(arr);
            float x = 65;
            double step = arr.Length / maxCols;
            for(double i = 0; i<arr.Length; i+=step)
            {
                dynamic d = arr[(int)i];
                dynamic value = EMath.Remap(d, min, max, 360, 20);
                if(d < avg)
                {
                    bg.FillEllipse(Brushes.Red, x, (float)value, pointSize, pointSize);
                }
                else bg.FillEllipse(Brushes.Green, x, (float)value, pointSize, pointSize);
                x += pointSize;
            }
        }
    }
}
