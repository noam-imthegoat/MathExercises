using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
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
        private int ExceriseNumber = 0;
        private int count = 0;

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
            int ans = int.Parse(Answer.Text);
            char charChar = char.Parse(sign.Text);

            int num1a = int.Parse(randomNum1.Text);
            int num2a = int.Parse(randomNum2.Text);
            int savedCount = count;
            int countMistake = 0;

            switch (charChar)
            {
                case '+':
                    if (ans == num1a + num2a)
                        count++;
                    break;

                case '-':
                    if (ans == num1a - num2a)
                        count++;
                    break;

                case '*':
                    if (ans == num1a * num2a)
                        count++;
                    break;

                case '/':
                    if (ans == (double)num1a / num2a)
                        count++;
                    break;
            }
            if (count - 1 == savedCount)
            {
                isCorrect.Text = "CORRECT";
                isCorrect.Visibility = Visibility.Visible;
                contButton.Visibility = Visibility.Visible;
            }
            else
            {
                isCorrect.Text = "WRONG TRY AGAIN";
                isCorrect.Visibility = Visibility.Visible;
                Answer.Text = "";

            }
            if (countMistake >= 3)
                WindowStartupLocation = WindowStartupLocation.CenterScreen;

        }

        private void contButton_Click(object sender, RoutedEventArgs e)
        {
            isCorrect.Visibility = Visibility.Collapsed;
            contButton.Visibility = Visibility.Collapsed;
            Answer.Text = "";
            if (ExceriseNumber >= 10)
                ending();

            else
                startButton_Click(sender, e);
        }



        private void ending()
        {
            mainScreen.Visibility = Visibility.Collapsed;
            exerciseText.Visibility = Visibility.Collapsed;
            exerciseNum.Visibility = Visibility.Collapsed;
            checkButton.Visibility = Visibility.Collapsed;

            grade.Visibility = Visibility.Visible;
            isCorrect.Visibility = Visibility.Collapsed;
            contButton.Visibility = Visibility.Collapsed;
            grade.Text = "הציון שלך הוא " + count * 10;
            restart.Visibility = Visibility.Visible;


        }

        private void restart_Click(object sender, RoutedEventArgs e)
        {
            ExceriseNumber = 0;
            grade.Visibility = Visibility.Collapsed;

            startButton_Click(sender, e);
        }


        // 13/11/26 you were trying to make the "stop after 3 tries" work and u couldnt u failure also for infinite numbers after 0 no worky
    }
}