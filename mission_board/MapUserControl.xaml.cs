using System.Windows.Threading;
using System.Windows.Controls;
using System;
using System.Windows.Interop;
using System.Windows.Forms;

namespace mission_board
{
    /// <summary>
    /// Interaction logic for MapUserControl.xaml
    /// </summary>
    public partial class MapUserControl : System.Windows.Controls.UserControl
    {
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();
        private readonly int threshold = 3 * 60 * 1000;
        private uint ticksSinceLastActivity = 0;
        private const int WM_MOUSEMOVE = 0x0200;

        public MapUserControl()
        {
            InitializeComponent();
            
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        //  Updates the current seconds display and calls
        //  InvalidateRequerySuggested on the CommandManager to force 
        //  the Command to raise the CanExecuteChanged event.
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {

        }

        private void Map_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Escape)
            {
                if (MessageBox.Show("Do you want to exit the application?", "Exit?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
    }
}
