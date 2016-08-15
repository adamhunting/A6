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

namespace Testing
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

        private void Face_sli_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            SolidColorBrush FaceColor = (SolidColorBrush)this.Resources["FaceColor"];

            if ((Face_RedColor != null) && (Face_GreenColor != null) && (Face_BlueColor != null))
            {
                FaceColor.Color = Color.FromRgb((byte)Face_RedColor.Value, (byte)Face_GreenColor.Value, (byte)Face_BlueColor.Value);
            }

        }

        private void Eye_sli_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            SolidColorBrush EyeColor = (SolidColorBrush)this.Resources["EyeColor"];

            if ((Eye_RedColor != null) && (Eye_GreenColor != null) && (Eye_BlueColor != null))
            {
                EyeColor.Color = Color.FromRgb((byte)Eye_RedColor.Value, (byte)Eye_GreenColor.Value, (byte)Eye_BlueColor.Value);
            }

        }

        private void Other_sli_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            SolidColorBrush OtherColor = (SolidColorBrush)this.Resources["OtherColor"];

            if ((Other_RedColor != null) && (Other_GreenColor != null) && (Other_BlueColor != null))
            {
                OtherColor.Color = Color.FromRgb((byte)Other_RedColor.Value, (byte)Other_GreenColor.Value, (byte)Other_BlueColor.Value);
            }

        }

        private void Nose_sli_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            SolidColorBrush NoseColor = (SolidColorBrush)this.Resources["NoseColor"];

            if ((Nose_RedColor != null) && (Nose_GreenColor != null) && (Nose_BlueColor != null))
            {
                NoseColor.Color = Color.FromRgb((byte)Nose_RedColor.Value, (byte)Nose_GreenColor.Value, (byte)Nose_BlueColor.Value);
            }

        }

        private void Mouth_sli_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {

            SolidColorBrush MouthColor = (SolidColorBrush)this.Resources["MouthColor"];

            if ((Mouth_RedColor != null) && (Mouth_GreenColor != null) && (Mouth_BlueColor != null))
            {
                MouthColor.Color = Color.FromRgb((byte)Mouth_RedColor.Value, (byte)Mouth_GreenColor.Value, (byte)Mouth_BlueColor.Value);
            }

        }
    }
}
