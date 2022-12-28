using Infragistics.Controls.Charts;
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

namespace XamDataChart_DashArray
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new ScatterDataSource();
        }
    }

    public class ScatterDataSource : List<ScatterDataPoint>
    {
        public static Random Rand = new Random();
        public ScatterDataSource()
        {
            int value = 50;
            for (int i = 0; i < 10; i++)
            {
                double change = Rand.NextDouble();
                if (change > .5)
                {
                    value += (int)(change * 20);
                }
                else
                {
                    value -= (int)(change * 20);
                }
                value %= 100;
                this.Add(new ScatterDataPoint
                {
                    X = i,
                    Y = Rand.Next(value - 50, value + 50)
                });
            }
        }
    }

    public class ScatterDataPoint
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

}
