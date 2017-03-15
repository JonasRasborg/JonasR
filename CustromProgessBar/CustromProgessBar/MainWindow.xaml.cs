using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Timers;

namespace CustromProgessBar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Timer aTimer;
        private int E;
        public MainWindow()
        {
            InitializeComponent();
            progressBar.Value = 0;
            


            aTimer = new Timer();
            aTimer.Interval = 100;
            aTimer.Elapsed += timer_Tick;
            aTimer.Start();

        }

        void timer_Tick(object sender, EventArgs e)
        {
            E++;
            if (E == 60)
            {
                aTimer.Stop();
                aTimer.Start();
                E = 0;
            }
            Dispatcher.Invoke(new Action(() => progressBar.Value = E));
            
        }
    }
}
