using OATControl.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace OATControl
{
    /// <summary>
    /// Interaction logic for Visualization.xaml
    /// </summary>
    public partial class OATVisualization : Window
    {
        public OATVisualization()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Settings.Default.MiniControllerPos = new System.Drawing.Point((int)this.Left, (int)this.Top);
            base.OnClosing(e);
        }
    }
}
