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

namespace WpfAppRGBSliders
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void RSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var brush = new SolidColorBrush(Color.FromArgb(255, (byte)RSlider.Value, (byte)GSlider.Value, (byte)BSlider.Value));
            mijnGrid.Background = brush;
            RLabel_Copy.Content = Convert.ToString(Math.Round(RSlider.Value));
        }

        private void GSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var brush = new SolidColorBrush(Color.FromArgb(255, (byte)RSlider.Value, (byte)GSlider.Value, (byte)BSlider.Value));
            mijnGrid.Background = brush;
            GLabel_Copy.Content = Convert.ToString(Math.Round(GSlider.Value));
        }

        private void BSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var brush = new SolidColorBrush(Color.FromArgb(255, (byte)RSlider.Value, (byte)GSlider.Value, (byte)BSlider.Value));
            mijnGrid.Background = brush;
            BLabel_Copy.Content = Convert.ToString(Math.Round(BSlider.Value));
        }
    }
}
