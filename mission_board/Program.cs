using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mission_board
{
    static class Program
    {
        public static Timer IdleTimer = new Timer();
        private const int idleThresholdTime = 5 * 60 * 1000;
        private static Form1 form;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IdleMessageFilter idleMessageFilter = new IdleMessageFilter();
            Application.AddMessageFilter(idleMessageFilter);
            Application.Idle += new EventHandler(Application_Idle);
            IdleTimer.Interval = idleThresholdTime;
            IdleTimer.Tick += TimeDone;
            IdleTimer.Start();

            Application.Run(new splash_screen());
            form = new Form1();
            Application.Run(form);
        }

        private static void Application_Idle(Object sender, EventArgs e)
        {
            if (!IdleTimer.Enabled)     // not yet idling?
                IdleTimer.Start();
        }

        private static void TimeDone(object sender, EventArgs e)
        {
            IdleTimer.Stop();
            form.CycleMissionary();
            IdleTimer.Start();
        }
    }

    public class IdleMessageFilter : IMessageFilter
    {
        const int WM_NCLBUTTONDOWN = 0x00A1;
        const int WM_NCLBUTTONUP = 0x00A2;
        const int WM_NCRBUTTONDOWN = 0x00A4;
        const int WM_NCRBUTTONUP = 0x00A5;
        const int WM_NCMBUTTONDOWN = 0x00A7;
        const int WM_NCMBUTTONUP = 0x00A8;
        const int WM_NCXBUTTONDOWN = 0x00AB;
        const int WM_NCXBUTTONUP = 0x00AC;
        const int WM_KEYDOWN = 0x0100;
        const int WM_KEYUP = 0x0101;
        const int WM_MOUSEMOVE = 0x0200;
        const int WM_LBUTTONDOWN = 0x0201;
        const int WM_LBUTTONUP = 0x0202;
        const int WM_RBUTTONDOWN = 0x0204;
        const int WM_RBUTTONUP = 0x0205;
        const int WM_MBUTTONDOWN = 0x0207;
        const int WM_MBUTTONUP = 0x0208;
        const int WM_XBUTTONDOWN = 0x020B;
        const int WM_XBUTTONUP = 0x020C;

        // The Messages array must be sorted due to use of Array.BinarySearch
        static int[] Messages = new int[] {WM_NCLBUTTONDOWN,
            WM_NCLBUTTONUP, WM_NCRBUTTONDOWN, WM_NCRBUTTONUP, WM_NCMBUTTONDOWN,
            WM_NCMBUTTONUP, WM_NCXBUTTONDOWN, WM_NCXBUTTONUP, WM_KEYDOWN, WM_KEYUP,
            WM_LBUTTONDOWN, WM_LBUTTONUP, WM_RBUTTONDOWN, WM_RBUTTONUP,
            WM_MBUTTONDOWN, WM_MBUTTONUP, WM_XBUTTONDOWN, WM_XBUTTONUP};

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_MOUSEMOVE)  // mouse move is high volume
                return false;
            if (!Program.IdleTimer.Enabled)     // idling?
                return false;           // No
            if (Array.BinarySearch(Messages, m.Msg) >= 0)
                Program.IdleTimer.Stop();
            return false;
        }
    }
}
