using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace RobotFormsLib
{
    public class Robot
    {
        private const int MOUSEEVENTF_MOVE = 0x0001; /* mouse move */
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        private const int MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008; /* right button down */
        private const int MOUSEEVENTF_RIGHTUP = 0x0010; /* right button up */
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020; /* middle button down */
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040; /* middle button up */


        static bool stop;
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(IntPtr hWnd);


        public static Bitmap Screenshot()
        {
            Size size = new Size((int)SystemParameters.VirtualScreenWidth, (int)SystemParameters.VirtualScreenHeight);
            Bitmap bitmap = new Bitmap(size.Width, size.Height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(Point.Empty, Point.Empty, size);
            }

            return bitmap;
        }
        public static void MouseLeftDown()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 50, 50, 0, 0);
        }

        public static void MouseLeftUp()
        {
            mouse_event(MOUSEEVENTF_LEFTUP, 50, 50, 0, 0);
        }

        public static void MouseRightDown()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 50, 50, 0, 0);
        }

        public static void MouseRightUp()
        {
            mouse_event(MOUSEEVENTF_RIGHTUP, 50, 50, 0, 0);
        }

        public static void StrzalkaWDol()
        {

            SendKeys.SendWait("{DOWN}");

        }
        public static void Enter()
        {

            SendKeys.SendWait("{ENTER}");

        }

        public static void WpiszZnak(char znak)
        {

            SendKeys.SendWait(znak.ToString());
        }

        public static void Execute(string filePath)
        {
            Process process = new Process();
            process.StartInfo.FileName = filePath;
            process.Start();
        }
    }
}
