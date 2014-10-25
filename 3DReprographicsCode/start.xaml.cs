using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Microsoft.Samples.Kinect.KinectFusionExplorer
{
    /// <summary>
    /// Interaction logic for start.xaml
    /// </summary>
    public partial class start : Window
    {
        public start()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow repro = new MainWindow();
            repro.Show();
            this.Close();
        }

        private void WindowClosed(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
