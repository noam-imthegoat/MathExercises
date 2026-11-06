using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MathExercises
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            mainScreen.Visibility = Visibility.Collapsed;
            exerciseText.Visibility = Visibility.Collapsed;
            exerciseNum.Visibility = Visibility.Collapsed;
            checkButton.Visibility = Visibility.Collapsed;
            isCorrect.Visibility = Visibility.Collapsed;
            contButton.Visibility = Visibility.Collapsed;
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            startButton.Visibility = Visibility.Collapsed;
            welcomeText.Visibility = Visibility.Collapsed;

            mainScreen.Visibility = Visibility.Visible;
            exerciseText.Visibility = Visibility.Visible;
            exerciseNum.Visibility = Visibility.Visible;
            checkButton.Visibility = Visibility.Visible;

            int ExceriseNumber = 0;
            int num1 = new Random().Next(1, 11);
            int num2 = new Random().Next(1, 11);
            int randForChar = new Random().Next(4);

            char[] options = { '+', '-', '*', '/' };

            char randChosen = options[randForChar];

            randomNum1.Text = num1.ToString();
            sign.Text = randChosen.ToString();
            randomNum2.Text = num2.ToString();

            ExceriseNumber++;
            exerciseNum.Text = ExceriseNumber.ToString();
        }

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {
            switch
        }
    }
}