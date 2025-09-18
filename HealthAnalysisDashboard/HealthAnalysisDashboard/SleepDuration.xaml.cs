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

namespace HealthAnalysisDashboard
{
    /// <summary>
    /// Interaction logic for SleepDuration.xaml
    /// </summary>
    public partial class SleepDuration : UserControl
    {
        public SleepDuration()
        {
            InitializeComponent();
            sleepDuration.Data = Geometry.Parse("M0,25.100006L28.5,25.100006 28.5,28.699997 26.299988,28.699997 26.299988,32 24,32 24,28.699997 4.7000122,28.699997 4.7000122,32 2.4000244,32 2.4000244,28.699997 0,28.699997z M5.0999756,8.6000061L23.400024,8.6000061 28.5,22.100006 0,22.100006z M6.4000244,0L22.200012,0 23,5.9000015 5.5,5.9000015z");

        }
    }
    
}