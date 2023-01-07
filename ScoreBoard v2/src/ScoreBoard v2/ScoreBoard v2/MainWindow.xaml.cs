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

namespace ScoreBoard_v2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Boolean isRedReversed = false;
        Boolean isBlueReversed = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RedPointGained(object sender, RoutedEventArgs e)
        {

            // Gets String contents of button --> Converts to int --> Adds string casted integer of current score + integer value of button content
            int scoreOfRed = Int32.Parse(RedScoreBox.Text);
            Button button = sender as Button;
            int pointsGained = Int32.Parse(button.Content as string);
            if (isRedReversed) pointsGained *= -1;
            RedScoreBox.Text = (scoreOfRed + pointsGained).ToString();

            LinearGradientBrush gradient = ScoreGradient;
            Point currentPoint = gradient.StartPoint;
            currentPoint.X = currentPoint.X + .1;
            gradient.StartPoint = currentPoint;

        }

        private void BluePointGained(object sender, RoutedEventArgs e)
        {

            // Gets String contents of button --> Converts to int --> Adds string casted integer of current score + integer value of button content
            int scoreOfBlue = Int32.Parse(BlueScoreBox.Text);
            Button button = sender as Button;
            int pointsGained = Int32.Parse(button.Content as string);
            if (isBlueReversed) pointsGained *= -1;
            BlueScoreBox.Text = (scoreOfBlue + pointsGained).ToString();





           LinearGradientBrush gradient = ScoreGradient;
            Point currentPoint = gradient.StartPoint;
            currentPoint.X = currentPoint.X - .1;
           gradient.StartPoint = currentPoint;


            


        }

        private void ReverseRed(object sender, RoutedEventArgs e)
        {
            isRedReversed = !isRedReversed;
        }

        private void BlueReversed(object sender, RoutedEventArgs e)
        {
            isBlueReversed = !isBlueReversed;
        }
    }
}
