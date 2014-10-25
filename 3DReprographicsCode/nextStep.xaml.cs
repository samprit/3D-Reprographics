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
using System.Diagnostics;

namespace Microsoft.Samples.Kinect.KinectFusionExplorer
{
    /// <summary>
    /// Interaction logic for nextStep.xaml
    /// </summary>
    public partial class nextStep : Window
    {
        public nextStep()
        {
            InitializeComponent();
            fileName = "";
            meshlab = 0;
        }

        public string fileName;
        public int meshlab;

        private void Step1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow repro = new MainWindow();
            repro.Show();
            this.Close();
        }

        private void Step2_Click(object sender, RoutedEventArgs e)
        {

            //fileName = "C:\\Users\\samprit\\Desktop\\sam.stl";
            View_Click(sender, e);

            meshlab++;

            string outputFileName="";
            Step2.Style = this.Resources["Step1Button"] as Style;

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "Meshlab\\meshlabserver.exe";

            if(meshlab == 1 && fileName!="")
            {
                outputFileName = fileName.Substring(0, fileName.Length - 4) + "_output" + fileName.Substring(fileName.Length - 4);
                startInfo.Arguments = " -i " + fileName + " -o " + outputFileName + " -s MeshlabSteps\\fullsteps.mlx";
                var process = Process.Start(startInfo);
                process.WaitForExit();
            }
            

            fileName = outputFileName;

        }

        private void Step3_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.FileName = "C:\\Users\\samprit\\Desktop\\acads-computer science\\BTP\\Final Software\\Slic3r\\slic3r.exe";
            startInfo.FileName = "Slic3r\\slic3r.exe";
            var process = Process.Start(startInfo);
            process.WaitForExit();

            Step3.Style = this.Resources["Step1Button"] as Style;
            this.Cursor = Cursors.Arrow;
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "Meshlab\\meshlab.exe";
            startInfo.Arguments = fileName;
            var process = Process.Start(startInfo);
            this.Hide();
            process.WaitForExit();
            this.Show();
            this.Cursor = Cursors.Arrow;
        }
    }
}
